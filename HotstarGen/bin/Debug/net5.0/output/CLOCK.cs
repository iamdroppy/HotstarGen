using System;
namespace Hotstar
{
    public enum NATIVE_CLOCK : ulong
    { 
        /// <summary>
        /// SET_CLOCK_TIME(12, 34, 56);
        ///
        /// > int hour
        /// > int minute
        /// > int second
        ///
        /// </summary>
        SET_CLOCK_TIME = 0x3A52C59FFB2DEED8,
        /// <summary>
        /// Gets the current ingame hour, expressed without zeros. (09:34 will be represented as 9)
        ///
        ///
        /// </summary>
        GET_CLOCK_HOURS = 0xC82CF208C2B19199,
        /// <summary>
        /// Gets the current ingame clock minute.
        ///
        ///
        /// </summary>
        GET_CLOCK_MINUTES = 0x4E162231B823DBBF,
        /// <summary>
        /// Gets the current ingame clock second. Note that ingame clock seconds change really fast since a day in RDR is only 48 minutes in real life.
        ///
        ///
        /// </summary>
        GET_CLOCK_SECONDS = 0xB6101ABE62B5F080,
        /// <summary>
        /// Base year is 1898.
        ///
        ///
        /// </summary>
        _GET_SECONDS_SINCE_BASE_YEAR = 0x78FD8BE812E436B2,
        /// <summary>
        /// Gets the current day of the week.
        /// 
        /// 0: Sunday
        /// 1: Monday
        /// 2: Tuesday
        /// 3: Wednesday
        /// 4: Thursday
        /// 5: Friday
        /// 6: Saturday
        ///
        ///
        /// </summary>
        GET_CLOCK_DAY_OF_WEEK = 0x4DD02D4C7FB30076,
        /// <summary>
        /// Same as GET_POSIX_TIME except that it takes a single pointer to a struct.
        ///
        /// > Any* outTime
        ///
        /// </summary>
        _GET_POSIX_TIME_STRUCT = 0x86A68E84E5884951,
        PAUSE_CLOCK = 0x4D1A590C92BF377E,
        _PAUSE_CLOCK_THIS_FRAME = 0x568D998A9FF96774,
        ADVANCE_CLOCK_TIME_TO = 0x0184750AE88D0B1D,
        ADD_TO_CLOCK_TIME = 0xAB7C251C7701D336,
        _SET_MILLISECONDS_PER_GAME_MINUTE = 0x04EEDB3848DACF68,
        SET_CLOCK_DATE = 0x02AD3092562941E2,
        GET_CLOCK_DAY_OF_MONTH = 0xDF2FD796C54480A5,
        GET_CLOCK_MONTH = 0x2D44E8FC79EAB1AC,
        GET_CLOCK_YEAR = 0xE136DCA28C4A48BA,
        GET_MILLISECONDS_PER_GAME_MINUTE = 0xE4CB8D126501EC52,
        GET_POSIX_TIME = 0x90338AD4A784E455,
        _ADD_TIME_TO_DATE_TIME = 0x28EEACE9B43D9597,
    }
    public static class NATIVE_CLOCK_EXTENSIONS
    {
        public static void Call(this NATIVE_CLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_CLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}