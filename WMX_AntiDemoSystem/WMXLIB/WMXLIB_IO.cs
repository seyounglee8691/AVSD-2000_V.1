using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMX3ApiCLR;

namespace WMX_Anti
{
    partial class WMXLIB_Main
    {
       public void SetDigitalOutIO(int addr , int bit , byte value)
        {
            //Wmx3Lib_io.SetOutBytes(addr, bit, value);
            Wmx3Lib_io.SetOutBit(addr, bit, value);
        }
       public void SetDigitalOutIO1(int addr, int bit, byte[] value)
       {
       //    Wmx3Lib_io.SetOutBit(addr, bit, value);
           Wmx3Lib_io.SetOutBytes(addr, bit, value);
       }
       public byte[] GetDigitalInIO(int addr, int bit)
       {
        //   Wmx3Lib_io.GetInBit(addr, bit, ref value);
           byte[] value = new byte[bit];
           Wmx3Lib_io.GetInBytes(addr, bit, ref value);

           //gVar.valuenum = value[0];
           //gVar.bitnum = bit;
           //gVar.addressnum = WMX3Lib_IOAddress.Bit;

           return value;
       }
    }
}
