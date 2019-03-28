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
void BackgroundWorker::cut_videos(QVector<QString>& filelist)
{

}
BackgroundWorker::BackgroundWorker()
{

}
