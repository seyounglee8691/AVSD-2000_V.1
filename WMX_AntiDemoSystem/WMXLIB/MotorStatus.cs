using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using WMX3ApiCLR;

namespace M_Status
{
    class MotorStatus
    {
        /*---------------------------------------------------------------------*/
        /* Function    : _tmain                                                */
        /* Description : Main Function.                                        */
        /*---------------------------------------------------------------------*/
        static void Status(string[] args)
        {
            WMX3Api Wmx3Lib = new WMX3Api();
            CoreMotionStatus CmStatus = new CoreMotionStatus();
            CoreMotion Wmx3Lib_cm = new CoreMotion(Wmx3Lib);

            Console.WriteLine("Program Start.");
            System.Threading.Thread.Sleep(1000);

            // Create device.
            Wmx3Lib.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\",
                DeviceType.DeviceTypeNormal,
                0xFFFFFFFF);

            // Set Device Name.
            Wmx3Lib.SetDeviceName("MotorStatus");

            // Start Communication.
            Wmx3Lib.StartCommunication(0xFFFFFFFF);

            // Set servo on.
            Wmx3Lib_cm.AxisControl.SetServoOn(0, 1);
            while (true)
            {
                Wmx3Lib_cm.GetStatus(ref CmStatus);
                if (CmStatus.AxesStatus[0].ServoOn)
                {
                    break;
                }

                System.Threading.Thread.Sleep(100);
            }

            // Homing.
            Config.HomeParam homeParam = new Config.HomeParam();
            Wmx3Lib_cm.Config.GetHomeParam(0, ref homeParam);
            homeParam.HomeType = Config.HomeType.CurrentPos;
            Wmx3Lib_cm.Config.SetHomeParam(0, homeParam);
            Wmx3Lib_cm.Home.StartHome(0);
            Wmx3Lib_cm.Motion.Wait(0);

            //-------------------------------------------------------------------
            // Create a command value.
            //-------------------------------------------------------------------
            Motion.PosCommand posCommand = new Motion.PosCommand();
            posCommand.Profile.Type = WMX3ApiCLR.ProfileType.Trapezoidal;
            posCommand.Axis = 0;
            posCommand.Target = 1000000;
            posCommand.Profile.Velocity = 100000;
            posCommand.Profile.Acc = 1000000;
            posCommand.Profile.Dec = 1000000;

            // Rotate the motor at the specific speed.
            Wmx3Lib_cm.Motion.StartMov(posCommand);

            // Dump data.
            while (true)
            {
                Console.WriteLine("1:status dump else:end\n");
                Console.WriteLine("->");

                int selectNum;

                while (true)
                {
                    string line = Console.ReadLine();

                    if (line != null && int.TryParse(line, out selectNum))
                    {
                        break;
                    }

                    Console.WriteLine("->");
                }

                if (selectNum != 1)
                {
                    break;
                }

                //---------------------------------------------------------------
                // Dump information on specified axis.
                //---------------------------------------------------------------
                Wmx3Lib_cm.GetStatus(ref CmStatus);
                CoreMotionAxisStatus cmAxis0, cmAxis1, cmAxis2, cmAxis3; 
                cmAxis0 = CmStatus.AxesStatus[0];
                cmAxis1 = CmStatus.AxesStatus[1];
                cmAxis2 = CmStatus.AxesStatus[2];
                cmAxis3 = CmStatus.AxesStatus[3];

                double PosCmd0 = cmAxis0.PosCmd;
                double PosCmd1 = cmAxis1.PosCmd;
                double PosCmd2 = cmAxis2.PosCmd;
                double PosCmd3 = cmAxis3.PosCmd;

                if (!cmAxis0.InPos)
                {
     
                }
                //Console.WriteLine(" 1.PosCmd    :" + cmAxis.PosCmd.ToString("F3"));             // 1. PosCmd
                //Console.WriteLine(" 2.ActPos    :" + cmAxis.ActualPos.ToString("F3"));          // 2. ActualPos
                //Console.WriteLine(" 3.ActVel    :" + cmAxis.ActualVelocity.ToString("F3"));     // 3. ActualVelocity
                //Console.WriteLine(" 4.ActTrq    :" + cmAxis.ActualTorque.ToString("F3"));       // 4. ActualTorque 
                //Console.WriteLine(" 5.AmpAlm    :" + cmAxis.AmpAlarm.ToString());               // 5. AmpAlarm
                //Console.WriteLine(" 6.AmpAlmCode:" + cmAxis.AmpAlarmCode.ToString("X5"));       // 6. AmpAlarmCode 
                //Console.WriteLine(" 7.SrvOn     :" + cmAxis.ServoOn.ToString());                // 7. ServoOn
                //Console.WriteLine(" 8.HomeDone  :" + cmAxis.HomeDone.ToString());               // 8. HomeDone 
                //Console.WriteLine(" 9.InPos     :" + cmAxis.InPos.ToString());                  // 9. InPos
                //Console.WriteLine("10.NegLS     :" + cmAxis.NegativeLS.ToString());             // 10.negativeLS
                //Console.WriteLine("11.PosLS     :" + cmAxis.PositiveLS.ToString());             // 11.positiveLS
                //Console.WriteLine("12.HomeSw    :" + cmAxis.HomeSwitch.ToString());             // 12.homeSwitch
                //Console.WriteLine("13.OpState   :" + OP_STATE(cmAxis.OpState));                 // 13.OperationState
            }

            // Motor Stop.
            Wmx3Lib_cm.Motion.ExecQuickStop(0);

            // Wait until the axis stops.
            Wmx3Lib_cm.Motion.Wait(0);

            // Set servo off.
            Wmx3Lib_cm.AxisControl.SetServoOn(0, 0);
            while (true)
            {
                Wmx3Lib_cm.GetStatus(ref CmStatus);
                if (!CmStatus.AxesStatus[0].ServoOn)
                {
                    break;
                }
            }
            
            // Stop Communication.
            Wmx3Lib.StopCommunication(0xFFFFFFFF);

            //Quit device.
            Wmx3Lib.CloseDevice();

            Console.WriteLine("Program End.");
            System.Threading.Thread.Sleep(3000);

            
        }
        //public double status(ref a)
        //{
        //    return;
        //}

        private static string OP_STATE(WMX3ApiCLR.OperationState state)
        {
            switch (state)
            {
                case WMX3ApiCLR.OperationState.Idle:
                    return "Idle";
                case WMX3ApiCLR.OperationState.Pos:
                    return "Pos";
                case WMX3ApiCLR.OperationState.Jog:
                    return "Jog";
                case WMX3ApiCLR.OperationState.Home:
                    return "Home";
                case WMX3ApiCLR.OperationState.Sync:
                    return "Sync";
                case WMX3ApiCLR.OperationState.GantryHome:
                    return "GantryHome";
                case WMX3ApiCLR.OperationState.Stop:
                    return "Stop";
                case WMX3ApiCLR.OperationState.Intpl:
                    return "Intpl";
                case WMX3ApiCLR.OperationState.ConstLinearVelocity:
                    return "ConstLinearVelocity";
                case WMX3ApiCLR.OperationState.Trq:
                    return "Trq";
                case WMX3ApiCLR.OperationState.DirectControl:
                    return "DirectControl";
                case WMX3ApiCLR.OperationState.PVT:
                    return "PVT";
                case WMX3ApiCLR.OperationState.ECAM:
                    return "ECAM";
                case WMX3ApiCLR.OperationState.SyncCatchUp:
                    return "SyncCatchUp";
                case WMX3ApiCLR.OperationState.DancerControl:
                    return "DancerControl";
                default:
                    return "";
            }
        }
    }
}