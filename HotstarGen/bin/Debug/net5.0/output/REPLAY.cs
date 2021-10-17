using System;
namespace Hotstar
{
    public enum NATIVE_REPLAY : ulong
    { 
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _IS_INTERIOR_RENDERING_DISABLED = 0x0F838D47DE58EDB2,
        /// <summary>
        /// Hardcoded to return true.
        ///
        ///
        /// </summary>
        OPEN_VIDEO_EDITOR = 0xB3F2829907403C13,
        /// <summary>
        /// Hardcoded to return true.
        ///
        /// > Any p0
        ///
        /// </summary>
        CLOSE_VIDEO_EDITOR = 0xCEEC64BD27A59312,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        IS_VIDEO_EDITOR_RUNNING = 0x9EEB007317FA3B9C,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x57C6525034E76EB0 = 0x57C6525034E76EB0,
    }
    public static class NATIVE_REPLAY_EXTENSIONS
    {
        public static void Call(this NATIVE_REPLAY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_REPLAY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}