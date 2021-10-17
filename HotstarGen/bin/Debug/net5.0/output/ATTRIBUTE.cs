using System;
namespace Hotstar
{
    public enum NATIVE_ATTRIBUTE : ulong
    { 
        /// <summary>
        /// attributeIndex:
        /// enum ePedAttribute
        /// {
        /// 	PA_HEALTH,
        /// 	PA_STAMINA,
        /// 	PA_SPECIALABILITY,
        /// 	PA_COURAGE,
        /// 	PA_AGILITY,
        /// 	PA_SPEED,
        /// 	PA_ACCELERATION,
        /// 	PA_BONDING,
        /// 	SA_HUNGER,
        /// 	SA_FATIGUED,
        /// 	SA_INEBRIATED,
        /// 	SA_POISONED,
        /// 	SA_BODYHEAT,
        /// 	SA_BODYWEIGHT,
        /// 	SA_OVERFED,
        /// 	SA_SICKNESS,
        /// 	SA_DIRTINESS,
        /// 	SA_DIRTINESSHAT,
        /// 	MTR_STRENGTH,
        /// 	MTR_GRIT,
        /// 	MTR_INSTINCT,
        /// 	PA_UNRULINESS,
        /// 	SA_DIRTINESSSKIN
        /// };
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > int p2
        ///
        /// </summary>
        SET_ATTRIBUTE_BASE_RANK = 0x5DA12E025D47D4E5,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_ATTRIBUTE_RANK = 0xA4C8E23E29040DE0,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_ATTRIBUTE_BASE_RANK = 0x147149F2E909323C,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int coreIndex
        ///
        /// </summary>
        GET_ATTRIBUTE_BONUS_RANK = 0x0EFA71F4B4330E04,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_MAX_ATTRIBUTE_RANK = 0x704674A0535A471D,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > int p2
        ///
        /// </summary>
        SET_ATTRIBUTE_BONUS_RANK = 0x920F9488BD115EFB,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_DEFAULT_ATTRIBUTE_RANK = 0x958DD43D41F89A47,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_DEFAULT_MAX_ATTRIBUTE_RANK = 0x7C059C55AD940CB4,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > int p2
        ///
        /// </summary>
        ADD_ATTRIBUTE_POINTS = 0x75415EE0CB583760,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > int p2
        ///
        /// </summary>
        SET_ATTRIBUTE_POINTS = 0x09A59688C26D88DF,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_ATTRIBUTE_POINTS = 0x219DA04BAA9CB065,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        GET_MAX_ATTRIBUTE_POINTS = 0x223BF310F854871C,
        /// <summary>
        /// coreIndex:
        /// enum eAttributeCore
        /// {
        /// 	ATTRIBUTE_CORE_HEALTH,
        /// 	ATTRIBUTE_CORE_STAMINA,
        /// 	ATTRIBUTE_CORE_DEADEYE
        /// };
        ///
        /// > Ped ped
        /// > int coreIndex
        /// > int value
        ///
        /// </summary>
        _SET_ATTRIBUTE_CORE_VALUE = 0xC6258F41D86676E0,
        /// <summary>
        /// Gets the ped's core value on a scale of 0 to 100.
        /// coreIndex: see _SET_ATTRIBUTE_CORE_VALUE
        ///
        /// > Ped ped
        /// > int coreIndex
        ///
        /// </summary>
        _GET_ATTRIBUTE_CORE_VALUE = 0x36731AC041289BB1,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Hash modelHash
        /// > int attributeIndex
        /// > int rank
        ///
        /// </summary>
        GET_DEFAULT_ATTRIBUTE_POINTS_NEEDED_FOR_RANK = 0x94A7F191DB49A44D,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        /// 
        /// Old name: _SET_ATTRIBUTE_OVERPOWER_VALUE
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > float value
        /// > BOOL makeSound
        ///
        /// </summary>
        ENABLE_ATTRIBUTE_OVERPOWER = 0xF6A7C08DF2E28B28,
        /// <summary>
        /// coreIndex: see _SET_ATTRIBUTE_CORE_VALUE
        /// 
        /// Previously incorrectly named ENABLE_ATTRIBUTE_OVERPOWER
        ///
        /// > Ped ped
        /// > int coreIndex
        /// > float value
        /// > BOOL makeSound
        ///
        /// </summary>
        _ENABLE_ATTRIBUTE_CORE_OVERPOWER = 0x4AF5A4C7B9157D14,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        DISABLE_ATTRIBUTE_OVERPOWER = 0xF8DAC3D85636C241,
        /// <summary>
        /// attributeIndex: see SET_ATTRIBUTE_BASE_RANK
        ///
        /// > Ped ped
        /// > int attributeIndex
        ///
        /// </summary>
        _IS_ATTRIBUTE_OVERPOWERED = 0x103C2F885ABEB00B,
        _IS_ATTRIBUTE_CORE_OVERPOWERED = 0x200373A8DF081F22,
        _GET_ATTRIBUTE_OVERPOWER_SECONDS_LEFT = 0x4C9F782180712742,
        _GET_ATTRIBUTE_CORE_OVERPOWER_SECONDS_LEFT = 0xB429F58803D285B1,
        STOP_ITEM_PREVIEW = 0xD962F8579D702DB5,
        _SET_CORE_ICON = 0xA4D3A1C008F250DF,
        _START_PERIODIC_ICON = 0xFB6E111908502871,
        _STOP_PERIODIC_ICON = 0x3FC4C027FD0936F4,
        _0x7E2C766ADB2C5F1A = 0x7E2C766ADB2C5F1A,
    }
    public static class NATIVE_ATTRIBUTE_EXTENSIONS
    {
        public static void Call(this NATIVE_ATTRIBUTE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_ATTRIBUTE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}