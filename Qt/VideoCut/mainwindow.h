#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QFileDialog>
#include <QDebug>
#include<memory>
#include "config.h"
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

private:
    Ui::MainWindow *ui;
    config conf;


};

#endif // MAINWINDOW_H
