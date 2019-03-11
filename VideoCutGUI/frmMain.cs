using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutGUI
{
    public partial class frmMain : Form
    {
        //public static bool isFile = true; //是否为单个文件，不是的话则按目录处理
        //public static string work_path = null; //视频文件或目录的地址
        public static double freq = 1;//频率，默认为1秒切一张
        public static bool all_save = true;//是否全都保存在一个文件夹里，若false则为在保存文件夹里为每一个视频文件单独建立文件夹
        public static string save_path = null; //保存路径
        public static List<string> file_to_work = null; //要处理的文件
        public static Dictionary<string,Exception> err_files = null; //出错的文件，对应异常类型
         
        public frmMain()
        {
            InitializeComponent();
            file_to_work = new List<string>();
            err_files = new Dictionary<string, Exception>();
        }

        private void clear_file()
        {
            file_to_work.Clear();
            err_files.Clear();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            clear_file();
            var DlgFile = new OpenFileDialog();   //显示选择文件对话框 
            DlgFile.InitialDirectory = "c:\\";
            DlgFile.Filter = "mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*";
            DlgFile.FilterIndex = 1;
            DlgFile.RestoreDirectory = true;
            if (DlgFile.ShowDialog() == DialogResult.OK)
            {
                string path = DlgFile.FileName;
                //MessageBox.Show(path);  //显示文件路径
                //work_path = path;
                file_to_work.Add(path);
                lblNum.Text = "当前已选定"+file_to_work.Count+"个文件";
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            clear_file();
            FolderBrowserDialog path_dir = new FolderBrowserDialog();//选择目录
            if (path_dir.ShowDialog() == DialogResult.OK)
            {
                
                string path = path_dir.SelectedPath;
                //MessageBox.Show(path);
                //work_path = path;
                try
                {
                    //file_to_work = Helper.GetFile(path, file_to_work);
                    bgwFileLoading.RunWorkerAsync(path);
                    //lblNum.Text = "当前已选定" + file_to_work.Count + "个文件";
                    lblNum.Text = "开始读取目录";
                    //MessageBox.Show(file_to_work[0]);
                    //var temp = file_to_work[0].Split('\\');
                    //MessageBox.Show(temp[temp.Length - 1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void rdbOneSec_CheckedChanged(object sender, EventArgs e)
        {
            freq = 1;
            //MessageBox.Show(freq.ToString());
        }

        private void rdbThreeSec_CheckedChanged(object sender, EventArgs e)
        {
            freq = 3;
            //MessageBox.Show(freq.ToString());
        }

        private void rdbFiveSec_CheckedChanged(object sender, EventArgs e)
        {
            freq = 5;
            //MessageBox.Show(freq.ToString());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (save_path == null||file_to_work==null)
            {
                MessageBox.Show("请选择要处理的文件和保存路径");
                return;
            }
            Console.WriteLine(freq);
            lblStatus.Text = "正在执行抽取";
            lstFinished.Items.Clear();
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            try
            {
                bgwVideo.RunWorkerAsync();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            all_save = true;
        }

        private void rdbEach_CheckedChanged(object sender, EventArgs e)
        {
            all_save = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path_dir = new FolderBrowserDialog();//选择目录
            if (path_dir.ShowDialog() == DialogResult.OK)
            {
                string path = path_dir.SelectedPath;
                //MessageBox.Show(path);
                save_path = path;
            }
        }

        private void rdbdotfive_CheckedChanged(object sender, EventArgs e)
        {
            freq = 0.5;
        }

        private void bgwVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            int count = 0;
            bool flag = false;
            foreach (var item in file_to_work)
            {
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;//此结果将会被传送到RunWorkerCompleted事件中
                        return ; //提前结束工作任务
                    }
                    if (all_save)
                    {
                        flag=Helper.video_cut(item, save_path, freq, bw, e,err_files);
                    }
                    else
                    {
                        var filename = Helper.get_filename(item);
                        string subPath = save_path + "\\" + filename;
                        if (false == System.IO.Directory.Exists(subPath))
                        {
                            //创建文件夹
                            System.IO.Directory.CreateDirectory(subPath);
                        }
                        flag=Helper.video_cut(item, subPath, freq, bw, e,err_files);
                    }
                    if (flag)
                    {
                        count++;
                        bw.ReportProgress(count, item);
                    }
                    
             }
           
            
        }

        private void bgwVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var file_name = e.UserState.ToString();
            if (!err_files.ContainsKey(file_name))
            {
                Console.WriteLine("No exception");
                lstFinished.Items.Add(file_name);
                lblStatus.Text = "已经抽取" + lstFinished.Items.Count + "个文件";
            }
            
            
        }

        private void bgwVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "用户取消了操作";
            }
            if(err_files.Count==0)
            {
                MessageBox.Show("视频处理完成，输出路径"+save_path);
            }
            else
            {
                if (lblStatus.Text== "正在执行抽取")
                {
                    lblStatus.Text = "抽取失败";
                }
                var err = new frmErr(err_files);
                err.Show();
            }
            btnStart.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnCancel.Enabled = false;
            bgwVideo.CancelAsync();
        }

        private void bgwFileLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            var path = e.Argument as string;
            int count = 0;
            file_to_work = Helper.GetFile(path, file_to_work,count,bw);
        }

        private void bgwFileLoading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblNum.Text = "正在读取目录，已找到" + file_to_work.Count + "个文件";
        }

        private void bgwFileLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("目录搜索完成，已找到" + file_to_work.Count + "个文件");
            lblNum.Text = "当前已选定" + file_to_work.Count + "个文件";
        }
    }
}
