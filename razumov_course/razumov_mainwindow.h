#ifndef RAZUMOV_MAINWINDOW_H
#define RAZUMOV_MAINWINDOW_H

#include <QMainWindow>
#include <QtSql>
#include <QSqlQuery>
//#include <QFileInfo>
#include <QPushButton>
#include <QFileDialog>
#include <QTableView>
#include <QAction>
#include <razumov_calendar.h>
#include <razumov_helpbrowser.h>

namespace Ui {
class razumov_MainWindow;
}

class razumov_MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit razumov_MainWindow(QWidget *parent = nullptr);
    ~razumov_MainWindow();
private slots:
    void returnRecordEdit(int id); //слот, который открывает запись для редактирования
    void slotLoad(); //загрузить файл БД
    void slotSave(); //сохранить изменения
    void slotSaveAs();
    void slotUploadToTxt();
    void slotLightTheme();
    void slotDarkTheme();
    void slotAbout();
    void on_pushButton_AddRecord_clicked();
    void on_pushButton_PrevMonth_clicked();
    void on_pushButton_NextMonth_clicked();
    void on_pushButton_PrevYear_clicked();
    void on_pushButton_NextYear_clicked();
    void on_pushButton_Search_clicked();
    void on_pushButton_ApplyFormatting_clicked();
    void on_pushButton_DelRecord_clicked();
    void on_pushButton_Home_clicked();
    void on_tableView_clicked(const QModelIndex &index);

private:
    void changeDateByButtons(int changeMonth, int changeYear);
    void showRecordsInChosenDay();
    QVector<QPushButton*> buttonsForDeletion; //записи дня в виде кнопок
    int currentId;
    void initToolButtons(); //код для кнопок toolButtons
    QString fileDB; //имя файла с базой данных
    void openFileDB();
    void hideRecordEdit();
    void useTempalate(int type);
    void addHTML(int type);
    void addMainMenu();
    int textWithoutFormatting;
    QString textForRecord;
    Ui::razumov_MainWindow *ui;
    QSqlDatabase db;
    CalendarTableModel *calendar;
};

#endif // RAZUMOV_MAINWINDOW_H
