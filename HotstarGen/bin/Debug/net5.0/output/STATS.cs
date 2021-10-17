using System;
namespace Hotstar
{
    public enum NATIVE_STATS : ulong
    { 
        /// <summary>
        /// struct StatId
        /// {
        /// 	alignas(8) Hash BaseId;
        /// 	alignas(8) Hash PermutationId;
        /// }
        ///
        /// > Any* statId
        ///
        /// </summary>
        STAT_ID_IS_VALID = 0xC48FE1971C9743FF,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > int value
        /// > BOOL p2
        ///
        /// </summary>
        STAT_ID_SET_INT = 0xA4DDF5DF95E65EEE,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > float value
        /// > BOOL p2
        ///
        /// </summary>
        STAT_ID_SET_FLOAT = 0x481BDF6A10C5EF68,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > BOOL value
        /// > BOOL p2
        ///
        /// </summary>
        STAT_ID_SET_BOOL = 0x3B5107353267D7A1,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > const char* label
        /// > BOOL p2
        ///
        /// </summary>
        STAT_ID_SET_GXT_LABEL = 0x05060A54834F2382,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > Any* date
        /// > BOOL p2
        ///
        /// </summary>
        STAT_ID_SET_DATE = 0x1FAE9B2FAA2DFE06,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > int* p1
        ///
        /// </summary>
        STAT_ID_GET_INT = 0x767FBC2AC802EF3E,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > float* value
        ///
        /// </summary>
        STAT_ID_GET_FLOAT = 0xD7AE6C9C9C6AC54D,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > BOOL* value
        ///
        /// </summary>
        STAT_ID_GET_BOOL = 0x11B5E6D2AE73F48F,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        /// > Any* date
        ///
        /// </summary>
        STAT_ID_GET_DATE = 0x8B0FACEFC36C824C,
        /// <summary>
        /// statId: see 0xC48FE1971C9743FF
        ///
        /// > Any* statId
        ///
        /// </summary>
        STAT_ID_SET_TO_POSSE_ID = 0x34B22DE38477EDB4,
        _STAT_ID_INCREMENT_INT = 0x6A0184E904CDF25E,
        _STAT_ID_INCREMENT_FLOAT = 0x4A47E38EA3D60939,
        STAT_ADD_BOUNTY_TARGET = 0x6B1044FDC2B09101,
        STAT_BOUNTY_CAPTURED = 0x262EF7CF49CF1EB9,
        STAT_BOUNTY_ESCAPED = 0xB22F05732F72F70C,
        STAT_PHOTOGRAPH_TAKEN = 0x4D31051A4CA83787,
        STAT_REGISTER_LEGENDARY_ANIMAL_DEED = 0xCD0D69C65BB0E8B9,
        STATSTRACKER_IS_INITIALIZED = 0x01F4D242765C6B24,
        STATSTRACKER_DEED_STARTED = 0xB2A38826E5886E83,
        CHAL_IS_GOAL_ACTIVE = 0x04DAC3929796EB87,
        CHAL_SET_GOAL_DISABLED = 0xF63DF9EE16393343,
        CHAL_GET_NUM_RANKS_COMPLETED = 0x58CB53DB63F84DE9,
        CHAL_GET_MAX_RANKS = 0x58CB53DB63F84DEA,
        CHAL_ADD_GOAL_PROGRESS_INT = 0xDDBD560745B1EE9A,
        CHAL_ADD_GOAL_PROGRESS_FLOAT = 0x86922D8C02FB7703,
        CHAL_SET_GOAL_PROGRESS_INT = 0xDDBD560745B1EE9B,
        CHAL_ADD_GOAL_PROGRESS_INT_BY_SCORE_ID = 0xDDBD560745B1EE9C,
        CHAL_ADD_GOAL_PROGRESS_FLOAT_BY_SCORE_ID = 0x86922D8C02FB7705,
        CHAL_ACHIEVEMENT_IS_COMPLETE = 0x77B97A827739D434,
        CHAL_ACHIEVEMENT_GET_PROGRESS_INT = 0x808712E428F697B8,
        CHAL_NET_START_CHAL = 0x4ABF7E4DB6279E8F,
        CHAL_NET_STOP_CHAL = 0x43B0163154A50C86,
        CHAL_NET_START_GOAL = 0xC3FCB47344DCB638,
        CHAL_NET_STOP_GOAL = 0x00CE6A93324A590B,
        CHAL_MISSION_GET_NUM_GOALS = 0x0B0576DD3A75E58D,
        CHAL_MISSION_GET_NUM_GOALS_COMPLETE = 0xA785A52B59B7E7B2,
        CHAL_MISSION_IS_GOAL_COMPLETE = 0xC0BB774787BBF301,
        CHAL_MISSION_ADD_GOAL_PROGRESS_INT = 0x97E18E7C098626DE,
        WEEKLY_COLLECTIBLE_GET_NUM_SETS = 0x8F5317729F791D10,
        WEEKLY_COLLECTIBLE_GET_ITEM_SET_BUY_AWARD = 0x610783F646894D25,
        WEEKLY_COLLECTIBLE_GET_ITEM_SET_LABEL = 0xBFFA88522FF0F730,
        WEEKLY_COLLECTIBLE_GET_NUM_ITEMS_IN_SET = 0x7D675C9DDDB365BE,
        WEEKLY_COLLECTIBLE_GET_ITEM_IN_SET = 0xBA61BA6205A3F5A8,
        _0x0FEE2561120F3333 = 0x0FEE2561120F3333,
        _0xBD861AE8A5181ED7 = 0xBD861AE8A5181ED7,
        _0x91A4F58E01ED5E4C = 0x91A4F58E01ED5E4C,
        _0xE141F6B40B1E3683 = 0xE141F6B40B1E3683,
        _0x1E7384AB5D4F4581 = 0x1E7384AB5D4F4581,
        _0x5420D398A42917FC = 0x5420D398A42917FC,
        _0xDA26263C87CCE9C1 = 0xDA26263C87CCE9C1,
        _0x831BF01C56149A8A = 0x831BF01C56149A8A,
        _0x7C2ABF6E556B21FC = 0x7C2ABF6E556B21FC,
        _0x8312F09C56149A8A = 0x8312F09C56149A8A,
        _0x378D3B1B11D9385B = 0x378D3B1B11D9385B,
        _0xDA26263C07CCE9C2 = 0xDA26263C07CCE9C2,
        _0xD64DBC8B0424135F = 0xD64DBC8B0424135F,
        _0xA59590050F80FF2E = 0xA59590050F80FF2E,
        _0x90E9A5DADBABC918 = 0x90E9A5DADBABC918,
        _0xF8181B5EF156862C = 0xF8181B5EF156862C,
        _0x8C889E4CBB4B2356 = 0x8C889E4CBB4B2356,
        _0xA596890CF55B5095 = 0xA596890CF55B5095,
        _0xF21A5D66874FCEDD = 0xF21A5D66874FCEDD,
        _0x3EB2791A1FBC8A42 = 0x3EB2791A1FBC8A42,
        _0xDF95DF488A645CE7 = 0xDF95DF488A645CE7,
        _0xBE66B26B6529E943 = 0xBE66B26B6529E943,
        _0xF2B5ABDE09958689 = 0xF2B5ABDE09958689,
        _0x302E71C1D9EE75B9 = 0x302E71C1D9EE75B9,
        _0x6123E2832C34243D = 0x6123E2832C34243D,
        _0xCA41E86545413B5B = 0xCA41E86545413B5B,
        _0xD5910ECF81A2278C = 0xD5910ECF81A2278C,
        _0x99230691875FC218 = 0x99230691875FC218,
        _0x025E98E317652CDD = 0x025E98E317652CDD,
        _0xE5A680A5D8B1F687 = 0xE5A680A5D8B1F687,
        _0x4DAC398297981B87 = 0x4DAC398297981B87,
        _0xDDBD560745B1EE98 = 0xDDBD560745B1EE98,
        _0xB112B9262EC29C20 = 0xB112B9262EC29C20,
        _0x4FCBCC0584CD08E9 = 0x4FCBCC0584CD08E9,
        _0xCA1F0B5103936891 = 0xCA1F0B5103936891,
        _0x8BA3D7B1E83EF803 = 0x8BA3D7B1E83EF803,
        _0x9D0F5D2E1951CD84 = 0x9D0F5D2E1951CD84,
        _0x218F7710A139D012 = 0x218F7710A139D012,
        _0x3AEABAE3F3C7600C = 0x3AEABAE3F3C7600C,
        _0x3F6FD87D2030ADC6 = 0x3F6FD87D2030ADC6,
        _0xA2E2BEA4E83F6270 = 0xA2E2BEA4E83F6270,
        _0xB5E2EDA2135E0FA1 = 0xB5E2EDA2135E0FA1,
        _0x4F2D5FA23DB992DE = 0x4F2D5FA23DB992DE,
        _0x4E463A3CDEFFFE96 = 0x4E463A3CDEFFFE96,
    }
    public static class NATIVE_STATS_EXTENSIONS
    {
        public static void Call(this NATIVE_STATS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_STATS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}