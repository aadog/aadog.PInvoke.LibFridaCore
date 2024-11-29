using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aadog.PInvoke.LibFridaCore
{
    public class MarshalExt
    {
        public static unsafe string? ConvertLPErrorToString(GError* error)
        {
            if (error == null)
            {
                return null;
            }
            return Marshal.PtrToStringUTF8(new IntPtr(error->message));
        }
    }
}
