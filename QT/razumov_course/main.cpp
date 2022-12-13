#include "razumov_mainwindow.h"
#include <QApplication>
#include <QtWidgets>

void loadModules(QSplashScreen* psplash)
{
    QTime time;
    time.start();

    for (int i = 0; i < 100; ) {
        if (time.elapsed() > 30) {
            time.start();
            ++i;
        }
        psplash->showMessage("Loading modules: "
                             + QString::number(i) + "%",
                             Qt::AlignHCenter | Qt::AlignBottom,
                             Qt::black);
    }
}

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QSplashScreen splash(QPixmap(":/loading.gif"));
    splash.show(); //загрузочный экран
    razumov_MainWindow w;
    loadModules(&splash);
    splash.finish(&w);

    w.show();

    return a.exec();
}
