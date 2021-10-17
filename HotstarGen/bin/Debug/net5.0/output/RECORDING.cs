using System;
namespace Hotstar
{
    public enum NATIVE_RECORDING : ulong
    { 
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _STOP_RECORDING_THIS_FRAME = 0xA8C44C13419634F2,
    }
    public static class NATIVE_RECORDING_EXTENSIONS
    {
        public static void Call(this NATIVE_RECORDING hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_RECORDING hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}