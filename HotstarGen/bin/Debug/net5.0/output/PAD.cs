using System;
namespace Hotstar
{
    public enum NATIVE_PAD : ulong
    { 
        /// <summary>
        /// Sets the current control context. Must be called every frame.
        /// 
        /// context: https://alloc8or.re/rdr3/doc/misc/input_contexts.txt
        /// For more information, see common:/data/control/settings.meta
        ///
        /// > int p0
        /// > Hash context
        ///
        /// </summary>
        _SET_CONTROL_CONTEXT = 0x2804658EB7D8A50B,
        /// <summary>
        /// padIndex is not used
        ///
        /// > int padIndex
        ///
        /// </summary>
        _IS_USING_KEYBOARD = 0xA571D46727E2B718,
        /// <summary>
        /// nullsub, doesn't do anything
        /// 
        /// Old name: _SET_CONTROL_GROUP_COLOR
        ///
        /// > int padIndex
        /// > int red
        /// > int green
        /// > int blue
        ///
        /// </summary>
        SET_CONTROL_LIGHT_EFFECT_COLOR = 0x8290252FFF36ACB5,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        SET_CONTROL_LIGHT_EFFECT_FLASHING_COLOR = 0xA45884DB10EC7EE3,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > int padIndex
        ///
        /// </summary>
        _0xCB0360EFEFB2580D = 0xCB0360EFEFB2580D,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        ///
        /// </summary>
        _0x14D29BB12D47F68C = 0x14D29BB12D47F68C,
        _IS_CONTROL_ACTION_VALID = 0xBC0884BC590951C7,
        IS_CONTROL_ENABLED = 0x1CEA6BFDF248E5D9,
        IS_CONTROL_PRESSED = 0xF3A21BCD95725A4A,
        IS_CONTROL_RELEASED = 0x648EE3E7F38877DD,
        IS_CONTROL_JUST_PRESSED = 0x580417101DDB492F,
        IS_CONTROL_JUST_RELEASED = 0x50F940259D3841E6,
        GET_CONTROL_VALUE = 0xD95E79E8686D2C27,
        GET_CONTROL_NORMAL = 0xEC3C9B8D5327B563,
        GET_CONTROL_UNBOUND_NORMAL = 0x5B84D09CEC5209C5,
        _SET_CONTROL_NORMAL = 0xE8A25867FBA3B05E,
        IS_DISABLED_CONTROL_PRESSED = 0xE2587F8CBBD87B1D,
        IS_DISABLED_CONTROL_JUST_PRESSED = 0x91AEF906BCA88877,
        IS_DISABLED_CONTROL_JUST_RELEASED = 0x305C8DCD79DA8B0F,
        GET_DISABLED_CONTROL_NORMAL = 0x11E65974A982637C,
        GET_DISABLED_CONTROL_UNBOUND_NORMAL = 0x4F8A26A890FD62FB,
        SET_PAD_SHAKE = 0x48B3886C1358D0D5,
        STOP_PAD_SHAKE = 0x38C16A305E8CDC8D,
        IS_LOOK_INVERTED = 0x77B612531280010D,
        SET_INPUT_EXCLUSIVE = 0xEDE476E5EE29EDB1,
        DISABLE_CONTROL_ACTION = 0xFE99B66D079CF6BC,
        ENABLE_CONTROL_ACTION = 0x351220255D64C155,
        DISABLE_ALL_CONTROL_ACTIONS = 0x5F4B6931816E599B,
        _0xDDCEB0F26C89C00F = 0xDDCEB0F26C89C00F,
        _0xD7D22F5592AED8BA = 0xD7D22F5592AED8BA,
        _0x771DFCB24D19C2F6 = 0x771DFCB24D19C2F6,
        _0x43F35DDB2905D945 = 0x43F35DDB2905D945,
        _0xBD629C1C4F501C80 = 0xBD629C1C4F501C80,
        _0x6CD79468A1E595C6 = 0x6CD79468A1E595C6,
        _0xF239400E16C23E08 = 0xF239400E16C23E08,
        _0xA0CEFCEA390AAB9B = 0xA0CEFCEA390AAB9B,
        _0x5F217BC1190503D8 = 0x5F217BC1190503D8,
        _0x709BA8C08C5C008D = 0x709BA8C08C5C008D,
        _0x1252C029FC8EBB4D = 0x1252C029FC8EBB4D,
        _0x52C68E92D6E23ADD = 0x52C68E92D6E23ADD,
    }
    public static class NATIVE_PAD_EXTENSIONS
    {
        public static void Call(this NATIVE_PAD hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PAD hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}