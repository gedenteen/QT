#include "win_ok.h"
#include "ui_win_ok.h"

win_ok::win_ok(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::win_ok)
{
    ui->setupUi(this);
}

win_ok::~win_ok()
{
    delete ui;
}
