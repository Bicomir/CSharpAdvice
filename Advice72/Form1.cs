using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tip72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AutoResetEvent autoSet = new AutoResetEvent(false);
        List<string> tempList = new List<string>() { "init0", "init1", "init2" };


        private void buttonStartAThread_Click(object sender, EventArgs e)
        {
            object syncObj = new object();

            Thread t1 = new Thread(() =>
            {
                // 确保等待t2开始之后才运行下面的代码
                autoSet.Set();

                lock (syncObj)
                {
                    foreach (var item in tempList)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(() =>
            {
                // 通知t1可以执行代码
                autoSet.Set();
                // 沉睡1s后， 是为了确保删除操作在t1的迭代过程中
                Thread.Sleep(1000);
                lock (syncObj)
                {
                    tempList.RemoveAt(1);
                }
            });
            t2.IsBackground = true;
            t2.Start();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            //给在autoResetEvent上等待的线程一个信号
            autoSet.Set();
        }

        private void StartThread1()
        {
            Thread tWork1 = new Thread(() =>
            {
                label1.Text = "线程1启动..." + Environment.NewLine;
                label1.Text += "开始处理一些实际的工作" + Environment.NewLine;
                //省略工作代码
                label1.Text += "我开始等待别的线程给我信号，才愿意继续下去" + Environment.NewLine;
                autoSet.WaitOne();
                label1.Text += "我继续做一些工作，然后结束了！";
                //省略工作代码
            });
            tWork1.IsBackground = true;
            tWork1.Start();
        }

        private void StartThread2()
        {
            Thread tWork2 = new Thread(() =>
            {
                label2.Text = "线程2启动..." + Environment.NewLine;
                label2.Text += "开始处理一些实际的工作" + Environment.NewLine;
                //省略工作代码
                label2.Text += "我开始等待别的线程给我信号，才愿意继续下去" + Environment.NewLine;
                autoSet.WaitOne();
                label2.Text += "我继续做一些工作，然后结束了！";
                //省略工作代码
            });
            tWork2.IsBackground = true;
            tWork2.Start();
        }

    }
}
