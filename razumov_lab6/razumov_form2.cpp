#include "razumov_form2.h"
#include "ui_razumov_form2.h"

razumov_Form2::razumov_Form2(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::razumov_Form2)
{
    ui->setupUi(this);
}

razumov_Form2::~razumov_Form2()
{
    delete ui;
}

void razumov_Form2::receiveData(QString str) { //16 task
    QStringList lst = str.split("*");
    ui->textEdit->setText(lst.at(1)+"\n"+lst.at(0));
    if (lst.size()>1) {
        QImage image1(lst.at(0));
        ui->labelPhoto->setPixmap(QPixmap::fromImage(image1));
    }
}

void on_buttonBox_clicked(QAbstractButton *button) {

}

void razumov_Form2::on_buttonBox_clicked(QAbstractButton *button)
{
    if (button->text() == "Reset") {
        ui->textEdit->clear();
        ui->labelPhoto->clear();
    }
    else if (button->text() == "&Save") {
        QString filename = QFileDialog::getSaveFileName(0,
            "Сохранить файл", QDir::currentPath(), "*.cpp *.txt *.c");
        QFile file(filename);
        file.open(QIODevice::WriteOnly);
        file.write(ui->textEdit->toPlainText().toUtf8());
        file.close();
    }
    else {
        QString filename = QFileDialog::getOpenFileName(0,
            "Открыть файл", QDir::currentPath(), "*.cpp *.txt *.c");
        QFile file(filename);
        if (file.open(QIODevice::ReadOnly | QIODevice::Text))
            ui->textEdit->setPlainText(file.readAll());

        QStringList inf = ui->textEdit->toPlainText().split("\n");
        QImage image2(inf.at(5));
        ui->labelPhoto->setPixmap(QPixmap::fromImage(image2));
    }
}
