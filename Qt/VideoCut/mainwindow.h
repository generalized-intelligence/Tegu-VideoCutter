#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QFileDialog>
#include <QMessageBox>
#include <QDebug>
#include<memory>
#include "config.h"
#include "helper.h"
using std::shared_ptr;
using std::make_shared;
namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
    void clear_file();

private slots:
    void on_btnFile_clicked();
    void Video_file_update(QString filename);
    void on_rdbOneFolder_toggled(bool checked);

    void on_btnFolder_clicked();

    void on_btnPath_clicked();


    void on_btnStop_clicked();

private:
    Ui::MainWindow *ui;
    config conf;


};

#endif // MAINWINDOW_H
