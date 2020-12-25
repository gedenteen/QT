#ifndef RAZUMOV_MOVEITEM_H
#define RAZUMOV_MOVEITEM_H

#include <QObject>
#include <QGraphicsItem>
#include <QPainter>
#include <QGraphicsSceneMouseEvent>
#include <QDebug>
#include <QCursor>
#include <QThread>
#include <QList>

///--- MoveGardenBed ---/// класс для грядок
class MoveGardenBed : public QObject, public QGraphicsItem
{
    Q_OBJECT
public:
    explicit MoveGardenBed(QObject *parent = nullptr);
    ~MoveGardenBed();

public:
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
    void mouseMoveEvent(QGraphicsSceneMouseEvent *event);
    void mousePressEvent(QGraphicsSceneMouseEvent *event);
    void mouseReleaseEvent(QGraphicsSceneMouseEvent *event);
};

///--- MoveTomato ---/// класс для помидоров
class MoveTomato : public MoveGardenBed
{
    Q_OBJECT
public:
    explicit MoveTomato(QObject *parent = nullptr);
    ~MoveTomato();

private:
    //переопределяемые методы:
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
};

///--- MoveCarrot ---/// класс для морковок
class MoveCarrot : public MoveGardenBed
{
    Q_OBJECT
public:
    explicit MoveCarrot(QObject *parent = nullptr);
    ~MoveCarrot();

private:
    //переопределяемые методы:
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
};

///--- MoveSunflower ---/// класс для подсолнухов
class MoveSunflower : public MoveGardenBed
{
    Q_OBJECT
public:
    explicit MoveSunflower(QObject *parent = nullptr);
    ~MoveSunflower();

private:
    //переопределяемые методы:
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
};

///--- MoveCrow ---/// класс для вороны
class MoveCrow : public MoveGardenBed
{
    Q_OBJECT
public:
    explicit MoveCrow(QObject *parent = nullptr);
    ~MoveCrow();

public slots:
    void flying_crow(); //слот для автопередвижения вороны

private:
    qreal valueX; //координаты изображения вороны
    qreal valueY; //qreal для setPos(mapToScene())
    char imgDirection;
    //переопределяемые методы:
    void mouseMoveEvent(QGraphicsSceneMouseEvent *event);
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
};

#endif // RAZUMOV_MOVEITEM_H
