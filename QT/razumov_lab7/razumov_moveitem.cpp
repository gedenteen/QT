#include "razumov_moveitem.h"

///--- MoveGardenBed ---/// класс для грядок
MoveGardenBed::MoveGardenBed(QObject *parent) :
    QObject(parent), QGraphicsItem() {}

MoveGardenBed::~MoveGardenBed() {}

QRectF MoveGardenBed::boundingRect() const
{
    //создание прямоугольника, который ограничивает изображение,
    //координаты от центра изображения:
    return QRectF (-200, -10, 400, 100);
}

void MoveGardenBed::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    //границы:
    painter->setPen(QPen(QColor::fromRgbF(0.7, 0.5, 0, 1), 3));
    //заливка:
    painter->setBrush(QBrush(QColor::fromRgbF(0.7, 0.5, 0, 1), Qt::SolidPattern));
    //нарисовать хорду (часть окружности):
    painter->drawChord(-200, -10, 400, 100, 10*16, 150*16);
    //без этого класс будет считаться абстрактным:
    Q_UNUSED(option);
    Q_UNUSED(widget);
}

void MoveGardenBed::mouseMoveEvent(QGraphicsSceneMouseEvent *event)
{
    //изменить координаты изображения на координаты курсора:
    this->setPos(mapToScene(event->pos()));
}

void MoveGardenBed::mousePressEvent(QGraphicsSceneMouseEvent *event)
{
    //изменение вида курсора на руку:
    this->setCursor(QCursor(Qt::ClosedHandCursor));
    Q_UNUSED(event);
}

void MoveGardenBed::mouseReleaseEvent(QGraphicsSceneMouseEvent *event)
{
    //поменять вид курсора на обычную стрелку:
    this->setCursor(QCursor(Qt::ArrowCursor));
    Q_UNUSED(event);
}

///--- MoveTomato ---/// класс для помидоров
MoveTomato::MoveTomato(QObject *parent) :
    MoveGardenBed(parent) {}

MoveTomato::~MoveTomato() {}

QRectF MoveTomato::boundingRect() const
{
    //создание прямоугольника, который ограничивает изображение,
    //координаты от центра изображения:
    return QRectF (-60, -105, 130, 229);
}

void MoveTomato::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QImage img_tomato("../razumov_lab7/tomato.png");
    painter->drawImage(-60, -105, img_tomato);
    //без этого класс будет считаться абстрактным:
    Q_UNUSED(option);
    Q_UNUSED(widget);
}

///--- MoveCarrot ---/// класс для морковок
MoveCarrot::MoveCarrot(QObject *parent) :
    MoveGardenBed(parent) {}

MoveCarrot::~MoveCarrot() {}

QRectF MoveCarrot::boundingRect() const
{
    //создание прямоугольника, который ограничивает изображение,
    //координаты от центра изображения:
    return QRectF (-60, -63, 120, 127);
}

void MoveCarrot::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QImage img_carrot("../razumov_lab7/carrot.png");
    painter->drawImage(-60, -63, img_carrot);
    //без этого класс будет считаться абстрактным:
    Q_UNUSED(option);
    Q_UNUSED(widget);
}

///--- MoveSunflower ---/// класс для подсолнухов
MoveSunflower::MoveSunflower(QObject *parent) :
    MoveGardenBed(parent) {}

MoveSunflower::~MoveSunflower() {}

QRectF MoveSunflower::boundingRect() const
{
    //создание прямоугольника, который ограничивает изображение,
    //координаты от центра изображения:
    return QRectF (-71, -101, 142, 202);
}

void MoveSunflower::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QImage img_sunflower("../razumov_lab7/sunflower.png");
    painter->drawImage(-71, -101, img_sunflower);
    //без этого класс будет считаться абстрактным:
    Q_UNUSED(option);
    Q_UNUSED(widget);
}

///--- MoveCrow ---/// класс для вороны
MoveCrow::MoveCrow(QObject *parent) :
    MoveGardenBed(parent)
{
    valueX = valueY = 150; //начальные координаты
    imgDirection = 'r'; //направление движения
}

MoveCrow::~MoveCrow() {}

void MoveCrow::flying_crow() {
    //слот для автопередвижения изобржения вороны
    int summandX = 10; //на сколько пикселей перемещение
    while(1) {
        valueX += summandX; //изменение координаты по оси Х
        this->setX(valueX); //отрисовка с новыми координатами
        //получить список QGraphicsItem, с которыми ворона пересекается:
        QList<QGraphicsItem*> *list = new QList<QGraphicsItem*>;
        *list = this->collidingItems();
        //если ворона с чем-то столкнулась, то поменять направление:
        if (list->count() > 0) {
            if (imgDirection == 'r')
                imgDirection = 'l';
            else
                imgDirection = 'r';
            summandX *= -1;
        }
        QThread::msleep(300); //задержка
    }
}

void MoveCrow::mouseMoveEvent(QGraphicsSceneMouseEvent *event)
{
    //переопределение mouseMoveEvent:
    valueX = event->pos().x();
    valueY = event->pos().y();
    this->setPos(mapToScene(valueX, valueY));
    QThread::msleep(300); //без задержки критический баг
}

QRectF MoveCrow::boundingRect() const
{
    return QRectF (-100, -109, 200, 218);
    //размере по ширине немного больше, засчет этого картинка вороны
    //не перекрывает другие картинки при "столкновении"
}

void MoveCrow::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QImage img_crow;
    if (imgDirection == 'r') //если ворона летит вправо
        img_crow.load("../razumov_lab7/crow_toright.png");
    else //иначе влево
        img_crow.load("../razumov_lab7/crow_toleft.png");
    painter->drawImage(-86, -109, img_crow);
    //без этого класс будет считаться абстрактным:
    Q_UNUSED(option);
    Q_UNUSED(widget);
}
