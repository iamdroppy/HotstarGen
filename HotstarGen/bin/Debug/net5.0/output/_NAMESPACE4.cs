using System;
namespace Hotstar
{
    public enum NATIVE__NAMESPACE4 : ulong
    { 
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any* gamerHandle
        /// > int p1
        ///
        /// </summary>
        _0xC31C44C43B48FDE3 = 0xC31C44C43B48FDE3,
    }
    public static class NATIVE__NAMESPACE4_EXTENSIONS
    {
        public static void Call(this NATIVE__NAMESPACE4 hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE__NAMESPACE4 hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}