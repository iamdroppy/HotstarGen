using System;
namespace Hotstar
{
    public enum NATIVE_WEAPON : ulong
    { 
        /// <summary>
        /// addReason:
        /// enum eAddItemReason : Hash
        /// {
        /// 	ADD_REASON_AWARDS = 0xB784AD1E,
        /// 	ADD_REASON_CREATE_CHARACTER = 0xE2C4FF71,
        /// 	ADD_REASON_DEBUG = 0x5C05C64D,
        /// 	ADD_REASON_DEFAULT = 0x2CD419DC,
        /// 	ADD_REASON_GET_INVENTORY = 0xD8188685,
        /// 	ADD_REASON_INCENTIVE = 0x8ADC2E95,
        /// 	ADD_REASON_LOADOUT = 0xCA3454E6,
        /// 	ADD_REASON_LOAD_SAVEGAME = 0x56212906,
        /// 	ADD_REASON_LOOTED = 0xCA806A55,
        /// 	ADD_REASON_MELEE = 0x7B9BDCE7,
        /// 	ADD_REASON_MP_MISSION = 0xEC0E0194,
        /// 	ADD_REASON_NOTIFICATION = 0xC56292D2,
        /// 	ADD_REASON_PICKUP = 0x1A770E22,
        /// 	ADD_REASON_PURCHASED = 0x4A6726C9,
        /// 	ADD_REASON_SET_AMOUNT = 0x4504731E,
        /// 	ADD_REASON_SYNCING = 0x8D4B4FF4,
        /// 	ADD_REASON_USE_FAILED = 0xD385B670
        /// };
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int amount
        /// > Hash addReason
        ///
        /// </summary>
        _ADD_AMMO_TO_PED = 0xB190BCA3F4042F95,
        /// <summary>
        /// addReason: see _ADD_AMMO_TO_PED
        ///
        /// > Ped ped
        /// > Hash ammoType
        /// > int amount
        /// > Hash addReason
        ///
        /// </summary>
        _ADD_AMMO_TO_PED_BY_TYPE = 0x106A811C6D3035F3,
        /// <summary>
        /// removeReason must be REMOVE_REASON_USED, REMOVE_REASON_GIVEN, REMOVE_REASON_DROPPED or REMOVE_REASON_DEBUG, unless amount is -1
        /// 
        /// removeReason: see REMOVE_WEAPON_FROM_PED
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int amount
        /// > Hash removeReason
        ///
        /// </summary>
        _REMOVE_AMMO_FROM_PED = 0xF4823C813CB8277D,
        /// <summary>
        /// removeReason must be REMOVE_REASON_USED, REMOVE_REASON_GIVEN, REMOVE_REASON_DROPPED or REMOVE_REASON_DEBUG, unless amount is -1
        /// 
        /// removeReason: see REMOVE_WEAPON_FROM_PED
        ///
        /// > Ped ped
        /// > Hash ammoHash
        /// > int amount
        /// > Hash removeReason
        ///
        /// </summary>
        _REMOVE_AMMO_FROM_PED_BY_TYPE = 0xB6CFEC32E3742779,
        /// <summary>
        /// Returns the current ammo type of the specified ped's specified weapon.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        GET_PED_AMMO_TYPE_FROM_WEAPON = 0x7FEAD38B326B9F74,
        /// <summary>
        /// Gets the model hash from the weapon hash.
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        _GET_WEAPONTYPE_MODEL = 0xF70825EB340E7D15,
        /// <summary>
        /// Gives the ped the weapon.
        /// For a list of weapon groups, here is a weapons enum by Mooshe with all weapon-related hashes: https://pastebin.com/n72eW6zd
        /// 
        /// attachPoint: see SET_CURRENT_PED_WEAPON
        /// addReason: see _ADD_AMMO_TO_PED
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int ammoCount
        /// > BOOL bForceInHand
        /// > BOOL bForceInHolster
        /// > int attachPoint
        /// > BOOL bAllowMultipleCopies
        /// > float p7
        /// > float p8
        /// > Hash addReason
        /// > BOOL bIgnoreUnlocks
        /// > float permanentDegradation
        /// > BOOL p12
        ///
        /// </summary>
        GIVE_WEAPON_TO_PED = 0x5E3BDDBCB83F3D84,
        /// <summary>
        /// Unequip current weapon and set current weapon to WEAPON_UNARMED.
        /// p0 usually 2 in R* scripts. Doesn't seem to have any effect if changed....
        /// immediately: if true it will instantly switch to unarmed
        ///
        /// > Ped ped
        /// > int p0
        /// > BOOL immediately
        ///
        /// </summary>
        _HIDE_PED_WEAPONS = 0xFCCC886EDE3C63EC,
        /// <summary>
        /// attachPoint:
        /// enum eWeaponAttachPoint
        /// {
        /// 	WEAPON_ATTACH_POINT_INVALID = -1,
        /// 	WEAPON_ATTACH_POINT_HAND_PRIMARY = 0,
        /// 	WEAPON_ATTACH_POINT_HAND_SECONDARY = 1,
        /// 	WEAPON_ATTACH_POINT_PISTOL_R = 2,
        /// 	MAX_HAND_WEAPON_ATTACH_POINTS = 2,
        /// 	WEAPON_ATTACH_POINT_PISTOL_L = 3,
        /// 	WEAPON_ATTACH_POINT_KNIFE = 4,
        /// 	WEAPON_ATTACH_POINT_LASSO = 5,
        /// 	WEAPON_ATTACH_POINT_THROWER = 6,
        /// 	WEAPON_ATTACH_POINT_BOW = 7,
        /// 	WEAPON_ATTACH_POINT_BOW_ALTERNATE = 8,
        /// 	WEAPON_ATTACH_POINT_RIFLE = 9,
        /// 	WEAPON_ATTACH_POINT_RIFLE_ALTERNATE = 10,
        /// 	WEAPON_ATTACH_POINT_LANTERN = 11,
        /// 	WEAPON_ATTACH_POINT_TEMP_LANTERN = 12,
        /// 	WEAPON_ATTACH_POINT_MELEE = 13,
        /// 	MAX_SYNCED_WEAPON_ATTACH_POINTS = 13,
        /// 	WEAPON_ATTACH_POINT_HIP = 14,
        /// 	WEAPON_ATTACH_POINT_BOOT = 15,
        /// 	WEAPON_ATTACH_POINT_BACK = 16,
        /// 	WEAPON_ATTACH_POINT_FRONT = 17,
        /// 	WEAPON_ATTACH_POINT_SHOULDERSLING = 18,
        /// 	WEAPON_ATTACH_POINT_LEFTBREAST = 19,
        /// 	WEAPON_ATTACH_POINT_RIGHTBREAST = 20,
        /// 	WEAPON_ATTACH_POINT_LEFTARMPIT = 21,
        /// 	WEAPON_ATTACH_POINT_RIGHTARMPIT = 22,
        /// 	WEAPON_ATTACH_POINT_LEFTARMPIT_RIFLE = 23,
        /// 	WEAPON_ATTACH_POINT_SATCHEL = 24,
        /// 	WEAPON_ATTACH_POINT_LEFTARMPIT_BOW = 25,
        /// 	WEAPON_ATTACH_POINT_RIGHT_HAND_EXTRA = 26,
        /// 	WEAPON_ATTACH_POINT_LEFT_HAND_EXTRA = 27,
        /// 	WEAPON_ATTACH_POINT_RIGHT_HAND_AUX = 28,
        /// 	MAX_WEAPON_ATTACH_POINTS = 29
        /// };
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL equipNow
        /// > int attachPoint
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        SET_CURRENT_PED_WEAPON = 0xADF692B254977C0C,
        /// <summary>
        /// attachPoint: see SET_CURRENT_PED_WEAPON
        ///
        /// > Ped ped
        /// > Hash* weaponHash
        /// > BOOL p2
        /// > int attachPoint
        /// > BOOL p4
        ///
        /// </summary>
        GET_CURRENT_PED_WEAPON = 0x3A87E44BB9A01D54,
        /// <summary>
        /// addReason: see _ADD_AMMO_TO_PED
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int ammoCount
        /// > BOOL p3
        /// > Hash addReason
        ///
        /// </summary>
        GIVE_DELAYED_WEAPON_TO_PED = 0xB282DC6EBD803C75,
        /// <summary>
        /// removeReason:
        /// enum eRemoveItemReason : Hash
        /// {
        /// 	REMOVE_REASON_CLIENT_PURGED = 0x4A4E94DC,
        /// 	REMOVE_REASON_COALESCE = 0x2ABE393E,
        /// 	REMOVE_REASON_DEBUG = 0xA07362E6,
        /// 	REMOVE_REASON_DEFAULT = 0xF77DE93D,
        /// 	REMOVE_REASON_DELETE_CHARACTER = 0x20AFBDE9,
        /// 	REMOVE_REASON_DROPPED = 0xEC7FB5D5,
        /// 	REMOVE_REASON_DUPLICATE = 0x19047132,
        /// 	REMOVE_REASON_GIFTED_INCORRECTLY = 0x9C4E3829,
        /// 	REMOVE_REASON_GIVEN = 0xAD5377D4,
        /// 	REMOVE_REASON_INSUFFICIENT_INVENTORY = 0x518D1AAE,
        /// 	REMOVE_REASON_ITEM_DOES_NOT_EXIST = 0xEAD5D889,
        /// 	REMOVE_REASON_LOADOUT = 0x1B94E3BA,
        /// 	REMOVE_REASON_SET_AMOUNT = 0x19D5CFA5,
        /// 	REMOVE_REASON_SOLD = 0x76C4B482,
        /// 	REMOVE_REASON_USED = 0x2188E0A3,
        /// 	REMOVE_REASON_USE_FAILED = 0x671F9EAD
        /// };
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL p2
        /// > Hash removeReason
        ///
        /// </summary>
        REMOVE_WEAPON_FROM_PED = 0x4899CB088EDF59B8,
        /// <summary>
        /// Hides the ped's weapon during a cutscene.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE = 0x6F6981D2253C208F,
        /// <summary>
        /// attachPoint: see SET_CURRENT_PED_WEAPON
        ///
        /// > Ped ped
        /// > int attachPoint
        /// > BOOL visible
        ///
        /// </summary>
        _SET_PED_WEAPON_ATTACH_POINT_VISIBILITY = 0x67E21ACC5C0C970C,
        /// <summary>
        /// Returns "WNS_INVALID" if the weapon is invalid/doesn't exist.
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        _GET_WEAPON_NAME = 0x89CF5FF3D363311E,
        /// <summary>
        /// entity can be a ped or weapon object.
        ///
        /// > Entity entity
        /// > Hash componentHash
        /// > Hash weaponHash
        /// > BOOL p3
        ///
        /// </summary>
        _GIVE_WEAPON_COMPONENT_TO_ENTITY = 0x74C9090FDD1BB48E,
        /// <summary>
        /// Related to weapon visual damage, not actual damage.
        ///
        /// > Object weaponObject
        ///
        /// </summary>
        _GET_WEAPON_DAMAGE = 0x904103D5D2333977,
        /// <summary>
        /// Related to weapon visual damage, not actual damage.
        ///
        /// > Object weaponObject
        /// > float level
        /// > BOOL p2
        ///
        /// </summary>
        _SET_WEAPON_DAMAGE = 0xE22060121602493B,
        /// <summary>
        /// every other level will have the max value of (brokeLevel - threshold)
        ///
        /// > Object weaponObject
        /// > float threshold
        ///
        /// </summary>
        _SET_WEAPON_LEVEL_THRESHOLD = 0xD4071EFC83794B2F,
        /// <summary>
        /// 0.0: good condition, 1.0: poor condition
        ///
        /// > Object weaponObject
        ///
        /// </summary>
        GET_WEAPON_DEGRADATION = 0x0D78E1097F89E637,
        /// <summary>
        /// Returns weaponHash
        ///
        /// > Hash weaponGroupHash
        /// > float p1
        /// > float p2
        /// > Any p3
        ///
        /// </summary>
        _0xF8204EF17410BF43 = 0xF8204EF17410BF43,
        /// <summary>
        /// Returns true when the weapon passed is either a lasso, the camera or the binoculars
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        _0x6ABAD7B0A854F8FB = 0x6ABAD7B0A854F8FB,
        /// <summary>
        /// Returns true when the weapon passed is either the fishingrod, a lasso, the camera or the binoculars
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        _0x49E40483948AF062 = 0x49E40483948AF062,
        /// <summary>
        /// Returns emoteType Hash
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x2C4FEC3D0EFA9FC0 = 0x2C4FEC3D0EFA9FC0,
        /// <summary>
        /// Returns weaponCollection Hash
        ///
        /// > Hash pedModel
        ///
        /// </summary>
        _0xD42514C182121C23 = 0xD42514C182121C23,
        _GET_WEAPON_UNLOCK = 0x865F36299079FB75,
        _REMOVE_ALL_PED_AMMO = 0x1B83C0DEEBCBB214,
        SET_PED_AMMO = 0x14E56BC5B5DB6A19,
        _SET_VEHICLE_WEAPON_HEADING_LIMITS = 0x56CB3B4305A4F7CE,
        SET_VEHICLE_WEAPON_HEADING = 0x194D877FC5597B7D,
        SET_PED_INFINITE_AMMO = 0x3EDCB0505123623B,
        _SET_PED_INFINITE_AMMO_CLIP = 0xFBAA1E06B6BCA741,
        GET_AMMO_IN_PED_WEAPON = 0x015A522136D7F951,
        GET_MAX_AMMO_IN_CLIP = 0xA38DCFFCEA8962FA,
        GET_AMMO_IN_CLIP = 0x2E1202248937775C,
        _GET_AMMO_IN_CLIP_BY_INVENTORY_UID = 0x678F00858980F516,
        SET_AMMO_IN_CLIP = 0xDCD2A934D65CB497,
        _REFILL_AMMO_IN_CLIP = 0xDF4A3404D022ADDE,
        GET_MAX_AMMO = 0xDC16122C7A20C933,
        SET_PED_AMMO_BY_TYPE = 0x5FD1E1F011E76D7E,
        GET_PED_AMMO_BY_TYPE = 0x39D22031557946C1,
        SET_PED_AMMO_TO_DROP = 0xA4EFEF9440A5B0EF,
        _GET_AMMO_TYPE_FOR_WEAPON = 0x5C2EA6C44F515F34,
        _GET_WEAPON_TYPE_FROM_AMMO_TYPE = 0x7AA043F6C41D151E,
        _GET_WEAPON_COMPONENT_TYPE_MODEL = 0x59DE03442B6C9598,
        GET_WEAPONTYPE_GROUP = 0xEDCA14CA5199FF25,
        IS_WEAPON_BOW = 0xC4DEC3CA8C365A5D,
        _IS_WEAPON_LANTERN = 0x79407D33328286C6,
        _IS_WEAPON_TORCH = 0x506F1DE1BFC75304,
        GIVE_WEAPON_TO_PED_WITH_OPTIONS = 0xBE7E42B07FD317AC,
        _SET_PED_CURRENT_WEAPON_COCKED_STATE = 0x5230D3F6EE56CFE6,
        _HOLSTER_PED_WEAPONS = 0x94A3C1B804D291EC,
        GET_CURRENT_PED_WEAPON_ENTITY_INDEX = 0x3B390A939AF0B5FC,
        GET_PED_BACKUP_WEAPON = 0xC71FE230A513C30F,
        _GET_PED_WORST_WEAPON = 0xDA37A053C1522F5D,
        GET_BEST_PED_WEAPON = 0x8483E98E8B888AE2,
        GET_BEST_PED_SHORTARM_GUID = 0xF52BD94B47CCF736,
        GET_PED_WEAPON_GUID_AT_ATTACH_POINT = 0x6929E22158E52265,
        SET_CURRENT_PED_VEHICLE_WEAPON = 0x75C55983C2C39DAA,
        GET_CURRENT_PED_VEHICLE_WEAPON = 0x1017582BCD3832DC,
        IS_PED_ARMED = 0xCB690F680A3EA971,
        IS_WEAPON_VALID = 0x937C71165CF334B3,
        _IS_AMMO_VALID = 0x1F7977C9101F807F,
        IS_PED_CARRYING_WEAPON = 0xF29A186ED428B552,
        HAS_PED_GOT_WEAPON = 0x8DECB02F88F428BC,
        IS_PED_WEAPON_READY_TO_SHOOT = 0xB80CA294F2F26749,
        REMOVE_ALL_PED_WEAPONS = 0xF25DF915FA38C5F3,
        _REMOVE_WEAPON_FROM_PED_BY_GUID = 0x51C3B71591811485,
        SET_PED_CURRENT_WEAPON_VISIBLE = 0x0725A4CCFDED9A70,
        _SET_PED_ALL_WEAPONS_VISIBILITY = 0x4F806A6CFED89468,
        SET_PED_DROPS_WEAPONS_WHEN_DEAD = 0x476AE72C1D19D1A8,
        GET_PED_LAST_WEAPON_IMPACT_COORD = 0x6C4D0409BA1A2BC2,
        _CLEAR_PED_LAST_WEAPON_DAMAGE = 0x087D8F4BC65F68E4,
        _HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON = 0xDCF06D0CDFF68424,
        SET_PED_DROPS_INVENTORY_WEAPON = 0x208A1888007FC0E6,
        _MAKE_PED_RELOAD = 0x79E1E511FF7EFB13,
        _DROP_CURRENT_PED_WEAPON = 0xCEF4C65DE502D367,
        SET_ALLOW_ANY_WEAPON_DROP = 0x78030C7867D8B9B6,
        _REMOVE_WEAPON_COMPONENT_FROM_PED = 0x19F70C4D80494FF8,
        _HAS_PED_GOT_WEAPON_COMPONENT = 0xBBC67A6F965C688A,
        _REQUEST_WEAPON_ASSET = 0x72D4CB5DB927009C,
        _HAS_WEAPON_ASSET_LOADED = 0xFF07CF465F48B830,
        _REMOVE_WEAPON_ASSET = 0xC3896D03E2852236,
        _GET_WEAPON_NAME_2 = 0x6D3AC61694A791C5,
        _GET_WEAPON_NAME_WITH_PERMANENT_DEGRADATION = 0x7A56D66C78D8EF8E,
        SET_INSTANTLY_EQUIP_WEAPON_PICKUPS = 0x739B9C6D0E7F7F93,
        _GET_WEAPON_STAT_ID = 0x8EC44AE8DECFF841,
        _GET_PED_HOGTIE_WEAPON = 0x90EB1CB189923587,
        _CREATE_WEAPON_OBJECT = 0x9888652B8BA77F73,
        REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT = 0xF7D82B0D66777611,
        HAS_WEAPON_GOT_WEAPON_COMPONENT = 0x76A18844E743BF91,
        _GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT = 0x1A47699E8D533E8F,
        GET_WEAPON_CLIP_SIZE = 0xD3750CCC00635FC2,
        GET_ALLOW_DUAL_WIELD = 0x918990BD9CE08582,
        _SET_ALLOW_DUAL_WIELD = 0x83B8D50EB9446BBA,
        _IS_WEAPON_KNIFE = 0x792E3EF76C911959,
        IS_WEAPON_REVOLVER = 0xC212F1D05A8232BB,
        IS_WEAPON_PISTOL = 0xDDC64F5E31EEDAB6,
        IS_WEAPON_REPEATER = 0xDDB2578E95EF7138,
        IS_WEAPON_RIFLE = 0x0A82317B7EBFC420,
        IS_WEAPON_SHOTGUN = 0xC75386174ECE95D5,
        _IS_WEAPON_SNIPER = 0x6AD66548840472E5,
        IS_WEAPON_MELEE_WEAPON = 0x959383DCD42040DA,
        _IS_WEAPON_THROWABLE = 0x30E7C16B12DA8211,
        _IS_WEAPON_LASSO = 0x6E4E1A82081EABED,
        _IS_WEAPON_BINOCULARS = 0xC853230E76A152DF,
        IS_WEAPON_A_GUN = 0x705BE297EEBDB95D,
        _IS_WEAPON_TWO_HANDED = 0x0556E9D2ECF39D01,
        _IS_WEAPON_ONE_HANDED = 0xD955FEE4B87AFA07,
        _IS_WEAPON_SILENT = 0x5809DBCA0A37C82B,
        SHOULD_WEAPON_BE_DISCARDED_WHEN_SWAPPED = 0x2C83212A7AA51D3D,
        _GET_WEAPON_DIRT = 0x810E8AE9AFEA7E54,
        _SET_WEAPON_DIRT = 0x812CE61DEBCAB948,
        _GET_WEAPON_SOOT = 0x4BF66F8878F67663,
        _SET_WEAPON_SOOT = 0xA9EF4AD10BDDDB57,
        GET_WEAPON_PERMANENT_DEGRADATION = 0xD56E5F336C675EFA,
        _SET_WEAPON_DEGRADATION = 0xA7A57E89E965D839,
        _LISTEN_PROJECTILE_HIT_EVENTS = 0xDA5D3F2C6DD5B5D4,
        _GET_WEAPON_SCALE = 0x22084CA699219624,
        _SET_WEAPON_SCALE = 0xC3544AD0522E69B4,
        _CAN_WEAPON_USE_AMMO_WITH_TYPE = 0xC570B881754DF609,
        _SET_PED_WEAPON_AMMO_TYPE = 0xCC9C4393523833E2,
        _SET_PED_INVENTORY_WEAPON_AMMO_TYPE = 0xEBE46B501BC3FBCF,
        _DISABLE_AMMO_TYPE_FOR_PED_WEAPON = 0xF0D728EEA3C99775,
        _DISABLE_AMMO_TYPE_FOR_PED = 0xAA5A52204E077883,
        _ENABLE_AMMO_TYPE_FOR_PED_WEAPON = 0x23FB9FACA28779C1,
        _ENABLE_AMMO_TYPE_FOR_PED = 0x3B7B7908B7ADFB4B,
        SET_CURRENT_PED_WEAPON_BY_GUID = 0x12FB95FE3D579238,
        SET_PLAYER_PED_QUICK_SWAP_WEAPON_BY_GUID = 0xEC1F85DA51D3D6C4,
        _IS_TARGET_PED_CONSTRAINED_BY_PED_USING_BOLAS = 0x8D50F43298AB9545,
        _0x8A779706DA5CA3DD = 0x8A779706DA5CA3DD,
        _0x9409C62504A8F9E9 = 0x9409C62504A8F9E9,
        _0xBF5987E1CDE63501 = 0xBF5987E1CDE63501,
        _0x46F032B8DDF46CDE = 0x46F032B8DDF46CDE,
        _0x9F0E1892C7F228A8 = 0x9F0E1892C7F228A8,
        _0x4820A6939D7CEF28 = 0x4820A6939D7CEF28,
        _0xC395355843BE134B = 0xC395355843BE134B,
        _0x486C96A0DCD2BC92 = 0x486C96A0DCD2BC92,
        _0x7B98500614C8E8B8 = 0x7B98500614C8E8B8,
        _0x9F67929D98E7C6E8 = 0x9F67929D98E7C6E8,
        _0x08FF1099ED2E6E21 = 0x08FF1099ED2E6E21,
        _0xBDDA0C290C228159 = 0xBDDA0C290C228159,
        _0xA2091482ED42EF85 = 0xA2091482ED42EF85,
        _0x2387D6E9C6B478AA = 0x2387D6E9C6B478AA,
        _0x23BF601A42F329A0 = 0x23BF601A42F329A0,
        _0x07E1C35F0078C3F9 = 0x07E1C35F0078C3F9,
        _0xDBC4B552B2AE9A83 = 0xDBC4B552B2AE9A83,
        _0x431240A58484D5D0 = 0x431240A58484D5D0,
        _0x45E57FDD531C9477 = 0x45E57FDD531C9477,
        _0xF08D8FEB455F2C8C = 0xF08D8FEB455F2C8C,
        _0x16D9841A85FA627E = 0x16D9841A85FA627E,
        _0xB0FB9B196A3D13F0 = 0xB0FB9B196A3D13F0,
        _0x2EBF70E1D8C06683 = 0x2EBF70E1D8C06683,
        _0x63B83A526329AFBC = 0x63B83A526329AFBC,
        _0x0A2AB7B7ABC055F4 = 0x0A2AB7B7ABC055F4,
        _0x8425C5F057012DAB = 0x8425C5F057012DAB,
        _0xA3716A77DCF17424 = 0xA3716A77DCF17424,
        _0x457B16951AD77C1B = 0x457B16951AD77C1B,
        _0x3799EFCC3C8CD5E1 = 0x3799EFCC3C8CD5E1,
        _0x79B1A6E780266DB0 = 0x79B1A6E780266DB0,
        _0xBDD9C235D8D1052E = 0xBDD9C235D8D1052E,
        _0xD2209866B0CB72EA = 0xD2209866B0CB72EA,
        _0xE9B3FEC825668291 = 0xE9B3FEC825668291,
        _0x9CCA3131E6B53C68 = 0x9CCA3131E6B53C68,
        _0xB832F1A686B9B810 = 0xB832F1A686B9B810,
        _0x5A695BD328586B44 = 0x5A695BD328586B44,
        _0x641351E9AD103890 = 0x641351E9AD103890,
        _0xBE711B14A159E84F = 0xBE711B14A159E84F,
        _0xE9BD19F8121ADE3E = 0xE9BD19F8121ADE3E,
        _0x14FF0C2545527F9B = 0x14FF0C2545527F9B,
        _0xD4C6E24D955FF061 = 0xD4C6E24D955FF061,
        _0xAFFD0CCF31F469B8 = 0xAFFD0CCF31F469B8,
        _0x9E2D5D6BC97A5F1E = 0x9E2D5D6BC97A5F1E,
        _0xC6A6789BB405D11C = 0xC6A6789BB405D11C,
        _0x6CA484C9A7377E4F = 0x6CA484C9A7377E4F,
        _0x74C9080FDD1BB48E = 0x74C9080FDD1BB48E,
        _0x74C9080FDD1BB48F = 0x74C9080FDD1BB48F,
        _0x74C2365FDD1BB48F = 0x74C2365FDD1BB48F,
        _0x74C90AAACC1DD48F = 0x74C90AAACC1DD48F,
        _0x74C8000FDD1BB111 = 0x74C8000FDD1BB111,
        _0x74C8000FDD1BB222 = 0x74C8000FDD1BB222,
        _0xF4601C1203B1A78D = 0xF4601C1203B1A78D,
        _0xCBCFFF805F1B4596 = 0xCBCFFF805F1B4596,
        _0x01F661BB9C71B465 = 0x01F661BB9C71B465,
        _0xF3B1620B920D1708 = 0xF3B1620B920D1708,
        _0x86147D05FA831D3A = 0x86147D05FA831D3A,
        _0x408CF580C5E96D49 = 0x408CF580C5E96D49,
        _0x6554ECCE226F2A2A = 0x6554ECCE226F2A2A,
        _0xCD356B42C57BFE01 = 0xCD356B42C57BFE01,
        _0xBC9444F2FF94A9C0 = 0xBC9444F2FF94A9C0,
        _0x899A04AFCC725D04 = 0x899A04AFCC725D04,
        _0xF252A85B8F3F8C58 = 0xF252A85B8F3F8C58,
        _0x9EEFD670F10656D7 = 0x9EEFD670F10656D7,
        _0xF2F585411E748B9C = 0xF2F585411E748B9C,
        _0xA769D753922B031B = 0xA769D753922B031B,
        _0xC5899C4CD2E2495D = 0xC5899C4CD2E2495D,
        _0x44C8F4908F1B2622 = 0x44C8F4908F1B2622,
        _0xEA522F991E120D45 = 0xEA522F991E120D45,
        _0xD2866CBA797E872E = 0xD2866CBA797E872E,
        _0x7EFACC589B98C488 = 0x7EFACC589B98C488,
        _0x5B235F24472F2C3B = 0x5B235F24472F2C3B,
        _0xBFCA7AFABF9D7967 = 0xBFCA7AFABF9D7967,
        _0x495A04CAEC263AF8 = 0x495A04CAEC263AF8,
        _0x95CA12E2C68043E5 = 0x95CA12E2C68043E5,
        _0xABC18A28BAD4B46F = 0xABC18A28BAD4B46F,
        _0x80BB243789008A82 = 0x80BB243789008A82,
        _0x58425FCA3D3A2D15 = 0x58425FCA3D3A2D15,
        _0xEC97101A8F311282 = 0xEC97101A8F311282,
        _0x7E7B19A4355FEE13 = 0x7E7B19A4355FEE13,
        _0xAF9D167A5656D6A6 = 0xAF9D167A5656D6A6,
        _0x183CE355115B6E75 = 0x183CE355115B6E75,
        _0xD63B4BA3A02A99E0 = 0xD63B4BA3A02A99E0,
        _0x404514D231DB27A0 = 0x404514D231DB27A0,
        _0xD53846B9C931C181 = 0xD53846B9C931C181,
        _0x000FA7A4A8443AF7 = 0x000FA7A4A8443AF7,
        _0xECBB26529A737EF6 = 0xECBB26529A737EF6,
        _0xCAD4FE9398820D24 = 0xCAD4FE9398820D24,
        _0x4823F13A21F51964 = 0x4823F13A21F51964,
        _0xB7E52A058B07C7E2 = 0xB7E52A058B07C7E2,
        _0x0DE0944ECCB3DF5D = 0x0DE0944ECCB3DF5D,
        _0x46D42883E873C1D7 = 0x46D42883E873C1D7,
        _0x65DC4AC5B96614CB = 0x65DC4AC5B96614CB,
    }
    public static class NATIVE_WEAPON_EXTENSIONS
    {
        public static void Call(this NATIVE_WEAPON hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_WEAPON hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}