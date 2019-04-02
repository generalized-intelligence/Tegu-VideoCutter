#include "backgroundworker.h"
void BackgroundWorker::search_files(QString path,QVector<QString>& file_list)
{
    try {
        GetFile(path,file_list);
    } catch (QException e) {
        qDebug()<<e.what();
        emit error(e);
    }

    emit all_finished();
}
void BackgroundWorker::cut_videos(QString save_path,QVector<QString> file_list,QVector<QString>&error_list,bool all_save,double freq)
{
    foreach(QString video_file,file_list)
    {
        if(all_save)//true to save all pictures in one folder
        {
            VideoCut(video_file,save_path,freq,this->working_thread,error_list);
        }
        else
        {

        }
    }
    if(error_list.length()>0)
    {
        QString err_save_path=QDir::currentPath();
        QString file_name="error_list_"+QDateTime::currentDateTime().toString("yyyyMMdd_hh:mm:ss")+".txt";
        QFile file(err_save_path+'/'+file_name);
        file.open(QIODevice::WriteOnly | QIODevice::Text);
        QTextStream txtOutput(&file);
        foreach(QString err_file,error_list)
        {
            txtOutput<<err_file<<endl;
        }
        file.close();
        emit all_finished(true,err_save_path+'/'+file_name);
    }
    else
    {
        emit all_finished(true,"");
    }


}
BackgroundWorker::BackgroundWorker()
{

}
