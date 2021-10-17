using System;
namespace Hotstar
{
    public enum NATIVE_QUEUE : ulong
    { 
        _EVENT_QUEUE_IS_EMPTY = 0x402B5D7D269FF796,
        _EVENT_QUEUE_POP = 0xD87DF294B049211D,
    }
    public static class NATIVE_QUEUE_EXTENSIONS
    {
        public static void Call(this NATIVE_QUEUE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_QUEUE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}