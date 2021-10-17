using System;
namespace Hotstar
{
    public enum NATIVE_SAVE : ulong
    { 
        /// <summary>
        /// enum eSavegameType : Hash
        /// {
        /// 	SAVEGAMETYPE_AMBIENT = 0x3CA4E1F8,
        /// 	SAVEGAMETYPE_DEFAULT = 0xCB6ED080,
        /// 	SAVEGAMETYPE_DELETE_CHAR = 0xCD35F947,
        /// 	SAVEGAMETYPE_END_CREATE_NEWCHAR = 0x4C50A3CE,
        /// 	SAVEGAMETYPE_END_MATCH = 0xE470ED50,
        /// 	SAVEGAMETYPE_END_MISSION = 0x9A444E54,
        /// 	SAVEGAMETYPE_END_SESSION = 0x6D23956C,
        /// 	SAVEGAMETYPE_END_SHOPPING = 0xA311A6C4,
        /// 	SAVEGAMETYPE_RANKUP = 0xE25F8017,
        /// 	SAVEGAMETYPE_SCRIPT_MP_GLOBALS = 0xAFF30AD4,
        /// 	SAVEGAMETYPE_SP_AUTOSAVE = 0xF4AE69EC,
        /// 	SAVEGAMETYPE_SP_DEBUG = 0x6A8122FD,
        /// 	SAVEGAMETYPE_SP_PROPERTY = 0xAE0AB38E
        /// };
        ///
        /// > Hash savegameType
        ///
        /// </summary>
        SAVEGAME_SAVE_SP = 0x62C9EB51656D68CE,
        /// <summary>
        /// See SAVEGAME_SAVE_SP
        ///
        /// > Hash savegameType
        ///
        /// </summary>
        SAVEGAME_SAVE_MP = 0x1840F3B30ED0105F,
        SAVEGAME_IS_SAVE_PENDING = 0x3CF46F55C6585590,
        _0x4FB5869E2B37FC00 = 0x4FB5869E2B37FC00,
        _0x1431540BCA1A1BD2 = 0x1431540BCA1A1BD2,
        _0xA7ECEBAFBAF997A5 = 0xA7ECEBAFBAF997A5,
        _0xED4B0C1057892B2E = 0xED4B0C1057892B2E,
        _0x9BB83C4DD7BE0802 = 0x9BB83C4DD7BE0802,
        _0xE8346E62FD7FB962 = 0xE8346E62FD7FB962,
        _0xC0ABF784590798A9 = 0xC0ABF784590798A9,
        _0xB00CE33465B5406D = 0xB00CE33465B5406D,
        _0x529B9CCD0972AF4D = 0x529B9CCD0972AF4D,
        _0x529B9CCD0972AF4E = 0x529B9CCD0972AF4E,
        _0xB25B5A375BE5BE26 = 0xB25B5A375BE5BE26,
        _0x35DEFECAE36D4FAE = 0x35DEFECAE36D4FAE,
        _0xBB7F4273C186BC4B = 0xBB7F4273C186BC4B,
        _0x5A10D6506B2F2C63 = 0x5A10D6506B2F2C63,
        _0x4845E7E7643A908C = 0x4845E7E7643A908C,
        _0x186608A2AC6F9E88 = 0x186608A2AC6F9E88,
        _0x443174C20B8B9E7F = 0x443174C20B8B9E7F,
        _0x8E8FFB9E4AD051D2 = 0x8E8FFB9E4AD051D2,
        _0xE0B45E983BFC0768 = 0xE0B45E983BFC0768,
        _0x81F4E92BE3958364 = 0x81F4E92BE3958364,
        _0xA844FEB5C22C2C74 = 0xA844FEB5C22C2C74,
    }
    public static class NATIVE_SAVE_EXTENSIONS
    {
        public static void Call(this NATIVE_SAVE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_SAVE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}