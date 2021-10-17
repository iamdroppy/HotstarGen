using System;
namespace Hotstar
{
    public enum NATIVE_PERSISTENCE : ulong
    { 
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0xB03140014ACA6C40 = 0xB03140014ACA6C40,
        PERSISTENCE_REMOVE_ALL_ENTITIES_IN_AREA = 0x9D16896F0DBE78A2,
        _0x7A1BD123E5CDB6E5 = 0x7A1BD123E5CDB6E5,
        _0x065887B694359799 = 0x065887B694359799,
        _0xFC9806DA9A460093 = 0xFC9806DA9A460093,
        _0xE225CEF1901F6108 = 0xE225CEF1901F6108,
        _0x8DE104BEC243A73B = 0x8DE104BEC243A73B,
        _0xEFB5F34CC0953B27 = 0xEFB5F34CC0953B27,
        _0xBA2C49EA6A8D24FF = 0xBA2C49EA6A8D24FF,
        _0x2E545965DF98D476 = 0x2E545965DF98D476,
        _0xF5622FA6ACFCA7DB = 0xF5622FA6ACFCA7DB,
        _0x3CA5E58C9731A16B = 0x3CA5E58C9731A16B,
        _0xDC0A1F0ECEC9F0C0 = 0xDC0A1F0ECEC9F0C0,
        _0x5A79220F6D38D7C3 = 0x5A79220F6D38D7C3,
        _0xCFDA2518F322D836 = 0xCFDA2518F322D836,
        _0x1F56FB3FDB4EAF65 = 0x1F56FB3FDB4EAF65,
        _0x291CC21D1FB6790E = 0x291CC21D1FB6790E,
        _0x8245C1F3262F4AC2 = 0x8245C1F3262F4AC2,
        _0xFB7CF1DE938A3E22 = 0xFB7CF1DE938A3E22,
        _0xB6E1A185C2B9319A = 0xB6E1A185C2B9319A,
        _0x188313616D184213 = 0x188313616D184213,
        _0x66DAA3A9274E8E82 = 0x66DAA3A9274E8E82,
    }
    public static class NATIVE_PERSISTENCE_EXTENSIONS
    {
        public static void Call(this NATIVE_PERSISTENCE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PERSISTENCE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}