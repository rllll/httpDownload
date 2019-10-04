using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Threading;
//测试网址http://mirrors.163.com/debian/ls-lR.gz
//大文件http://kd.269.net/200.zip
namespace httpDownload
{
    public partial class Form1 : Form
    {
        public bool[] threadendTag;//判断各线程是否接收完文件
        public string[] filenameList;//各线程下载的小文件名列表
        public int[] filestartpos;//各线程开始读取文件的位置
        public int[] filesize;//小文件大小
        public string url;//请求链接
        public bool union;//判断文件是否合并完成
        public int thread;//线程数
        /*public bool ThreadDead;*/

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //path.Text = "D:\\VS2019Project\\httpDownload\\download";
            String fullPath = System.Environment.CurrentDirectory.ToString();
            
            path.Text = Directory.GetParent(Directory.GetParent(fullPath).FullName).FullName + "\\download";
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "请选择一个下载目录";
            string Path;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Path = fb.SelectedPath;
                path.Text = Path;
            }
        }
        public class HttpFile
        {
            public Form1 formm;//声明一个窗体类
            public int threadIndex;//进程标识
            public string filenamea;//下载的小文件名
            public string strUrl;//请求的链接
            public FileStream fs;
            public HttpWebRequest request;
            public Stream ns;
            public byte[] nbytes;//接收缓冲区
            public int nreadsize;//接收字节数
            

            public HttpFile(Form1 form, int thread)
            {
                formm = form;
                threadIndex = thread;
            }
            ~HttpFile()
            {
                formm.Dispose();
            }
            public int getThread
            {
                get
                {
                    return threadIndex;
                }
            }
            public int getFilesize
            {
                get
                {
                    return formm.filesize[threadIndex];
                }
            }
            public void receive()//线程开始接收文件
            {
                filenamea = formm.filenameList[threadIndex];
                strUrl = formm.url;
                ns = null;
                nbytes = new byte[512];
                nreadsize = 0;
                formm.recevMsg.Items.Add("线程" + threadIndex.ToString() + "开始接收：" + "文件大小" + Math.Ceiling(formm.filesize[threadIndex] / 1024.0f) + "KB");
                fs = new FileStream(filenamea,FileMode.Create);

                try
                {
                    request = (HttpWebRequest)HttpWebRequest.Create(strUrl);
                    //要接收文件的字节范围
                    request.AddRange(formm.filestartpos[threadIndex], formm.filestartpos[threadIndex] + formm.filesize[threadIndex]);
                    ns = request.GetResponse().GetResponseStream();
                    nreadsize = ns.Read(nbytes, 0, nbytes.Length);
                    while (nreadsize > 0)
                    {
                        fs.Write(nbytes, 0, nreadsize);
                        //formm.recevMsg.Items.Add("线程" + threadIndex.ToString() + "已下载字节：" + Math.Ceiling(nreadsize / 1024.0f) + "KB");
                        nreadsize = ns.Read(nbytes, 0, nbytes.Length);
                    }
                    fs.Close();
                    ns.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                    fs.Close();
                }
                formm.recevMsg.Items.Add("线程" + threadIndex.ToString() + "接收完毕！");
                
                
            }
        }
 
        private void StartDownload_Click(object sender, EventArgs e)
        {
            
            DateTime date = DateTime.Now;
            Date.Text = date.ToString();
            url = SourceUrl.Text.ToString();
            HttpWebRequest request;
            long filesizew = 0;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(url);//建立一个HTTP请求
                filesizew = request.GetResponse().ContentLength;//得到文件总大小
                request.Abort();//取消请求
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message,"错误信息");
                return;
            }

            thread = Convert.ToInt32(recvThreadnum.Text.Trim().ToString(), 10);
            recevMessageShow("同时下载线程数：" + thread.ToString());
            recevMessageShow("文件大小：" + Math.Ceiling(filesizew / 1024.0f) + "KB");

            threadendTag = new bool[thread];
            filenameList = new string[thread];
            filestartpos = new int[thread];
            filesize = new int[thread];

            int filethread = (int)filesizew / thread;
            int filethreade = filethread + (int)filesizew % thread;
            string filePath = path.Text;

            //文件大小切割
            for (int i = 0; i < thread; i++)
            {
                threadendTag[i] = false;
                filenameList[i] = filePath + "\\" + i.ToString() + ".txt";
                if (i < thread - 1)
                {
                    filestartpos[i] = filethread * i;
                    filesize[i] = filethread - 1;
                }
                else
                {
                    filestartpos[i] = filethread * i;
                    filesize[i] = filethreade - 1;
                }
            }
            
            Thread[] threadk = new Thread[thread];
            HttpFile[] httpfile = new HttpFile[thread];

            //各进程开始下载
            for (int j = 0; j < thread; j++)
            {
                httpfile[j] = new HttpFile(this, j);
                threadk[j] = new Thread(new ThreadStart(httpfile[j].receive));
                threadk[j].Start();
            }
            

        }
        public void Combine()
        {
            /*for (int i = 0; i < thread; i++)
                threadendTag[i] = false;*/
            while (true)
            {
                union = true;
                for (int i = 0; i < thread; i++)
                {
                    if (threadendTag[i] == false)
                    {
                        union = false;
                        Thread.Sleep(100);
                        break;
                    }
                }
                if (union == true)
                {
                    break;
                }
                string[] fns = SourceUrl.Text.Split('/');
                string saveFilePath = path.Text + "\\" + fns[fns.Length - 1];
                FileStream fs = new FileStream(saveFilePath, FileMode.Create);
                FileStream fstemp;
                byte[] bytes = new byte[512];
                int readsize;
                for (int i = 0; i < thread; i++)
                {
                    fstemp = new FileStream(filenameList[i], FileMode.Open);
                    readsize = fstemp.Read(bytes, 0, bytes.Length);
                    while (readsize > 0)
                    {
                        fs.Write(bytes, 0, readsize);
                        readsize = fstemp.Read(bytes, 0, bytes.Length);
                    }
                    threadendTag[i] = true;
                    fstemp.Close();
                }
                long recevfilesize = fs.Length;
                fs.Close();
                recevMsg.Items.Add("已成功接收的文件总大小：" + Math.Ceiling(recevfilesize / 1024.0f) + "KB");
            }
            DateTime date = DateTime.Now;
            DateEnd.Text = date.ToString();
            if (MessageBox.Show("是否删除缓存？","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < thread; i++)
                {
                    FileInfo fi = new FileInfo(filenameList[i]);
                    try
                    {
                        fi.Delete();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void recevMessageShow(string Message)
        {
            recevMsg.Items.Add(Message);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            recevMsg.Items.Clear();
        }

        private void Filecombine_Click(object sender, EventArgs e)
        {

            Thread hbth = new Thread(new ThreadStart(Combine));
            hbth.Start();
        }
    }
}
