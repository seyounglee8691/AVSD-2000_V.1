using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMX3ApiCLR;
using AvxApi;

namespace WMX_Anti
{
    partial class WMXLIB_Main
    {
        AvXMotion avx;

        Main_Form fr_Main;

        public WMX3Api Wmx3Lib;
        public UserMemory ShareMemory;
        public CoreMotionStatus CmStatus;
        public CoreMotion Wmx3Lib_cm;
        public AdvancedMotion wmx3Lib_adm;
        public Io Wmx3Lib_io;
        public IOAddress WMX3Lib_IOAddress;
        public IOConstants WMX3Lib_IOconstants;
        public IoEventInput ioevent;
        public bool Routione_Check = true;
        Config.SystemParam param;
        Config.AxisParam axisparam;

        public int err = ErrorCode.None;
        public int err1;

        public byte[] inData = new byte[Constants.MaxIoInSize];
        
        public byte[] outData = new byte[Constants.MaxIoOutSize];
        public int ActurePos;
        string name = "AVSD-2000";
        public bool[] stServo = new bool[4];
        public void WmxLIB_Main()
        {
            
            Wmx3Lib = new WMX3Api();
            CmStatus = new CoreMotionStatus();
            Wmx3Lib_cm = new CoreMotion(Wmx3Lib);
            wmx3Lib_adm = new AdvancedMotion(Wmx3Lib);
            road(); 
            Wmx3Lib_io = new Io();
            WMX3Lib_IOAddress = new IOAddress();
            WMX3Lib_IOconstants = new IOConstants();
            FileLoad();
            
           // CreateDevice();
        }
        public void road()
        {           
             // ShareMemory = new UserMemory(Wmx3Lib);      
        }
        public void CreateDevice()
        {

            //err = Wmx3Lib.
            
            err = Wmx3Lib.CreateDevice(@"C:\Program Files\SoftServo\WMX3", DeviceType.DeviceTypeNormal); ///새로운 wmx3디바이스 생성
            Wmx3Lib.SetDeviceName(name);
            //Thread.Sleep(5000);
            //Thread.Sleep(1500);
            //err1 = err;                                                                                             
            //Set Device Name.
            //Wmx3Lib.SetDeviceName(name);
            //wmx3Engine.rtss가 위치한 경로를 string형태로 넣어줌
            //DeviceType은 DeviceType의 우선순위
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to create device. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //err = Wmx3Lib.StartCommunication(5000);
            //if (err != ErrorCode.None)
            //{
            //    MessageBox.Show("Failed to start communication. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Thread.Sleep(5000);
        }
        public void CloseDevice()
        {
           Wmx3Lib.CloseDevice();
        }
        public void StartCommunication() //엔진에 연결된 플랫폼과 통신
        {
            err = Wmx3Lib.StartCommunication();
            
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to start communication. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gVar.startcomp = true;
            }
            Thread.Sleep(300);
        }
        public void StopCommunication() //통신 종료
        {
            err = Wmx3Lib.StopCommunication();
            Thread.Sleep(1000);
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to stop communication. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ServoOn(int nAxis, int Value)
        {
            //Thread.Sleep(5000);
            if (err == ErrorCode.None)
            {
                err = Wmx3Lib_cm.AxisControl.SetServoOn(nAxis, Value);
            }
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to set servo on. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void avx_Cycle(int X_target, int Y_target)
        {
            AvxMotionErrorCode rtn = AvxMotionErrorCode.None;
            AVXRobotCommand avxrobocmd = new AVXRobotCommand();
            AdvMotion.PVTIntplCommand pvtinterpcmd = new AdvMotion.PVTIntplCommand();
            avx = new AvXMotion();
            avxrobocmd.Axis[0] = 0;
            avxrobocmd.Axis[1] = 1;
            avxrobocmd.Axis[2] = 2;
            avxrobocmd.Axis[3] = 3;
            avxrobocmd.AxisCount = 4;
            avxrobocmd.CommCycle = 1000;
            avxrobocmd.LinearMode = false;
            avxrobocmd.maxVelocity[0] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[1] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[2] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[3] = gVar.XY_Speed + 2000000;
            avxrobocmd.Velocity = gVar.XY_Speed;
            avxrobocmd.VibLimit = 5;
            avxrobocmd.enAvsType = AVXRobotCommand.AvsType.ZV;
            avxrobocmd.enInterplType = AVXRobotCommand.Linear_Intpl_Profile_Calc_Mode.MatchFarthestAxis;
            avxrobocmd.Acc = gVar.XY_AccD + 2000000;
            for (int i = 0; i < 6; i++)
            {
                avxrobocmd.doDRatio[i] = 0;
            }
            avxrobocmd.doNfreq[0] = 6.2;
            avxrobocmd.doNfreq[1] = 6.2;

            avxrobocmd.doNfreq[2] = 7;
            avxrobocmd.doNfreq[3] = 7;

            avxrobocmd.doNfreq[4] = 11;
            avxrobocmd.doNfreq[5] = 11;
            avxrobocmd.CurrentPos[0] = GetAxisStaus(0).PosCmd;
            avxrobocmd.CurrentPos[1] = GetAxisStaus(1).PosCmd;
            avxrobocmd.CurrentPos[2] = GetAxisStaus(2).PosCmd;
            avxrobocmd.CurrentPos[3] = GetAxisStaus(3).PosCmd;

            avxrobocmd.TargetPos[0] = gVar.X_Pos[X_target];
            avxrobocmd.TargetPos[1] = gVar.Y_Pos[Y_target];
            avxrobocmd.TargetPos[2] = avxrobocmd.CurrentPos[2];
            avxrobocmd.TargetPos[3] = avxrobocmd.CurrentPos[3];
            int rtn2;
            rtn = avx.AVSMotion(avxrobocmd, out pvtinterpcmd);
            if (rtn != AvxMotionErrorCode.None)
            {
                string stf;
                avx.ErrorToString(rtn, out stf);
            }
            err = wmx3Lib_adm.AdvMotion.StartPVT(pvtinterpcmd);

            if (err == 1548)
            {

            }
        }
        public void X_Axis_AVX_MOVE(int Axis_num, int target)
        {
            AvxMotionErrorCode rtn = AvxMotionErrorCode.None;
            AVXRobotCommand avxrobocmd = new AVXRobotCommand();
            AdvMotion.PVTIntplCommand pvtinterpcmd = new AdvMotion.PVTIntplCommand();
            avx = new AvXMotion();
            avxrobocmd.Axis[0] = 0;
            avxrobocmd.Axis[1] = 1;
            avxrobocmd.Axis[2] = 2;
            avxrobocmd.Axis[3] = 3;
            avxrobocmd.AxisCount = 4;
            avxrobocmd.CommCycle = 1000;
            avxrobocmd.LinearMode = false;
            avxrobocmd.maxVelocity[0] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[1] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[2] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[3] = gVar.XY_Speed + 2000000;
            avxrobocmd.Velocity = gVar.XY_Speed;
            avxrobocmd.VibLimit = 5;
            avxrobocmd.enAvsType = AVXRobotCommand.AvsType.ZV;
            avxrobocmd.enInterplType = AVXRobotCommand.Linear_Intpl_Profile_Calc_Mode.MatchFarthestAxis;
            avxrobocmd.Acc = gVar.XY_AccD + 2000000;
            for (int i = 0; i < 6; i++)
            {
                avxrobocmd.doDRatio[i] = 0;
            }
            avxrobocmd.doNfreq[0] = 6.2;
            avxrobocmd.doNfreq[1] = 6.2;

            avxrobocmd.doNfreq[2] = 7;
            avxrobocmd.doNfreq[3] = 7;

            avxrobocmd.doNfreq[4] = 11;
            avxrobocmd.doNfreq[5] = 11;
            avxrobocmd.CurrentPos[0] = GetAxisStaus(0).PosCmd;
            avxrobocmd.CurrentPos[1] = GetAxisStaus(1).PosCmd;
            avxrobocmd.CurrentPos[2] = GetAxisStaus(2).PosCmd;
            avxrobocmd.CurrentPos[3] = GetAxisStaus(3).PosCmd;

            avxrobocmd.TargetPos[0] = gVar.doAbsPosAxis[Axis_num, Convert.ToInt16(target)];
            avxrobocmd.TargetPos[1] = avxrobocmd.CurrentPos[1];
            avxrobocmd.TargetPos[2] = avxrobocmd.CurrentPos[2];
            avxrobocmd.TargetPos[3] = avxrobocmd.CurrentPos[3];
            int rtn2;
            rtn = avx.AVSMotion(avxrobocmd, out pvtinterpcmd);
            if (rtn != AvxMotionErrorCode.None)
            {
                string stf;
                avx.ErrorToString(rtn, out stf);
            }
            err = wmx3Lib_adm.AdvMotion.StartPVT(pvtinterpcmd);
            //  if (err != ErrorCode.None)
            if (err == 1548)
            {
                //   string stf = WMX3Api.ErrorToString(err);
                //   MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   return;
            }
            //else
            //{
            //    string stf = WMX3Api.ErrorToString(err);
            //    MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
        public void Y_Axis_AVX_MOVE(int Axis_num, int target)
        {
            AvxMotionErrorCode rtn = AvxMotionErrorCode.None;
            AVXRobotCommand avxrobocmd = new AVXRobotCommand();
            AdvMotion.PVTIntplCommand pvtinterpcmd = new AdvMotion.PVTIntplCommand();
            avx = new AvXMotion();
            avxrobocmd.Axis[0] = 0;
            avxrobocmd.Axis[1] = 1;
            avxrobocmd.Axis[2] = 2;
            avxrobocmd.Axis[3] = 3;
            avxrobocmd.AxisCount = 4;
            avxrobocmd.CommCycle = 1000;
            avxrobocmd.LinearMode = false;
            avxrobocmd.maxVelocity[0] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[1] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[2] = gVar.XY_Speed + 2000000;
            avxrobocmd.maxVelocity[3] = gVar.XY_Speed + 2000000;
            avxrobocmd.Velocity = gVar.XY_Speed;
            avxrobocmd.VibLimit = 5;
            avxrobocmd.enAvsType = AVXRobotCommand.AvsType.ZV;
            avxrobocmd.enInterplType = AVXRobotCommand.Linear_Intpl_Profile_Calc_Mode.MatchFarthestAxis;
            avxrobocmd.Acc = gVar.XY_AccD + 2000000;
            for (int i = 0; i < 6; i++)
            {
                avxrobocmd.doDRatio[i] = 0;
            }
            avxrobocmd.doNfreq[0] = 6.2;
            avxrobocmd.doNfreq[1] = 6.2;

            avxrobocmd.doNfreq[2] = 7;
            avxrobocmd.doNfreq[3] = 7;

            avxrobocmd.doNfreq[4] = 11;
            avxrobocmd.doNfreq[5] = 11;
            avxrobocmd.CurrentPos[0] = GetAxisStaus(0).PosCmd;
            avxrobocmd.CurrentPos[1] = GetAxisStaus(1).PosCmd;
            avxrobocmd.CurrentPos[2] = GetAxisStaus(2).PosCmd;
            avxrobocmd.CurrentPos[3] = GetAxisStaus(3).PosCmd;

            avxrobocmd.TargetPos[0] = avxrobocmd.CurrentPos[0];
            avxrobocmd.TargetPos[1] = gVar.doAbsPosAxis[Axis_num, Convert.ToInt16(target)];
            avxrobocmd.TargetPos[2] = avxrobocmd.CurrentPos[2];
            avxrobocmd.TargetPos[3] = avxrobocmd.CurrentPos[3];
            int rtn2;
            rtn = avx.AVSMotion(avxrobocmd, out pvtinterpcmd);
            if (rtn != AvxMotionErrorCode.None)
            {
                string stf;
                avx.ErrorToString(rtn, out stf);
            }
            err = wmx3Lib_adm.AdvMotion.StartPVT(pvtinterpcmd);
            //  if (err != ErrorCode.None)
            if (err == 1548)
            {
                //   string stf = WMX3Api.ErrorToString(err);
                //   MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   return;
            }
            //else
            //{
            //    string stf = WMX3Api.ErrorToString(err);
            //    MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

       
        public void SetServooff(int nAxis, int Value) // 0번축 서보 OFF
        {
            Wmx3Lib_cm.AxisControl.SetServoOn(nAxis, Value);
            //if (err != ErrorCode.None)
            //{
            //    MessageBox.Show("Failed to set servo on. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void ImportParm() //Import parameters from file
        {
            #region ex
            //Wmx3Lib_cm.Config.Import("wmx_parameters.xml", ref param, ref axisparam);
            //if (err == ErrorCode.None)
            //{
            //    //If the parameters were successfully read from file, attempt to write them to the engine
            //    err = Wmx3Lib_cm.Config.SetParam(param);
            //    if (err != ErrorCode.None)
            //    {
            //        //wmxlib_cm.ErrorToString(err, WMX3Api.ErrorToString(err), sizeof(WMX3Api.ErrorToString(err)));
            //        MessageBox.Show("Failed to set parameters. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
            //    }
            //    err = Wmx3Lib_cm.Config.SetAxisParam(axisparam);
            //    if (err != ErrorCode.None)
            //    {
            //        MessageBox.Show("Failed to get axis parameters. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Failed to import parameters from file. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
            //}
            #endregion
            err = Wmx3Lib_cm.Config.ImportAndSetAll("C:\\wmx_parameters.xml");
            string stf = WMX3Api.ErrorToString(err);

            if (err != ErrorCode.None)
            {
                MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } return;
        }
        public void GetinIO()
        {
            Wmx3Lib_io.GetInBit(20, 1, ref inData[0]);
        }
        public void Run_ABSMOVE(Motion.PosCommand ABSM)
        {
            if (err == ErrorCode.None)
            {
                err = Wmx3Lib_cm.Motion.StartPos(ABSM);
                Routione_Check = true;
                string stf = WMX3Api.ErrorToString(err);

                if (err != ErrorCode.None)
                {
                    MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } return;
            }
        }
        public void Run_LinMOVE(Motion.LinearIntplCommand LinM)
        {
            err = Wmx3Lib_cm.Motion.StartLinearIntplPos(LinM);
            Routione_Check = true;
            string stf = WMX3Api.ErrorToString(err);

            if (err != ErrorCode.None)
            {
                MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } return;
        }
        public void Run_PVTMOVE(AdvMotion.PVTIntplCommand PVTM)
        {
            if (err == ErrorCode.None)
            {
                err = wmx3Lib_adm.AdvMotion.StartPVT(PVTM);
                string stf = WMX3Api.ErrorToString(err);

                if (err != ErrorCode.None)
                {
                    MessageBox.Show("" + stf, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } return;
            }
        }
        public CoreMotionAxisStatus GetAxisStaus(int nAxis)
        {
            if (nAxis >= 4 || nAxis < 0)
                return null;
            Wmx3Lib_cm.GetStatus(ref CmStatus);

            return CmStatus.AxesStatus[nAxis];
        }
        public void AlarmClear(int nAxis)
        {
            Wmx3Lib_cm.AxisControl.ClearAmpAlarm(nAxis);
      //      Wmx3Lib_cm.AxisControl.ClearAxisAlarm(nAxis);
        }
        public void FileLoad()
        {

        }
        public Motion.PosCommand SetTrajQ(double target, double velocity, double acc, double dec, int slaveNum, ProfileType profileType)
        {
            Routione_Check = false;
            Motion.PosCommand ABS_M = new Motion.PosCommand();
            ABS_M.Profile.Type = profileType;
            ABS_M.Axis = slaveNum;
            ABS_M.Target = target;
            ABS_M.Profile.Velocity = velocity;
            ABS_M.Profile.Acc = acc;
            ABS_M.Profile.Dec = dec;

            return ABS_M;
        }
        public Motion.LinearIntplCommand SetLin(double X_target, double Y_target, double veloctiy, double acc, double dec, int X_Axis, int Y_Axis, ProfileType profileType)
        {
          
            Routione_Check = false;
            Motion.LinearIntplCommand lin = new Motion.LinearIntplCommand();
            lin.AxisCount = 2;
            lin.Axis[0] = X_Axis;
            lin.Axis[1] = Y_Axis;
            lin.Profile.Type = profileType;
            lin.Profile.Velocity = veloctiy;
            lin.Profile.Acc = acc;
            lin.Profile.Dec = dec;
            Config.MotionParam motionP = new Config.MotionParam();
            
            int rtn = 0;
            string str1 = string.Empty;
            rtn = Wmx3Lib_cm.Config.GetMotionParam(X_Axis, ref motionP);
            if (rtn != CoreMotionErrorCode.None)
            {
                str1 = CoreMotion.ErrorToString(rtn);
            }

            motionP.LinearIntplProfileCalcMode = Config.LinearIntplProfileCalcMode.MatchFarthestAxis;

            rtn = Wmx3Lib_cm.Config.SetMotionParam(X_Axis, motionP);
            if (rtn != CoreMotionErrorCode.None)
            {
                str1 = CoreMotion.ErrorToString(rtn);
            }



            rtn = Wmx3Lib_cm.Config.GetMotionParam(Y_Axis, ref motionP);
            if (rtn != CoreMotionErrorCode.None)
            {
                str1 = CoreMotion.ErrorToString(rtn);
            }
            motionP.LinearIntplProfileCalcMode = Config.LinearIntplProfileCalcMode.MatchFarthestAxis;
            rtn = Wmx3Lib_cm.Config.SetMotionParam(Y_Axis, motionP);
            if (rtn != CoreMotionErrorCode.None)
            {
                str1 = CoreMotion.ErrorToString(rtn);
            }
            lin.MaxVelocity[0] = veloctiy;
            lin.MaxVelocity[1] = veloctiy;
            lin.MaxAcc[0] = acc;
            lin.MaxAcc[1] = acc;

            lin.MaxDec[0] = dec;
            lin.MaxDec[1] = dec;
            lin.Target[0] = X_target;
            lin.Target[1] = Y_target;
           // lin.Target[1] = 0;

            return lin;
        }
        public AdvMotion.PVTIntplCommand Set_PVT(double X_target, double Y_target, double veloctiy, double acc, double dec, int X_Axis, int Y_Axis, ProfileType profileType)
        {
            AdvMotion.PVTIntplCommand pvtCmd = new AdvMotion.PVTIntplCommand();
            
            pvtCmd.AxisCount = 2;
            pvtCmd.Axis[0] = X_Axis;
            pvtCmd.Axis[1] = Y_Axis;
            pvtCmd.PointCount[0] = 1;
            pvtCmd.PointCount[1] = 1;
            pvtCmd.Points[0, 0].TimeMilliseconds = 100.0;
            pvtCmd.Points[0, 0].Pos = X_target;
            pvtCmd.Points[1, 0].Pos = Y_target;
            pvtCmd.Points[0, 0].Velocity = veloctiy;
            pvtCmd.Points[1, 0].Velocity = veloctiy;
            return pvtCmd;
        }
        public void LinearInterpolation(double X_target, double Y_target, double veloctiy, double acc, double dec, int X_Axis, int Y_Axis, ProfileType profileType)
        {
            Motion.LinearIntplCommand lin = new Motion.LinearIntplCommand();

            lin.AxisCount = 2;
            lin.Axis[0] = X_Axis;
            lin.Axis[1] = Y_Axis;
            lin.Profile.Type = profileType;
            lin.Profile.Velocity = veloctiy;
            lin.Profile.Acc = acc;
            lin.Profile.Dec = dec;

            lin.Target[0] = X_target;
            lin.Target[1] = Y_target;

            Wmx3Lib_cm.Motion.StartLinearIntplPos(lin);
        }
        public void Wait(int Axis)
        {
            Wmx3Lib_cm.Motion.Wait(Axis);
        }
        public void Homeing(int Axis)
        {
            Config.HomeParam homeParam = new Config.HomeParam();

            if (err == ErrorCode.None)
            {
                Wmx3Lib_cm.Motion.Wait(Axis);
                Wmx3Lib_cm.Config.GetHomeParam(Axis, ref homeParam);
                if (Axis == 2)
                {
                    homeParam.HomeType = Config.HomeType.ZPulse;
                }
                else
                {
                    homeParam.HomeType = Config.HomeType.HS;
                }
               
               // homeParam.
                err = Wmx3Lib_cm.Config.SetHomeParam(Axis, homeParam);

                if (err != ErrorCode.None)
                {
                    Console.WriteLine("Joint {0} Homming Setting Failed", Axis);
                }
                else
                {
                    Wmx3Lib_cm.Home.StartHome(Axis);
                }
               
                
            }
        }
        public void QuickStop(int axis)
        {
            Wmx3Lib_cm.Motion.ExecTimedStop(axis, 10);
        }
        public void E_Stop(int Axis)
        {
            Wmx3Lib_cm.Motion.ExecTimedStop(Axis, 10); // 10ms
            Wmx3Lib_cm.Motion.Stop(Axis);
            Wmx3Lib_cm.Motion.Wait(Axis);
            //Thread.Sleep(500);
            //Wmx3Lib_cm.AxisControl.SetServoOn(Axis, 0);

        }
        public void jogplus_MouseDown(ProfileType profileType, int slaveNum, double velocity, double acc, double dec)
        {
            Motion.JogCommand jogCommand = new Motion.JogCommand();
            jogCommand.Profile.Type = profileType;
            jogCommand.Axis = slaveNum;

            // JOG+ 이동 속도
            jogCommand.Profile.Velocity = velocity;

            // JOG+ 이동 가속도/감속도
            jogCommand.Profile.Acc = acc;
            jogCommand.Profile.Dec = dec;

            Wmx3Lib_cm.Motion.StartJog(jogCommand);
        }

        public void stop(int Axis)
        {
            Wmx3Lib_cm.Motion.Stop(Axis);
        }

        public void Command_Position(int Axis)
        {
            err = Wmx3Lib_cm.Home.SetCommandPos(0, 0);
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to set command position. Error=%d (%s)\n" + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
