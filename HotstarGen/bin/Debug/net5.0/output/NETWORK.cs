using System;
namespace Hotstar
{
    public enum NATIVE_NETWORK : ulong
    { 
        /// <summary>
        /// Returns whether the signed-in user has valid Rockstar Online Services (ROS) credentials.
        ///
        ///
        /// </summary>
        NETWORK_HAS_VALID_ROS_CREDENTIALS = 0x85443FF4C328F53B,
        /// <summary>
        /// If you are host, returns true else returns false.
        ///
        ///
        /// </summary>
        NETWORK_IS_HOST = 0x8DB296B814EDDA07,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_PROMOTION_ENABLED = 0x8FF6059DA26E688A,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_CUSTOM_UPSELL_ENABLED = 0x78A9535AF83715C6,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_SHOULD_SHOW_PROMOTION_DLG = 0xDA4B1A479C414FB2,
        /// <summary>
        /// Hardcoded to return zero.
        ///
        ///
        /// </summary>
        NETWORK_GET_PROMOTION_DLG_SEEN_COUNT = 0x2FB53C631A49BE92,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > Any* sessionId
        ///
        /// </summary>
        _NETWORK_SESSION_GET_SESSION_ID = 0xE9B356C330C0A806,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > Any* sessionId1
        /// > Any* sessionId2
        ///
        /// </summary>
        _NETWORK_SESSION_ARE_SESSION_IDS_EQUAL = 0x4DEC5000F7B508F0,
        /// <summary>
        /// flags:
        /// enum eSessionRequestOptionFlags
        /// {
        /// 	SESSION_REQUEST_OPTION_FLAG_INCLUDE_GANG_MEMBERS = (1 << 1),
        /// 	SESSION_REQUEST_OPTION_FLAG_LEADER_KEEPS_GANG = (1 << 7),
        /// };
        /// 
        /// seamlessType:
        /// enum eSeamlessType
        /// {
        /// 	SEAMLESS_TYPE_NORMAL,
        /// 	SEAMLESS_TYPE_PVE,
        /// 	SEAMLESS_TYPE_DEV,
        /// 	SEAMLESS_TYPE_NO_SEAMLESS
        /// };
        ///
        /// > int flags
        /// > int seamlessType
        /// > Any* sessionRequestId
        ///
        /// </summary>
        NETWORK_REQUEST_SESSION_SEAMLESS = 0x04019AE4956D4393,
        /// <summary>
        /// Equivalent to NETWORK_REQUEST_SESSION_SEAMLESS if userHash == 0.
        /// Otherwise it is equivalent to NETWORK_SESSION_REQUEST_SESSION_COMPETITIVE(flags, MATCHTYPE_SEAMLESS, userHash, 0, sessionRequestId);
        /// 
        /// p1 is unused
        ///
        /// > int flags
        /// > int p1
        /// > int userHash
        /// > Any* sessionRequestId
        ///
        /// </summary>
        NETWORK_SESSION_REQUEST_SESSION_SEAMLESS = 0x2989E131FDE37E97,
        /// <summary>
        /// matchType:
        /// enum eMatchType
        /// {
        /// 	MATCHTYPE_DEPRECATED,
        /// 	MATCHTYPE_UGCPLAYLIST,
        /// 	MATCHTYPE_UGCMISSION,
        /// 	MATCHTYPE_MINIGAME,
        /// 	MATCHTYPE_SEAMLESS,
        /// 	MATCHTYPE_PRIVATE_DO_NOT_USE
        /// };
        ///
        /// > int flags
        /// > int matchType
        /// > int userHash
        /// > int p3
        /// > Any* sessionRequestId
        ///
        /// </summary>
        NETWORK_SESSION_REQUEST_SESSION_COMPETITIVE = 0x309BBEBEA8A3986C,
        /// <summary>
        /// category:
        /// enum eOnCallType
        /// {
        /// 	NETWORK_SESSION_REQUEST_ON_CALL_TYPE_STORY = 2,
        /// 	NETWORK_SESSION_REQUEST_ON_CALL_TYPE_MATCH = 3
        /// };
        ///
        /// > int flags
        /// > int category
        /// > Any* p2
        /// > int userHash
        /// > Any* sessionRequestId
        ///
        /// </summary>
        _NETWORK_SESSION_REQUEST_SESSION_ON_CALL = 0x23D9C1F2E4098EDC,
        /// <summary>
        /// Returns result of session request:
        /// 0 - NOT_FOUND
        /// 1 - IN_PROGRESS
        /// 2 - TIMEOUT
        /// 3 - PLAYER_OFFLINE
        /// 4 - GANG_MEMBERS_CHANGED
        /// 5 - PLAYER_CANCELLED
        /// 6 - PLAYER_SET_TOO_LARGE
        /// 7 - MATCH_ACCEPTED
        /// 8 - OTHER
        ///
        /// > Any* sessionRequestId
        /// > int* p1
        ///
        /// </summary>
        _NETWORK_SESSION_GET_SESSION_REQUEST_RESULT = 0x0DD051B1BF4B8BD6,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _NETWORK_IS_IN_SESSION_LOBBY = 0xC5196C42DE19F646,
        /// <summary>
        /// enum eSessionFlags
        /// {
        /// 	SESSION_FLAG_NONE = 0,
        /// 	SF_INSTANCE = (1 << 0),
        /// 	SF_MATCH = (1 << 1),
        /// 	SF_PRIVATE = (1 << 2),
        /// 	SF_BLOCK_INVITES = (1 << 3),
        /// 	SF_BLOCK_JOIN_VIA_PRESENCE = (1 << 4),
        /// 	SF_BLOCK_NON_HOST_INVITES = (1 << 5),
        /// 	SF_BLOCK_IN_PROGRESS_MATCHMAKING_BACKFILL = (1 << 6),
        /// 	SF_BLOCK_IN_GAMEPLAY_MATCHMAKING_BACKFILL = (1 << 7),
        /// 	SF_BLOCK_INVITES_TEMPORARY = (1 << 8),
        /// 	SF_IN_GAMEPLAY = (1 << 9),
        /// 	SF_COMPETITIVE = (1 << 10),
        /// 	SF_MATCHMAKING_BACKFILL_IS_BLOCKED = (1 << 11)
        /// };
        ///
        /// > int flags
        ///
        /// </summary>
        _NETWORK_SESSION_ADD_SESSION_FLAGS = 0xE546BDA1B3E288EE,
        /// <summary>
        /// See _NETWORK_SESSION_ADD_SESSION_FLAGS
        ///
        /// > int flags
        ///
        /// </summary>
        NETWORK_SESSION_REMOVE_SESSION_FLAGS = 0x78335E12DB0BF961,
        /// <summary>
        /// Returns value of fwuiCachedSetting "general.onlineNotificationsInStoryMode"
        ///
        ///
        /// </summary>
        _NETWORK_ARE_ONLINE_NOTIFICATIONS_SHOWN_IN_STORY_MODE = 0xF5C5929E07512F80,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_IN_PLATFORM_PARTY = 0x2FC5650B0271CB57,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_IN_PLATFORM_PARTY_CHAT = 0xFD8B834A8BA05048,
        /// <summary>
        /// Seems to always return 0, but it's used in quite a few loops.
        /// 
        /// for (num3 = 0; num3 < NETWORK::0xCCD8C02D(); num3++)
        ///     {
        ///         if (NETWORK::NETWORK_IS_PARTICIPANT_ACTIVE(PLAYER::0x98F3B274(num3)) != 0)
        ///         {
        ///             var num5 = NETWORK::NETWORK_GET_PLAYER_INDEX(PLAYER::0x98F3B274(num3));
        ///
        ///
        /// </summary>
        NETWORK_GET_MAX_NUM_PARTICIPANTS = 0xA6C90FBC38E395EE,
        /// <summary>
        /// Returns the Player associated to a given Ped when in an online session.
        ///
        /// > Ped ped
        ///
        /// </summary>
        NETWORK_GET_PLAYER_INDEX_FROM_PED = 0x6C0E2E0125610278,
        /// <summary>
        /// Returns the amount of players connected in the current session. Only works when connected to a session/server.
        ///
        ///
        /// </summary>
        NETWORK_GET_NUM_CONNECTED_PLAYERS = 0xA4A79DD2D9600654,
        /// <summary>
        /// Return the local Participant ID
        ///
        ///
        /// </summary>
        PARTICIPANT_ID = 0x90986E8876CE0A83,
        /// <summary>
        /// Return the local Participant ID.
        /// 
        /// This native is exactly the same as 'PARTICIPANT_ID' native.
        ///
        ///
        /// </summary>
        PARTICIPANT_ID_TO_INT = 0x57A3BDDAD8E5AA0A,
        /// <summary>
        /// Returns the network ID of the given vehicle.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        VEH_TO_NET = 0xB4C94523F023419C,
        /// <summary>
        /// Returns the network ID of the given ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        PED_TO_NET = 0x0EDEC3C276198689,
        /// <summary>
        /// Returns the network ID of the given object.
        ///
        /// > Object object
        ///
        /// </summary>
        OBJ_TO_NET = 0x99BFDC94A603E541,
        /// <summary>
        /// gets the ped id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_PED = 0xBDCD95FC216A8B3E,
        /// <summary>
        /// gets the object id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_OBJ = 0xD8515F5FEA14CB3F,
        /// <summary>
        /// gets the entity id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_ENT = 0xBFFEAB45A9A9094A,
        /// <summary>
        /// Always returns a null string.
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_GET_GAMERTAG_FROM_HANDLE = 0x426141162EBE5CDB,
        /// <summary>
        /// Hardcoded to return -1.
        ///
        /// > Any* p0
        /// > Any p1
        ///
        /// </summary>
        NETWORK_DISPLAYNAMES_FROM_HANDLES_START = 0xD66C9E72B3CC4982,
        /// <summary>
        /// Hardcoded to return zero.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        NETWORK_GET_DISPLAYNAMES_FROM_HANDLES = 0x58CC181719256197,
        /// <summary>
        /// Example:
        /// 
        /// char displayName[64];
        /// if (_NETWORK_GET_DISPLAY_NAME_FROM_HANDLE(handle, displayName))
        /// {
        /// 	// use displayName
        /// }
        ///
        /// > Any* gamerHandle
        /// > char* displayName
        ///
        /// </summary>
        _NETWORK_GET_DISPLAY_NAME_FROM_HANDLE = 0x7FEE4F07C54B6B3C,
        /// <summary>
        /// Hardcoded to return false.
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_IS_PENDING_FRIEND = 0x0BE73DA6984A6E33,
        /// <summary>
        /// On PC this returns true if gamerHandle is a valid handle.
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        _NETWORK_CAN_ADD_FRIEND = 0x99ABE9BF9DADA162,
        /// <summary>
        /// Old name: _NETWORK_SET_PASSIVE_MODE_OPTION
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        NETWORK_SET_PLAYER_IS_PASSIVE = 0x9C25E8EC4C535FBD,
        /// <summary>
        /// if set to true other network players can't see it
        /// if set to false other network player can see it
        /// =========================================
        /// ^^ I attempted this by grabbing an object with GET_ENTITY_PLAYER_IS_FREE_AIMING_AT and setting this naive no matter the toggle he could still see it.
        /// 
        /// pc or last gen?
        /// 
        /// ^^ last-gen
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _NETWORK_SET_ENTITY_INVISIBLE_TO_NETWORK = 0xF1CA12B18AEF5298,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_OBJECTS = 0xAA81B5F10BC43AC2,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_PEDS = 0x1F13D5AE5CB17E17,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_VEHICLES = 0xCF3A965906452031,
        /// <summary>
        /// Always returns 60
        ///
        ///
        /// </summary>
        GET_MAX_NUM_NETWORK_OBJECTS = 0xC7BE335216B5EC7C,
        /// <summary>
        /// Always returns 110
        ///
        ///
        /// </summary>
        GET_MAX_NUM_NETWORK_PEDS = 0x0C1F7D49C39D2289,
        /// <summary>
        /// Always returns 40
        ///
        ///
        /// </summary>
        GET_MAX_NUM_NETWORK_VEHICLES = 0x0AFCE529F69B21FF,
        /// <summary>
        /// Always returns 80
        ///
        ///
        /// </summary>
        GET_MAX_NUM_NETWORK_PICKUPS = 0xA72835064DD63E4C,
        /// <summary>
        /// Adds the first argument to the second.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        GET_TIME_OFFSET = 0x017008CCDAD48503,
        /// <summary>
        /// Subtracts the second argument from the first, then returns whether the result is negative.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        IS_TIME_LESS_THAN = 0xCB2CF5148012C8D0,
        /// <summary>
        /// Subtracts the first argument from the second, then returns whether the result is negative.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        IS_TIME_MORE_THAN = 0xDE350F8651E4346C,
        /// <summary>
        /// Subtracts the second argument from the first.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        GET_TIME_DIFFERENCE = 0xA2C6FC031D46FFF0,
        /// <summary>
        /// Takes the specified time and writes it to the structure specified in the second argument.
        /// 
        /// struct date_time
        /// {
        ///     int year;
        ///     int PADDING1;
        ///     int month;
        ///     int PADDING2;
        ///     int day;
        ///     int PADDING3;
        ///     int hour;
        ///     int PADDING4;
        ///     int minute;
        ///     int PADDING5;
        ///     int second;
        ///     int PADDING6;
        /// };
        ///
        /// > int posixTime
        /// > Any* timeStructure
        ///
        /// </summary>
        CONVERT_POSIX_TIME = 0xAC97AF97FA68E5D5,
        /// <summary>
        /// Note: scripts seem to indicate that this was renamed to NETWORK_IS_PLAYER_IN_MP_FAST_INSTANCE
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_IS_PLAYER_IN_MP_CUTSCENE = 0x63F9EE203C3619F2,
        /// <summary>
        /// Note: this native was added in build 1311.16
        ///
        ///
        /// </summary>
        _IS_OBJECT_REASSIGNMENT_IN_PROGRESS = 0x8FE9EB11EC9CC23A,
        /// <summary>
        /// Note: this native was added in build 1311.16
        ///
        ///
        /// </summary>
        _GET_NUM_PEER_NEGOTIATION_RESPONSES = 0x4FE932E84FE932E8,
        /// <summary>
        /// Must be called from a background script, otherwise it will do nothing.
        ///
        /// > Any* p0
        ///
        /// </summary>
        _NETWORK_DEBUG_REQUEST_ENTITY_POSITION = 0xFA38B52F91B59075,
        /// <summary>
        /// NETWORK_ARE_*
        ///
        /// > Player player
        /// > int index
        ///
        /// </summary>
        _NETWORK_IS_PLAYER_EQUAL_TO_INDEX = 0x9DE986FC9A87C474,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        NETWORK_REQUEST_CLOUD_TUNABLES = 0x42FB3B532D526E6C,
        /// <summary>
        /// Checks if the user has ROS privilege 14.
        ///
        ///
        /// </summary>
        _UGC_HAS_PRIVILEGE = 0x6506BFA755FB209C,
        /// <summary>
        /// 0 = succeeded
        /// 1 = pending
        /// 2 = failed
        ///
        /// > int textureDownloadId
        ///
        /// </summary>
        GET_STATUS_OF_TEXTURE_DOWNLOAD = 0x8BD6C6DEA20E82C6,
        /// <summary>
        /// Always returns -1. Seems to be XB1 specific.
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK = 0xDEB2B99A1AF1A2A6,
        /// <summary>
        /// Same as _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER (0xD414BE129BB81B32)
        ///
        /// > Player player
        ///
        /// </summary>
        _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER_2 = 0x0E3A041ED6AC2B45,
        /// <summary>
        /// Returns true if the passed value is less than 32.
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_IS_PLAYER_INDEX_VALID = 0x255A5EF65EDA9167,
        /// <summary>
        /// Returns CGameConfig->ConfigOnlineServices->RosTitleName (see gameconfig.xml)
        ///
        ///
        /// </summary>
        _NETWORK_GET_ROS_TITLE_NAME = 0xAC6153A0722F524C,
        /// <summary>
        /// Hardcoded to return zero.
        /// 
        /// ==== PS4 specific info ====
        /// 
        /// Returns some sort of unavailable reason:
        /// -1 = REASON_INVALID
        ///  0 = REASON_OTHER
        ///  1 = REASON_SYSTEM_UPDATE
        ///  2 = REASON_GAME_UPDATE
        ///  3 = REASON_SIGNED_OUT
        ///  4 = REASON_AGE
        ///  5 = REASON_CONNECTION
        /// 
        /// =================================
        ///
        ///
        /// </summary>
        _0x74FB3E29E6D10FA9 = 0x74FB3E29E6D10FA9,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xFC6FCF4C03F1BBF6 = 0xFC6FCF4C03F1BBF6,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x160F0CE6D76A39C9 = 0x160F0CE6D76A39C9,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0x316FD416C432C761 = 0x316FD416C432C761,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0x062842D61D0D53FD = 0x062842D61D0D53FD,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x0CC28C08613BA9E5 = 0x0CC28C08613BA9E5,
        /// <summary>
        /// Returns the entity's network ID.
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0xF302AB9D978352EE = 0xF302AB9D978352EE,
        /// <summary>
        /// Returns the entity associated with the given network ID.
        ///
        /// > int networkId
        ///
        /// </summary>
        _0x4538EE7C321590BC = 0x4538EE7C321590BC,
        /// <summary>
        /// Params: p5 = 50.f, p6 = 0 in R* scripts
        ///
        /// > Any* p0
        /// > Any* p1
        /// > float x
        /// > float y
        /// > float z
        /// > float p5
        /// > Any p6
        ///
        /// </summary>
        _0x880A7202301E282B = 0x880A7202301E282B,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xC964FCD3D1720697 = 0xC964FCD3D1720697,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xEC089F84A9C16C62 = 0xEC089F84A9C16C62,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        /// > int p1
        /// > int p2
        /// > int p3
        ///
        /// </summary>
        _0x5F328FC909F0E0FF = 0x5F328FC909F0E0FF,
        /// <summary>
        /// Must be called from a background script, otherwise it will do nothing.
        ///
        /// > Entity entity
        /// > BOOL p1
        ///
        /// </summary>
        _0x979765465A6F25FC = 0x979765465A6F25FC,
        /// <summary>
        /// Hardcoded to return zero.
        ///
        ///
        /// </summary>
        _0x5133CF81924F1129 = 0x5133CF81924F1129,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x1E4E097D71D449FB = 0x1E4E097D71D449FB,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x982D7AD755B8F62C = 0x982D7AD755B8F62C,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x917AD74BDCF8B6E9 = 0x917AD74BDCF8B6E9,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0xF8DC69DC1AD19072 = 0xF8DC69DC1AD19072,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x744BFBB0CA908161 = 0x744BFBB0CA908161,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x106CBDD5077DEDE1 = 0x106CBDD5077DEDE1,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0xBAF7E2979442B29F = 0xBAF7E2979442B29F,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x039B692B3318FAB6 = 0x039B692B3318FAB6,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x4835413EA6F9C9CD = 0x4835413EA6F9C9CD,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0x039AD6B57D5179FF = 0x039AD6B57D5179FF,
        /// <summary>
        /// Note: this native was added in build 1311.16
        /// 
        /// GET_NUM_*
        ///
        ///
        /// </summary>
        _0x02B3CDD652B3CDD6 = 0x02B3CDD652B3CDD6,
        /// <summary>
        /// Note: this native was added in build 1355.30
        ///
        ///
        /// </summary>
        _0x40FEDB13870042F1 = 0x40FEDB13870042F1,
        /// <summary>
        /// Note: this native was added in build 1355.30
        ///
        /// > int p0
        ///
        /// </summary>
        _0x422F9D6D6C7BC290 = 0x422F9D6D6C7BC290,
        /// <summary>
        /// Returns false if pedshot push failed
        ///
        /// > Any* p0
        /// > Any slot
        /// > Any p2
        ///
        /// </summary>
        _0xB72999D3120599DF = 0xB72999D3120599DF,
        /// <summary>
        /// Returns false if pedshot push failed
        ///
        /// > Any* p0
        /// > Any cachingSlot
        /// > Any p2
        /// > Any type
        ///
        /// </summary>
        _0x2A48D9567940598F = 0x2A48D9567940598F,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0xFD8112109A96877C = 0xFD8112109A96877C,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0xFB3205788F8AFA3F = 0xFB3205788F8AFA3F,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        ///
        /// </summary>
        _0x335AF56613CA0F49 = 0x335AF56613CA0F49,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        ///
        /// </summary>
        _0x9E5A47744C0F0376 = 0x9E5A47744C0F0376,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        ///
        /// </summary>
        _0xD3B6EBC6C3D77D44 = 0xD3B6EBC6C3D77D44,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        ///
        /// </summary>
        _0xA7670F7991099680 = 0xA7670F7991099680,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        ///
        /// </summary>
        _0x7673C0D2C5CDAC55 = 0x7673C0D2C5CDAC55,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        /// > int p1
        /// > float p2
        ///
        /// </summary>
        _0x3CBD6565D9C3B133 = 0x3CBD6565D9C3B133,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        /// > int p1
        ///
        /// </summary>
        _0x0D183D8490EE4366 = 0x0D183D8490EE4366,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > int p0
        ///
        /// </summary>
        _0xC1968045EEB563B7 = 0xC1968045EEB563B7,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Player player
        ///
        /// </summary>
        _0x6BFF5F84102DF80A = 0x6BFF5F84102DF80A,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x5C497525F803486B = 0x5C497525F803486B,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xAEDF1BC1C133D6E3 = 0xAEDF1BC1C133D6E3,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x6FD992C4A1C1B986 = 0x6FD992C4A1C1B986,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x2CD41AC000E6F611 = 0x2CD41AC000E6F611,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xACC44768AF229042 = 0xACC44768AF229042,
        /// <summary>
        /// Note: this native was added in build 1311.23
        ///
        /// > Hash ctx
        /// > int ec
        /// > BOOL ex
        /// > BOOL ro
        ///
        /// </summary>
        _0x19447FCAE97704DC = 0x19447FCAE97704DC,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x2C4E98DDA475364F = 0x2C4E98DDA475364F,
        NETWORK_IS_SIGNED_ONLINE = 0x1077788E268557C2,
        NETWORK_IS_CLOUD_AVAILABLE = 0x9A4CF4F48AD77302,
        NETWORK_HAS_SOCIAL_CLUB_ACCOUNT = 0x67A5589628E0CFF6,
        NETWORK_HAVE_ONLINE_PRIVILEGES = 0x25CB5A9F37BFD063,
        NETWORK_CHECK_USER_CONTENT_PRIVILEGES = 0x595F028698072DD9,
        NETWORK_CHECK_COMMUNICATION_PRIVILEGES = 0x83F28CE49FBBFFBA,
        NETWORK_CAN_VIEW_GAMER_USER_CONTENT = 0x246545C37C27A717,
        NETWORK_CAN_ACCESS_MULTIPLAYER = 0xAF50DA1A3F8B1BA4,
        NETWORK_CHECK_ACCESS_AND_ALERT_IF_FAIL = 0x2A8112A974DE1EF6,
        _NETWORK_GET_GLOBAL_ENTITY_FLAGS = 0xDD7806FD0543BC3D,
        _NETWORK_HAS_COMPLETED_MP_INTRO_FLOW_ON_CURRENT_SLOT = 0xDD73C9838CE7181D,
        NETWORK_SET_COMPLETED_MP_INTRO_FLOW_ON_CURRENT_SLOT = 0x2C5BD9A43987AA27,
        NETWORK_SET_MP_MISSION_FLAG_ON_CURRENT_SLOT = 0x86FD10251A7118A4,
        NETWORK_SESSION_IS_PRIVATE = 0xCEF70AA5B3F89BA1,
        NETWORK_SESSION_REQUEST_SESSION_PRIVATE = 0x39A8EF7AF29A192C,
        _NETWORK_SESSION_REQUEST_SESSION_NOMINATED = 0x4F4672457FF597D1,
        NETWORK_SESSION_IS_SESSION_REQUEST_ID_VALID = 0x2F54B146D3EDCE4D,
        NETWORK_SESSION_GET_SESSION_TYPE = 0xF0C0C94B404206FA,
        NETWORK_SESSION_IS_ANY_REQUEST_IN_PROGRESS = 0xBAFFDE5F953720D9,
        NETWORK_SESSION_IS_REQUEST_IN_PROGRESS = 0x8FB7C254CFCBF78E,
        _NETWORK_SESSION_IS_REQUEST_IN_PROGRESS_BY_QUEUE_GROUP = 0x9E762A595CF88E4A,
        _NETWORK_SESSION_CANCEL_REQUEST = 0xE72E5C1289BD1F40,
        NETWORK_SESSION_IS_REQUEST_PENDING_TRANSITION = 0xCCF878D50F8AB10D,
        _NETWORK_SESSION_TRANSITION_TO_SESSION = 0xF20B18A330E6DB5C,
        NETWORK_SESSION_LEFT_QUEUE_OR_REQUESTED_SESSION = 0xECE6A0C1B59CD8BE,
        NETWORK_SESSION_LEAVE_SESSION = 0x17C21B7319A05047,
        NETWORK_SESSION_IS_TRANSITIONING = 0xF2CBC969C4F090C7,
        _NETWORK_SESSION_PLAYLIST_GO_TO_NEXT_CONTENT = 0xBDE605F925B07127,
        _NETWORK_SESSION_PLAYLIST_GET_UPCOMING_CONTENT = 0x8F9DB6CD03B42B58,
        NETWORK_DISABLE_REALTIME_MULTIPLAYER = 0x236905C700FDB54D,
        NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK = 0x6D03BFBD643B2A02,
        NETWORK_CLEAR_CLOCK_TIME_OVERRIDE = 0xD972DF67326F966E,
        NETWORK_IS_CLOCK_TIME_OVERRIDDEN = 0xD7C95D322FF57522,
        NETWORK_GET_GLOBAL_CLOCK = 0x11A7ADCD629E170F,
        _NETWORK_CLOCK_TIME_OVERRIDE = 0x669E223E64B1903C,
        _NETWORK_CLOCK_TIME_OVERRIDE_2 = 0xE28C13ECC36FF14E,
        NETWORK_IS_FINDING_GAMERS = 0xDDDF64C91BFCF0AA,
        NETWORK_DID_FIND_GAMERS_SUCCEED = 0xF9B83B77929D8863,
        NETWORK_CLEAR_FOUND_GAMERS = 0x6D14CCEE1B40381A,
        _NETWORK_GET_GAMER_SESSION_FROM_HANDLE = 0xFBDFE1C1356E12E8,
        NETWORK_DID_GET_GAMER_STATUS_SUCCEED = 0x5AE17C6B0134B7F1,
        NETWORK_CLEAR_GET_GAMER_STATUS = 0x86E0660E4F5C956D,
        NETWORK_SET_SCRIPT_READY_FOR_EVENTS = 0x7AC752103856FB20,
        NETWORK_IS_GAME_IN_PROGRESS = 0x10FAB35428CCC9D7,
        NETWORK_IS_SESSION_ACTIVE = 0xD83C2B94E7508980,
        NETWORK_IS_IN_SESSION = 0xCA97246103B63917,
        NETWORK_IS_SESSION_STARTED = 0x9DE624D2FC4B603F,
        NETWORK_CAN_SESSION_END = 0x4EEBC3694E49C572,
        NETWORK_SESSION_GET_SESSION_FLAGS = 0x51F33DBC1A41CBFD,
        _NETWORK_SESSION_SET_PLAYER_FLAGS = 0x0AE241A4A9ADEEEC,
        _NETWORK_SESSION_REMOVE_PLAYER_FLAGS = 0x3215BBE34D3418C5,
        _NETWORK_GET_SESSION_HOST = 0x8DC9AA3B508B1A85,
        NETWORK_HAS_PENDING_INVITE_FAILURE = 0xD0498AD30E16B6BD,
        _NETWORK_SEND_SESSION_INVITE = 0xE47001B7CB8B98AE,
        NETWORK_ACCEPT_RS_INVITE = 0xB2CEA5105AAC8DDE,
        NETWORK_REQUEST_JOIN = 0xE483BB6BE686F632,
        NETWORK_IS_PLATFORM_INVITE_PENDING = 0xFC4165C9165C166F,
        _NETWORK_GET_PLATFORM_INVITE_ID = 0x9BCF28FB5D65A9BE,
        NETWORK_ACTION_PLATFORM_INVITE = 0x3B82ACC3F4B6240C,
        NETWORK_CLEAR_PLATFORM_INVITE = 0xA4484173759749B1,
        NETWORK_SEED_RANDOM_NUMBER_GENERATOR = 0xF1B84178F8674195,
        NETWORK_GET_RANDOM_INT_RANGED = 0xE30CF56F1EFA5F43,
        NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0x1CA59E306ECB80A5,
        NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0x2910669969E9535E,
        NETWORK_GET_NUM_PARTICIPANTS = 0x18D0456E86604654,
        NETWORK_GET_SCRIPT_STATUS = 0x57D158647A6BFABF,
        NETWORK_REGISTER_HOST_BROADCAST_VARIABLES = 0x3E9B2F01C50DF595,
        _NETWORK_GET_SIZE_OF_HOST_BROADCAST_DATA_STORAGE = 0xBA24095EA96DFE17,
        NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES = 0x3364AA97340CA215,
        _NETWORK_GET_SIZE_OF_PLAYER_BROADCAST_DATA_STORAGE = 0x690806BC83BC8CA2,
        NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA = 0x5D10B3795F3FC886,
        NETWORK_GET_PLAYER_INDEX = 0x24FB80D107371267,
        NETWORK_GET_PARTICIPANT_INDEX = 0x1B84DF6AF2A46938,
        NETWORK_IS_PLAYER_CONNECTED = 0x93DC1BE4E1ABE9D1,
        NETWORK_GET_TOTAL_NUM_PLAYERS = 0xCF61D4B4702EE9EB,
        NETWORK_IS_PARTICIPANT_ACTIVE = 0x6FF8FF40B6357D45,
        NETWORK_IS_PLAYER_ACTIVE = 0xB8DFD30D6973E135,
        NETWORK_IS_PLAYER_A_PARTICIPANT = 0x3CA58F6CB7CBD784,
        NETWORK_IS_HOST_OF_THIS_SCRIPT = 0x83CD99A1E6061AB5,
        NETWORK_GET_HOST_OF_THIS_SCRIPT = 0xC7B4D79B01FA7A5C,
        NETWORK_GET_HOST_OF_SCRIPT = 0x1D6A14F1F9A736FC,
        _NETWORK_GET_HOST_OF_THREAD = 0xB4A25351D79B444C,
        NETWORK_SET_MISSION_FINISHED = 0x3B3D11CD9FFCDFC9,
        NETWORK_IS_SCRIPT_ACTIVE = 0x9D40DF90FAD26098,
        NETWORK_IS_SCRIPT_ACTIVE_BY_HASH = 0x1B89BC43B6E69107,
        NETWORK_GET_NUM_SCRIPT_PARTICIPANTS = 0x3658E8CD94FC121A,
        NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT = 0x638A3A81733086DB,
        NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT = 0x1AD5B71586B94820,
        NETWORK_IS_FEATURE_SUPPORTED = 0x9C725D149622BFDE,
        NETWORK_GET_DESTROYER_OF_NETWORK_ID = 0x7A1ADEEF01740A24,
        _NETWORK_GET_DESTROYER_OF_ENTITY = 0x4CACA84440FA26F6,
        NETWORK_GET_ENTITY_KILLER_OF_PLAYER = 0x42B2DAA6B596F5F8,
        NETWORK_RESURRECT_LOCAL_PLAYER = 0xEA23C49EAA83ACFB,
        _NETWORK_RESURRECT_LOCAL_PLAYER_2 = 0x4154B7D8C75E5DCF,
        NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME = 0x2D95C7E2D7E07307,
        NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT = 0x524FF0AEFF9C3973,
        NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD = 0xB07D3185E11657A5,
        NETWORK_GET_NETWORK_ID_FROM_ENTITY = 0xA11700682F3AD45C,
        NETWORK_GET_ENTITY_FROM_NETWORK_ID = 0xCE4E5D9B0A4FF560,
        NETWORK_GET_ENTITY_IS_NETWORKED = 0xC7827959479DCC78,
        NETWORK_REGISTER_ENTITY_AS_NETWORKED = 0x06FAACD625D80CAA,
        NETWORK_DOES_NETWORK_ID_EXIST = 0x38CE16C96BD11344,
        NETWORK_REQUEST_CONTROL_OF_NETWORK_ID = 0xA670B3662FAFFBD0,
        NETWORK_HAS_CONTROL_OF_NETWORK_ID = 0x4D36070FE0215186,
        NETWORK_REQUEST_CONTROL_OF_ENTITY = 0xB69317BF5E782347,
        _NETWORK_REQUEST_CONTROL_OF_ANIM_SCENE = 0xAAA92B631B13F614,
        NETWORK_REQUEST_CONTROL_OF_PICKUP_PLACEMENT = 0x56ED2C48558DAB78,
        NETWORK_HAS_CONTROL_OF_ENTITY = 0x01BF60A500E28887,
        NETWORK_HAS_CONTROL_OF_PICKUP = 0x5BC9495F0B3B6FA6,
        _NETWORK_HAS_CONTROL_OF_ANIM_SCENE = 0x26A5C12FACFF8724,
        NETWORK_HAS_CONTROL_OF_PICKUP_PLACEMENT = 0x51EABCF2786515AB,
        _ANIM_SCENE_TO_NET = 0xE0D73CDDEA79DDCD,
        NET_TO_VEH = 0x367B936610BA360C,
        _NET_TO_ANIM_SCENE = 0xD7F6781A0ABAF6FB,
        _PROPSET_TO_NET = 0x74F99EF7EF503398,
        _NET_TO_PROPSET = 0xD08066E00D26C448,
        NETWORK_GET_LOCAL_HANDLE = 0xE86051786B66CD8E,
        NETWORK_HANDLE_FROM_PLAYER = 0x388EB2B86C73B6B3,
        NETWORK_HASH_FROM_PLAYER_HANDLE = 0xBC1D768F2F5D6C05,
        NETWORK_HANDLE_FROM_FRIEND = 0xD45CB817D7E177D2,
        NETWORK_ARE_HANDLES_THE_SAME = 0x57DBA049E110F217,
        NETWORK_IS_HANDLE_VALID = 0x6F79B93B0A8E4133,
        NETWORK_GET_PLAYER_FROM_GAMER_HANDLE = 0xCE5F689CF5A0A49D,
        NETWORK_IS_GAMER_IN_MY_SESSION = 0x0F10B05DDF8D16E9,
        NETWORK_SHOW_PROFILE_UI = 0x859ED1CEA343FCA8,
        NETWORK_GET_TOTAL_NUM_FRIENDS = 0xDB7ABDD203FA3704,
        NETWORK_CAN_REFRESH_FRIEND_PAGE = 0x1AF5E28E64A76A9F,
        NETWORK_REFRESH_CURRENT_FRIEND_PAGE = 0x1F51F367B710A832,
        _NETWORK_GET_GAMERTAG_FROM_FRIEND = 0x5659D87BE674AB17,
        NETWORK_IS_FRIEND = 0x1A24A179F9B31654,
        NETWORK_ADD_FRIEND = 0x8E02D73914064223,
        _NETWORK_REMOVE_FRIEND = 0x55F618F68AB854D3,
        NETWORK_SET_FRIENDLY_FIRE_OPTION = 0xF808475FA571D823,
        NETWORK_SET_RICH_PRESENCE = 0x1DCCACDCFC569362,
        NETWORK_GET_TIMEOUT_TIME = 0x5ED0356A0CE3A34F,
        PREVENT_NETWORK_ID_MIGRATION = 0x7182EDDA1EE7DB5A,
        KEEP_NETWORK_ID_IN_FAST_INSTANCE = 0xE1BC73D6815BA361,
        SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES = 0xE05E81A888FA63C8,
        SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER = 0xA8A024587329F36A,
        SET_NETWORK_ID_VISIBLE_IN_CUTSCENE = 0xA6928482543022B4,
        IS_NETWORK_ID_OWNED_BY_PARTICIPANT = 0xA1607996431332DF,
        _NETWORK_GET_PLAYER_OWNER_OF_NETWORK_ID = 0xA6C0787443C9583E,
        SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE = 0xD1065D68947E7B6E,
        PREVENT_MIGRATION_OF_ENTITIES_IN_FAST_INSTANCE_FOR_LOCAL_PLAYER = 0x89D803CD48622150,
        SET_LOCAL_PLAYER_INVISIBLE_LOCALLY = 0xE5F773C1A1D9D168,
        SET_PLAYER_INVISIBLE_LOCALLY = 0x12B37D54667DB0B8,
        SET_PLAYER_VISIBLE_LOCALLY = 0xFAA10F1FAFB11AF2,
        SET_ENTITY_VISIBLE_IN_CUTSCENE = 0xE0031D3C8F36AB82,
        IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID = 0x6E192E33AD436366,
        ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID = 0xD45B1FFCCD52FF19,
        IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE = 0xD82CF8E64C8729D8,
        IS_SPHERE_VISIBLE_TO_PLAYER = 0xDC3A310219E5DA62,
        RESERVE_NETWORK_MISSION_OBJECTS = 0x4E5C93BD0C32FBF8,
        RESERVE_NETWORK_CLIENT_MISSION_OBJECTS = 0xE7DDA8BD3BCF751C,
        RESERVE_NETWORK_MISSION_PEDS = 0xB60FEBA45333D36F,
        RESERVE_NETWORK_CLIENT_MISSION_PEDS = 0x807E119F80231732,
        RESERVE_NETWORK_MISSION_VEHICLES = 0x76B02E21ED27A469,
        RESERVE_NETWORK_MISSION_PICKUPS = 0x4D40E7D749BC6E6D,
        CAN_REGISTER_MISSION_OBJECTS = 0x800DD4721A8B008B,
        CAN_REGISTER_MISSION_PEDS = 0xBCBF4FEF9FA5D781,
        CAN_REGISTER_MISSION_VEHICLES = 0x7277F1F2E085EE74,
        CAN_REGISTER_MISSION_PICKUPS = 0xF0460C7BF80011EA,
        CAN_REGISTER_MISSION_ENTITIES = 0x69778E7564BADE6D,
        _GET_NUM_RESERVED_MISSION_PICKUPS = 0x62BE3ECC79FBD004,
        GET_NUM_CREATED_MISSION_OBJECTS = 0x12B6281B6C6706C0,
        GET_NUM_CREATED_MISSION_PEDS = 0xCB215C4B56A7FAE7,
        GET_NUM_CREATED_MISSION_VEHICLES = 0x0CD9AB83489430EA,
        _GET_NUM_CREATED_MISSION_PICKUPS = 0xD2BA051B94CA9BCC,
        GET_NETWORK_TIME = 0x7A5487FE9FAA6B48,
        GET_NETWORK_TIME_ACCURATE = 0x89023FBBF9200E9F,
        HAS_NETWORK_TIME_STARTED = 0x46718ACEEDEAFC84,
        GET_CLOUD_TIME_AS_INT = 0x9A73240B49945C76,
        NETWORK_SET_IN_SPECTATOR_MODE = 0x423DE3854BB50894,
        _NETWORK_SET_IN_STATIC_SPECTATOR_MODE = 0xFBF1ECFB39A77B5F,
        NETWORK_IS_IN_SPECTATOR_MODE = 0x048746E388762E11,
        _NETWORK_IS_PLAYER_IN_SPECTATOR_MODE = 0x5B709519997ECF0F,
        NETWORK_SET_IN_MP_CUTSCENE = 0x9CA5DE655269FEC4,
        NETWORK_IS_IN_MP_CUTSCENE = 0x6CC27C9FA2040220,
        _SET_NETWORK_RESPOT_TIMER = 0x442B4347B6EC36E8,
        _SET_LOCAL_PLAYER_AS_GHOST = 0x5FFE9B4144F9712F,
        _IS_ENTITY_GHOSTED_TO_LOCAL_PLAYER = 0x21D04D7BC538C146,
        _SET_ENTITY_GHOSTED_TO_LOCAL_PLAYER = 0xEE5AE9956743BA20,
        _NETWORK_GET_NETWORK_ID_FROM_ROPE = 0x42871327315EDAE8,
        _NETWORK_GET_ROPE_FROM_NETWORK_ID = 0xEB1A4DD8352EC828,
        _NETWORK_SPAWN_CONFIG_ADD_EXCLUSION_VOLUME = 0xEEB7818B1D307212,
        NETWORK_SPAWN_CONFIG_SET_FLAGS = 0xF94A0D5B254375DF,
        NETWORK_SPAWN_CONFIG_SET_GROUND_TO_ROOT_OFFSET = 0x59577799F6AE2F34,
        NETWORK_SPAWN_CONFIG_SET_TUNING_FLOAT = 0x0608326F7B98C08D,
        NETWORK_START_SOLO_TUTORIAL_SESSION = 0x17E0198B3882C2CB,
        NETWORK_END_TUTORIAL_SESSION = 0xD0AFAFF5A51D72F7,
        NETWORK_IS_IN_TUTORIAL_SESSION = 0xADA24309FE08DACF,
        NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING = 0x35F0B98A8387274D,
        NETWORK_ALLOW_ALL_ENTITY_FADING_FOR_INSTANCES = 0x4B05B97BA46F419D,
        NETWORK_ALLOW_ENTITY_FADING_FOR_INSTANCES = 0xF3354D6CA46F419D,
        NETWORK_SET_LOCAL_PLAYER_PENDING_FAST_INSTANCE_ID = 0x007FF852DCF49DA4,
        _NETWORK_GET_PLAYER_FAST_INSTANCE_ID = 0xD9267375834C5EAB,
        NETWORK_CONCEAL_PLAYER = 0xBBDF066252829606,
        NETWORK_IS_PLAYER_CONCEALED = 0x919B3C98ED8292F9,
        NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING = 0x0467C11ED88B7D28,
        NETWORK_GET_TUNABLE_CLOUD_CRC = 0x10BD227A753B0D84,
        NETWORK_DOES_TUNABLE_EXIST = 0x85E5F8B9B898B20A,
        NETWORK_ACCESS_TUNABLE_INT = 0x8BE1146DFD5D4468,
        NETWORK_ACCESS_TUNABLE_BOOL = 0xAA6A47A573ABB75A,
        _NETWORK_TRY_ACCESS_TUNABLE_INT = 0xA25E006B36719774,
        _NETWORK_TRY_ACCESS_TUNABLE_FLOAT = 0xA18393089C05E49C,
        _NETWORK_TRY_ACCESS_TUNABLE_BOOL = 0xB2AD5D29A99D4B26,
        NETWORK_DISABLE_PROXIMITY_MIGRATION = 0x407091CF6037118E,
        CLOUD_HAS_REQUEST_COMPLETED = 0x4C61B39930D045DA,
        CLOUD_DID_REQUEST_SUCCEED = 0x3A3D5568AF297CD5,
        _GET_LAUNCH_PARAM_EXISTS = 0x02E97CE283648CD9,
        _GET_LAUNCH_PARAM_VALUE = 0x65E65CA6A0FE59D4,
        _SET_LAUNCH_PARAM_VALUE = 0x668AF6E4933AC13F,
        _CLEAR_LAUNCH_PARAM = 0x782C94DB6469634D,
        _GET_LAUNCH_PARAM_STRING = 0xC59AB6A04333C502,
        _SET_LAUNCH_PARAM_STRING = 0xDFFC15AA63D04AAB,
        _CLEAR_LAUNCH_PARAMS = 0x966DD84FB6A46017,
        UGC_IS_REQUEST_PENDING = 0xF4AC4FA844FD559A,
        UGC_HAS_REQUEST_FINISHED = 0xA9EB4D606076615D,
        UGC_DID_REQUEST_SUCCEED = 0x0B6009A90B8495F1,
        _UGC_QUERY_BY_CONTENT_ID = 0x69D22E183580113F,
        UGC_CLEAR_QUERY_RESULTS = 0xE931354FEA710038,
        UGC_QUERY_WAS_FORCE_CANCELLED = 0xF8F0705E77A0E705,
        UGC_QUERY_GET_CONTENT_NUM = 0x76160E0396142765,
        UGC_QUERY_GET_CONTENT_HAS_PLAYER_RECORD = 0xF794765390A6DCA5,
        UGC_REQUEST_CONTENT_DATA_FROM_PARAMS = 0x7FD2990AF016795E,
        UGC_REQUEST_CACHED_DESCRIPTION = 0x5E0165278F6339EE,
        UGC_GET_CACHED_DESCRIPTION = 0x40F7E66472DF3E5C,
        UGC_SET_QUERY_DATA_FROM_OFFLINE = 0xF98DDE0A8ED09323,
        UGC_IS_LANGUAGE_SUPPORTED = 0xF53E48461B71EECB,
        TEXTURE_DOWNLOAD_REQUEST = 0x16160DA74A8E74A2,
        _MUGSHOT_TEXTURE_DOWNLOAD_REQUEST = 0x9B5DB6CEAFAA10BB,
        UGC_TEXTURE_DOWNLOAD_REQUEST = 0x308F96458B7087CC,
        _LOCAL_PLAYER_PEDSHOT_TEXTURE_DOWNLOAD_REQUEST = 0x6E2FD8CF7EB10E53,
        TEXTURE_DOWNLOAD_RELEASE = 0x487EB90B98E9FB19,
        _TEXTURE_DOWNLOAD_RELEASE_BY_NAME = 0x7A17B7981560FFA5,
        TEXTURE_DOWNLOAD_GET_NAME = 0x3448505B6E35262D,
        NETWORK_HAVE_ROS_BANNED_PRIV = 0x8020A73847E0CA7D,
        NETWORK_HAS_ROS_PRIVILEGE = 0xA699957E60D80214,
        _NETWORK_AUTO_SESSION_SET_ALLOWED_TO_SPLIT = 0x0A428058079EE65C,
        NETWORK_AUTO_SESSION_IS_ALLOWED_TO_MERGE = 0xAADED99A6B268A27,
        _NETWORK_AUTO_SESSION_SET_ALLOWED_TO_MERGE = 0x63246A24F5747510,
        NETWORK_AUTO_SESSION_CAN_SPLIT_SESSION = 0xE404BFF0ABA23CDC,
        NETWORK_AUTO_SESSION_SPLIT_SESSION = 0xC223D299C670413D,
        NETWORK_AUTO_SESSION_FINISH_INSTANCE = 0xBB51299166B844F3,
        NETWORK_AUTO_SESSION_IS_OBJECT_CREATION_PAUSED = 0x0E2C3AEE6CE603B7,
        NETWORK_IS_RESETTING_POPULATION = 0x1BB50CD340A996E6,
        NETWORK_RESET_POPULATION = 0x101F538C25ABB39A,
        NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND = 0xC505036A35AFD01B,
        _NETWORK_ALLOW_LOCAL_ENTITY_ATTACHMENT = 0x267C78C60E806B9A,
        _NETWORK_IS_CONNECTION_ENDPOINT_RELAY_SERVER = 0x16D3D49902F697BB,
        _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER = 0xD414BE129BB81B32,
        _NETWORK_GET_AVERAGE_PACKET_LOSS_FOR_PLAYER = 0x350C23949E43686C,
        _NETWORK_GET_NUM_UNACKED_FOR_PLAYER = 0xFF8FCF9FFC458A1C,
        _NETWORK_GET_UNRELIABLE_RESEND_COUNT_FOR_PLAYER = 0x3765C3A3E8192E10,
        _NETWORK_GET_OLDEST_RESEND_COUNT_FOR_PLAYER = 0x52C1EADAF7B10302,
        _SET_LOCAL_PLAYER_DAMAGE_MULTIPLIER_FOR_PLAYER = 0xD041A32992A55F84,
        _NETWORK_SET_VEHICLE_WHEELS_DESTRUCTIBLE = 0x0C8BC052AE87D744,
        GET_UNIQUE_INT_FOR_PLAYER = 0x07F723401B9D921C,
        NETWORK_IS_AIM_CAM_ACTIVE = 0x8E7CE19219669AEB,
        _NETWORK_ALERT = 0x1BAA028F52EED310,
        _SET_SOCIAL_MATCHMAKING_ALLOWED = 0x777D0571A466B520,
        _GET_SOCIAL_MATCHMAKING_ALLOWED = 0xD0541EF28E9C4783,
        NETWORK_AWARD_HAS_REACHED_MAXCLAIM = 0xFBE782B3165AC8EC,
        _NETWORK_GET_XP = 0xDB438CC9BC6F4022,
        _NETWORK_GET_RANK = 0x32C90CDFAF40514C,
        NETWORK_SET_RECENT_GAMERS_ENABLED = 0x29FE035D35B8589C,
        _NETWORK_ADD_PLAYER_TO_RECENT_GAMERS_LIST = 0x157D8F3DE12B307F,
        NETWORK_REQUEST_RECENT_GAMER_NAMES = 0x6D206D383BB5F6B1,
        _NETWORK_IS_RECENT_GAMER_NAMES_REQUEST_IN_PROGRESS = 0x4664D213A0CCAF40,
        _NETWORK_DID_RECENT_GAMER_NAMES_REQUEST_SUCCEED = 0x12AEB56B489415C5,
        _NETWORK_GET_NUM_RECENT_GAMERS = 0x37A834AEC6A4F74A,
        NETWORK_GET_RECENT_GAMER_NAMES = 0xFEFCC345CE357453,
        NETWORK_ACTIVITY_RESET_TO_IDLE = 0x3FE141FDB990E3D1,
        NETWORK_ACTIVITY_SET_CURRENT = 0x9ADAC065D9F6706F,
        _REPORT_PLAYER = 0xA197C35F73AC0F12,
        _0xF23A6D6C11D8EC15 = 0xF23A6D6C11D8EC15,
        _0x3E8CCE6769DB5F34 = 0x3E8CCE6769DB5F34,
        _0x83FE8D7229593017 = 0x83FE8D7229593017,
        _0xE5FF65CFF5160752 = 0xE5FF65CFF5160752,
        _0xA95470DA137587F5 = 0xA95470DA137587F5,
        _0xBB697756309D77EE = 0xBB697756309D77EE,
        _0xD7D0DF27CB1765B5 = 0xD7D0DF27CB1765B5,
        _0x3E74A687A73979C6 = 0x3E74A687A73979C6,
        _0x1413B6BF27AB7A95 = 0x1413B6BF27AB7A95,
        _0xAFA14F98327791CE = 0xAFA14F98327791CE,
        _0xA6F1BAABFF6AD7B9 = 0xA6F1BAABFF6AD7B9,
        _0x0F44A5C78D114922 = 0x0F44A5C78D114922,
        _0xFD4272A137703449 = 0xFD4272A137703449,
        _0x71FA2D1880C48032 = 0x71FA2D1880C48032,
        _0x65F040D91001ED4B = 0x65F040D91001ED4B,
        _0x0E54D4DA6018FF8E = 0x0E54D4DA6018FF8E,
        _0x7BCA0A3972708436 = 0x7BCA0A3972708436,
        _0x25189F9908E9CD65 = 0x25189F9908E9CD65,
        _0xDDAEB478E58F8DEA = 0xDDAEB478E58F8DEA,
        _0x225640E09EFFDC3F = 0x225640E09EFFDC3F,
        _0xD3A3C8B9F3BDEF81 = 0xD3A3C8B9F3BDEF81,
        _0x18B94666CF610AEB = 0x18B94666CF610AEB,
        _0x981146E5C9CE9250 = 0x981146E5C9CE9250,
        _0xBF8276E51761F9DA = 0xBF8276E51761F9DA,
        _0xDCA4A74135E1DEA5 = 0xDCA4A74135E1DEA5,
        _0xF23D6475640D29EB = 0xF23D6475640D29EB,
        _0x704F92B3AF20D857 = 0x704F92B3AF20D857,
        _0xF342F6BD0A8287D5 = 0xF342F6BD0A8287D5,
        _0xD39A72AE5EBD57E5 = 0xD39A72AE5EBD57E5,
        _0xD1FFB246F4E088AC = 0xD1FFB246F4E088AC,
        _0x27B1AE4D8C652F08 = 0x27B1AE4D8C652F08,
        _0x6C27442A225A241A = 0x6C27442A225A241A,
        _0xE59F4924BD3A718D = 0xE59F4924BD3A718D,
        _0x16EFB123C4451032 = 0x16EFB123C4451032,
        _0xE79BA3BC265895DA = 0xE79BA3BC265895DA,
        _0xC0CFFDA87C2C163D = 0xC0CFFDA87C2C163D,
        _0x5ED39DA62BEB1330 = 0x5ED39DA62BEB1330,
        _0x3AA0CDC63696166D = 0x3AA0CDC63696166D,
        _0xE8E633215471BB5D = 0xE8E633215471BB5D,
        _0xA2837A5E21FB5A58 = 0xA2837A5E21FB5A58,
        _0xE39600E50D608693 = 0xE39600E50D608693,
        _0xD7BAD4062074B9C1 = 0xD7BAD4062074B9C1,
        _0xCA58D4FD20D70F24 = 0xCA58D4FD20D70F24,
        _0xC028B3F52C707C49 = 0xC028B3F52C707C49,
        _0x5B9C6AC118FD4774 = 0x5B9C6AC118FD4774,
        _0x603469298A4308AF = 0x603469298A4308AF,
        _0x11820D1AE80DEA39 = 0x11820D1AE80DEA39,
        _0x31DAD2CD6D49546E = 0x31DAD2CD6D49546E,
        _0xFB9ECED5B68F3B78 = 0xFB9ECED5B68F3B78,
        _0x2302C0264EA58D31 = 0x2302C0264EA58D31,
        _0x6CF82A7F65A5AD5F = 0x6CF82A7F65A5AD5F,
        _0x236321F1178A5446 = 0x236321F1178A5446,
        _0x950ACD8F05B7B9DF = 0x950ACD8F05B7B9DF,
        _0xF260AF6F43953316 = 0xF260AF6F43953316,
        _0x5759160AC17C13CE = 0x5759160AC17C13CE,
        _0xA47D48D06AA5A188 = 0xA47D48D06AA5A188,
        _0xA94ECE191D90637A = 0xA94ECE191D90637A,
        _0x5CB8B0C846D0F30B = 0x5CB8B0C846D0F30B,
        _0xFF36F36B07E69059 = 0xFF36F36B07E69059,
        _0xA3EEC0A5AFF3FC5B = 0xA3EEC0A5AFF3FC5B,
        _0xB389289F031F059A = 0xB389289F031F059A,
        _0xDA1BFED8582F61F0 = 0xDA1BFED8582F61F0,
        _0x232E1EB23CDB313C = 0x232E1EB23CDB313C,
        _0x3E4A16BC669E71B3 = 0x3E4A16BC669E71B3,
        _0xE348D1404BD80146 = 0xE348D1404BD80146,
        _0x665161D250850A9F = 0x665161D250850A9F,
        _0xBC7D36946D19E60E = 0xBC7D36946D19E60E,
        _0x02C4C6C2900D84DF = 0x02C4C6C2900D84DF,
        _0xD78A26024BB13E08 = 0xD78A26024BB13E08,
        _0x9ED3108D6847760A = 0x9ED3108D6847760A,
        _0xD785864798258032 = 0xD785864798258032,
        _0xE31A04513237DC89 = 0xE31A04513237DC89,
        _0x51D99497ABF3F451 = 0x51D99497ABF3F451,
        _0xC1E1A3D5ED7617B8 = 0xC1E1A3D5ED7617B8,
        _0xD42C543F73233041 = 0xD42C543F73233041,
        _0x5E71E72A94985214 = 0x5E71E72A94985214,
        _0x75FC34A2BA345BD1 = 0x75FC34A2BA345BD1,
        _0x34BC1E79546BA543 = 0x34BC1E79546BA543,
        _0x26A867C0B7A456D1 = 0x26A867C0B7A456D1,
        _0xDCA6ABDB9288FBE4 = 0xDCA6ABDB9288FBE4,
        _0xFD1AC0B3858F224C = 0xFD1AC0B3858F224C,
        _0xA63E4F050F20021F = 0xA63E4F050F20021F,
        _0xA35E7BF20FA269E0 = 0xA35E7BF20FA269E0,
        _0x0BF90CBB6B72977B = 0x0BF90CBB6B72977B,
        _0x7B3FF2D193628126 = 0x7B3FF2D193628126,
        _0x19B52C20B5C4757C = 0x19B52C20B5C4757C,
        _0x6CEE2E30021DAEC6 = 0x6CEE2E30021DAEC6,
        _0x44D59EC597BBF348 = 0x44D59EC597BBF348,
        _0xB131E686BD97B3F8 = 0xB131E686BD97B3F8,
        _0xEB6027FD1B4600D5 = 0xEB6027FD1B4600D5,
        _0x405DDEFB1F531B18 = 0x405DDEFB1F531B18,
        _0x43CF999205084B4B = 0x43CF999205084B4B,
        _0x13F592FC3BF0EA84 = 0x13F592FC3BF0EA84,
        _0xCF23AB5BD47B384D = 0xCF23AB5BD47B384D,
        _0xE5634491A58C2703 = 0xE5634491A58C2703,
        _0xBDCC671B911040F9 = 0xBDCC671B911040F9,
        _0x5D3C528B7A7DF836 = 0x5D3C528B7A7DF836,
        _0x2686BD9566B65EDA = 0x2686BD9566B65EDA,
        _0xBB1EC8C2EEF33BAA = 0xBB1EC8C2EEF33BAA,
        _0x67CCDF74C4DF7169 = 0x67CCDF74C4DF7169,
        _0xC8B6D18E22484643 = 0xC8B6D18E22484643,
        _0x97BCE4C4B3191228 = 0x97BCE4C4B3191228,
        _0x41452E8A3B9C0C4B = 0x41452E8A3B9C0C4B,
        _0x89EC2FC89ECB1005 = 0x89EC2FC89ECB1005,
        _0x61BFBAA795E712AD = 0x61BFBAA795E712AD,
        _0x765E60A1DCB8B1CE = 0x765E60A1DCB8B1CE,
        _0x691E4DE5309EAEFC = 0x691E4DE5309EAEFC,
        _0xDC6AD5C046F33AB4 = 0xDC6AD5C046F33AB4,
        _0x6C7E04E9DE451789 = 0x6C7E04E9DE451789,
        _0x894B5ECAB45D2342 = 0x894B5ECAB45D2342,
        _0xCE5E79D9E303628E = 0xCE5E79D9E303628E,
        _0xDBC754CB6CCB9378 = 0xDBC754CB6CCB9378,
        _0xCD53E6CBF609C012 = 0xCD53E6CBF609C012,
        _0xF40EF49B3099E98E = 0xF40EF49B3099E98E,
        _0x8C109958C9BB559D = 0x8C109958C9BB559D,
        _0xE42D1042F09865FE = 0xE42D1042F09865FE,
        _0xADB56322EEDFBDC9 = 0xADB56322EEDFBDC9,
        _0xF9F0B3028431967B = 0xF9F0B3028431967B,
        _0x2D053EA815702DD1 = 0x2D053EA815702DD1,
        _0x566CEB0542EF5ECF = 0x566CEB0542EF5ECF,
        _0xCAF50048C8D0FBA0 = 0xCAF50048C8D0FBA0,
        _0xA6BF569956C60A60 = 0xA6BF569956C60A60,
        _0x409FE0CA6A4D1D49 = 0x409FE0CA6A4D1D49,
        _0xE0CB4AB15CB32710 = 0xE0CB4AB15CB32710,
        _0x21A99A72B00D8002 = 0x21A99A72B00D8002,
        _0x104080CA9E519B00 = 0x104080CA9E519B00,
        _0x63E9DCBC8B0931ED = 0x63E9DCBC8B0931ED,
        _0x97764E8AC6487A9A = 0x97764E8AC6487A9A,
        _0x9993F1E11944A3DD = 0x9993F1E11944A3DD,
        _0x24CD8FAEA1368379 = 0x24CD8FAEA1368379,
        _0x5F0E99071582DECA = 0x5F0E99071582DECA,
        _0x98539FC453AEA639 = 0x98539FC453AEA639,
        _0x2D5DC831176D0114 = 0x2D5DC831176D0114,
        _0xEBFA8D50ADDC54C4 = 0xEBFA8D50ADDC54C4,
        _0x162C23CA83ED0A62 = 0x162C23CA83ED0A62,
        _0x5A34CD9C3C5BEC44 = 0x5A34CD9C3C5BEC44,
        _0x68103E2247887242 = 0x68103E2247887242,
        _0xD4022C7286B0DFA2 = 0xD4022C7286B0DFA2,
        _0xA21E3BAD0A42D199 = 0xA21E3BAD0A42D199,
        _0xCC4E72C339461ED1 = 0xCC4E72C339461ED1,
        _0x356F9FB0698C1FEB = 0x356F9FB0698C1FEB,
        _0xCAF4CA2F87779F8F = 0xCAF4CA2F87779F8F,
        _0xB5C4B18B12A2AF23 = 0xB5C4B18B12A2AF23,
        _0xE2C3CEC3C0903A00 = 0xE2C3CEC3C0903A00,
        _0xCBAC13F065C47596 = 0xCBAC13F065C47596,
        _0xCD954F330693F5F2 = 0xCD954F330693F5F2,
        _0xFBC30B70B3CDB87E = 0xFBC30B70B3CDB87E,
        _0x814729078AED6D30 = 0x814729078AED6D30,
        _0xE258570E0C116A66 = 0xE258570E0C116A66,
        _0x4440FEE3EFE78F54 = 0x4440FEE3EFE78F54,
        _0xA021095C983F20D8 = 0xA021095C983F20D8,
        _0x6D87BA8EF15226CD = 0x6D87BA8EF15226CD,
        _0x277865A734918AE6 = 0x277865A734918AE6,
        _0x5A91BCEF74944E93 = 0x5A91BCEF74944E93,
        _0x0B6B4507AC5EA8B8 = 0x0B6B4507AC5EA8B8,
        _0x3034C77C79A58880 = 0x3034C77C79A58880,
        _0xDCC4B7F7112E8AB7 = 0xDCC4B7F7112E8AB7,
        _0x455156F47DC6B78C = 0x455156F47DC6B78C,
        _0x5CD3AAD8FF9ED121 = 0x5CD3AAD8FF9ED121,
        _0x51951DE06C0D1C40 = 0x51951DE06C0D1C40,
        _0xE3AB5EEFCB6671A2 = 0xE3AB5EEFCB6671A2,
        _0x9B39B0555CC692B5 = 0x9B39B0555CC692B5,
        _0xFE53B1F8D43F19BF = 0xFE53B1F8D43F19BF,
        _0x862C5040F4888741 = 0x862C5040F4888741,
        _0x7E300B5B86AB1D1A = 0x7E300B5B86AB1D1A,
        _0x780A13F780A13F1B = 0x780A13F780A13F1B,
        _0xE525878A35B9EEBD = 0xE525878A35B9EEBD,
        _0x3F0ABAE38A0515AD = 0x3F0ABAE38A0515AD,
        _0x3F2EE18A3E294801 = 0x3F2EE18A3E294801,
        _0x271F95E55C663B8B = 0x271F95E55C663B8B,
        _0x64A36BA85CE01A81 = 0x64A36BA85CE01A81,
        _0xE10F2D7715ABABEC = 0xE10F2D7715ABABEC,
        _0x7A8E8DF782B47EB0 = 0x7A8E8DF782B47EB0,
        _0x77B299E8799B1332 = 0x77B299E8799B1332,
        _0x923346025512DFB7 = 0x923346025512DFB7,
        _0x273E04A3A7AD1F2D = 0x273E04A3A7AD1F2D,
        _0x49CF17A564918E8D = 0x49CF17A564918E8D,
        _0xD637D327080CD86E = 0xD637D327080CD86E,
        _0x564552C6AF1EEAB1 = 0x564552C6AF1EEAB1,
    }
    public static class NATIVE_NETWORK_EXTENSIONS
    {
        public static void Call(this NATIVE_NETWORK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_NETWORK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}