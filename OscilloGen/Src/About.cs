using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscilloGen.Src;

internal class About
{
    public static readonly short MajorVersion = 1;
    public static readonly short MinorVersion = 1;
    public static readonly string Description = "OscilloGen";

    public static readonly int VENDOR_ID = 0x0483;       // STMicroelectronics
    public static readonly int DFU_ID = 0xdf11;         // DFU
}
