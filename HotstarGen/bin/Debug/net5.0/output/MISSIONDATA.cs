using System;
namespace Hotstar
{
    public enum NATIVE_MISSIONDATA : ulong
    { 
        MISSIONDATA_IS_VALID = 0xE54DC27571D5EDC5,
        MISSIONDATA_GET_CATAGORY = 0x57E798B65C45EE17,
        MISSIONDATA_GET_TEXTURE_NAME = 0x57E798B56C45EE15,
        MISSIONDATA_GET_TEXTURE_TXD = 0x57E798B57C45EE16,
        MISSIONDATA_WAS_COMPLETED = 0xE54DC27571D5EDC4,
        MISSIONDATA_GET_RATING = 0x57E798B54C45EE1A,
        MISSIONDATA_IS_REQUIRED_STORY_MISSION = 0xE824CE7D13FCB35E,
        MISSIONDATA_GET_REPLAY_STATE = 0x8C32D86E9556ED86,
        MISSIONDATA_SET_RATING_SCORES = 0x12F65317708749A5,
        MISSIONDATA_SET_HIGH_SCORE = 0x3A04F0169DA87A9D,
        MISSIONDATA_GET_HIGH_SCORE = 0x9AABABF8313C3516,
        MISSIONDATA_SET_REPLAY_LOCKED_FOR_CATEGORY = 0x957A830C9B4B99EA,
        _MISSIONDATA_TIMECYCLE_BOX_SET_MODIFIER = 0x25855B1574BF8CD5,
        _MISSIONDATA_TIMECYCLE_BOX_DELETE = 0x7F89E15A8FB8DE97,
        _MISSIONDATA_TIMECYCLE_BOX_EXISTS = 0x7E8F86A4FA33033C,
        _0xE824CE7D13FCB300 = 0xE824CE7D13FCB300,
        _0xE4E2C581F127A11C = 0xE4E2C581F127A11C,
        _0xE145864DECC34219 = 0xE145864DECC34219,
    }
    public static class NATIVE_MISSIONDATA_EXTENSIONS
    {
        public static void Call(this NATIVE_MISSIONDATA hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_MISSIONDATA hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}