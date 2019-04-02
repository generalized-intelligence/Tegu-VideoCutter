#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    clear_file();
    thread=new QThread();
    worker=new BackgroundWorker();
    worker->moveToThread(thread);
    worker->working_thread=thread;
    thread->start();
    connect(this,SIGNAL(start_searching_files(QString,QVector<QString>&)),worker,SLOT(search_files(QString,QVector<QString>&)),Qt::DirectConnection);
    connect(this,SIGNAL(start_cutting_videos(QString,QVector<QString>,bool,double)),worker,SLOT(cut_videos(QString,QVector<QString>,bool,double)),Qt::DirectConnection);
    connect(worker,SIGNAL(error(QException,bool)),this,SLOT(got_error_searching_file(QException,bool)));
    connect(worker,SIGNAL(all_finished(bool,QString)),this,SLOT(job_finished(bool,QString)));
    connect(worker,SIGNAL(one_video_file_finished(QString)),this,SLOT(Video_file_update(QString)));

    ui->textBrowser->append("Here shows the files finished cutting.\n");
}
void MainWindow::clear_file()
{
    this->conf.file_to_work.clear();
}

MainWindow::~MainWindow()
{
    thread->requestInterruption();
    thread->quit();
    thread->wait();;//quit worker
    delete ui;
    delete worker;
    delete thread;
}
void MainWindow::Video_file_update(QString filename)
{
    ui->textBrowser->append(filename+"\n");
}

void MainWindow::got_error_searching_file(QException e,bool isVideo)
{
    if(isVideo)
    {
        QString exception_content(e.what());
        QMessageBox::information(this,"Error","Searching files failed:"+exception_content);
        ui->lblNumber->setText("Searching files failed");
        return;
    }
}

void MainWindow::on_btnFile_clicked()
{
    clear_file();
    auto DlgFile=make_shared<QFileDialog>(this);
    DlgFile->setWindowTitle("Open Video File");
    DlgFile->setAcceptMode(QFileDialog::AcceptOpen);
    QStringList file_type;
    file_type<<"mp4 files (*.mp4)"
            <<"avi files (*.avi)"
           <<"All files (*.*)";
    //DlgFile->setFilters();
    DlgFile->setNameFilters(file_type);
    DlgFile->setDirectory(".");
    if(DlgFile->exec()==QDialog::Accepted)
    {
        auto path=DlgFile->selectedFiles()[0];
        qDebug()<<path<<"\n";
        conf.file_to_work.append(path);
        qDebug()<<conf.file_to_work.count();
        QString num=QString::number(conf.file_to_work.count());
        ui->lblNumber->setText(num+" Files Selected");
    }

}

void MainWindow::on_rdbOneFolder_toggled(bool checked)
{
    conf.all_save=checked;//true to save all pictures in one folder
    qDebug()<<conf.all_save;
}
void MainWindow::job_finished(bool isVideo,QString error_log_path)
{
    if(!isVideo)
    {
        foreach(QString file,conf.file_to_work)
        {
            qDebug()<<file;
        }
        QString num=QString::number(conf.file_to_work.count());
        ui->lblNumber->setText(num+" Files Selected");
        QMessageBox::information(this,"Searching finished",num+" Files selected");
        return;
    }
    else
    {
        if(error_log_path.length()!=0)
        {
            QMessageBox::information(this,"Finished","Cutting files Finished, some files failed to cut.\n "
                                                     "Failed filename lists saved here:"+error_log_path);
        }
        else
        {
            QMessageBox::information(this,"Finished","All files cutting finished");
        }
    }

}
void MainWindow::on_btnFolder_clicked()
{
    clear_file();
    QString folder_path=QFileDialog::getExistingDirectory (this, "Select the folder to open","./" );
    qDebug()<<folder_path;
    if(folder_path.length()!=0)
    {
//        try {
//            ui->lblNumber->setText("Searching Files");
//            GetFile(folder_path,conf.file_to_work);
//        } catch (QException e) {
//            QMessageBox::information(this,"Error","Failed to search the path:"+folder_path);
//            ui->lblNumber->setText("Searching Files Failed");
//            return;
//        }
        emit start_searching_files(folder_path,conf.file_to_work);

    }


}

void MainWindow::on_btnPath_clicked()
{
    QString folder_path=QFileDialog::getExistingDirectory (this, "Select the folder to open","./" );
    //qDebug()<<folder_path;
    if(folder_path.length()!=0)
    {
        conf.save_path=folder_path;
        qDebug()<<folder_path;
    }
}


void MainWindow::on_btnStop_clicked()
{
    thread->requestInterruption();
}

void MainWindow::on_rdb05_clicked()
{
    conf.freq=0.5;
    qDebug()<<conf.freq;
}

void MainWindow::on_rdb1_clicked()
{
    conf.freq=1;
    qDebug()<<conf.freq;
}

void MainWindow::on_rdb3_clicked()
{
    conf.freq=3;
    qDebug()<<conf.freq;
}


void MainWindow::on_rdb5_clicked()
{
    conf.freq=5;
    qDebug()<<conf.freq;
}


void MainWindow::on_btnStart_clicked()
{
    emit start_cutting_videos(conf.save_path,conf.file_to_work,conf.all_save,conf.freq);
}
