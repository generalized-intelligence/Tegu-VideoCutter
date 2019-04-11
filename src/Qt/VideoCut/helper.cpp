#include "helper.h"

void GetFile(QString path,QVector<QString> *file_list)
{
    QDir dir(path);
    foreach(QFileInfo mfi ,dir.entryInfoList())
    {
        if(mfi.isFile())
        {
            auto full_name=mfi.absoluteFilePath().toLower();
            qDebug()<< "File :" << full_name;
            if(full_name.endsWith(".avi")||full_name.endsWith(".mp4"))
            {
                file_list->append(full_name);
            }
        }else
        {
            if(mfi.fileName()=="." || mfi.fileName() == "..")continue;
            qDebug() << "Entry Dir" << mfi.absoluteFilePath();
            GetFile(mfi.absoluteFilePath(),file_list);
        }
    }
}
QString GetFilename(QString path)
{
    auto path_list=path.split('/');
    QString file_name=path_list.at(path_list.size()-1);
    return file_name;
}
bool VideoCut(QString video_path,QString save_path,double freq,QThread *worker,QVector<QString>&err_files)
{ //cut a single file
    VideoCaptureRAII raii(video_path);
    cv::VideoCapture& video_capture=raii.capture;
    if(!video_capture.isOpened())
    {
        qDebug()<<video_capture.isOpened();
        qDebug()<<"Failed to load video file:"+video_path;
        return false;
    }
    auto image_mat=cv::Mat();
    double real_freq=freq*video_capture.get(CV_CAP_PROP_FPS);
    int extract_freq=static_cast<int>(real_freq);
    qDebug()<<extract_freq;
    int count=0;
    int index=1;
    while(!worker->isInterruptionRequested())
    {
        try {
            bool result = video_capture.grab();
            if(!result)
            {
                qDebug()<<"finished";
                break;
            }
            if(count%extract_freq==0)
            {
                video_capture.retrieve(image_mat);
                auto img_filename=GetFilename(video_path)+"_"+QString::number(index)+".jpg";
                auto full_save_path=save_path+"/"+img_filename;
                cv::imwrite(full_save_path.toStdString(),image_mat);
                index++;
            }
            count++;
        } catch (cv::Exception e) {
            qDebug()<<e.what();
            err_files.append(video_path);

            return false;
        }


    }
    return true;
}
