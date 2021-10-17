using System;
namespace Hotstar
{
    public enum NATIVE_UISTICKYFEED : ulong
    { 
        /// <summary>
        /// Example: https://pastebin.com/EJD7ytnz
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_STICKY_FEED_CREATE_ERROR_MESSAGE = 0x9F2CC2439A04E7BA,
        /// <summary>
        /// Example: https://pastebin.com/JygJShNU
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_STICKY_FEED_CREATE_DEATH_FAIL_MESSAGE = 0x815C4065AE6E6071,
        /// <summary>
        /// Example: https://pastebin.com/6mLtee2S
        ///
        /// > Any* p0
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_STICKY_FEED_CREATE_WARNING_MESSAGE = 0x339E16B41780FC35,
        /// <summary>
        /// Seems to only update _UI_STICKY_FEED_CREATE_ERROR_MESSAGE(0x9F2CC2439A04E7BA) and _UI_STICKY_FEED_CREATE_DEATH_FAIL_MESSAGE(0x815C4065AE6E6071) message.
        /// Example: https://pastebin.com/nDrJyWq2
        ///
        /// > int msgId
        /// > Any* p1
        /// > BOOL p2
        ///
        /// </summary>
        _UI_STICKY_FEED_UPDATE_MESSAGE = 0xBC6F454E310124DA,
        /// <summary>
        /// Returns state of sticky feed message:
        /// 0 - INITIALIZING
        /// 1 - IN QUEUE
        /// 2 - WAITING TO SHOW
        /// 3 - ENTERING
        /// 4 - SHOWING
        /// 5 - EXITING
        /// 6 - COMPLETE
        /// 7 - COUNT
        ///
        /// > int msgId
        ///
        /// </summary>
        _UI_STICKY_FEED_GET_MESSAGE_STATE = 0x07954320D77F6A3D,
        _UI_STICKY_FEED_CLEAR_MESSAGE = 0x00A15B94CBA4F76F,
        _UI_STICKY_FEED_IS_CHANNEL_ACTIVE = 0xC5C395C60B542A3C,
        _UI_STICKY_FEED_IS_ALERT_SCREEN_ACTIVE = 0xF8806EC3FF840FDC,
    }
    public static class NATIVE_UISTICKYFEED_EXTENSIONS
    {
        public static void Call(this NATIVE_UISTICKYFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UISTICKYFEED hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}