#include "razumov_widget.h"
#include "ui_razumov_widget.h"

razumov_Widget::razumov_Widget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::razumov_Widget)
{
    ui->setupUi(this);
    //размеры окна:
    int winWidth = 1700, winHeight = 800;
    this->resize(winWidth, winHeight);
    this->setFixedSize(winWidth, winHeight);
    //создание графической сцены:
    scene = new QGraphicsScene(this);
    scene->setItemIndexMethod(QGraphicsScene::NoIndex); //индексация элементов
    //настройка graphicsView:
    ui->graphicsView->setGeometry(0, 0, winWidth, winHeight); //размер graphicsView
    ui->graphicsView->setScene(scene); //установить графическую сцену в graphicsView
    ui->graphicsView->setRenderHint(QPainter::Antialiasing); //рендер
    ui->graphicsView->setCacheMode(QGraphicsView::CacheBackground); //кэш фона
    ui->graphicsView->setViewportUpdateMode(QGraphicsView::BoundingRectViewportUpdate);
    //размер сцены:
    scene->setSceneRect(10, 10, winWidth-20, winHeight-20);
    //рамки, чтобы ворона "не улетела" за края окна:
    scene->addLine(0, 2, winWidth, 2, QPen(Qt::red, 4));
    scene->addLine(winWidth-2, 0, winWidth-2, winHeight, QPen(Qt::red, 4));
    scene->addLine(0, winHeight-2, winWidth, winHeight-2, QPen(Qt::red, 4));
    scene->addLine(2, 0, 2, winHeight, QPen(Qt::red, 4));
    //создание изображений:
    MoveGardenBed *bed[3];
    MoveTomato *tomato[3];
    MoveCarrot *carrot[3];
    MoveSunflower *sunflower[3];
    for (int i = 0; i < 3; i++) {
        bed[i] = new MoveGardenBed();
        bed[i]->setPos(260 + i * 520, 700);
        scene->addItem(bed[i]);
    }
    for (int i = 0; i < 3; i++) {
        tomato[i] = new MoveTomato();
        tomato[i]->setPos(150 + i * 90, 610);
        scene->addItem(tomato[i]);
        carrot[i] = new MoveCarrot();
        carrot[i]->setPos(680 + i * 90, 660);
        scene->addItem(carrot[i]);
        sunflower[i] = new MoveSunflower();
        sunflower[i]->setPos(1200 + i * 90, 620);
        scene->addItem(sunflower[i]);
    }
    //ворона:
    MoveCrow *crow = new MoveCrow();
    crow->setPos(150, 150);
    scene->addItem(crow);
    //добавления слота для автопередвижения вороны в отдельный поток,
    //чтобы ворона двигалась одновременно с действиями пользователя:
    QThread *thread= new QThread;
    crow->moveToThread(thread);
    connect(thread, SIGNAL(started()), crow, SLOT(flying_crow()));
    thread->start();
}

razumov_Widget::~razumov_Widget()
{
    delete ui;
}
