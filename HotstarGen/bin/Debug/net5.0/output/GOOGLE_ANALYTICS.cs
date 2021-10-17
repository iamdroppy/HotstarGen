using System;
namespace Hotstar
{
    public enum NATIVE_GOOGLE_ANALYTICS : ulong
    { 
        _GOOGLE_ANALYTICS_PUSH_PAGE = 0xD43A616AE3AC4EF6,
        _GOOGLE_ANALYTICS_POP_PAGE = 0xC6DE040378364798,
        _GOOGLE_ANALYTICS_START_EVENT = 0x1C54F031D7C0F7AC,
        _GOOGLE_ANALYTICS_END_EVENT = 0x87BBCC4360A9BDE3,
    }
    public static class NATIVE_GOOGLE_ANALYTICS_EXTENSIONS
    {
        public static void Call(this NATIVE_GOOGLE_ANALYTICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_GOOGLE_ANALYTICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}