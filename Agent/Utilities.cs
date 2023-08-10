using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Agent
{
    public static class Utilities
    {
        public static bool Is64Bit
            => IntPtr.Size == 8;
    }
}
