#ifndef INPUTDIALOG_RAZUMOV_H
#define INPUTDIALOG_RAZUMOV_H

#include <QDialog>
#include <QLineEdit>

class QLineEdit;

class InputDialog_Razumov: public QDialog {
    Q_OBJECT
private:
    QLineEdit* m_ptxtFirstName;
    QLineEdit* m_ptxtLastName;
public:
    InputDialog_Razumov(QWidget* pwgt = 0);
    QString firstName() const;
    QString lastName() const;
};

#endif // INPUTDIALOG_RAZUMOV_H
