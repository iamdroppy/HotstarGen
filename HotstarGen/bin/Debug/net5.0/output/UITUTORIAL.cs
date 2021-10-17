using System;
namespace Hotstar
{
    public enum NATIVE_UITUTORIAL : ulong
    { 
        /// <summary>
        /// enum eRpgIcons
        /// {
        /// 	ICON_STAMINA,
        /// 	ICON_STAMINA_CORE,
        /// 	ICON_DEADEYE,
        /// 	ICON_DEADEYE_CORE,
        /// 	ICON_HEALTH,
        /// 	ICON_HEALTH_CORE,
        /// 	ICON_HORSE_HEALTH,
        /// 	ICON_HORSE_HEALTH_CORE,
        /// 	ICON_HORSE_STAMINA,
        /// 	ICON_HORSE_STAMINA_CORE,
        /// 	ICON_HORSE_COURAGE,
        /// 	ICON_HORSE_COURAGE_CORE
        /// };
        ///
        /// > int rpgIcon
        /// > int visibility
        ///
        /// </summary>
        _UITUTORIAL_SET_RPG_ICON_VISIBILITY = 0xC116E6DF68DCE667,
        _UITUTORIAL_GET_IS_THREAT_INDICATOR_CAPABLE_RADAR_SHOWN = 0x2CC24A2A7A1489C4,
        _UITUTORIAL_GET_IS_THREAT_INDICATOR_ON = 0xFC2E0A5E9ED4E1B4,
    }
    public static class NATIVE_UITUTORIAL_EXTENSIONS
    {
        public static void Call(this NATIVE_UITUTORIAL hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UITUTORIAL hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}