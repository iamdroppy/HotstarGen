using System;
namespace Hotstar
{
    public enum NATIVE_IK : ulong
    { 
        _0x66F9EB44342BB4C5 = 0x66F9EB44342BB4C5,
        _0x0B9F7A01EC50448D = 0x0B9F7A01EC50448D,
        _0x0EABF182FBB63D72 = 0x0EABF182FBB63D72,
        _0x6098139150DCC745 = 0x6098139150DCC745,
        _0x873C792E07A32C8B = 0x873C792E07A32C8B,
    }
    public static class NATIVE_IK_EXTENSIONS
    {
        public static void Call(this NATIVE_IK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_IK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}