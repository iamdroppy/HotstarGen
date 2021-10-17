using System;
namespace Hotstar
{
    public enum NATIVE_DECORATOR : ulong
    { 
        /// <summary>
        /// This function sets metadata of type bool to specified entity.
        /// 
        ///
        /// > Entity entity
        /// > const char* propertyName
        /// > BOOL value
        ///
        /// </summary>
        DECOR_SET_BOOL = 0xFE26E4609B1C3772,
        /// <summary>
        /// Sets property to int.
        ///
        /// > Entity entity
        /// > const char* propertyName
        /// > int value
        ///
        /// </summary>
        DECOR_SET_INT = 0xE88F4D7F52A6090F,
        /// <summary>
        /// Returns whether or not the specified property is set for the entity.
        ///
        /// > Entity entity
        /// > const char* propertyName
        ///
        /// </summary>
        DECOR_EXIST_ON = 0xD9D1CDBF3464DCDF,
        /// <summary>
        /// type: see DECOR_REGISTER
        ///
        /// > const char* propertyName
        /// > int type
        ///
        /// </summary>
        DECOR_IS_REGISTERED_AS_TYPE = 0x72355278C069F272,
        DECOR_SET_FLOAT = 0x238F8B0C1C7FE834,
        _DECOR_SET_UINT8 = 0x4BDC83150D43772D,
        _DECOR_SET_STRING = 0x0671C1A3FF7AFDFC,
        DECOR_GET_BOOL = 0xDEF3F1B071ABB197,
        DECOR_GET_FLOAT = 0xE5FF70CD842CA9D4,
        DECOR_GET_INT = 0x44DB62727762FD9B,
        _DECOR_GET_UINT8 = 0xB1682B2443F0540B,
        DECOR_REMOVE = 0x2BA7F5877A088A1D,
        _DECOR_REMOVE_ALL = 0x88942780E0ADEA42,
        DECOR_REGISTER = 0x0B253D644E3C36B3,
        _DECOR_REGISTER_2 = 0x4587374F88B7F6C2,
    }
    public static class NATIVE_DECORATOR_EXTENSIONS
    {
        public static void Call(this NATIVE_DECORATOR hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_DECORATOR hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}