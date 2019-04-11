#ifndef BACKGROUNDWORKER_H
#define BACKGROUNDWORKER_H
#include <QThread>
#include <QDialog>
#include <QString>
#include <QVector>
#include <QException>
#include <QMutex>
#include <QDir>
#include <QDateTime>
#include "helper.h"

class BackgroundWorker : public QObject
{
    Q_OBJECT
signals:
    void one_video_file_finished(QString filename);
    void all_finished(bool is_video=false,QString error_path="");
    void error(QException e,bool is_video=false);
public:
    BackgroundWorker();
    QThread *working_thread;
    QVector<QString>err_list;
public slots:
    void cut_videos(QString save_path,QVector<QString> file_list,bool all_save,double freq);
    void search_files(QString path,QVector<QString> *file_list);

};

#endif // BACKGROUNDWORKER_H
