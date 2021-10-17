using System;
namespace Hotstar
{
    public enum NATIVE_VEHICLE : ulong
    { 
        /// <summary>
        /// Deletes a vehicle.
        /// The vehicle must be a mission entity to delete, so call this before deleting: SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);
        /// 
        /// eg how to use:
        /// SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);
        /// DELETE_VEHICLE(&vehicle);
        /// 
        /// Deletes the specified vehicle, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Vehicle* vehicle
        ///
        /// </summary>
        DELETE_VEHICLE = 0xE20A909D8C4A70F8,
        /// <summary>
        /// Makes the vehicle accept no passengers.
        ///
        /// > Vehicle veh
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON = 0xECB9E9BC887E8060,
        /// <summary>
        /// Returns true if the vehicle's current speed is less than, or equal to 0.0025f.
        /// 
        /// For some vehicles it returns true if the current speed is <= 0.00039999999.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_STOPPED = 0x78C3311A73135241,
        /// <summary>
        /// Gets the number of passengers, NOT including the driver. Use IS_VEHICLE_SEAT_FREE(Vehicle, -1) to also check for the driver
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_NUMBER_OF_PASSENGERS = 0x59F3F16577CD79B2,
        /// <summary>
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        IS_SEAT_WARP_ONLY = 0x7892685BF6D9775E,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_DISABLE_RANDOM_TRAINS_THIS_FRAME = 0xD4288603E8766FF7,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > int doorLockStatus
        ///
        /// </summary>
        SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED = 0xA9F1D75195CC40F6,
        /// <summary>
        /// Explodes a selected vehicle.
        /// 
        /// Vehicle vehicle = Vehicle you want to explode.
        /// BOOL isAudible = If explosion makes a sound.
        /// BOOL isInvisible = If the explosion is invisible or not.
        /// 
        /// First BOOL does not give any visual explosion, the vehicle just falls apart completely but slowly and starts to burn.
        ///
        /// > Vehicle vehicle
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > Any p3
        /// > Any p4
        ///
        /// </summary>
        EXPLODE_VEHICLE = 0x75DCED9EEC5769D7,
        /// <summary>
        /// Value: mostly 99999.9f
        ///
        /// > Vehicle vehicle
        /// > float value
        ///
        /// </summary>
        _SET_BOAT_MOVEMENT_RESISTANCE = 0xE3261532550D6A9F,
        /// <summary>
        /// If set to true, vehicle will not take crash damage, but is still susceptible to damage from bullets and explosives
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_STRONG = 0xAB315515C9F8803D,
        /// <summary>
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        /// Use GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(vehicle) - 1 for last seat index.
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        IS_VEHICLE_SEAT_FREE = 0xE052C1B1CAA4ECE4,
        /// <summary>
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        GET_PED_IN_VEHICLE_SEAT = 0xBB40DD2270B65366,
        /// <summary>
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        GET_LAST_PED_IN_VEHICLE_SEAT = 0x74583B19FEEAFDA7,
        /// <summary>
        /// enum eDraftHarness
        /// {
        /// 	DRAFT_HARNESS_LR,
        /// 	DRAFT_HARNESS_RR,
        /// 	DRAFT_HARNESS_LM,
        /// 	DRAFT_HARNESS_RM,
        /// 	DRAFT_HARNESS_LF,
        /// 	DRAFT_HARNESS_RF,
        /// 	DRAFT_HARNESS_COUNT
        /// };
        ///
        /// > Vehicle vehicle
        /// > int harnessId
        ///
        /// </summary>
        _GET_PED_IN_DRAFT_HARNESS = 0xA8BA0BAE0173457B,
        /// <summary>
        /// This native makes the vehicle stop immediately
        /// 
        /// distance defines how far it will travel until stopping.
        ///
        /// > Vehicle vehicle
        /// > float distance
        /// > int duration
        /// > BOOL unknown
        ///
        /// </summary>
        BRING_VEHICLE_TO_HALT = 0x260BE8F09E326A20,
        /// <summary>
        /// Closes all doors of a vehicle:
        ///
        /// > Vehicle vehicle
        /// > BOOL closeInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOORS_SHUT = 0xA4FFCD645B11F25A,
        /// <summary>
        /// Allows you to toggle bulletproof tires.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_TYRES_CAN_BURST = 0xEBD0A4E935106FE5,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL loose
        /// > BOOL openInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOOR_OPEN = 0x550CE392A4672412,
        /// <summary>
        /// windowIndex:
        /// 0 = Front Right Window
        /// 1 = Front Left Window
        /// 2 = Back Right Window
        /// 3 = Back Left Window
        ///
        /// > Vehicle vehicle
        /// > int windowIndex
        ///
        /// </summary>
        REMOVE_VEHICLE_WINDOW = 0x745F15A215F2DDF1,
        /// <summary>
        /// dirtLevel: 0.0 - 1.0
        ///
        /// > Vehicle vehicle
        /// > float dirtLevel
        ///
        /// </summary>
        _SET_VEHICLE_DIRT_LEVEL_2 = 0xBAE0EEDF93F05EAA,
        /// <summary>
        /// mudLevel: 0.0 - 1.0
        ///
        /// > Vehicle vehicle
        /// > float mudLevel
        ///
        /// </summary>
        _SET_VEHICLE_MUD_LEVEL = 0x4D15E49764CB328A,
        /// <summary>
        /// Sets the vehicle's lights state.
        ///
        /// > Vehicle vehicle
        /// > int state
        ///
        /// </summary>
        SET_VEHICLE_LIGHTS = 0x629F0A0E952CAE7D,
        /// <summary>
        /// Maximum possible speed is 30.0 (108 km/h)
        ///
        /// > Vehicle train
        /// > float speed
        ///
        /// </summary>
        _SET_TRAIN_MAX_SPEED = 0x9F29999DFDF2AEB8,
        /// <summary>
        /// Request the vehicle recording defined by the lowercase format string "%s%03d.yvr". For example, REQUEST_VEHICLE_RECORDING(1, "FBIs1UBER") corresponds to fbis1uber001.yvr.
        /// For all vehicle recording/playback natives, "script" is a common prefix that usually corresponds to the script/mission the recording is used in, "recording" is its int suffix, and "id" corresponds to a unique identifier within the recording streaming module.
        /// (GTA) Note that only 24 recordings (hardcoded in multiple places) can ever active at a given time before clobbering begins.
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        REQUEST_VEHICLE_RECORDING = 0xC474CF16EDA45DC9,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        HAS_VEHICLE_RECORDING_BEEN_LOADED = 0xBA9325BE372AB6EA,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > Any p0
        /// > Any* p1
        ///
        /// </summary>
        REMOVE_VEHICLE_RECORDING = 0x139E35755418F6AA,
        /// <summary>
        /// This native does no interpolation between pathpoints. The same position will be returned for all times up to the next pathpoint in the recording.
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > float time
        /// > const char* script
        ///
        /// </summary>
        GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME = 0x1A00961A1BE94E5E,
        /// <summary>
        /// This native does no interpolation between pathpoints. The same rotation will be returned for all times up to the next pathpoint in the recording.
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > float time
        /// > const char* script
        ///
        /// </summary>
        GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME = 0x61787DD28B8CC0D5,
        /// <summary>
        /// p3 is some flag related to 'trailers' (invokes CVehicle::GetTrailer).
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > Vehicle vehicle
        /// > int recording
        /// > const char* script
        /// > BOOL p3
        ///
        /// </summary>
        START_PLAYBACK_RECORDED_VEHICLE = 0x4932B84E3276508E,
        /// <summary>
        /// Often called after START_PLAYBACK_RECORDED_VEHICLE and SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE; similar in use to FORCE_ENTITY_AI_AND_ANIMATION_UPDATE.
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE = 0x59ECA796021B0539,
        /// <summary>
        /// SET_TIME_POSITION_IN_RECORDING can be emulated by: desired_time - GET_TIME_POSITION_IN_RECORDING(vehicle)
        ///
        /// > Vehicle vehicle
        /// > float time
        ///
        /// </summary>
        SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE = 0x5F5E6379C59EFC56,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        IS_VEHICLE_DOOR_FULLY_OPEN = 0x7AE191143C7A9107,
        /// <summary>
        /// Starts or stops the engine on the specified vehicle.
        /// 
        /// vehicle: The vehicle to start or stop the engine on.
        /// value: true to turn the vehicle on; false to turn it off.
        /// instantly: if true, the vehicle will be set to the state immediately; otherwise, the current driver will physically turn on or off the engine.
        ///
        /// > Vehicle vehicle
        /// > BOOL value
        /// > BOOL instantly
        ///
        /// </summary>
        SET_VEHICLE_ENGINE_ON = 0xB64CFA14CB9A2E78,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > int speed
        /// > float angle
        ///
        /// </summary>
        SET_VEHICLE_DOOR_CONTROL = 0xD57F10EBBA814ECF,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL p2
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        SET_VEHICLE_DOOR_LATCHED = 0x06F8A202EB312A3C,
        /// <summary>
        /// doorId: enum eDoorId
        /// {
        /// 	VEH_EXT_DOOR_INVALID_ID = -1,
        /// 	VEH_EXT_DOOR_DSIDE_F,
        /// 	VEH_EXT_DOOR_DSIDE_M,
        /// 	VEH_EXT_DOOR_DSIDE_M1,
        /// 	VEH_EXT_DOOR_DSIDE_M2,
        /// 	VEH_EXT_DOOR_DSIDE_R,
        /// 	VEH_EXT_DOOR_PSIDE_F,
        /// 	VEH_EXT_DOOR_PSIDE_M,
        /// 	VEH_EXT_DOOR_PSIDE_M1,
        /// 	VEH_EXT_DOOR_PSIDE_M2,
        /// 	VEH_EXT_DOOR_PSIDE_R,
        /// 	VEH_EXT_BONNET,
        /// 	VEH_EXT_BOOT
        /// };
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL closeInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOOR_SHUT = 0x6A3C24B91FD0EA09,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL deleteDoor
        ///
        /// </summary>
        SET_VEHICLE_DOOR_BROKEN = 0x9666CF20A1C6D780,
        /// <summary>
        /// Setting this to false, makes the specified vehicle to where if you press Y your character doesn't even attempt the animation to enter the vehicle. Hence it's not considered aka ignored.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_IS_CONSIDERED_BY_PLAYER = 0x54800D386C5825E5,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL isBreakable
        ///
        /// </summary>
        _SET_VEHICLE_DOOR_CAN_BREAK = 0x081FB9D6422F804C,
        /// <summary>
        /// This fixes a vehicle.
        /// If the vehicle's engine's broken then you cannot fix it with this native.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_VEHICLE_FIXED = 0x79811282A9D1AE56,
        /// <summary>
        /// Locks the vehicle's steering to the desired angle, explained below.
        /// 
        /// Requires to be called onTick. Steering is unlocked the moment the function stops being called on the vehicle.
        /// 
        /// Steer bias:
        /// -1.0 = full right
        /// 0.0 = centered steering
        /// 1.0 = full left
        ///
        /// > Vehicle vehicle
        /// > float value
        ///
        /// </summary>
        SET_VEHICLE_STEER_BIAS = 0x84DAAE11E9EE4FC3,
        /// <summary>
        /// Note: only some vehicle have extras
        ///
        /// > Vehicle vehicle
        /// > int extraId
        /// > BOOL disable
        ///
        /// </summary>
        SET_VEHICLE_EXTRA = 0xBB6F89150BC9D16B,
        /// <summary>
        /// Apply damage to vehicle at a location. Location is relative to vehicle model (not world).
        /// 
        /// Radius of effect damage applied in a sphere at impact location
        ///
        /// > Vehicle vehicle
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float damage
        /// > float radius
        /// > BOOL p6
        ///
        /// </summary>
        SET_VEHICLE_DAMAGE = 0x1D7678F81452BB41,
        /// <summary>
        /// Returns 1000.0 if the function is unable to get the address of the specified vehicle or if it's not a vehicle.
        /// 
        /// Minimum: -4000
        /// Maximum: 1000
        /// 
        /// -4000: Engine is destroyed
        /// 0 and below: Engine catches fire and health rapidly declines
        /// 300: Engine is smoking and losing functionality
        /// 1000: Engine is perfect
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_ENGINE_HEALTH = 0x90DBFFAC43B22081,
        /// <summary>
        /// 1000 is max health
        /// Begins leaking gas at around 650 health
        /// -999.90002441406 appears to be minimum health, although nothing special occurs <- false statement
        /// 
        /// -------------------------
        /// Minimum: -4000
        /// Maximum: 1000
        /// 
        /// -4000: Engine is destroyed
        /// 0 and below: Engine catches fire and health rapidly declines
        /// 300: Engine is smoking and losing functionality
        /// 1000: Engine is perfect
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        SET_VEHICLE_ENGINE_HEALTH = 0x8BDC5B998B4654EF,
        /// <summary>
        /// 1000 is max health
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_PETROL_TANK_HEALTH = 0x1E5A9B356D5098BE,
        /// <summary>
        /// 1000 is max health
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        SET_VEHICLE_PETROL_TANK_HEALTH = 0x6AB2918EE3BEC94C,
        /// <summary>
        /// Sounds the horn for the specified vehicle.
        /// 
        /// vehicle: The vehicle to activate the horn for.
        /// mode: The hash of "NORMAL" or "HELDDOWN". Can be 0.
        /// duration: The duration to sound the horn, in milliseconds.
        /// 
        /// Note: If a player is in the vehicle, it will only sound briefly.
        ///
        /// > Vehicle vehicle
        /// > int duration
        /// > Hash mode
        /// > BOOL forever
        ///
        /// </summary>
        START_VEHICLE_HORN = 0xB4E3BFC39CA16057,
        /// <summary>
        /// if true, axles won't bend.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_HAS_STRONG_AXLES = 0x252253C8A45AA1FC,
        /// <summary>
        /// snowLevel: 0.0 - 1.0
        ///
        /// > Vehicle vehicle
        /// > float snowLevel
        ///
        /// </summary>
        _SET_VEHICLE_SNOW_LEVEL = 0x6F73EFAB11651D7F,
        /// <summary>
        /// wetLevel: 0.0 - 1.0
        ///
        /// > Vehicle vehicle
        /// > float wetLevel
        ///
        /// </summary>
        _SET_VEHICLE_WET_LEVEL = 0x5AABB09F6FBD1F87,
        /// <summary>
        /// Returns false if every seat is occupied.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        ARE_ANY_VEHICLE_SEATS_FREE = 0xA0A424505A1B6429,
        /// <summary>
        /// Sets a vehicle to be strongly resistant to explosions. p0 is the vehicle; set p1 to false to toggle the effect on/off.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE = 0xA402939C6761E1A3,
        /// <summary>
        /// HAS_*
        ///
        ///
        /// </summary>
        _HAS_FILLED_VEHICLE_POPULATION = 0x2701D01D5E18FC31,
        /// <summary>
        /// Gets the trailer of a vehicle and puts it into the trailer parameter.
        ///
        /// > Vehicle vehicle
        /// > Vehicle* trailer
        ///
        /// </summary>
        GET_VEHICLE_TRAILER_VEHICLE = 0xCF867A239EC30741,
        /// <summary>
        /// seatIndex: see CREATE_PED_INSIDE_VEHICLE
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        CAN_SHUFFLE_SEAT = 0xF8B2D32A2231FD24,
        /// <summary>
        /// Ranges from -1 to 2? (internal type is int8)
        ///
        /// > Vehicle vehicle
        /// > int lodLevel
        ///
        /// </summary>
        _SET_VEHICLE_LOD_LEVEL = 0x3FA7D7D1E0EA809E,
        /// <summary>
        /// Copies sourceVehicle's damage (broken bumpers, broken lights, etc.) to targetVehicle.
        ///
        /// > Vehicle sourceVehicle
        /// > Vehicle targetVehicle
        ///
        /// </summary>
        COPY_VEHICLE_DAMAGES = 0xDBC28A8C683CD80B,
        /// <summary>
        /// Requires a visibility tracker on the vehicle (TRACK_VEHICLE_VISIBILITY)
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_VISIBLE = 0x424910CD5DE8C246,
        /// <summary>
        /// index: 0 - 1
        /// 
        /// Used to be incorrectly named _SET_VEHICLE_EXCLUSIVE_DRIVER_2
        ///
        /// > Vehicle vehicle
        /// > Ped ped
        /// > int index
        ///
        /// </summary>
        SET_VEHICLE_EXCLUSIVE_DRIVER = 0xC6B9BF123B9463B6,
        /// <summary>
        /// Seems related to vehicle health, like the one in IV.
        /// Max 1000, min 0.
        /// Vehicle does not necessarily explode or become undrivable at 0.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_BODY_HEALTH = 0x42113B857E33C16E,
        /// <summary>
        /// Returns handles of boat paddles entities.
        ///
        /// > Vehicle vehicle
        /// > Entity* left
        /// > Entity* right
        ///
        /// </summary>
        _GET_ROWING_OARS = 0xA6E210FB4283B767,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        _IS_VEHICLE_DOOR_BROKEN = 0xE979BB5602AD3402,
        /// <summary>
        /// Returns rage::NumericLimits<float>::kMax (3.402823466e+38) if vehicle is not a valid vehicle of type VEHICLE_TYPE_DRAFT.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_DRAFT_VEHICLE_DESIRED_SPEED = 0xC6D7DDC843176701,
        /// <summary>
        /// configHash: https://alloc8or.re/rdr3/doc/enums/eTrainConfig.txt
        /// For more information, see trainconfigs.ymt
        ///
        /// > Hash configHash
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL direction
        /// > BOOL passengers
        /// > BOOL p6
        /// > BOOL conductor
        ///
        /// </summary>
        _CREATE_MISSION_TRAIN = 0xC239DBD9A57D2A71,
        /// <summary>
        /// SET_VEHICLE_AL*
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0x1240E8596A8308B9 = 0x1240E8596A8308B9,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x9868C0D0134855F7 = 0x9868C0D0134855F7,
        /// <summary>
        /// Returns amount for CAN_REGISTER_MISSION_VEHICLES
        ///
        /// > Hash trainConfig
        ///
        /// </summary>
        _0x635423D55CA84FC8 = 0x635423D55CA84FC8,
        /// <summary>
        /// Outputs junctionIndex, to be used with 0xE6C5E2125EB210C1
        ///
        /// > Hash trainConfig
        /// > float x
        /// > float y
        /// > float z
        /// > int* junctionIndex
        ///
        /// </summary>
        _0x86AFC343CF7F0B34 = 0x86AFC343CF7F0B34,
        /// <summary>
        /// SET_VEHICLE_LI*
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0x8F75941C86EEBFCA = 0x8F75941C86EEBFCA,
        /// <summary>
        /// Used to be incorrectly named SET_VEHICLE_EXCLUSIVE_DRIVER
        /// 
        /// Likely SET_VEHICLE_ALLOW_*
        /// 
        /// Jenkins hash may be wrong, unsure at this time.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x0893DAFBFA67110E = 0x0893DAFBFA67110E,
        /// <summary>
        /// Hashes: COACH2_BOOT_LOOT_ITEMS_COACHROB_RSC, COACH2_BOOT_LOOT_ITEMS_COACHROB, COACH2_MARY3
        ///
        /// > Vehicle vehicle
        /// > Hash coachrobberyLoot
        ///
        /// </summary>
        _0xF489F94BFEE12BB0 = 0xF489F94BFEE12BB0,
        /// <summary>
        /// Params: destroyingForce is usually 100f in R* Scripts
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        /// > float destroyingForce
        ///
        /// </summary>
        _0xC372B6A88F6E4AD8 = 0xC372B6A88F6E4AD8,
        /// <summary>
        /// Params: p1 usually 1 in R* Scripts
        ///
        /// > Vehicle vehicle
        /// > int p1
        ///
        /// </summary>
        _0x4C60C333F9CCA2B6 = 0x4C60C333F9CCA2B6,
        CREATE_VEHICLE = 0xAF35D0D2583051B0,
        _CREATE_DRAFT_VEHICLE = 0x214651FB1DFEBA89,
        IS_VEHICLE_MODEL = 0x0045A54EC7A22455,
        SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA = 0xBBB134FB9D50C0CC,
        SET_ALL_VEHICLE_GENERATORS_ACTIVE = 0x3D596E6E88A02C24,
        SET_VEHICLE_ON_GROUND_PROPERLY = 0x7263332501E07F52,
        GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS = 0xA9C55F1C15E62E06,
        GET_VEHICLE_MODEL_NUMBER_OF_SEATS = 0x9A578736FF3A17C3,
        _GET_VEHICLE_TURRET_SEAT = 0xFF5791B7639C2A46,
        SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0x606374EBFC27B133,
        SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0x1F91D44490E1EA0C,
        SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0xFEDFA97638D61D4A,
        SET_VEHICLE_DOORS_LOCKED = 0x96F78A6A075D55D9,
        SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0x359A8EA1FB8D6F0F,
        GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0xFA2CDDFEB8BC898B,
        SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS = 0x2381977DA948F8DC,
        SET_VEHICLE_DOORS_LOCKED_FOR_TEAM = 0xE712BC978770F105,
        _GET_VEHICLE_DOORS_LOCKED_FOR_TEAM = 0xDD1E1393D966D39A,
        SET_BOAT_ANCHOR = 0xAEAB044F05B92659,
        CAN_ANCHOR_BOAT_HERE = 0xC075176CFB8B4128,
        _SET_BOAT_FROZEN_WHEN_ANCHORED = 0x286771F3059A37A7,
        SET_BOAT_SINKS_WHEN_WRECKED = 0x62A6D317A011EA1D,
        IS_DRAFT_VEHICLE = 0xEA44E97849E9F3DD,
        SET_VEHICLE_FORWARD_SPEED = 0xF9F92AF49F12F6E7,
        _STOP_BRING_VEHICLE_TO_HALT = 0x7C06330BFDDA182E,
        SET_VEHICLE_WHEELS_CAN_BREAK = 0x839137C40275FB77,
        SET_VEHICLE_DOORS_TO_OPEN_AT_ANY_DISTANCE = 0x362CEDD2A41E0747,
        SET_RANDOM_TRAINS = 0x1156C6EE7E82A98A,
        _GET_NEAREST_TRAIN_TRACK_POSITION = 0x6DE03BCC15E81710,
        DELETE_ALL_TRAINS = 0xA3120A1385F17FF7,
        SET_TRAIN_SPEED = 0xDFBA6BBFF7CCAFBB,
        SET_TRAIN_CRUISE_SPEED = 0x01021EB2E96B793C,
        _SET_TRAIN_STOPS_FOR_STATIONS = 0x4182C037AA1F0091,
        IS_TRAIN_WAITING_AT_STATION = 0xE887BD31D97793F6,
        SET_RANDOM_BOATS = 0xF44D446D4E36DB87,
        GET_TIME_POSITION_IN_RECORDING = 0x233B51C7913FA031,
        STOP_PLAYBACK_RECORDED_VEHICLE = 0xBF9B4D6267E8C26D,
        IS_PLAYBACK_GOING_ON_FOR_VEHICLE = 0x02774B3A9034278F,
        IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE = 0x5A7472606EC5B7C1,
        SET_PLAYBACK_SPEED = 0xD78084EED4CD94C6,
        GET_CLOSEST_VEHICLE = 0x52F45D033645181B,
        GET_TRAIN_CARRIAGE = 0xD0FB093A4CDB932C,
        DELETE_MISSION_TRAIN = 0x0D3630FB07E8B570,
        SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED = 0xBBE7648349B49BE8,
        SET_MISSION_TRAIN_COORDS = 0x7632755962AB9922,
        IS_THIS_MODEL_A_BOAT = 0x799CFC7C5B743B15,
        IS_THIS_MODEL_A_TRAIN = 0xFC08C8F8C1EDF174,
        SET_VEHICLE_CAN_BE_TARGETTED = 0x05254BA0B44ADC16,
        SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED = 0x4BF8131AE811541C,
        SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS = 0xC903855E028A05F2,
        SET_VEHICLE_DIRT_LEVEL = 0x758C3460EE915D0A,
        SET_VEHICLE_UNDRIVEABLE = 0x6E884BAB713A2A94,
        SET_VEHICLE_PROVIDES_COVER = 0x652712478F1721F4,
        SET_VEHICLE_CAN_BREAK = 0xC5ED9D59B4646611,
        GET_VEHICLE_DOOR_LOCK_STATUS = 0xC867FD144F2469D3,
        IS_VEHICLE_ON_ALL_WHEELS = 0x0D5D119529654EE0,
        SET_TRAIN_OFFSET_FROM_STATION = 0x8EC47DD4300BF063,
        GET_CURRENT_STATION_FOR_TRAIN = 0x86FA6D8B48667D75,
        GET_TRACK_INDEX_OF_TRAIN = 0x865FEC2FA899F29C,
        SET_DISABLE_VEHICLE_PETROL_TANK_FIRES = 0xB70986AB19B04AFF,
        SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE = 0x5795FBE7A2001C14,
        SET_DISABLE_VEHICLE_ENGINE_FIRES = 0xD146EE5F2B06B95E,
        REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA = 0xC619A44639BC0CB4,
        IS_VEHICLE_EXTRA_TURNED_ON = 0xFA9A55D9C4351625,
        DOES_EXTRA_EXIST = 0xAF5E7E9A7620FFB5,
        IS_VEHICLE_STUCK_TIMER_UP = 0x1ABA9753939503C5,
        RESET_VEHICLE_STUCK_TIMER = 0x23298B468F7D88B6,
        IS_VEHICLE_DRIVEABLE = 0xB86D29B10F627379,
        IS_VEHICLE_WRECKED = 0xDDBEA5506C848227,
        SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER = 0xBB5A3FA8ED3979C5,
        _SET_VEHICLE_TINT = 0x8268B098F6FCA4E2,
        _SET_VEHICLE_LIVERY = 0xF89D82A0582E46ED,
        _GET_VEHICLE_TINT = 0xA44D65E6C624526F,
        _GET_VEHICLE_LIVERY = 0xBB765B8FD49A796C,
        IS_VEHICLE_WINDOW_INTACT = 0x0E7910A63E05B12C,
        IS_ANY_VEHICLE_NEAR_POINT = 0x5698BA4FD04D39C4,
        REQUEST_VEHICLE_HIGH_DETAIL_MODEL = 0x84B81EF78BD22357,
        REQUEST_VEHICLE_ASSET = 0x81A15811460FAB3A,
        HAS_VEHICLE_ASSET_LOADED = 0xB935F3154BC913C8,
        REMOVE_VEHICLE_ASSET = 0x888A4E675B38F5AD,
        SET_VEHICLE_AUTOMATICALLY_ATTACHES = 0x501354951CD942DE,
        IS_VEHICLE_IN_BURNOUT = 0x3F5029A8FC060C48,
        SET_VEHICLE_HANDBRAKE = 0x91BE51AEC4E99710,
        INSTANTLY_FILL_VEHICLE_POPULATION = 0x1FF00DB43026B12F,
        GET_VEHICLE_ESTIMATED_MAX_SPEED = 0xFE52F34491529F0B,
        ADD_ROAD_NODE_SPEED_ZONE = 0x4C221BAC54D735C3,
        REMOVE_ROAD_NODE_SPEED_ZONE = 0xFE9AB3354ACE6C9C,
        _IS_VEHICLE_SEAT_ACCESSIBLE = 0x80DDCCB2F4A3EB57,
        MODIFY_VEHICLE_TOP_SPEED = 0x35AD938C74CACD6A,
        GET_LAST_DRIVEN_VEHICLE = 0xA94F3E0AB9695E19,
        CLEAR_LAST_DRIVEN_VEHICLE = 0x0EFC5DC62E67609B,
        SET_PED_OWNS_VEHICLE = 0x838C216C2B05A009,
        _GET_VEHICLE_OWNER = 0xB729679356A889AE,
        SET_VEHICLE_LOD_MULTIPLIER = 0x5F5E2B1B9EAECC0F,
        SET_VEHICLE_SHOOT_AT_TARGET = 0xB79BE78C665B3E6D,
        SET_FORCE_HD_VEHICLE = 0x373CB1283308BD7B,
        TRACK_VEHICLE_VISIBILITY = 0x1F3969B140DEE157,
        SET_ENABLE_VEHICLE_SLIPSTREAMING = 0x73F1E4F6DF26FE30,
        SET_VEHICLE_INACTIVE_DURING_PLAYBACK = 0x4EA71B4C9DB3C3F1,
        SET_VEHICLE_ENGINE_CAN_DEGRADE = 0x48E4C137A71C2688,
        SET_VEHICLE_IS_STOLEN = 0x6C32FC81DFF25C9A,
        DISABLE_VEHICLE_WEAPON = 0x94B1E71B144356A5,
        SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS = 0xE42952510F84AFDB,
        _SET_VEHICLE_JET_ENGINE_ON = 0x1549BA7FE83A2383,
        SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP = 0xC462C79379ABBCB1,
        _IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE = 0xB213D2A560B2E48B,
        _SET_DISABLE_SUPERDUMMY_MODE = 0x1716D787D9B94202,
        SET_VEHICLE_BODY_HEALTH = 0x55CCAAE4F28C67A0,
        GET_DRIVER_OF_VEHICLE = 0x2963B5C1637E8A27,
        _GET_BREAKABLE_VEHICLE_LOCKS_STATE = 0xE015CF1F2C0959D8,
        _GET_BREAKABLE_VEHICLE_LOCK_OBJECT = 0x58F2244C1286D09A,
        _GET_NUM_BREAKABLE_VEHICLE_LOCK_OBJECTS = 0x2FA86833E3617E2D,
        SET_BREAKABLE_VEHICLE_LOCKS_UNBREAKABLE = 0xBC4735F48CD983EF,
        GET_DRAFT_ANIMAL_COUNT = 0xA19447D83294E29F,
        _BREAK_OFF_VEHICLE_WHEEL = 0xD4F5EFB55769D272,
        _SET_DRAFT_VEHICLE_DESIRED_SPEED = 0x0C3F0F7F92CA847C,
        _0x6355602C02EDC6DF = 0x6355602C02EDC6DF,
        _0xCE1531927AD6C9F8 = 0xCE1531927AD6C9F8,
        _0x35DC1877312FBA0F = 0x35DC1877312FBA0F,
        _0x5136B284B67B35C7 = 0x5136B284B67B35C7,
        _0x424FFCB9F0D2D4B5 = 0x424FFCB9F0D2D4B5,
        _0xA9E185D498B9AC67 = 0xA9E185D498B9AC67,
        _0x750D42C013F64AE7 = 0x750D42C013F64AE7,
        _0xE78993FF9022C064 = 0xE78993FF9022C064,
        _0x201B8ED4FF7FE9F5 = 0x201B8ED4FF7FE9F5,
        _0x41CDA90EE3450921 = 0x41CDA90EE3450921,
        _0xD21A3D421E7F09F7 = 0xD21A3D421E7F09F7,
        _0xA13028E22564A1BD = 0xA13028E22564A1BD,
        _0x485B05EF05B9AEE9 = 0x485B05EF05B9AEE9,
        _0x6B53F4B811E583D2 = 0x6B53F4B811E583D2,
        _0x75B49ACD73617437 = 0x75B49ACD73617437,
        _0x1098CDA477890165 = 0x1098CDA477890165,
        _0x98A7598C579EE871 = 0x98A7598C579EE871,
        _0x9E8711C81AA17876 = 0x9E8711C81AA17876,
        _0x404527BC03DA0E6C = 0x404527BC03DA0E6C,
        _0xE12F5ED49F44D40D = 0xE12F5ED49F44D40D,
        _0xF6E3D38869D0F7AD = 0xF6E3D38869D0F7AD,
        _0x8878FF3EEE2868A9 = 0x8878FF3EEE2868A9,
        _0x331CBD247FC5DAA8 = 0x331CBD247FC5DAA8,
        _0x0516FAE561276EFC = 0x0516FAE561276EFC,
        _0x45853F4E17D847D5 = 0x45853F4E17D847D5,
        _0x6E585A616ABB8401 = 0x6E585A616ABB8401,
        _0x15206E88FF7617DF = 0x15206E88FF7617DF,
        _0xA7966807953A18EE = 0xA7966807953A18EE,
        _0x6B34BE961F639E21 = 0x6B34BE961F639E21,
        _0xE6BD7DD3FD474415 = 0xE6BD7DD3FD474415,
        _0x615B3B8E73634509 = 0x615B3B8E73634509,
        _0x38E7DD70A242D5CB = 0x38E7DD70A242D5CB,
        _0x63509DDF102E08E8 = 0x63509DDF102E08E8,
        _0x7408B5C66BA31ADB = 0x7408B5C66BA31ADB,
        _0x41365DB586CD9E8E = 0x41365DB586CD9E8E,
        _0xD0AABE5B9F8FA589 = 0xD0AABE5B9F8FA589,
        _0x427C919E9809E370 = 0x427C919E9809E370,
        _0xC29996A337BDD099 = 0xC29996A337BDD099,
        _0x1E8A921112891651 = 0x1E8A921112891651,
        _0xB4241AD8F5AEE9ED = 0xB4241AD8F5AEE9ED,
        _0xA230A5DDE12ED374 = 0xA230A5DDE12ED374,
        _0x0D5FDF0D36FA10CD = 0x0D5FDF0D36FA10CD,
        _0xE682002DB1F30669 = 0xE682002DB1F30669,
        _0x718EB706B6E998A0 = 0x718EB706B6E998A0,
        _0xF05DFAF1ADFEF2CD = 0xF05DFAF1ADFEF2CD,
        _0xD1DF5E54F4ACBE1A = 0xD1DF5E54F4ACBE1A,
        _0x0FDDEE66E3465726 = 0x0FDDEE66E3465726,
        _0x4C05B42A8D937796 = 0x4C05B42A8D937796,
        _0xB961DD799A837BD7 = 0xB961DD799A837BD7,
        _0x16B86A49E072AA85 = 0x16B86A49E072AA85,
        _0x2A7413168F6CD5A8 = 0x2A7413168F6CD5A8,
        _0xFFFE15B433300B8C = 0xFFFE15B433300B8C,
        _0x6EA1273D525427F4 = 0x6EA1273D525427F4,
        _0x7BE0746539DEF0C8 = 0x7BE0746539DEF0C8,
        _0x3137EDC899E6DAE4 = 0x3137EDC899E6DAE4,
        _0x6C87F49BFA181DB5 = 0x6C87F49BFA181DB5,
        _0x85D39F5E3B6D7EB0 = 0x85D39F5E3B6D7EB0,
        _0x0E558D3A49D759D6 = 0x0E558D3A49D759D6,
        _0xD4907EF4334C7602 = 0xD4907EF4334C7602,
        _0x68830738A6BFB370 = 0x68830738A6BFB370,
        _0x60B7D1DCC312697D = 0x60B7D1DCC312697D,
        _0x8DF5F6A19F99F0D5 = 0x8DF5F6A19F99F0D5,
        _0x671A07C9A1CD50A5 = 0x671A07C9A1CD50A5,
        _0xDD100CE1EBBF37E3 = 0xDD100CE1EBBF37E3,
        _0x160C1B5AB48AB87C = 0x160C1B5AB48AB87C,
        _0x3660BCAB3A6BB734 = 0x3660BCAB3A6BB734,
        _0x787E43477746876F = 0x787E43477746876F,
        _0xC9EA26893C9E4024 = 0xC9EA26893C9E4024,
        _0xA72B1BF3857B94D7 = 0xA72B1BF3857B94D7,
        _0xB9D5BDDA88E1BB66 = 0xB9D5BDDA88E1BB66,
        _0x63DC1F22C903B709 = 0x63DC1F22C903B709,
        _0x33992A808DF1C1BA = 0x33992A808DF1C1BA,
        _0x065D03A9D6B2C6B5 = 0x065D03A9D6B2C6B5,
        _0x3053064F909B5F42 = 0x3053064F909B5F42,
        _0x7549B9E841940695 = 0x7549B9E841940695,
        _0x3C9628A811CBD724 = 0x3C9628A811CBD724,
        _0x67995318F5FAA496 = 0x67995318F5FAA496,
        _0x09034479E6E3E269 = 0x09034479E6E3E269,
        _0xD9BF3ED8EFB67EA3 = 0xD9BF3ED8EFB67EA3,
        _0x785639D89F8451AB = 0x785639D89F8451AB,
        _0xE6C5E2125EB210C1 = 0xE6C5E2125EB210C1,
        _0x3ABFA128F5BF5A70 = 0x3ABFA128F5BF5A70,
        _0x2C46D2A591D8C322 = 0x2C46D2A591D8C322,
        _0xCAFF2C9747103C02 = 0xCAFF2C9747103C02,
        _0x138398153824E332 = 0x138398153824E332,
        _0x34BCF6209B9668A7 = 0x34BCF6209B9668A7,
        _0xD0BA1853D76683C8 = 0xD0BA1853D76683C8,
        _0xDC69F6913CCA0B99 = 0xDC69F6913CCA0B99,
        _0x7840576C50A13DBA = 0x7840576C50A13DBA,
        _0xD0116DF21E6C7B36 = 0xD0116DF21E6C7B36,
        _0x54CBDD6E1B4CB4DF = 0x54CBDD6E1B4CB4DF,
        _0x1180A2974D251B7B = 0x1180A2974D251B7B,
        _0x9CC94A948EAF5372 = 0x9CC94A948EAF5372,
        _0xDE8C5B9F65017FA1 = 0xDE8C5B9F65017FA1,
        _0xAF787E081AC4A8EE = 0xAF787E081AC4A8EE,
        _0xBA958F68031DDBFC = 0xBA958F68031DDBFC,
        _0x1A861F899EBBE17C = 0x1A861F899EBBE17C,
        _0xF8F7DA13CFBD4532 = 0xF8F7DA13CFBD4532,
        _0xCFE122EC635CC2B2 = 0xCFE122EC635CC2B2,
        _0x2BB2B5BCF0DF8008 = 0x2BB2B5BCF0DF8008,
        _0x6703872EC09BC158 = 0x6703872EC09BC158,
        _0x1BFBAFCC6760FF02 = 0x1BFBAFCC6760FF02,
        _0xF5EA41C1408695FB = 0xF5EA41C1408695FB,
        _0xC84E138448507567 = 0xC84E138448507567,
        _0x0E3BF7ED4169EC43 = 0x0E3BF7ED4169EC43,
        _0x8D3230A0ED7DE39F = 0x8D3230A0ED7DE39F,
        _0xCF9DA72002FC16BF = 0xCF9DA72002FC16BF,
        _0x104D9A7B1C0D0783 = 0x104D9A7B1C0D0783,
        _0x23A3AB86E0807721 = 0x23A3AB86E0807721,
        _0xC1842F40FD501DA2 = 0xC1842F40FD501DA2,
        _0x30D86B2B7622D0EB = 0x30D86B2B7622D0EB,
        _0x09C970AE59ABF6B2 = 0x09C970AE59ABF6B2,
        _0x1EF36558FBDE2DAA = 0x1EF36558FBDE2DAA,
        _0x7F8E2B131E1DCA6C = 0x7F8E2B131E1DCA6C,
        _0x13C190302369308B = 0x13C190302369308B,
        _0xCBF88256E44D5D39 = 0xCBF88256E44D5D39,
        _0xC325A6BAA62CF8A2 = 0xC325A6BAA62CF8A2,
        _0x0CD7914D17A970AB = 0x0CD7914D17A970AB,
        _0x23F66C36F8E5EAAB = 0x23F66C36F8E5EAAB,
        _0x697DF68F3A761A50 = 0x697DF68F3A761A50,
        _0x27E3F2B57209FA54 = 0x27E3F2B57209FA54,
        _0x15CC8C33D7FFCC4A = 0x15CC8C33D7FFCC4A,
        _0xDC0556D0F484ECAA = 0xDC0556D0F484ECAA,
        _0xE777DDF3E78397E8 = 0xE777DDF3E78397E8,
        _0xCEC4CA2CAB8FA98C = 0xCEC4CA2CAB8FA98C,
        _0x012701ED938B85DE = 0x012701ED938B85DE,
        _0x8379E05871AD24E0 = 0x8379E05871AD24E0,
        _0xF5FFB08976911B50 = 0xF5FFB08976911B50,
        _0x316CDB5B6E8F4110 = 0x316CDB5B6E8F4110,
        _0x4402960666000E62 = 0x4402960666000E62,
        _0xB36D3EC70963BE60 = 0xB36D3EC70963BE60,
        _0x0F7F603BDE08C4D3 = 0x0F7F603BDE08C4D3,
        _0x5B1A26BB18E7D451 = 0x5B1A26BB18E7D451,
        _0x35D302397E524939 = 0x35D302397E524939,
        _0xC399CC89FBA05DA0 = 0xC399CC89FBA05DA0,
        _0x0BA4250D20007C2E = 0x0BA4250D20007C2E,
        _0x2200AB13CBD10F4E = 0x2200AB13CBD10F4E,
        _0xB42C87521D1BDD2F = 0xB42C87521D1BDD2F,
        _0xC351394B932A6A50 = 0xC351394B932A6A50,
        _0x172E9DD35858DCD7 = 0x172E9DD35858DCD7,
        _0x877EA24EB1614495 = 0x877EA24EB1614495,
        _0x9D12796EF4BF9EA9 = 0x9D12796EF4BF9EA9,
        _0x850CE59DEC2028F3 = 0x850CE59DEC2028F3,
        _0x0355FE37240E2C77 = 0x0355FE37240E2C77,
        _0x3D86997A86FEEF0D = 0x3D86997A86FEEF0D,
        _0xD826690B5CF3BEFF = 0xD826690B5CF3BEFF,
        _0x165BE2001E5E4B75 = 0x165BE2001E5E4B75,
        _0x6090A031C69F384E = 0x6090A031C69F384E,
        _0x226C6A4E3346D288 = 0x226C6A4E3346D288,
        _0x41503629D1139ABC = 0x41503629D1139ABC,
        _0x0794199B25E499E1 = 0x0794199B25E499E1,
        _0x73118A3EE9C9B6DB = 0x73118A3EE9C9B6DB,
        _0xE1C0F8781BF130C2 = 0xE1C0F8781BF130C2,
        _0xCB2CA620C48BC875 = 0xCB2CA620C48BC875,
        _0x18714953CCED17D3 = 0x18714953CCED17D3,
        _0x41F0B254DDF71473 = 0x41F0B254DDF71473,
        _0x8E5DA070BAD3279E = 0x8E5DA070BAD3279E,
        _0xE1A83D4A3B5D7938 = 0xE1A83D4A3B5D7938,
        _0x6DE072AC8A95FFC1 = 0x6DE072AC8A95FFC1,
        _0xC4A2C11FC0D41916 = 0xC4A2C11FC0D41916,
        _0xFC4F15A7DDDC47B1 = 0xFC4F15A7DDDC47B1,
        _0xCF342503CA4C8DF1 = 0xCF342503CA4C8DF1,
        _0x06A09A6E0C6D2A84 = 0x06A09A6E0C6D2A84,
        _0xAE7E66A61E7C17A5 = 0xAE7E66A61E7C17A5,
        _0xEF28A614B4B264B8 = 0xEF28A614B4B264B8,
        _0x04F0579DBDD32F34 = 0x04F0579DBDD32F34,
        _0x12F6C6ED3EFF42DE = 0x12F6C6ED3EFF42DE,
        _0x87B974E54C71BA7B = 0x87B974E54C71BA7B,
        _0xBD3C4A2ED509205E = 0xBD3C4A2ED509205E,
        _0xD1EFA8D68BF5D63D = 0xD1EFA8D68BF5D63D,
        _0x1121B07088ED3013 = 0x1121B07088ED3013,
        _0x42404D57D621601A = 0x42404D57D621601A,
        _0x288CBB414C3C2FBB = 0x288CBB414C3C2FBB,
        _0x6FD7BDF10304363A = 0x6FD7BDF10304363A,
        _0xCEB1F1EED484A5B4 = 0xCEB1F1EED484A5B4,
        _0xF57DB8E83DCD8349 = 0xF57DB8E83DCD8349,
        _0x7C9E45A4CED2E8DA = 0x7C9E45A4CED2E8DA,
        _0x87344305778E5415 = 0x87344305778E5415,
        _0x6835AFEA10E186F4 = 0x6835AFEA10E186F4,
        _0x8C6D9A399126C194 = 0x8C6D9A399126C194,
        _0x14DA8C4BC2CCD90A = 0x14DA8C4BC2CCD90A,
        _0xCACAB2B123BBDBD6 = 0xCACAB2B123BBDBD6,
        _0xFF2B1F59FB892F14 = 0xFF2B1F59FB892F14,
        _0x5AADC7BBBB1BCEEB = 0x5AADC7BBBB1BCEEB,
        _0xD798DF5DB67B1659 = 0xD798DF5DB67B1659,
        _0x31F343383F19C987 = 0x31F343383F19C987,
        _0x07E2E21E799080A0 = 0x07E2E21E799080A0,
        _0xC2E62678D602853C = 0xC2E62678D602853C,
        _0x873AAF600CC36DAC = 0x873AAF600CC36DAC,
        _0x51C7694E140FAE43 = 0x51C7694E140FAE43,
        _0x8DECD262602548B9 = 0x8DECD262602548B9,
        _0xCBC7B6F9A56B79F6 = 0xCBC7B6F9A56B79F6,
        _0x37D238BE69F7378A = 0x37D238BE69F7378A,
        _0x703D4FB366DA4452 = 0x703D4FB366DA4452,
        _0x762FDC4C19E5A981 = 0x762FDC4C19E5A981,
        _0x2045429505158D1A = 0x2045429505158D1A,
        _0x13EB275BF81636D1 = 0x13EB275BF81636D1,
    }
    public static class NATIVE_VEHICLE_EXTENSIONS
    {
        public static void Call(this NATIVE_VEHICLE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_VEHICLE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}