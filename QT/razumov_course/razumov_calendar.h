#ifndef RAZUMOV_CALENDAR_H
#define RAZUMOV_CALENDAR_H

#include <QAbstractTableModel>
#include <QObject>
#include <QDate>

class CalendarTableModel : public QAbstractTableModel
{
    Q_OBJECT
public:
    CalendarTableModel(QObject *parent = nullptr);
    void setCalendarPage();
protected:
    int _chosenYear, _chosenMonth, _chosenDay; //выбранная дата на календаре
    QDate _firstDate; //день, который отобразится первым (скорее всего, предыдущего месяца)
public:
    virtual int rowCount(const QModelIndex &parent) const override;
    virtual int columnCount(const QModelIndex &parent) const override;
    virtual QVariant data(const QModelIndex &index, int role) const override;
    virtual QVariant headerData(int section, Qt::Orientation orientation, int role) const override;
    void changeDate(int changeMonth, int changeYear);
    void getYearAndMonth(int &year, int &month);
    void getChosenDate(int &year, int &month, int &day);
    void setChosenDay(int day);
    char colorTheme; //какая сейчас цветовая тема программы
};

#endif // RAZUMOV_CALENDAR_H
