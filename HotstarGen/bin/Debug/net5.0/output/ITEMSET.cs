using System;
namespace Hotstar
{
    public enum NATIVE_ITEMSET : ulong
    { 
        CREATE_ITEMSET = 0xA1AF16083320065A,
        DESTROY_ITEMSET = 0x712BC69F10549B92,
        IS_ITEMSET_VALID = 0xD30765D153EF5C76,
        ADD_TO_ITEMSET = 0xABE74510883C7950,
        REMOVE_FROM_ITEMSET = 0xC5BAA432B429DC24,
        GET_ITEMSET_SIZE = 0x55F2E375AC6018A9,
        GET_INDEXED_ITEM_IN_ITEMSET = 0x275A2E2C0FAB7612,
        GET_INDEXED_SCENARIO_POINT_INDEX_IN_ITEMSET = 0x9FC3CDB5CE815901,
        IS_IN_ITEMSET = 0xD1503C2EE2FE688C,
        CLEAN_ITEMSET = 0x85F3A86CA9021FB0,
        _CLEAR_ITEMSET = 0x20A4BF0E09BEE146,
    }
    public static class NATIVE_ITEMSET_EXTENSIONS
    {
        public static void Call(this NATIVE_ITEMSET hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_ITEMSET hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}