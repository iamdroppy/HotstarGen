using System;
namespace Hotstar
{
    public enum NATIVE_COMPAPP : ulong
    { 
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Hash p0
        /// > BOOL p1
        ///
        /// </summary>
        _0xB6FD96420C0126A1 = 0xB6FD96420C0126A1,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Hash p0
        /// > int p1
        ///
        /// </summary>
        _0x74BCCEB233AD95B2 = 0x74BCCEB233AD95B2,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Hash p0
        /// > const char* p1
        ///
        /// </summary>
        _0x29C733459A9011EB = 0x29C733459A9011EB,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _0x7AF1BB4504EA5ED9 = 0x7AF1BB4504EA5ED9,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xCCB4635A071FB62D = 0xCCB4635A071FB62D,
    }
    public static class NATIVE_COMPAPP_EXTENSIONS
    {
        public static void Call(this NATIVE_COMPAPP hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_COMPAPP hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}