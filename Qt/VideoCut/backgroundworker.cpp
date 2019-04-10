#if _MSC_VER >= 1600
#pragma execution_character_set("utf-8")
#endif
#include "backgroundworker.h"
void BackgroundWorker::search_files(QString path,QVector<QString> *file_list)
{
    try {
        GetFile(path,file_list);
    } catch (QException e) {
        qDebug()<<e.what();
        emit error(e);
    }

    emit all_finished();
}
void BackgroundWorker::cut_videos(QString save_path,QVector<QString> file_list,bool all_save,double freq)
{
    err_list.clear();
    foreach(QString video_file,file_list)
    {
        if(all_save)//true to save all pictures in one folder
        {
            VideoCut(video_file,save_path,freq,this->working_thread,err_list);
        }
        else
        {
            QStringList video_path_list=video_file.split('/');
            QString dir_name=video_path_list[video_path_list.size()-1];
            qDebug()<<dir_name;
            QString dir_str=save_path+'/'+dir_name;
            // 检查目录是否存在，若不存在则新建
            QDir dir;
            if (!dir.exists(dir_str))
            {
                bool res = dir.mkpath(dir_str);
                qDebug() << "make dir :"<<dir_str << res;
                if(!res)
                {
                    err_list.append(video_file);//failed to make dir
                    continue;
                }

            }
            VideoCut(video_file,dir_str,freq,this->working_thread,err_list);
        }
        emit one_video_file_finished(video_file);
    }
    if(err_list.length()>0)
    {
        QString err_save_path=QDir::currentPath();
        QString file_name="error_list_"+QDateTime::currentDateTime().toString("yyyyMMdd_hh:mm:ss")+".txt";
        QFile file(err_save_path+'/'+file_name);
        file.open(QIODevice::WriteOnly | QIODevice::Text);
        QTextStream txtOutput(&file);
        foreach(QString err_file,err_list)
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
