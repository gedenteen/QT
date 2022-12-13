#ifndef RAZUMOV_FORM2_H
#define RAZUMOV_FORM2_H

#include <QWidget>
#include <QAbstractButton>
#include <QFile>
#include <QFileDialog>

namespace Ui {
class razumov_Form2;
}

class razumov_Form2 : public QWidget
{
    Q_OBJECT

public:
    explicit razumov_Form2(QWidget *parent = nullptr);
    ~razumov_Form2();

private:
    Ui::razumov_Form2 *ui;

public slots:
    void receiveData(QString str); //16 task
//private slots:
    void on_buttonBox_clicked(QAbstractButton *button);
};

#endif // RAZUMOV_FORM2_H
