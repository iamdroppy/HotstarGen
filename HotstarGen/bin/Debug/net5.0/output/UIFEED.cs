using System;
namespace Hotstar
{
    public enum NATIVE_UIFEED : ulong
    { 
        /// <summary>
        /// Example : https://pastebin.com/GvdBp8Dh
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_FEED_POST_HELP_TEXT = 0x049D5C615BD38BAD,
        /// <summary>
        /// Example : https://pastebin.com/h1YzycuR
        ///
        /// > Any* duration
        /// > Any* data
        /// > BOOL p2
        /// > BOOL p3
        ///
        /// </summary>
        _UI_FEED_POST_LOCATION_SHARD = 0xD05590C1AB38F068,
        /// <summary>
        /// Example : https://pastebin.com/13tuRa63
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_FEED_POST_OBJECTIVE = 0xCEDBF17EFCC0E4A4,
        /// <summary>
        /// Display text on right of the screen, Example : https://pastebin.com/n1YmNe25
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_FEED_POST_FEED_TICKER = 0xB2920B9760F0F36B,
        /// <summary>
        /// Example : https://pastebin.com/YZMBkAmW
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        /// > BOOL p3
        ///
        /// </summary>
        _UI_FEED_POST_SAMPLE_TOAST = 0x26E87218390E6729,
        /// <summary>
        /// Example : https://pastebin.com/kAtEMQTD
        ///
        /// > Any* p0
        /// > Any* p1
        /// > int p2
        /// > int p3
        ///
        /// </summary>
        _UI_FEED_POST_SAMPLE_NOTIFICATION = 0xC927890AA64E9661,
        _UI_FEED_POST_SAMPLE_TOAST_WITH_APP_LINK = 0x38838A646FB30AAE,
        _UI_FEED_POST_SAMPLE_TOAST_RIGHT = 0xB249EBCB30DD88E0,
        _UI_FEED_POST_MISSION_NAME = 0x2024F4F333095FB1,
        _UI_FEED_POST_RETICLE_MESSAGE = 0x893128CDB4B81FBB,
        _UI_FEED_POST_ONE_TEXT_SHARD = 0x860DDFE97CC94DF0,
        _UI_FEED_POST_TWO_TEXT_SHARD = 0xA6F4216AB10EB08E,
        _UI_FEED_POST_THREE_TEXT_SHARD = 0x02BCC0FE9EBA3529,
        _UI_FEED_POST_GAME_UPDATE_SHARD = 0x8D1249BD28791878,
        _UI_FEED_POST_VOICE_CHAT_FEED = 0xC48152BC6B3E821C,
        UI_FEED_CLEAR_CHANNEL = 0xDD1232B332CBB9E7,
        _UI_FEED_CLEAR_ALL_CHANNELS = 0x6035E8FBCA32AC5E,
        UI_FEED_GET_CURRENT_MESSAGE = 0xC17F69E1418CD11F,
        _0xAFF5BE9BA496CE40 = 0xAFF5BE9BA496CE40,
        _0x3F9FDDBA79117C69 = 0x3F9FDDBA79117C69,
        _0x18D6869FBFFEC0F8 = 0x18D6869FBFFEC0F8,
        _0x2F901291EF177B02 = 0x2F901291EF177B02,
        _0x6D85126F6CCF02C9 = 0x6D85126F6CCF02C9,
        _0x4E88A65968A55C78 = 0x4E88A65968A55C78,
        _0x0FD07141AD048AAE = 0x0FD07141AD048AAE,
        _0x59FA676177DBE4C9 = 0x59FA676177DBE4C9,
        _0xB7223B91CD6B7E07 = 0xB7223B91CD6B7E07,
    }
    public static class NATIVE_UIFEED_EXTENSIONS
    {
        public static void Call(this NATIVE_UIFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UIFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}