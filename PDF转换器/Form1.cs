using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Spire.Pdf;
using Spire.License;
using System.IO;
using System.Threading;

namespace PDF转换器
{
    public partial class Form1 : Form
    {
        //文件集合
        private Hashtable fileList = new Hashtable();

        public Form1()
        {
            //加载嵌入资源
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
        }
        #region 加载嵌入资源中的全部dll文件
        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }
        #endregion

        private void panelFileBox_DragDrop(object sender, DragEventArgs e)
        {
            string pdfPath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string extension = System.IO.Path.GetExtension(pdfPath);//扩展名
            string fileName = System.IO.Path.GetFileNameWithoutExtension(pdfPath);//文件名
            if (!extension.Equals(".pdf"))
            {
                MessageBox.Show("请拖入PDF格式的文件");
                return;
            }
            if (fileList.Contains(fileName))
            {
                MessageBox.Show("文件已存在");
                return;
            }
            fileList.Add(fileName, pdfPath);
            LoadListView(fileName, pdfPath);
        }

        private void LoadListView(string fileName, string pdfPath)
        {
            this.labTips.Visible = false;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = fileName;
            lvi.SubItems.Add(pdfPath);
            this.listView1.Items.Add(lvi);
        }

        private void panelFileBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 设置行高
            ImageList imgList = new ImageList();
            // 分别是宽和高
            imgList.ImageSize = new Size(1, 25);
            // 这里设置listView的SmallImageList ,用imgList将其撑大
            listView1.SmallImageList = imgList;
            //在各数据之间形成网格线
            listView1.GridLines = true;
            //显示列名称
            listView1.View = View.Details;
            listView1.Columns.Add("文件名",200, HorizontalAlignment.Center);
            listView1.Columns.Add("路径", listView1.Width - 200, HorizontalAlignment.Center);
        }

        private void btnPdfToWord_Click(object sender, EventArgs e)
        {
            if (fileList != null && fileList.Count > 0)
            {
                try
                {
                    this.labPro.Visible = true;
                    PdfDocument doc = new PdfDocument();
                    string savepath = Environment.CurrentDirectory + "/word/";
                    //目录不存在的话就创建
                    if (!Directory.Exists(savepath))
                    {
                        Directory.CreateDirectory(savepath);
                    }
                    //遍历哈希表中的键
                    foreach (string key in fileList.Keys)
                    {
                        doc.LoadFromFile(fileList[key].ToString());//pdf物理路径
                        doc.SaveToFile(savepath + key + ".doc", FileFormat.DOC);//生成word的物理路径
                    }
                    //打开文件所在目录
                    if (ShowProcessBar())
                    {
                        System.Diagnostics.Process.Start(savepath);
                    }
                }
                catch (Exception)
                {
                }

            }
            else
            {
                tipMsg.SetToolTip(btnPdfToWord, "请先拖入要转换的PDF文件");
            }
        }
        // <summary>
        /// 设置进度条当前进度值
        /// </summary>
        /// <param name="value"></param>
        public void setPos(int value)
        {
            //如果值有效
            if (value <= progressBar1.Maximum)
            {
                //设置进度值
                progressBar1.Value = value;
                //显示百分比
                labPro.Text = "正在转换，当前进度：" + (value * 100 / progressBar1.Maximum).ToString() + "%";
            }
            //重点，必须加上，否则父子窗体都假死
            Application.DoEvents();
        }
        private bool ShowProcessBar(){

            for (int i = 1; i <= 100; i++)
            {
                //设置进度条位置
                setPos(i);
                //睡眠时间为10
                Thread.Sleep(10);
            }
            return true;
        }
    }
}
