/********************************************************************************
** Form generated from reading UI file 'razumov_form2.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_RAZUMOV_FORM2_H
#define UI_RAZUMOV_FORM2_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialogButtonBox>
#include <QtWidgets/QLabel>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_razumov_Form2
{
public:
    QTextEdit *textEdit;
    QDialogButtonBox *buttonBox;
    QLabel *label;
    QLabel *labelPhoto;

    void setupUi(QWidget *razumov_Form2)
    {
        if (razumov_Form2->objectName().isEmpty())
            razumov_Form2->setObjectName(QString::fromUtf8("razumov_Form2"));
        razumov_Form2->resize(811, 403);
        textEdit = new QTextEdit(razumov_Form2);
        textEdit->setObjectName(QString::fromUtf8("textEdit"));
        textEdit->setGeometry(QRect(10, 60, 371, 281));
        buttonBox = new QDialogButtonBox(razumov_Form2);
        buttonBox->setObjectName(QString::fromUtf8("buttonBox"));
        buttonBox->setGeometry(QRect(560, 350, 221, 31));
        QFont font;
        font.setPointSize(13);
        buttonBox->setFont(font);
        buttonBox->setStandardButtons(QDialogButtonBox::Open|QDialogButtonBox::Reset|QDialogButtonBox::Save);
        label = new QLabel(razumov_Form2);
        label->setObjectName(QString::fromUtf8("label"));
        label->setGeometry(QRect(10, 10, 171, 41));
        labelPhoto = new QLabel(razumov_Form2);
        labelPhoto->setObjectName(QString::fromUtf8("labelPhoto"));
        labelPhoto->setGeometry(QRect(400, 60, 391, 281));
        labelPhoto->setFrameShape(QFrame::Panel);
        labelPhoto->setAlignment(Qt::AlignCenter);

        retranslateUi(razumov_Form2);

        QMetaObject::connectSlotsByName(razumov_Form2);
    } // setupUi

    void retranslateUi(QWidget *razumov_Form2)
    {
        razumov_Form2->setWindowTitle(QApplication::translate("razumov_Form2", "\320\237\320\276\320\273\321\203\321\207\320\265\320\275\320\275\321\213\320\265 \320\264\320\260\320\275\320\275\321\213\320\265 (\320\260\320\262\321\202\320\276\321\200 \320\240\320\260\320\267\321\203\320\274\320\276\320\262)", nullptr));
        label->setText(QApplication::translate("razumov_Form2", "\320\237\320\276\320\273\321\203\321\207\320\265\320\275\320\275\321\213\320\265 \320\264\320\260\320\275\320\275\321\213\320\265:", nullptr));
        labelPhoto->setText(QApplication::translate("razumov_Form2", "TextLabel", nullptr));
    } // retranslateUi

};

namespace Ui {
    class razumov_Form2: public Ui_razumov_Form2 {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_RAZUMOV_FORM2_H
