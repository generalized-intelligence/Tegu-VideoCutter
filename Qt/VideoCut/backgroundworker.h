#ifndef BACKGROUNDWORKER_H
#define BACKGROUNDWORKER_H
#include <QThread>
#include <QDialog>
#include <QString>
#include <QVector>
#include <QException>
#include <QMutex>
#include "helper.h"

class BackgroundWorker : public QObject
{
    Q_OBJECT
signals:
    void one_video_file_finished(QString filename);
    void all_finished(bool is_video=false);
    void error(QException e,bool is_video=false);
public:
    BackgroundWorker();

public slots:
    void cut_videos(QVector<QString>& filelist);
    void search_files(QString path,QVector<QString>& file_list);

};

#endif // BACKGROUNDWORKER_H
