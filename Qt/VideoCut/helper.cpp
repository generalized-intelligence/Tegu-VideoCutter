#include "helper.h"
void GetFile(QString path,QVector<QString>& file_list)
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
                file_list.append(full_name);
            }
        }else
        {
            if(mfi.fileName()=="." || mfi.fileName() == "..")continue;
            qDebug() << "Entry Dir" << mfi.absoluteFilePath();
            GetFile(mfi.absoluteFilePath(),file_list);
        }
    }
}
