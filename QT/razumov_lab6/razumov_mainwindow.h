#ifndef RAZUMOV_MAINWINDOW_H
#define RAZUMOV_MAINWINDOW_H

#include <QMainWindow>
#include "razumov_form2.h"

namespace Ui {
class razumov_MainWindow;
}

class razumov_MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit razumov_MainWindow(QWidget *parent = nullptr);
    ~razumov_MainWindow();

private:
    Ui::razumov_MainWindow *ui;
    razumov_Form2 *myform2;

signals:
    void sendData(QString str);

private slots:
    void onButtonSend();

    void on_pushButtonDone_clicked();
    void on_pushButtonUpload_clicked();
};

#endif // RAZUMOV_MAINWINDOW_H
