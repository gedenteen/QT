#ifndef RAZUMOV_WIDGET_H
#define RAZUMOV_WIDGET_H

#include <QWidget>
#include <QGraphicsScene>

#include "razumov_moveitem.h"

namespace Ui {
class razumov_Widget;
}

class razumov_Widget : public QWidget
{
    Q_OBJECT

public:
    explicit razumov_Widget(QWidget *parent = nullptr);
    ~razumov_Widget(); 

private:
    Ui::razumov_Widget *ui;
    QGraphicsScene *scene;
};

#endif // RAZUMOV_WIDGET_H
