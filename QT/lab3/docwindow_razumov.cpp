#include "docwindow_razumov.h"
#include "win_ok.h"

DocWindow_Razumov::DocWindow_Razumov(QWidget *pwgt) : QTextEdit(pwgt)
{

}

void DocWindow_Razumov::slotLoad() {
    QString str = QFileDialog::getOpenFileName();
    if (str.isEmpty()) {
        return;
    }

    QFile file(str);
    if(file.open(QIODevice::ReadOnly)) {
        QTextStream stream(&file);
        setPlainText(stream.readAll());
        file.close();
    }

    m_strFileName = str;
    emit changeWindowTitle(m_strFileName);
}

void DocWindow_Razumov::slotSaveAs() {
    QString str = QFileDialog::getSaveFileName(0, m_strFileName);
    if (!str.isEmpty()) {
        m_strFileName = str;
        slotSave();
    }
}

void DocWindow_Razumov::slotSave() {
    if(m_strFileName.isEmpty()) {
        slotSaveAs();
        return;
    }

    QFile file(m_strFileName);
    if (file.open(QIODevice::WriteOnly)) {
        QTextStream(&file)<<toPlainText();
    }

    file.close(); //12p
    emit changeWindowTitle(m_strFileName);

    win_ok *dg = new win_ok(); //13p
    dg->show();
}

int currentColor = 1;
void DocWindow_Razumov::slotColor() {
    if (currentColor == 1) {
        setTextColor(QColor(255,0,0));
        currentColor = 2;
    }
    else {
        setTextColor(QColor(0,0,0));
        currentColor = 1;
    }
} //24p
