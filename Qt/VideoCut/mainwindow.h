#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QFileDialog>
#include <QMessageBox>
#include <QThread>
#include <QDebug>
#include<memory>
#include "config.h"
#include "helper.h"
#include "backgroundworker.h"
using std::shared_ptr;
using std::make_shared;
namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT
signals:
    void start_searching_files(QString path,QVector<QString>& file_list);
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
    void job_finished(bool isVideo=false);
    void video_finish_list_update(QString error_log_path);
    void got_error(QException e,bool isVideo);

private:
    Ui::MainWindow *ui;
    config conf;
    QThread *thread;
    BackgroundWorker *worker;
};

#endif // MAINWINDOW_H
