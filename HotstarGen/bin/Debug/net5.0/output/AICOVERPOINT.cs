using System;
namespace Hotstar
{
    public enum NATIVE_AICOVERPOINT : ulong
    { 
        TASK_ENTER_COVER = 0x4972A022AE6DAFA1,
        TASK_EXIT_COVER = 0x2BC4A6D92D140112,
        _ADD_SCRIPTED_COVER_POINT = 0x975BD6351648935F,
        _0x53E4D0C079CA6855 = 0x53E4D0C079CA6855,
        _0xC276FE69DDA22BAD = 0xC276FE69DDA22BAD,
        _0x5F5B1B7E8E8F94C6 = 0x5F5B1B7E8E8F94C6,
        _0x957D7E750216D74B = 0x957D7E750216D74B,
        _0x89783FDDF079C88D = 0x89783FDDF079C88D,
        _0x64340DC208D671D5 = 0x64340DC208D671D5,
        _0x7A1FDCF35EAA140F = 0x7A1FDCF35EAA140F,
        _0x2A31D13C5F021D0D = 0x2A31D13C5F021D0D,
        _0x3C7A9C2C953128FE = 0x3C7A9C2C953128FE,
        _0xEBA51A294C73292E = 0xEBA51A294C73292E,
        _0x140B3CB1D424A945 = 0x140B3CB1D424A945,
        _0x8CBE916CFC64AD5C = 0x8CBE916CFC64AD5C,
        _0x1A7A802B2301EDC0 = 0x1A7A802B2301EDC0,
        _0x733077295AB51304 = 0x733077295AB51304,
    }
    public static class NATIVE_AICOVERPOINT_EXTENSIONS
    {
        public static void Call(this NATIVE_AICOVERPOINT hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_AICOVERPOINT hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}