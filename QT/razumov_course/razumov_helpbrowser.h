#ifndef RAZUMOV_HELPBROWSER_H
#define RAZUMOV_HELPBROWSER_H

#include <QWidget>
#include <QTextBrowser>
#include <QPushButton>
#include <QLayout>

class razumov_HelpBrowser : public QWidget
{
    Q_OBJECT

public:
    razumov_HelpBrowser(const QString &path, const QString &page,
                QWidget *parent = nullptr);

    static void showPage(const QString &page);

private slots:
    void updateWindowTitle();

private:
    QTextBrowser *textBrowser;
    QPushButton *homeButton;
    QPushButton *backButton;
    QPushButton *closeButton;
};

#endif // RAZUMOV_HELPBROWSER_H
