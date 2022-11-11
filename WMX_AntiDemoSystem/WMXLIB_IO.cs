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
            Wmx3Lib_io.SetOutBit(addr, bit, value);
        }
       public void GetDigitalInIO(int addr, int bit, byte value)
       {
           Wmx3Lib_io.GetInBit(addr, bit, ref value);
           gVar.ionum = value;
          // Wmx3Lib_io.
       }
    }
}
