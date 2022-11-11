using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMX_Anti
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frLoading());
            Application.Run(new Main_Form());
            //frLoading frloading = new frLoading();
            //frloading.Show();
          //  frloading.Update();
          //  frloading.Refresh();
            
            //Main_Form frmain = new Main_Form();
            //Application.Run(frmain);
            
            //Application.Run(new frLoading());

            //Main_Form fr = new Main_Form();
            //Application.Run(fr);
            //Application.Run(new Main_Form());
        }
    }
}
