#ifndef DOCWINDOW_RAZUMOV_H
#define DOCWINDOW_RAZUMOV_H

#include <QTextEdit>
#include <QFileDialog> //оно нужно?
#include <QTextStream>

class DocWindow_Razumov : public QTextEdit
{
    Q_OBJECT
private:
    QString m_strFileName;

public:
    //explicit DocWindow_Razumov(QWidget *parent = nullptr);
    DocWindow_Razumov(QWidget* pwgt = 0);

signals:
    void changeWindowTitle(const QString&);

public slots:
    void slotLoad();
    void slotSave();
    void slotSaveAs();
    void slotColor();
};

#endif // DOCWINDOW_RAZUMOV_H
