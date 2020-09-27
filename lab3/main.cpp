#include "sdiprogram_razumov.h"
#include <QApplication>
#include <QtWidgets>

void loadModules(QSplashScreen* psplash)
{
    QTime time;
    time.start();

    for (int i = 0; i < 100; ) {
        if (time.elapsed() > 40) {
            time.start();
            ++i;
        }
        psplash->showMessage("Loading modules: "
                             + QString::number(i) + "%",
                             Qt::AlignHCenter | Qt::AlignBottom,
                             Qt::black
                            );
    }
}

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QSplashScreen splash(QPixmap("../lab3/s.jpg"));
    splash.show();
    SDIProgram_Razumov w;
    loadModules(&splash);
    splash.finish(&w);
    w.show();

    return a.exec();
}
