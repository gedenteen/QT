#include "razumov_calendar.h"
#include <QBrush>
#include <QLocale>
#include <QSqlQuery>
#include <QDebug>

CalendarTableModel::CalendarTableModel(QObject *parent) : QAbstractTableModel(parent)
{
    colorTheme = 'L'; //изначально светлая тема
    QDate curDate = QDate::currentDate();
    _chosenYear = curDate.year();
    _chosenMonth = curDate.month();
    _chosenDay = curDate.day();
    setCalendarPage();
}


void CalendarTableModel::setCalendarPage()
{
    beginResetModel();
    QDate firstDayOfMonth(_chosenYear, _chosenMonth, 1);
    _firstDate = firstDayOfMonth.addDays(1 - firstDayOfMonth.dayOfWeek());
    endResetModel();
}

///эти методы нужны для переопределения класса (он теперь не абстрактный)
int CalendarTableModel::rowCount(const QModelIndex &parent) const
{
    return 6;
}

int CalendarTableModel::columnCount(const QModelIndex &parent) const
{
    return 7;
}

QVariant CalendarTableModel::data(const QModelIndex &index, int role) const
{
    if (!index.isValid())
        return QVariant(); //вернуть пустой QVariant (см. тип метода)
    QDate date = _firstDate.addDays(index.row() * 7 + index.column());
    if (role == Qt::DisplayRole) {
        return date.day();
    }
    else if (role == Qt::ForegroundRole) {
        if (date.year() == _chosenYear && date.month() == _chosenMonth) { //если текущий месяц
            if (colorTheme == 'L') //если светлая тема
                return QBrush(Qt::black);
            else //иначе темная тема
                return QBrush(Qt::white);
        }
        else
            return QBrush(QColor(127, 127, 127, 255));
    }
    else if (role == Qt::BackgroundRole) {
        //узнать, есть ли записи в этот день:
        QString str = "SELECT * FROM records "
                    "WHERE year = " + QString::number(date.year()) + " AND "
                    "month = " + QString::number(date.month()) + " AND "
                    "day = " + QString::number(date.day()) + ";";
        QSqlQuery qry;
        bool b = qry.exec(str);
        if (b && qry.next()) { //если есть >= 1 запись
            if (date.year() == _chosenYear && date.month() == _chosenMonth) //если текущий месяц
                return QBrush(QColor(219, 228, 130, 200)); //бежевый цвет
            else if (colorTheme == 'L') //если светлая тема
                return QBrush(Qt::white);
            else //иначе темная тема
                return QBrush(QColor(52, 54, 67, 255)); //темный цвет+1
        }
        else {
            if (colorTheme == 'L') //если светлая тема
                return QBrush(Qt::white);
            else //иначе темная тема
                return QBrush(QColor(52, 54, 67, 255)); //темный цвет+1
        }
    }
    return QVariant();
}

QVariant CalendarTableModel::headerData(int section, Qt::Orientation orientation, int role) const
{
    if (role == Qt::DisplayRole && orientation == Qt::Horizontal) {
        return QLocale(QLocale::Russian).dayName(section + 1, QLocale::ShortFormat);
    }
    return QVariant();
}

void CalendarTableModel::changeDate(int changeMonth, int changeYear)
{
    _chosenMonth += changeMonth;
    _chosenYear += changeYear;
    if (_chosenMonth == 0) {
        _chosenYear--;
        _chosenMonth = 12;
    }
    else if (_chosenMonth == 13) {
        _chosenYear++;
        _chosenMonth = 1;
    }
    setCalendarPage();
}

void CalendarTableModel::getYearAndMonth(int &year, int &month)
{
    year = _chosenYear;
    month = _chosenMonth;
}

void CalendarTableModel::getChosenDate(int &year, int &month, int &day)
{
    year = _chosenYear;
    month = _chosenMonth;
    day = _chosenDay;
}

void CalendarTableModel::setChosenDay(int day)
{
    _chosenDay = day;
}
