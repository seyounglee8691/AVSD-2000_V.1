using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WMX_Anti
{
    public partial class frLoading : Form
    {
       
        WMXLIB_Main wmxLib_main;
        Main_Form fr_main;
        int a;
        public frLoading()
        {
            InitializeComponent();
              
          //  wmxLib_main = new WMXLIB_Main();
        }

        delegate void ProgressDelegate(int i);
        delegate void CloseDelegate();

        private void btstart_Click(object sender, EventArgs e)
        {
           
            //Thread.Sleep(500);
            UpDateThread();
           

            //this.Hide();
            //mainform.Show();
          //  Update();

            

        }
        private void FormClose()
        {
            this.Close();
        }

        private void UpDateThread()
        {
            bool _wantToClose = false;

            Thread UpDateThread = new Thread(delegate()
                {
                    try
                    {
                        while (!_wantToClose)
                        {
                            BeginInvoke(new System.Action(delegate()
                                {
                                    //loadingbar.Value = gVar.progress_;
                                    //test();
                                    this.Close();
                                }));
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                    catch
                    {
                       
                    }
                });
            UpDateThread.Start();
        }
        private void step(int index)
        {
            loadingbar.Value = index;
        }

        private void Thread()
        {
            BeginInvoke(new Action(delegate()
                {
                       
                }));
            for (int Buffering = 0; Buffering <= 100; Buffering++)
            {
               
                this.Invoke(new ProgressDelegate(step), Buffering);
                System.Threading.Thread.Sleep(50);
            }
            this.Invoke(new CloseDelegate(FormClose));
            fr_main.Show();
        }


        private void frLoading_Load(object sender, EventArgs e)
        {
            Thread loading = new Thread(Thread);
            loading.Start();
           // UpDateThread();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
