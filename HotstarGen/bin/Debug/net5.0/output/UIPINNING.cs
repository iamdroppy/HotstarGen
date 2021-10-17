using System;
namespace Hotstar
{
    public enum NATIVE_UIPINNING : ulong
    { 
        _0x3138582E0A13BFAB = 0x3138582E0A13BFAB,
    }
    public static class NATIVE_UIPINNING_EXTENSIONS
    {
        public static void Call(this NATIVE_UIPINNING hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UIPINNING hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}