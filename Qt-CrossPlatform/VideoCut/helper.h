#ifndef HELPER_H
#define HELPER_H
#include<QString>
#include<QVector>
#include<memory>
using std::shared_ptr;
QString GetFilename(QString path);
QVector<QString>GetFile(QString path);
bool VideoCut(QString video_path,QString save_path,double freq);

#endif // HELPER_H
