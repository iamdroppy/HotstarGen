using System;
namespace Hotstar
{
    public enum NATIVE_AITRANSPORT : ulong
    { 
        /// <summary>
        /// seat: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Ped ped
        /// > Entity transportEntity
        /// > int seat
        /// > int flags
        ///
        /// </summary>
        SET_PED_ON_TRANSPORT_SEAT = 0xE588B5A8A005CB5E,
        /// <summary>
        /// flagId:
        /// enum eTransportConfigFlags
        /// {
        /// 	TCF_NotConsideredForEntryByLocalPlayer,
        /// 	TCF_0xB78D6624,
        /// 	TCF_0xA9700425,
        /// 	TCF_0x8D7E4641,
        /// 	TCF_0xF24BAA1F,
        /// 	TCF_0x63B77935,
        /// 	TCF_NotConsideredForEntryByAllPlayers,
        /// 	TCF_0xD17A2AFD,
        /// 	TCF_0xD4E4FDD5,
        /// 	TCF_0x8227C929,
        /// 	TCF_0x812C1070,
        /// 	TCF_0x0E1AB26F,
        /// 	TCF_0xBF4EC863,
        /// 	TCF_0x75660C36,
        /// 	TCF_0xA2539E20,
        /// 	TCF_0x9162C633,
        /// 	TCF_DisableHonorModifiers,
        /// 	TCF_0xF9E71CB6,
        /// 	TCF_0x933ECD3F,
        /// 	TCF_0x18513A34
        /// };
        ///
        /// > Entity transportEntity
        /// > int flagId
        /// > BOOL value
        ///
        /// </summary>
        SET_TRANSPORT_CONFIG_FLAG = 0xBA8818212633500A,
        /// <summary>
        /// flagId: see SET_TRANSPORT_CONFIG_FLAG
        ///
        /// > Entity transportEntity
        /// > int flagId
        /// > BOOL p2
        ///
        /// </summary>
        GET_TRANSPORT_CONFIG_FLAG = 0xF382C92CCC1CCDBC,
        /// <summary>
        /// See _SET_TRANSPORT_USAGE_FLAGS
        ///
        /// > Entity transportEntity
        /// > int* flags
        ///
        /// </summary>
        _GET_TRANSPORT_USAGE_FLAGS = 0xE195C5A82156321D,
        /// <summary>
        /// enum eTransportUsageFlags
        /// {
        /// 	TUF_INVALID = 0,
        /// 	TUF_ALLOW_DRIVER_ME = (1 << 0),
        /// 	TUF_ALLOW_DRIVER_GANG = (1 << 1),
        /// 	TUF_ALLOW_DRIVER_CREW = (1 << 2),
        /// 	TUF_ALLOW_DRIVER_FRIENDS = (1 << 3),
        /// 	TUF_ALLOW_DRIVER_ANYONE = (1 << 4),
        /// 	TUF_ALLOW_PASSENGER_ME = (1 << 5),
        /// 	TUF_ALLOW_PASSENGER_GANG = (1 << 6),
        /// 	TUF_ALLOW_PASSENGER_CREW = (1 << 7),
        /// 	TUF_ALLOW_PASSENGER_FRIENDS = (1 << 8),
        /// 	TUF_ALLOW_PASSENGER_ANYONE = (1 << 9),
        /// 	TUF_ALLOW_ACCESS_AI = (1 << 10)
        /// };
        ///
        /// > Entity transportEntity
        /// > int flags
        ///
        /// </summary>
        _SET_TRANSPORT_USAGE_FLAGS = 0xE2487779957FE897,
        TASK_ENTER_TRANSPORT = 0xAEE3ADD08829CB6F,
        TASK_EXIT_TRANSPORT = 0xC273A5B8488F7838,
        SET_PED_OFF_TRANSPORT_SEAT = 0x8886D83A430537FD,
        SET_TRANSPORT_ACCESSIBLE_SEAT_FLAGS = 0xDD0660C997DE94FD,
        IS_PED_ENTERING_TRANSPORT = 0x619E63980BFC0096,
        IS_PED_EXITING_TRANSPORT = 0x660639BC60157048,
        _0x4B6C9A43F7D9109B = 0x4B6C9A43F7D9109B,
        _0x159EF5B6EDCE00E8 = 0x159EF5B6EDCE00E8,
        _0xDC44F405A6B98D03 = 0xDC44F405A6B98D03,
        _0x2E2E06023D07631E = 0x2E2E06023D07631E,
        _0x43FF27FC1829C202 = 0x43FF27FC1829C202,
        _0xFFEC4B0A1A3ED515 = 0xFFEC4B0A1A3ED515,
        _0x4248AB2EEB3C75AD = 0x4248AB2EEB3C75AD,
        _0xB7079F4C72896756 = 0xB7079F4C72896756,
        _0x5639FBEA922788DA = 0x5639FBEA922788DA,
        _0x67F7CEAC2391E114 = 0x67F7CEAC2391E114,
        _0x8C8371EDFAF014A0 = 0x8C8371EDFAF014A0,
        _0xF8C20282B237E3F7 = 0xF8C20282B237E3F7,
        _0x13F138225C202F66 = 0x13F138225C202F66,
    }
    public static class NATIVE_AITRANSPORT_EXTENSIONS
    {
        public static void Call(this NATIVE_AITRANSPORT hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_AITRANSPORT hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}