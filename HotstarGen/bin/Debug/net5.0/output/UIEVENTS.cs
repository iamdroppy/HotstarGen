using System;
namespace Hotstar
{
    public enum NATIVE_UIEVENTS : ulong
    { 
        /// <summary>
        /// Old name: _EVENT_MANAGER_IS_EVENT_PENDING
        ///
        /// > Hash hash
        ///
        /// </summary>
        EVENTS_UI_IS_PENDING = 0x67ED5A7963F2F722,
        /// <summary>
        /// eventData:
        /// struct UI_SCRIPT_EVENT
        /// {
        /// 	alignas(8) eUIScriptEventType eventType; // https://alloc8or.re/rdr3/doc/enums/eUIScriptEventType.txt
        /// 	alignas(8) int intParam;
        /// 	alignas(8) Hash hashParam;
        /// 	alignas(8) Hash datastoreParam;
        /// };
        /// 
        /// Old name: _EVENT_MANAGER_GET_EVENT
        ///
        /// > Hash hash
        /// > Any* eventData
        ///
        /// </summary>
        EVENTS_UI_GET_MESSAGE = 0xE24E957294241444,
        /// <summary>
        /// eventData: see EVENTS_UI_GET_MESSAGE
        /// 
        /// Old name: _EVENT_MANAGER_PEEK_EVENT
        ///
        /// > Hash hash
        /// > Any* eventData
        ///
        /// </summary>
        EVENTS_UI_PEEK_MESSAGE = 0x90237103F27F7937,
        /// <summary>
        /// Old name: _EVENT_MANAGER_POP_EVENT
        ///
        /// > Hash hash
        ///
        /// </summary>
        EVENTS_UI_POP_MESSAGE = 0x8E8A2369F48EC839,
    }
    public static class NATIVE_UIEVENTS_EXTENSIONS
    {
        public static void Call(this NATIVE_UIEVENTS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UIEVENTS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}