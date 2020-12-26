#include "razumov_mainwindow.h"
#include "ui_razumov_mainwindow.h"

void razumov_MainWindow::addMainMenu()
{
    QMenu* pmnuFile = new QMenu("&Файл");
    QMenu* pmnuSettings = new QMenu("&Настройки");
    QMenu* pmnuHelp = new QMenu("&Помощь");
    pmnuFile->addAction("Открыть",
                        this,
                        SLOT(slotLoad()));
    pmnuFile->addAction("Сохранить",
                        this,
                        SLOT(slotSave()),
                        QKeySequence("CTRL+S")
                        );
    pmnuFile->addAction("Сохранить как",
                        this,
                        SLOT(slotSaveAs()));
    pmnuFile->addAction("Выгрузить в txt-файл",
                        this,
                        SLOT(slotUploadToTxt()));
    pmnuFile->addAction("Выход",
                        qApp,
                        SLOT(quit()));
    pmnuSettings->addAction("Светлая тема",
                            this,
                            SLOT(slotLightTheme()));
    pmnuSettings->addAction("Темная тема",
                            this,
                            SLOT(slotDarkTheme()));
    pmnuHelp->addAction("Справка",
                        this,
                        SLOT(slotAbout()),
                        Qt::Key_F1
                        );

    menuBar()->addMenu(pmnuFile);
    menuBar()->addMenu(pmnuSettings);
    menuBar()->addMenu(pmnuHelp);
}

void razumov_MainWindow::slotLoad()
{
    QString str = QFileDialog::getOpenFileName(
                nullptr, "Открыть файл", QDir::currentPath(), "*.sqlite *.db");
    if (str.isEmpty()) {
        return;
    }
    fileDB = str;
    openFileDB();
}

void razumov_MainWindow::slotSave()
{
    on_pushButton_AddRecord_clicked();
}

void razumov_MainWindow::slotSaveAs()
{
    QString newFileName = QFileDialog::getSaveFileName(
                nullptr, "Сохранить как", QDir::currentPath(), "*.sqlite *.db");
    if (newFileName.isEmpty()) {
        qDebug() << "Пустое имя файла в slotSaveAs()";
        return;
    }

    QFile::copy(fileDB, newFileName);
}

void razumov_MainWindow::slotUploadToTxt()
{
    QString fileName = QFileDialog::getSaveFileName(
                nullptr, "Сохранить как", QDir::currentPath(), "*.txt");
    if (fileName.isEmpty()) {
        qDebug() << "Пустое имя файла в slotUploadToTxt()";
        return;
    }
    QFile file(fileName);
    if (file.open(QFile::WriteOnly)) { //открыть файл
        QTextStream fout(&file); //создать поток файла
        QString str = "SELECT * FROM records ;";
        QSqlQuery qry;
        if (!qry.exec(str)) {
            this->statusBar()->showMessage("Ошибка: не удалось сделать запрос к базе данных");
        }
        QSqlRecord rec = qry.record();
        while (qry.next()) {
            int year = qry.value(rec.indexOf("year")).toInt();
            int month = qry.value(rec.indexOf("month")).toInt();
            int day = qry.value(rec.indexOf("day")).toInt();
            QString title = qry.value(rec.indexOf("title")).toString();
            QString text = qry.value(rec.indexOf("text")).toString();
            QString hashtags = qry.value(rec.indexOf("hashtags")).toString();
            fout << "\n  date: " << day << "." << month << "." << year << "\n";
            fout << "\nTitle: " << title << "\n";
            fout << "\nText: " << text << "\n";
            fout << "\nHashtags: " << hashtags << "\n";
        }
    }
    this->statusBar()->showMessage("База данных успешно выгружена в " + fileName);
}

void razumov_MainWindow::slotLightTheme()
{
    calendar->colorTheme = 'L';
    QFile file(":/style_light.css"); //подключение *.css
    file.open(QFile::ReadOnly);
    this->setStyleSheet(file.readAll()); //к QApplication
}

void razumov_MainWindow::slotDarkTheme()
{
    calendar->colorTheme = 'D';
    QFile file(":/style_dark.css"); //подключение *.css
    file.open(QFile::ReadOnly);
    this->setStyleSheet(file.readAll()); //к QApplication
}

void razumov_MainWindow::slotAbout()
{
    razumov_HelpBrowser::showPage("index.html");
}
