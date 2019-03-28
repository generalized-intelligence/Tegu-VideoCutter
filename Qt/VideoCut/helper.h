#ifndef HELPER_H
#define HELPER_H
#include<QString>
#include<QVector>
#include<QDir>
#include<QDebug>
#include<memory>

using std::shared_ptr;
QString GetFilename(QString path);
void GetFile(QString path,QVector<QString>& file_list);//Search a folder recursively
bool VideoCut(QString video_path,QString save_path,double freq);

#endif // HELPER_H
