using System;
namespace Hotstar
{
    public enum NATIVE_UNLOCK : ulong
    { 
        _UNLOCK_IS_UNLOCK_FLAG_SET = 0x6B6369647F26F09F,
        UNLOCK_IS_UNLOCKED = 0xC4B660C7B6040E75,
        UNLOCK_SET_UNLOCKED = 0x1B7C5ADA8A6910A0,
        UNLOCK_IS_VISIBLE = 0x8588A14B75AF096B,
        UNLOCK_SET_VISIBLE = 0x46B901A8ECDB5A61,
        _UNLOCK_IS_NEW = 0x644166BA7AA49DEA,
        _UNLOCK_SET_NEW = 0xA6D79C7AEF870A99,
        _UNLOCK_IS_LOOTABLE = 0x66BF197E066050DE,
        _0x7C1C2062CFAD06FE = 0x7C1C2062CFAD06FE,
    }
    public static class NATIVE_UNLOCK_EXTENSIONS
    {
        public static void Call(this NATIVE_UNLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UNLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}