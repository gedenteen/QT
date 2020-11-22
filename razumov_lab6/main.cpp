#include "razumov_mainwindow.h"
#include <QApplication>
#include <QFile>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QFile file(":/style.css"); //подключение style.css
    file.open(QFile::ReadOnly); //
    a.setStyleSheet(file.readAll()); //к QApplication
    file.close();

    razumov_MainWindow w;
    w.show();

    return a.exec();
}
