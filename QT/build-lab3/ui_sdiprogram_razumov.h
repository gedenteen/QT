/********************************************************************************
** Form generated from reading UI file 'sdiprogram_razumov.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SDIPROGRAM_RAZUMOV_H
#define UI_SDIPROGRAM_RAZUMOV_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_SDIProgram_Razumov
{
public:
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QWidget *centralWidget;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *SDIProgram_Razumov)
    {
        if (SDIProgram_Razumov->objectName().isEmpty())
            SDIProgram_Razumov->setObjectName(QString::fromUtf8("SDIProgram_Razumov"));
        SDIProgram_Razumov->resize(400, 300);
        menuBar = new QMenuBar(SDIProgram_Razumov);
        menuBar->setObjectName(QString::fromUtf8("menuBar"));
        SDIProgram_Razumov->setMenuBar(menuBar);
        mainToolBar = new QToolBar(SDIProgram_Razumov);
        mainToolBar->setObjectName(QString::fromUtf8("mainToolBar"));
        SDIProgram_Razumov->addToolBar(mainToolBar);
        centralWidget = new QWidget(SDIProgram_Razumov);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        SDIProgram_Razumov->setCentralWidget(centralWidget);
        statusBar = new QStatusBar(SDIProgram_Razumov);
        statusBar->setObjectName(QString::fromUtf8("statusBar"));
        SDIProgram_Razumov->setStatusBar(statusBar);

        retranslateUi(SDIProgram_Razumov);

        QMetaObject::connectSlotsByName(SDIProgram_Razumov);
    } // setupUi

    void retranslateUi(QMainWindow *SDIProgram_Razumov)
    {
        SDIProgram_Razumov->setWindowTitle(QApplication::translate("SDIProgram_Razumov", "SDIProgram_Razumov", nullptr));
    } // retranslateUi

};

namespace Ui {
    class SDIProgram_Razumov: public Ui_SDIProgram_Razumov {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SDIPROGRAM_RAZUMOV_H
