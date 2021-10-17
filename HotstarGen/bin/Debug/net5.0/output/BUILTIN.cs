using System;
namespace Hotstar
{
    public enum NATIVE_BUILTIN : ulong
    { 
        /// <summary>
        /// Counts up. Every 1000 is 1 real-time second. Use SETTIMERA(int value) to set the timer (e.g.: SETTIMERA(0)).
        ///
        ///
        /// </summary>
        TIMERA = 0x83666F9FB8FEBD4B,
        /// <summary>
        /// Gets the current frame time.
        ///
        ///
        /// </summary>
        TIMESTEP = 0x0000000050597EE2,
        /// <summary>
        /// Calculates the magnitude of a vector.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        VMAG = 0x652D2EEEF1D3E62C,
        /// <summary>
        /// Calculates the magnitude of a vector but does not perform Sqrt operations. (Its way faster)
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        VMAG2 = 0xA8CEACB4F35AE058,
        /// <summary>
        /// Calculates distance between vectors.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        VDIST = 0x2A488C176D52CCA5,
        /// <summary>
        /// Calculates distance between vectors but does not perform Sqrt operations. (Its way faster)
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        VDIST2 = 0xB7A628320EFF8E47,
        /// <summary>
        /// I'm guessing this rounds a float value up to the next whole number, and FLOOR rounds it down
        ///
        /// > float value
        ///
        /// </summary>
        CEIL = 0x11E019C8F43ACC8A,
        /// <summary>
        /// 0 = high
        /// 1 = normal
        /// 2 = low
        ///
        /// > int priority
        ///
        /// </summary>
        SET_THREAD_PRIORITY = 0x42B65DEEF2EDF2A1,
        WAIT = 0x4EDE34FBADD967A6,
        TIMERB = 0xC9D9444186B5A374,
        SETTIMERA = 0xC1B1E9A034A63A62,
        SETTIMERB = 0x5AE11BC36633DE4E,
        SIN = 0x0BADBFA3B172435F,
        COS = 0xD0FFB162F40A139C,
        SQRT = 0x71D93B57D07F9804,
        POW = 0xE3621CC40F31FE2E,
        _LOG10 = 0xE816E655DE37FE20,
        SHIFT_LEFT = 0xEDD95A39E5544DE8,
        SHIFT_RIGHT = 0x97EF1E5BCE9DC075,
        FLOOR = 0xF34EE736CF047844,
        ROUND = 0xF2DB717A73826179,
        TO_FLOAT = 0xBBDA792448DB5A89,
    }
    public static class NATIVE_BUILTIN_EXTENSIONS
    {
        public static void Call(this NATIVE_BUILTIN hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_BUILTIN hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}