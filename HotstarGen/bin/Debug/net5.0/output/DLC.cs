using System;
namespace Hotstar
{
    public enum NATIVE_DLC : ulong
    { 
        IS_DLC_PRESENT = 0x2763DC12BBE2BB6F,
        GET_IS_LOADING_SCREEN_ACTIVE = 0x71D4BF5890659B0C,
        _GET_SPECIAL_EDITION_CORE_STATS_BONUS_ENABLED = 0xA16B4FBA7887D7BA,
        _GET_SPECIAL_EDITION_CASH_CAMP_BONUS_ENABLED = 0x1DB9D61E505AE3FC,
    }
    public static class NATIVE_DLC_EXTENSIONS
    {
        public static void Call(this NATIVE_DLC hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_DLC hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}