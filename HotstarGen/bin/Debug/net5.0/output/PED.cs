using System;
namespace Hotstar
{
    public enum NATIVE_PED : ulong
    { 
        /// <summary>
        /// Deletes the specified ped, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Ped* ped
        ///
        /// </summary>
        DELETE_PED = 0xCC0EF140F99365C5,
        /// <summary>
        /// Copies ped's components and props to targetPed.
        ///
        /// > Ped ped
        /// > Ped targetPed
        ///
        /// </summary>
        CLONE_PED_TO_TARGET = 0xE952D6431689AD9A,
        /// <summary>
        /// Gets a value indicating whether the specified ped is in the specified vehicle.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > BOOL atGetIn
        ///
        /// </summary>
        IS_PED_IN_VEHICLE = 0xA3EE4A07279BB9DB,
        /// <summary>
        /// Gets a value indicating whether the specified ped is in any vehicle.
        ///
        /// > Ped ped
        /// > BOOL atGetIn
        ///
        /// </summary>
        IS_PED_IN_ANY_VEHICLE = 0x997ABD671D25CA0B,
        /// <summary>
        /// Gets a value indicating whether this ped's health is below its injured threshold.
        /// 
        /// The default threshold is 100.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_INJURED = 0x84A2DD9AC37C35C1,
        /// <summary>
        /// Gets a value indicating whether this ped's health is below its fatally injured threshold. The default threshold is 100.
        /// If the handle is invalid, the function returns true.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_FATALLY_INJURED = 0xD839450756ED5A80,
        /// <summary>
        /// Returns whether the specified ped is reloading.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_RELOADING = 0x24B100C68C645951,
        /// <summary>
        /// seatIndex:
        /// enum eVehicleSeat
        /// {
        /// 	VS_ANY_PASSENGER = -2,
        /// 	VS_DRIVER,
        /// 	VS_FRONT_RIGHT,
        /// 	VS_BACK_LEFT,
        /// 	VS_BACK_RIGHT,
        /// 	VS_EXTRA_LEFT_1,
        /// 	VS_EXTRA_RIGHT_1,
        /// 	VS_EXTRA_LEFT_2,
        /// 	VS_EXTRA_RIGHT_2,
        /// 	VS_EXTRA_LEFT_3,
        /// 	VS_EXTRA_RIGHT_3,
        /// 	VS_NUM_SEATS
        /// };
        ///
        /// > Vehicle vehicle
        /// > Hash modelHash
        /// > int seatIndex
        /// > BOOL p3
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        CREATE_PED_INSIDE_VEHICLE = 0x7DD959874C1FD534,
        /// <summary>
        /// angle is ped's view cone
        ///
        /// > Ped ped
        /// > Ped otherPed
        /// > float angle
        ///
        /// </summary>
        IS_PED_FACING_PED = 0xD71649DB0A545AA3,
        /// <summary>
        /// Notes: The function only returns true while the ped is: 
        /// A.) Swinging a random melee attack (including pistol-whipping)
        /// 
        /// B.) Reacting to being hit by a melee attack (including pistol-whipping)
        /// 
        /// C.) Is locked-on to an enemy (arms up, strafing/skipping in the default fighting-stance, ready to dodge+counter). 
        /// 
        /// You don't have to be holding the melee-targetting button to be in this stance; you stay in it by default for a few seconds after swinging at someone. If you do a sprinting punch, it returns true for the duration of the punch animation and then returns false again, even if you've punched and made-angry many peds
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_IN_MELEE_COMBAT = 0x4E209B2C1EAD5159,
        /// <summary>
        /// Returns whether the specified ped is shooting.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_SHOOTING = 0x34616828CD07F1A1,
        /// <summary>
        /// accuracy = 0-100, 100 being perfectly accurate
        ///
        /// > Ped ped
        /// > int accuracy
        ///
        /// </summary>
        SET_PED_ACCURACY = 0x7AEFB85C1D49DEB6,
        /// <summary>
        /// Forces the ped to fall back and kills it.
        /// 
        /// It doesn't really explode the ped's head but it kills the ped
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        EXPLODE_PED_HEAD = 0x2D05CED3A38D0F3A,
        /// <summary>
        /// Same as SET_PED_ARMOUR, but ADDS 'amount' to the armor the Ped already has.
        ///
        /// > Ped ped
        /// > int amount
        ///
        /// </summary>
        ADD_ARMOUR_TO_PED = 0x5BA652A0CD14DF2F,
        /// <summary>
        /// Ped: The ped to warp.
        /// vehicle: The vehicle to warp the ped into.
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        SET_PED_INTO_VEHICLE = 0xF75B0D629E1C063D,
        /// <summary>
        /// Returns true/false if the ped is/isn't male.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_MALE = 0x6D9F5FAA7488BA46,
        /// <summary>
        /// Returns true/false if the ped is/isn't humanoid.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_HUMAN = 0xB980061DA992779D,
        /// <summary>
        /// Gets the vehicle the specified Ped is in.
        /// 
        /// If the Ped is not in a vehicle and includeLastVehicle is true, the vehicle they were last in is returned.
        ///
        /// > Ped ped
        /// > BOOL lastVehicle
        ///
        /// </summary>
        GET_VEHICLE_PED_IS_IN = 0x9A9112A0FE9A4713,
        /// <summary>
        /// Resets the value for the last vehicle driven by the Ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        RESET_PED_LAST_VEHICLE = 0xBB8DE8CF6A8DD8BB,
        /// <summary>
        /// Sets the scenario ped density to the given config.
        /// 
        /// Valid configs:
        /// - BLACKWATER
        /// - DEFAULT
        /// - NEWBORDEAUX
        /// - RHODES
        /// - STRAWBERRY
        /// - TUMBLEWEED
        /// - VALENTINE
        /// - VANHORN
        /// 
        /// See common/data/ai/densityscoringconfigs.meta for more information.
        ///
        /// > Hash configHash
        ///
        /// </summary>
        _SET_SCENARIO_PED_DENSITY_THIS_FRAME = 0x95423627A9CA598E,
        /// <summary>
        /// The distance between these points, is the diagonal of a box (remember it's 3D).
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        SET_PED_NON_CREATION_AREA = 0xEE01041D559983EA,
        /// <summary>
        /// Gets a value indicating whether the specified ped is on top of any vehicle.
        /// 
        /// Return 1 when ped is on vehicle.
        /// Return 0 when ped is not on a vehicle.
        /// 
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        IS_PED_ON_VEHICLE = 0x67722AEB798E5FAB,
        /// <summary>
        /// Detect if ped is sitting in the specified vehicle
        /// [True/False]
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_PED_SITTING_IN_VEHICLE = 0xA808AA1D79230FC2,
        /// <summary>
        /// Detect if ped is in any vehicle
        /// [True/False]
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_SITTING_IN_ANY_VEHICLE = 0x826AA586EDB9FEF8,
        /// <summary>
        /// enum ePedDamageCleanliness
        /// {
        /// 	PED_DAMAGE_CLEANLINESS_POOR,
        /// 	PED_DAMAGE_CLEANLINESS_GOOD,
        /// 	PED_DAMAGE_CLEANLINESS_PERFECT
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_DAMAGE_CLEANLINESS = 0x88EFFED5FE8B0B4A,
        /// <summary>
        /// damageCleanliness: see _GET_PED_DAMAGE_CLEANLINESS
        ///
        /// > Ped ped
        /// > int damageCleanliness
        ///
        /// </summary>
        _SET_PED_DAMAGE_CLEANLINESS = 0x7528720101A807A5,
        /// <summary>
        /// Returns true if _GET_PED_DAMAGE_CLEANLINESS was ever lower than 2
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_DAMAGED = 0x6CFC373008A1EDAF,
        /// <summary>
        /// Old name: _SET_PED_DAMAGE_MODIFIER
        ///
        /// > Ped ped
        /// > float damageModifier
        ///
        /// </summary>
        SET_PED_TO_PLAYER_WEAPON_DAMAGE_MODIFIER = 0xD77AE48611B7B10A,
        /// <summary>
        /// Returns true if the ped is currently opening a door (CTaskOpenDoor).
        ///
        /// > Ped ped
        ///
        /// </summary>
        _IS_PED_OPENING_A_DOOR = 0x26AF0E8E30BD2A2C,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        SET_PED_STEALTH_MOVEMENT = 0x88CBB5CEB96B7BD2,
        /// <summary>
        /// Returns whether the entity is in stealth mode
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_STEALTH_MOVEMENT = 0x7C2AC9CA66575FBF,
        /// <summary>
        /// Creates a new ped group.
        /// Groups can contain up to 8 peds.
        /// 
        /// The parameter is unused.
        /// 
        /// Returns a handle to the created group, or 0 if a group couldn't be created.
        ///
        /// > int unused
        ///
        /// </summary>
        CREATE_GROUP = 0x90370EBE0FEE1A3D,
        /// <summary>
        /// This only will teleport the ped to the group leader if the group leader teleports (sets coords).
        /// 
        /// Only works in singleplayer
        ///
        /// > Ped pedHandle
        /// > int groupHandle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_CAN_TELEPORT_TO_GROUP_LEADER = 0x2E2F4240B3F24647,
        /// <summary>
        /// Sets the range at which members will automatically leave the group.
        ///
        /// > int groupHandle
        /// > float separationRange
        ///
        /// </summary>
        SET_GROUP_SEPARATION_RANGE = 0x4102C7858CFEE4E4,
        /// <summary>
        /// Returns the Entity (Ped, Vehicle, or ?Object?) that killed the 'ped'
        /// 
        /// Is best to check if the Ped is dead before asking for its killer.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_SOURCE_OF_DEATH = 0x93C8B64DEB84728C,
        /// <summary>
        /// Returns the hash of the weapon/model/object that killed the ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_CAUSE_OF_DEATH = 0x16FFE42AB2D2DC59,
        /// <summary>
        /// Can't select void. This function returns nothing. The hash of the created relationship group is output in the second parameter.
        ///
        /// > const char* name
        /// > Hash* groupHash
        ///
        /// </summary>
        ADD_RELATIONSHIP_GROUP = 0xF372BC22FCB88606,
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Ped ped
        /// > Hash eventType
        ///
        /// </summary>
        IS_PED_RESPONDING_TO_EVENT = 0x625B774D75C87068,
        /// <summary>
        /// shootRate 0-1000
        ///
        /// > Ped ped
        /// > int shootRate
        ///
        /// </summary>
        SET_PED_SHOOT_RATE = 0x614DA022990752DC,
        /// <summary>
        /// combatType can be between 0-14. See GET_COMBAT_FLOAT below for a list of possible parameters.
        ///
        /// > Ped ped
        /// > int combatType
        /// > float p2
        ///
        /// </summary>
        SET_COMBAT_FLOAT = 0xFF41B4B141ED981C,
        /// <summary>
        /// Returns the group id of which the specified ped is a member of.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_GROUP_INDEX = 0xF162E133B4E7A675,
        /// <summary>
        /// 0: Default
        /// 1: Circle Around Leader
        /// 2: Alternative Circle Around Leader
        /// 3: Line, with Leader at center
        ///
        /// > int groupId
        /// > int formationType
        ///
        /// </summary>
        SET_GROUP_FORMATION = 0xCE2F5FC3AF7E8C1E,
        /// <summary>
        /// damages a ped with the given amount
        ///
        /// > Ped ped
        /// > int damageAmount
        /// > int p2
        /// > int boneId
        /// > Ped pedKiller
        ///
        /// </summary>
        APPLY_DAMAGE_TO_PED = 0x697157CED63F18D4,
        /// <summary>
        /// Turns the desired ped into a cop. If you use this on the player ped, you will become almost invisible to cops dispatched for you. You will also report your own crimes, get a generic cop voice, get a cop-vision-cone on the radar, and you will be unable to shoot at other cops. Toggling ped as "false" has no effect; you must change p0's ped model to disable the effect.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_AS_COP = 0xBB03C38DD3FB7FFD,
        /// <summary>
        /// Sets the maximum health of a ped.
        ///
        /// > Ped ped
        /// > int value
        ///
        /// </summary>
        SET_PED_MAX_HEALTH = 0xF5F6378C4F3419D3,
        /// <summary>
        /// configHash: see pedhealth.meta
        ///
        /// > Ped ped
        /// > Hash configHash
        ///
        /// </summary>
        _SET_PED_HEALTH_CONFIG = 0xF6B82FCE03B43A37,
        /// <summary>
        /// state:
        /// enum eKnockOffVehicle
        /// {
        /// 	KNOCKOFFVEHICLE_DEFAULT,
        /// 	KNOCKOFFVEHICLE_NEVER,
        /// 	KNOCKOFFVEHICLE_EASY,
        /// 	KNOCKOFFVEHICLE_HARD
        /// };
        ///
        /// > Ped ped
        /// > int state
        ///
        /// </summary>
        SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE = 0x7A6535691B477C48,
        /// <summary>
        /// ped can not pull out a weapon when true
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_ENABLE_HANDCUFFS = 0xDF1AF8B5D56542FA,
        /// <summary>
        /// Based on TASK_COMBAT_HATED_TARGETS_AROUND_PED, the parameters are likely similar (PedHandle, and area to attack in).
        ///
        /// > Ped ped
        /// > float radius
        ///
        /// </summary>
        REGISTER_HATED_TARGETS_AROUND_PED = 0x9222F300BF8354FE,
        /// <summary>
        /// Gets the closest ped in a radius.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > BOOL p4
        /// > BOOL p5
        /// > Ped* outPed
        /// > BOOL p7
        /// > BOOL p8
        /// > int pedType
        /// > Any p10
        ///
        /// </summary>
        GET_CLOSEST_PED = 0xC33AB876A77F8164,
        /// <summary>
        /// Causes Ped to ragdoll on collision with any object (e.g Running into trashcan). If applied to player you will sometimes trip on the sidewalk.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        SET_PED_RAGDOLL_ON_COLLISION = 0xF0A4F1BBF4FA7497,
        /// <summary>
        /// If the ped handle passed through the parenthesis is in a ragdoll state this will return true.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_RAGDOLL = 0x47E4E977581C5B55,
        /// <summary>
        /// flags:
        /// enum eRagdollBlockingFlags
        /// {
        /// 	RBF_BULLET_IMPACT = (1 << 0),
        /// 	RBF_VEHICLE_IMPACT = (1 << 1),
        /// 	RBF_FIRE = (1 << 2),
        /// 	RBF_ELECTROCUTION = (1 << 3),
        /// 	RBF_PLAYER_IMPACT = (1 << 4),
        /// 	RBF_EXPLOSION = (1 << 5),
        /// 	RBF_IMPACT_OBJECT = (1 << 6),
        /// 	RBF_MELEE = (1 << 7),
        /// 	RBF_RUBBER_BULLET = (1 << 8),
        /// 	RBF_FALLING = (1 << 9),
        /// 	RBF_WATER_JET = (1 << 10),
        /// 	RBF_DROWNING = (1 << 11),
        /// 	RBF_0x9F52E2C4 = (1 << 12),
        /// 	RBF_PLAYER_BUMP = (1 << 13),
        /// 	RBF_PLAYER_RAGDOLL_BUMP = (1 << 14),
        /// 	RBF_PED_RAGDOLL_BUMP = (1 << 15),
        /// 	RBF_VEHICLE_GRAB = (1 << 16),
        /// 	RBF_SMOKE_GRENADE = (1 << 17),
        /// 	RBF_HORSE_BUMP = (1 << 18),
        /// 	RBF_ACTIVATE_ON_COLLISION = (1 << 19)
        /// };
        ///
        /// > Ped ped
        /// > int flags
        ///
        /// </summary>
        SET_RAGDOLL_BLOCKING_FLAGS = 0x26695EC767728D84,
        /// <summary>
        /// flags: see SET_RAGDOLL_BLOCKING_FLAGS
        ///
        /// > Ped ped
        /// > int flags
        ///
        /// </summary>
        CLEAR_RAGDOLL_BLOCKING_FLAGS = 0xD86D101FCFD00A4B,
        /// <summary>
        /// Ped will no longer get angry when you stay near him.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        REMOVE_PED_DEFENSIVE_AREA = 0x74D4E028107450A9,
        /// <summary>
        /// This function will simply bring the dead person back to life.
        /// 
        /// Try not to use it alone, since using this function alone, will make peds fall through ground in hell(well for the most of the times).
        /// 
        /// Instead, before calling this function, you may want to declare the position, where your Resurrected ped to be spawn at.(For instance, Around 2 floats of Player's current position.) 
        /// 
        /// Also, disabling any assigned task immediately helped in the number of scenarios, where If you want peds to perform certain decided tasks.
        ///
        /// > Ped ped
        ///
        /// </summary>
        RESURRECT_PED = 0x71BC8E838B9C6035,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        SET_PED_NAME_DEBUG = 0x98EFA132A4117BE1,
        /// <summary>
        /// It clears the wetness of the selected Ped/Player. Clothes have to be wet to notice the difference.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_PED_WETNESS = 0x9C720776DAA43E7E,
        /// <summary>
        /// It adds the wetness level to the player clothing/outfit. As if player just got out from water surface.
        /// 
        /// 
        ///
        /// > Ped ped
        /// > float height
        ///
        /// </summary>
        SET_PED_WETNESS_HEIGHT = 0x44CB6447D2571AA0,
        /// <summary>
        /// combined with PED::SET_PED_WETNESS_HEIGHT(), this native makes the ped drenched in water up to the height specified in the other function
        ///
        /// > Ped ped
        ///
        /// </summary>
        SET_PED_WETNESS_ENABLED_THIS_FRAME = 0xB5485E4907B53019,
        /// <summary>
        /// Despite this function's name, it simply returns whether the specified handle is a Ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        WAS_PED_SKELETON_UPDATED = 0x11B499C1E0FF8559,
        /// <summary>
        /// Gets the position of the specified bone of the specified ped.
        /// 
        /// ped: The ped to get the position of a bone from.
        /// boneId: The ID of the bone to get the position from. This is NOT the index.
        /// offsetX: The X-component of the offset to add to the position relative to the bone's rotation.
        /// offsetY: The Y-component of the offset to add to the position relative to the bone's rotation.
        /// offsetZ: The Z-component of the offset to add to the position relative to the bone's rotation.
        ///
        /// > Ped ped
        /// > int boneId
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        GET_PED_BONE_COORDS = 0x17C07FC640E86B4E,
        /// <summary>
        /// Equivalent to IS_PED_USING_SCENARIO from V but takes a hash instead of a string.
        ///
        /// > Ped ped
        /// > Hash scenarioHash
        ///
        /// </summary>
        IS_PED_USING_SCENARIO_HASH = 0x34D6AC1157C8226C,
        /// <summary>
        /// lookIntensity:
        /// 0 - REACT_LOOK_NONE
        /// 1 - REACT_LOOK_LOW
        /// 2 - REACT_LOOK_MEDIUM
        /// 3 - REACT_LOOK_HIGH
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int lookIntensity
        ///
        /// </summary>
        SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT = 0xEEED8FAFEC331A70,
        /// <summary>
        /// lookIntensity: see SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int lookIntensity
        ///
        /// </summary>
        SET_PED_SHOULD_PLAY_COMBAT_SCENARIO_EXIT = 0x802092B07E3B1EEA,
        /// <summary>
        /// lookIntensity: see SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int lookIntensity
        /// > BOOL p5
        ///
        /// </summary>
        _SET_PED_SHOULD_PLAY_EMOTIONAL_SCENARIO_EXIT = 0x62FDAD5E01D2DD47,
        /// <summary>
        /// lookIntensity: see SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int lookIntensity
        /// > BOOL p5
        ///
        /// </summary>
        SET_PED_SHOULD_PLAY_QUICK_SCENARIO_EXIT = 0x463803429297117C,
        /// <summary>
        /// flagId: https://alloc8or.re/rdr3/doc/enums/ePedScriptConfigFlags.txt
        ///
        /// > Ped ped
        /// > int flagId
        /// > BOOL value
        ///
        /// </summary>
        SET_PED_CONFIG_FLAG = 0x1913FE4CBF41C463,
        /// <summary>
        /// flagId: see SET_PED_CONFIG_FLAG
        ///
        /// > Ped ped
        /// > int flagId
        /// > BOOL p2
        ///
        /// </summary>
        GET_PED_CONFIG_FLAG = 0x7EE53118C892B513,
        /// <summary>
        /// Presumably returns the Entity that the Ped is currently diving out of the way of.
        ///
        /// > Ped ped
        /// > Entity* evadingEntity
        ///
        /// </summary>
        IS_PED_EVASIVE_DIVING = 0x414641C26E105898,
        /// <summary>
        /// 0 - Stationary (Will just stand in place)
        /// 1 - Defensive (Will try to find cover and very likely to blind fire)
        /// 2 - Offensive (Will attempt to charge at enemy but take cover as well)
        /// 3 - Suicidal Offensive (Will try to flank enemy in a suicidal attack)
        ///
        /// > Ped ped
        /// > int combatMovement
        ///
        /// </summary>
        SET_PED_COMBAT_MOVEMENT = 0x4D9CA1009AFBD057,
        /// <summary>
        /// abilityLevel:
        /// enum eCombatAbilityLevel
        /// {
        /// 	CAL_POOR,
        /// 	CAL_AVERAGE,
        /// 	CAL_PROFESSIONAL
        /// };
        ///
        /// > Ped ped
        /// > int abilityLevel
        ///
        /// </summary>
        SET_PED_COMBAT_ABILITY = 0xC7622C0D36B2FDA8,
        /// <summary>
        /// range:
        /// enum eCombatRange
        /// {
        /// 	CR_NEAR,
        /// 	CR_MEDIUM,
        /// 	CR_FAR,
        /// 	CR_VERY_FAR
        /// };
        ///
        /// > Ped ped
        /// > int range
        ///
        /// </summary>
        SET_PED_COMBAT_RANGE = 0x3C606747B23E497B,
        /// <summary>
        /// attributeIndex: https://alloc8or.re/rdr3/doc/enums/eCombatAttribute.txt
        ///
        /// > Ped ped
        /// > int attributeIndex
        /// > BOOL enabled
        ///
        /// </summary>
        SET_PED_COMBAT_ATTRIBUTES = 0x9F7794730795E019,
        /// <summary>
        /// brawlingStyle:
        /// enum eBrawlingStyle : Hash
        /// {
        /// 	BS_AI = 0x802C604D,
        /// 	BS_AI_BARBRAWL = 0x4FF5F0C7,
        /// 	BS_AI_DEFENSIVE = 0xD888F2FD,
        /// 	BS_AI_MOONSHINE_BARBRAWL = 0xA01B433A,
        /// 	BS_ALLIGATOR = 0x7A5548ED,
        /// 	BS_ALLIGATOR_LARGE = 0x368EC7CB,
        /// 	BS_ALLY = 0x69C76C14,
        /// 	BS_ANIMAL = 0xD777C754,
        /// 	BS_BADGER = 0x7E7C3F53,
        /// 	BS_BEAR = 0x0BC66E35,
        /// 	BS_BEAVER = 0x4E313783,
        /// 	BS_BOAR = 0x176A5831,
        /// 	BS_BOUNTY_HUNTER = 0x3900654C,
        /// 	BS_BRUISER = 0x4514DB61,
        /// 	BS_BULL = 0x4E50C5D2,
        /// 	BS_COUGAR = 0x9DAA7CCB,
        /// 	BS_COW = 0xB0E91295,
        /// 	BS_COYOTE = 0xA448EB69,
        /// 	BS_DEER = 0xA781E6B3,
        /// 	BS_DOG = 0x5A4155C4,
        /// 	BS_ELK = 0x408697F0,
        /// 	BS_FEMALE = 0x6A3BB2C2,
        /// 	BS_FEMALE_STRONG = 0x4DAFDD84,
        /// 	BS_GANGUP = 0xD0CECFF2,
        /// 	BS_GOAT = 0x078E649F,
        /// 	BS_HORSE = 0xF6B775F3,
        /// 	BS_MICAH_FINALE = 0x1F0BB27A,
        /// 	BS_MOOSE = 0x968917AB,
        /// 	BS_MUSKRAT = 0x1EDC33AC,
        /// 	BS_NO_MELEE = 0x25B5F931,
        /// 	BS_PIG = 0x22EAD110,
        /// 	BS_PLAYER = 0x78BAEF07,
        /// 	BS_PLAYER_FINALE = 0xF9E77D2D,
        /// 	BS_PLAYER_MOONSHINER = 0x687BF19F,
        /// 	BS_PLAYER_WINTER1 = 0x3C6A802F,
        /// 	BS_QUICK = 0xC4CABB1B,
        /// 	BS_RACCOON = 0x505F8917,
        /// 	BS_SHEEP = 0x6827CCCF,
        /// 	BS_SNAKE = 0x82BEBC4B,
        /// 	BS_TIMID = 0x431AEF77,
        /// 	BS_WOLF = 0xA8F023D4
        /// };
        ///
        /// > Ped ped
        /// > Hash brawlingStyle
        ///
        /// </summary>
        _SET_PED_BRAWLING_STYLE = 0x8BA83CC4288CD56D,
        /// <summary>
        /// normalized / non normalized
        /// 0.0        / 1000.0         STARTED IN WRITHE STAGE
        /// 1.0        / 0.0            END OF WRITHE, DEAD
        /// -1.0                        DEAD
        /// 
        /// Returns some value from AI task 562 (unknown).
        ///
        /// > Ped ped
        /// > BOOL normalized
        ///
        /// </summary>
        _GET_PED_REMAINING_REVIVAL_TIME = 0xEBE89623EB861271,
        /// <summary>
        /// attributeFlags:
        /// enum eFleeAttribute
        /// {
        /// 	FA_FORCE_EXIT_VEHICLE = (1 << 16),
        /// 	FA_DISABLE_MOUNT_USAGE = (1 << 20),
        /// 	FA_DISABLE_ENTER_VEHICLES = (1 << 22),
        /// };
        ///
        /// > Ped ped
        /// > int attributeFlags
        /// > BOOL enable
        ///
        /// </summary>
        SET_PED_FLEE_ATTRIBUTES = 0x70A2D1137C8ED7C9,
        /// <summary>
        /// returns whether or not a ped is visible within your FOV, not this check auto's to false after a certain distance.
        /// 
        /// 
        /// Target needs to be tracked.. won't work otherwise.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_TRACKED_PED_VISIBLE = 0x91C8E617F64188AC,
        /// <summary>
        /// Returns:
        /// 0 - CTR_CANNOT_TARGET
        /// 1 - CTR_CAN_TARGET
        /// 2 - CTR_NOT_SURE_YET
        ///
        /// > Ped ped
        /// > Entity targetEntity
        /// > BOOL p2
        /// > BOOL p3
        ///
        /// </summary>
        CAN_PED_SEE_ENTITY = 0x7F9B9791D4CB71F6,
        /// <summary>
        /// no bone = -1
        ///
        /// > Ped ped
        /// > int boneId
        ///
        /// </summary>
        GET_PED_BONE_INDEX = 0x3F428D08BE5AAE31,
        /// <summary>
        /// motionStateHash:
        /// enum eMotionState : Hash
        /// {
        /// 	MotionState_ActionMode_Idle = 0xDA40A0DC,
        /// 	MotionState_ActionMode_Run = 0x31BADE14,
        /// 	MotionState_ActionMode_Walk = 0xD2905EA7,
        /// 	MotionState_Aiming = 0x3F67C6AF,
        /// 	MotionState_Crouch_Idle = 0x43FB099E,
        /// 	MotionState_Crouch_Jog = 0x6CB208A0,
        /// 	MotionState_Crouch_Run = 0x3593CF09,
        /// 	MotionState_Crouch_Walk = 0x08C31A98,
        /// 	MotionState_Diving_Idle = 0x4848CDED,
        /// 	MotionState_Idle = 0x9072A713,
        /// 	MotionState_Jog = 0xABA49932,
        /// 	MotionState_None = 0xEE717723,
        /// 	MotionState_Run = 0xFFF7E7A4,
        /// 	MotionState_RunStop = 0xECB32E00,
        /// 	MotionState_Sprint = 0xBD8817DB,
        /// 	MotionState_SprintStop = 0xDEBA9A6E,
        /// 	MotionState_Swimming_TreadWater = 0xD1BF11C7,
        /// 	MotionState_Walk = 0xD827C3DB,
        /// 	MotionState_WalkStop = 0x3DFCD7A3
        /// };
        ///
        /// > Ped ped
        /// > Hash motionStateHash
        /// > BOOL p2
        /// > int p3
        /// > BOOL p4
        ///
        /// </summary>
        FORCE_PED_MOTION_STATE = 0xF28965D04F570DCA,
        /// <summary>
        /// Min: 0.0f
        /// Max: 1.15f
        ///
        /// > Ped ped
        /// > float value
        ///
        /// </summary>
        SET_PED_MOVE_RATE_OVERRIDE = 0x085BF80FA50A39D1,
        /// <summary>
        /// Overrides the ped's collision capsule radius for the current tick.
        /// Must be called every tick to be effective.
        /// 
        /// Setting this to 0.001 will allow warping through some objects.
        ///
        /// > Ped ped
        /// > float value
        ///
        /// </summary>
        SET_PED_CAPSULE = 0x364DF566EC833DE2,
        /// <summary>
        /// For more information, see common:/data/emotional_presets.meta
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        _REQUEST_PED_EMOTIONAL_PRESET = 0x5C3C55EAAD19915F,
        /// <summary>
        /// See _REQUEST_PED_EMOTIONAL_PRESET
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        _HAS_PED_EMOTIONAL_PRESET_LOADED = 0xDE3904B22695D9F9,
        /// <summary>
        /// See _REQUEST_PED_EMOTIONAL_PRESET
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        _REMOVE_PED_EMOTIONAL_PRESET = 0xFC3BAB1801A8255A,
        /// <summary>
        /// lootFlag:
        /// enum eLootFlag
        /// {
        /// 	LOOT_FLAG_IS_CRITICAL_LOOT_TARGET = 7,
        /// 	LOOT_FLAG_IGNORE_WATER_CHECKS = 8,
        /// 	LOOT_FLAG_ANIMAL_FLAGGED_FOR_TAGGING = 23,
        /// };
        ///
        /// > Ped ped
        /// > int lootFlag
        /// > BOOL enabled
        ///
        /// </summary>
        SET_LOOTING_FLAG = 0x6569F31A01B4C097,
        /// <summary>
        /// lootFlag: see SET_LOOTING_FLAG
        ///
        /// > Ped ped
        /// > int lootFlag
        ///
        /// </summary>
        _GET_LOOTING_FLAG = 0xE4C11F104620DDCE,
        /// <summary>
        /// enum ePedLootStatus
        /// {
        /// 	PLS_NONE,
        /// 	PLS_PRE_LOOT,
        /// 	PLS_SAMPLING,
        /// 	PLS_SKINNING
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_LOOT_STATUS_MP = 0xC737697C41628340,
        /// <summary>
        /// 0.0 - 1.0
        /// Modifies the "scent line" on the ped's body when using Eagle Eye.
        ///
        /// > Ped ped
        /// > float scent
        ///
        /// </summary>
        _SET_PED_SCENT = 0x01B21B81865E2A1F,
        /// <summary>
        /// enum eMetaPedType
        /// {
        /// 	MPT_MALE,
        /// 	MPT_FEMALE,
        /// 	MPT_TEEN,
        /// 	MPT_ANIMAL,
        /// 	MPT_NONE
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_META_PED_TYPE = 0xEC9A1261BF0CE510,
        /// <summary>
        /// Update variation on ped, needed after first creation, or when compoent or texture/overlay is changed
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        /// > BOOL p3
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        _UPDATE_PED_VARIATION = 0xCC8CA3E88256E58F,
        /// <summary>
        /// Sets the outfit preset for the ped. The presetId is an index which determines its preset outfit. p2 is always false.
        ///
        /// > Ped ped
        /// > int presetId
        /// > BOOL p2
        ///
        /// </summary>
        _SET_PED_OUTFIT_PRESET = 0x77FF8D35EEC6BBC4,
        /// <summary>
        /// Alters entity's stamina by 'amount'. Can be negative (to drain stamina).
        ///
        /// > Ped ped
        /// > float amount
        ///
        /// </summary>
        _CHANGE_PED_STAMINA = 0xC3D4B754C0E86B9E,
        /// <summary>
        /// 0.0 <= stamina <= 100.0
        ///
        /// > Ped ped
        /// > float stamina
        ///
        /// </summary>
        _RESTORE_PED_STAMINA = 0x675680D089BFA21F,
        /// <summary>
        /// Material hash list: https://raw.githubusercontent.com/femga/rdr3_discoveries/master/clothes/cloth_drawable_albedo_normal_material_TEMPORARY.lua
        ///
        /// > Hash albedoHash
        /// > Hash normalHash
        /// > Hash materialHash
        ///
        /// </summary>
        _REQUEST_TEXTURE = 0xC5E7204F322E49EB,
        /// <summary>
        /// Seem color is not RGB or HSV
        ///
        /// > int textureId
        /// > int layerId
        /// > int tint0
        /// > int tint1
        /// > int tint2
        ///
        /// </summary>
        _SET_TEXTURE_LAYER_TINT = 0x2DF59FFE6FFD6044,
        /// <summary>
        /// -1 - HORSE_ASSIST__NO_CHANGE
        ///  0 - HORSE_ASSIST__MANUAL
        ///  1 - HORSE_ASSIST__SEMIASSIST
        ///  2 - HORSE_ASSIST__FULLASSIST
        ///
        /// > Ped horse
        /// > int avoidanceLevel
        ///
        /// </summary>
        SET_HORSE_AVOIDANCE_LEVEL = 0xDDCF6FEA5D7ACC17,
        /// <summary>
        /// Doesn't actually return anything.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PED_USE_HORSE_MAP_COLLISION = 0xEB72453B6F5B45B0,
        /// <summary>
        /// Setting the removeTimer to -1 will make the applied data stick
        ///
        /// > Ped ped
        /// > const char* variableName
        /// > int value
        /// > int removeTimer
        ///
        /// </summary>
        _SET_PED_BLACKBOARD_INT = 0x5F53010C4C3F6BAF,
        /// <summary>
        /// p1:
        /// BodyPartChained
        /// OverloadMostInjuredBodyPart
        /// 
        /// p2:
        /// LeftLeg
        /// Legs
        /// RightArm
        ///
        /// > Ped ped
        /// > const char* variableName
        /// > const char* value
        /// > int removeTimer
        ///
        /// </summary>
        _SET_PED_BLACKBOARD_HASH = 0xA762C9D6CF165E0D,
        /// <summary>
        /// quality: see _GET_PED_QUALITY
        ///
        /// > Ped ped
        /// > int quality
        ///
        /// </summary>
        _SET_PED_QUALITY = 0xCE6B874286D640BB,
        /// <summary>
        /// enum ePedQuality
        /// {
        /// 	PQ_INVALID = -1,
        /// 	PQ_LOW,
        /// 	PQ_MEDIUM,
        /// 	PQ_HIGH,
        /// 	PQ_MAX
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_QUALITY = 0x7BCC6087D130312A,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        /// > Any p1
        ///
        /// </summary>
        _0x606D529DADA3C940 = 0x606D529DADA3C940,
        /// <summary>
        /// Note: this native was added in build 1232.40
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0x11E6B9629C46D6EC = 0x11E6B9629C46D6EC,
        /// <summary>
        /// Returns animal skin quality modifier
        ///
        /// > Player player
        ///
        /// </summary>
        _0xEE2D5C819A65BF26 = 0xEE2D5C819A65BF26,
        /// <summary>
        /// Params: p1 = 10, p2 = 0
        ///
        /// > Ped ped
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        _0x3FDCC1F8C17E303E = 0x3FDCC1F8C17E303E,
        /// <summary>
        /// Hashes: STANDARD_PED_AGRO_GUARD, BOUNTY_HUNTER, PLAYER_HORSE
        ///
        /// > Ped ped
        /// > Hash p1
        ///
        /// </summary>
        _0xB8B6430EAD2D2437 = 0xB8B6430EAD2D2437,
        /// <summary>
        /// Seems to set the ped's loco type.
        /// Values used in the scripts:
        /// algie
        /// angry_female
        /// arthur_healthy
        /// cowboy
        /// cowboy_f
        /// default
        /// default_female
        /// free_slave_01
        /// free_slave_02
        /// gold_panner
        /// guard_lantern
        /// injured_general
        /// john_marston
        /// lilly_millet
        /// lone_prisoner
        /// lost_man
        /// mp_ova_hunter
        /// mp_ova_hunter_female
        /// murfree
        /// old_female
        /// primate
        /// rally
        /// waiter
        /// war_veteran
        ///
        /// > Ped ped
        /// > const char* locomotionArchetype
        ///
        /// </summary>
        _0x923583741DC87BCE = 0x923583741DC87BCE,
        /// <summary>
        /// Clears locomotion archetype
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x4FD80C3DD84B817B = 0x4FD80C3DD84B817B,
        /// <summary>
        /// Sets peds motion type
        ///
        /// > Ped ped
        /// > const char* locoMotionType
        ///
        /// </summary>
        _0x89F5E7ADECCCB49C = 0x89F5E7ADECCCB49C,
        /// <summary>
        /// Known stand up animation types: REAR, FRONT
        ///
        /// > Ped ped
        /// > const char* standUpType
        ///
        /// </summary>
        _0xEAA8242C8479C27D = 0xEAA8242C8479C27D,
        /// <summary>
        /// Returns ped drunk level
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x6FB76442469ABD68 = 0x6FB76442469ABD68,
        /// <summary>
        /// Actual name begins with 'S'
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0xF9ACF4A08098EA25 = 0xF9ACF4A08098EA25,
        /// <summary>
        /// Hashes: MOODNORMAL, MOODEXERTIONMEDIUM, MOODANGRY, MOODAGITATED, MOODEXERTIONEXTREME, MOODEXERTIONMILD, MOODBITCHY, MOODPANIC, MOODDEFUSE, MOODDEAD
        /// Params: p2 = 6 in R* Scripts
        ///
        /// > Ped ped
        /// > Hash p1
        /// > int p2
        ///
        /// </summary>
        _0x8B3B71C80A29A4BB = 0x8B3B71C80A29A4BB,
        /// <summary>
        /// SET_PED_CAN_*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0xEE9DF765990E8D1D = 0xEE9DF765990E8D1D,
        /// <summary>
        /// Params: p5 = -1 in R* Scripts
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > Any p4
        /// > float p5
        /// > Any p6
        /// > float p7
        ///
        /// </summary>
        _0x4C57F27D1554E6B0 = 0x4C57F27D1554E6B0,
        /// <summary>
        /// SET_PED_CAN_*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0xFD6943B6DF77E449 = 0xFD6943B6DF77E449,
        /// <summary>
        /// Hashes: GUARD, COMBAT_ANIMAL, LAW, LAW_SHERIFF
        ///
        /// > Ped ped
        /// > Hash p1
        ///
        /// </summary>
        _0xBD75500141E4725C = 0xBD75500141E4725C,
        /// <summary>
        /// Params: p2 is usually 1, sometimes 0 or 2
        /// duration in seconds, -1.0 = forever
        ///
        /// > Ped ped
        /// > Hash combatStyleHash
        /// > int p2
        /// > float duration
        ///
        /// </summary>
        _0x8ACC0506743A8A5C = 0x8ACC0506743A8A5C,
        /// <summary>
        /// Params: p1 = 1 in R* Scripts
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        _0x78815FC52832B690 = 0x78815FC52832B690,
        /// <summary>
        /// duration in seconds, -1.0 = forever
        ///
        /// > Ped ped
        /// > Hash combatStyleModHash
        /// > float duration
        ///
        /// </summary>
        _0x8B1E8E35A6E814EA = 0x8B1E8E35A6E814EA,
        /// <summary>
        /// Hashes: GS_DRAGGING, GS_FACE_TO_BACK, GS_FACE_TO_FACE, GS_FACE_TO_FACE_WALL, GS_MOUNTED
        ///
        /// > Ped ped
        /// > Hash type
        ///
        /// </summary>
        _0x630E7B01F091A197 = 0x630E7B01F091A197,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x600BBDD29820370C = 0x600BBDD29820370C,
        /// <summary>
        /// REQUEST_*
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0x75BA1CB3B7D40CAF = 0x75BA1CB3B7D40CAF,
        /// <summary>
        /// GET_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x511F1A683387C7E2 = 0x511F1A683387C7E2,
        /// <summary>
        /// p1 ranges from 0.0 to 1.0
        ///
        /// > Ped ped
        /// > float p1
        /// > int p2
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        _0xE3144B932DFDFF65 = 0xE3144B932DFDFF65,
        /// <summary>
        /// If targetPed is set to 0 the ped motivationState affects everyone
        ///
        /// > Ped ped
        /// > int motivationState
        /// > Ped targetPed
        ///
        /// </summary>
        _0x42688E94E96FD9B4 = 0x42688E94E96FD9B4,
        /// <summary>
        /// motivationState: 0 - 10
        ///
        /// > Ped ped
        /// > int motivationState
        /// > float p2
        /// > Ped targetPed
        ///
        /// </summary>
        _0x06D26A96CA1BCA75 = 0x06D26A96CA1BCA75,
        /// <summary>
        /// motivationState = 3: AGITATION_STATE in R* Scripts
        ///
        /// > Ped ped
        /// > int motivationState
        /// > BOOL enabled
        ///
        /// </summary>
        _0x2EB75FB86C41F026 = 0x2EB75FB86C41F026,
        /// <summary>
        /// The higher the modifier, the slower the motivationState value will decrease
        ///
        /// > Ped ped
        /// > int motivationState
        /// > float modifier
        ///
        /// </summary>
        _0xA1EB5D029E0191D3 = 0xA1EB5D029E0191D3,
        /// <summary>
        /// Returns category hash that each ped component has. Hash examples: MASKS, HATS, HEADS, HORSE_MANES
        ///
        /// > Ped ped
        /// > int index
        ///
        /// </summary>
        _0xCCB97B51893C662F = 0xCCB97B51893C662F,
        /// <summary>
        /// Returns p1 value for 0x8E84119A23C16623
        ///
        /// > Entity entity
        /// > Any p1
        ///
        /// </summary>
        _0x62FDF4E678E40CC6 = 0x62FDF4E678E40CC6,
        /// <summary>
        /// Returns requestId
        /// Params: p1 = 1 in R* Scripts
        ///
        /// > Hash model
        /// > int p1
        ///
        /// </summary>
        _0xF97C34C33487D569 = 0xF97C34C33487D569,
        /// <summary>
        /// Returns requestId
        /// Params: p1 = 1 in R* Scripts
        ///
        /// > Hash asset
        /// > int p1
        ///
        /// </summary>
        _0x91FE941F9FCFB702 = 0x91FE941F9FCFB702,
        /// <summary>
        /// Creates prop from metaped asset bundle
        ///
        /// > Hash asset
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > BOOL p7
        /// > BOOL p8
        /// > BOOL p9
        ///
        /// </summary>
        _0x9641A9A20310F6B8 = 0x9641A9A20310F6B8,
        /// <summary>
        /// Creates metaped from ped outfit requestId. See _REQUEST_METAPED_OUTFIT
        ///
        /// > int requestId
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL p8
        ///
        /// </summary>
        _0xEAF682A14F8E5F53 = 0xEAF682A14F8E5F53,
        /// <summary>
        /// Returns peltId
        ///
        /// > Ped horse
        /// > int index
        ///
        /// </summary>
        _0x0CEEB6F4780B1F2F = 0x0CEEB6F4780B1F2F,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        /// > Any p1
        ///
        /// </summary>
        _0xC991EF46FE323867 = 0xC991EF46FE323867,
        CREATE_PED = 0xD49F9B0955C367DE,
        CLONE_PED = 0xEF29A16337FACADB,
        IS_PED_IN_MODEL = 0x796D90EFB19AA332,
        IS_PED_DEAD_OR_DYING = 0x3317DEDB88C95038,
        IS_PED_AIMING_FROM_COVER = 0x3998B1276A3300E5,
        IS_PED_A_PLAYER = 0x12534C348C6CB68B,
        SET_PED_DESIRED_HEADING = 0xAA5A7ECE2AA8FE70,
        _FREEZE_PED_CAMERA_ROTATION = 0xFF287323B0E2C69A,
        IS_PED_STOPPED = 0x530944F6F4B8A214,
        IS_PED_SITTING = 0x84D0BF2B21862059,
        IS_ANY_PED_SHOOTING_IN_AREA = 0xA0D3D71EA1086C55,
        GET_PED_ACCURACY = 0x37F4AD56ECBC0CD6,
        IS_PED_MODEL = 0xC9D55B1A358A5BF7,
        SET_PED_MOVE_ANIMS_BLEND_OUT = 0x9E8C908F41584ECD,
        _GET_NUM_FREE_SLOTS_IN_PED_POOL = 0x313778EDCA9158E2,
        _RESERVE_AMBIENT_PEDS = 0xED9582B3DA8F02B4,
        _RESERVE_AMBIENT_PEDS_TOTAL = 0xF008E0BA1FE1D644,
        _UNRESERVE_AMBIENT_PEDS = 0x7D4E70A67A651C71,
        _GET_NUM_RESERVED_AMBIENT_PEDS_DESIRED = 0x62DE46F061CAA468,
        _GET_NUM_RESERVED_AMBIENT_PEDS_READY = 0x5C16855277819BBF,
        _ARE_ALL_AMBIENT_PED_RESERVATIONS_READY = 0x5E420FF293EE5472,
        _SET_SCENARIO_PED_RANGE_MULTIPLIER_THIS_FRAME = 0xA77FA7BE9312F8C0,
        _SET_AMBIENT_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0xAB0D553FE20A6E25,
        SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0x7A556143A1C03898,
        _SET_AMBIENT_ANIMAL_DENSITY_MULTIPLIER_THIS_FRAME = 0xC0258742B034DFAF,
        _SET_AMBIENT_HUMAN_DENSITY_MULTIPLIER_THIS_FRAME = 0xBA0980B5C0A11924,
        _SET_SCENARIO_ANIMAL_DENSITY_MULTIPLIER_THIS_FRAME = 0xDB48E99F8E064E56,
        _SET_SCENARIO_HUMAN_DENSITY_MULTIPLIER_THIS_FRAME = 0x28CB6391ACEDD9DB,
        INSTANTLY_FILL_PED_POPULATION = 0x4759CC730F947C81,
        CLEAR_PED_NON_CREATION_AREA = 0x2E05208086BA0651,
        SET_PED_ONTO_MOUNT = 0x028F76B6E78246EB,
        _REMOVE_PED_FROM_MOUNT = 0x5337B721C51883A9,
        CREATE_PED_ON_MOUNT = 0xF89AA2BD01FC06B7,
        _IS_MOUNT_SEAT_FREE = 0xAAB0FE202E9FC9F0,
        IS_PED_ON_MOUNT = 0x460BC76A0E10655E,
        IS_PED_FULLY_ON_MOUNT = 0x95CBC65780DE7EB1,
        GET_MOUNT = 0xE7E11B8DCBED1058,
        _GET_LAST_MOUNT = 0x4C8B59171957BCF7,
        SET_PED_OWNS_ANIMAL = 0x931B241409216C1F,
        IS_ANIMAL_INTERACTION_POSSIBLE = 0xD543D3A8FDE4F185,
        IS_PED_ON_SPECIFIC_VEHICLE = 0xEC5F66E459AF3BB2,
        SET_PED_MONEY = 0xA9C8960E8684C1B5,
        GET_PED_MONEY = 0x3F69145BBA87BAE7,
        IS_PED_ON_FOOT = 0x01FEE67DB37F59B2,
        IS_PED_PLANTING_BOMB = 0xC70B5FAE151982D8,
        GET_DEAD_PED_PICKUP_COORDS = 0xCD5003B097200F36,
        IS_PED_IN_ANY_BOAT = 0x2E0E1C2B4F6CB339,
        IS_PED_IN_ANY_HELI = 0x298B91AE825E5705,
        IS_PED_IN_ANY_PLANE = 0x5FFF4CFC74D8FB80,
        IS_PED_IN_FLYING_VEHICLE = 0x9134873537FA419C,
        GET_PED_LAST_DAMAGE_BONE = 0xD75960F6BD9EA49C,
        CLEAR_PED_LAST_DAMAGE_BONE = 0x8EF6B7AC68E2F01B,
        _SET_PED_DAMAGED = 0xDACE03C65C6666DB,
        COMPUTE_SATCHEL_ITEM_FOR_PED_DAMAGE = 0x9E7738B291706746,
        SET_AI_WEAPON_DAMAGE_MODIFIER = 0x1B1E2A40A65B8521,
        RESET_AI_WEAPON_DAMAGE_MODIFIER = 0xEA16670E7BA4743C,
        GET_PED_TO_PLAYER_WEAPON_DAMAGE_MODIFIER = 0x936E7CAD0AE2EE14,
        SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER = 0x66460DEDDD417254,
        _SET_PED_HEADSHOT_DAMAGE_MULTIPLIER = 0x2BA918C823B8BA56,
        SET_PED_CAN_BE_TARGETTED = 0x63F58F7C80513AAD,
        SET_PED_CAN_BE_TARGETTED_BY_TEAM = 0xBF1CA77833E58F2C,
        SET_PED_CAN_BE_TARGETTED_BY_PLAYER = 0x66B57B72E0836A76,
        IS_PED_FALLING = 0xFB92A102F1C4DFA3,
        _IS_PED_SLIDING = 0xD6740E14E4CEFC0B,
        IS_PED_JUMPING = 0xCEDABC5900A0BF97,
        IS_PED_CLIMBING = 0x53E8CB4F48BFE623,
        _IS_PED_CLIMBING_LADDER = 0x59643424B68D52B5,
        IS_PED_VAULTING = 0x117C70D1F5730B5E,
        IS_PED_DIVING = 0x5527B8246FEF9B11,
        IS_PED_IN_ANY_TAXI = 0x6E575D6A898AB852,
        SET_PED_ID_RANGE = 0xF107E836A70DCE05,
        _GET_PED_ID_RANGE = 0x31167ED4324B758D,
        SET_PED_HIGHLY_PERCEPTIVE = 0x52D59AB61DDC05DD,
        SET_PED_SEEING_RANGE = 0xF29CF591C4BF6CEE,
        SET_PED_HEARING_RANGE = 0x33A8F7F7D5F7F33C,
        SET_PED_VISUAL_FIELD_MIN_ANGLE = 0x2DB492222FB21E26,
        SET_PED_VISUAL_FIELD_MAX_ANGLE = 0x70793BDCA1E854D4,
        SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE = 0x9C74B0BC831B753A,
        SET_PED_VISUAL_FIELD_CENTER_ANGLE = 0x3B6405E8AB34A907,
        _SET_PED_CROUCH_MOVEMENT = 0x7DE9692C6F64CFE8,
        GET_PED_CROUCH_MOVEMENT = 0xD5FE956C70FF370B,
        GET_PED_IS_DOING_COMBAT_ROLL = 0xC48A9EB0D499B3E5,
        SET_PED_AS_GROUP_LEADER = 0x2A7819605465FBCE,
        SET_PED_AS_GROUP_MEMBER = 0x9F3480FE65DB31B5,
        REMOVE_GROUP = 0x8EB2F69076AF7053,
        REMOVE_PED_FROM_GROUP = 0xED74007FFB146BC2,
        IS_PED_GROUP_MEMBER = 0x9BB01E3834671191,
        _IS_PED_GROUP_LEADER = 0x878B68960C1C2A35,
        IS_PED_HANGING_ON_TO_VEHICLE = 0x1C86D8AEF8254B78,
        IS_PED_PRONE = 0xD6A86331A537A7B9,
        IS_PED_IN_COMBAT = 0x4859F1FC66A6278E,
        CAN_PED_IN_COMBAT_SEE_TARGET = 0xEAD42DE3610D0721,
        IS_PED_JACKING = 0x4AE4FF911DFB61DA,
        IS_PED_BEING_JACKED = 0x9A497FE2DF198913,
        IS_PED_BEING_STUNNED = 0x4FBACCE3B4138EE8,
        GET_PEDS_JACKER = 0x9B128DC36C1E04CF,
        GET_JACK_TARGET = 0x5486A79D9FBD342D,
        IS_PED_FLEEING = 0xBBCCE00B381F8482,
        IS_PED_IN_COVER = 0x60DFD0691A170B88,
        IS_PED_IN_COVER_FACING_LEFT = 0x845333B3150583AB,
        IS_PED_GOING_INTO_COVER = 0x9F65DBC537E59AD5,
        IS_PED_RESPONDING_TO_THREAT = 0x77525BBF433F2CD6,
        GIVE_PED_HASH_SCENARIO_PROP = 0x2B02DB082258625F,
        GET_SEAT_PED_IS_TRYING_TO_ENTER = 0x6F4C85ACD641BCD2,
        GET_PED_TIME_OF_DEATH = 0x1E98817B311AE98A,
        GET_CURRENT_TARGET_FOR_PED = 0xCD66FEA29400A0B5,
        SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0xADB3F206518799E8,
        _GET_DEFAULT_RELATIONSHIP_GROUP_HASH = 0x3CC4A718C258BDD0,
        SET_PED_RELATIONSHIP_GROUP_HASH = 0xC80A74AC829DDD92,
        SET_RELATIONSHIP_BETWEEN_GROUPS = 0xBF25EB89375A37AD,
        CLEAR_RELATIONSHIP_BETWEEN_GROUPS = 0x5E29243FB56FC6D4,
        REMOVE_RELATIONSHIP_GROUP = 0xB6BA2444AB393DA2,
        GET_RELATIONSHIP_BETWEEN_PEDS = 0xEBA5AD3A0EAF7121,
        GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0x42FDD0F017B1E38E,
        GET_PED_RELATIONSHIP_GROUP_HASH = 0x7DBDD04862D95F04,
        GET_RELATIONSHIP_BETWEEN_GROUPS = 0x9E6B70061662AE5C,
        SET_PED_TO_INFORM_RESPECTED_FRIENDS = 0x112942C6E708F70B,
        SET_PED_FIRING_PATTERN = 0x9AC577F5A12AD8A9,
        GET_COMBAT_FLOAT = 0x52DFF8A10508090A,
        GET_GROUP_SIZE = 0x8DE69FE35CA09A45,
        DOES_GROUP_EXIST = 0x7C6B0C22F9F40BBE,
        IS_PED_IN_GROUP = 0x5891CAC5D4ACFF74,
        GET_PLAYER_PED_IS_FOLLOWING = 0x6A3975DEA89F9A17,
        _GET_GROUP_FORMATION = 0x13A1B061007C906B,
        SET_GROUP_FORMATION_SPACING = 0x1D9D45004C28C916,
        RESET_GROUP_FORMATION_DEFAULT_SPACING = 0x63DAB4CCB3273205,
        ADD_CUSTOM_FORMATION_LOCATION = 0x4E23CD07BD161E06,
        ADD_FORMATION_LOCATION = 0xB05945C1E9E60D91,
        SET_FORMATION_POSITIONS_TARGET_RADIUS = 0x7CC7D3B7AF7FB71F,
        GET_VEHICLE_PED_IS_USING = 0x6094AD011A2EA87D,
        GET_VEHICLE_PED_IS_ENTERING = 0xF92691AED837A5FC,
        _GET_VEHICLE_DRAFT_HORSE_IS_ATTACHED_TO = 0xE4770DA1B8FF4FD1,
        _GET_LAST_VEHICLE_DRAFT_HORSE_WAS_ATTACHED_TO = 0x5064DB5083C29921,
        GET_SEAT_PED_IS_USING = 0x4E76CB57222A00E5,
        _GET_TRANSPORT_PED_IS_SEATED_ON = 0x849BD6C6314793D0,
        IS_PED_ENTERING_ANY_TRANSPORT = 0x1D46B417F926D34D,
        SET_PED_GRAVITY = 0x9FF447B6B6AD960A,
        GET_PED_TYPE = 0xFF059E1E4C01E63C,
        GET_PED_MAX_HEALTH = 0x4700A416E8324EF3,
        SET_PED_MAX_TIME_IN_WATER = 0x43C851690662113D,
        SET_PED_MAX_TIME_UNDERWATER = 0x6BA428C528D9E522,
        CAN_KNOCK_PED_OFF_VEHICLE = 0x51AC07A44D4F5B8A,
        KNOCK_PED_OFF_VEHICLE = 0x45BBCBA77C29A841,
        GET_PED_AS_GROUP_MEMBER = 0x51455483CF23ED97,
        GET_PED_AS_GROUP_LEADER = 0x5CCE68DBD5FE93EC,
        SET_PED_KEEP_TASK = 0x971D38760FBC02EF,
        IS_PED_SWIMMING = 0x9DE327631295B4C2,
        IS_PED_SWIMMING_UNDER_WATER = 0xC024869A53992F34,
        SET_CREATE_RANDOM_COPS = 0x102E68B2024D536D,
        IS_PED_IN_ANY_TRAIN = 0x6F972C1AB75A1ED0,
        IS_PED_GETTING_INTO_A_VEHICLE = 0xBB062B2B5722478E,
        SET_ENABLE_BOUND_ANKLES = 0xC52E0F855C58FC2E,
        RESET_PED_WEAPON_MOVEMENT_CLIPSET = 0x97B0DB5B4AA74E77,
        RESET_PED_IN_VEHICLE_CONTEXT = 0x22EF8FF8778030EB,
        SET_PED_GESTURE_GROUP = 0xDDF803377F94AAA8,
        PED_COWER_IN_PLACE = 0xF6E1E9F47A7686F8,
        PED_COWER_MOVE_TO_POINT = 0x1E4C940233FC0C6F,
        _IS_PED_DRUNK = 0x50F124E6EF188B22,
        GET_ANIM_INITIAL_OFFSET_POSITION = 0xBE22B26DD764C040,
        GET_ANIM_INITIAL_OFFSET_ROTATION = 0x4B805E6046EE9E47,
        SET_PED_RANDOM_COMPONENT_VARIATION = 0xC8A9481A01E63C28,
        KNOCK_OFF_PED_PROP = 0x6FD7816A36615F48,
        SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0x9F8AA94D6D97DBF4,
        _SET_PED_SCALE = 0x25ACFC650B65C538,
        _GET_PED_HEIGHT = 0x1D491CCF7211FB74,
        _GET_PED_SIZE_FROM_MODEL = 0xA65AA1ACE81E5A77,
        REGISTER_TARGET = 0x2F25D9AEFA34FBA2,
        CAN_PED_RAGDOLL = 0x128F79EDCECE4FD5,
        SET_PED_TO_RAGDOLL = 0xAE99FB955581844A,
        SET_PED_TO_RAGDOLL_WITH_FALL = 0xD76632D99E4966C8,
        IS_PED_RUNNING_RAGDOLL_TASK = 0xE3B6097CC25AA69E,
        SET_PED_RAGDOLL_FORCE_FALL = 0x01F6594B923B9251,
        RESET_PED_RAGDOLL_TIMER = 0x9FA4664CF62E47E8,
        SET_PED_CAN_RAGDOLL = 0xB128377056A54E2A,
        IS_PED_RUNNING_MOBILE_PHONE_TASK = 0x2AFE52F782F25775,
        SET_PED_DEFENSIVE_AREA_VOLUME = 0xFC3DB99C8144CD81,
        SET_PED_SPHERE_DEFENSIVE_AREA = 0x9D3151A373974804,
        SET_PED_DEFENSIVE_AREA_DIRECTION = 0x413C6C763A4AFFAD,
        GET_PED_DEFENSIVE_AREA_POSITION = 0x3C06B8786DD94CD1,
        IS_PED_DEFENSIVE_AREA_ACTIVE = 0xBA63D9FE45412247,
        REVIVE_INJURED_PED = 0x8D8ACD8388CD99CE,
        APPLY_PED_BLOOD_SPECIFIC = 0xEF0D582CBF2D9B0F,
        _SET_PED_WOUND_EFFECT = 0xFFD54D9FE71B966A,
        _REMOVE_PED_WOUND_EFFECT = 0x66B1CB778D911F49,
        APPLY_PED_DAMAGE_PACK = 0x46DF918788CB093F,
        CLEAR_PED_BLOOD_DAMAGE = 0x8FE22675A5A45817,
        CLEAR_PED_BLOOD_DAMAGE_BY_ZONE = 0x56E3B78C5408D9F4,
        CLEAR_PED_DAMAGE_DECAL_BY_ZONE = 0x523C79AEEFCC4A2A,
        _CLEAR_PED_BLOOD_DAMAGE_FACIAL = 0x7F5D88333EE8A86F,
        FADE_AND_DESTROY_PED = 0x7043D0681285BA2D,
        CLEAR_PED_ENV_DIRT = 0x6585D955A68452A5,
        SET_PED_SWEAT = 0x27B0405F59637D1F,
        CLEAR_PED_DECORATIONS = 0x0E5173C163976E38,
        ADD_SCENARIO_BLOCKING_AREA = 0x1B5C85C612E5256E,
        REMOVE_SCENARIO_BLOCKING_AREAS = 0xD37401D78A929A49,
        REMOVE_SCENARIO_BLOCKING_AREA = 0x31D16B74C6E29D66,
        IS_PED_USING_ANY_SCENARIO = 0x57AB4A3080F85143,
        IS_PED_USING_THIS_SCENARIO = 0x9C54041BB66BCF9E,
        SET_PED_PANIC_EXIT_SCENARIO = 0xFE07FF6495D52E2A,
        _SET_PED_SHOULD_PLAY_DIRECTED_SCENARIO_EXIT = 0xEC6935EBE0847B90,
        SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT = 0xA3A9299C4F2ADB98,
        SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT = 0xF1C03A5352243A30,
        SET_FACIAL_IDLE_ANIM_OVERRIDE = 0xFFC24B988B938B38,
        CLEAR_FACIAL_IDLE_ANIM_OVERRIDE = 0x726256CC1EEB182F,
        SET_PED_CAN_PLAY_GESTURE_ANIMS = 0xBAF20C5432058024,
        SET_PED_CAN_PLAY_AMBIENT_ANIMS = 0x6373D1349925A70E,
        SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS = 0x0EB0585D15254740,
        SET_PED_CAN_ARM_IK = 0x6C3B4D6D13B4C841,
        SET_PED_CAN_HEAD_IK = 0xC11C18092C5530DC,
        SET_PED_CAN_LEG_IK = 0x73518ECE2485412B,
        SET_PED_CAN_TORSO_IK = 0xF2B7106D37947CE0,
        SET_PED_CAN_TORSO_REACT_IK = 0xF5846EDB26A98A24,
        SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT = 0xEC4686EC06434678,
        IS_PED_HEADTRACKING_PED = 0x5CD3CB88A7F8850D,
        IS_PED_HEADTRACKING_ENTITY = 0x813A0A7C9D2E831F,
        _DISABLE_AMBIENT_LOOK_AT_REQUESTS = 0x80038740C96AD17F,
        _DISABLE_ALL_LOOK_AT_REQUESTS = 0xE1965A380342BE1F,
        SET_PED_CLOTH_PACKAGE_INDEX = 0x78C4E9961DB3EB5B,
        SET_PED_RESET_FLAG = 0xC1E8A365BF3B29F2,
        GET_PED_RESET_FLAG = 0xAF9E59B1B1FBF2A0,
        SET_PED_GROUP_MEMBER_PASSENGER_INDEX = 0x0BDDB8D9EC6BCF3C,
        _IS_THIS_MODEL_A_HORSE = 0x772A1969F649E902,
        SET_PED_MODEL_IS_SUPPRESSED = 0xE163A4BCE4DE6F11,
        _IS_PED_MODEL_SUPPRESSED = 0xAA9F048DCF69B6DC,
        SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT = 0xDF993EE5E90ABA25,
        SET_PED_LEG_IK_MODE = 0xC396F5B86FF9FEBD,
        GET_PED_COMBAT_MOVEMENT = 0xDEA92412FCAEB3F5,
        SET_PED_TARGET_LOSS_RESPONSE = 0x0703B9079823DA4A,
        IS_PED_PERFORMING_MELEE_ACTION = 0xDCCA191DF9980FD7,
        _GET_PED_MELEE_ACTION_PHASE = 0x6127F25ED21C533C,
        IS_PED_BEING_STEALTH_KILLED = 0x863B23EFDE9C5DF2,
        GET_MELEE_TARGET_FOR_PED = 0x18A3E9EE1297FD39,
        _GET_PED_BRAWLING_STYLE = 0xEC6B59BE445FEC51,
        SET_PAUSE_PED_WRITHE_BLEEDOUT = 0x925A160133003AC6,
        GET_PED_IS_GRAPPLING = 0x0E99E3BF11BB6367,
        GET_PED_IS_BEING_GRAPPLED = 0x3BDFCF25B58B0415,
        GET_PED_GRAPPLE_STATE = 0x2311F15D971AA680,
        IS_ANY_PED_NEAR_POINT = 0x083961498679DC9F,
        FORCE_PED_AI_AND_ANIMATION_UPDATE = 0x2208438012482A1A,
        IS_PED_HEADING_TOWARDS_POSITION = 0xFCF37A457CB96DC0,
        REQUEST_PED_VISIBILITY_TRACKING = 0x7D7A2E43E74E2EB8,
        RELEASE_PED_VISIBILITY_TRACKING = 0x3088634CF8C819CF,
        REQUEST_PED_VEHICLE_VISIBILITY_TRACKING = 0x2BC338A7B21F4608,
        CAN_PED_BE_MOUNTED = 0x2D64376CF437363E,
        IS_EVENT_IN_QUEUE = 0xC8D523BF5BBD3808,
        CAN_PED_SEE_PED_CACHED = 0x9D9473CB82D83A30,
        _GET_PED_CURRENT_MOVEMENT_SPEED = 0xF60165E1D2C5370B,
        SET_PED_MAX_MOVE_BLEND_RATIO = 0x433083750C5E064A,
        SET_PED_MIN_MOVE_BLEND_RATIO = 0x01A898D26E2333DD,
        GET_PED_NEARBY_VEHICLES = 0xCFF869CBFA210D82,
        GET_PED_NEARBY_PEDS = 0x23F8F5FC7E8C4A6B,
        IS_PED_READY_TO_RENDER = 0xA0BC8FAED8CFEB3C,
        IS_PED_USING_ACTION_MODE = 0x00E73468D085F745,
        SET_PED_USING_ACTION_MODE = 0xD75ACCF5E0FB5367,
        _GET_RIDER_OF_MOUNT = 0xB676EFDA03DADA52,
        SPAWNPOINTS_START_SEARCH = 0x2DF9038C90AD5264,
        SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA = 0xB2AFF10216DEFA2F,
        _SPAWNPOINTS_START_SEARCH_WITH_VOLUME = 0x83ED1FC9DF3411F5,
        SPAWNPOINTS_CANCEL_SEARCH = 0xFEE4A5459472A9F8,
        SPAWNPOINTS_IS_SEARCH_ACTIVE = 0x3C67506996001F5E,
        SPAWNPOINTS_IS_SEARCH_COMPLETE = 0xA586FBEB32A53DBB,
        SPAWNPOINTS_IS_SEARCH_FAILED = 0xF445DE8DA80A1792,
        SPAWNPOINTS_GET_NUM_SEARCH_RESULTS = 0xA635C11B8C44AFC2,
        SPAWNPOINTS_GET_SEARCH_RESULT = 0x280C7E3AC7F56E90,
        SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS = 0xB782F8238512BAD5,
        SET_IK_TARGET = 0xC32779C16FCEECD9,
        _REQUEST_MOTION_TYPE_ASSET = 0xF7EA250B9A919E03,
        HAS_MOTION_TYPE_ASSET_LOADED = 0x854BC9B1A1CCD034,
        _REMOVE_MOTION_TYPE_ASSET = 0xDE7B2B4144906CDF,
        SET_PED_LOD_MULTIPLIER = 0xDC2C5C242AAC342B,
        IS_ANY_HOSTILE_PED_NEAR_POINT = 0x68772DB2B2526F9F,
        IS_TARGET_PED_IN_PERCEPTION_AREA = 0x06087579E7AA85A9,
        SET_POP_CONTROL_SPHERE_THIS_FRAME = 0xD8C3BE3EE94CAF2D,
        IS_PED_HOGTIED = 0x3AA24CCC0D451379,
        IS_PED_BEING_HOGTIED = 0xD453BB601D4A606E,
        IS_PED_HOGTYING = 0x42429C674B61238B,
        SET_PED_LASSO_HOGTIE_FLAG = 0xAE6004120C18DF97,
        _GET_FIRST_ENTITY_PED_IS_CARRYING = 0xD806CD2A4F2C2996,
        _GET_CARRIER_AS_PED = 0x09B83E68DE004CD4,
        _GET_CARRIER_AS_MOUNT = 0xA033D7E4BBF9844D,
        _GET_CARRIER_AS_HUMAN = 0x79443D56C8DF45EE,
        GET_CARRIED_ATTACHED_INFO_FOR_SLOT = 0x608BC6A6AACD5036,
        DETACH_CARRIABLE_ENTITY = 0xED00D72F81CF7278,
        FIND_ALL_ATTACHED_CARRIABLE_ENTITIES = 0xB5ACE8B23A438EC0,
        IS_PED_CARRYING_SOMETHING = 0xA911EE21EDF69DAF,
        IS_PED_LASSOED = 0x9682F850056C9ADE,
        _GET_LASSOER_OF_PED = 0x833F0053340EF413,
        _GET_LASSO_TARGET = 0xB65A4DAB460A19BD,
        GET_LOOTING_PICKUP_TARGET_ENTITY = 0x14169FA823679E41,
        IS_PED_INCAPACITATED = 0xB655DB7582AEC805,
        _SET_PED_INCAPACITATION_MODIFIERS = 0x39ED303390DDEAC7,
        _GET_PED_CAN_BE_INCAPACITATED_THIS_FRAME = 0x7A4E00364B5D727B,
        SET_PED_CAN_BE_INCAPACITATED = 0x5240864E847C691C,
        _SET_PED_INCAPACITATION_FLAGS = 0xD67B6F3BCF81BA47,
        _INCAPACITATED_REVIVE = 0xF6262491C7704A63,
        _IS_PED_DRAGGING = 0x226CF9B159E38F42,
        IS_PED_BEING_DRAGGED = 0xEF3A8772F085B4AA,
        _ADD_PED_STAY_OUT_VOLUME = 0xE9B168527B337BF0,
        _REMOVE_PED_STAY_OUT_VOLUME = 0x0CAB404CD2DB41F5,
        GET_PED_MOTION_FOCUS_ENTITY = 0x243E1B4607040057,
        _SET_PED_FACE_FEATURE = 0x5653AB26C82938CF,
        _GET_PED_FACE_FEATURE = 0xFD1BA1EEF7985BB8,
        IS_PED_FALLING_OVER = 0x3E592D0486DEC0F6,
        _SET_PED_CULL_RANGE = 0x8AC1D721B2097B6E,
        _IS_METAPED_USING_COMPONENT = 0xFB4891BD7578CDC1,
        _IS_PED_CHILD = 0x137772000DAF42C5,
        REMOVE_TAG_FROM_META_PED = 0xD710A5007C2AC539,
        _GET_NUM_COMPONENTS_IN_PED = 0x90403E8107B60E81,
        _SET_PED_BODY_COMPONENT = 0x1902C4CFCC5BE57C,
        _GET_PED_META_OUTFIT_HASH = 0x30569F348D126A5A,
        _DOES_METAPED_OUTFIT_EXIST_FOR_PED_MODEL = 0xC0E880B7A441164D,
        _SET_RANDOM_OUTFIT_VARIATION = 0x283978A15512B2FE,
        GET_NUM_META_PED_OUTFITS = 0x10C70A515BC03707,
        _REQUEST_METAPED_OUTFIT = 0x13154A76CE0CF9AB,
        _RELEASE_METAPED_OUTFIT_REQUEST = 0x4592B8B9B0EF5F48,
        _IS_METAPED_OUTFIT_REQUEST_VALID = 0xB25E57FC8E37114D,
        _APPLY_PED_METAPED_OUTFIT = 0x74F512E29CB717E2,
        _SET_METAPED_WEARINESS = 0x314C5465195F3B30,
        _GET_PED_STAMINA = 0x775A1CA7893AA8B5,
        _GET_PED_MAX_STAMINA = 0xCB42AFE2B613EE55,
        _GET_PED_LAST_DROPPED_HAT = 0x1F714E7A9DADFC42,
        _OVERRIDE_TEXTURE_ON_PED = 0x0B46E25761519058,
        _RELEASE_TEXTURE = 0x6BEFAA907B076859,
        _UPDATE_PED_TEXTURE = 0x92DAABA2C1C10B0E,
        _RESET_PED_TEXTURE = 0x8472A1789478F82F,
        _IS_TEXTURE_VALID = 0x31DC8D3F216D8509,
        _ADD_TEXTURE_LAYER = 0x86BB5FF45F193A02,
        _REMOVE_PED_OVERLAY = 0x96C349DE04C49011,
        _SET_TEXTURE_LAYER_SHEET_GRID_INDEX = 0x3329AAE2882FC8E4,
        _SET_TEXTURE_LAYER_ALPHA = 0x6C76BC24F8BB709A,
        _SET_TEXTURE_LAYER_ROUGHNESS = 0x057C4F092E2298BE,
        _SET_TEXTURE_LAYER_PALLETE = 0x1ED8588524AC9BE1,
        _SET_TEXTURE_LAYER_MOD = 0xF2EA041F1146D75B,
        _SET_TEXTURE_LAYER_TEXTURE_MAP = 0x253A63B5BADBC398,
        _RESET_PED_TEXTURE_2 = 0xB63B9178D0F58D82,
        IS_LOCATION_SPAWN_SAFE = 0xFB1E7998B8595825,
        RESET_HORSE_AVOIDANCE_LEVEL_TO_DEFAULT = 0x2A5AFD2B8381A6E1,
        GET_META_PED_ASSET_GUIDS = 0xA9C28516A6DC9D56,
        GET_META_PED_ASSET_TINT = 0xE7998FEC53A33BBE,
        _SET_PED_BLACKBOARD_BOOL = 0xCB9401F918CB0F75,
        _SET_PED_BLACKBOARD_FLOAT = 0x437C08DB4FEBE2BD,
        GET_PED_BLACKBOARD_SCRIPT_INT = 0xB71B91B398F8F067,
        GET_PED_BLACKBOARD_SCRIPT_BOOL = 0x4912DFE492DB98CD,
        GET_PED_BLACKBOARD_SCRIPT_FLOAT = 0xA29FD00D45311EB7,
        _APPLY_SHOP_ITEM_TO_PED = 0xD3A7B003ED343FD9,
        REMOVE_SHOP_ITEM_FROM_PED_BY_CATEGORY = 0xDF631E4BCE1B1FC4,
        _GET_PED_COMPONENT_AT_INDEX = 0x77BA37622E22023B,
        _GET_PED_COMPONENT_CATEGORY = 0x5FF9A878C3D115B8,
        _SET_PED_PROMPT_NAME_FROM_GXT_ENTRY = 0xFCA8FB9E15FA80D3,
        _SET_PED_PROMPT_NAME = 0x4A48B6E03BABB4AC,
        _SET_PED_TRAIL_EFFECT = 0xA5950E16B8F31052,
        _0x39A2FC5AF55A52B1 = 0x39A2FC5AF55A52B1,
        _0x7C08E7CB8D951B70 = 0x7C08E7CB8D951B70,
        _0x36E4B61DC56DE77C = 0x36E4B61DC56DE77C,
        _0x9851DE7AEC10B4E1 = 0x9851DE7AEC10B4E1,
        _0x66C047719B0E80E1 = 0x66C047719B0E80E1,
        _0x0E2F43516F998269 = 0x0E2F43516F998269,
        _0x6DB875AFC584FA32 = 0x6DB875AFC584FA32,
        _0x09D7AFD3716DA8E1 = 0x09D7AFD3716DA8E1,
        _0x9C81338B2E62CE0A = 0x9C81338B2E62CE0A,
        _0xB7DBB2986B87E230 = 0xB7DBB2986B87E230,
        _0xD355E2F1BB41087E = 0xD355E2F1BB41087E,
        _0x285D36C5C72B0569 = 0x285D36C5C72B0569,
        _0x5CA20FBE49891BBD = 0x5CA20FBE49891BBD,
        _0xC6136B40FFFB778B = 0xC6136B40FFFB778B,
        _0x6E8B87139854022D = 0x6E8B87139854022D,
        _0x9E3842E5DAD69F80 = 0x9E3842E5DAD69F80,
        _0xBFA6B7731C3BAF02 = 0xBFA6B7731C3BAF02,
        _0x0EE3F0D7FECCC54F = 0x0EE3F0D7FECCC54F,
        _0x7C00CFC48A782DC0 = 0x7C00CFC48A782DC0,
        _0x19C975B81BE53C28 = 0x19C975B81BE53C28,
        _0x693126B5D0457D0D = 0x693126B5D0457D0D,
        _0xED1C764997A86D5A = 0xED1C764997A86D5A,
        _0xB8AB265426CFE6DD = 0xB8AB265426CFE6DD,
        _0xE8D1CCB9375C101B = 0xE8D1CCB9375C101B,
        _0xA691C10054275290 = 0xA691C10054275290,
        _0x6734F0A6A52C371C = 0x6734F0A6A52C371C,
        _0x024EC9B649111915 = 0x024EC9B649111915,
        _0xF103823FFE72BB49 = 0xF103823FFE72BB49,
        _0xBCC76708E5677E1D = 0xBCC76708E5677E1D,
        _0x454AD4DA6C41B5BD = 0x454AD4DA6C41B5BD,
        _0x54D3CD482742C482 = 0x54D3CD482742C482,
        _0x5CB2EBB467BE3ED6 = 0x5CB2EBB467BE3ED6,
        _0x9F0F28B42C4EE80A = 0x9F0F28B42C4EE80A,
        _0xA69899995997A63B = 0xA69899995997A63B,
        _0x9B65444C07B782BF = 0x9B65444C07B782BF,
        _0x7FC84E85D98F063D = 0x7FC84E85D98F063D,
        _0x8BE24D74D74C6E9B = 0x8BE24D74D74C6E9B,
        _0x77243ED4F7CAAA55 = 0x77243ED4F7CAAA55,
        _0xE0B61ED8BB37712F = 0xE0B61ED8BB37712F,
        _0x9911F4A24485F653 = 0x9911F4A24485F653,
        _0x34EDDD59364AD74A = 0x34EDDD59364AD74A,
        _0x2D976DBDC731DF80 = 0x2D976DBDC731DF80,
        _0x256EDD55C6BE1482 = 0x256EDD55C6BE1482,
        _0x9EFF3C91DF38304F = 0x9EFF3C91DF38304F,
        _0x0F9E754EBE8FDBFA = 0x0F9E754EBE8FDBFA,
        _0xB29C553BA582D09E = 0xB29C553BA582D09E,
        _0x101B45C5F56D970F = 0x101B45C5F56D970F,
        _0x6B89FAA36FC909A3 = 0x6B89FAA36FC909A3,
        _0x73B6F907B913C860 = 0x73B6F907B913C860,
        _0xA6D6F03095C88F59 = 0xA6D6F03095C88F59,
        _0x92C8EACA29F6BED6 = 0x92C8EACA29F6BED6,
        _0x069EDDF1FD4DEB0A = 0x069EDDF1FD4DEB0A,
        _0x763FA8A9D76EE3A7 = 0x763FA8A9D76EE3A7,
        _0xC2266AA617668AD3 = 0xC2266AA617668AD3,
        _0xDC9273D95976BA22 = 0xDC9273D95976BA22,
        _0xDEE8D30AA5C2E28D = 0xDEE8D30AA5C2E28D,
        _0xE1B3BE07D3AADDED = 0xE1B3BE07D3AADDED,
        _0x32CEDA9A0AB4CEF7 = 0x32CEDA9A0AB4CEF7,
        _0x52A24D8A1DA89658 = 0x52A24D8A1DA89658,
        _0x34B5CEAC180A5D6E = 0x34B5CEAC180A5D6E,
        _0x4F27603E44A8E4C0 = 0x4F27603E44A8E4C0,
        _0xE50C9816B3F22D8B = 0xE50C9816B3F22D8B,
        _0x9B6808EC46BE849B = 0x9B6808EC46BE849B,
        _0x7883AA809DF43D98 = 0x7883AA809DF43D98,
        _0xC5B78E41DCF8227C = 0xC5B78E41DCF8227C,
        _0xFECA2081F61ED2CD = 0xFECA2081F61ED2CD,
        _0x577C60BA06D0EA64 = 0x577C60BA06D0EA64,
        _0x5C6C7C70CA302801 = 0x5C6C7C70CA302801,
        _0xB91AB3BE7F655D49 = 0xB91AB3BE7F655D49,
        _0xEC4B4B3B9908052A = 0xEC4B4B3B9908052A,
        _0x733C87D4CE22BEA2 = 0x733C87D4CE22BEA2,
        _0x028E7B3BBA0BD2FC = 0x028E7B3BBA0BD2FC,
        _0xFA8C10DCE0706D43 = 0xFA8C10DCE0706D43,
        _0x43CA928E892CFDB8 = 0x43CA928E892CFDB8,
        _0x2BA9D7BF629F920C = 0x2BA9D7BF629F920C,
        _0x900CA00CE703E1E2 = 0x900CA00CE703E1E2,
        _0x9AB33CB5834885B3 = 0x9AB33CB5834885B3,
        _0x899DFA0009AC93DE = 0x899DFA0009AC93DE,
        _0x3A5697B80FED5EBE = 0x3A5697B80FED5EBE,
        _0x89E59DBD15E21177 = 0x89E59DBD15E21177,
        _0x7583A9D35248B83F = 0x7583A9D35248B83F,
        _0x2DD4E0E26DFAD97D = 0x2DD4E0E26DFAD97D,
        _0x06FA94C835787C64 = 0x06FA94C835787C64,
        _0xBD6B242B8BD5543A = 0xBD6B242B8BD5543A,
        _0xC22AA08A8ADB87D4 = 0xC22AA08A8ADB87D4,
        _0x569F1E1237508DEB = 0x569F1E1237508DEB,
        _0x3BBDD6143FF16F98 = 0x3BBDD6143FF16F98,
        _0xA0774E388CE4A679 = 0xA0774E388CE4A679,
        _0xBEC65C6049B3219D = 0xBEC65C6049B3219D,
        _0xBDED916A9F9B0604 = 0xBDED916A9F9B0604,
        _0x4D0D2E3D8BC000EB = 0x4D0D2E3D8BC000EB,
        _0x5407B7288D0478B7 = 0x5407B7288D0478B7,
        _0x7BE607DAFF382FD2 = 0x7BE607DAFF382FD2,
        _0x336B3D200AB007CB = 0x336B3D200AB007CB,
        _0xDC91F22F09BC6C2F = 0xDC91F22F09BC6C2F,
        _0x9629FAF6460D35CB = 0x9629FAF6460D35CB,
        _0x4E68C7EF706DF35D = 0x4E68C7EF706DF35D,
        _0x3ACCE14DFA6BA8C2 = 0x3ACCE14DFA6BA8C2,
        _0x40C9155AF8BC13F3 = 0x40C9155AF8BC13F3,
        _0xF4860514AD354226 = 0xF4860514AD354226,
        _0x5E9FAF6C513347B4 = 0x5E9FAF6C513347B4,
        _0x326F7951EF0D7F75 = 0x326F7951EF0D7F75,
        _0xE76687023D8C8505 = 0xE76687023D8C8505,
        _0xCB8F4C9343EBE240 = 0xCB8F4C9343EBE240,
        _0x20E54854DEF6A54A = 0x20E54854DEF6A54A,
        _0x244E8C282188E40F = 0x244E8C282188E40F,
        _0x3C529A827998F9B3 = 0x3C529A827998F9B3,
        _0x1F44B7E283C09EDE = 0x1F44B7E283C09EDE,
        _0x0455546F23FF08E4 = 0x0455546F23FF08E4,
        _0x909AD9E9A92A10DF = 0x909AD9E9A92A10DF,
        _0x917760CFE7A0E0F1 = 0x917760CFE7A0E0F1,
        _0xB05CC690CDE8A4A9 = 0xB05CC690CDE8A4A9,
        _0x478F6B9920446CE2 = 0x478F6B9920446CE2,
        _0x0E9E95FDEDCC9D35 = 0x0E9E95FDEDCC9D35,
        _0x8AF8E647D6B2A649 = 0x8AF8E647D6B2A649,
        _0x87C2724A56F66020 = 0x87C2724A56F66020,
        _0xD5BD1B5318A81994 = 0xD5BD1B5318A81994,
        _0x9BBEAF8B0C007F1E = 0x9BBEAF8B0C007F1E,
        _0xC99F104BDF8C7F5A = 0xC99F104BDF8C7F5A,
        _0x02E741E19E39628C = 0x02E741E19E39628C,
        _0x97C475212B327666 = 0x97C475212B327666,
        _0x154B7E841AC7412F = 0x154B7E841AC7412F,
        _0x8AFCCC0F18D70018 = 0x8AFCCC0F18D70018,
        _0xE1103300F3456DE7 = 0xE1103300F3456DE7,
        _0xA8A95CECB1906EA2 = 0xA8A95CECB1906EA2,
        _0xDDFAD4DEAA7FA362 = 0xDDFAD4DEAA7FA362,
        _0x966DE09688A1DE39 = 0x966DE09688A1DE39,
        _0x7E5185B979706210 = 0x7E5185B979706210,
        _0x40C3524D4ED83554 = 0x40C3524D4ED83554,
        _0x86FAFC18E3D4380C = 0x86FAFC18E3D4380C,
        _0x07EA5B053FA60AC7 = 0x07EA5B053FA60AC7,
        _0xF9CBD46433E36713 = 0xF9CBD46433E36713,
        _0x96595B36D6A2279B = 0x96595B36D6A2279B,
        _0x7FB0088E8769CDDB = 0x7FB0088E8769CDDB,
        _0xA90684ED185CCB4B = 0xA90684ED185CCB4B,
        _0x8B3CB08158E98481 = 0x8B3CB08158E98481,
        _0x1CE875505D45338A = 0x1CE875505D45338A,
        _0xBAD2A311667A50D7 = 0xBAD2A311667A50D7,
        _0x405180B14DA5A935 = 0x405180B14DA5A935,
        _0x24C82EF607105FAA = 0x24C82EF607105FAA,
        _0xD7AD3C7EBAF88C92 = 0xD7AD3C7EBAF88C92,
        _0x329772C47DBB2FBC = 0x329772C47DBB2FBC,
        _0x331550B212014B92 = 0x331550B212014B92,
        _0x94132D7C8D3575C4 = 0x94132D7C8D3575C4,
        _0x8AF46E5159A5B620 = 0x8AF46E5159A5B620,
        _0x45FEA6D5539BD474 = 0x45FEA6D5539BD474,
        _0x20C5459379D75C1C = 0x20C5459379D75C1C,
        _0xE37ACEE15AC50C7E = 0xE37ACEE15AC50C7E,
        _0xA3C53CDE922BC78B = 0xA3C53CDE922BC78B,
        _0x41C23A8E6B344867 = 0x41C23A8E6B344867,
        _0x9337183FDA2E9035 = 0x9337183FDA2E9035,
        _0xA454D234E45BB6E5 = 0xA454D234E45BB6E5,
        _0xA7DC9266ED6A4E51 = 0xA7DC9266ED6A4E51,
        _0x89816B58C3466262 = 0x89816B58C3466262,
        _0x97B06669AC569003 = 0x97B06669AC569003,
        _0x85F500F4E24CA43E = 0x85F500F4E24CA43E,
        _0x9B9B9FA0EA283E3D = 0x9B9B9FA0EA283E3D,
        _0xEC60D1D225BC50AA = 0xEC60D1D225BC50AA,
        _0x12F2D161BF4031FC = 0x12F2D161BF4031FC,
        _0x0ADA3EC589E1736E = 0x0ADA3EC589E1736E,
        _0xE33F98BD76490ABC = 0xE33F98BD76490ABC,
        _0xD55DB4466D00A258 = 0xD55DB4466D00A258,
        _0x7DD7FB3480D8083E = 0x7DD7FB3480D8083E,
        _0xAF041C10756C30FB = 0xAF041C10756C30FB,
        _0x5AF24CA9C974E51A = 0x5AF24CA9C974E51A,
        _0xDC88D06719070C39 = 0xDC88D06719070C39,
        _0x550CB89DD7F4FA3D = 0x550CB89DD7F4FA3D,
        _0x8822F139408B8D0A = 0x8822F139408B8D0A,
        _0x8822F124788B8D0A = 0x8822F124788B8D0A,
        _0x3AE3552E7C207CC5 = 0x3AE3552E7C207CC5,
        _0x88A95BB640FC186F = 0x88A95BB640FC186F,
        _0x878E8104FA27CDAE = 0x878E8104FA27CDAE,
        _0x58F7DB5BD8FA2288 = 0x58F7DB5BD8FA2288,
        _0x2371C39D4F91C288 = 0x2371C39D4F91C288,
        _0x16F798A05BB9E3B5 = 0x16F798A05BB9E3B5,
        _0xAAB050DA48B57978 = 0xAAB050DA48B57978,
        _0x935CF6E42BAF7F4D = 0x935CF6E42BAF7F4D,
        _0x32CCAD8A981B53D3 = 0x32CCAD8A981B53D3,
        _0x406CCF555B04FAD3 = 0x406CCF555B04FAD3,
        _0x268B3AEBF032A88D = 0x268B3AEBF032A88D,
        _0xC17A94CC8FC3C61A = 0xC17A94CC8FC3C61A,
        _0x134775B093AD5C38 = 0x134775B093AD5C38,
        _0xD8736EFDA38EDC5C = 0xD8736EFDA38EDC5C,
        _0x6E5CBCB3941D7D08 = 0x6E5CBCB3941D7D08,
        _0x4707E9C23D8CA3FE = 0x4707E9C23D8CA3FE,
        _0x221F4D9912B7FE86 = 0x221F4D9912B7FE86,
        _0x8CB2553C559102C1 = 0x8CB2553C559102C1,
        _0xFD3C31A2E45671E7 = 0xFD3C31A2E45671E7,
        _0x3AEC4A410ECAF30D = 0x3AEC4A410ECAF30D,
        _0x9F933E0985E12C51 = 0x9F933E0985E12C51,
        _0x88B2026A3B0BE33D = 0x88B2026A3B0BE33D,
        _0x1854217C640B39EC = 0x1854217C640B39EC,
        _0xEB2BFE5D009F0331 = 0xEB2BFE5D009F0331,
        _0xEF2E6F870783369B = 0xEF2E6F870783369B,
        _0x4EC4EA2F72B36358 = 0x4EC4EA2F72B36358,
        _0xCF0B19806473D324 = 0xCF0B19806473D324,
        _0xB4B7C92FCE7347B7 = 0xB4B7C92FCE7347B7,
        _0x7020839C7302D8AC = 0x7020839C7302D8AC,
        _0xE1AADD0055D76603 = 0xE1AADD0055D76603,
        _0x5A1A929C8B729B4A = 0x5A1A929C8B729B4A,
        _0x97A38B65EBDA3D50 = 0x97A38B65EBDA3D50,
        _0x06A10B4D7F50B0C3 = 0x06A10B4D7F50B0C3,
        _0x88A5564B19C15391 = 0x88A5564B19C15391,
        _0x354CA4DDDEEC397A = 0x354CA4DDDEEC397A,
        _0xFEA6126C34DF2532 = 0xFEA6126C34DF2532,
        _0xA967D6A8ED2D713B = 0xA967D6A8ED2D713B,
        _0x58D32261AE0F0843 = 0x58D32261AE0F0843,
        _0x735662994E60A710 = 0x735662994E60A710,
        _0x91BAB9E064F036CD = 0x91BAB9E064F036CD,
        _0x897934E868EDDD6C = 0x897934E868EDDD6C,
        _0x34C11114887150FD = 0x34C11114887150FD,
        _0xD8544F6260F5F01E = 0xD8544F6260F5F01E,
        _0xEB8886E1065654CD = 0xEB8886E1065654CD,
        _0x8D9BFCE3352DE47F = 0x8D9BFCE3352DE47F,
        _0xF9CFF5BB70E8A2CB = 0xF9CFF5BB70E8A2CB,
        _0xA7A806677F8DE138 = 0xA7A806677F8DE138,
        _0xA064BBABB064446F = 0xA064BBABB064446F,
        _0x4C39C95AE5DB1329 = 0x4C39C95AE5DB1329,
        _0x6F46F8ACB44C4FC1 = 0x6F46F8ACB44C4FC1,
        _0x91A5F9CBEBB9D936 = 0x91A5F9CBEBB9D936,
        _0xAB643407D0B26F07 = 0xAB643407D0B26F07,
        _0x1148F706CF4EBDDA = 0x1148F706CF4EBDDA,
        _0x9A77DFD295E29B09 = 0x9A77DFD295E29B09,
        _0xD8CEEED54C672B5D = 0xD8CEEED54C672B5D,
        _0xF9331B3A314EB49D = 0xF9331B3A314EB49D,
        _0xE735A7DA22E88359 = 0xE735A7DA22E88359,
        _0x82CB0F3F0C7785E5 = 0x82CB0F3F0C7785E5,
        _0xCA95C156C14B2054 = 0xCA95C156C14B2054,
        _0xD2F0FE8805D91647 = 0xD2F0FE8805D91647,
        _0x7EDB3C766B0D073F = 0x7EDB3C766B0D073F,
        _0x4F63433CE3C08230 = 0x4F63433CE3C08230,
        _0x6647C5F6F5792496 = 0x6647C5F6F5792496,
        _0xCD9E5F94A2F38683 = 0xCD9E5F94A2F38683,
        _0x1D4636C90BBEFACB = 0x1D4636C90BBEFACB,
        _0xEF371232BC6053E1 = 0xEF371232BC6053E1,
        _0x86F0B6730C32AC14 = 0x86F0B6730C32AC14,
        _0x8101BA1C0B462412 = 0x8101BA1C0B462412,
        _0xC6981AFF6D2A71C2 = 0xC6981AFF6D2A71C2,
        _0xE0FE107AB174D64A = 0xE0FE107AB174D64A,
        _0x7ABBD9E449E0DB00 = 0x7ABBD9E449E0DB00,
        _0xADD31A5C7A5FAA73 = 0xADD31A5C7A5FAA73,
        _0xE6CB36F43A95D75F = 0xE6CB36F43A95D75F,
        _0x078076AB50FB117F = 0x078076AB50FB117F,
        _0x815C0074A1BC0D93 = 0x815C0074A1BC0D93,
        _0xFFDE295662405B25 = 0xFFDE295662405B25,
        _0xCC2B20596E29E4E3 = 0xCC2B20596E29E4E3,
        _0x0A4618FFD517E24D = 0x0A4618FFD517E24D,
        _0x712B2C2B2471B493 = 0x712B2C2B2471B493,
        _0x00B380FF2DF6AB7A = 0x00B380FF2DF6AB7A,
        _0x1FA132CBCD7CB239 = 0x1FA132CBCD7CB239,
        _0x5BF0B9D9A8E227A0 = 0x5BF0B9D9A8E227A0,
        _0x642720D8D69328B6 = 0x642720D8D69328B6,
        _0x99DF2639DA76C1DC = 0x99DF2639DA76C1DC,
        _0xDEDBED3020DA49DC = 0xDEDBED3020DA49DC,
        _0xA405BF9F01960C16 = 0xA405BF9F01960C16,
        _0x9D8DFE2DE9CB4DFC = 0x9D8DFE2DE9CB4DFC,
        _0xC48AF420371C7407 = 0xC48AF420371C7407,
        _0x5EFA8A3D8A60D662 = 0x5EFA8A3D8A60D662,
        _0x242EDF85D4E87B65 = 0x242EDF85D4E87B65,
        _0x9238A3D970BBB0A9 = 0x9238A3D970BBB0A9,
        _0x9A4AC116CC1EEE14 = 0x9A4AC116CC1EEE14,
        _0xE20027B414BFE6C7 = 0xE20027B414BFE6C7,
        _0x6DBF2D78709AD70B = 0x6DBF2D78709AD70B,
        _0xB8DE69D9473B7593 = 0xB8DE69D9473B7593,
        _0x949B2F9ED2917F5D = 0x949B2F9ED2917F5D,
        _0xB346C85D49CC998E = 0xB346C85D49CC998E,
        _0xC163DAC52AC975D3 = 0xC163DAC52AC975D3,
        _0xBBF6D1D07C02D00A = 0xBBF6D1D07C02D00A,
        _0x02AA2096FE00F3E1 = 0x02AA2096FE00F3E1,
        _0x57F35552E771BE9D = 0x57F35552E771BE9D,
        _0x7C10221CE718AA72 = 0x7C10221CE718AA72,
        _0x0D3B1568917EBDA0 = 0x0D3B1568917EBDA0,
        _0x29F3539189D3E277 = 0x29F3539189D3E277,
        _0xE9E06EA514A69061 = 0xE9E06EA514A69061,
        _0x4DB9D03AC4E1FA84 = 0x4DB9D03AC4E1FA84,
        _0x12EB4E31F092C9B3 = 0x12EB4E31F092C9B3,
        _0xD0B7AEB56229D317 = 0xD0B7AEB56229D317,
        _0x753B15AD0FD6F3E3 = 0x753B15AD0FD6F3E3,
        _0x604190F0CF0DF158 = 0x604190F0CF0DF158,
        _0x789DABD18E9024DB = 0x789DABD18E9024DB,
        _0xEAE3B5B019C8D23F = 0xEAE3B5B019C8D23F,
        _0xF3C873ED0C595109 = 0xF3C873ED0C595109,
        _0x8301D87B1B89E219 = 0x8301D87B1B89E219,
        _0x99A6E246C315BF60 = 0x99A6E246C315BF60,
        _0x56E9C26CD29D1ED6 = 0x56E9C26CD29D1ED6,
        _0xB086C8C0F5701D14 = 0xB086C8C0F5701D14,
        _0xC2722B252C79E641 = 0xC2722B252C79E641,
        _0xC488B8C0E52560D8 = 0xC488B8C0E52560D8,
        _0x2DC0E8DCBD3546E9 = 0x2DC0E8DCBD3546E9,
        _0x6D07B371E9439019 = 0x6D07B371E9439019,
        _0xD65FDC686A031C83 = 0xD65FDC686A031C83,
        _0x68821369A2CEADD5 = 0x68821369A2CEADD5,
        _0x164CECC59E70DF86 = 0x164CECC59E70DF86,
        _0x5102307CE88798EB = 0x5102307CE88798EB,
        _0x118D476A6F1A13F1 = 0x118D476A6F1A13F1,
        _0x0EA9EACBA3B01601 = 0x0EA9EACBA3B01601,
        _0xC5303F460A40D21D = 0xC5303F460A40D21D,
        _0xE29D8CD66553DBAA = 0xE29D8CD66553DBAA,
        _0xB06F5F1DEF417216 = 0xB06F5F1DEF417216,
        _0xFC23348F0F4E245F = 0xFC23348F0F4E245F,
        _0x9184788BFF1EDAD7 = 0x9184788BFF1EDAD7,
        _0x0105FEE8F9091255 = 0x0105FEE8F9091255,
        _0xD049920CD29F6CC8 = 0xD049920CD29F6CC8,
        _0xBB3E5370EBB6BE28 = 0xBB3E5370EBB6BE28,
        _0x2FA568BFA725F8D6 = 0x2FA568BFA725F8D6,
        _0x56E4BAD93D33453C = 0x56E4BAD93D33453C,
        _0x75A082563B4452E5 = 0x75A082563B4452E5,
        _0x16802C32B2FCA06B = 0x16802C32B2FCA06B,
        _0x8BA0C65AC15A7D33 = 0x8BA0C65AC15A7D33,
        _0x0FFDF937E5C11382 = 0x0FFDF937E5C11382,
        _0x5FCF25D584065BFD = 0x5FCF25D584065BFD,
        _0xA2116C1E4ED85C24 = 0xA2116C1E4ED85C24,
        _0x75D3333409CD33CE = 0x75D3333409CD33CE,
        _0xBC1DC48270468444 = 0xBC1DC48270468444,
        _0x46BF2A810679D6E6 = 0x46BF2A810679D6E6,
        _0xCA95924C893A0C91 = 0xCA95924C893A0C91,
        _0xBAE08F00021BFFB2 = 0xBAE08F00021BFFB2,
        _0x413697EC260AABBF = 0x413697EC260AABBF,
        _0xCAC43D060099EA72 = 0xCAC43D060099EA72,
        _0xC9151483CC06A414 = 0xC9151483CC06A414,
        _0xAD3330E3C3E98007 = 0xAD3330E3C3E98007,
        _0xB8E2D655E1D5BD39 = 0xB8E2D655E1D5BD39,
        _0x7BB810E8B343AC7B = 0x7BB810E8B343AC7B,
        _0x6A489892E813951A = 0x6A489892E813951A,
        _0xEBB208D6AE712C03 = 0xEBB208D6AE712C03,
        _0x290B2E6CCDE532E1 = 0x290B2E6CCDE532E1,
        _0x0EEF7A81C17679DB = 0x0EEF7A81C17679DB,
        _0x1B710E6F4AB69341 = 0x1B710E6F4AB69341,
        _0xA218D2BBCAA7388C = 0xA218D2BBCAA7388C,
        _0xCBDE59C48F2B06F5 = 0xCBDE59C48F2B06F5,
        _0x6A190B94C2541A99 = 0x6A190B94C2541A99,
        _0x3D9F958834AB9C30 = 0x3D9F958834AB9C30,
        _0x913D04A5176F84C9 = 0x913D04A5176F84C9,
        _0x2C76FA0E01681F8D = 0x2C76FA0E01681F8D,
        _0x4642182A298187D0 = 0x4642182A298187D0,
        _0x6B67320E0D57856A = 0x6B67320E0D57856A,
        _0xAA6C49AE90A32299 = 0xAA6C49AE90A32299,
        _0xB65927F861E7AE39 = 0xB65927F861E7AE39,
        _0xA1FBAC56D38563E2 = 0xA1FBAC56D38563E2,
        _0x6F43C351A5D51E2F = 0x6F43C351A5D51E2F,
        _0x0C31C51168E80365 = 0x0C31C51168E80365,
        _0x5463C962BC7777C3 = 0x5463C962BC7777C3,
        _0x4B19F171450E0D4F = 0x4B19F171450E0D4F,
        _0x758F081DB204DDDE = 0x758F081DB204DDDE,
        _0x7B5C293238EE4F20 = 0x7B5C293238EE4F20,
        _0xAE6B68A83ABBE7C0 = 0xAE6B68A83ABBE7C0,
        _0xA4B6432E3880F2F9 = 0xA4B6432E3880F2F9,
        _0xE37287EE358939C3 = 0xE37287EE358939C3,
        _0x011A42FD923D41CA = 0x011A42FD923D41CA,
        _0x89BFDF6D53145545 = 0x89BFDF6D53145545,
        _0x2890418B39BC8FFF = 0x2890418B39BC8FFF,
        _0x4B9668DB91DC39B8 = 0x4B9668DB91DC39B8,
        _0x92A1B55A59720395 = 0x92A1B55A59720395,
        _0x88D9D76D78065487 = 0x88D9D76D78065487,
        _0x5BCF0B79D4F5DBA3 = 0x5BCF0B79D4F5DBA3,
        _0x2E5B5D1F1453E08E = 0x2E5B5D1F1453E08E,
        _0x29924EB8EE9DB926 = 0x29924EB8EE9DB926,
        _0xB285AD0EC870B2DF = 0xB285AD0EC870B2DF,
        _0xCB86D3E3E3708901 = 0xCB86D3E3E3708901,
        _0x633F83B301C87994 = 0x633F83B301C87994,
        _0x5203038FF8BAE577 = 0x5203038FF8BAE577,
        _0x7F090958AE95B61B = 0x7F090958AE95B61B,
        _0xC494C76A34266E82 = 0xC494C76A34266E82,
        _0xC3995D396F1D97B6 = 0xC3995D396F1D97B6,
        _0x15F4732C357B1D6D = 0x15F4732C357B1D6D,
        _0x947E43F544B6AB34 = 0x947E43F544B6AB34,
        _0x32417CB860A3BDC4 = 0x32417CB860A3BDC4,
        _0xE737D5F14304A2EC = 0xE737D5F14304A2EC,
        _0xEBD49472BCCF7642 = 0xEBD49472BCCF7642,
        _0x19173C3F15367B54 = 0x19173C3F15367B54,
        _0x5708EDD71B50C008 = 0x5708EDD71B50C008,
        _0xB9BDFAE609DFB7C5 = 0xB9BDFAE609DFB7C5,
        _0xF7327ACC7A89AEF1 = 0xF7327ACC7A89AEF1,
        _0x7CC2186C32D3540A = 0x7CC2186C32D3540A,
        _0x1E017404784AA6A3 = 0x1E017404784AA6A3,
        _0x2B4CE170DE09F346 = 0x2B4CE170DE09F346,
        _0x7C8AA850617651D9 = 0x7C8AA850617651D9,
        _0x23BDE06596A22CEC = 0x23BDE06596A22CEC,
        _0xCDFB8C04D4C95D9B = 0xCDFB8C04D4C95D9B,
        _0x33FA048675821DA7 = 0x33FA048675821DA7,
        _0xFD8E853F0BC2E942 = 0xFD8E853F0BC2E942,
        _0x05CE6AF4DF071D23 = 0x05CE6AF4DF071D23,
        _0x801917E7D7BCE418 = 0x801917E7D7BCE418,
        _0xC6C4E15CF7D52FEA = 0xC6C4E15CF7D52FEA,
        _0xD05AD61F242C626B = 0xD05AD61F242C626B,
        _0x0F967019CC853BCC = 0x0F967019CC853BCC,
        _0x070A3841406C43D5 = 0x070A3841406C43D5,
        _0x9E66708B2B41F14A = 0x9E66708B2B41F14A,
        _0xF634E2892220EF34 = 0xF634E2892220EF34,
        _0xAAC0EE3B4999ABB5 = 0xAAC0EE3B4999ABB5,
        _0x5BB04BC74A474B47 = 0x5BB04BC74A474B47,
        _0x9078FB0557364099 = 0x9078FB0557364099,
        _0x29FCE825613FEFCA = 0x29FCE825613FEFCA,
        _0x65C75FDCCAC86464 = 0x65C75FDCCAC86464,
        _0x0D497AA69059FE40 = 0x0D497AA69059FE40,
        _0xD7D2F45C56A4F4DF = 0xD7D2F45C56A4F4DF,
        _0x1D23D3F70606D788 = 0x1D23D3F70606D788,
        _0xBD0E4F52F6D95242 = 0xBD0E4F52F6D95242,
        _0xFFA1594703ED27CA = 0xFFA1594703ED27CA,
        _0xBC6DF00D7A4A6819 = 0xBC6DF00D7A4A6819,
        _0xA2B8E47442C76CEC = 0xA2B8E47442C76CEC,
        _0xA622E66EEE92A08D = 0xA622E66EEE92A08D,
        _0x9B90842304C938A7 = 0x9B90842304C938A7,
        _0xCB1A3864C524F784 = 0xCB1A3864C524F784,
        _0xFA0D206B489A6846 = 0xFA0D206B489A6846,
        _0xA4AC05B1A364EBC5 = 0xA4AC05B1A364EBC5,
        _0x1298B3D8E4C2409F = 0x1298B3D8E4C2409F,
        _0xA274F51EF7E34B95 = 0xA274F51EF7E34B95,
        _0xC2EF407645BEECDC = 0xC2EF407645BEECDC,
        _0xFA742B82D093D848 = 0xFA742B82D093D848,
        _0xA2F8B3B5FEDFC100 = 0xA2F8B3B5FEDFC100,
        _0x66FF395445A88A6E = 0x66FF395445A88A6E,
        _0x4FF3C2B4E6A196C1 = 0x4FF3C2B4E6A196C1,
        _0x0BFA1BD465CDFEFD = 0x0BFA1BD465CDFEFD,
        _0x370A973252741AC4 = 0x370A973252741AC4,
        _0xA5BAE410B03E7371 = 0xA5BAE410B03E7371,
        _0x98082246107A6ACF = 0x98082246107A6ACF,
        _0x851966E1E35AF491 = 0x851966E1E35AF491,
        _0x4EFC1F8FF1AD94DE = 0x4EFC1F8FF1AD94DE,
        _0xC0940AC858C1E126 = 0xC0940AC858C1E126,
        _0x43E4DA469541A9C9 = 0x43E4DA469541A9C9,
        _0x0BCD4091C8EABA42 = 0x0BCD4091C8EABA42,
        _0x3972F78A78B5D9DF = 0x3972F78A78B5D9DF,
        _0x27E8A84C12B0B7D1 = 0x27E8A84C12B0B7D1,
        _0x273915CE30780986 = 0x273915CE30780986,
        _0x3FCBB5FCFD968698 = 0x3FCBB5FCFD968698,
        _0xF6D9E1F3560CBF8E = 0xF6D9E1F3560CBF8E,
        _0x13E7320C762F0477 = 0x13E7320C762F0477,
        _0xB0B2C6D170B0E8E5 = 0xB0B2C6D170B0E8E5,
        _0x93FFD92F05EC32FD = 0x93FFD92F05EC32FD,
        _0x610438375E5D1801 = 0x610438375E5D1801,
        _0xF47D54B986F0A346 = 0xF47D54B986F0A346,
        _0x3EFED081B4834BA1 = 0x3EFED081B4834BA1,
        _0x0FB1BA7FF73B41E1 = 0x0FB1BA7FF73B41E1,
        _0xB292203008EBBAAC = 0xB292203008EBBAAC,
        _0xD4D403EA031F351C = 0xD4D403EA031F351C,
        _0xA73F50E8796150D5 = 0xA73F50E8796150D5,
        _0xC412AA1C73111FE0 = 0xC412AA1C73111FE0,
        _0x627F7F3A0C4C51FF = 0x627F7F3A0C4C51FF,
        _0x13A210949FCBD92B = 0x13A210949FCBD92B,
        _0xD049FDAF089FDDB0 = 0xD049FDAF089FDDB0,
        _0xDD9540E7B1C9714F = 0xDD9540E7B1C9714F,
        _0x55546004A244302A = 0x55546004A244302A,
        _0xDE1B1907A83A1550 = 0xDE1B1907A83A1550,
        _0x95B8E397B8F4360F = 0x95B8E397B8F4360F,
        _0xEF5A3D2285D8924B = 0xEF5A3D2285D8924B,
        _0x825F6DD559A0895B = 0x825F6DD559A0895B,
        _0x345C9F993A8AB4A4 = 0x345C9F993A8AB4A4,
        _0xE7687EB2F634ABF0 = 0xE7687EB2F634ABF0,
        _0x22F2A386D43048A9 = 0x22F2A386D43048A9,
        _0x36513AFFC703C60D = 0x36513AFFC703C60D,
        _0xFC3B580C4380B5B7 = 0xFC3B580C4380B5B7,
        _0xEA8763E505AFD49A = 0xEA8763E505AFD49A,
        _0xE4EF4382E22C780C = 0xE4EF4382E22C780C,
        _0xD61FCF9FCFD515B7 = 0xD61FCF9FCFD515B7,
        _0x8D9DB115FBA8E23D = 0x8D9DB115FBA8E23D,
        _0x16F2C8C084AB2092 = 0x16F2C8C084AB2092,
        _0xD97BC27AC039F681 = 0xD97BC27AC039F681,
        _0xF6A8C4B4A11AE89C = 0xF6A8C4B4A11AE89C,
        _0xE4C95E0AE31C6512 = 0xE4C95E0AE31C6512,
        _0x5D4CD22A8C82A81A = 0x5D4CD22A8C82A81A,
        _0xBF567DF2BEF211A6 = 0xBF567DF2BEF211A6,
        _0x4F5EBE70081E5A20 = 0x4F5EBE70081E5A20,
        _0x87247BC60B60BED8 = 0x87247BC60B60BED8,
        _0x57779B55B83E2BEA = 0x57779B55B83E2BEA,
        _0x7EE3A8660F38797E = 0x7EE3A8660F38797E,
        _0xA180FBD502A03125 = 0xA180FBD502A03125,
        _0x1F8215D0E446F593 = 0x1F8215D0E446F593,
        _0x53BA7D96B9A421D9 = 0x53BA7D96B9A421D9,
        _0x96C7B659854DE629 = 0x96C7B659854DE629,
        _0x5B73975B4F12F7F3 = 0x5B73975B4F12F7F3,
        _0x81B75428A7813E67 = 0x81B75428A7813E67,
        _0xA6F67BEC53379A32 = 0xA6F67BEC53379A32,
        _0x411189E51B8020BA = 0x411189E51B8020BA,
        _0x0E17378642156790 = 0x0E17378642156790,
        _0x498F2E77982D6945 = 0x498F2E77982D6945,
        _0x56E58D4D118FB45E = 0x56E58D4D118FB45E,
        _0xBF5E791BBBF90A3C = 0xBF5E791BBBF90A3C,
        _0x7FF72DE061DF55E2 = 0x7FF72DE061DF55E2,
        _0xA31D350D66FA1855 = 0xA31D350D66FA1855,
        _0xAF61B3CD8C3B82C3 = 0xAF61B3CD8C3B82C3,
        _0xEEDC9B29314B2733 = 0xEEDC9B29314B2733,
        _0x5C90E20C25E6D83C = 0x5C90E20C25E6D83C,
        _0x10F96086123B939F = 0x10F96086123B939F,
        _0x3FDBB99EFD8CE4AF = 0x3FDBB99EFD8CE4AF,
        _0x7E8F9949B7AABBF0 = 0x7E8F9949B7AABBF0,
        _0x5DA36CCCB63C0895 = 0x5DA36CCCB63C0895,
        _0x56076667E7C2DCD6 = 0x56076667E7C2DCD6,
        _0x0D7FFA1B2F69ED82 = 0x0D7FFA1B2F69ED82,
        _0x66B957AAC2EAAEAB = 0x66B957AAC2EAAEAB,
        _0xFFCC2DB2D9953401 = 0xFFCC2DB2D9953401,
        _0x6243635AF2F1B826 = 0x6243635AF2F1B826,
        _0x31B2E7F2E3C58B89 = 0x31B2E7F2E3C58B89,
        _0x63342C50EC115CE8 = 0x63342C50EC115CE8,
        _0xAAB86462966168CE = 0xAAB86462966168CE,
        _0x7E02E4218D916B94 = 0x7E02E4218D916B94,
        _0x59BD177A1A48600A = 0x59BD177A1A48600A,
        _0xD103F6DBB5442BE8 = 0xD103F6DBB5442BE8,
        _0xC2745D9261664901 = 0xC2745D9261664901,
        _0x19B14E04B009E28B = 0x19B14E04B009E28B,
        _0xF917F92BF22ECBAB = 0xF917F92BF22ECBAB,
        _0x49DADFC4CD808B0A = 0x49DADFC4CD808B0A,
        _0xBA208A8D6399A3AC = 0xBA208A8D6399A3AC,
        _0x704C908E9C405136 = 0x704C908E9C405136,
        _0x7406C71F4AC2FFCC = 0x7406C71F4AC2FFCC,
        _0x28508173C6A7CC18 = 0x28508173C6A7CC18,
        _0x52250B92EA70BE3D = 0x52250B92EA70BE3D,
        _0xCE7A6C1D5CDE1F9D = 0xCE7A6C1D5CDE1F9D,
        _0x604E1010E3162E86 = 0x604E1010E3162E86,
        _0xE8ABE3B73FC7FE17 = 0xE8ABE3B73FC7FE17,
        _0x3A50753042B6891B = 0x3A50753042B6891B,
        _0x932786CE3C76477C = 0x932786CE3C76477C,
        _0x095C2277FED731DB = 0x095C2277FED731DB,
        _0x09171A6F8FDE5DC1 = 0x09171A6F8FDE5DC1,
        _0x09E378C52B1433B5 = 0x09E378C52B1433B5,
        _0x6507AC3BD7C99009 = 0x6507AC3BD7C99009,
        _0x2942457417A5FD24 = 0x2942457417A5FD24,
        _0xEBAAC9A750E7563B = 0xEBAAC9A750E7563B,
        _0x992187D975635DF5 = 0x992187D975635DF5,
        _0x0B787A37EEDD226F = 0x0B787A37EEDD226F,
    }
    public static class NATIVE_PED_EXTENSIONS
    {
        public static void Call(this NATIVE_PED hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PED hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}