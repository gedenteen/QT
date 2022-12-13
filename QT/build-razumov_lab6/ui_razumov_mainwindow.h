/********************************************************************************
** Form generated from reading UI file 'razumov_mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_RAZUMOV_MAINWINDOW_H
#define UI_RAZUMOV_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDateEdit>
#include <QtWidgets/QFormLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_razumov_MainWindow
{
public:
    QWidget *centralWidget;
    QWidget *formLayoutWidget;
    QFormLayout *formLayout;
    QLabel *labelFullname;
    QLineEdit *lineEditName;
    QLabel *labelPosition;
    QLineEdit *lineEditPosition;
    QLabel *labelBirthday;
    QDateEdit *dateEditBirthday;
    QLabel *labelGender;
    QRadioButton *radioButtonMale;
    QRadioButton *radioButtonFemale;
    QLabel *labelEmail;
    QLineEdit *lineEditEmail;
    QLabel *labelPhoto;
    QPushButton *pushButtonUpload;
    QPushButton *pushButtonDone;
    QLineEdit *lineEditFileName;
    QLabel *labelFileName;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *razumov_MainWindow)
    {
        if (razumov_MainWindow->objectName().isEmpty())
            razumov_MainWindow->setObjectName(QString::fromUtf8("razumov_MainWindow"));
        razumov_MainWindow->setEnabled(true);
        razumov_MainWindow->resize(659, 380);
        centralWidget = new QWidget(razumov_MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        formLayoutWidget = new QWidget(centralWidget);
        formLayoutWidget->setObjectName(QString::fromUtf8("formLayoutWidget"));
        formLayoutWidget->setGeometry(QRect(10, 10, 451, 211));
        formLayout = new QFormLayout(formLayoutWidget);
        formLayout->setSpacing(6);
        formLayout->setContentsMargins(11, 11, 11, 11);
        formLayout->setObjectName(QString::fromUtf8("formLayout"));
        formLayout->setLabelAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);
        formLayout->setContentsMargins(0, 0, 0, 0);
        labelFullname = new QLabel(formLayoutWidget);
        labelFullname->setObjectName(QString::fromUtf8("labelFullname"));

        formLayout->setWidget(0, QFormLayout::LabelRole, labelFullname);

        lineEditName = new QLineEdit(formLayoutWidget);
        lineEditName->setObjectName(QString::fromUtf8("lineEditName"));
        lineEditName->setMinimumSize(QSize(0, 30));

        formLayout->setWidget(0, QFormLayout::FieldRole, lineEditName);

        labelPosition = new QLabel(formLayoutWidget);
        labelPosition->setObjectName(QString::fromUtf8("labelPosition"));

        formLayout->setWidget(1, QFormLayout::LabelRole, labelPosition);

        lineEditPosition = new QLineEdit(formLayoutWidget);
        lineEditPosition->setObjectName(QString::fromUtf8("lineEditPosition"));
        lineEditPosition->setMinimumSize(QSize(0, 30));

        formLayout->setWidget(1, QFormLayout::FieldRole, lineEditPosition);

        labelBirthday = new QLabel(formLayoutWidget);
        labelBirthday->setObjectName(QString::fromUtf8("labelBirthday"));

        formLayout->setWidget(2, QFormLayout::LabelRole, labelBirthday);

        dateEditBirthday = new QDateEdit(formLayoutWidget);
        dateEditBirthday->setObjectName(QString::fromUtf8("dateEditBirthday"));
        QSizePolicy sizePolicy(QSizePolicy::Minimum, QSizePolicy::Minimum);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(dateEditBirthday->sizePolicy().hasHeightForWidth());
        dateEditBirthday->setSizePolicy(sizePolicy);
        dateEditBirthday->setMinimumSize(QSize(0, 30));
        dateEditBirthday->setTabletTracking(true);

        formLayout->setWidget(2, QFormLayout::FieldRole, dateEditBirthday);

        labelGender = new QLabel(formLayoutWidget);
        labelGender->setObjectName(QString::fromUtf8("labelGender"));

        formLayout->setWidget(3, QFormLayout::LabelRole, labelGender);

        radioButtonMale = new QRadioButton(formLayoutWidget);
        radioButtonMale->setObjectName(QString::fromUtf8("radioButtonMale"));

        formLayout->setWidget(3, QFormLayout::FieldRole, radioButtonMale);

        radioButtonFemale = new QRadioButton(formLayoutWidget);
        radioButtonFemale->setObjectName(QString::fromUtf8("radioButtonFemale"));

        formLayout->setWidget(4, QFormLayout::FieldRole, radioButtonFemale);

        labelEmail = new QLabel(formLayoutWidget);
        labelEmail->setObjectName(QString::fromUtf8("labelEmail"));

        formLayout->setWidget(6, QFormLayout::LabelRole, labelEmail);

        lineEditEmail = new QLineEdit(formLayoutWidget);
        lineEditEmail->setObjectName(QString::fromUtf8("lineEditEmail"));
        lineEditEmail->setMinimumSize(QSize(0, 30));

        formLayout->setWidget(6, QFormLayout::FieldRole, lineEditEmail);

        labelPhoto = new QLabel(centralWidget);
        labelPhoto->setObjectName(QString::fromUtf8("labelPhoto"));
        labelPhoto->setGeometry(QRect(480, 10, 151, 201));
        labelPhoto->setFrameShape(QFrame::Panel);
        labelPhoto->setAlignment(Qt::AlignCenter);
        pushButtonUpload = new QPushButton(centralWidget);
        pushButtonUpload->setObjectName(QString::fromUtf8("pushButtonUpload"));
        pushButtonUpload->setGeometry(QRect(480, 220, 151, 41));
        pushButtonDone = new QPushButton(centralWidget);
        pushButtonDone->setObjectName(QString::fromUtf8("pushButtonDone"));
        pushButtonDone->setGeometry(QRect(480, 270, 151, 41));
        lineEditFileName = new QLineEdit(centralWidget);
        lineEditFileName->setObjectName(QString::fromUtf8("lineEditFileName"));
        lineEditFileName->setGeometry(QRect(10, 280, 451, 31));
        lineEditFileName->setMinimumSize(QSize(0, 30));
        labelFileName = new QLabel(centralWidget);
        labelFileName->setObjectName(QString::fromUtf8("labelFileName"));
        labelFileName->setGeometry(QRect(210, 250, 251, 29));
        razumov_MainWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(razumov_MainWindow);
        menuBar->setObjectName(QString::fromUtf8("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 659, 22));
        razumov_MainWindow->setMenuBar(menuBar);
        mainToolBar = new QToolBar(razumov_MainWindow);
        mainToolBar->setObjectName(QString::fromUtf8("mainToolBar"));
        mainToolBar->setEnabled(false);
        mainToolBar->setMovable(true);
        razumov_MainWindow->addToolBar(Qt::TopToolBarArea, mainToolBar);
        statusBar = new QStatusBar(razumov_MainWindow);
        statusBar->setObjectName(QString::fromUtf8("statusBar"));
        razumov_MainWindow->setStatusBar(statusBar);

        retranslateUi(razumov_MainWindow);

        QMetaObject::connectSlotsByName(razumov_MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *razumov_MainWindow)
    {
        razumov_MainWindow->setWindowTitle(QApplication::translate("razumov_MainWindow", "\320\241\320\276\320\267\320\264\320\260\320\275\320\270\320\265 \320\264\320\260\320\275\320\275\321\213\321\205 (\320\260\320\262\321\202\320\276\321\200 \320\240\320\260\320\267\321\203\320\274\320\276\320\262)", nullptr));
        labelFullname->setText(QApplication::translate("razumov_MainWindow", "\320\244\320\230\320\236", nullptr));
        labelPosition->setText(QApplication::translate("razumov_MainWindow", "\320\224\320\276\320\273\320\266\320\275\320\276\321\201\321\202\321\214", nullptr));
        labelBirthday->setText(QApplication::translate("razumov_MainWindow", "\320\224\320\260\321\202\320\260 \321\200\320\276\320\266\320\264\320\265\320\275\320\270\321\217", nullptr));
        labelGender->setText(QApplication::translate("razumov_MainWindow", "\320\237\320\276\320\273", nullptr));
        radioButtonMale->setText(QApplication::translate("razumov_MainWindow", "\320\234\321\203\320\266\321\201\320\272\320\276\320\271", nullptr));
        radioButtonFemale->setText(QApplication::translate("razumov_MainWindow", "\320\226\320\265\320\275\321\201\320\272\320\270\320\271", nullptr));
        labelEmail->setText(QApplication::translate("razumov_MainWindow", "\320\255\320\273\320\265\320\272\321\202\321\200\320\276\320\275\320\275\320\260\321\217 \320\277\320\276\321\207\321\202\320\260", nullptr));
        labelPhoto->setText(QApplication::translate("razumov_MainWindow", "\320\244\320\276\321\202\320\276", nullptr));
        pushButtonUpload->setText(QApplication::translate("razumov_MainWindow", "\320\227\320\260\320\263\321\200\321\203\320\267\320\270\321\202\321\214\n"
" \321\204\320\276\321\202\320\276", nullptr));
        pushButtonDone->setText(QApplication::translate("razumov_MainWindow", "\320\223\320\276\321\202\320\276\320\262\320\276", nullptr));
        labelFileName->setText(QApplication::translate("razumov_MainWindow", "\320\237\320\276\320\273\320\275\320\276\320\265 \320\270\320\274\321\217 \321\204\320\260\320\271\320\273\320\260 \321\204\320\276\321\202\320\276\320\263\321\200\320\260\321\204\320\270\320\270:", nullptr));
    } // retranslateUi

};

namespace Ui {
    class razumov_MainWindow: public Ui_razumov_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_RAZUMOV_MAINWINDOW_H
