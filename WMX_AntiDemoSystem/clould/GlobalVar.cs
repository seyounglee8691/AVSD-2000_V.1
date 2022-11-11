using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMX_Anti
{
    class gVar
    {

        //Logic Number, Time Delay, InitCompleted, RunStatus
        public static int AxisNum, intInitNum, intRunNum, intTimeDelay, intTimeDelayCnt, intRepeatNum, intRepeatNumCnt, MotionNum, H_speed;
        public static bool MotionCheck, MotionStop, MtCycle;
        public static int intInitTCheck, intRunTCheck;
        public static Boolean boInitComp, boRunComp;
        public static Boolean boRetry;
        public static int progress_;
        //IO
        public static int valuenum, bitnum, addressnum;
        public static bool startcomp = false;

        //Common Axis Motion Status Bit 
        public static Boolean boInitStatus;
        public static int intLogNum;
        public static int intAxisNum;
        public static int Push = 0;

        public static int[] intSetPos = new int[4];
        public static int[] intSetSpeed = new int[3];
        public static int[] intSetAcc = new int[3];
        public static int XY_Speed;
        public static int XY_AccD;

        public static Double[] doMotCmdPos = new double[4];
        public static Double[] doMotFeedbackPos = new double[4];
        public static Double[] doMotACC = new double[4];
        public static Double[] doMotDEC = new double[4];
        public static Double[] doMotCmdSpeed = new double[4];
        public static Double[] doMotFeedbackSpeed = new double[4];
        public static Boolean[] boMotALM = new Boolean[4];
        public static Boolean[] boMotINP = new Boolean[4];
        public static Boolean[] boMotRDY = new Boolean[4];
        public static Boolean[] boMotCCW = new Boolean[4];
        public static Boolean[] boMotORG = new Boolean[4];
        public static Boolean[] boMotCW = new Boolean[4];
        public static Boolean[] boHomeSucess = new Boolean[4];

        //Common Axis Motion Moving Method
        public static int intVelRelAbs; // 0=Velocity Mode(Jog적용시), 1=Relative Mode(상대좌표이동), 2=Absolute Mode(절대좌표이동)

        public static int intMotHomeDirection; //0: (-)방향 Homing Direction, 1: (+)방향 Homing Direction
        public const int IX_MAP_IDX = 0;  // Interpolation Map Index
        

        //Axis: Position, Jog, Acc, Speed 
        public static double[,] doAbsPosAxis = new double[4, 8];
        public static double[] X_Pos = new double[6];
        public static double[] Y_Pos = new double[6];
        public static double[,] doAbsSpeedAxis = new double[4, 8];

        public static double[] doAbsACCAxis = new double[4];
        public static double[] doJogSpeedAxis = new double[4];
        public static double[] doJogDistAxis = new double[4];
        public static double[] doJogAccAxis = new double[4];


        public static double[] MxdoAbsPosAxis = new double[2];
        public static double[] MxdoAbsPosAxis1 = new double[2];
        public static double[] MxdoAbsPosAxis2 = new double[2];
        public static double[] MxdoAbsPosAxis3 = new double[2];



    } 
}
