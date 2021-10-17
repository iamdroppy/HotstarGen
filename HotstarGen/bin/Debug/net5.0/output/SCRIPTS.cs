using System;
namespace Hotstar
{
    public enum NATIVE_SCRIPTS : ulong
    { 
        /// <summary>
        /// Returns if a script has been loaded into the game. Used to see if a script was loaded after requesting.
        ///
        /// > const char* scriptName
        ///
        /// </summary>
        HAS_SCRIPT_LOADED = 0xE97BD36574F8B0A6,
        /// <summary>
        /// Starts a new iteration of the current threads.
        /// Call this first, then SCRIPT_THREAD_ITERATOR_GET_NEXT_THREAD_ID (0x30B4FA1C82DD4B9F)
        ///
        ///
        /// </summary>
        SCRIPT_THREAD_ITERATOR_RESET = 0x39382EB8DCD8684D,
        /// <summary>
        /// If the function returns 0, the end of the iteration has been reached.
        ///
        ///
        /// </summary>
        SCRIPT_THREAD_ITERATOR_GET_NEXT_THREAD_ID = 0x3CE3FB167E837D7C,
        /// <summary>
        /// Gets the number of instances of the specified script is currently running.
        /// 
        /// Actually returns numRefs - 1.
        /// if (program)
        /// 	v3 = rage::scrProgram::GetNumRefs(program) - 1;
        /// return v3;
        ///
        /// > Hash scriptHash
        ///
        /// </summary>
        _GET_NUMBER_OF_REFERENCES_OF_SCRIPT_WITH_NAME_HASH = 0x8E34C953364A76DD,
        /// <summary>
        /// enum eThreadExitReason
        /// {
        /// 	THREAD_EXIT_REASON_NONE,
        /// 	THREAD_EXIT_REASON_BACKGROUND_THREAD_STOPPED,
        /// 	THREAD_EXIT_REASON_SESSION_MERGE,
        /// 	THREAD_EXIT_REASON_SCENARIO_OUT_OF_SCOPE,
        /// 	THREAD_EXIT_REASON_REQUESTED_BY_SCRIPT
        /// };
        ///
        ///
        /// </summary>
        _GET_THREAD_EXIT_REASON = 0x54AE4FDEEFEAB77E,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork), 2 = unk, 3 = unk, 4 = SCRIPT_EVENT_QUEUE_ERRORS (CEventGroupScriptErrors)
        ///
        /// > int eventGroup
        ///
        /// </summary>
        GET_NUMBER_OF_EVENTS = 0x5CE8DE5909565748,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork), 2 = unk, 3 = unk, 4 = SCRIPT_EVENT_QUEUE_SCRIPT_ERRORS (CEventGroupScriptErrors)
        ///
        /// > int eventGroup
        /// > int eventIndex
        ///
        /// </summary>
        GET_EVENT_EXISTS = 0xC9F59C0A710ECD34,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork), 2 = unk, 3 = unk, 4 = SCRIPT_EVENT_QUEUE_SCRIPT_ERRORS (CEventGroupScriptErrors)
        /// 
        /// Returns event name hash: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > int eventGroup
        /// > int eventIndex
        ///
        /// </summary>
        GET_EVENT_AT_INDEX = 0xA85E614430EFF816,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork), 2 = unk, 3 = unk, 4 = SCRIPT_EVENT_QUEUE_SCRIPT_ERRORS (CEventGroupScriptErrors)
        /// 
        /// Note: eventDataSize is NOT the size in bytes, it is the size determined by the SIZE_OF operator (RAGE Script operator, not C/C++ sizeof). That is, the size in bytes divided by 8 (script variables are always 8-byte aligned!).
        ///
        /// > int eventGroup
        /// > int eventIndex
        /// > Any* eventData
        /// > int eventDataSize
        ///
        /// </summary>
        GET_EVENT_DATA = 0x57EC5FA4D4D6AFCA,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork), 2 = unk, 3 = unk, 4 = SCRIPT_EVENT_QUEUE_SCRIPT_ERRORS (CEventGroupScriptErrors)
        /// 
        /// Note: eventDataSize is NOT the size in bytes, it is the size determined by the SIZE_OF operator (RAGE Script operator, not C/C++ sizeof). That is, the size in bytes divided by 8 (script variables are always 8-byte aligned!).
        /// 
        /// playerBits (also known as playersToBroadcastTo) is a bitset that indicates which players this event should be sent to. In order to send the event to specific players only, use (1 << playerIndex). Set all bits if it should be broadcast to all players.
        ///
        /// > int eventGroup
        /// > Any* eventData
        /// > int eventDataSize
        /// > int scriptMetadataIndex
        /// > int* playerBits
        ///
        /// </summary>
        TRIGGER_SCRIPT_EVENT = 0x5AE99C571D5BBE5D,
        /// <summary>
        /// Same as GET_IS_LOADING_SCREEN_ACTIVE
        ///
        ///
        /// </summary>
        IS_LOADING_SCREEN_VISIBLE = 0xB54ADBE65D528FCB,
        /// <summary>
        /// Hashed version of BG_START_CONTEXT
        ///
        /// > Hash contextHash
        ///
        /// </summary>
        BG_START_CONTEXT_HASH = 0x2EB67D564DCC09D5,
        /// <summary>
        /// Hashed version of BG_END_CONTEXT
        ///
        /// > Hash contextHash
        ///
        /// </summary>
        BG_END_CONTEXT_HASH = 0x6D1431744182CDE8,
        /// <summary>
        /// Inserts the given context into the background scripts context map.
        ///
        /// > const char* contextName
        ///
        /// </summary>
        BG_START_CONTEXT = 0x49BA5678BA040CA7,
        /// <summary>
        /// Deletes the given context from the background scripts context map.
        ///
        /// > const char* contextName
        ///
        /// </summary>
        BG_END_CONTEXT = 0x3ABF7BA1C3E2C8CF,
        /// <summary>
        /// Returns "INVALID_NET_RPC_GUID" if netRpcGuid is invalid.
        ///
        /// > Any* netRpcGuid
        ///
        /// </summary>
        _NET_RPC_GUID_TO_STRING = 0xAC9FF854BD4BA9B5,
        /// <summary>
        /// return : script thread id, 0 if failed
        /// Pass pointer to struct of args in p1, size of struct goes into p2
        ///
        /// > const char* scriptName
        /// > Any* args
        /// > int argCount
        /// > int stackSize
        ///
        /// </summary>
        START_NEW_SCRIPT_WITH_ARGS = 0xB8BA7F44DF1575E1,
        /// <summary>
        /// Returns true if GtaThread+0x77C is equal to 1.
        ///
        ///
        /// </summary>
        _0x2238EC3EC631AB1F = 0x2238EC3EC631AB1F,
        /// <summary>
        /// Sets bit 0 in GtaThread+0x784
        ///
        ///
        /// </summary>
        _0x4858148E3B8A75D0 = 0x4858148E3B8A75D0,
        /// <summary>
        /// BG_*
        ///
        /// > int scriptIndex
        /// > const char* p1
        ///
        /// </summary>
        _0x4AE1DFF337A86FDE = 0x4AE1DFF337A86FDE,
        /// <summary>
        /// BG_*
        ///
        /// > int scriptIndex
        /// > const char* p1
        ///
        /// </summary>
        _0x55C40B7592BAD213 = 0x55C40B7592BAD213,
        /// <summary>
        /// BG_*
        ///
        /// > Hash p0
        ///
        /// </summary>
        _0x829CD22E043A2577 = 0x829CD22E043A2577,
        /// <summary>
        /// Hashes: CHAL_CTX_SHOWDOWN, CHAL_CTX_FAKE_DRUNK, CHAL_CTX_FREE_ROAM_EVENT, CHAL_CTX_POSSE_VERSUS, CHAL_CTX_IN_SHOP
        ///
        /// > Hash p0
        ///
        /// </summary>
        _0x7D654266025E921B = 0x7D654266025E921B,
        _SET_PLAYER_BIT_AT_INDEX = 0x31010318BA9897AC,
        _CLEAR_PLAYER_BIT_AT_INDEX = 0xD426E2E3288469D6,
        _SET_ALL_PLAYER_BITS = 0x20F4CB76689ACDBC,
        _CLEAR_ALL_PLAYER_BITS = 0xDE544B7EC0C187CC,
        GET_BLOCK_OF_PLAYER_BITS = 0xFA3B530A5CC693D5,
        SET_BLOCK_OF_PLAYER_BITS = 0xC6DFB8C04C86D5A5,
        COUNT_PLAYER_BITS = 0x462C687BEA254BD9,
        COUNT_PARTICIPANT_BITS = 0x2F050A3FF8738245,
        REQUEST_SCRIPT = 0x46ED607DDD40D7FE,
        SET_SCRIPT_AS_NO_LONGER_NEEDED = 0x0086D3067E1CFD1C,
        DOES_SCRIPT_EXIST = 0x552B171E3F69E5AE,
        REQUEST_SCRIPT_WITH_NAME_HASH = 0xF6B9CE3F8D5B9B74,
        SET_SCRIPT_WITH_NAME_HASH_AS_NO_LONGER_NEEDED = 0x50723A1567C8361E,
        HAS_SCRIPT_WITH_NAME_HASH_LOADED = 0xA5D8E0C2F3C7EEBC,
        DOES_SCRIPT_WITH_NAME_HASH_EXIST = 0xA34E89749F628284,
        TERMINATE_THREAD = 0x87ED52AE40EA1A52,
        IS_THREAD_ACTIVE = 0x46E9AE36D8FA6417,
        DOES_THREAD_EXIST = 0xFF975BC4435A0FA3,
        GET_THREAD_EXISTENCE_DETAILS = 0xD92FA81B64920E85,
        _GET_HASH_OF_THREAD = 0x724CB89D35B283D0,
        _IS_BACKGROUND_SCRIPT = 0x20B7F69B40C6B755,
        GET_ID_OF_THIS_THREAD = 0x55525C346BEF6960,
        TERMINATE_THIS_THREAD = 0x5E8B6D17FF91CD59,
        _REQUEST_THREAD_EXIT = 0x7DE4643157AD646C,
        _REQUEST_THREAD_EXIT_FOR_ALL_THREADS_WITH_THIS_NAME = 0x7423F7835770F619,
        IS_THREAD_EXIT_REQUESTED = 0x9E4EF615E307FBBE,
        _IS_THREAD_EXIT_REQUESTED_FOR_THREAD_WITH_THIS_ID = 0x30BED53646C86D11,
        GET_HASH_OF_THIS_SCRIPT_NAME = 0xBC2C927F5C264960,
        SET_EVENT_FLAG_FOR_DELETION = 0x4768D5252EAEB76F,
        _TRIGGER_SCRIPT_EVENT_2 = 0x8B61C950A148FFA2,
        SHUTDOWN_LOADING_SCREEN = 0xFC179D7E8886DADF,
        SET_NO_LOADING_SCREEN = 0x5CB83156AA038F95,
        GET_NO_LOADING_SCREEN = 0x323DAF00687E0F28,
        _DISPLAY_LOADING_SCREENS = 0x1E5B70E53DB661E5,
        STOP_DISPLAYING_MP_TRANSITION_LOADING_SCREENS = 0x778D4733E0F2F265,
        BAIL_TO_LANDING_PAGE = 0xBC2C927F5C264243,
        BAIL_WITH_PASS_THROUGH_PARAMS = 0xE98204D3C25AE14C,
        _BG_RELOAD_ALL_BACKGROUND_SCRIPTS = 0xBE7D814CFA181B56,
        _STORE_GLOBAL_BLOCK = 0xB952A3AC41D58F2F,
        _RESTORE_GLOBAL_BLOCK = 0xDC3914A99B4A5FDF,
        _DOES_COMPRESSED_GLOBAL_BLOCK_BUFFER_EXIST = 0x66EE5B93C308F734,
        _SET_GLOBAL_BLOCK_CAN_BE_ACCESSED = 0xE66F392BFCE734AF,
        _GET_GLOBAL_BLOCK_CAN_BE_ACCESSED = 0x42A7EB5C814C2DE0,
        _SET_ALL_GLOBAL_BLOCKS_HAVE_BEEN_LOADED = 0x11986B05885564D2,
        START_NEW_SCRIPT = 0xE81651AD79516E48,
        START_NEW_SCRIPT_WITH_NAME_HASH = 0xEB1C67C3A5333A92,
        START_NEW_SCRIPT_WITH_NAME_HASH_AND_ARGS = 0xC4BB298BD441BE78,
        _0xE4ABE20DCE7C7CFE = 0xE4ABE20DCE7C7CFE,
        _0xFFDDF802279BE128 = 0xFFDDF802279BE128,
        _0x64F765D9A1F8F02C = 0x64F765D9A1F8F02C,
        _0x72B2E00C9BAC6789 = 0x72B2E00C9BAC6789,
        _0x179A6F0EE2E79026 = 0x179A6F0EE2E79026,
        _0x1BDB5A07307F6929 = 0x1BDB5A07307F6929,
        _0x1C5EB3C27F7508CB = 0x1C5EB3C27F7508CB,
        _0x42A429CDFED6D99D = 0x42A429CDFED6D99D,
        _0x5827BE85A87B073D = 0x5827BE85A87B073D,
        _0x0A79C81C418F5D38 = 0x0A79C81C418F5D38,
        _0xA88E1D7FA1E20080 = 0xA88E1D7FA1E20080,
        _0xE7282390542F570D = 0xE7282390542F570D,
        _0x11B0A0B282FA9B10 = 0x11B0A0B282FA9B10,
        _0x6F700A4BF7C3331B = 0x6F700A4BF7C3331B,
        _0xF9E951A1E5517C06 = 0xF9E951A1E5517C06,
        _0x76CBCD9EADC00955 = 0x76CBCD9EADC00955,
        _0x29FB4CE89472C3CB = 0x29FB4CE89472C3CB,
        _0x50B72A754EE64A71 = 0x50B72A754EE64A71,
        _0x7409669C5ED50144 = 0x7409669C5ED50144,
        _0xAC8FAB22A914AE34 = 0xAC8FAB22A914AE34,
        _0xB9467E41DAB1CF2C = 0xB9467E41DAB1CF2C,
        _0x4293B44A855F82CC = 0x4293B44A855F82CC,
        _0xF1E9045F5AA9E428 = 0xF1E9045F5AA9E428,
        _0x380FFA15B72408FB = 0x380FFA15B72408FB,
    }
    public static class NATIVE_SCRIPTS_EXTENSIONS
    {
        public static void Call(this NATIVE_SCRIPTS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_SCRIPTS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}