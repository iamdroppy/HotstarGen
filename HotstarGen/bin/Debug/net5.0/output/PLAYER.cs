using System;
namespace Hotstar
{
    public enum NATIVE_PLAYER : ulong
    { 
        /// <summary>
        /// Does the same like PLAYER::GET_PLAYER_PED
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_PED_SCRIPT_INDEX = 0x5C880F9056D784C8,
        /// <summary>
        /// Make sure to request the model first and wait until it has loaded.
        ///
        /// > Player player
        /// > Hash modelHash
        /// > BOOL p2
        ///
        /// </summary>
        SET_PLAYER_MODEL = 0xED40380076A31506,
        /// <summary>
        /// Gets the player's team.
        /// Returns -1 in singleplayer.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_TEAM = 0xB464EB6A40C7975B,
        /// <summary>
        /// Sets the player's team.
        ///
        /// > Player player
        /// > int team
        /// > BOOL bRestrictToThisScript
        ///
        /// </summary>
        SET_PLAYER_TEAM = 0xE8DD8536F01DE600,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Player player
        /// > int wantedLevel
        /// > BOOL disableNoMission
        ///
        /// </summary>
        SET_PLAYER_WANTED_LEVEL = 0x384D4765395E006C,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Player player
        ///
        /// </summary>
        CLEAR_PLAYER_WANTED_LEVEL = 0x4E4B996C928C7AA6,
        /// <summary>
        /// If toggle is set to false:
        ///  The police won't be shown on the (mini)map
        /// 
        /// If toggle is set to true:
        ///  The police will be shown on the (mini)map
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_POLICE_RADAR_BLIPS = 0x6FD7DD6B63F2820E,
        /// <summary>
        /// Checks whether the specified player has a Ped, the Ped is not dead, is not injured and is not arrested.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_PLAYING = 0xBFFB35986CAAE58C,
        /// <summary>
        /// Gets a value indicating whether the specified player is currently aiming freely.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_FREE_AIMING = 0x936F967D4BE1CE9D,
        /// <summary>
        /// Gets a value indicating whether the specified player is currently aiming freely at the specified entity.
        ///
        /// > Player player
        /// > Entity entity
        ///
        /// </summary>
        IS_PLAYER_FREE_AIMING_AT_ENTITY = 0x8C67C11C68713D25,
        /// <summary>
        /// Affects the range of auto aim target.
        ///
        /// > Player player
        /// > float range
        ///
        /// </summary>
        SET_PLAYER_LOCKON_RANGE_OVERRIDE = 0x3A3CD06597388322,
        /// <summary>
        /// Sets whether this player can be hassled by gangs.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_CAN_BE_HASSLED_BY_GANGS = 0xC7FE774412046825,
        /// <summary>
        /// Sets whether this player can take cover.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_CAN_USE_COVER = 0x5EDA520F7A3BAF4E,
        /// <summary>
        /// Gets the maximum wanted level the player can get.
        /// Ranges from 0 to 5.
        ///
        ///
        /// </summary>
        GET_MAX_WANTED_LEVEL = 0xD04CFAD1E2B7984A,
        /// <summary>
        /// Returns the group ID the player is member of.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_GROUP = 0x9BAB31815159ABCF,
        /// <summary>
        /// Returns whether the player can control himself.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_CONTROL_ON = 0x7964097FCE4C244B,
        /// <summary>
        /// Returns TRUE if the player ('s ped) is climbing at the moment.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_CLIMBING = 0xB8A70C22FD48197A,
        /// <summary>
        /// Return true while player is being arrested / busted.
        /// 
        /// If atArresting is set to 1, this function will return 1 when player is being arrested (while player is putting his hand up, but still have control)
        /// 
        /// If atArresting is set to 0, this function will return 1 only when the busted screen is shown.
        ///
        /// > Player player
        /// > BOOL atArresting
        ///
        /// </summary>
        IS_PLAYER_BEING_ARRESTED = 0xC8183AE963C58374,
        /// <summary>
        /// Returns the same as PLAYER_ID and NETWORK_PLAYER_ID_TO_INT
        ///
        ///
        /// </summary>
        GET_PLAYER_INDEX = 0x47E385B0D957C8D4,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > int value
        ///
        /// </summary>
        INT_TO_PLAYERINDEX = 0x748B3A65C2604C33,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > int value
        ///
        /// </summary>
        INT_TO_PARTICIPANTINDEX = 0x58FF971FC8F2702C,
        /// <summary>
        /// This returns YOUR 'identity' as a Player type.
        /// 
        /// Always returns 0 in story mode.
        ///
        ///
        /// </summary>
        PLAYER_ID = 0x217E9DC48139933D,
        /// <summary>
        /// Returns current player ped
        ///
        ///
        /// </summary>
        PLAYER_PED_ID = 0x096275889B8E0EE0,
        /// <summary>
        /// Does exactly the same thing as PLAYER_ID()
        ///
        ///
        /// </summary>
        NETWORK_PLAYER_ID_TO_INT = 0x8A9386F0749A17FA,
        /// <summary>
        /// Simply sets you as invincible (Health will not deplete).
        /// 
        /// Use 0x733A643B5B0C53C1 instead if you want Ragdoll enabled, which is equal to:
        /// *(DWORD *)(playerPedAddress + 0x188) |= (1 << 9);
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_INVINCIBLE = 0xFEBEEBC9CBDF4B12,
        /// <summary>
        /// Returns the player's invincibility status.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_INVINCIBLE = 0x0CBBCB2CCFA7DC4E,
        /// <summary>
        /// Sets your targeting mode.
        /// 0 = Traditional GTA
        /// 1 = Assisted Aiming
        /// 2 = Free Aim
        ///
        /// > int targetMode
        ///
        /// </summary>
        SET_PLAYER_TARGETING_MODE = 0xD66A941F401E7302,
        /// <summary>
        /// This can be between 1.0f - 50.0f
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE = 0x5DA6500FE849DA16,
        /// <summary>
        /// Swim speed multiplier.
        /// Multiplier goes up to 1.49f
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_SWIM_MULTIPLIER_FOR_PLAYER = 0xBFCEABDE34DA5085,
        /// <summary>
        /// Inhibits the player from using any method of combat including melee and firearms.
        /// 
        /// NOTE: Only disables the firing for one frame
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        DISABLE_PLAYER_FIRING = 0x2970929FD5F9FC89,
        /// <summary>
        /// Disables the player's teleportation
        ///
        ///
        /// </summary>
        STOP_PLAYER_TELEPORT = 0x0858B86146601BE8,
        /// <summary>
        /// This modifies the damage value of your weapon. Whether it is a multiplier or base damage is unknown.
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_WEAPON_DAMAGE_MODIFIER = 0x94D529F7B73D7A85,
        /// <summary>
        /// Returns true if the player is riding a train.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_RIDING_TRAIN = 0x2FB0ACADA6A238DD,
        /// <summary>
        /// Max level is 5.
        ///
        /// > Player player
        /// > int level
        ///
        /// </summary>
        _SET_DEADEYE_ABILITY_LEVEL = 0xF0FE8E790BFEB5BB,
        /// <summary>
        /// // see personaabilities.meta
        /// enum ePersonaAbilityFlag
        /// {
        /// 	PERSONA_CAN_AUTOESCAPE_FROM_LASSO,
        /// 	PERSONA_HAT_BLOCKS_FIRST_HEADSHOT,
        /// 	PERSONA_FULL_AUTO_FOR_ALL_WEAPONS,
        /// 	PERSONA_MIGHT_LIVE_AFTER_DEADLY_DAMAGE,
        /// 	PERSONA_IGNORE_AIM_BEFORE_FIRING_RESTRICTIONS,
        /// 	PERSONA_DEADEYE_INSTANT_RELOAD,
        /// 	PERSONA_USE_PHOSPHOROUS_ROUNDS,
        /// 	PERSONA_CONT_DEADEYE_ON_TAKING_COVER,
        /// 	PERSONA_CONT_DEADEYE_ON_RELOAD,
        /// 	PERSONA_CONT_DEADEYE_ON_SHOOTING,
        /// 	PERSONA_CONT_DEADEYE_ON_EXITING_AIM,
        /// 	PERSONA_DISABLE_PLAYER_CANCELLING_DEADEYE,
        /// 	PERSONA_CONT_DEADEYE_ON_RAGDOLL,
        /// 	PERSONA_USE_EXPLOSIVE_ROUNDS,
        /// 	PERSONA_EXIT_DEADEYE_ON_TAKING_DAMAGE,
        /// 	PERSONA_CARRY_TWO_MONEYBAGS,
        /// 	PERSONA_ABILITY_LONG_PICK_HERBS,
        /// 	PERSONA_ABILITY_UNBREAKABLE_LASSO,
        /// 	PERSONA_CONT_DEADEYE_ON_SPRINTING,
        /// 	PERSONA_CANT_DEAL_HEADSHOTS,
        /// 	PERSONA_HANGMAN,
        /// 	PERSONA_ALLOW_DEADEYE_WITH_MELEE_WEAPONS,
        /// 	PERSONA_ALLOW_DEADEYE_WHILE_UNARMED,
        /// 	PERSONA_DISABLE_DEADEYE_PERFECT_ACCURACY,
        /// 	PERSONA_CANT_DEAL_HEADSHOTS_TO_PLAYERS,
        /// 	PERSONA_CANT_DEAL_CRITICAL_DAMAGE,
        /// 	PERSONA_CANT_DEAL_CRITICAL_DAMAGE_TO_PLAYERS,
        /// 	PERSONA_ALLOW_EAGLEEYE_IN_COMBAT,
        /// 	PERSONA_CONT_EAGLEEYE_ON_SPRINT,
        /// 	PERSONA_SUPPRESS_LENGENDARY_EAGLEEYE_TRAIL_COLOR
        /// };
        ///
        /// > int flagId
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_LOCAL_PLAYER_PERSONA_ABILITY_FLAG = 0x7146CF430965927C,
        /// <summary>
        /// Returns true if the given player has a valid ped.
        ///
        /// > Player player
        ///
        /// </summary>
        _0x0760D6F70EBCC05C = 0x0760D6F70EBCC05C,
        /// <summary>
        /// Params: p1 is mostly 34, p2 = 0
        ///
        /// > Player player
        /// > int p1
        /// > int p2
        /// > BOOL enabled
        ///
        /// </summary>
        _0x0751D461F06E41CE = 0x0751D461F06E41CE,
        /// <summary>
        /// SET_PLAYER_S/T*
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        _0x8591EE69CC3ED257 = 0x8591EE69CC3ED257,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0x77B0B6D17A3AC9AA = 0x77B0B6D17A3AC9AA,
        /// <summary>
        /// GET_PLAYER_*
        ///
        /// > Player player
        /// > int p1
        /// > BOOL p2
        ///
        /// </summary>
        _0xFB6EB8785F808551 = 0xFB6EB8785F808551,
        /// <summary>
        /// Only applies to HUNTERCART01
        ///
        /// > Player player
        /// > Vehicle wagon
        ///
        /// </summary>
        _0x6A4404BDFA62CE2C = 0x6A4404BDFA62CE2C,
        /// <summary>
        /// p0: mostly Ped Hashes
        ///
        /// > Hash p0
        /// > BOOL model
        /// > BOOL outfit
        ///
        /// </summary>
        _0x8E84119A23C16623 = 0x8E84119A23C16623,
        /// <summary>
        /// Hardcoded to return zero/false.
        ///
        ///
        /// </summary>
        _0x0B7803F6F7BB43E0 = 0x0B7803F6F7BB43E0,
        /// <summary>
        /// Hardcoded to return zero/false.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xC74EB3F2EC169F6B = 0xC74EB3F2EC169F6B,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0x3B296934DB026873 = 0x3B296934DB026873,
        GET_PLAYER_PED = 0x275F255ED201B937,
        _GET_PLAYER_PED_2 = 0x5EBE38A20BC51C27,
        GET_PLAYER_NAME = 0x7124FD9AC0E01BA0,
        _FORMAT_PLAYER_NAME_STRING = 0x5B6193813E03E4E9,
        GET_WANTED_LEVEL_RADIUS = 0x80B00EB26D9521C7,
        GET_WANTED_LEVEL_THRESHOLD = 0x1B1A3B358F7D8F07,
        IS_PLAYER_WANTED_LEVEL_GREATER = 0xE1C0AD4C24324C36,
        IS_PLAYER_DEAD = 0x2E9C3FCB6798F397,
        SET_PLAYER_CONTROL = 0x4D51E59243281D80,
        GET_PLAYER_WANTED_LEVEL = 0xABC532F9098BFD9D,
        SET_MAX_WANTED_LEVEL = 0x28A4BD2CEE236E19,
        _SET_MAX_WANTED_LEVEL_2 = 0xEA6DE0CD15AECBE2,
        SET_EVERYONE_IGNORE_PLAYER = 0x34630A768925B852,
        GET_IS_PLAYER_UI_PROMPT_ACTIVE = 0x51BEA356B1C60225,
        SET_ALL_RANDOM_PEDS_FLEE = 0xE705309B8C6445A4,
        SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME = 0xD5C198A62F1DEB0A,
        SET_WANTED_LEVEL_MULTIPLIER = 0xD7FA719CB54866C2,
        RESET_WANTED_LEVEL_DIFFICULTY = 0x062D14F18E8B0CAE,
        REPORT_POLICE_SPOTTED_PLAYER = 0xCBCCF73FFA69CC6B,
        CAN_PLAYER_START_MISSION = 0x2DF170B1185AF777,
        IS_PLAYER_READY_FOR_CUTSCENE = 0xAA67BCB0097F2FA3,
        IS_PLAYER_TARGETTING_ENTITY = 0x27F89FDC16688A7A,
        GET_PLAYER_TARGET_ENTITY = 0xAE663DDD99C8A670,
        _IS_PLAYER_FREE_FOCUSING = 0x1A51BFE60708E482,
        GET_PLAYER_INTERACTION_TARGET_ENTITY = 0x3EE1F7A8C32F24E1,
        GET_ENTITY_PLAYER_IS_FREE_AIMING_AT = 0xA6817C110B830EAD,
        _SET_PLAYER_CAN_MERCY_KILL = 0x39363DFD04E91496,
        IS_PLAYER_TARGETTING_ANYTHING = 0x4605C66E0F935F83,
        RESTORE_PLAYER_STAMINA = 0xC41F4B6E23FE6A4A,
        IS_PLAYER_SCRIPT_CONTROL_ON = 0xB78350754157C00F,
        RESET_PLAYER_ARREST_STATE = 0x12917931C31F1750,
        GET_PLAYERS_LAST_VEHICLE = 0x2F96E7720B0B19EA,
        HAS_FORCE_CLEANUP_OCCURRED = 0xC11469DCA6FC3BB5,
        FORCE_CLEANUP = 0x768C017FB878E4F4,
        FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME = 0xDAACAF8B687F2353,
        FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID = 0xF4C9512A2F0A3031,
        GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP = 0x84E8E29EBD4A46D2,
        SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE = 0xDA35A134038557EC,
        SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE = 0xBEC463B3A11C909E,
        IS_SYSTEM_UI_BEING_DISPLAYED = 0x908258B6209E71F7,
        SET_PLAYER_LOCKON = 0x462AA1973CBBA75E,
        CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED = 0x270B63A641BE32F2,
        HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED = 0xDA4A4B9B96E20092,
        CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED = 0x0361096D6CE4372C,
        HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED = 0x16C8D205DD5A2E90,
        SET_PLAYER_FORCED_AIM = 0xD5FCC166AEB2FD0F,
        _GET_PLAYER_HEALTH = 0x0317C947D062854E,
        _GET_PLAYER_STAMINA = 0x0FF421E467373FCF,
        START_PLAYER_TELEPORT = 0xDF8822C55EDDA65B,
        UPDATE_PLAYER_TELEPORT = 0xC39DCE4672CBFBC1,
        IS_PLAYER_TELEPORT_ACTIVE = 0x085EEAEB8783FEB5,
        GET_PLAYER_CURRENT_STEALTH_NOISE = 0xD7ECC25E176ECBA5,
        SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER = 0x8899C244EBCF70DE,
        SET_PLAYER_STAMINA_RECHARGE_MULTIPLIER = 0xFECA17CF3343694B,
        _SET_PED_AS_SADDLE_HORSE_FOR_PLAYER = 0xD2CB0FB0FDCB473D,
        _GET_SADDLE_HORSE_FOR_PLAYER = 0xB48050D326E9A2F3,
        SET_PED_AS_TEMP_PLAYER_HORSE = 0x227B06324234FB09,
        BOOST_PLAYER_HORSE_SPEED_FOR_TIME = 0x09C28F828EE674FA,
        SET_PLAYER_WEAPON_DEFENSE_MODIFIER = 0xD15CC2D493160BE3,
        SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER = 0xE4CB5A3F18170381,
        SET_PLAYER_WEAPON_TYPE_DAMAGE_MODIFIER = 0xD04AD186CE8BB129,
        SET_PLAYER_NOISE_MULTIPLIER = 0xB5EC6BDAEBCA454C,
        SET_PLAYER_SNEAKING_NOISE_MULTIPLIER = 0x4DE44FA389DCA565,
        SIMULATE_PLAYER_INPUT_GAIT = 0xFA0C063C422C4355,
        RESET_PLAYER_INPUT_GAIT = 0x61A2EECAB274829B,
        SET_PLAYER_SIMULATE_AIMING = 0xE0447DEF81CCDFD2,
        SET_PLAYER_CLOTH_PIN_FRAMES = 0xD0D9317DFEEF9A66,
        HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE = 0xC932F57F31EA9152,
        _GET_DEADEYE_ABILITY_LEVEL = 0xCCE7C695C164C35F,
        _IS_DEADEYE_ABILITY_LOCKED = 0x8A0643B0B4CA276B,
        _SET_DEADEYE_ABILITY_LOCKED = 0x2797B8D66DD0EBB8,
        EAGLE_EYE_SET_CUSTOM_ENTITY_TINT = 0x62ED71E133B6C9F1,
        GET_MOUNT_OWNED_BY_PLAYER = 0xF49F14462F0AE27C,
        _GET_PLAYER_OWNER_OF_MOUNT = 0xAD03B03737CE6810,
        _GET_VEHICLE_OWNED_BY_PLAYER = 0xB9050A97594C8832,
        _GET_PLAYER_OWNER_OF_VEHICLE = 0x7C803BDC8343228D,
        _SET_PLAYER_OWNS_VEHICLE = 0xD0E02AA618020D17,
        GET_DISCOVERABLE_NAME_HASH_AND_TYPE_FOR_ENTITY = 0x0139637A3BFF8B6D,
        GET_TARGET_CHARACTER_NAME_SCRIPT_OVERRIDE_HASH = 0x0335106F3ACABBED,
        GET_TARGET_CHARACTER_NAME_SCRIPT_OVERRIDE_RAW_STRING = 0x755E08680F21EF30,
        GET_TARGET_CHARACTER_NAME_FOR_LOCAL_PLAYER = 0x36E3D8B5A6552FE8,
        GET_HAS_PLAYER_DISCOVERED_CHARACTER_NAME_MP = 0x354F689C4FFAAB37,
        _0x325434C68358D282 = 0x325434C68358D282,
        _0x6614F9039BD31931 = 0x6614F9039BD31931,
        _0xA3DB37EDF9A74635 = 0xA3DB37EDF9A74635,
        _0xEA8F168A76A0B9BC = 0xEA8F168A76A0B9BC,
        _0x93624B36E8851B42 = 0x93624B36E8851B42,
        _0x9073EC5456651A90 = 0x9073EC5456651A90,
        _0x2E67707BEC52CA4B = 0x2E67707BEC52CA4B,
        _0x16752DAA7E6D3F72 = 0x16752DAA7E6D3F72,
        _0x1D256EED194F5B58 = 0x1D256EED194F5B58,
        _0x5B7B97E99F84138B = 0x5B7B97E99F84138B,
        _0x8674D138391FFB1B = 0x8674D138391FFB1B,
        _0xA82964B9D8D6A983 = 0xA82964B9D8D6A983,
        _0xD0B0B044112BF424 = 0xD0B0B044112BF424,
        _0x96722257E5381E00 = 0x96722257E5381E00,
        _0xD2DFC9CCA5596A11 = 0xD2DFC9CCA5596A11,
        _0x5CE5CACC01D0F985 = 0x5CE5CACC01D0F985,
        _0x927861B2C08DBEA5 = 0x927861B2C08DBEA5,
        _0xBEA3A6E5F5F79A6F = 0xBEA3A6E5F5F79A6F,
        _0x04D7F33640662FA2 = 0x04D7F33640662FA2,
        _0x3DAABE78A23694BC = 0x3DAABE78A23694BC,
        _0x7AE93C45EC14A166 = 0x7AE93C45EC14A166,
        _0xD1A70C1E8D1031FE = 0xD1A70C1E8D1031FE,
        _0xACA45DDCEF6071C4 = 0xACA45DDCEF6071C4,
        _0xA0C683284DF027C7 = 0xA0C683284DF027C7,
        _0x4EC8BE63B8A5D4EF = 0x4EC8BE63B8A5D4EF,
        _0x3D9DA5C9EFD20D88 = 0x3D9DA5C9EFD20D88,
        _0x2BEED53B912537D0 = 0x2BEED53B912537D0,
        _0x908D4B72854C8F62 = 0x908D4B72854C8F62,
        _0xD1F6B912785BFD35 = 0xD1F6B912785BFD35,
        _0xC4873B053054C04B = 0xC4873B053054C04B,
        _0xCA59808E51FD67C4 = 0xCA59808E51FD67C4,
        _0xBA5CA1FEB5DE0DF6 = 0xBA5CA1FEB5DE0DF6,
        _0x0869D499A7848309 = 0x0869D499A7848309,
        _0xB331D8A73F9D2BDF = 0xB331D8A73F9D2BDF,
        _0xAC22AA6DF4D1C1DE = 0xAC22AA6DF4D1C1DE,
        _0x0C6B89876262A99D = 0x0C6B89876262A99D,
        _0x12E09E278C6C29B7 = 0x12E09E278C6C29B7,
        _0xDD33A82352C4652F = 0xDD33A82352C4652F,
        _0x1FDA57E8908F2609 = 0x1FDA57E8908F2609,
        _0x84481018E668E1B8 = 0x84481018E668E1B8,
        _0x2009F8AB7A5E9D6D = 0x2009F8AB7A5E9D6D,
        _0xE24C64D9ADED2EF5 = 0xE24C64D9ADED2EF5,
        _0xE7F8707269544B29 = 0xE7F8707269544B29,
        _0xE631EAF35828FA67 = 0xE631EAF35828FA67,
        _0x086549F3B0381CB1 = 0x086549F3B0381CB1,
        _0xEBB6E27AC2FF32DA = 0xEBB6E27AC2FF32DA,
        _0xB15CD2F9932C9AB5 = 0xB15CD2F9932C9AB5,
        _0x621D1B289CAF5978 = 0x621D1B289CAF5978,
        _0xCBB54CC7FFFFAB86 = 0xCBB54CC7FFFFAB86,
        _0xBED386157F65942C = 0xBED386157F65942C,
        _0xDAB6A2FC56B7DE65 = 0xDAB6A2FC56B7DE65,
        _0x0F4EAF69DA41AF43 = 0x0F4EAF69DA41AF43,
        _0x6ADF821FBF21920E = 0x6ADF821FBF21920E,
        _0x8F2A81C09DA9124A = 0x8F2A81C09DA9124A,
        _0x39BED552DB46FFA9 = 0x39BED552DB46FFA9,
        _0x054473164C012699 = 0x054473164C012699,
        _0xC71D07C96946E263 = 0xC71D07C96946E263,
        _0xD48227263E3D06AE = 0xD48227263E3D06AE,
        _0x3946FC742AC305CD = 0x3946FC742AC305CD,
        _0xA28056CD1B04B250 = 0xA28056CD1B04B250,
        _0xC67A4910425F11F1 = 0xC67A4910425F11F1,
        _0x4A056257802DD3E5 = 0x4A056257802DD3E5,
        _0x19B4F71703902238 = 0x19B4F71703902238,
        _0x747257807B8721CE = 0x747257807B8721CE,
        _0x8702D9150D9FBB3D = 0x8702D9150D9FBB3D,
        _0xCB0B9506BC91E441 = 0xCB0B9506BC91E441,
        _0xEACEBAAE0A33FB3F = 0xEACEBAAE0A33FB3F,
        _0x72AD59F7B7FB6E24 = 0x72AD59F7B7FB6E24,
        _0x1A6E84F13C952094 = 0x1A6E84F13C952094,
        _0x78B3D19AF6391A55 = 0x78B3D19AF6391A55,
        _0x1F488807BC8E0630 = 0x1F488807BC8E0630,
        _0x73EB2EF2E92D23BF = 0x73EB2EF2E92D23BF,
        _0x310CE349E0C0EC4B = 0x310CE349E0C0EC4B,
        _0xEBFF94328FF7A18A = 0xEBFF94328FF7A18A,
        _0xF993373285053D77 = 0xF993373285053D77,
        _0xE956C2340A76272E = 0xE956C2340A76272E,
        _0x95EE1DEE1DCD9070 = 0x95EE1DEE1DCD9070,
        _0xDE6C85975F9D4894 = 0xDE6C85975F9D4894,
        _0xBBA140062B15A8AC = 0xBBA140062B15A8AC,
        _0xAE637BB8EF017875 = 0xAE637BB8EF017875,
        _0xB16223CB7DA965F0 = 0xB16223CB7DA965F0,
        _0x28A13BF6B05C3D83 = 0x28A13BF6B05C3D83,
        _0xC0B21F235C02139C = 0xC0B21F235C02139C,
        _0x51345AE20F22C261 = 0x51345AE20F22C261,
        _0xFA437FA0738C370C = 0xFA437FA0738C370C,
        _0x2498035289B5688F = 0x2498035289B5688F,
        _0x811A748B1BE231BA = 0x811A748B1BE231BA,
        _0x029884FB65821B07 = 0x029884FB65821B07,
        _0x200114E99552462B = 0x200114E99552462B,
        _0x1D77B47AFA584E90 = 0x1D77B47AFA584E90,
        _0x5A498FCA232F71E1 = 0x5A498FCA232F71E1,
        _0xAB3773E7AA1E9DCC = 0xAB3773E7AA1E9DCC,
        _0x00BA333DA05ADC23 = 0x00BA333DA05ADC23,
        _0x22B3CABEDDB538B2 = 0x22B3CABEDDB538B2,
        _0xB783F75940B23014 = 0xB783F75940B23014,
        _0xC0B1C05B313693D1 = 0xC0B1C05B313693D1,
        _0x57D9991DC1334151 = 0x57D9991DC1334151,
        _0x21091B4BEB6376EE = 0x21091B4BEB6376EE,
        _0xAE4BCC79C587EBBF = 0xAE4BCC79C587EBBF,
        _0x4D1699543B1C023C = 0x4D1699543B1C023C,
        _0x3A6AE4EEE30370FE = 0x3A6AE4EEE30370FE,
        _0xA81D24AE0AF99A5E = 0xA81D24AE0AF99A5E,
        _0xDF66A37936D5F3D9 = 0xDF66A37936D5F3D9,
        _0x592F58BC4D2A2CF3 = 0x592F58BC4D2A2CF3,
        _0x768E81AE285A4B67 = 0x768E81AE285A4B67,
        _0x0E1DB1F8F5B561DC = 0x0E1DB1F8F5B561DC,
        _0x08E22898A6AF4905 = 0x08E22898A6AF4905,
        _0xBEFED69CE8317F91 = 0xBEFED69CE8317F91,
        _0xA63FCAD3A6FEC6D2 = 0xA63FCAD3A6FEC6D2,
        _0xE022CC1B545F1D9F = 0xE022CC1B545F1D9F,
        _0x1710BC33CFB83634 = 0x1710BC33CFB83634,
        _0x64FF4BF9AF59E139 = 0x64FF4BF9AF59E139,
        _0x45AB66D02B601FA7 = 0x45AB66D02B601FA7,
        _0x107F2A66E1C4C83A = 0x107F2A66E1C4C83A,
        _0x2C2D287748E8E9B7 = 0x2C2D287748E8E9B7,
        _0x22CD23BB0C45E0CD = 0x22CD23BB0C45E0CD,
        _0x535ED4605F89AB6E = 0x535ED4605F89AB6E,
        _0x617D3494AD58200F = 0x617D3494AD58200F,
        _0xBBADFB5E5E5766FB = 0xBBADFB5E5E5766FB,
        _0x68A0389E0718AC8F = 0x68A0389E0718AC8F,
        _0x8FBF9EDB378CCB8C = 0x8FBF9EDB378CCB8C,
        _0x46FA0AE18F4C7FA9 = 0x46FA0AE18F4C7FA9,
        _0xD3F7445CEA2E5035 = 0xD3F7445CEA2E5035,
        _0xDF93973251FB2CA5 = 0xDF93973251FB2CA5,
        _0x694FFA4308060CD1 = 0x694FFA4308060CD1,
        _0x818241B3EDA84191 = 0x818241B3EDA84191,
        _0x2D3ACE3DE0A2B622 = 0x2D3ACE3DE0A2B622,
        _0x83C989D5B5B5B466 = 0x83C989D5B5B5B466,
        _0x03B4B759A8990505 = 0x03B4B759A8990505,
        _0x67659A8F248E0141 = 0x67659A8F248E0141,
        _0xB427911EA6DFFEF3 = 0xB427911EA6DFFEF3,
        _0x914071FF93AF2692 = 0x914071FF93AF2692,
        _0x2E78D822208E740A = 0x2E78D822208E740A,
        _0x19B2C7A6C34FAD54 = 0x19B2C7A6C34FAD54,
        _0x9422743A5BA50E10 = 0x9422743A5BA50E10,
        _0x497A6539BB0E8787 = 0x497A6539BB0E8787,
        _0x93F499CAE53FCD05 = 0x93F499CAE53FCD05,
        _0xFE0304050261442C = 0xFE0304050261442C,
        _0x5C2E5E3CAEEB1F58 = 0x5C2E5E3CAEEB1F58,
        _0xFC79DCC94D0A5897 = 0xFC79DCC94D0A5897,
        _0x59F0AFF3E0A1B019 = 0x59F0AFF3E0A1B019,
        _0xAF341032E97FB061 = 0xAF341032E97FB061,
        _0x43F50A7CD2482156 = 0x43F50A7CD2482156,
        _0x967FF5BC0CFE6D26 = 0x967FF5BC0CFE6D26,
        _0x4EA69188FBCE6A7D = 0x4EA69188FBCE6A7D,
        _0xDEE80FEDFDD43C9B = 0xDEE80FEDFDD43C9B,
        _0x3AD212429E095EFB = 0x3AD212429E095EFB,
        _0x113EF458AB6CDA67 = 0x113EF458AB6CDA67,
        _0x5B9813ECF7633FE8 = 0x5B9813ECF7633FE8,
        _0x9AFCF9FE1884BF62 = 0x9AFCF9FE1884BF62,
        _0x1E8099F449ABB0BA = 0x1E8099F449ABB0BA,
        _0x6B5DDFB967E5073D = 0x6B5DDFB967E5073D,
        _0x32348719DCED2969 = 0x32348719DCED2969,
        _0x3C4AE8506638C7E2 = 0x3C4AE8506638C7E2,
        _0x51139D8C17B16FBC = 0x51139D8C17B16FBC,
        _0x8F44EBB3BA8F6D44 = 0x8F44EBB3BA8F6D44,
        _0x83FCD6921FC8FD05 = 0x83FCD6921FC8FD05,
        _0xE92261BD28C0878F = 0xE92261BD28C0878F,
        _0x870634493CB4372C = 0x870634493CB4372C,
        _0xA54000D4BFD90BDE = 0xA54000D4BFD90BDE,
        _0x6EDB5D08CB03E763 = 0x6EDB5D08CB03E763,
        _0x27AD7162D3FED01E = 0x27AD7162D3FED01E,
        _0xCCD9B77F70D31C9D = 0xCCD9B77F70D31C9D,
        _0xC93A9A45430D484E = 0xC93A9A45430D484E,
        _0x570A13A4CA2799BB = 0x570A13A4CA2799BB,
        _0x3ACAC8832E77BC93 = 0x3ACAC8832E77BC93,
        _0x2B12B6FC8B8772AB = 0x2B12B6FC8B8772AB,
        _0xE910932F4B30BE23 = 0xE910932F4B30BE23,
        _0x131E294EF60160DF = 0x131E294EF60160DF,
        _0x0E9057A9DA78D0F8 = 0x0E9057A9DA78D0F8,
        _0x263D69767F76059C = 0x263D69767F76059C,
        _0x543DFE14BE720027 = 0x543DFE14BE720027,
        _0xAC67098A1E54ABB0 = 0xAC67098A1E54ABB0,
        _0x9DAE1380CC5C6451 = 0x9DAE1380CC5C6451,
        _0x9A957912CE2EABD1 = 0x9A957912CE2EABD1,
        _0xE5D3EB37ABC1EB03 = 0xE5D3EB37ABC1EB03,
        _0x0E6846476906C9DD = 0x0E6846476906C9DD,
        _0x6852288340B43239 = 0x6852288340B43239,
        _0xE50A67C33514A390 = 0xE50A67C33514A390,
        _0xD288E02E364972D2 = 0xD288E02E364972D2,
        _0x40AB73092C95B5F5 = 0x40AB73092C95B5F5,
        _0x6ECFC621A168424C = 0x6ECFC621A168424C,
        _0xDC5E09D012D759C4 = 0xDC5E09D012D759C4,
        _0x00B156AFEBCC5AE0 = 0x00B156AFEBCC5AE0,
        _0xC58CE6824E604DEC = 0xC58CE6824E604DEC,
        _0x330CA55A3647FA1C = 0x330CA55A3647FA1C,
        _0xA62BBAAE67A05BB0 = 0xA62BBAAE67A05BB0,
        _0x2C41D93F550D5E37 = 0x2C41D93F550D5E37,
        _0x22C8B10802301381 = 0x22C8B10802301381,
        _0xE0D6C2A146A5C993 = 0xE0D6C2A146A5C993,
        _0x06E1FB78B1E59CA5 = 0x06E1FB78B1E59CA5,
        _0xCE285A4413B00B7F = 0xCE285A4413B00B7F,
        _0x3813E11A378958A5 = 0x3813E11A378958A5,
        _0x2AF423D6ECB2C485 = 0x2AF423D6ECB2C485,
        _0x0F9CF06986300875 = 0x0F9CF06986300875,
        _0xDFC85C5199045026 = 0xDFC85C5199045026,
        _0x6FA957D1B55941C1 = 0x6FA957D1B55941C1,
        _0x1DA5C5B0923E1B85 = 0x1DA5C5B0923E1B85,
        _0xAAED694CE814817F = 0xAAED694CE814817F,
        _0xBC02B3D151D3859F = 0xBC02B3D151D3859F,
        _0x907B16B3834C69E2 = 0x907B16B3834C69E2,
        _0xF21C7A3F3FFBA629 = 0xF21C7A3F3FFBA629,
        _0x292F0B6EDC82E3A4 = 0x292F0B6EDC82E3A4,
        _0xE133C1EC5300F740 = 0xE133C1EC5300F740,
        _0xC900A465364A85D6 = 0xC900A465364A85D6,
        _0xCFB2EED4FCB7BD77 = 0xCFB2EED4FCB7BD77,
        _0x2BB8D58E88777499 = 0x2BB8D58E88777499,
        _0x00EB5A760638DB55 = 0x00EB5A760638DB55,
        _0x65887EAC535A0B0C = 0x65887EAC535A0B0C,
        _0x11A7FF918EF6BC66 = 0x11A7FF918EF6BC66,
        _0xBE0C524970892D41 = 0xBE0C524970892D41,
        _0xFE7C9CF376D23342 = 0xFE7C9CF376D23342,
        _0x7761A30432C91297 = 0x7761A30432C91297,
        _0x5006C36652D6EC56 = 0x5006C36652D6EC56,
        _0xED591CB17C8BA216 = 0xED591CB17C8BA216,
        _0x1F0E3A4434565F8F = 0x1F0E3A4434565F8F,
        _0x6C54E69516CC56BD = 0x6C54E69516CC56BD,
        _0x3A8611BD7BDE84F7 = 0x3A8611BD7BDE84F7,
        _0xC177C827CEFC0AA4 = 0xC177C827CEFC0AA4,
        _0xBD96185264DDAAEA = 0xBD96185264DDAAEA,
        _0x628E742FE1F79C4A = 0x628E742FE1F79C4A,
        _0xC6366A585659D15C = 0xC6366A585659D15C,
        _0x98CD760DE43B612E = 0x98CD760DE43B612E,
        _0x216BC0D3D2E413D2 = 0x216BC0D3D2E413D2,
        _0x45EF176B532CA851 = 0x45EF176B532CA851,
        _0xA342495F93B7B838 = 0xA342495F93B7B838,
        _0x3BB84F812E052C90 = 0x3BB84F812E052C90,
        _0x9FC5A003FB76EDBD = 0x9FC5A003FB76EDBD,
        _0x0FAF95D71ED67ADE = 0x0FAF95D71ED67ADE,
        _0x988C9045531B9FCE = 0x988C9045531B9FCE,
        _0x06C3DB00B69D5435 = 0x06C3DB00B69D5435,
        _0xBB6EA5D59E926095 = 0xBB6EA5D59E926095,
        _0xE1D356F5A66D0FFA = 0xE1D356F5A66D0FFA,
        _0x929DDD5538F3DF1F = 0x929DDD5538F3DF1F,
        _0xFA7DAAE3959E6C7B = 0xFA7DAAE3959E6C7B,
        _0x9461A8FAB0378E5B = 0x9461A8FAB0378E5B,
        _0xCB61A63AA53D7D22 = 0xCB61A63AA53D7D22,
        _0xCFFC3ECCD7A5CCEB = 0xCFFC3ECCD7A5CCEB,
        _0x76F7E1BCD623A429 = 0x76F7E1BCD623A429,
        _0x585CE159DB46FADB = 0x585CE159DB46FADB,
        _0x9F9A829C6751F3C7 = 0x9F9A829C6751F3C7,
        _0xFE691E89C08937B6 = 0xFE691E89C08937B6,
        _0xE6D4E435B56D5BD0 = 0xE6D4E435B56D5BD0,
        _0x5CA6BBD4A7D8145E = 0x5CA6BBD4A7D8145E,
        _0x9044835BE9D9DBFE = 0x9044835BE9D9DBFE,
        _0xDA9D7BE231FE865F = 0xDA9D7BE231FE865F,
        _0x946D46CD6DFB9742 = 0x946D46CD6DFB9742,
        _0x0772F87D7B07719A = 0x0772F87D7B07719A,
        _0xCDDD4B74660E2335 = 0xCDDD4B74660E2335,
        _0x77E83C315A3B31CA = 0x77E83C315A3B31CA,
        _0x7C32191D9FB2BDEA = 0x7C32191D9FB2BDEA,
        _0xFB0E622B401884D3 = 0xFB0E622B401884D3,
        _0xDC68829BB3F37023 = 0xDC68829BB3F37023,
        _0x4DBC4873707E8FD6 = 0x4DBC4873707E8FD6,
        _0xCEDC16930526F728 = 0xCEDC16930526F728,
        _0x14E57F88BA0A07FC = 0x14E57F88BA0A07FC,
        _0x2E1ABE627C95ED9B = 0x2E1ABE627C95ED9B,
        _0x497A18F8F88AA9D8 = 0x497A18F8F88AA9D8,
        _0x4F0D2256AAE94EDA = 0x4F0D2256AAE94EDA,
        _0x5F8E0303C229C84B = 0x5F8E0303C229C84B,
        _0x506CE71FB6E8CF5E = 0x506CE71FB6E8CF5E,
        _0xF4CB347D7B5EB0FD = 0xF4CB347D7B5EB0FD,
        _0xCD7CA3013FD12749 = 0xCD7CA3013FD12749,
        _0xE5A3DD2FF84E1A4B = 0xE5A3DD2FF84E1A4B,
        _0x57028FD99886F6F9 = 0x57028FD99886F6F9,
        _0x35A33783EC3C3448 = 0x35A33783EC3C3448,
        _0x39D8D7082BC34B72 = 0x39D8D7082BC34B72,
        _0x1AD8AD999C27F44A = 0x1AD8AD999C27F44A,
    }
    public static class NATIVE_PLAYER_EXTENSIONS
    {
        public static void Call(this NATIVE_PLAYER hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PLAYER hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}