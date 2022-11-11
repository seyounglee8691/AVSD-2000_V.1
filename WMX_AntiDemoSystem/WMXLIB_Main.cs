using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMX3ApiCLR;

namespace WMX_Anti
{
    partial class WMXLIB_Main
    {
        Main_Form fr_Main;
        public WMX3Api Wmx3Lib;
        public CoreMotionStatus CmStatus;
        public CoreMotion Wmx3Lib_cm;
        public AdvancedMotion wmx3Lib_adm;
        public Io Wmx3Lib_io;
        public bool Routione_Check = true;
        Config.SystemParam param;
        Config.AxisParam axisparam;

        public int err = ErrorCode.None;
        public int err1;

        public byte[] inData = new byte[Constants.MaxIoInSize];
        public byte[] outData = new byte[Constants.MaxIoOutSize];
        public int ActurePos;
        string name = "ControlMotionIO";
        public bool[] stServo = new bool[4];
        public void WmxLIB_Main()
        {
            // CreateDevice();
            Wmx3Lib = new WMX3Api();
            CmStatus = new CoreMotionStatus();
            Wmx3Lib_cm = new CoreMotion(Wmx3Lib);
            wmx3Lib_adm = new AdvancedMotion(Wmx3Lib);
            Wmx3Lib_io = new Io();
            
            FileLoad();

        }
        public void road (WMXLIB_Main open)
        {
            WmxLIB_Main();
        }
        public void CreateDevice()
        {
            
            //err = Wmx3Lib.
            

            err = Wmx3Lib.CreateDevice(@"C:\Program Files\SoftServo\WMX3", DeviceType.DeviceTypeNormal); ///새로운 wmx3디바이스 생성
            Thread.Sleep(5000);
            // err1 = err;                                                                                             
            // Set Device Name.
       //     Wmx3Lib.SetDeviceName(name);
            ///wmx3Engine.rtss가 위치한 경로를 string형태로 넣어줌
            ///DeviceType은 DeviceType의 우선순위
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

        public void getDevice()
        {
            Wmx3Lib.GetDeviceName(ref name);
        }
        public void StartCommunication() //엔진에 연결된 플랫폼과 통신
        {
            err = Wmx3Lib.StartCommunication();
            
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to start communication. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Thread.Sleep(3000);
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
        public void SetServooff(int nAxis, int Value) // 0번축 서보 OFF
        {
            err = Wmx3Lib_cm.AxisControl.SetServoOn(nAxis, Value);
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to set servo on. Error = " + WMX3Api.ErrorToString(err), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ImportParm() //Import parameters from file
        {
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

            err = Wmx3Lib_cm.Config.ImportAndSetAll("C:\\wmx_parameters.xml");
            if (err != ErrorCode.None)
            {
                MessageBox.Show("Failed to import parameters. Error=%d (%s)\n"+ err);
            }
        }
        public void GetinIO()
        {
            Wmx3Lib_io.GetInBit(20, 1, ref inData[0]);
        }
        //public void GetDigitalInIO(int addr, int bit, byte value)
        //{
        //    Wmx3Lib_io.GetOutBit(addr, bit, ref value);
        //    // Wmx3Lib_io.
        //}
        public void ExportParm() //Export parameters to file
        {
            err = Wmx3Lib_cm.Config.GetParam(ref param);
            if (err == ErrorCode.None)
            {
                err = Wmx3Lib_cm.Config.GetAxisParam(ref axisparam);
                if (err == ErrorCode.None)
                {
                    err = Wmx3Lib_cm.Config.Export("wmx_parameters.xml", param, axisparam);
                    if (err != ErrorCode.None)
                    {
                        MessageBox.Show("Failed to export parameters to file. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
                    }
                }
                else
                {
                    MessageBox.Show("Failed to get axis parameters. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
                }
            }
            else
            {
                MessageBox.Show("Failed to get parameters. Error=%d (%s)\n", WMX3Api.ErrorToString(err));
            }
        }
        public void Run_ABSMOVE(Motion.PosCommand ABSM)
        {
            if (err == ErrorCode.None)
            {
                err = Wmx3Lib_cm.Motion.StartPos(ABSM);
                Routione_Check = true;

                if (err != ErrorCode.None)
                {
                    Console.WriteLine("Joint {0} Position Control Failed");
                }
            }
        }
        public void Run_LinMOVE(Motion.LinearIntplCommand LinM)
        {
            if (err == ErrorCode.None)
            {
                err = Wmx3Lib_cm.Motion.StartLinearIntplPos(LinM);
                Routione_Check = true;

                if (err != ErrorCode.None)
                {
                    Console.WriteLine("Joint {0} Position Control Failed");
                }
            }
        }
        public void Run_PVTMOVE(AdvMotion.PVTIntplCommand PVTM)
        {
            if (err == ErrorCode.None)
            {
                err = wmx3Lib_adm.AdvMotion.StartPVT(PVTM);

                if (err != ErrorCode.None)
                {
                    Console.WriteLine("Joint {0} Position Control Failed");
                }
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

            lin.Target[0] = X_target;
            lin.Target[1] = Y_target;

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
        public void ABSMove(double target, double velocity, double acc, double dec, int slaveNum, ProfileType profileType)
        {
            Motion.PosCommand ABS_move = SetTrajQ(target, velocity, acc, dec, slaveNum, profileType);

            Wmx3Lib_cm.Motion.StartPos(ABS_move);
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
                homeParam.HomeType = Config.HomeType.HS;
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
