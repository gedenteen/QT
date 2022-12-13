#include "auth.h"
#include "ui_auth.h"

auth::auth(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::auth)
{
    ui->setupUi(this);
    //ui->labela->addAction(QIcon(":imgcat/5b8lPMWCKgo.jpg"));
    ui->label_2->setStyleSheet("background-color: rgb(220, 220, 0)");
}

auth::~auth()
{
    delete ui;
}
