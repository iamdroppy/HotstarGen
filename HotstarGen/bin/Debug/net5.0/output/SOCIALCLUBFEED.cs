using System;
namespace Hotstar
{
    public enum NATIVE_SOCIALCLUBFEED : ulong
    { 
        _SC_FEED_SUBMIT_PRESET_MESSAGE = 0xEFB64240F6B17817,
        SC_FEED_HUB_HAS_NEW_DATA = 0x068332D20CB6F897,
    }
    public static class NATIVE_SOCIALCLUBFEED_EXTENSIONS
    {
        public static void Call(this NATIVE_SOCIALCLUBFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_SOCIALCLUBFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}