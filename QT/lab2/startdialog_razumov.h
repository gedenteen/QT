#ifndef STARTDIALOG_RAZUMOV_H
#define STARTDIALOG_RAZUMOV_H

#include <QWidget>
#include <QPushButton>
#include <QMessageBox>
#include "inputdialog_razumov.h"

class StartDIalog_Razumov: public QPushButton {
    Q_OBJECT

public:
    StartDIalog_Razumov(QWidget* pwgt = 0) : QPushButton("Нажми на эту кнопку", pwgt)
    {
        connect(this, SIGNAL(clicked()), SLOT(slotButtonClicked()));
    }

public slots:
    void slotButtonClicked() {
        InputDialog_Razumov* pInputDialog = new InputDialog_Razumov;
        if (pInputDialog->exec() == QDialog::Accepted) {
            QMessageBox::information(0,
                                     "Ваша инофрмация: ",
                                     "Имя: "
                                     + pInputDialog->firstName()
                                     + "\nФамилия: "
                                     + pInputDialog->lastName()
                                     );
        }
        delete pInputDialog;
    }
};

#endif // STARTDIALOG_RAZUMOV_H
