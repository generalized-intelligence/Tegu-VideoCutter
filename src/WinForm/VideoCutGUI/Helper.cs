using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.IO;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
namespace VideoCutGUI
{

    class Helper
    {
        

        public static string get_filename(string path)
        {
            var temp = path.Split('\\');
            return temp[temp.Length - 1];
        }

        public static List<string> GetFile(string path, List<string> FileList,int count,BackgroundWorker bw)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                //int size = Convert.ToInt32(f.Length);
                if (f.FullName.EndsWith(".mp4") || f.FullName.EndsWith(".MP4") || f.FullName.EndsWith(".avi") || f.FullName.EndsWith(".AVI"))//只有当是视频文件时才添加
                {
                    FileList.Add(f.FullName);//添加文件路径到列表中
                    count++;
                    bw.ReportProgress(count, null);
                }
                
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                GetFile(d.FullName, FileList,count,bw);
            }
            return FileList;
        }
        [HandleProcessCorruptedStateExceptions]
        public static bool video_cut(string video_path,string save_path,double freq, BackgroundWorker bw, DoWorkEventArgs e, Dictionary<string, Exception> err_files)
        {
            // 视频帧率
            int count = 0;
            int index = 1;
            if (bw.CancellationPending)
            {
                e.Cancel = true;//此结果将会被传送到RunWorkerCompleted事件中
                return false; //提前结束工作任务
            }

            using (VideoCapture capture = new VideoCapture(video_path))
            using (var image = new Mat())
            {
                double real_freq = capture.Fps * freq;
                int extract_freq = (int)real_freq;
                Console.WriteLine(extract_freq);
                while (true)
                {
                    //Console.WriteLine(count);
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;//此结果将会被传送到RunWorkerCompleted事件中
                        return false; //提前结束工作任务
                    }
                    try
                    {
                        capture.Read(image);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error:" + video_path);
                        err_files.Add(video_path, ex);
                        capture.Dispose();
                        return false;
                    }
                    
                    if (image.Empty())
                    {
                        Console.WriteLine("finished");
                        break;
                    }
                    if (count % extract_freq == 0)
                    {
                        string img_filename = get_filename(video_path) +"_"+ index + ".jpg";
                        Cv2.ImWrite(save_path+"\\"+ img_filename, image);
                        index++;
                    }
                    count++;
                }
            }
            return true;
        }
    }
}
