using System;
namespace Hotstar
{
    public enum NATIVE_DEBUG : ulong
    { 
        /// <summary>
        /// Return example: 1207.69_dev_pc
        ///
        ///
        /// </summary>
        _GET_GAME_BUILD_STRING = 0x05A5F662AD35C573,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xACF9CB705BEFA8CB = 0xACF9CB705BEFA8CB,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xA8D970D8A72640A6 = 0xA8D970D8A72640A6,
    }
    public static class NATIVE_DEBUG_EXTENSIONS
    {
        public static void Call(this NATIVE_DEBUG hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_DEBUG hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}