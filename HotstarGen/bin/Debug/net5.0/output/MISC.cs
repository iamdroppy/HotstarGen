using System;
namespace Hotstar
{
    public enum NATIVE_MISC : ulong
    { 
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        IS_MAG_DEMO_1_ACTIVE = 0x5FC9357C26DAEFCE,
        /// <summary>
        /// Maximum value is 1.0f
        /// At a value of 0.0f the game will still run at a minimum time scale.
        ///
        /// > float timeScale
        ///
        /// </summary>
        SET_TIME_SCALE = 0x9682AF6050854856,
        /// <summary>
        /// If true, the player can't save the game.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MISSION_FLAG = 0x36694B456BE80D0A,
        /// <summary>
        /// If the parameter is true, sets the random event flag to true, if the parameter is false, the function does nothing at all.
        /// Does nothing if the mission flag is set.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RANDOM_EVENT_FLAG = 0xB1ADCCC4150C6473,
        /// <summary>
        /// creates single lightning+thunder at random position
        ///
        ///
        /// </summary>
        FORCE_LIGHTNING_FLASH = 0x369DB5B2510FA080,
        /// <summary>
        /// p3 is always -1.0f in the scripts
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        ///
        /// </summary>
        _FORCE_LIGHTNING_FLASH_AT_COORDS = 0x67943537D179597C,
        /// <summary>
        /// Returns rage::fwTimer::sm_nonScaledClippedTime
        ///
        ///
        /// </summary>
        _GET_GAME_TIMER_NON_SCALED_CLIPPED = 0x483B8C542103AD72,
        /// <summary>
        /// Reads the passed value as floating point value and returns it.
        /// Example: _READ_INT_AS_FLOAT(0x3F800000) returns 1.0f because 0x3F800000 is the hexadecimal representation of 1.0f.
        ///
        /// > int value
        ///
        /// </summary>
        _READ_INT_AS_FLOAT = 0xD2C9126410DFA1B2,
        /// <summary>
        /// If useZ is false, only the 2D plane (X-Y) will be considered for calculating the distance.
        /// 
        /// Consider using this faster native instead: SYSTEM::VDIST - DVIST always takes in consideration the 3D coordinates.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > BOOL useZ
        ///
        /// </summary>
        GET_DISTANCE_BETWEEN_COORDS = 0x0BE7F4E3CDBAFB28,
        /// <summary>
        /// dx = x1 - x2
        /// dy = y1 - y2
        ///
        /// > float dx
        /// > float dy
        ///
        /// </summary>
        GET_HEADING_FROM_VECTOR_2D = 0x38D5202FF9271C62,
        /// <summary>
        /// Computes a hash for the given string. It is hashed using Jenkins' One-at-a-Time hash algorithm (https://en.wikipedia.org/wiki/Jenkins_hash_function)
        /// Note: this implementation is case-insensitive.
        ///
        /// > const char* string
        ///
        /// </summary>
        GET_HASH_KEY = 0xFD340785ADF8CFB7,
        /// <summary>
        /// Sets whether the game should fade in after the player dies or is arrested.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_FADE_IN_AFTER_DEATH_ARREST = 0xDF3B5846DE5904AF,
        /// <summary>
        /// Returns whether the game's measurement system is set to metric.
        ///
        ///
        /// </summary>
        SHOULD_USE_METRIC_MEASUREMENTS = 0x4FB556ACEFA93098,
        /// <summary>
        /// Same as SHOULD_USE_METRIC_MEASUREMENTS
        ///
        ///
        /// </summary>
        _SHOULD_USE_METRIC_MEASUREMENTS_2 = 0x58BCDC75BA52110A,
        /// <summary>
        /// Determines whether there is a projectile within the specified coordinates. The coordinates form a rectangle.
        /// 
        /// ownedByPlayer = only projectiles fired by the player will be detected.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > BOOL ownedByPlayer
        ///
        /// </summary>
        IS_PROJECTILE_IN_AREA = 0x05B0061EFDFC8941,
        /// <summary>
        /// Determines whether there is a projectile of a specific type within the specified coordinates. The coordinates form a rectangle.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int type
        /// > BOOL p7
        ///
        /// </summary>
        IS_PROJECTILE_TYPE_IN_AREA = 0x04965FB9E14235C7,
        /// <summary>
        /// GET_PROJECTILE_*
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > float distance
        /// > Vector3* outCoords
        /// > Object* outProjectile
        /// > BOOL p5
        /// > BOOL mustBeOwnedByThisPed
        ///
        /// </summary>
        _GET_PROJECTILE_NEAR_PED = 0x9578986A6105A6AD,
        /// <summary>
        /// p3 - possibly radius?
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        HAS_BULLET_IMPACTED_IN_AREA = 0xC153E5BCCF411814,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        IS_ORBIS_VERSION = 0x88CFAE250D3E0C71,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        IS_DURANGO_VERSION = 0xD1CCC2A2639D325F,
        /// <summary>
        /// Hardcoded to return true.
        ///
        ///
        /// </summary>
        IS_PC_VERSION = 0xB0FB6CFAA5A1C833,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        IS_STADIA_VERSION = 0x268AB8420A9E4ED7,
        /// <summary>
        /// Returns true if the entire string consists only of space characters.
        ///
        /// > const char* string
        ///
        /// </summary>
        IS_STRING_NULL_OR_EMPTY_OR_SPACES = 0x375F5870A7B8BEC1,
        /// <summary>
        /// Returns false if it's a null or empty string or if the string is too long. outInteger will be set to -999 in that case.
        ///
        /// > const char* string
        /// > int* outInteger
        ///
        /// </summary>
        STRING_TO_INT = 0xF2DD2298B3AF23E2,
        /// <summary>
        /// Note: the buffer should be exactly 32 bytes long
        ///
        /// > int value
        /// > const char* format
        /// > char* buffer
        ///
        /// </summary>
        _INT_TO_STRING = 0xCF11C0CEB40C401B,
        /// <summary>
        /// Note: The first bit in 'flags' must not be set.
        /// It is also required to pass at least one extra argument (this must be a text label string or hash).
        /// When passing a hash, flags should be 0.
        ///
        /// > int flags
        /// >  ...
        ///
        /// </summary>
        VAR_STRING = 0xFA925AC00EB830B9,
        /// <summary>
        /// Returns a formatted string (0x%x)
        ///
        /// > int rgb
        ///
        /// </summary>
        _CREATE_COLOR_STRING = 0xBCC2CFADEA1AEA6C,
        /// <summary>
        /// Make sure to call this from the correct thread if you're using multiple threads because all other threads except the one which is calling SET_GAME_PAUSED will be paused.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_GAME_PAUSED = 0xFAEC088D28B1DE4A,
        /// <summary>
        /// Cheats are GTA IV cheats:
        /// 
        /// 0 = unknown
        /// 1 = unknown (same as 0)
        /// 2 = Max Health and Armor
        /// 3 = Raise Wanted Level
        /// 4 = Lower Wanted Level
        /// 5 = unknown (does nothing)
        /// 6 = Change Weather
        /// 7 = Spawn Annihilator
        /// 8 = Spawn NRG 900
        /// 9 = Spawn FBI
        /// 10 = Spawn Jetmax
        /// 11 = Spawn Comet
        /// 12 = Spawn Turismo
        /// 13 = Spawn Cognoscenti
        /// 14 = Spawn Super GT
        /// 15 = Spawn Sanchez
        /// 
        /// Initially used in Max Payne 3, that's why we know the name.
        ///
        /// > int cheatId
        ///
        /// </summary>
        SET_CHEAT_ACTIVE = 0xD4958E8CF0DE0DD0,
        /// <summary>
        /// spawns a few distant/out-of-sight peds, vehicles, animals etc each time it is called
        ///
        ///
        /// </summary>
        POPULATE_NOW = 0xEA6DC3A8ADD2005F,
        /// <summary>
        /// p0 must be < 2
        ///
        /// > int p0
        ///
        /// </summary>
        _QUEUE_SAVEGAME_OPERATION = 0x279B0696DA4657EB,
        /// <summary>
        /// Only 0 and 1 are valid for p0, higher values causes the native to return 2.
        ///
        /// > int p0
        ///
        /// </summary>
        _GET_STATUS_OF_SAVEGAME_OPERATION = 0x1B065A2BF7953815,
        /// <summary>
        /// enum DispatchType
        /// {
        /// 	DT_Invalid,
        /// 	DT_PoliceAutomobile,
        /// 	DT_PoliceHelicopter,
        /// 	DT_FireDepartment,
        /// 	DT_SwatAutomobile,
        /// 	DT_AmbulanceDepartment,
        /// 	DT_PoliceRiders,
        /// 	DT_PoliceVehicleRequest,
        /// 	DT_PoliceRoadBlock,
        /// 	DT_PoliceAutomobileWaitPulledOver,
        /// 	DT_PoliceAutomobileWaitCruising,
        /// 	DT_Gangs,
        /// 	DT_SwatHelicopter,
        /// 	DT_PoliceBoat,
        /// 	DT_ArmyVehicle,
        /// 	DT_OnFoot,
        /// 	DT_PoliceDogs
        /// };
        ///
        /// > int dispatchService
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_DISPATCH_SERVICE = 0x50E52637EF70EF77,
        /// <summary>
        /// dispatchService: see ENABLE_DISPATCH_SERVICE
        ///
        /// > int dispatchService
        /// > BOOL toggle
        ///
        /// </summary>
        BLOCK_DISPATCH_SERVICE_RESOURCE_CREATION = 0x66947E61A44DE2C6,
        /// <summary>
        /// dispatchService: see ENABLE_DISPATCH_SERVICE
        ///
        /// > int dispatchService
        /// > float x
        /// > float y
        /// > float z
        /// > int numUnits
        /// > float radius
        /// > int* outIncidentID
        /// > Any p7
        /// > Any p8
        ///
        /// </summary>
        CREATE_INCIDENT = 0x3F892CAF67444AE7,
        /// <summary>
        /// dispatchService: see ENABLE_DISPATCH_SERVICE
        /// 
        /// The entities must be added to itemSet.
        ///
        /// > int dispatchService
        /// > float x
        /// > float y
        /// > float z
        /// > ItemSet itemSet
        /// > float radius
        /// > int* outIncidentID
        ///
        /// </summary>
        _CREATE_INCIDENT_WITH_ENTITIES = 0xAB3D3F45436DB1D8,
        /// <summary>
        /// Delete an incident with a given id.
        ///
        /// > int incidentId
        ///
        /// </summary>
        DELETE_INCIDENT = 0x5CFD0F0D6AAE0AEE,
        /// <summary>
        /// enum eOnscreenKeyboardTextType
        /// {
        /// 	KTEXTTYPE_INVALID = -1,
        /// 	KTEXTTYPE_DEFAULT,
        /// 	KTEXTTYPE_EMAIL,
        /// 	KTEXTTYPE_PASSWORD,
        /// 	KTEXTTYPE_NUMERIC,
        /// 	KTEXTTYPE_ALPHABET,
        /// 	KTEXTTYPE_GAMERTAG,
        /// 	KTEXTTYPE_FILENAME,
        /// 	KTEXTTYPE_COUNT
        /// };
        ///
        /// > int textType
        /// > const char* windowTitle
        /// > const char* p2
        /// > const char* defaultText
        /// > const char* defaultConcat1
        /// > const char* defaultConcat2
        /// > const char* defaultConcat3
        /// > int maxInputLength
        ///
        /// </summary>
        DISPLAY_ONSCREEN_KEYBOARD = 0x044131118D8DB3CD,
        /// <summary>
        /// Returns the current status of the onscreen keyboard, and updates the output.
        /// 
        /// Status Codes:
        /// 
        /// 0 - User still editing
        /// 1 - User has finished editing
        /// 2 - User has canceled editing
        /// 3 - Keyboard isn't active
        ///
        ///
        /// </summary>
        UPDATE_ONSCREEN_KEYBOARD = 0x37DF360F235A3893,
        /// <summary>
        /// Returns NULL unless UPDATE_ONSCREEN_KEYBOARD() returns 1 in the same tick.
        ///
        ///
        /// </summary>
        GET_ONSCREEN_KEYBOARD_RESULT = 0xAFB4CF58A4A292B1,
        /// <summary>
        /// Appears to remove stealth kill action from memory
        ///
        /// > Hash hash
        /// > BOOL p1
        ///
        /// </summary>
        _REMOVE_STEALTH_KILL = 0x7ACF124C12A2B045,
        /// <summary>
        /// Begins with START_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _START_BENCHMARK_RECORDING = 0x29D1F6DF864A094E,
        /// <summary>
        /// Begins with STOP_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _STOP_BENCHMARK_RECORDING = 0xB89AEC71AFF2B599,
        /// <summary>
        /// Begins with RESET_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _RESET_BENCHMARK_RECORDING = 0xECBABD0307FB216F,
        /// <summary>
        /// Saves the benchmark recording to %USERPROFILE%\Documents\Rockstar Games\Red Dead Redemption 2\Benchmarks and submits some metrics.
        ///
        ///
        /// </summary>
        _SAVE_BENCHMARK_RECORDING = 0xF4743E2ECC02B3DA,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _UI_IS_SINGLEPLAYER_PAUSE_MENU_ACTIVE = 0x4FFA0386A6216113,
        /// <summary>
        /// Returns value of the '-benchmarkIterations' command line option.
        ///
        ///
        /// </summary>
        _GET_BENCHMARK_ITERATIONS_FROM_COMMAND_LINE = 0x22FC52CF470CC98D,
        /// <summary>
        /// Returns value of the '-benchmarkPass' command line option.
        ///
        ///
        /// </summary>
        _GET_BENCHMARK_PASS_FROM_COMMAND_LINE = 0x9297DACF3A2CDFF7,
        /// <summary>
        /// 0 = invalid
        /// 1 = CEntity
        /// 2 = rage::volBase
        /// 3 = rage::volSphere
        /// 4 = rage::volBox
        /// 5 = rage::volAggregate
        /// 6 = rage::volCylinder
        /// 7 = CScriptedCoverPoint
        /// 8 = rage::ptfxScriptInfo
        /// 9 = CPed
        /// 10 = CVehicle
        /// 11 = CObject
        /// 12 = CItemSet
        /// 13 = CPersistentCharacter
        ///
        /// > ScrHandle handle
        ///
        /// </summary>
        _GET_ITEM_TYPE = 0xDC8D2FF478DF9553,
        /// <summary>
        /// Event names in the scripts: MGBegin, MGEnd, ReadyForCut
        ///
        /// > Ped ped
        /// > const char* eventName
        ///
        /// </summary>
        _GET_LOOTING_EVENT_HAS_FIRED = 0xF9B91C5129EABC08,
        /// <summary>
        /// Note: this native was added in build 1232.56
        ///
        ///
        /// </summary>
        _SET_GAME_LOGIC_PAUSED = 0x550F05CFFBD63C8C,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        STOP_CURRENT_LOADING_PROGRESS_TIMER = 0xA565FAC215CBC77D,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > const char* p0
        /// > const char* p1
        ///
        /// </summary>
        _0xCC7FC854B956A128 = 0xCC7FC854B956A128,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x9935F76407C32539 = 0x9935F76407C32539,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xFF252E2BAFB7330F = 0xFF252E2BAFB7330F,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > const char* p0
        /// > const char* p1
        ///
        /// </summary>
        _0x91D657230BC208D2 = 0x91D657230BC208D2,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x1694A053DFB61A34 = 0x1694A053DFB61A34,
        /// <summary>
        /// Hardcoded to return one/true.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xAF530E56505D1BD6 = 0xAF530E56505D1BD6,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xB16FC7B364D86585 = 0xB16FC7B364D86585,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xA9342743B634A462 = 0xA9342743B634A462,
        /// <summary>
        /// GET_C*
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > float p8
        /// > BOOL p9
        ///
        /// </summary>
        _0x83ACC65D9ACEC5EF = 0x83ACC65D9ACEC5EF,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0xB711EB4BC8D06013 = 0xB711EB4BC8D06013,
        /// <summary>
        /// RESET_*
        ///
        ///
        /// </summary>
        _0xEF42F56F69877125 = 0xEF42F56F69877125,
        /// <summary>
        /// SCRIPT_RACE_*
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        _0xBA62B4D80FA66BD6 = 0xBA62B4D80FA66BD6,
        /// <summary>
        /// Hardcoded to return one/true.
        ///
        ///
        /// </summary>
        _0xDC057B86FC157031 = 0xDC057B86FC157031,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        /// > Any p1
        ///
        /// </summary>
        _0xEB946B9E579729AD = 0xEB946B9E579729AD,
        GET_NUMBER_OF_FREE_STACKS_OF_THIS_SIZE = 0x40DC2907A9697EF7,
        _GET_NUMBER_OF_INSTRUCTIONS = 0x72904D3D62AF5839,
        _GET_MAX_NUM_INSTRUCTIONS = 0xC43CD2668B204419,
        SET_RANDOM_SEED = 0x5CD7A49104AFCB6B,
        GET_MISSION_FLAG = 0xB15CD1CF58771DE1,
        GET_RANDOM_EVENT_FLAG = 0x924D54E5698AE3E0,
        _GET_PREV_WEATHER_TYPE_HASH_NAME = 0x4BEB42AEBCA732E9,
        _GET_NEXT_WEATHER_TYPE_HASH_NAME = 0x51021D36F62AAA83,
        SET_WEATHER_TYPE = 0x59174F1AFE095B5A,
        _SET_WEATHER_TYPE_2 = 0x2C6A07AF9AEDABD8,
        _GET_RANDOM_WEATHER_TYPE = 0x1359C181BC625503,
        SET_RANDOM_WEATHER_TYPE = 0x6E5A7FBEECAB3C72,
        CLEAR_WEATHER_TYPE_PERSIST = 0xD85DFE5C131E4AE9,
        _CLEAR_WEATHER_TYPE_PERSIST_OVERTIME = 0xCE7690C0A0D1C36D,
        _GET_WEATHER_TYPE_TRANSITION = 0x0AC679B2342F14F2,
        _SET_WEATHER_TYPE_TRANSITION = 0xFA3E3CA8A1DE6D5D,
        _SET_WEATHER_TYPE_FROZEN = 0xD74ACDF7DB8114AF,
        _SET_OVERRIDE_WEATHER = 0xBE83CAE8ED77A94F,
        CLEAR_OVERRIDE_WEATHER = 0x80A398F16FFE3CC3,
        _SET_WEATHER_VARIATION = 0x3373779BAF7CAF48,
        _CLEAR_WEATHER_VARIATION = 0x0E71C80FA4EC8147,
        WATER_OVERRIDE_SET_SHOREWAVEAMPLITUDE = 0x55123D5A7D9D3C42,
        WATER_OVERRIDE_SET_OCEANWAVEMAXAMPLITUDE = 0xF06C5B66DE20B2B8,
        _GET_TEMPERATURE_AT_COORDS = 0xB98B78C3768AF6E0,
        SET_WIND_SPEED = 0xD00C2D82DC04A99F,
        GET_WIND_SPEED = 0xFFB7E74E041150A4,
        SET_WIND_DIRECTION = 0xB56C4F5F57A45600,
        GET_WIND_DIRECTION = 0xF703E82F3FE14A5F,
        _SET_RAIN_LEVEL = 0x193DFC0526830FD6,
        GET_RAIN_LEVEL = 0x931B5F4CC130224B,
        _SET_SNOW_LEVEL = 0xF6BEE7E80EC5CA40,
        GET_SNOW_LEVEL = 0x1E5D727041BE1709,
        GET_GAME_TIMER = 0x4F67E8ECA7D3F667,
        GET_SYSTEM_TIME = 0xBE7F225417E35A7C,
        _GET_NUMBER_OF_MICROSECONDS_SINCE_LAST_CALL = 0xB0CE5E5ED8BB3581,
        _GET_SCRIPT_TIME_WITHIN_FRAME_IN_MICROSECONDS = 0x63219768C586667C,
        _RESET_SCRIPT_TIME_WITHIN_FRAME = 0x1411A7CBC3A6EB7B,
        GET_FRAME_TIME = 0x5E72022914CE3C38,
        _GET_BENCHMARK_TIME = 0x3F3172FEAE3AFE1C,
        GET_FRAME_COUNT = 0x77DFA958FCF100C1,
        GET_RANDOM_FLOAT_IN_RANGE = 0xE29F927A961F8AAA,
        GET_RANDOM_INT_IN_RANGE = 0xD53343AA4FB7DD28,
        GET_GROUND_Z_FOR_3D_COORD = 0x24FA4267BB8D2431,
        GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD = 0x2A29CA9A6319E6AB,
        ASIN = 0x6E3C15D296C15583,
        ACOS = 0x586690F0176DC575,
        TAN = 0x8C13DB96497B7ABF,
        ATAN = 0x503054DED0B78027,
        ATAN2 = 0x965B220A066E3F07,
        GET_ANGLE_BETWEEN_2D_VECTORS = 0xD0DFE1C486097BBB,
        SET_BIT = 0xF73FBE4845C43B5B,
        CLEAR_BIT = 0x7D1D4A3602B6AD4E,
        IS_POSITION_OCCUPIED = 0x825CA3ED43831015,
        CLEAR_AREA = 0x3B882A96EA77D5B1,
        CLEAR_ANGLED_AREA_OF_VEHICLES = 0xA4D83115C1E02F8A,
        SET_CREDITS_ACTIVE = 0xD37BECF862DA726F,
        NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME = 0x3D0EAC6385DD6100,
        PAUSE_DEATH_ARREST_RESTART = 0x66AB6B6C7E72F393,
        IGNORE_NEXT_RESTART = 0x6C9FF40FF1B69F8F,
        SET_FADE_IN_AFTER_LOAD = 0xAC806C4CAB973517,
        OVERRIDE_SAVE_HOUSE = 0xB2C69E11A37B5AF0,
        SHOOT_SINGLE_BULLET_BETWEEN_COORDS = 0x867654CBC7606F2C,
        FIRE_SINGLE_BULLET = 0xCBC9A21F6A2A679C,
        GET_MODEL_DIMENSIONS = 0xDCB8DDD5D054A7E7,
        IS_BIT_SET = 0x4ED6CFDFE8D4131A,
        IS_MINIGAME_IN_PROGRESS = 0xF4D8BCD052E7EA1B,
        _SHOULD_USE_METRIC_TEMPERATURE = 0xFF4AAF3275BAAB4F,
        _SHOULD_USE_METRIC_WEIGHT = 0x8F24157FEDB85EA2,
        _SHOULD_USE_24_HOUR_CLOCK = 0x0177CF20345F44DD,
        COMPARE_STRINGS = 0xBFBB74A15EFC149B,
        ABSI = 0x0C214D5B8A38C828,
        ABSF = 0x134549B388167CBF,
        IS_PROJECTILE_TYPE_IN_ANGLED_AREA = 0x928431F4133CD3D4,
        IS_PROJECTILE_TYPE_WITHIN_DISTANCE = 0xF51C9BAAD9ED64C4,
        GET_COORDS_OF_PROJECTILE_TYPE_WITHIN_DISTANCE = 0xD73C960A681052DF,
        IS_BULLET_IN_ANGLED_AREA = 0x9D09D8493747CF02,
        IS_BULLET_IN_AREA = 0xC652FD308772D79E,
        IS_BULLET_IN_BOX = 0xC128137C52152741,
        HAS_BULLET_IMPACTED_IN_BOX = 0x3B6A4C05FB2B33AC,
        IS_STRING_NULL = 0x602102324604D96B,
        IS_STRING_NULL_OR_EMPTY = 0x2CF12F9ACF18F048,
        ARE_STRINGS_EQUAL = 0xD3852F22AB713A1F,
        _DOES_STRING_EXIST_IN_STRING = 0x9382D5D43D2AA6FF,
        _GET_STRING_FROM_FLOAT = 0x2B6846401D68E563,
        _GET_STRING_FROM_VECTOR = 0x6C4DBF553885F9EB,
        _GET_STRING_FROM_BOOL = 0xF216F74101968DB0,
        SET_BITS_IN_RANGE = 0x324DC1CEF57F31E6,
        GET_BITS_IN_RANGE = 0x68E1352AF48F905D,
        SET_THIS_SCRIPT_CAN_BE_PAUSED = 0x3215376E79F6EA18,
        SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT = 0x8ABD939C2E5D00ED,
        IS_GAME_SESSION_STATE_MACHINE_IDLE = 0xF9E7DBB39080640B,
        _COPY_MEMORY = 0xF7AC7DC0DEE7C9BE,
        IS_INCIDENT_VALID = 0x39F2B1BAD412246A,
        _SET_INCIDENT_UNK = 0x9617B6E5F6537B63,
        ADD_POP_MULTIPLIER_AREA = 0x5EBDA1A3B8CB5EF7,
        DOES_POP_MULTIPLIER_AREA_EXIST = 0x03BA619C81A646B3,
        REMOVE_POP_MULTIPLIER_AREA = 0x88CB484364EFB37A,
        RESET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0xC7817264BC4B6377,
        SET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0xEAB6823B82FBD283,
        _RESET_DISPATCH_MIN_SPAWN_DISTANCE = 0x96498D922D8D0D0A,
        _SET_DISPATCH_MIN_SPAWN_DISTANCE = 0x27A1B170AA8AF84C,
        _RESET_DISPATCH_MAX_SPAWN_DISTANCE = 0x54EC7B6BC72BAD69,
        _SET_DISPATCH_MAX_SPAWN_DISTANCE = 0x89314FB3463E28DE,
        _ADD_DISPATCH_SPAWN_BLOCKING_AREA = 0xA2D5A26208421426,
        REMOVE_DISPATCH_SPAWN_BLOCKING_AREA = 0x49F751F6868DDC5B,
        _ADD_TACTICAL_ANALYSIS_POINT = 0xE4EE55E63FA9AF45,
        _CLEAR_TACTICAL_ANALYSIS_POINTS = 0xD93B6516C6878267,
        _CANCEL_ONSCREEN_KEYBOARD = 0x58A39BE597CE99CD,
        NEXT_ONSCREEN_KEYBOARD_RESULT_WILL_DISPLAY_USING_THESE_FONTS = 0x5CB71EAA1429A358,
        SET_SUPER_JUMP_THIS_FRAME = 0xB3E9BE963F10C445,
        SCRIPT_RACE_INIT = 0x8AE059F47158417E,
        SCRIPT_RACE_SHUTDOWN = 0x334CE0DA4FAF330C,
        SCRIPT_RACE_GET_PLAYER_SPLIT_TIME = 0x769E848C66E3C2BB,
        _DOES_ITEM_HAVE_VALID_BASE = 0xBDC6E364C9C78178,
        _IS_BASE_A_PERSISTENT_CHARACTER = 0x716F17F8A0419F95,
        _IS_BASE_A_COVER_POINT = 0xFEC1D4B5C82C176F,
        _GET_ENTITY_FROM_ITEM = 0xEE04C0AFD4EFAF0E,
        _GET_PED_FROM_INDEXED_ITEM = 0x3FFB15534067DCD4,
        _GET_VEHICLE_FROM_INDEXED_ITEM = 0xE578C8AE173719B3,
        _GET_OBJECT_FROM_INDEXED_ITEM = 0x18013392501CE5DC,
        REGISTER_INTERACTION_LOCKON_PROMPT = 0x870708A6E147A9AD,
        _IS_MISSION_CREATOR_ACTIVE = 0xF236C84C6ADFCB2F,
        _IS_PED_DECOMPOSED = 0x5170DDA6D63ACAAA,
        SET_PED_DECOMPOSED = 0x674B90BE1115846D,
        DISABLE_LOOTING_COMPOSITE_LOOTABLE_THIS_FRAME = 0x40D72189F46D2E15,
        _IS_GLOBAL_BLOCK_VALID = 0xACB7E1418A8B6E32,
        _SET_GLOBAL_BLOCK_IS_LOADED = 0xE97240065406CB80,
        GAME_FRAMEWORK_MANAGER_INIT = 0x4CABE596D632E4B0,
        _GAME_FRAMEWORK_MANAGER_SHUTDOWN = 0xAFF2FD8ADD927585,
        _GAME_FRAMEWORK_MANAGER_GET_MODE = 0xFAED234C7F53ABEB,
        _0x5801BE2DF2AF07EC = 0x5801BE2DF2AF07EC,
        _0x9BF2C0C568C61641 = 0x9BF2C0C568C61641,
        _0xF81C53561D15F330 = 0xF81C53561D15F330,
        _0x1096603B519C905F = 0x1096603B519C905F,
        _0xCC3EDC5614B03F61 = 0xCC3EDC5614B03F61,
        _0x708DF841B8F27AA2 = 0x708DF841B8F27AA2,
        _0xDA4D8EB04E8E2928 = 0xDA4D8EB04E8E2928,
        _0xB08C4FA25BC29DB9 = 0xB08C4FA25BC29DB9,
        _0x0730E518486DEEC3 = 0x0730E518486DEEC3,
        _0x7F4CE164D9A11DFE = 0x7F4CE164D9A11DFE,
        _0xDD560ABEF5D3784C = 0xDD560ABEF5D3784C,
        _0x2916B30DC6C41179 = 0x2916B30DC6C41179,
        _0xD3F943B88F55376A = 0xD3F943B88F55376A,
        _0x243CEDE8F916B994 = 0x243CEDE8F916B994,
        _0x745808BB01CEC6B9 = 0x745808BB01CEC6B9,
        _0x6BED40493A1AFDB8 = 0x6BED40493A1AFDB8,
        _0xBBE5B63EFFB08E68 = 0xBBE5B63EFFB08E68,
        _0xAB6A04CEC428258B = 0xAB6A04CEC428258B,
        _0x8F4F050054005C27 = 0x8F4F050054005C27,
        _0x80E9C316EF84DD81 = 0x80E9C316EF84DD81,
        _0xE704838F36F93B7B = 0xE704838F36F93B7B,
        _0xE84AAC1B22A73E99 = 0xE84AAC1B22A73E99,
        _0xB909149F2BB5F6DA = 0xB909149F2BB5F6DA,
        _0xD2D74F89DF844A50 = 0xD2D74F89DF844A50,
        _0xEF50E344A8F93784 = 0xEF50E344A8F93784,
        _0x2FCD528A397E5C88 = 0x2FCD528A397E5C88,
        _0x0A487CC74A517FB5 = 0x0A487CC74A517FB5,
        _0x7A76104CC2CC69E8 = 0x7A76104CC2CC69E8,
        _0xDC416CA762BC4F43 = 0xDC416CA762BC4F43,
        _0x970339EFA4FDE518 = 0x970339EFA4FDE518,
        _0x3C3C7B1B5EC08764 = 0x3C3C7B1B5EC08764,
        _0x94E8CA3DEE952789 = 0x94E8CA3DEE952789,
        _0x5B4A8121A47D844D = 0x5B4A8121A47D844D,
        _0x74ACA66484CEBAF0 = 0x74ACA66484CEBAF0,
        _0x49C44FE78A135A1D = 0x49C44FE78A135A1D,
        _0xF650DCF5D6F312C1 = 0xF650DCF5D6F312C1,
        _0x6C7B68D3CE60E8DE = 0x6C7B68D3CE60E8DE,
        _0x627B68D9CE6EE8DE = 0x627B68D9CE6EE8DE,
        _0x7CF96F1250EF3221 = 0x7CF96F1250EF3221,
        _0x3233C4EC0514C7EC = 0x3233C4EC0514C7EC,
        _0x39D6DACE323A20B6 = 0x39D6DACE323A20B6,
        _0xBD090F5B1DB82189 = 0xBD090F5B1DB82189,
        _0xF569E33FB72ED28E = 0xF569E33FB72ED28E,
        _0x4B0501A468B749F8 = 0x4B0501A468B749F8,
        _0x6BCF7B5CD338281A = 0x6BCF7B5CD338281A,
        _0xFD0759658268FD8E = 0xFD0759658268FD8E,
        _0x2E036F0480B8BF02 = 0x2E036F0480B8BF02,
        _0x9A252AA23D7098F2 = 0x9A252AA23D7098F2,
        _0x553D67295DDD2309 = 0x553D67295DDD2309,
        _0xF18AF483DF70BBDE = 0xF18AF483DF70BBDE,
        _0x33982467B1E349EF = 0x33982467B1E349EF,
        _0x8314FC2013ECE2DA = 0x8314FC2013ECE2DA,
        _0x4D5C9CC7E7E23E09 = 0x4D5C9CC7E7E23E09,
        _0xE98D55C5983F2509 = 0xE98D55C5983F2509,
        _0xFC6ECB9170145ECE = 0xFC6ECB9170145ECE,
        _0x35165C658077CD0B = 0x35165C658077CD0B,
        _0x4B101DBCC9482F2D = 0x4B101DBCC9482F2D,
        _0xA3A8926951471C82 = 0xA3A8926951471C82,
        _0x88BC5F4AEF77FC4E = 0x88BC5F4AEF77FC4E,
        _0xFDF38E2B711BF78E = 0xFDF38E2B711BF78E,
        _0x6AC4AF46A6B8DFB2 = 0x6AC4AF46A6B8DFB2,
        _0x8DB104CCEBCD58C5 = 0x8DB104CCEBCD58C5,
        _0x68319452C5064ABA = 0x68319452C5064ABA,
        _0xDE2C3B74D2B3705C = 0xDE2C3B74D2B3705C,
        _0x49F3241C28EBBFBC = 0x49F3241C28EBBFBC,
        _0x183672FE838A661B = 0x183672FE838A661B,
        _0x38C0C9CAE1544500 = 0x38C0C9CAE1544500,
        _0x154340E87D8CC178 = 0x154340E87D8CC178,
        _0x94FCADCF9F0C368E = 0x94FCADCF9F0C368E,
        _0x0D0AE5081F88CFE1 = 0x0D0AE5081F88CFE1,
        _0xAF3A84C7DE6A1DC5 = 0xAF3A84C7DE6A1DC5,
        _0x48E4D50F87A96AA5 = 0x48E4D50F87A96AA5,
        _0xB1F6665AA54DCD5C = 0xB1F6665AA54DCD5C,
        _0x8BB99B85444544D9 = 0x8BB99B85444544D9,
        _0x6F02B5E50511721E = 0x6F02B5E50511721E,
        _0xCC1BAF72D571DB8D = 0xCC1BAF72D571DB8D,
        _0xAB26DEEE120FD3FD = 0xAB26DEEE120FD3FD,
        _0x082C043C7AFC3747 = 0x082C043C7AFC3747,
        _0xBB282CF5D2333FB8 = 0xBB282CF5D2333FB8,
        _0xAD44856A1CD29635 = 0xAD44856A1CD29635,
        _0x38C2BF94D15F464D = 0x38C2BF94D15F464D,
        _0x3A87FDA8F1B6CDFB = 0x3A87FDA8F1B6CDFB,
        _0x4647842FE8F31C1E = 0x4647842FE8F31C1E,
        _0x9B47971234169990 = 0x9B47971234169990,
        _0x96282005C5C6801F = 0x96282005C5C6801F,
        _0xF63FA29D4A9ACA86 = 0xF63FA29D4A9ACA86,
        _0x8C0F6A3D7236DEEB = 0x8C0F6A3D7236DEEB,
        _0x7FA58CED69405F9A = 0x7FA58CED69405F9A,
        _0xA08111B053D84B4D = 0xA08111B053D84B4D,
        _0x36040772DF5E59A0 = 0x36040772DF5E59A0,
        _0x0358B8A41916C613 = 0x0358B8A41916C613,
        _0xDBDA48EC456ED908 = 0xDBDA48EC456ED908,
    }
    public static class NATIVE_MISC_EXTENSIONS
    {
        public static void Call(this NATIVE_MISC hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_MISC hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}