#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    clear_file();
}
void MainWindow::clear_file()
{
    this->conf.file_to_work.clear();
    this->conf.err_files.clear();
}

MainWindow::~MainWindow()
{
    delete ui;
}
void MainWindow::Video_file_update(QString filename)
{

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
    conf.all_save=checked;
    qDebug()<<conf.all_save;
}
