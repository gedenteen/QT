#ifndef SDIPROGRAM_RAZUMOV_H
#define SDIPROGRAM_RAZUMOV_H

#include <QMainWindow>
#include <QtWidgets>
#include "docwindow_razumov.h"
//#include "sdiprogram_razumov.h"

namespace Ui {
class SDIProgram_Razumov;
}

class SDIProgram_Razumov : public QMainWindow
{
    Q_OBJECT

public:
    SDIProgram_Razumov(QWidget *pwgt = 0): QMainWindow(pwgt) {
        QMenu* pmnuFile = new QMenu("&File");
        QMenu* pmnuHelp = new QMenu("&Help");
        DocWindow_Razumov* pdoc = new DocWindow_Razumov;
        pmnuFile->addAction("&Open...",
                            pdoc,
                            SLOT(slotLoad()),
                            QKeySequence("CTRL+O")
                            ); //15p
        pmnuFile->addAction("&Save",
                            pdoc,
                            SLOT(slotSave()),
                            QKeySequence("CTRL+S")
                            );
        pmnuFile->addAction("&SaveAs",
                            pdoc,
                            SLOT(slotSaveAs()),
                            QKeySequence("CTRL+P")
                            );
        pmnuFile->addAction("&Color",
                            pdoc,
                            SLOT(slotColor())
                            ); //24p
        pmnuFile->addAction("&Quit",
                            qApp,
                            SLOT(quit()),
                            QKeySequence("CTRL+Q")
                            );

        pmnuHelp->addAction("&About",
                            this,
                            SLOT(slotAbout()),
                            Qt::Key_F1
                            ); //16p

        menuBar()->addMenu(pmnuFile);
        menuBar()->addMenu(pmnuHelp); //17p

        setCentralWidget(pdoc); //18p

        connect(pdoc,
                SIGNAL(changeWindowTitle(const QString&)),
                SLOT(slotChangeWindowTitle(const QString&))
                ); //19p

        statusBar()->showMessage("Ready", 2000); //20p

    }
    //explicit SDIProgram_Razumov(QWidget *parent = nullptr);
    ~SDIProgram_Razumov();

public slots:
    void slotAbout() {
        QMessageBox::about(this, "About", "Данная программа - простейший текстовый "
                                          "редактор. Сделано студентом Разумовым "
                                          "Дмитрием, группа ИП-811."); //23p
    }

    void slotChangeWindowTitle(const QString& str) {
        setWindowTitle(str);
    } //21p

private:
    Ui::SDIProgram_Razumov *ui;
};

#endif // SDIPROGRAM_RAZUMOV_H
