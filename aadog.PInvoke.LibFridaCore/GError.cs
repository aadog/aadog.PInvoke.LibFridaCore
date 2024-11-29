using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aadog.PInvoke.LibFridaCore
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GError
    {
        public GQuark domain;
        public gint code;
        public gchar* message;
    };

}
