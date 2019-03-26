#ifndef BACKGROUNDWORKER_H
#define BACKGROUNDWORKER_H
#include <QThread>
#include <QDialog>
#include <QString>
#include <QVector>
class BackgroundWorker : public QThread
{
signals:
    void one_file_finished(QString filename);
public:
    BackgroundWorker(QObject* parent);
    void start_cut_videos(QVector<QString>* filelist);

};

#endif // BACKGROUNDWORKER_H
