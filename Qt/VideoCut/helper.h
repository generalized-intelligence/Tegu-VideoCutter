#ifndef HELPER_H
#define HELPER_H
#include<QString>
#include<QVector>
#include<QDir>
#include<QDebug>
#include <QThread>
#include <exception>
#include <opencv2/opencv.hpp>
#include <opencv2/videoio/videoio.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>

QString GetFilename(QString path);
void GetFile(QString path,QVector<QString>& file_list);//Search a folder recursively
bool VideoCut(QString video_path,QString save_path,double freq,QThread *worker,QVector<QString>& err_files);

#endif // HELPER_H
