#include "razumov_mainwindow.h"
#include "ui_razumov_mainwindow.h"

void razumov_MainWindow::on_pushButton_Search_clicked()
{
    hideRecordEdit();
    ///получить выбранную дату на календаре:
    int year, month, day;
    calendar->getChosenDate(year, month, day);
    QString strSearch = ui->lineEdit_Search->text();
    QString str = "SELECT * FROM records "
                  "WHERE (year = " + QString::number(year) + " AND "
                  "month = " + QString::number(month) + " AND "
                  "day = " + QString::number(day) + ") AND "
                  "(title LIKE '%" + strSearch + "%' OR "
                  "text LIKE '%" + strSearch + "%' OR "
                  "hashtags LIKE '%" + strSearch + "%');";
    ///сделать запрос к базе данных:
    QSqlQuery qry;
    if (!qry.exec(str)) {
        this->statusBar()->showMessage("Ошибка: неправильный запрос в on_pushButton_Search_clicked()");
    }
    QSqlRecord rec = qry.record();
    int count = 0; //кол-во записей
    ///добавить кнопки по полученным записям:
    while (qry.next()) { //если есть >= 1 запись
        count++;
        QString title = qry.value(rec.indexOf("title")).toString();
        int id = qry.value(rec.indexOf("_id")).toInt();
        QPushButton *button = new QPushButton(title, this);
        //изменить свойства кнопки:
        QFont font = button->font();
        font.setBold(true);
        font.setPixelSize(20);
        button->setFont(font);
        button->setMaximumHeight(50);
        button->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
        //добавить кнопку:
        ui->verticalLayout->addWidget(button);
        ///использовать лямбда-функцию для передачи параметра в слот:
        connect(button, &QPushButton::clicked, [=]{
            this->returnRecordEdit(id);
        });
        ///добавить кнопку в массив, чтобы потом ее удалить:
        this->buttonsForDeletion.push_back(button);
    }
    this->statusBar()->showMessage("Записей найдено: " + QString::number(count));
}

void razumov_MainWindow::on_pushButton_DelRecord_clicked()
{
    if (currentId != -1) {
        QString str = "DELETE FROM records "
                      "WHERE _id = " + QString::number(currentId) + ";";
        ///сделать запрос к базе данных:
        QSqlQuery qry;
        if (!qry.exec(str)) {
            this->statusBar()->showMessage("Не удалось сделать запрос на удаление "
                                           "в on_pushButton_AddRecord_clicked()");
        }
    }
    showRecordsInChosenDay();
    this->statusBar()->showMessage("Запись успешно удалена");
}

void razumov_MainWindow::on_pushButton_AddRecord_clicked()
{
    ///переменные:
    QString str, str_insert;
    int year = 0, month = 0, day = 0;
    QString title, text, hashtags;
    ///если изменяется существующая запись:
    //qDebug() << "currentID = " << currentId;
    if (currentId != -1) {
        str = "DELETE FROM records "
                      "WHERE _id = " + QString::number(currentId) + ";";
        ///сделать запрос к базе данных:
        QSqlQuery qry;
        if (!qry.exec(str)) {
            this->statusBar()->showMessage("Не удалось сделать запрос на удаление "
                                           "в on_pushButton_AddRecord_clicked()");
        }
    }
    ///получить данные о дне записи из календаря:
    calendar->getChosenDate(year, month, day);
    ///получить заголовок, текст и хэштеги:
    title = ui->lineEdit_Title->text();
    text = textWithoutFormatting ? ui->textEdit_Record->toPlainText() : textForRecord;
    hashtags = ui->lineEdit_Hashtags->text();
    ///запрос на добавление записи:
    str_insert = "INSERT INTO records("
                 "year, month, day, title, text, hashtags) "
                 "VALUES (%1, %2, %3, '%4', '%5', '%6');";
    str = str_insert.arg(year)
                    .arg(month)
                    .arg(day)
                    .arg(title)
                    .arg(text)
                    .arg(hashtags);
    QSqlQuery qry;
    bool b = qry.exec(str);
    if (!b) {
        statusBar()->showMessage("Ошибка: запись не добавлена в базу данных!");
    }
    else {
        statusBar()->showMessage("Запись успешно сохранена в базу данных");
    }
    ///получить новый ID новой записи, чтобы можно было удалить ее
    ///иначе будут дубликаты записи при нескольких сохранениях
    str = "SELECT * FROM records "
          "WHERE (year = " + QString::number(year) + " AND "
          "month = " + QString::number(month) + " AND "
          "day = " + QString::number(day) + ") AND "
          "(title LIKE '" + title + "' AND "
          "text LIKE '" + text + "' AND "
          "hashtags LIKE '" + hashtags + "');";
    if (!qry.exec(str)) {
        this->statusBar()->showMessage("Ошибка: в функции on_pushButton_AddRecord_clicked()");
    }
    QSqlRecord rec = qry.record();
    ///добавить кнопки по полученным записям:
    if (qry.size() == 0) {
        this->statusBar()->showMessage("Ошибка: в функции on_pushButton_AddRecord_clicked()");
        return;
    }
    if (qry.next()) { //если есть >= 1 запись
        int id = qry.value(rec.indexOf("_id")).toInt();
        currentId = id;
    }
}

void razumov_MainWindow::on_pushButton_ApplyFormatting_clicked()
{
    if (textWithoutFormatting == 1) {
        textForRecord = ui->textEdit_Record->toPlainText();
        ui->textEdit_Record->setHtml(textForRecord);
        ui->textEdit_Record->setReadOnly(1);
        textWithoutFormatting = 0;
    }
    else {
        ui->textEdit_Record->clear();
        ui->textEdit_Record->setPlainText(textForRecord);
        ui->textEdit_Record->setReadOnly(0);
        textWithoutFormatting = 1;
    };
}

void razumov_MainWindow::on_pushButton_Home_clicked()
{
    QDate curDate = QDate::currentDate();
    int curYear = curDate.year();
    int curMonth = curDate.month();
    int chosenYear,chosenMonth;
    calendar->getYearAndMonth(chosenYear, chosenMonth);
    changeDateByButtons(curMonth - chosenMonth,
                        curYear - chosenYear); //месяц, потом год
}

void razumov_MainWindow::on_pushButton_PrevMonth_clicked()
{
    changeDateByButtons(-1, 0);
}

void razumov_MainWindow::on_pushButton_NextMonth_clicked()
{
    changeDateByButtons(1, 0);
}

void razumov_MainWindow::on_pushButton_PrevYear_clicked()
{
    changeDateByButtons(0, -1);
}

void razumov_MainWindow::on_pushButton_NextYear_clicked()
{
    changeDateByButtons(0, 1);
}
