using System;
namespace Hotstar
{
    public enum NATIVE_SPACTIONPROXY : ulong
    { 
        _SPACTIONPROXY_START_MANAGER = 0x1F471B79ACC91BEE,
        _SPACTIONPROXY_MANAGER_IS_READY = 0x1F471B79ACC91BED,
        _SPACTIONPROXY_MANAGER_IS_FAILED = 0x1F471B79ACC91BEC,
        _SPACTIONPROXY_GET_NEXT_PENDING_CRAFTING_ACTION = 0x1F471B79ACC97BEF,
        _SPACTIONPROXY_GET_NEXT_PENDING_BUY_ACTION = 0x1F471B79ACC98BEF,
        _SPACTIONPROXY_PROCESS_ACTION = 0x1F471B79ACC94BEF,
    }
    public static class NATIVE_SPACTIONPROXY_EXTENSIONS
    {
        public static void Call(this NATIVE_SPACTIONPROXY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_SPACTIONPROXY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}