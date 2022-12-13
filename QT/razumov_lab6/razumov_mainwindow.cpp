#include "razumov_mainwindow.h"
#include "ui_razumov_mainwindow.h"
#include <QFileDialog>

razumov_MainWindow::razumov_MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::razumov_MainWindow)
{
    ui->setupUi(this);
    myform2 = new razumov_Form2();
    connect(ui->pushButtonDone, SIGNAL(clicked()), myform2, SLOT(show()));
    connect(ui->pushButtonDone, SIGNAL(clicked()), this, SLOT(onButtonSend()));
    connect(this, SIGNAL(sendData(QString)), myform2, SLOT(receiveData(QString))); //17 task

//    QFile file(":/style.css"); //подключение style.css
//    file.open(QFile::ReadOnly); //
//    myform2->setStyleSheet(file.readAll()); //к QApplication
//    file.close();
}

razumov_MainWindow::~razumov_MainWindow()
{
    delete ui;
}

void razumov_MainWindow::onButtonSend() {
    //sendData();
}

void razumov_MainWindow::on_pushButtonDone_clicked() { //12-14 tasks
    QString str = ui->lineEditFileName->text() + "*" +
                  "ФИО: " + ui->lineEditName->text() + "\n" +
                  "Должность: " + ui->lineEditPosition->text() + "\n" +
                  "Дата рождения: " + ui->dateEditBirthday->text() + "\n" +
                  "Email: " + ui->lineEditEmail->text() + "\n";
    if (ui->radioButtonMale->isChecked() == true)
        str += "пол: мужской";
    else
        str += "пол: женский";
    emit sendData(str);
}

void razumov_MainWindow::on_pushButtonUpload_clicked() {
    QString filename = QFileDialog::getOpenFileName(0, "Выберите изображение",
                                                        QDir::currentPath(),
                                                        "*.png *.jpg *.gif");
        ui->lineEditFileName->setText(filename);
        QImage image1(filename);
        ui->labelPhoto->setPixmap(QPixmap::fromImage(image1));
}
