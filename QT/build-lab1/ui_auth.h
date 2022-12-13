/********************************************************************************
** Form generated from reading UI file 'auth.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_AUTH_H
#define UI_AUTH_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_auth
{
public:
    QWidget *centralwidget;
    QLabel *label;
    QLabel *label_2;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *auth)
    {
        if (auth->objectName().isEmpty())
            auth->setObjectName(QString::fromUtf8("auth"));
        auth->resize(550, 399);
        centralwidget = new QWidget(auth);
        centralwidget->setObjectName(QString::fromUtf8("centralwidget"));
        label = new QLabel(centralwidget);
        label->setObjectName(QString::fromUtf8("label"));
        label->setGeometry(QRect(0, 0, 551, 351));
        label->setPixmap(QPixmap(QString::fromUtf8(":/imgcat2/5b8lPMWCKgo.jpg")));
        label_2 = new QLabel(centralwidget);
        label_2->setObjectName(QString::fromUtf8("label_2"));
        label_2->setGeometry(QRect(200, 20, 241, 51));
        QFont font;
        font.setPointSize(13);
        label_2->setFont(font);
        label_2->setFocusPolicy(Qt::TabFocus);
        label_2->setAutoFillBackground(true);
        auth->setCentralWidget(centralwidget);
        menubar = new QMenuBar(auth);
        menubar->setObjectName(QString::fromUtf8("menubar"));
        menubar->setGeometry(QRect(0, 0, 550, 22));
        auth->setMenuBar(menubar);
        statusbar = new QStatusBar(auth);
        statusbar->setObjectName(QString::fromUtf8("statusbar"));
        auth->setStatusBar(statusbar);

        retranslateUi(auth);

        QMetaObject::connectSlotsByName(auth);
    } // setupUi

    void retranslateUi(QMainWindow *auth)
    {
        auth->setWindowTitle(QApplication::translate("auth", "\320\236\320\261 \320\260\320\262\321\202\320\276\321\200\320\265", nullptr));
        label->setText(QString());
        label_2->setText(QApplication::translate("auth", "<html><head/><body><p align=\"center\">\320\220\320\262\321\202\320\276\321\200 - \320\240\320\260\320\267\321\203\320\274\320\276\320\262 \320\224\320\274\320\270\321\202\321\200\320\270\320\271, <br/>\320\263\321\200\321\203\320\277\320\277\320\260 \320\230\320\237-811</p></body></html>", nullptr));
    } // retranslateUi

};

namespace Ui {
    class auth: public Ui_auth {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_AUTH_H
