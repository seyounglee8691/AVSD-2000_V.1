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

namespace WMX_Anti
{
    public partial class Main_Form : Form
    {
        WMXLIB_Main wmxLIB_Main;
        WMX3Api WMXLib;
        TextBox[] OP_St;
        TextBox[] st_POS;
        TextBox[] CP, AP;
        Button[] Un_Mmove;
        Button[] bt_Xmove;
        Label[] st_ORG, st_NEL, st_PEL, st_ALM;
        CheckBox[] input_IO, output_IO;
        bool[] HomeT = new bool[4];
        bool Servo;
        bool F_stop;
        bool Routione_Check = true;
        string stRoutine;
        int Routine;
        int Count = 0;
        int axis;
        Thread MotionThread;

        public Main_Form()
        {
            WMXLib = new WMX3Api();
           // wmxLIB_Main.WMXLIB_Main1();
            InitializeComponent();
            T_st();
           
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
                                    for (int i = 0; i < 4; i++)
                                    {
                                        MotionStatus(i);
                                    }
                                }));
                            Thread.Sleep(50);
                            //Delay(50);
                        }
                    }
                    catch
                    {

                    }
                });
            UpDateThread.Start();
            //wmxLIB_Main.
        }

        //private void state(int nAxis)
        //{
        //    bool[] bPOT = new bool[4];
        //    bool[] bNOT = new bool[4];
        //    bool[] bServo = new bool[4];
        //    bool[] bHome = new bool[4];
        //    bool[] bALM = new bool[4];
        //    bPOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).PositiveLS;
        //    bNOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).NearNegativeLS;
        //    bALM[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).AmpAlarm;
        //    bServo[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).ServoOn;
        //  //  CoreMotionAxisStatus

        //    CP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).PosCmd.ToString("F0");
        //    AP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).ActualPos.ToString();

        //    if (bServo[nAxis])
        //    {
        //        if (!wmxLIB_Main.GetAxisStaus(nAxis).InPos)
        //        {
        //            //if (wmxLIB_Main.GetAxisStaus(nAxis).HomeSwitch == true)
        //            //{
        //            //    OP_St[nAxis].Text = "HOME";
        //            //    OP_St[nAxis].ForeColor = Color.Yellow;
        //            //}
        //            if (HomeT[nAxis] == true)
        //            {
        //                OP_St[nAxis].Text = "HOME";
        //                OP_St[nAxis].ForeColor = Color.Yellow;
        //            }
        //            else
        //            {
        //                OP_St[nAxis].Text = "POS";
        //                OP_St[nAxis].ForeColor = Color.LimeGreen;
        //                st_ORG[nAxis].BackColor = Color.Transparent;
        //            }
        //        }
        //        else
        //        {
        //            OP_St[nAxis].Text = "IDLE";
        //            OP_St[nAxis].ForeColor = Color.White;
        //        }
        //        if (wmxLIB_Main.GetAxisStaus(nAxis).HomeDone)
        //        {
        //            st_ORG[nAxis].BackColor = Color.Yellow;
        //            HomeT[nAxis] = false;

        //        }
        //        else
        //        {
        //            st_ORG[nAxis].BackColor = Color.Transparent;
        //        }
        //        if (bPOT[nAxis])
        //        {
        //            st_PEL[nAxis].BackColor = Color.Red;
        //        }
        //        else
        //        {
        //            st_PEL[nAxis].BackColor = Color.Transparent;
        //        }
        //        if (bNOT[nAxis])
        //        {
        //            st_NEL[nAxis].BackColor = Color.Red;
        //        }
        //        else
        //        {
        //            st_NEL[nAxis].BackColor = Color.Transparent;
        //        }
        //        if (bALM[nAxis])
        //        {
        //            st_ALM[nAxis].BackColor = Color.Red;
        //        }
        //        else
        //        {
        //            st_ALM[nAxis].BackColor = Color.Transparent;
        //        }
        //    }
        //    else
        //    {
        //        OP_St[nAxis].Text = "OFF";
        //        OP_St[nAxis].ForeColor = Color.Black;
        //        st_ORG[nAxis].BackColor = Color.Transparent;
        //    }
        //}

        private void T_st()
        {
            OP_St = new TextBox[4] { lbOP_0, lbOP_1, lbOP_2, lbOP_3 };
            st_POS = new TextBox[4] { lbOP_0, lbOP_1, lbOP_2, lbOP_3 };
            st_ORG = new Label[4] { lborg0, lborg1, lborg2, lborg3 };
            st_NEL = new Label[4] { N_EL0, N_EL1, N_EL2, N_EL3 };
            st_PEL = new Label[4] { P_EL0, P_EL1, P_EL2, P_EL3 };
            st_ALM = new Label[4] { lbALM0, lbALM1, lbALM2, lbALM3 };
            CP = new TextBox[4] { cp0, cp1, cp2, cp3 };
            AP = new TextBox[4] { ap0, ap1, ap2, ap3 };
            bt_Xmove = new Button[3] { X_UnMove0, X_UnMove1, X_UnMove2 };
            Un_Mmove = new Button[3] { XY_UnMove0, XY_UnMove1, XY_UnMove2};
            input_IO = new CheckBox[8] { inIO0, inIO1, inIO2, inIO3, inIO4, inIO5, inIO6, inIO7 };
        }
        private void CreateDevice()
        {
            wmxLIB_Main.CreateDevice();

            // wmxLIB_Main.err = wmxLIB_Main.err1;
        }
        private void StartCommunication() //엔진에 연결된 플랫폼과 통신
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
            bPOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).PositiveLS;
            bNOT[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).NearNegativeLS;
            bALM[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).AmpAlarm;
            bServo[nAxis] = wmxLIB_Main.GetAxisStaus(nAxis).ServoOn;
            
           
            CP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).PosCmd.ToString("F0");
            AP[nAxis].Text = wmxLIB_Main.GetAxisStaus(nAxis).ActualPos.ToString("F0");
          
         
            if (bServo[nAxis])
            {
                OP_STATE(wmxLIB_Main.GetAxisStaus(nAxis).OpState, nAxis);
                //OP_St[nAxis].Text = OP_STATE(wmxLIB_Main.GetAxisStaus(nAxis).OpState);

                //if (OP_St[nAxis].Text == "Idle")
                //{
                //    OP_St[nAxis].ForeColor = Color.White;
                //}
                //if (OP_St[nAxis].Text == "Pos")
                //{
                //    OP_St[nAxis].ForeColor = Color.LimeGreen;
                //}
                //if (OP_St[nAxis].Text == "Jog")
                //{
                //    OP_St[nAxis].ForeColor = Color.LimeGreen;
                //}
                //if (OP_St[nAxis].Text == "Intpl")
                //{
                //    OP_St[nAxis].ForeColor = Color.LimeGreen;
                //}
                //if (OP_St[nAxis].Text == "PVT")
                //{
                //    OP_St[nAxis].ForeColor = Color.LimeGreen;
                //}
                //if (OP_St[nAxis].Text == "Stop")
                //{
                //    OP_St[nAxis].ForeColor = Color.DarkRed;
                //}
                //if (OP_St[nAxis].Text == "Home")
                //{
                //    OP_St[nAxis].ForeColor = Color.Yellow;
                //}      
                if (wmxLIB_Main.GetAxisStaus(nAxis).HomeDone)
                {
                    if (wmxLIB_Main.GetAxisStaus(nAxis).HomeSwitch)
                    {
                        st_ORG[nAxis].BackColor = Color.Yellow;
                        HomeT[nAxis] = false;
                    }
                    else
                    {
                        wmxLIB_Main.GetAxisStaus(nAxis).HomeDone = false;
                     //   st_ORG[nAxis].BackColor = Color.Transparent;
                    }
                }
                else
                {
                    st_ORG[nAxis].BackColor = Color.Transparent;
                }
                if (wmxLIB_Main.GetAxisStaus(nAxis).PositiveLS)
                {
                    st_PEL[nAxis].BackColor = Color.Red;
                }
                else
                {
                    st_PEL[nAxis].BackColor = Color.Transparent;
                }
                if (wmxLIB_Main.GetAxisStaus(nAxis).NearNegativeLS)
                {
                    st_NEL[nAxis].BackColor = Color.Red;
                }
                else
                {
                    st_NEL[nAxis].BackColor = Color.Transparent;
                }
                if (bALM[nAxis])
                {
                    st_ALM[nAxis].BackColor = Color.Red;
                }
                else
                {
                    st_ALM[nAxis].BackColor = Color.Transparent;
                }
            }
            else
            {
                OP_St[nAxis].Text = "OFF";
                OP_St[nAxis].ForeColor = Color.Black;
                st_ORG[nAxis].BackColor = Color.Transparent;
                st_ALM[nAxis].BackColor = Color.Transparent;
                st_NEL[nAxis].BackColor = Color.Transparent;
                st_PEL[nAxis].BackColor = Color.Transparent;
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
                    }break;
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
                    }break;
            }
        }
        //private static string OP_STATE(WMX3ApiCLR.OperationState state) 
        //{
        //    switch (state)
        //    {
        //        case WMX3ApiCLR.OperationState.Idle:
        //            return "Idle";
        //        case WMX3ApiCLR.OperationState.Pos:
        //            return "Pos";
        //        case WMX3ApiCLR.OperationState.Jog:
        //            return "Jog";
        //        case WMX3ApiCLR.OperationState.Home:
        //            return "Home";
        //        case WMX3ApiCLR.OperationState.Sync:
        //            return "Sync";
        //        case WMX3ApiCLR.OperationState.GantryHome:
        //            return "GantryHome";
        //        case WMX3ApiCLR.OperationState.Stop:
        //            return "Stop";
        //        case WMX3ApiCLR.OperationState.Intpl:
        //            return "Intpl";
        //        case WMX3ApiCLR.OperationState.ConstLinearVelocity:
        //            return "ConstLinearVelocity";
        //        case WMX3ApiCLR.OperationState.Trq:
        //            return "Trq";
        //        case WMX3ApiCLR.OperationState.DirectControl:
        //            return "DirectControl";
        //        case WMX3ApiCLR.OperationState.PVT:
        //            return "PVT";
        //        case WMX3ApiCLR.OperationState.ECAM:
        //            return "ECAM";
        //        case WMX3ApiCLR.OperationState.SyncCatchUp:
        //            return "SyncCatchUp";
        //        case WMX3ApiCLR.OperationState.DancerControl:
        //            return "DancerControl";
        //        default:
        //            return "";
        //    }
        //}
        private void SetServoOn() //서보 ON
        {
            Servo = true;
            //for (int ON = 0; ON < 4; ON++)
            //{
            //    wmxLIB_Main.ServoOn(ON, 1);
            //}
            wmxLIB_Main.ServoOn(0, 1);
            wmxLIB_Main.ServoOn(1, 1);
            wmxLIB_Main.ServoOn(2, 1);
            wmxLIB_Main.ServoOn(3, 1);
            StringBuilder(1);
            Servo_ON.BackColor = Color.LimeGreen;
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
                switch (Num)
                {
                    case 0:
                        {
                            
                        } break;
                    case 1:
                        {
                            sb.AppendLine("SERVO ON");
                            textBox1.ForeColor = Color.LimeGreen;
                        } break;
                    case 2:
                        {
                            sb.AppendLine("Homeing");
                           // textBox1.ForeColor = Color.LimeGreen;
                        } break;
                }
            }
            else
            {
                sb.AppendLine("SERVO OFF");
                textBox1.ForeColor = Color.Red;
            }
            textBox1.Text += dtDate + ", " + dtTime + ": " + sb;

        }
        private void SetServooff() // 0번축 서보 OFF
        {
            Servo = false;
            //for (int OFF = 0; OFF < 4; OFF++)
            //{
            //    wmxLIB_Main.ServoOn(OFF, 0);
            //}
                wmxLIB_Main.ServoOn(0, 0);
                wmxLIB_Main.ServoOn(1, 0);
                wmxLIB_Main.ServoOn(2, 0);
                wmxLIB_Main.ServoOn(3, 0);
             //   Servo = true;
                StringBuilder(0);
                Servo_ON.BackColor = Color.Red;
        }

        private void WMX3Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmxLIB_Main.ServoOn(0, 0);
            wmxLIB_Main.ServoOn(1, 0);
            wmxLIB_Main.ServoOn(2, 0);
            wmxLIB_Main.ServoOn(3, 0);
            wmxLIB_Main.CloseDevice();
            //StopCommunication();

            timer1.Stop();
        }

        private void Servo_ON_Click(object sender, EventArgs e)
        {
            if (Servo == false)
            {
                SetServoOn();
            }
            else
            {
                SetServooff();
            }
        }

        private void Servo_OFF_Click(object sender, EventArgs e)
        {
            SetServooff();
        }
        private void btStop_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                wmxLIB_Main.stop(i);
            }
        }

        private void homing(int Axis)
        {
            wmxLIB_Main.Homeing(Axis);
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                homing(i);
                HomeT[i] = true;
            }
            StringBuilder(2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for (int Axis = 0; Axis < 4; Axis++)
            //{
            //    MotionStatus(Axis);
            //}
           // SetCycle(0);
            MotionStatus(0);
            MotionStatus(1);
            MotionStatus(2);
            MotionStatus(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.SetDigitalOutIO(0, 0, 1);
        }

        private void btParameter_Click(object sender, EventArgs e)
        {
            W_Motion form = new W_Motion();
            form.Show();
            //W_Motion2 form2 = new W_Motion2();
            //form2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetServooff();
            StopCommunication();
            //Delay(1000);
            Close();
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
                    //MessageBox.Show("프로그램 종료중입니다");
                    //Close();
                    break;
                }
            }
        }
        public void UnMove(int Axis, double posNum)
        {
            double target = gVar.doAbsPosAxis[Axis, Convert.ToInt16(posNum)];
            double vel = gVar.doAbsPosAxis[Axis, 4];
            double acc = gVar.doAbsPosAxis[Axis, 5];
            double dec = gVar.doAbsPosAxis[Axis, 5];
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_ABSMOVE(wmxLIB_Main.SetTrajQ(target, vel, acc, dec, Axis, profileType));
            Routione_Check = true;
        }
        public void W_MotionMove0(double target, int Axis, double vel, double acc, double dec)
        {
            //double target = gVar.doAbsPosAxis[Axis, Convert.ToInt16(posNum)];
            //double vel = gVar.doAbsPosAxis[Axis, 4];
            //double acc = gVar.doAbsPosAxis[Axis, 5];
            //double dec = gVar.doAbsPosAxis[Axis, 5];
            ProfileType profileType = ProfileType.Trapezoidal;

            
            
            wmxLIB_Main.Run_ABSMOVE(wmxLIB_Main.SetTrajQ(target, vel, acc, dec, Axis, profileType));
           // Routione_Check = true;
        }
        private void X_UnMove0_Click(object sender, EventArgs e)
        {
            Button X_axisMove = (Button)sender;

            if (Routione_Check == true)
            {
                Routione_Check = false;
                for (int num = 0; num < 3; num++)
                {
                    if (bt_Xmove[num] == X_axisMove)
                    {
                        UnMove(0, num);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }  
           //     UnMove(0, 0);
        }

        private void X_UnMove1_Click(object sender, EventArgs e)
        {
          //  UnMove(0, 1);
        }

        private void X_UnMove2_Click(object sender, EventArgs e)
        {
          //  UnMove(0, 2);
        }

        private void X_UnMove3_Click(object sender, EventArgs e)
        {
            if (Routione_Check == true)
            {
                Routione_Check = false;
                stRoutine = "AxisMove";
                Count = 0;
                axis = 0;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }  
                //Count = 0;
                //axis = 0;
                //SetCycle(0);
                //timer2.Start();
                //Axis_Move(axis);
            
        }
        private void SetCycle(int Axis)
        {
            F_stop = false;

            MotionThread = new Thread(delegate()
            {
                M_Cycle(Axis);
            });
            MotionThread.Start();

        }
        private void M_Cycle(int Axis)
        {
            int Count = 0;
            do
            {
                UnMove(Axis, 0);
                wmxLIB_Main.Wait(Axis);
                Thread.Sleep(100);
                UnMove(Axis, 2);
                wmxLIB_Main.Wait(Axis);
                Thread.Sleep(100);
                UnMove(Axis, 0);
                wmxLIB_Main.Wait(Axis);
                Thread.Sleep(100);
                F_stop = true;
                Count++;
            } while (!F_stop);
        }
        
        private void test(int Axis)
        {
            switch (Count)
            {
                case 0:
                    {
                        timer2.Stop();
                        UnMove(Axis, 0);
                        Count = 1;
                        timer2.Start();
                    }break;
                case 1:
                    {
                        if (wmxLIB_Main.GetAxisStaus(Axis).InPos == true && wmxLIB_Main.GetAxisStaus(Axis).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(Axis);
                            //Delay(1000);
                               Thread.Sleep(100);
                            Count = 2;
                        } 
                    } break;
                case 2:
                    {
                        timer2.Stop();
                        UnMove(Axis, 2);
                        Count = 3;
                        timer2.Start(); 
                    } break;
                case 3:
                    {
                        if (wmxLIB_Main.GetAxisStaus(Axis).InPos == true && wmxLIB_Main.GetAxisStaus(Axis).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(Axis);
                            //Delay(1000);
                                  Thread.Sleep(100);
                            Count = 4;
                        }
                    } break;
                case 4:
                    {
                        timer2.Stop();
                        UnMove(Axis, 0);
                    } break;
            }
        }
        private void Axis_Move(int Axis)
        {
            
            switch (Count)
            {
                case 0:
                    {
                        timer2.Stop();
                        UnMove(Axis, 0);
                        Count = 1;
                        timer2.Start();
                    } break;
                case 1:
                    {
                        if (wmxLIB_Main.GetAxisStaus(Axis).InPos == true && wmxLIB_Main.GetAxisStaus(Axis).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(Axis);
                            //Delay(1000);
                            Thread.Sleep(100);
                            Count = 2;
                        }
                    } break;
                case 2:
                    {
                        timer2.Stop();
                        UnMove(Axis, 2);
                        Count = 3;
                        timer2.Start();
                    } break;
                case 3:
                    {
                        if (wmxLIB_Main.GetAxisStaus(Axis).InPos == true && wmxLIB_Main.GetAxisStaus(Axis).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(Axis);
                            //Delay(1000);
                            Thread.Sleep(100);
                            Count = 4;
                        }
                    } break;
                case 4:
                    {
                        timer2.Stop();
                        UnMove(Axis, 0);
                        if (wmxLIB_Main.GetAxisStaus(Axis).InPos == true && wmxLIB_Main.GetAxisStaus(Axis).MotionComplete == true)
                        {
                            Routione_Check = true;
                            Thread.Sleep(100);
                        }
                    } break;
            }
        }

        private void Y_UnMove0_Click(object sender, EventArgs e)
        {
            UnMove(1, 0);
        }

        private void Y_UnMove1_Click(object sender, EventArgs e)                                                                                                    
        {
            UnMove(1, 1);
        }

        private void Y_UnMove2_Click(object sender, EventArgs e)
        {
            UnMove(1, 2);
        }

        private void Y_UnMove3_Click(object sender, EventArgs e)
        {
            if (Routione_Check == true)
            {
                Routione_Check = false;
                stRoutine = "AxisMove";
                Count = 0;
                axis = 1;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void WMX3_Anti_Demo_Load(object sender, EventArgs e)
        {
            wmxLIB_Main = new WMXLIB_Main();
            wmxLIB_Main.WmxLIB_Main();

            CreateDevice();
            StartCommunication();
            SetServoOn();
           // timer1.Start();
        }
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
           
            for (int i = 0; i < 8; i++)
            {
                gVar.XY_Pos[i] = Convert.ToDouble(clsINIFile.GetValue(stSection, "M-Pos" + i, AppFilePath));
            }
            gVar.XY_Speed = Convert.ToInt32(clsINIFile.GetValue(stSection, "M-Speed", AppFilePath));
            gVar.XY_AccD = Convert.ToInt32(clsINIFile.GetValue(stSection, "M-Acc/D", AppFilePath));
            gVar.intAxisNum = Convert.ToInt32(clsINIFile.GetValue(stSection, "Select Axis", AppFilePath));
        }
        private void MulitPos(int X_Pos, int Y_Pos)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = gVar.XY_Speed;
            double acc = gVar.XY_AccD;
            double dec = gVar.XY_AccD;
            double X_target = gVar.XY_Pos[X_Pos];
            double Y_target = gVar.XY_Pos[Y_Pos];
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_LinMOVE(wmxLIB_Main.SetLin(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));
        }
        private void H_MulitPos(int X_Pos, int Y_Pos, double speed)
        {
            int X_Axis = 0;
            int Y_Axis = 1;
            double vel = speed;
            double acc = speed;
            double dec = speed;
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
            double X_target = gVar.XY_Pos[X_Pos];
            double Y_target = gVar.XY_Pos[Y_Pos];
            ProfileType profileType = ProfileType.Trapezoidal;

            wmxLIB_Main.Run_PVTMOVE(wmxLIB_Main.Set_PVT(X_target, Y_target, vel, acc, dec, X_Axis, Y_Axis, profileType));
        }

        private void XY_UnMove0_Click(object sender, EventArgs e)
        {
            H_MulitPos(0, 0, 100000);
        }

        private void XY_UnMove1_Click(object sender, EventArgs e)
        {
            MulitPos(0, 1);
        }

        private void XY_UnMove2_Click(object sender, EventArgs e)
        {
            MulitPos(2, 3);
        }

        private void XY_UnMove3_Click(object sender, EventArgs e)
        {
            if (Routione_Check == true)
            {
                Routione_Check = false;
                stRoutine = "IntplMove";
                Count = 0;
                axis = 0;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("모션 실행중입니다.");
            }
        }

        private void Z_UnMove0_Click(object sender, EventArgs e)
        {
            UnMove(3, 0);
        }

        private void Z_UnMove1_Click(object sender, EventArgs e)
        {
            UnMove(3, 1);
        }

        private void btE_Stop_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.QuickStop(0);
            wmxLIB_Main.QuickStop(1);
            wmxLIB_Main.QuickStop(2);
            wmxLIB_Main.QuickStop(3);
            Routione_Check = true;
       //   timer2.Stop();
            Delay(100);

        //    SetServooff();
        }
        private void Setting_Pos()
        {
            switch (Count)
            {
                case 0:
                    {
              //          timer2.Stop();
                        H_MulitPos(0, 0, 30000);
                        Count = 1;
               //         timer2.Start();
                    } break;
                case 1:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 2;
                        }
                    } break;
                case 2:
                    {
                    //    timer2.Stop();
                        MulitPos(2, 3);
                        Count = 3;
                   //     timer2.Start();
                    } break;
                case 3:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 4;
                        }
                    } break;
                case 4:
                    {
                 //       timer2.Stop();
                        MulitPos(4, 5);
                        Count = 5;
                  //      timer2.Start();
                    } break;
                case 5:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 6;
                        }
                    } break;
                case 6:
                    {
                  //      timer2.Stop();
                        MulitPos(6, 7);
                        Count = 7;
               //         timer2.Start();
                    } break;
                case 7:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 8;
                        }
                    } break;
                case 8:
                    {
                 //       timer2.Stop();
                        MulitPos(0, 1);
                        Count = 9;
                  //      timer2.Start();
                    } break;
                case 9:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 10;
                        }
                    } break;
                case 10:
                    {
                  //      timer2.Stop();
                        H_MulitPos(0, 0, 100000);
                        // Count = 9;
                        //  timer2.Start();
                    } break;
            }
        }

        private void  XY_MPos()
        {
          //  Routione_Check = false;
            switch (Count)
            {
                case 0:
                    {
                   //     timer2.Stop();
                        H_MulitPos(0, 0, 8000);
                        Count = 1;
                    //    timer2.Start();
                    } break;
                case 1:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 2;
                        }
                    } break;
                case 2:
                    {
                 //       timer2.Stop();
                        MulitPos(6, 7);
                        Count = 3;
                  //     timer2.Start();
                    } break;
                case 3:
                    {
                        if (wmxLIB_Main.GetAxisStaus(0).InPos == true && wmxLIB_Main.GetAxisStaus(0).MotionComplete == true && wmxLIB_Main.GetAxisStaus(1).InPos == true && wmxLIB_Main.GetAxisStaus(1).MotionComplete == true)
                        {
                            wmxLIB_Main.Wait(0);
                            wmxLIB_Main.Wait(1);
                            //Delay(1000);
                            Thread.Sleep(500);
                            Count = 4;
                        }
                    } break;
                case 4:
                    {
                        timer2.Stop();
                        H_MulitPos(0, 0, 8000);
                        Routione_Check = true;
                    } break;
            }
            //H_MulitPos(0, 0, 50000);
            //wmxLIB_Main.Wait(0);
            //wmxLIB_Main.Wait(1);
            //Thread.Sleep(100);
            //int Count = 0; 
            //do
            //{
            //    MulitPos(6, 7);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(1000);
            //    H_MulitPos(0, 0, 100000);
            //    wmxLIB_Main.Wait(0);
            //    wmxLIB_Main.Wait(1);
            //    Thread.Sleep(1000);
            //    Count++;
            //} while (Count == 2);
        }
        private void btBefore_Click(object sender, EventArgs e)
        {
            Count = 0;
           // axis = 3;

            Setting_Pos();
            //5timer2.Start();
            //MotionThread = new Thread(delegate()
            //{
            //    Setting_Pos();
            //});
            //MotionThread.Start();
        }

        private void XY_Move0_Click(object sender, EventArgs e)
        {
            PVTPOS(6, 7);
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            F_stop = true;
            timer2.Stop();
            wmxLIB_Main.stop(0);
            wmxLIB_Main.stop(1);
            wmxLIB_Main.stop(2);
            wmxLIB_Main.stop(3);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // wmxLIB_Main.GetAxisStaus(0);
            Routione_Check = false;
           // Count = 0;
            switch (stRoutine)
            {
                case "AxisMove":
                    {
                        Axis_Move(axis);
                    } break;
                case "IntplMove":
                    {
                        XY_MPos();
                    }break;
                    
            }
            //if (axis == 0 || axis == 1)
            //{
            //    Axis_Move(axis);
            //}
            //if (axis == 2)
            //{
            //    XY_MPos();
            //}
            //else if (axis == 3)
            //{
            //    Setting_Pos();
            //}
        }
    
        private void button3_Click_1(object sender, EventArgs e)
        {
            wmxLIB_Main.AlarmClear(0);
            wmxLIB_Main.AlarmClear(1);
            wmxLIB_Main.AlarmClear(2);
            wmxLIB_Main.AlarmClear(3);
            Thread.Sleep(100);
        
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            string file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                //선택된 파일의 풀 경로를 불로와 저장
                txtFile.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                //해당 경로에서 파일명만 추출하여 표시
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void out_start_CheckedChanged(object sender, EventArgs e)
        {
            if (out_start.Checked == true)
            {
                wmxLIB_Main.SetDigitalOutIO(8, 0, 1);
            }
            else
            {
                wmxLIB_Main.SetDigitalOutIO(8, 0, 0);
            }
        }

        private void btintialize_Click(object sender, EventArgs e)
        {
            homing(0);
            wmxLIB_Main.Wait(0);
            homing(1);
            wmxLIB_Main.Wait(1);
            homing(2);
            wmxLIB_Main.Wait(2);
            homing(3);
            wmxLIB_Main.Wait(3);
            if (wmxLIB_Main.GetAxisStaus(0).HomeDone || wmxLIB_Main.GetAxisStaus(1).HomeDone || wmxLIB_Main.GetAxisStaus(2).HomeDone || wmxLIB_Main.GetAxisStaus(3).HomeDone == true)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.ExportParm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wmxLIB_Main.ImportParm();
        }

        private void btAfter_Click(object sender, EventArgs e)
        {

        }

    }
}
