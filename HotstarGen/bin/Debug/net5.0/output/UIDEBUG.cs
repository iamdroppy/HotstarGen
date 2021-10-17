using System;
namespace Hotstar
{
    public enum NATIVE_UIDEBUG : ulong
    { 
        /// <summary>
        /// Note: you must use VAR_STRING
        ///
        /// > const char* text
        /// > float x
        /// > float y
        ///
        /// </summary>
        _BG_DISPLAY_TEXT = 0x16794E044C9EFB58,
        _BG_SET_TEXT_SCALE = 0xA1253A3C870B6843,
        _BG_SET_TEXT_COLOR = 0x16FA5CE47F184F1E,
    }
    public static class NATIVE_UIDEBUG_EXTENSIONS
    {
        public static void Call(this NATIVE_UIDEBUG hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UIDEBUG hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}