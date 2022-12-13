/********************************************************************************
** Form generated from reading UI file 'win_ok.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_WIN_OK_H
#define UI_WIN_OK_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QDialogButtonBox>
#include <QtWidgets/QLabel>

QT_BEGIN_NAMESPACE

class Ui_win_ok
{
public:
    QDialogButtonBox *buttonBox;
    QLabel *label;

    void setupUi(QDialog *win_ok)
    {
        if (win_ok->objectName().isEmpty())
            win_ok->setObjectName(QString::fromUtf8("win_ok"));
        win_ok->resize(240, 107);
        buttonBox = new QDialogButtonBox(win_ok);
        buttonBox->setObjectName(QString::fromUtf8("buttonBox"));
        buttonBox->setGeometry(QRect(10, 50, 201, 41));
        buttonBox->setOrientation(Qt::Horizontal);
        buttonBox->setStandardButtons(QDialogButtonBox::Cancel|QDialogButtonBox::Ok);
        label = new QLabel(win_ok);
        label->setObjectName(QString::fromUtf8("label"));
        label->setGeometry(QRect(30, 10, 181, 41));

        retranslateUi(win_ok);
        QObject::connect(buttonBox, SIGNAL(accepted()), win_ok, SLOT(accept()));
        QObject::connect(buttonBox, SIGNAL(rejected()), win_ok, SLOT(reject()));

        QMetaObject::connectSlotsByName(win_ok);
    } // setupUi

    void retranslateUi(QDialog *win_ok)
    {
        win_ok->setWindowTitle(QApplication::translate("win_ok", "Dialog", nullptr));
        label->setText(QApplication::translate("win_ok", "\320\244\320\260\320\271\320\273 \321\201\320\276\321\205\321\200\320\260\320\275\320\265\320\275", nullptr));
    } // retranslateUi

};

namespace Ui {
    class win_ok: public Ui_win_ok {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_WIN_OK_H
