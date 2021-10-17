using System;
namespace Hotstar
{
    public enum NATIVE_TELEMETRY : ulong
    { 
        /// <summary>
        /// Works in MP only.
        ///
        /// > Any* uuid
        ///
        /// </summary>
        _TELEMETRY_CREATE_UUID = 0xE692D336F8A2A97F,
        /// <summary>
        /// Does nothing, it's a nullsub.
        ///
        /// > Any* args
        ///
        /// </summary>
        _0x330029E121380CEB = 0x330029E121380CEB,
        _TELEMETRY_MISSION_STARTED = 0x15B0CC1B36F1DE29,
        _TELEMETRY_MISSION_OVER = 0xD894437E12C17AEC,
        _TELEMETRY_MISSION_CHECKPOINT = 0x8EC7890D446BD9C1,
        _TELEMETRY_PLAYER_SPAWNED = 0x5DA4718DF897EB25,
        _TELEMETRY_MATCH_QUEUE = 0x4C08D2B6D8BE17E4,
        _TELEMETRY_MATCH_OVER = 0xA2058154357726BB,
        _TELEMETRY_GAME_PROGRESS = 0x51EC204A6E5B5A1A,
        _TELEMETRY_HERB_PICKED = 0xAE693EC3A178F6C2,
        _TELEMETRY_ANIMAL_SKINNED = 0x7581972ADF5D699A,
        _TELEMETRY_CAMP_CREATED = 0x565EAA726B2CE3B7,
        _TELEMETRY_CAMP_SUPPLIES = 0x217F47761376E16E,
        _TELEMETRY_SHOP_EXIT = 0xF78E669FDC202E73,
        _TELEMETRY_SHOP_PURCHASE = 0x2A374E6F0075EE81,
        _TELEMETRY_SHOP_SELL = 0x9BD8A9D0A774A6F8,
        _TELEMETRY_GOLD_STORE = 0x536B6025E94AC48F,
        _TELEMETRY_SHOP_CUTSCENE = 0xB0B19B56697836F5,
        _TELEMETRY_HONOR = 0xE6B763C7F4902201,
        _TELEMETRY_CRAFT_ITEM = 0x78C2E029DB205A3A,
        TELEMETRY_CAMP_DONATE = 0xDF516E598D966D06,
        _TELEMETRY_MOONSHINE_BREW = 0xB5013EFBB5516867,
        _TELEMETRY_COLLECT = 0xD6CB05DDAEE43AFD,
        _TELEMETRY_MISSION_ILO_OPTION = 0xEA323F5E1A4DA2F1,
        _TELEMETRY_GANG_SHARES = 0xE6DC9B21AC7A8729,
        _TELEMETRY_FAST_TRAVEL = 0x7CEF4AC79F7E7FAD,
        _TELEMETRY_NET_CAMP = 0xA72773C3134F9A57,
        _TELEMETRY_PARLEY_FEUD = 0xF37A2149BC9A8A27,
        TELEMETRY_PLAYER_MENU_PIN = 0x076C5843371EB889,
        _TELEMETRY_NOTORIETY = 0xE26970A7AE0F28E9,
        _TELEMETRY_DEFENSIVE = 0xE57529D23541D2DD,
        _TELEMETRY_LOOT = 0xCF63EF77B0DF0397,
        _TELEMETRY_POKER_OVER = 0x8127C5AA05C5A210,
        _TELEMETRY_ROLE_BOUNTY = 0xAB43D1C80B5E9500,
        _TELEMETRY_BOUNTY_TARGET = 0x52FA31DB8F3AD25D,
        _TELEMETRY_PRISON = 0xB204BF9F30298D77,
        _TELEMETRY_ROLE_TRADER = 0x476038B5A0734C10,
        _TELEMETRY_ROLE_MOONSHINER = 0x99D40C5D74BC88E9,
        _TELEMETRY_ROLE_COLLECTOR = 0x4AC38DFD286DAD14,
        _TELEMETRY_PHOTO = 0xED22BE4C5A399E63,
        _TELEMETRY_GUN_LOCKER = 0x415FE28ED44BFF14,
        _TELEMETRY_ROLE_TOKEN_TRANSACTION = 0x32C2939564D74BFF,
        _TELEMETRY_COUPON = 0x621D719C4836292B,
        TELEMETRY_PERSONAL_VEHICLE_MOUNT = 0xFF9052BC7A3B7D33,
        _TELEMETRY_MENU_NAVIGATION = 0x3255D4D2082C6339,
        _TELEMETRY_HUB_NAVIGATION = 0x25CC50EC1A6F3A96,
        _TELEMETRY_SAMPLE = 0x61559675D23D8BD1,
        _TELEMETRY_ROLE_NATURALIST = 0x6FB9EA308F302922,
        _TELEMETRY_PHOTO_CAM = 0x0777D65EE8A17517,
        _TELEMETRY_INTRO_SKIP = 0x1B554723799245F4,
        ANALYTICS_PLAYTIME_FREEMODE_START = 0xE9F24081D84931B8,
        ANALYTICS_PLAYTIME_FREEMODE_END = 0x3180E991D4B8F248,
        _TELEMETRY_CUSTOM = 0x40914CCF2A1AB531,
        _TELEMETRY_CHAR_CREATOR = 0x7207AD471BC9278C,
        _0x9BEE018A63FFFAD9 = 0x9BEE018A63FFFAD9,
        _0xEC0BD8736DCAF841 = 0xEC0BD8736DCAF841,
        _0xF620F47B4F4A78C4 = 0xF620F47B4F4A78C4,
        _0xEF3C68F56BAD7B69 = 0xEF3C68F56BAD7B69,
        _0xECD67E9FA677CCCF = 0xECD67E9FA677CCCF,
        _0xCD6F8A0335D821F9 = 0xCD6F8A0335D821F9,
        _0x775B2ED944E44973 = 0x775B2ED944E44973,
        _0xCA9E42F437625A85 = 0xCA9E42F437625A85,
        _0x32D5898C4898CD95 = 0x32D5898C4898CD95,
        _0x3145044F3990D321 = 0x3145044F3990D321,
        _0xF5EAD898EF387E73 = 0xF5EAD898EF387E73,
        _0x6571E4327390EC0B = 0x6571E4327390EC0B,
        _0x7E002A36AEFCFB55 = 0x7E002A36AEFCFB55,
        _0xF9F14080D80937BD = 0xF9F14080D80937BD,
        _0x2C24AF8EEEEF8A55 = 0x2C24AF8EEEEF8A55,
        _0x16B23D4F7A1F50D9 = 0x16B23D4F7A1F50D9,
        _0x80A02D9F948A8BCA = 0x80A02D9F948A8BCA,
        _0xF184B3ECE36219CF = 0xF184B3ECE36219CF,
        _0xF0D54E0651DD7E07 = 0xF0D54E0651DD7E07,
        _0xC3ADF4880784FA9C = 0xC3ADF4880784FA9C,
        _0x317D9C9560529CC2 = 0x317D9C9560529CC2,
        _0xE67AF24C5A3B6058 = 0xE67AF24C5A3B6058,
        _0x37AA282163B0D2C4 = 0x37AA282163B0D2C4,
    }
    public static class NATIVE_TELEMETRY_EXTENSIONS
    {
        public static void Call(this NATIVE_TELEMETRY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_TELEMETRY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}