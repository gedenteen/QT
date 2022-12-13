#include "razumov_mainwindow.h"
#include "ui_razumov_mainwindow.h"
//#include "razumov_calendar.h"

razumov_MainWindow::razumov_MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::razumov_MainWindow)
{
    ui->setupUi(this);
    ///база данных:
    fileDB = "database.sqlite";
    openFileDB();
    ///календарь:
    calendar = new CalendarTableModel(this);
    ui->tableView->setModel(calendar);
    for (int i = 0; i < 7; i++)
        ui->tableView->horizontalHeader()->setSectionResizeMode(i, QHeaderView::Stretch);
    changeDateByButtons(0, 0); //добавить комментарий
    ///кнопки "Шаблоны" и "Добавить"
    initToolButtons();
    ///меню:
    addMainMenu();
    ///установить светлую тему:
    slotLightTheme();
    ///добавить иконку:
    QIcon iconHome(":/home.png");
    ui->pushButton_Home->setIcon(iconHome);
    ///заблокировать поиск:
    ui->pushButton_Search->setDisabled(true);
}

razumov_MainWindow::~razumov_MainWindow()
{
    delete ui;
}

void razumov_MainWindow::openFileDB()
{
    db = QSqlDatabase::addDatabase("QSQLITE");
    db.setDatabaseName(fileDB);
    if (!db.open()) {
        statusBar()->showMessage("Ошибка: не удается открыть файл с базой данных");
    }
    QSqlQuery qry;
    QString str = "CREATE TABLE records ("
                  "_id INTEGER PRIMARY KEY AUTOINCREMENT,"
                  "year INTEGER,"
                  "month INTEGER,"
                  "day INTEGER,"
                  "title TEXT,"
                  "text TEXT,"
                  "hashtags TEXT);";
    bool b = qry.exec(str);
    if (!b) {
        this->statusBar()->showMessage("База данных и таблица успешно открыты");
    }
    else {
        this->statusBar()->showMessage("Создана новая таблица для текущей базы данных");
    }
}

void razumov_MainWindow::changeDateByButtons(int changeMonth, int changeYear)
{ //функция, которая меняет месяц или год календаря
    calendar->changeDate(changeMonth, changeYear);
    int month = -100, year = -100;
    calendar->getYearAndMonth(year, month);
    QString month_name = "";
    switch (month) {
    case 1:
        month_name = "январь"; break;
    case 2:
        month_name = "февраль"; break;
    case 3:
        month_name = "март"; break;
    case 4:
        month_name = "апрель"; break;
    case 5:
        month_name = "май"; break;
    case 6:
        month_name = "июнь"; break;
    case 7:
        month_name = "июль"; break;
    case 8:
        month_name = "август"; break;
    case 9:
        month_name = "сентябрь"; break;
    case 10:
        month_name = "октябрь"; break;
    case 11:
        month_name = "ноябрь"; break;
    case 12:
        month_name = "декабрь"; break;
    default:
        statusBar()->showMessage("Ошибка: получен неправильный номер месяца");
    }
    ui->label_Month->setText(month_name);
    ui->label_Year->setText(QString::number(year));
}

void razumov_MainWindow::on_tableView_clicked(const QModelIndex &index)
{
    int row = index.row();
    int column = index.column();
    calendar->setChosenDay(index.sibling(row, column).data().toInt());
    showRecordsInChosenDay();
}

void razumov_MainWindow::hideRecordEdit()
{
    //скрыть все виджеты, которые нужны для изменения записи:
    ui->lineEdit_Title->clear();
    ui->lineEdit_Title->hide();
    ui->textEdit_Record->clear();
    ui->textEdit_Record->hide();
    ui->lineEdit_Hashtags->clear();
    ui->lineEdit_Hashtags->hide();
    ui->label_Title->hide();
    ui->label_Text->hide();
    ui->label_Hashtags->hide();
    //заблокировать кнопки, чтобы случайно ничего не изменить:
    ui->pushButton_AddRecord->setDisabled(true);
    ui->pushButton_DelRecord->setDisabled(true);
    ui->pushButton_ApplyFormatting->setDisabled(true);
    ui->toolButton_Templates->setDisabled(true);
    ui->toolButton_AddHTML->setDisabled(true);
    //разблокировать поиск:
    ui->pushButton_Search->setEnabled(true);
    //удалить кнопки, оставшиеся с другого дня:
    while( this->buttonsForDeletion.empty() == 0) {
        QPushButton *button = this->buttonsForDeletion.back();
        button->deleteLater();
        this->buttonsForDeletion.pop_back();
    }
}

void razumov_MainWindow::showRecordsInChosenDay()
{
    hideRecordEdit();
    //получить выбранную дату на календаре:
    int year, month, day;
    calendar->getChosenDate(year, month, day);
    QString str = "SELECT * FROM records "
                  "WHERE year = " + QString::number(year) + " AND "
                  "month = " + QString::number(month) + " AND "
                  "day = " + QString::number(day) + ";";
    //сделать запрос к базе данных:
    QSqlQuery qry;
    if (!qry.exec(str)) {
        this->statusBar()->showMessage("Ошибка: не удалось сделать запрос к базе данных");
    }
    QSqlRecord rec = qry.record();
    //добавить кнопки по полученным записям:
    while (qry.next()) { //если есть >= 1 запись
        QString title = qry.value(rec.indexOf("title")).toString();
        int id = qry.value(rec.indexOf("_id")).toInt();
        QPushButton *button = new QPushButton(title, this);
        //изменить свойства кнопки:
        QFont font = button->font();
        font.setBold(true);
        font.setPixelSize(20);
        button->setFont(font);
        button->setMaximumHeight(50);
        button->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Maximum);
        //добавить кнопку:
        ui->verticalLayout->addWidget(button);
        //использовать лямбда-функцию для передачи параметра в слот:
        connect(button, &QPushButton::clicked, [=]{
            this->returnRecordEdit(id);
        });
        //добавить кнопку в массив, чтобы потом ее удалить:
        this->buttonsForDeletion.push_back(button);
    }
    //добавить кнопку для создания новой записи:
    QPushButton *button = new QPushButton("Новая запись", this);
    //изменить свойства кнопки:
    QFont font = button->font();
    font.setPixelSize(20);
    button->setFont(font);
    button->setMaximumHeight(50);
    button->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Maximum);
    //добавить кнопку:
    ui->verticalLayout->addWidget(button);
    //использовать лямбда-функцию для передачи параметра в слот:
    connect(button, &QPushButton::clicked, [=]{
        this->returnRecordEdit(-1);
    });
    //добавить кнопку в массив, чтобы потом ее удалить:
    this->buttonsForDeletion.push_back(button);
}

void razumov_MainWindow::returnRecordEdit(int id)
{
    ///удалить кнопки в gridLayout_Right:
    while(this->buttonsForDeletion.empty() == 0) {
        QPushButton *button = this->buttonsForDeletion.back();
        button->deleteLater();
        this->buttonsForDeletion.pop_back();
    }
    ///и верни поля для записи
    ui->lineEdit_Title->show();
    ui->textEdit_Record->show();
    ui->lineEdit_Hashtags->show();
    ui->label_Title->show();
    ui->label_Text->show();
    ui->label_Hashtags->show();
    //разблокировать кнопки:
    ui->pushButton_AddRecord->setEnabled(true);
    ui->pushButton_DelRecord->setEnabled(true);
    ui->pushButton_ApplyFormatting->setEnabled(true);
    ui->toolButton_Templates->setEnabled(true);
    ui->toolButton_AddHTML->setEnabled(true);
    //запретить поиск:
    ui->pushButton_Search->setDisabled(true);
    ///обозначить текущий id (для кнопки "Сохранить запись"):
    currentId = id;
    ///запрос:
    QString str = "SELECT * FROM records "
                  "WHERE _id = " + QString::number(id) + ";";
    ///сделать запрос к базе данных:
    QSqlQuery qry;
    if (!qry.exec(str)) {
        this->statusBar()->showMessage("Ошибка: не удалось сделать запрос к базе данных");
    }
    QSqlRecord rec = qry.record();
    QString title, text, hashtags;
    if (qry.next()) {
        title = qry.value(rec.indexOf("title")).toString();
        text = qry.value(rec.indexOf("text")).toString();
        hashtags = qry.value(rec.indexOf("hashtags")).toString();
        ui->lineEdit_Title->setText(title);
        ui->textEdit_Record->setPlainText(text);
        ui->lineEdit_Hashtags->setText(hashtags);
    }
    if (id == -1) { //если новая запись
        textWithoutFormatting = 0;
        textForRecord = "";
    }
    else {
        textWithoutFormatting = 1; //сейчас текст без форматирования
        textForRecord = text; //подготовить текст без форматирования
    }
    on_pushButton_ApplyFormatting_clicked(); //показать текст записи с форматированием
}

