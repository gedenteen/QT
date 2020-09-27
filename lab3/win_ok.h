#ifndef WIN_OK_H
#define WIN_OK_H

#include <QDialog>

namespace Ui {
class win_ok;
}

class win_ok : public QDialog
{
    Q_OBJECT

public:
    explicit win_ok(QWidget *parent = nullptr);
    ~win_ok();

private:
    Ui::win_ok *ui;
};

#endif // WIN_OK_H
