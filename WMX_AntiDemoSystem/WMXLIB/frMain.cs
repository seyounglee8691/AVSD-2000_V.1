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
using WMX_Test;
using AvxApi;
namespace WMX_Anti
{
    public partial class Main_Form : Form
    {

        AvXMotion avx;
        WMXLIB_Main wmxLIB_Main;

        frLoading frloding;
        fr_parm fr_W;
        TextBox[] OP_St;
        TextBox[] st_POS;
        TextBox[] txtPos, txtVel;
        public TextBox[] CP, AP;
        public int cAxis;
        Button[] bt_Xmove, bt_Ymove, bt_XYmove;
        Label[] st_ORG, st_NEL, st_PEL, st_ALM;
        CheckBox[] input_IO, output_IO;
        int err = ErrorCode.None;

        delegate void ProgressDelegate(int i);
        delegate void CloseDelegate();

        int Buffering = 0;
        bool[] HomeT = new bool[4];
        bool Servo;
        bool F_stop;
        // bool Routione_Check = true;
        string stRoutine;
        int barValue;
        int Routine;
        int Count = 0;
        int axis;
        Thread MotionThread;
        bool MotionChange;

        int actual_Box;

        public Main_Form()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            wmxLIB_Main = new WMXLIB_Main();
            wmxLIB_Main.WmxLIB_Main();
            InitializeComponent();
            CreateDevice();
            StartCommunication();
            T_st();
            ReadMotionData();
            ReadAbspos();


        }


        bool _wantToClose = true;


        private void UpDateThread()
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
                                    for (int i = 0; i < 4; i++)
                                    {
                                        MotionStatus(i);
                                    }
                                    IO_Control();
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

        private void T_st()
        {
            txtVel = new TextBox[4] { textBox9, textBox10, textBox11, textBox12 };
            txtPos = new TextBox[4] { txt_Axis0, txt_Axis1, txt_Axis2, txt_Axis3 };
            OP_St = new TextBox[4] { lbOP_0, lbOP_1, lbOP_2, lbOP_3 };
            st_POS = new TextBox[4] { lbOP_0, lbOP_1, lbOP_2, lbOP_3 };
            st_ORG = new Label[4] { lborg0, lborg1, lborg2, lborg3 };
            st_NEL = new Label[4] { N_EL0, N_EL1, N_EL2, N_EL3 };
            st_PEL = new Label[4] { P_EL0, P_EL1, P_EL2, P_EL3 };
            st_ALM = new Label[4] { lbALM0, lbALM1, lbALM2, lbALM3 };
            CP = new TextBox[4] { cp0, cp1, cp2, cp3 };
            AP = new TextBox[4] { ap0, ap1, ap2, ap3 };
            bt_Xmove = new Button[3] { X_UnMove0, X_UnMove1, X_UnMove2 };
            bt_Ymove = new Button[3] { Y_UnMove0, Y_UnMove1, Y_UnMove2 };
            bt_XYmove = new Button[3] { XY_UnMove0, XY_UnMove1, XY_UnMove2 };
            statusbar.Minimum = 0;
            statusbar.Maximum = 100;

        }
        public void CreateDevice()
        {
            wmxLIB_Main.CreateDevice();
            gVar.progress_ = 30;
        }
        public CoreMotionAxisStatus getaxisstatus(int Axis)
        {
            wmxLIB_Main.Wmx3Lib_cm.GetStatus(ref wmxLIB_Main.CmStatus);

            return wmxLIB_Main.CmStatus.AxesStatus[Axis];
        }
        public void StartCommunication() //엔진에 연결된 플랫폼과 통신
        {
            wmxLIB_Main.StartCommunication();
        }
        private void StopCommunication() //통신 종료
        {
            wmxLIB_Main.StopCommunication();
        }
        private void MotionStatus(int nAxis)
        {
            bool[] bPOT = new bool[4];
            bool[] bNOT = new bool[4];
            bool[] bServo = new bool[4];
            bool[] bHome = new bool[4];
            bool[] bALM = new bool[4];
            //bPOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).PositiveLS;
            //bNOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).NearNegativeLS;
            //bALM[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).AmpAlarm;
            bServo[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).ServoOn;





                CP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).PosCmd.ToString("F0");
                AP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).ActualPos.ToString("F0");
                txtPos[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).ActualPos.ToString("F0");
                txtVel[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).ActualVelocity.ToString("F0");

                OP_STATE(wmxLIB_Main.GetAxisStaus(nAxis).OpState, nAxis);
            
            if (!bServo[nAxis])
            {
                OP_St[nAxis].Text = "OFF";
                OP_St[nAxis].ForeColor = Color.Black;
                st_ORG[nAxis].BackColor = Color.Transparent;
                st_ALM[nAxis].BackColor = Color.Transparent;
                st_NEL[nAxis].BackColor = Color.Transparent;
                st_PEL[nAxis].BackColor = Color.Transparent;
            }
            if (getaxisstatus(nAxis).HomeSwitch)
            {
                if (getaxisstatus(nAxis).HomeDone)
                {
                    st_ORG[nAxis].BackColor = Color.Yellow;
                    HomeT[nAxis] = false;
                }
                else
                {
                    getaxisstatus(nAxis).HomeDone = false;

                }
            }
            else
            {
                st_ORG[nAxis].BackColor = Color.Transparent;
            }
            if (getaxisstatus(nAxis).PositiveLS)
            {
                st_PEL[nAxis].BackColor = Color.Red;
            }
            else
            {
                st_PEL[nAxis].BackColor = Color.Transparent;
            }
            if (getaxisstatus(nAxis).NegativeLS)
            {
                st_NEL[nAxis].BackColor = Color.Red;
            }
            else
            {
                st_NEL[nAxis].BackColor = Color.Transparent;
            }
            if (getaxisstatus(nAxis).AmpAlarm)
            {
                st_ALM[3].BackColor = Color.Red;
            }
            else
            {
                st_ALM[nAxis].BackColor = Color.Transparent;
            }

        }
        private void start_IO()
        {
            wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
            wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
            wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
            led1.Value = false;
            led2.Value = true;
            led3.Value = false;
        }
        private void stop_IO()
        {
            wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
            wmxLIB_Main.SetDigitalOutIO(8, 1, 0);
            wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
            led1.Value = false;
            led2.Value = false;
            led3.Value = false;
        }
        bool bugCheck = false;
        private void IO_Control()
        {
            if (ck_IO.Checked)
            {

                byte[] value = wmxLIB_Main.GetDigitalInIO(24, 1);

                int invalue = value[0];

                for (int count_value = 1; count_value < 8; count_value++)
                {
                    if (((invalue >> count_value) & 0x01) == 0x01)
                    {


                        switch (count_value)
                        {
                            case 1:

                                if (bugCheck == false)
                                {
                                    textBox13.Text += count_value.ToString();
                                    gVar.MotionStop = false;
                                    BarValueCheck = false;
                                    wmxLIB_Main.SetDigitalOutIO(8, 0, 1);
                                    wmxLIB_Main.SetDigitalOutIO(8, 1, 0);
                                    wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
                                    SetCycle_A();
                                    StringBuilder(9);
                                }

                                bugCheck = true;

                                break;
                            case 2:
                                bugCheck = false;
                                textBox13.Text += count_value.ToString();
                                wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                                wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
                                wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
                                bt_stop();
                                break;
                        }
                    }
                }
            }
        }
        private void OP_STATE(WMX3ApiCLR.OperationState state, int nAxis)
        {
            switch (state)
            {
                case WMX3ApiCLR.OperationState.Idle:
                    {
                        OP_St[nAxis].Text = "Idle";
                        OP_St[nAxis].ForeColor = Color.White;
                    } break;
                case WMX3ApiCLR.OperationState.Pos:
                    {
                        OP_St[nAxis].Text = "Pos";
                        OP_St[nAxis].ForeColor = Color.LimeGreen;
                    } break;
                case WMX3ApiCLR.OperationState.Jog:
                    {
                        OP_St[nAxis].Text = "Jog";
                        OP_St[nAxis].ForeColor = Color.LimeGreen;
                    } break;
                case WMX3ApiCLR.OperationState.Intpl:
                    {
                        OP_St[nAxis].Text = "Intpl";
                        OP_St[nAxis].ForeColor = Color.LimeGreen;
                    } break;
                case WMX3ApiCLR.OperationState.PVT:
                    {
                        OP_St[nAxis].Text = "PVT";
                        OP_St[nAxis].ForeColor = Color.LimeGreen;
                    } break;
                case WMX3ApiCLR.OperationState.Stop:
                    {
                        OP_St[nAxis].Text = "Stop";
                        OP_St[nAxis].ForeColor = Color.DarkRed;
                    } break;
                case WMX3ApiCLR.OperationState.Home:
                    {
                        OP_St[nAxis].Text = "Home";
                        OP_St[nAxis].ForeColor = Color.Yellow;
                    } break;
                default:
                    {
                        OP_St[nAxis].Text = "";
                    } break;
            }
        }
        public void SetServoOn(int Axis) //서보 ON
        {
            Servo = true;
            wmxLIB_Main.ServoOn(Axis, 1);

        }
        private void LogMeassage(string text)
        {
            txtLog.Text = text;
        }
        private void StringBuilder(int Num)
        {
            string dtDate, dtTime;
            DateTime dtNow = DateTime.Now;
            dtDate = dtNow.ToShortDateString();
            dtTime = dtNow.ToLongTimeString();
            StringBuilder sb = new StringBuilder();

            if (Servo == true)
            {
                if (gVar.MotionNum == 11 || gVar.MotionNum == 12 || gVar.MotionNum == 13 || gVar.MotionNum == 14 || gVar.MotionNum == 15 || gVar.MotionNum == 20)
                {
                    return;
                }
                else
                {
                    switch (Num)
                    {

                        case 0:
                            {
                                sb.AppendLine("Initallize Completed");
                            } break;
                        case 1:
                            {
                                sb.AppendLine("SERVO ON");
                                txtLog.ForeColor = Color.LimeGreen;
                            } break;
                        case 2:
                            {
                                sb.AppendLine("Homeing");
                                // textBox1.ForeColor = Color.LimeGreen;
                            } break;
                        case 5:
                            {
                                sb.AppendLine("X Axis, Un shaped MOVE");
                            } break;
                        case 6:
                            {
                                sb.AppendLine("Y Axis, Un shaped MOVE");
                            } break;
                        case 7:
                            {
                                sb.AppendLine("X,Y Axis, Un shaped MOVE");
                            } break;
                        case 8:
                            {
                                sb.AppendLine("Before Cycle MOVE");
                            } break;
                        case 9:
                            {
                                sb.AppendLine("After Cycle MOVE");
                            } break;
                        case 10:
                            {
                                sb.AppendLine("Axis Stop");
                            } break;
                    }
                    txtLog.ForeColor = Color.LimeGreen;
                    if (Num == 10)
                    {
                        txtLog.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                sb.AppendLine("SERVO OFF");
                txtLog.ForeColor = Color.Red;
            }
            txtLog.Text += dtDate + ", " + dtTime + ": " + sb;

        }
        public void SetServooff(int Axis) // 0번축 서보 OFF
        {
            wmxLIB_Main.ServoOn(Axis, 0);

        }

        private void Servo_ON_Click(object sender, EventArgs e)
        {
            if (Servo == false)
            {
                for (int i = 0; i <= 3; i++)
                {
                    SetServoOn(i);

                    Servo_ON.BackColor = Color.LimeGreen;
                }
                StringBuilder(1);

            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    SetServooff(i);
                    Servo = false;

                    Servo_ON.BackColor = Color.Red;
                }
                StringBuilder(0);
            }
        }
        public void homing(int Axis)
        {
            wmxLIB_Main.Homeing(Axis);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gVar.boInitComp)
            {
                InitProcess();
            }
            //     if (gVar.boInitComp)
            {
                Unshaped_Cycle();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.SetDigitalOutIO(8, 0, 1);
        }

        private void btParameter_Click(object sender, EventArgs e)
        {
            fr_W = new fr_parm(this);
            fr_W.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                SetServooff(i);
            }

            StopCommunication();
            wmxLIB_Main.CloseDevice();

            this.Close();
        }
        private void Delay(int delay)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, delay);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (true)
            {
                ThisMoment = DateTime.Now;

                System.Windows.Forms.Application.DoEvents();

                if (AfterWards <= ThisMoment)
                {
                    break;
                }
            }
        }
        public void jog_P(ProfileType profileType, int Axis, double vel, double acc, double dec)
        {
            wmxLIB_Main.jogplus_MouseDown(profileType, Axis, vel, acc, dec);
        }
        void intiallize_M(int Axis, double posNum, double vel, double acc, double dec)
        {
            double target = gVar.doAbsPosAxis[Axis, Convert.ToInt16(posNum)];
            ProfileType profileType = ProfileType.Trapezoidal;

            cAxis = Axis;

            wmxLIB_Main.Run_ABSMOVE(wmxLIB_Main.SetTrajQ(target, vel, acc, dec, Axis, profileType));
        }
        public void UnMove(int Axis, double posNum)
        {
            double target = gVar.doAbsPosAxis[Axis, Convert.ToInt16(posNum)];
            double vel = gVar.doAbsPosAxis[Axis, 4];
            double acc = gVar.doAbsPosAxis[Axis, 5];
            double dec = gVar.doAbsPosAxis[Axis, 5];
            ProfileType profileType = ProfileType.Trapezoidal;

            cAxis = Axis;

            wmxLIB_Main.Run_ABSMOVE(wmxLIB_Main.SetTrajQ(target, vel, acc, dec, Axis, profileType));

            if (Axis == 0)
            {
                StringBuilder(5);
            }
            else if (Axis == 1)
            {
                StringBuilder(6);
            }
        }
        public void W_MotionMove0(double target, int Axis, double vel, double acc, double dec)
        {
            ProfileType profileType = ProfileType.Trapezoidal;
            wmxLIB_Main.Run_ABSMOVE(wmxLIB_Main.SetTrajQ(target, vel, acc, dec, Axis, profileType));
        }


        #region ###
        private void SetCycle_B()
        {
            getcount = 0;
            statusbar.Value = 0;
            barValue = 100 / Convert.ToInt16(txtcount.Text);
            F_stop = false;

            MotionThread = new Thread(delegate()
            {
                BeFore_Cycle();

            });
            MotionThread.Start();

        }
        private void SetCycle_A()
        {


            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos)
            {
                statusbar.Value = 0;
                barValue = 100 / Convert.ToInt16(txtcount.Text);
                getcount = 0;
                F_stop = false;

                MotionThread = new Thread(delegate()
                {
                    After_Cycle();
                });
                MotionThread.Start();
            }
        }
        private void step(int index)
        {
            statusbar.Value += index;
        }

        #endregion

        #region intiallize
        private void InitProcess()
        {
            switch (gVar.MotionNum)
            {
                case 11:
                    {
                        homing(0);
                        homing(1);
                        homing(2);
                        gVar.MotionNum = 12;
                        statusbar.Value = 20;

                    }
                    break;
                case 12:
                    {
                        tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(0).HomeDone && wmxLIB_Main.GetAxisStaus(1).HomeDone)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            wmxLIB_Main.Wait(2);
                            Thread.Sleep(100);
                            gVar.MotionNum = 13;
                            statusbar.Value = 50;
                        }
                        tmCycle.Start();
                    }
                    break;
                case 13:
                    {
                        intiallize_M(0, 0, 100000, 1000000, 1000000);
                        gVar.MotionNum = 14;
                        statusbar.Value = 60;
                    }
                    break;
                case 14:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            Thread.Sleep(300);
                            gVar.MotionNum = 15;
                            statusbar.Value = 80;
                        }
                    }
                    break;
                case 15:
                    {
                        intiallize_M(1, 0, 100000, 1000000, 1000000);
                        gVar.MotionNum = 20;
                        statusbar.Value = 90;
                    }
                    break;
                case 16:
                    {

                        tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(2).HomeDone == true)
                        {

                            wmxLIB_Main.Wait(2);
                            Thread.Sleep(200);
                            gVar.MotionNum = 17;
                        }
                        tmCycle.Start();
                    }
                    break;
                case 17:
                    {
                        UnMove(0, 0);
                        gVar.MotionNum = 18;
                    }
                    break;
                case 18:
                    {
                        // tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            Thread.Sleep(100);
                            gVar.MotionNum = 19;
                        }
                    }
                    break;
                case 19:
                    {
                        UnMove(1, 0);
                        gVar.MotionNum = 20;
                    }
                    break;
                case 20:
                    {
                        // tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(1);
                            Thread.Sleep(100);
                            gVar.MotionNum = 200;
                            gVar.boInitComp = true;
                            statusbar.Value = 100;
                            StringBuilder(0);
                            MessageBox.Show("초기화작업을 완료하였습니다.", "intiallize", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                    }
                    break;
                case 200:
                    {


                    } break;
            }
        }
        #endregion
        int getcount = 0;
        #region Unshaped Cycle
        private void Unshaped_Cycle()
        {

            switch (gVar.MotionNum)
            {
                case 50:
                    {
                        UnMove(gVar.AxisNum, 0);
                        gVar.MotionNum = 51;
                    } break;
                case 51:
                    {
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            Thread.Sleep(0);
                            gVar.MotionNum = 52;
                        }
                    }
                    break;
                case 52:
                    {
                        UnMove(gVar.AxisNum, 2);
                        gVar.MotionNum = 53;
                    }
                    break;
                case 53:
                    {
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            Thread.Sleep(0);
                            gVar.MotionNum = 54;
                        }
                    }
                    break;
                case 54:
                    {
                        UnMove(gVar.AxisNum, 0);
                        tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            Thread.Sleep(0);
                        }
                    }
                    break;
                //case 6:
                //    {
                //        H_MulitPos(0, 0);
                //        gVar.MotionNum = 7;
                //    }
                //    break;
                //case 7:
                //    {
                //        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                //        {
                //            wmxLIB_Main.Wait(0);
                //            wmxLIB_Main.Wait(1);
                //            Thread.Sleep(300);
                //            gVar.MotionNum = 8;
                //        }
                //    }
                //    break;

                case 60:
                    {
                        MulitPos(0, 0);
                        gVar.MotionNum = 61;
                    }
                    break;
                case 61:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            Thread.Sleep(0);
                            gVar.MotionNum = 62;
                        }
                    }
                    break;
                case 62:
                    {

                        MulitPos(4, 2);
                        gVar.MotionNum = 63;

                    }
                    break;
                case 63:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            Thread.Sleep(0);
                            gVar.MotionNum = 64;

                        }

                    }
                    break;
                case 64:
                    {
                        MulitPos(0, 0);
                        tmCycle.Stop();
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            Thread.Sleep(0);

                        }
                    }
                    break;
                case 70:
                    {
                        UnMove(2, 0);
                        gVar.MotionNum = 71;
                    }
                    break;
                case 71:
                    {
                        if (wmxLIB_Main.GetAxisStaus(2).InPos == true && wmxLIB_Main.GetAxisStaus(2).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(2);
                            Thread.Sleep(0);
                            gVar.MotionNum = 72;
                        }
                    }
                    break;
                case 72:
                    {
                        UnMove(2, 1);
                        gVar.MotionNum = 73;
                    }
                    break;
                case 73:
                    {
                        if (wmxLIB_Main.GetAxisStaus(2).InPos == true && wmxLIB_Main.GetAxisStaus(2).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(2);
                            Thread.Sleep(0);
                            gVar.MotionNum = 70;
                        }
                    }
                    break;
                #region 비포루틴
                case 80:
                    {
                        getcount = getcount + 1;
                        before_position(10000, 10000);
                        gVar.MotionNum = 81;
                    }
                    break;
                case 81:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Thread.Sleep(50);
                            gVar.MotionNum = 82;
                        }
                    }
                    break;
                case 82:
                    {
                        before_position(90000, 90000);
                        gVar.MotionNum = 83;
                    }
                    break;
                case 83:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //   Thread.Sleep(50);
                            gVar.MotionNum = 84;
                        }
                    }
                    break;
                case 84:
                    {
                        before_position(200000, 200000);
                        gVar.MotionNum = 85;
                    }
                    break;
                case 85:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //     Thread.Sleep(50);
                            gVar.MotionNum = 86;
                        }
                    }
                    break;
                case 86:
                    {
                        before_position(90000, 90000);
                        gVar.MotionNum = 87;
                    }
                    break;
                case 87:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //      Thread.Sleep(50);
                            gVar.MotionNum = 88;
                        }
                    }
                    break;
                case 88:
                    {
                        before_position(200000, 10000);
                        gVar.MotionNum = 89;
                    }
                    break;
                case 89:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //       Thread.Sleep(50);
                            gVar.MotionNum = 90;
                        }
                    }
                    break;
                case 90:
                    {
                        if (getcount == Convert.ToInt16(txtcount.Text))
                        {
                            before_position(10000, 10000);
                            tmCycle.Stop();
                            getcount = 0;
                            if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                            {

                                wmxLIB_Main.Wait(0);
                                wmxLIB_Main.Wait(1);
                                Thread.Sleep(50);
                            }
                            if (ck_IO.Checked)
                            {
                                wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                                wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
                                wmxLIB_Main.SetDigitalOutIO(8, 2, 0);

                            }

                            //  gVar.MotionNum = 90;              
                        }
                        else
                        {
                            gVar.MotionNum = 80;
                        }

                    }
                    break;
                #endregion
            }
        }
        bool BarValueCheck = false;
        private void After_Cycle()
        {
            //do
            //{
            //    getcount++;
            //    //       statusbar.Value += barValue;
            //    wmxLIB_Main.avx_Cycle(0,0);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(0);

            //    wmxLIB_Main.avx_Cycle(1, 1);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(0);

            //    wmxLIB_Main.avx_Cycle(2, 2);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(0);

            //    wmxLIB_Main.avx_Cycle(3, 3);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(0);

            //    wmxLIB_Main.avx_Cycle(4, 4);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(0);

            //    wmxLIB_Main.avx_Cycle(0, 0);
            //    this.Invoke(new ProgressDelegate(step), barValue);
            //    F_stop = true;
            //    Count++;

            //    wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
            //    wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
            //    wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
            //    led1.Value = false;
            //    led2.Value = true;
            //    led3.Value = false;
            //} 
            //while (getcount < Convert.ToInt16(txtcount.Text));
            while (getcount < Convert.ToInt16(txtcount.Text))
            {
                getcount++;
                //         statusbar.Value += barValue;
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(0, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                } if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(1, 1);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(2, 2);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(3, 3);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(4, 4);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(0, 0);
                }
                if (BarValueCheck == true)
                {
                    this.Invoke(new ProgressDelegate(step), barValue);
                }

                if (getcount >= Convert.ToInt16(txtcount.Text))
                {
                    wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                    wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
                    wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
                    led1.Value = false;
                    led2.Value = true;
                    led3.Value = false;
                    BarValueCheck = false;
                }
            }
        }

        private void BeFore_Cycle()
        {
            //   do
            //   {
            //       getcount++;
            ////       statusbar.Value += barValue;

            //      MulitPos(0, 0);
            //       wmxLIB_Main.Wait(0);
            //       wmxLIB_Main.Wait(1);
            //       Thread.Sleep(0);

            //       MulitPos(1, 1);
            //       wmxLIB_Main.Wait(0);
            //       wmxLIB_Main.Wait(1);
            //       Thread.Sleep(0);

            //       MulitPos(2, 2);
            //       wmxLIB_Main.Wait(0);
            //       wmxLIB_Main.Wait(1);
            //       Thread.Sleep(0);

            //       MulitPos(3, 3);
            //       wmxLIB_Main.Wait(0);
            //       wmxLIB_Main.Wait(1);
            //       Thread.Sleep(0);

            //       MulitPos(4, 4);
            //       wmxLIB_Main.Wait(0);
            //       wmxLIB_Main.Wait(1);
            //       Thread.Sleep(0);

            //       MulitPos(0, 0);
            //       this.Invoke(new ProgressDelegate(step), barValue);
            //       F_stop = true;
            //       Count++;

            //       wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
            //       wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
            //       wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
            //       led1.Value = false;
            //       led2.Value = true;
            //       led3.Value = false;
            //   } while (getcount < Convert.ToInt16(txtcount.Text));

            while (getcount < Convert.ToInt16(txtcount.Text))
            {
                getcount++;
                //statusbar.Value += barValue;
                //       statusbar.Value += barValue;
                if (!gVar.MotionStop)
                {
                    MulitPos(0, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    MulitPos(1, 1);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    MulitPos(2, 2);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    MulitPos(3, 3);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    MulitPos(4, 4);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    MulitPos(0, 0);
                }

                this.Invoke(new ProgressDelegate(step), barValue);


                if (getcount >= Convert.ToInt16(txtcount.Text))
                {
                    wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                    wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
                    wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
                    led1.Value = false;
                    led2.Value = true;
                    led3.Value = false;

                }
            }
        }
        #endregion
        private void M_Cycle(int Axis)
        {
            int Count = 0;

        }

        #region 축이동
        private void Axis_Move()
        {

            switch (Count)
            {
                case 0:
                    {
                        //     timer2.Stop();
                        UnMove(gVar.AxisNum, 0);
                        Count = 1;
                        //   timer2.Start();
                    } break;
                case 1:
                    {
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            //Delay(1000);
                            Thread.Sleep(100);
                            Count = 2;
                        }
                    } break;
                case 2:
                    {
                        //     timer2.Stop();
                        UnMove(gVar.AxisNum, 2);
                        Count = 3;
                        //           timer2.Start();
                    } break;
                case 3:
                    {
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            //Delay(1000);
                            Thread.Sleep(100);
                            Count = 4;
                        }
                    } break;
                case 4:
                    {
                        //    timer2.Stop();
                        UnMove(gVar.AxisNum, 0);
                        if (wmxLIB_Main.GetAxisStaus(gVar.AxisNum).InPos == true && wmxLIB_Main.GetAxisStaus(gVar.AxisNum).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(gVar.AxisNum);
                            wmxLIB_Main.Routione_Check = true;
                            Thread.Sleep(100);
                        }
                    } break;
            }
        }
        #endregion

        #region Y Unshaped
        private void Y_UnMove0_Click(object sender, EventArgs e)
        {
            Button Y_axisMove = (Button)sender;

            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                for (int num = 0; num < 3; num++)
                {
                    if (bt_Ymove[num] == Y_axisMove)
                    {
                        //       if (gVar.boInitComp)
                        {
                            UnMove(1, num);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void Y_UnMove1_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                UnMove(1, 1);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void Y_UnMove2_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                UnMove(1, 2);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void Y_UnMove3_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                gVar.AxisNum = 1;
                gVar.MotionNum = 50;
                tmCycle.Start();
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }
        #endregion
        #region X Unshaped
        private void X_UnMove0_Click(object sender, EventArgs e)
        {
            Button X_axisMove = (Button)sender;

            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos)
            {
                for (int num = 0; num < 3; num++)
                {
                    if (bt_Xmove[num] == X_axisMove)
                    {
                        //          if (gVar.boInitComp)
                        {
                            UnMove(0, num);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }
        private void X_UnMove3_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos)
            {
                gVar.AxisNum = 0;
                gVar.MotionNum = 50;
                tmCycle.Start();
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }
        #endregion
        #region X_Y 축이동
        private void XY_UnMove0_Click(object sender, EventArgs e)
        {
            Button XY_axismove = (Button)sender;

            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                if (XY_axismove == bt_XYmove[0])
                {
                    //      if (gVar.boInitComp)
                    {
                        MulitPos(0, 0);
                    }
                }
                if (XY_axismove == bt_XYmove[1])
                {
                    //     if (gVar.boInitComp)
                    {
                        MulitPos(1, 1);
                    }
                }
                if (XY_axismove == bt_XYmove[2])
                {
                    //    if (gVar.boInitComp)
                    {
                        MulitPos(4, 2);
                    }
                }
                StringBuilder(7);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }

        }

        private void XY_UnMove1_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                MulitPos(0, 1);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }

        }

        private void XY_UnMove2_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                MulitPos(2, 3);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }

        }

        private void XY_UnMove3_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                gVar.H_speed = 8000;
                gVar.MotionNum = 60;
                tmCycle.Start();
                StringBuilder(7);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
                wmxLIB_Main.Wait(axis);
            }
        }
        #endregion
        private void WMX3_Anti_Demo_Load(object sender, EventArgs e)
        {
            wmxLIB_Main.ImportParm();

            for (int i = 0; i <= 3; i++)
            {
                SetServoOn(i);
            }
            UpDateThread();
            timer1.Start();
            IO_check();
        }

        private void IO_check()
        {
            ck_IO.Checked = true;
            if (gVar.startcomp)
            {
                wmxLIB_Main.SetDigitalOutIO(0, 0, 0);
                wmxLIB_Main.SetDigitalOutIO(0, 1, 0);
                wmxLIB_Main.SetDigitalOutIO(0, 2, 1);
            }
        }
        #region 파라미터
        private void ReadAbspos()
        {
            String stSection;
            for (int i = 0; i < 4; i++)
            {
                stSection = "Axis" + Convert.ToString(i);


                //Motion Data File 경로 지정
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
        private void ReadMotionData()
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
        }
        #endregion

        public void W_Intpl(double X_target, double Y_target, double vel, double acc, double dec, int X_Axis, int Y_Axis, ProfileType profileType)
        {
            wmxLIB_Main.LinearInterpolation(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType);
        }
        private void before_position(double X_target, double Y_target)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = gVar.XY_Speed;
            double acc = gVar.XY_AccD;
            double dec = gVar.XY_AccD;
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_LinMOVE(wmxLIB_Main.SetLin(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));
        }
        private void MulitPos(int X_Pos, int Y_Pos)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = gVar.XY_Speed;
            double acc = gVar.XY_AccD;
            double dec = gVar.XY_AccD;
            double X_target = gVar.X_Pos[X_Pos];
            double Y_target = gVar.Y_Pos[Y_Pos];
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_LinMOVE(wmxLIB_Main.SetLin(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));


        }
        private void H_MulitPos(int X_Pos, int Y_Pos)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = gVar.XY_Speed;
            double acc = gVar.XY_AccD;
            double dec = gVar.XY_AccD;
            double X_target = X_Pos;
            double Y_target = Y_Pos;
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_LinMOVE(wmxLIB_Main.SetLin(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));
            //Thread.Sleep(100);
        }
        private void PVTPOS(int X_Pos, int Y_Pos)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = gVar.XY_Speed;
            double acc = gVar.XY_AccD;
            double dec = gVar.XY_AccD;
            double X_target = gVar.X_Pos[X_Pos];
            double Y_target = gVar.Y_Pos[Y_Pos];
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_PVTMOVE(wmxLIB_Main.Set_PVT(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));
        }

        private void Z_UnMove0_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                // gVar.MotionNum = 70;
                UnMove(2, 0);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void Z_UnMove1_Click(object sender, EventArgs e)
        {
            if (wmxLIB_Main.GetAxisStaus(0).InPos && wmxLIB_Main.GetAxisStaus(1).InPos && wmxLIB_Main.GetAxisStaus(2).InPos == true)
            {
                UnMove(2, 1);
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void btE_Stop_Click(object sender, EventArgs e)
        {
            bt_stop();

            if (ck_IO.Checked)
            {
                wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                wmxLIB_Main.SetDigitalOutIO(8, 1, 1);
                wmxLIB_Main.SetDigitalOutIO(8, 2, 0);
                led1.Value = false;
                led2.Value = true;
                led3.Value = false;
            }
        }
        public void bt_stop()
        {
            for (int i = 0; i < 4; i++)
            {
                QuickStop(i);
            }
            tmCycle.Stop();
            gVar.MotionStop = true;
            wmxLIB_Main.Routione_Check = true;
            Thread.Sleep(100);
            Delay(100);
            StringBuilder(10);

        }
        public void QuickStop(int Axis)
        {
            wmxLIB_Main.QuickStop(Axis);
        }
        public void stop(int Axis)
        {
            wmxLIB_Main.stop(Axis);
        }
        #region TEST
        //private void Setting_Pos()
        //{
        //    switch (gVar.MotionNum)
        //    {
        //        case 30:
        //            {
        //      //          timer2.Stop();
        //                H_MulitPos(0, 0);
        //                gVar.MotionNum = 12;
        //       //         timer2.Start();
        //            } break;
        //        case 31:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    gVar.MotionNum = 13;
        //                }
        //            } break;
        //        case 32:
        //            {
        //            //    timer2.Stop();
        //                MulitPos(2, 3);
        //                gVar.MotionNum = 14;
        //           //     timer2.Start();
        //            } break;
        //        case 33:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    gVar.MotionNum = 15;
        //                }
        //            } break;
        //        case 34:
        //            {
        //         //       timer2.Stop();
        //                MulitPos(4, 5);
        //                gVar.MotionNum = 16;
        //          //      timer2.Start();
        //            } break;
        //        case 35:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    gVar.MotionNum = 17;
        //                }
        //            } break;
        //        case 36:
        //            {
        //          //      timer2.Stop();
        //                MulitPos(6, 7);
        //                gVar.MotionNum = 18;
        //       //         timer2.Start();
        //            } break;
        //        case 37:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    gVar.MotionNum = 19;
        //                }
        //            } break;
        //        case 38:
        //            {
        //         //       timer2.Stop();
        //                MulitPos(0, 1);
        //                gVar.MotionNum = 20;
        //          //      timer2.Start();
        //            } break;
        //        case 39:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    gVar.MotionNum = 21;
        //                }
        //            } break;
        //        case 2:
        //            {
        //          //      timer2.Stop();
        //                H_MulitPos(0, 0);
        //                // Count = 9;
        //                //  timer2.Start();
        //            } break;
        //    }
        //}

        //private void  XY_MPos()
        //{
        //    wmxLIB_Main.Routione_Check = false;
        //    switch (gVar.MotionNum)
        //    {
        //        case 30:
        //            {
        //           //     timer2.Stop();
        //                H_MulitPos(0, 0);
        //                Count = 31;
        //            //    timer2.Start();
        //            } break;
        //        case 31:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    Count = 32;
        //                }
        //            } break;
        //        case 32:
        //            {
        //         //       timer2.Stop();
        //                MulitPos(6, 7);
        //                Count = 33;
        //          //     timer2.Start();
        //            } break;
        //        case 33:
        //            {
        //                if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
        //                {
        //                    wmxLIB_Main.Wait(0);
        //                    wmxLIB_Main.Wait(1);
        //                    //Delay(1000);
        //                    Thread.Sleep(500);
        //                    Count = 34;
        //                }
        //            } break;
        //        case 34:
        //            {
        //                //timer2.Stop();
        //                H_MulitPos(0, 0);
        //                //wmxLIB_Main.Wait(0);
        //                //wmxLIB_Main.Wait(1);
        //                wmxLIB_Main.Routione_Check = true;

        //            } break;
        //    }
        //}
        #endregion

        byte[] ionn = new byte[1];

        private void btStart_Click(object sender, EventArgs e)
        {
            gVar.MotionStop = false;

            if (!MotionChange)
            {
                BarValueCheck = false;
                wmxLIB_Main.SetDigitalOutIO(8, 0, 1);
                wmxLIB_Main.SetDigitalOutIO(8, 1, 0);
                wmxLIB_Main.SetDigitalOutIO(8, 2, 0);

                SetCycle_B();
                led1.Value = true;
                led2.Value = false;
                led3.Value = false;
                StringBuilder(8);
            }
            else
            {
                BarValueCheck = true;
                wmxLIB_Main.SetDigitalOutIO(8, 0, 1);
                wmxLIB_Main.SetDigitalOutIO(8, 1, 0);
                wmxLIB_Main.SetDigitalOutIO(8, 2, 0);

                SetCycle_A();
                led1.Value = true;
                led2.Value = false;
                led3.Value = false;
                StringBuilder(9);
            }
        }
        private void XY_Move0_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.avx_Cycle(0, 0);
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            wmxLIB_Main.AlarmClear(0);
            wmxLIB_Main.AlarmClear(1);
            wmxLIB_Main.AlarmClear(2);
            wmxLIB_Main.AlarmClear(3);
            gVar.boInitComp = false;
            gVar.MotionStop = false;
            Thread.Sleep(100);
            txtLog.Text = "";
            if (ck_IO.Checked)
            {
                wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
                wmxLIB_Main.SetDigitalOutIO(8, 1, 0);
                wmxLIB_Main.SetDigitalOutIO(8, 2, 1);
                led1.Value = false;
                led2.Value = true;
                led3.Value = false;
            }
        }
        private void btintialize_Click(object sender, EventArgs e)
        {

            gVar.boInitComp = false;
            gVar.MotionNum = 11;
            tmCycle.Start();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void X_Move0_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.X_Axis_AVX_MOVE(0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetCycle_B();
            // M_Cycle(0);
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_IO();
            for (int i = 0; i < 4; i++)
            {
                SetServooff(i);
            }
        }
        private void btBofore_Click(object sender, EventArgs e)
        {
            MotionChange = false;
            btAfter.Enabled = true;
            btBefore.Enabled = false;
            btBefore.BackColor = Color.WhiteSmoke;
            btAfter.BackColor = Color.Silver;
        }

        private void btAfter_Click_1(object sender, EventArgs e)
        {
            MotionChange = true;
            btAfter.Enabled = false;
            btBefore.Enabled = true;
            btBefore.BackColor = Color.Silver;
            btAfter.BackColor = Color.WhiteSmoke;
        }
        private void ck_IO_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_IO.Checked)
            {
                start_IO();
            }
            else
            {
                stop_IO();
            }
        }
        int CmdPos = 0;
        int ActualPos = 0;

        private void X_Move1_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.X_Axis_AVX_MOVE(0, 1);
        }

        private void X_Move2_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.X_Axis_AVX_MOVE(0, 2);
        }

        private void X_Move3_Click(object sender, EventArgs e)
        {
            MotionThread = new Thread(delegate()
            {
                X_AVX_Cycle();
            });
            MotionThread.Start();
        }

        private void X_AVX_Cycle()
        {
            if (!gVar.MotionStop)
            {
                wmxLIB_Main.X_Axis_AVX_MOVE(0, 0);
                wmxLIB_Main.Wait(0);
                wmxLIB_Main.Wait(1);
                Thread.Sleep(0);
            } if (!gVar.MotionStop)
            {
                wmxLIB_Main.X_Axis_AVX_MOVE(0, 3);
                wmxLIB_Main.Wait(0);
                wmxLIB_Main.Wait(1);
                Thread.Sleep(0);
            }
            if (!gVar.MotionStop)
            {
                wmxLIB_Main.X_Axis_AVX_MOVE(0, 0);
                wmxLIB_Main.Wait(0);
                wmxLIB_Main.Wait(1);
                Thread.Sleep(0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.Y_Axis_AVX_MOVE(1, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.Y_Axis_AVX_MOVE(1, 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.Y_Axis_AVX_MOVE(1, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MotionThread = new Thread(delegate()
            {
                Y_AVX_Cycle();
            });
            MotionThread.Start();
        }
        private void Y_AVX_Cycle()
        {
            {
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.Y_Axis_AVX_MOVE(1, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                } if (!gVar.MotionStop)
                {
                    wmxLIB_Main.Y_Axis_AVX_MOVE(1, 3);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.Y_Axis_AVX_MOVE(1, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
            }
        }

        private void XY_Move1_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.avx_Cycle(1, 1);
        }
        private void XY_Move2_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.avx_Cycle(2, 2);
        }

        private void XY_Move3_Click(object sender, EventArgs e)
        {
            MotionThread = new Thread(delegate()
            {
                XY_AVX_Cycle();
            });
            MotionThread.Start();
        }
        private void XY_AVX_Cycle()
        {
            {
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(0, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                } if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(2, 2);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
                if (!gVar.MotionStop)
                {
                    wmxLIB_Main.avx_Cycle(0, 0);
                    wmxLIB_Main.Wait(0);
                    wmxLIB_Main.Wait(1);
                    Thread.Sleep(0);
                }
            }
        }
    }
}
