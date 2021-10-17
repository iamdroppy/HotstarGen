using System;
namespace Hotstar
{
    public enum NATIVE_TXD : ulong
    { 
        DOES_STREAMED_TXD_EXIST = 0xBA0163B277C2D2D0,
        REQUEST_STREAMED_TXD = 0xDB1BD07FB464584D,
        HAS_STREAMED_TXD_LOADED = 0xBE72591D1509FFE4,
        SET_STREAMED_TXD_AS_NO_LONGER_NEEDED = 0x8232F37DF762ACB2,
        DOES_STREAMED_TEXTURE_DICT_EXIST = 0x7332461FC59EB7EC,
        REQUEST_STREAMED_TEXTURE_DICT = 0xC1BA29DF5631B0F8,
        HAS_STREAMED_TEXTURE_DICT_LOADED = 0x54D6900929CCF162,
        SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED = 0x4ACA10A91F66F1E2,
    }
    public static class NATIVE_TXD_EXTENSIONS
    {
        public static void Call(this NATIVE_TXD hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_TXD hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}