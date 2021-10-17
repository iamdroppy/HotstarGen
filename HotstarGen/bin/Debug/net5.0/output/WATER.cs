using System;
namespace Hotstar
{
    public enum NATIVE_WATER : ulong
    { 
        /// <summary>
        /// Must be called every frame to take full effect.
        ///
        ///
        /// </summary>
        DISABLE_WATER_LOOKUP = 0x754616EC6965D1FB,
        /// <summary>
        /// Most likely REMOVE_CURRENT_*
        ///
        /// > int p0
        ///
        /// </summary>
        _REMOVE_CURRENT_RISE = 0x4BEF8DD75AF6C71C,
        /// <summary>
        /// 0 = World
        /// 1 = Guarma
        ///
        /// > int waterType
        ///
        /// </summary>
        _SET_WORLD_WATER_TYPE = 0xE8770EE02AEE45C2,
        /// <summary>
        /// Only used in R* Script guama1
        ///
        /// > float wavesHeight
        /// > float p1
        /// > int p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float wavesStrength
        /// > int p8
        ///
        /// </summary>
        _0xC63540AEF8384732 = 0xC63540AEF8384732,
        ENABLE_WATER_LOOKUP = 0x754616EC6965D1BF,
        GET_WATER_HEIGHT = 0xFCA8B23F28813F69,
        GET_WATER_HEIGHT_NO_WAVES = 0xDCF3690AA262C03F,
        TEST_PROBE_AGAINST_ALL_WATER = 0x8974647ED222EA5F,
        TEST_VERTICAL_PROBE_AGAINST_ALL_WATER = 0x2B3451FA1E3142E2,
        _GET_WORLD_WATER_TYPE = 0x189739A7631C1867,
        _0x09A1C7DFDCE54FBC = 0x09A1C7DFDCE54FBC,
        _0xF0FBF193F1F5C0EA = 0xF0FBF193F1F5C0EA,
        _0xA33F5069B0CB89B8 = 0xA33F5069B0CB89B8,
        _0xB34A6009A0DB80B8 = 0xB34A6009A0DB80B8,
        _0xC63540AEF8384769 = 0xC63540AEF8384769,
        _0x0DCEC6A92E497E17 = 0x0DCEC6A92E497E17,
        _0xE8126623008372AA = 0xE8126623008372AA,
    }
    public static class NATIVE_WATER_EXTENSIONS
    {
        public static void Call(this NATIVE_WATER hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_WATER hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}