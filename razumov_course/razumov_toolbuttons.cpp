#include "razumov_mainwindow.h"
#include "ui_razumov_mainwindow.h"

void razumov_MainWindow::initToolButtons()
{
    ///------ ШАБЛОНЫ ЗАПИСЕЙ ---------///
    QAction* tempJourney = new QAction("Путешествие", this);
    tempJourney->setText("Путешествие");
    tempJourney->setStatusTip("Подготовить запись о путешествии");
    connect(tempJourney, &QAction::triggered, [=]{this->useTempalate(1);});
    ui->toolButton_Templates->addAction(tempJourney);
    QAction* tempCall = new QAction("Звонок", this);
    tempCall->setText("Звонок");
    tempCall->setStatusTip("Подготовить запись о предстоящем звонке");
    connect(tempCall, &QAction::triggered, [=]{this->useTempalate(2);});
    ui->toolButton_Templates->addAction(tempCall);
    QAction* tempRecipe = new QAction("Рецепт", this);
    tempRecipe->setText("Рецепт");
    tempRecipe->setStatusTip("Подготовить запись о кулинраном рецепте");
    connect(tempRecipe, &QAction::triggered, [=]{this->useTempalate(3);});
    ui->toolButton_Templates->addAction(tempRecipe);
    QAction* tempBusiness = new QAction("Дела", this);
    tempBusiness->setText("Дела");
    tempBusiness->setStatusTip("Подготовить запись о делах на день");
    connect(tempBusiness, &QAction::triggered, [=]{this->useTempalate(4);});
    ui->toolButton_Templates->addAction(tempBusiness);
    ///------ ДОБАВЛЕНИЕ HTML ---------///
    QAction* actAddBold = new QAction("Жирный текст", this);
    actAddBold->setText("Жирный текст");
    actAddBold->setStatusTip("Добавить в текст записи теги для жирного текста");
    connect(actAddBold, &QAction::triggered, [=]{this->addHTML(1);});
    ui->toolButton_AddHTML->addAction(actAddBold);
    QAction* actAddItalic = new QAction("Наклонный текст", this);
    actAddItalic->setText("Наклонный текст");
    actAddItalic->setStatusTip("Добавить в текст записи теги для наклонного текста");
    connect(actAddItalic, &QAction::triggered, [=]{this->addHTML(2);});
    ui->toolButton_AddHTML->addAction(actAddItalic);
    QAction* actAddNewline = new QAction("Перевод строки", this);
    actAddNewline->setText("Перевод строки");
    actAddNewline->setStatusTip("Добавить в текст записи тег перевода строки");
    connect(actAddNewline, &QAction::triggered, [=]{this->addHTML(3);});
    ui->toolButton_AddHTML->addAction(actAddNewline);
    QAction* actAddImage = new QAction("Изображение", this);
    actAddImage->setText("Изображение");
    actAddImage->setStatusTip("Добавить в текст записи тег для отображения изображения");
    connect(actAddImage, &QAction::triggered, [=]{this->addHTML(4);});
    ui->toolButton_AddHTML->addAction(actAddImage);
}

void razumov_MainWindow::useTempalate(int type)
{
    textWithoutFormatting = 1;
    if (type == 1) {
        ui->lineEdit_Title->setText("Путешествие в...");
        ui->textEdit_Record->setPlainText("<b>Дата:</b> <br>"
                                          "<b>Страна:</b> <br>"
                                          "<b>Участники:</b> ");
        ui->lineEdit_Hashtags->setText("#путешествие");
    }
    else if (type == 2) {
        ui->lineEdit_Title->setText("Позвонить...");
        ui->textEdit_Record->setPlainText("<b>Кому:</b> <br>"
                                          "<b>Телефон:</b> <br>"
                                          "<b>Тема разговора:</b> ");
        ui->lineEdit_Hashtags->setText("#звонок");
    }
    else if (type == 3) {
        ui->lineEdit_Title->setText("Рецепт...");
        ui->textEdit_Record->setPlainText("<b>Ингридиенты:</b> <br>"
                                          "<b>Что и как делать:</b> ");
        ui->lineEdit_Hashtags->setText("#рецепт");
    }
    else {
        ui->lineEdit_Title->setText("План на день");
        ui->textEdit_Record->setPlainText("1. <br>"
                                          "2. <br>"
                                          "3. ");
        ui->lineEdit_Hashtags->setText("#дела");
    }
    on_pushButton_ApplyFormatting_clicked();
}

void razumov_MainWindow::addHTML(int type)
{
    QString text = ui->textEdit_Record->toPlainText();
    if (type == 1) {
        ui->textEdit_Record->setPlainText(text + "<b></b>");
    }
    else if (type == 2) {
        ui->textEdit_Record->setPlainText(text + "<i></i>");
    }
    else if (type == 3) {
        ui->textEdit_Record->setPlainText(text + "<br>");
    }
    else {
        ui->textEdit_Record->setPlainText(text +
                "<img src=\"путь к файлу\" alt=\"альтернативный текст\">");
    }
}
