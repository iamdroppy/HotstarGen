using System;
namespace Hotstar
{
    public enum NATIVE_VOICE : ulong
    { 
        /// <summary>
        /// Params: p1 = 2; p2 = 3 in R* Script net_main_offline
        ///
        /// > Player player
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        _0x4791899615D70FA2 = 0x4791899615D70FA2,
        /// <summary>
        /// Returns p2 value of 0x4791899615D70FA2
        ///
        /// > Player player
        /// > int p1
        ///
        /// </summary>
        _0x767931C727DF2ED7 = 0x767931C727DF2ED7,
        _0xCCF71FCFA0070B1A = 0xCCF71FCFA0070B1A,
        _0x79F478FF5F9F4F05 = 0x79F478FF5F9F4F05,
        _0xAA35FD9ABAB490A3 = 0xAA35FD9ABAB490A3,
        _0x356135B9B10A2A82 = 0x356135B9B10A2A82,
        _0xEF6F2A35FAAF2ED7 = 0xEF6F2A35FAAF2ED7,
        _0x49623BCFC3A3D829 = 0x49623BCFC3A3D829,
        _0x919AF2D93E9AA89D = 0x919AF2D93E9AA89D,
        _0x0DED260A1958A82E = 0x0DED260A1958A82E,
        _0x8E462DB1EAA9C47C = 0x8E462DB1EAA9C47C,
        _0x5CA7FB7D6DE49DCC = 0x5CA7FB7D6DE49DCC,
        _0x58125B691F6827D5 = 0x58125B691F6827D5,
        _0x2F82CAB262C8AE26 = 0x2F82CAB262C8AE26,
        _0x08797A8C03868CB8 = 0x08797A8C03868CB8,
        _0xB779F4FA19269AEC = 0xB779F4FA19269AEC,
        _0x1FBF7F5BA7E4BE3A = 0x1FBF7F5BA7E4BE3A,
        _0xDC9B361CB7776673 = 0xDC9B361CB7776673,
        _0xEC8703E4536A9952 = 0xEC8703E4536A9952,
        _0xDB622ECD3DCBE078 = 0xDB622ECD3DCBE078,
        _0xB6E79850B759A30E = 0xB6E79850B759A30E,
        _0xF8938CF3984092A5 = 0xF8938CF3984092A5,
        _0x1C38C3577901AF1F = 0x1C38C3577901AF1F,
        _0xB3E8841F6BDAF83E = 0xB3E8841F6BDAF83E,
    }
    public static class NATIVE_VOICE_EXTENSIONS
    {
        public static void Call(this NATIVE_VOICE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_VOICE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}