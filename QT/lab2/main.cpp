#include "mainwindow.h"
#include "startdialog_razumov.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    StartDIalog_Razumov startDialogR;
    startDialogR.show();

    return a.exec();
}
