using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using M_Status;
using WMX3ApiCLR;
using AvxApi;

namespace WMX_Anti
{
    public partial class fr_parm : Form //fr_parm
    {
        
        WMXLIB_Main WmxLib_Main;
        Main_Form MainForm;
        RadioButton[] rdobt;
        Button[] PosNum;
        Button[] M_Move;
        TextBox[] txtPos;
        TextBox[] X_Pos;
        TextBox[] Y_Pos;
        int[,] SelectAxis = new int[4, 8];
        int selectAxis;
        bool[] b_Servo = new bool[4];

        public fr_parm(Main_Form fr_Main)
        {
            MainForm = fr_Main;
            InitializeComponent();
            initiallize();
            ReadMotionData();
            ReadAbspos();
            UpDateThread();
        }

        bool _wantToClose = true;

        void UpDateThread()
        {
            _wantToClose = false;

            Thread UpDateThread = new Thread(delegate()
            {
                try
                {
                    while (!_wantToClose)
                    {
                        BeginInvoke(new System.Action(delegate()
                        {

                            state(gVar.intAxisNum);

                        }));

                        Thread.Sleep(50);
                    }
                }
                catch
                {

                }
            });
            UpDateThread.Start();
        }
        private void state(int Axis)
        {
            if (MainForm.getaxisstatus(Axis).ServoOn)
            {
                txtcp.Text = MainForm.getaxisstatus(Axis).PosCmd.ToString("F0");
                txtap.Text = MainForm.getaxisstatus(Axis).ActualPos.ToString("F0");
                txtcs.Text = MainForm.getaxisstatus(Axis).VelocityCmd.ToString("F0");
                txtas.Text = MainForm.getaxisstatus(Axis).ActualVelocity.ToString("F0");

                groupBox5.Enabled = true;
                if (!MainForm.getaxisstatus(Axis).InPos)
                {
                    lbPOS.BackColor = Color.LimeGreen;
                }
                else
                {
                    lbPOS.BackColor = Color.DarkGray;
                }
                if (MainForm.getaxisstatus(Axis).AmpAlarm)
                {
                    lbALM.BackColor = Color.Red;
                }
                else
                {
                    lbALM.BackColor = Color.DarkGray;
                }
                if (MainForm.getaxisstatus(Axis).HomeSwitch)
                {
                    if (MainForm.getaxisstatus(Axis).HomeDone)
                    {
                        lbORG.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    lbORG.BackColor = Color.DarkGray;
                }
                if (MainForm.getaxisstatus(Axis).PositiveLS)
                {
                    LBPEL.BackColor = Color.Red;
                }
                else
                {
                    LBPEL.BackColor = Color.DarkGray;
                }
                if (MainForm.getaxisstatus(Axis).NegativeLS)
                {
                    lbNEL.BackColor = Color.Red;
                }
                else
                {
                    lbNEL.BackColor = Color.DarkGray;
                }
            }
            else
            {
                groupBox5.Enabled = false;
                txtcp.Text = "-";
                txtap.Text = "-";
                txtcs.Text = "-";
                txtas.Text = "-";
            }
        }
        private void initiallize()
        {
            rdobt = new RadioButton[4] { rdo0, rdo1, rdo2, rdo3 };
            PosNum = new Button[4] { move0, move1, move2, move3 };
            M_Move = new Button[6] { btmove0, btmove1, btmove2, btmove3, btmove4,btmove5 };
            txtPos = new TextBox[8] { txtpos0, txtpos1, txtpos2, txtpos3, txtspeed, txtacc_d, txt_jspeed, txt_jacc};
            X_Pos = new TextBox[6] { txt_X0, txt_X1, txt_X2, txt_X3, txt_X4, txt_X5};
            Y_Pos = new TextBox[6] { txt_Y0, txt_Y1, txt_Y2, txt_Y3, txt_Y4, txt_Y5 };
        }

        private void P_jog()
        {
            ProfileType profileType = ProfileType.Trapezoidal;
            int slaveNum = gVar.intAxisNum;
            double vel = Convert.ToDouble(txt_jspeed.Text);
            double acc = Convert.ToDouble(txt_jacc.Text);
            double dec = Convert.ToDouble(txt_jacc.Text);

            MainForm.jog_P(profileType, slaveNum, vel, acc, dec);
        }
        private void N_jog()
        {
            ProfileType profileType = ProfileType.Trapezoidal;
            int slaveNum = gVar.intAxisNum;
            double vel = Convert.ToDouble(txt_jspeed.Text) * (-1);
            double acc = Convert.ToDouble(txt_jacc.Text);
            double dec = Convert.ToDouble(txt_jacc.Text);

            MainForm.jog_P(profileType, slaveNum, vel, acc, dec);
        }

        private void jogplus_MouseDown(object sender, MouseEventArgs e)
        {
            P_jog();
        }

        private void jogplus_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.stop(gVar.intAxisNum);
        }
      
        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (rdobt[i].Checked == true)
                {
                    gVar.intAxisNum = i;
                   
                }
            }
            change_txt();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            SaveMotionData();
            Close();
        }

        private void Absnum(object sender, EventArgs e)
        {

            Button AbsNum = (Button)sender;
            for (int i = 0; i < 4; i++)
            {
                double target;
                if (PosNum[i] == AbsNum)
                {
                    target = Convert.ToDouble(txtPos[i].Text);
                    AbsMove(target);
                }
            }
        }
        private void AbsMove(double target)
        {
            double vel = Convert.ToDouble(txtspeed.Text);
            double acc = Convert.ToDouble(txtacc_d.Text);
            double dec = Convert.ToDouble(txtacc_d.Text);
            int slaveNum = gVar.intAxisNum;
            ProfileType profileType = ProfileType.Trapezoidal;

            MainForm.W_MotionMove0(target,slaveNum, vel, acc, dec);
        }

        private void txtpos1_TextChanged(object sender, EventArgs e)
        {

        }

        private void axis_home_Click(object sender, EventArgs e)
        {
          MainForm.homing(gVar.intAxisNum);
        }

        private void btE_Stop_Click(object sender, EventArgs e)
        {
            MainForm.bt_stop();
        }

        private void jogminus_MouseDown(object sender, MouseEventArgs e)
        {
            N_jog();
        }

        private void jogminus_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.stop(gVar.intAxisNum);
        }
        private void btServo_Click(object sender, EventArgs e)
        {
            Servo_ONOFF();
        }
        private void Servo_ONOFF()
        {
            if (MainForm.getaxisstatus(gVar.intAxisNum).ServoOn)
            {
                MainForm.SetServooff(gVar.intAxisNum);
                b_Servo[gVar.intAxisNum] = false;
            }
            else
            {
                MainForm.SetServoOn(gVar.intAxisNum);
                b_Servo[gVar.intAxisNum] = true;
            }
        }
        double X_target;
        double Y_target;
        private void Mulit_Move(object sender, EventArgs e)
        {
            Button btpos = (Button)sender;

            double vel = Convert.ToDouble(speed_xy.Text);
            double acc = Convert.ToDouble(accd_xy.Text);
            double dec = Convert.ToDouble(accd_xy.Text);
            int X_Axis = 0;
            int Y_Axis = 1;
            ProfileType profileType = ProfileType.Trapezoidal;

            if (btpos == M_Move[0])
            {
                X_target = Convert.ToDouble(X_Pos[0].Text);
                Y_target = Convert.ToDouble(Y_Pos[0].Text);
            }
            else if (btpos == M_Move[1])
            {
                X_target = Convert.ToDouble(X_Pos[1].Text);
                Y_target = Convert.ToDouble(Y_Pos[1].Text);
            }
            else if (btpos == M_Move[2])
            {
                X_target = Convert.ToDouble(X_Pos[2].Text);
                Y_target = Convert.ToDouble(Y_Pos[2].Text);
            }
            else if (btpos == M_Move[3])
            {
                X_target = Convert.ToDouble(X_Pos[3].Text);
                Y_target = Convert.ToDouble(Y_Pos[3].Text);
            }
            else if (btpos == M_Move[4])
            {
                X_target = Convert.ToDouble(X_Pos[4].Text);
                Y_target = Convert.ToDouble(Y_Pos[4].Text);
            }
            else if (btpos == M_Move[5])
            {
                X_target = Convert.ToDouble(X_Pos[5].Text);
                Y_target = Convert.ToDouble(Y_Pos[5].Text);
            }
            MainForm.W_Intpl(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            save(gVar.intAxisNum);
        }

        private void save(int index)
        {
            for (int i = 0; i < 8; i++)
            {
                gVar.doAbsPosAxis[index, i] = Convert.ToDouble(txtPos[i].Text);
            }
            SaveAbspos(gVar.intAxisNum);
        }
        private void SaveAbspos(int index)
        {
            String stSection;
            stSection = "Axis" + Convert.ToString(gVar.intAxisNum);

            //Motion Data File 경로 지정
            const string MOTIONINFO = "MotionInfo.ini";

            string AppFilePath, AppFileDir;

            AppFileDir = Application.StartupPath; // 윈도우즈 Applicaiton Program 디렉토리명 얻어오기 
            AppFilePath = AppFileDir + "\\" + MOTIONINFO;

            for (int i = 0; i < 8; i++)
            {
                clsINIFile.SetValue(stSection, "ABS info" + i, Convert.ToString(gVar.doAbsPosAxis[index, i]), AppFilePath);
            }
        }
        private void change_txt()
        {
            for (int i = 0; i < 8; i++)
            {
                txtPos[i].Text = Convert.ToString(gVar.doAbsPosAxis[gVar.intAxisNum, i]);
            }
        }
        public void ReadAbspos()
        {
            String stSection;
            for (int i = 0; i < 4; i++)
            {
                stSection = "Axis" + Convert.ToString(i);


                // Motion Data File 경로 지정
                const string MOTIONINFO = "MotionInfo.ini";

                string AppFilePath, AppFileDir;

                AppFileDir = Application.StartupPath; // 윈도우즈 Applicaiton Program 디렉토리명 얻어오기 
                AppFilePath = AppFileDir + "\\" + MOTIONINFO;

                    for (int j = 0; j < 8; j++)
                    {
                        gVar.doAbsPosAxis[i, j] = Convert.ToInt32(clsINIFile.GetValue(stSection, "ABS info" + j, AppFilePath));
                    }
            }
        }

        private void SaveMotionData()
        {
            for (int i = 0; i < 6; i++)
            {
                gVar.X_Pos[i] = Convert.ToDouble(X_Pos[i].Text);
                gVar.Y_Pos[i] = Convert.ToDouble(Y_Pos[i].Text);
            }
            String stSection;

            stSection = "X-Y Pos";

            //Motion Data File 경로 지정
            const string MOTIONINFO = "MotionInfo.ini";

            string AppFilePath, AppFileDir;

            AppFileDir = Application.StartupPath; // 윈도우즈 Applicaiton Program 디렉토리명 얻어오기 
            AppFilePath = AppFileDir + "\\" + MOTIONINFO;

            for (int i = 0; i < 6; i++)
            {
                clsINIFile.SetValue(stSection, "X-Pos" + i, Convert.ToString(gVar.X_Pos[i]), AppFilePath);
                clsINIFile.SetValue(stSection, "Y-Pos" + i, Convert.ToString(gVar.Y_Pos[i]), AppFilePath);
            }
            clsINIFile.SetValue(stSection, "M-Speed", speed_xy.Text, AppFilePath);
            clsINIFile.SetValue(stSection, "M-Acc/D", accd_xy.Text, AppFilePath);
            clsINIFile.SetValue(stSection, "Select Axis", Convert.ToString(gVar.intAxisNum), AppFilePath);
        }
        public void ReadMotionData()
        {
            String stSection;

            stSection = "X-Y Pos";

            //Motion Data File 경로 지정
            const string MOTIONINFO = "MotionInfo.ini";

            string AppFilePath, AppFileDir;

            AppFileDir = Application.StartupPath; // 윈도우즈 Applicaiton Program 디렉토리명 얻어오기 
            AppFilePath = AppFileDir + "\\" + MOTIONINFO;

            for (int i = 0; i < 6; i++)
            {
             gVar.X_Pos[i] = Convert.ToDouble(clsINIFile.GetValue(stSection, "X-Pos" + i, AppFilePath));
             gVar.Y_Pos[i] = Convert.ToDouble(clsINIFile.GetValue(stSection, "Y-Pos" + i, AppFilePath));
            }
            gVar.XY_Speed = Convert.ToInt32(clsINIFile.GetValue(stSection, "M-Speed", AppFilePath));
            gVar.XY_AccD = Convert.ToInt32(clsINIFile.GetValue(stSection, "M-Acc/D", AppFilePath));
            gVar.intAxisNum = Convert.ToInt32(clsINIFile.GetValue(stSection, "Select Axis", AppFilePath));

            rdobt[gVar.intAxisNum].Checked = true;

            txtPos_Setting();
        }

        private void txtPos_Setting()
        {
            for (int i = 0; i < 6; i++)
            {
                X_Pos[i].Text = Convert.ToString(gVar.X_Pos[i]);
                Y_Pos[i].Text = Convert.ToString(gVar.Y_Pos[i]);
            }
            speed_xy.Text = Convert.ToString(gVar.XY_Speed);
            accd_xy.Text = Convert.ToString(gVar.XY_AccD);
        }
        private void W_Motion_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMotionData();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            MainForm.stop(0);
            MainForm.stop(1);
            MainForm.stop(2);
            MainForm.stop(3);
        }

        private void W_Motion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVXRobotCommand avxrobocmd = new AVXRobotCommand();
            AdvMotion.PVTIntplCommand pvtinterpcmd = new AdvMotion.PVTIntplCommand();
            avxrobocmd.Axis[0] = 0;
            avxrobocmd.Axis[1] = 1;
            avxrobocmd.Axis[2] = 2;
            avxrobocmd.Axis[4] = 3;
            avxrobocmd.AxisCount = 4;
            avxrobocmd.CommCycle = 1000;
            avxrobocmd.LinearMode = false;
            avxrobocmd.maxVelocity[0] = 1000;
            avxrobocmd.maxVelocity[1] = 1000;
            avxrobocmd.maxVelocity[2] = 1000;
            avxrobocmd.maxVelocity[3] = 1000;
            avxrobocmd.Velocity = 1000;
            avxrobocmd.VibLimit = 5;
            avxrobocmd.enAvsType = AVXRobotCommand.AvsType.ZV;
            avxrobocmd.enInterplType = AVXRobotCommand.Linear_Intpl_Profile_Calc_Mode.MatchFarthestAxis;
            avxrobocmd.Acc = 10000;
            for (int i = 0; i < 6; i++)
            {
                avxrobocmd.doDRatio[i] = 0;
            }
            avxrobocmd.doNfreq[0] = 3;
            avxrobocmd.doNfreq[1] = 3;

            avxrobocmd.doNfreq[2] = 7;
            avxrobocmd.doNfreq[3] = 7;

            avxrobocmd.doNfreq[4] = 11;
            avxrobocmd.doNfreq[5] = 11;
            avxrobocmd.CurrentPos[0] = MainForm.getaxisstatus(0).PosCmd;
            avxrobocmd.CurrentPos[1] = MainForm.getaxisstatus(1).PosCmd;
            avxrobocmd.CurrentPos[2] = MainForm.getaxisstatus(2).PosCmd;
            avxrobocmd.CurrentPos[3] = MainForm.getaxisstatus(3).PosCmd;

            avxrobocmd.TargetPos[0] = 10000;
            avxrobocmd.TargetPos[1] = 10000;
            avxrobocmd.TargetPos[2] = avxrobocmd.CurrentPos[2];
            avxrobocmd.TargetPos[3] = avxrobocmd.CurrentPos[3];

            //avx.AVSMotion(avxrobocmd, out pvtinterpcmd);

        }
    }
}
