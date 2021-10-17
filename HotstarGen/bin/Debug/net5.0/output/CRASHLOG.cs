using System;
namespace Hotstar
{
    public enum NATIVE_CRASHLOG : ulong
    { 
        _0x0FD3ECF9D0C8655F = 0x0FD3ECF9D0C8655F,
        _0xCA0BAC376C541978 = 0xCA0BAC376C541978,
        _0x3A66F1963B223F61 = 0x3A66F1963B223F61,
        _0x7C680FF55617F82F = 0x7C680FF55617F82F,
        _0xD8E3D22AA4F0E0A5 = 0xD8E3D22AA4F0E0A5,
        _0xA67F0B039D9CD513 = 0xA67F0B039D9CD513,
        _0xE72E234B30DA7B7A = 0xE72E234B30DA7B7A,
        _0x87F005C969EF1563 = 0x87F005C969EF1563,
        _0x23CCAB8F40B9CBEE = 0x23CCAB8F40B9CBEE,
        _0xF0D545C1EEAD614A = 0xF0D545C1EEAD614A,
        _0x33C1D63E55FA4284 = 0x33C1D63E55FA4284,
        _0x4E42CA5BCD45444A = 0x4E42CA5BCD45444A,
        _0xDA05310EA94DC8C6 = 0xDA05310EA94DC8C6,
    }
    public static class NATIVE_CRASHLOG_EXTENSIONS
    {
        public static void Call(this NATIVE_CRASHLOG hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_CRASHLOG hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}