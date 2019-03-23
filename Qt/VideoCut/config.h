#ifndef CONFIG_H
#define CONFIG_H
#include<QString>
#include<QVector>
#include<QException>
struct config
{
    config();
    double freq=1;//frequency
    bool all_save=true;//save all image files in a folder
    //false to create a folder for every video file
    QString save_path;//path to save
    QVector<QString>file_to_work;//file list for working
    QVector<QString>err_files;//error files
};

#endif // CONFIG_H
