using System;
namespace Hotstar
{
    public enum NATIVE_TASK : ulong
    { 
        /// <summary>
        /// This tasks the ped to do nothing for the specified amount of miliseconds.
        /// This is useful if you want to add a delay between tasks when using a sequence task.
        ///
        /// > Ped ped
        /// > int ms
        ///
        /// </summary>
        TASK_PAUSE = 0xE73A266DB0CA9042,
        /// <summary>
        /// Makes the specified ped stand still for (time) milliseconds.
        ///
        /// > Ped ped
        /// > int time
        ///
        /// </summary>
        TASK_STAND_STILL = 0x919BE13EED931959,
        /// <summary>
        /// Dismounts the ped from the animal it's mounted on. taskFlag affects what side the rider gets off. 1 << 18 will get off on the left side, where any other value will get off on the right side. The only other known value are 1 << 17 and 1 << 24, which has the behavior of any other value (getting off the animal from the right side). p2-p5 are almost always 0.
        ///
        /// > Ped rider
        /// > int taskFlag
        /// > Any p2
        /// > Any p3
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        TASK_DISMOUNT_ANIMAL = 0x48E92D3DDE23C23A,
        /// <summary>
        /// Makes the specified ped achieve the specified heading.
        /// 
        /// pedHandle: The handle of the ped to assign the task to.
        /// heading: The desired heading.
        /// timeout: The time, in milliseconds, to allow the task to complete. If the task times out, it is cancelled, and the ped will stay at the heading it managed to reach in the time.
        ///
        /// > Ped ped
        /// > float heading
        /// > int timeout
        ///
        /// </summary>
        TASK_ACHIEVE_HEADING = 0x93B93A37987F1F3D,
        /// <summary>
        /// Clears the current point route. Call this before TASK_EXTEND_ROUTE and TASK_FOLLOW_POINT_ROUTE.
        ///
        ///
        /// </summary>
        TASK_FLUSH_ROUTE = 0x841142A1376E9006,
        /// <summary>
        /// Adds a new point to the current point route. Call TASK_FLUSH_ROUTE before the first call to this. Call TASK_FOLLOW_POINT_ROUTE to make the Ped go the route.
        /// 
        /// A maximum of 8 points can be added.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        TASK_EXTEND_ROUTE = 0x1E7889778264843A,
        /// <summary>
        /// Makes the specified ped flee the specified distance from the specified position.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float distance
        /// > int time
        /// > int fleeType
        /// > float fleeSpeed
        ///
        /// </summary>
        TASK_SMART_FLEE_COORD = 0x94587F17E9C365D5,
        /// <summary>
        /// Makes a ped run away from another ped (fleeFromTarget)
        /// 
        /// fleeDistance = ped will flee this distance
        /// fleeTime = ped will flee for this amount of time, set to "-1" to flee forever
        /// fleeType = can be 0, R* Scripts: fm_mission/race_controller: 66048; fme_escaped_convicts: 2260992, 2523136, 2359296; la_alligator/fox: 2097152; net_fetch: 17301536; net_stable_mount: 540928
        /// fleeSpeed = mostly 3f, rarely 1f in R* Scripts
        ///
        /// > Ped ped
        /// > Ped fleeFromTarget
        /// > float fleeDistance
        /// > int fleeTime
        /// > int fleeType
        /// > float fleeSpeed
        /// > Any p6
        ///
        /// </summary>
        TASK_SMART_FLEE_PED = 0x22B0D0E37CCB840D,
        /// <summary>
        /// Has the ped react to another entity. The reactionType determines how the ped reacts. p3 is 7.5f in the scripts. p4 is 0f. unkFlag is always 4. The rest of the parameters are unknown, but 0 is acceptable input. Here is a list of the different reaction type values by Mooshe: https://pastebin.com/Ju7BbmMt
        ///
        /// > Ped ped
        /// > Entity reactingTo
        /// > int reactionType
        /// > float p3
        /// > float p4
        /// > int unkFlag
        /// > Any p6
        /// > Any p7
        /// > Any p8
        ///
        /// </summary>
        TASK_REACT = 0xC4C32C31920E1B70,
        /// <summary>
        /// Makes ped walk around the area.
        /// 
        /// set p1 to 10.0f and p2 to 10 if you want the ped to walk anywhere without a duration.
        ///
        /// > Ped ped
        /// > float p1
        /// > int p2
        ///
        /// </summary>
        TASK_WANDER_STANDARD = 0xBB9CE077274F6A1B,
        /// <summary>
        /// Params: p2, p3 are set to 0 in R* Scripts
        ///
        /// > Ped ped
        /// > int action
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        TASK_HORSE_ACTION = 0xA09CFD29100F06C3,
        /// <summary>
        /// If no timeout, set timeout to -1.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float speedMultiplier
        /// > int timeout
        /// > float stoppingRange
        /// > int flags
        /// > float unk
        ///
        /// </summary>
        TASK_FOLLOW_NAV_MESH_TO_COORD = 0x15D3A79D4E44B913,
        /// <summary>
        /// param3: duration in ms, use -1 to look forever
        /// param4: using 2048 is fine
        /// param5: using 3 is fine
        ///
        /// > Ped ped
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        TASK_LOOK_AT_ENTITY = 0x69F4BE8C8CC4796C,
        /// <summary>
        /// returned values:
        /// 0 to 7 = task that's currently in progress, 0 meaning the first one.
        /// -1 no task sequence in progress.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_SEQUENCE_PROGRESS = 0x00A9010CFE1E3533,
        /// <summary>
        /// Gets the status of a script-assigned task.
        /// taskHash: https://alloc8or.re/rdr3/doc/enums/eScriptTaskHash.txt
        ///
        /// > Ped ped
        /// > Hash taskHash
        /// > BOOL p2
        ///
        /// </summary>
        GET_SCRIPT_TASK_STATUS = 0x77F1BEB8863288D5,
        /// <summary>
        /// duration: the amount of time in milliseconds to do the task.  -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
        ///
        /// > Ped ped
        /// > Entity targetEntity
        /// > int duration
        /// > BOOL p3
        /// > int p4
        ///
        /// </summary>
        TASK_AIM_GUN_AT_ENTITY = 0x9B53BB6E8943AF53,
        /// <summary>
        /// duration: the amount of time in milliseconds to do the task. -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
        ///
        /// > Ped ped
        /// > Entity targetEntity
        /// > int duration
        /// > float p3
        /// > float p4
        /// > float p5
        ///
        /// </summary>
        TASK_TURN_PED_TO_FACE_ENTITY = 0x5AD23D40115353AC,
        /// <summary>
        /// Makes the specified ped shuffle to the next vehicle seat.
        /// The ped MUST be in a vehicle and the vehicle parameter MUST be the ped's current vehicle.
        ///
        /// > Ped ped
        /// > Any p1
        ///
        /// </summary>
        TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT = 0x7AA80209BDA643EB,
        /// <summary>
        /// duration in milliseconds
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int duration
        ///
        /// </summary>
        TASK_TURN_PED_TO_FACE_COORD = 0x1DDA930A0AC38571,
        /// <summary>
        /// Documentation from GTA V, might be the same in RDR:
        /// 
        /// '1 - brake
        /// '3 - brake + reverse
        /// '4 - turn left 90 + braking
        /// '5 - turn right 90 + braking
        /// '6 - brake strong (handbrake?) until time ends
        /// '7 - turn left + accelerate
        /// '7 - turn right + accelerate
        /// '9 - weak acceleration
        /// '10 - turn left + restore wheel pos to center in the end
        /// '11 - turn right + restore wheel pos to center in the end
        /// '13 - turn left + go reverse
        /// '14 - turn left + go reverse
        /// '16 - crash the game after like 2 seconds :)
        /// '17 - keep actual state, game crashed after few tries
        /// '18 - game crash
        /// '19 - strong brake + turn left/right
        /// '20 - weak brake + turn left then turn right
        /// '21 - weak brake + turn right then turn left
        /// '22 - brake + reverse
        /// '23 - accelerate fast
        /// '24 - brake
        /// '25 - brake turning left then when almost stopping it turns left more
        /// '26 - brake turning right then when almost stopping it turns right more
        /// '27 - brake until car stop or until time ends
        /// '28 - brake + strong reverse acceleration
        /// '30 - performs a burnout (brake until stop + brake and accelerate)
        /// '31 - accelerate + handbrake
        /// '32 - accelerate very strong
        /// 
        /// Seems to be this:
        /// Works on NPCs, but overrides their current task. If inside a task sequence (and not being the last task), "time" will work, otherwise the task will be performed forever until tasked with something else
        ///
        /// > Ped driver
        /// > Vehicle vehicle
        /// > int action
        /// > int time
        ///
        /// </summary>
        TASK_VEHICLE_TEMP_ACTION = 0xC429DCEEB339E129,
        /// <summary>
        /// See TASK_VEHICLE_MISSION
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > Ped pedTarget
        /// > int mode
        /// > float maxSpeed
        /// > int drivingStyle
        /// > float minDistance
        /// > float p7
        /// > BOOL DriveAgainstTraffic
        ///
        /// </summary>
        TASK_VEHICLE_MISSION_PED_TARGET = 0x9454528DF15D657A,
        /// <summary>
        /// Climbs or vaults the nearest thing.
        ///
        /// > Ped ped
        /// > BOOL unused
        ///
        /// </summary>
        TASK_CLIMB = 0x89D9FCC2435112F1,
        /// <summary>
        /// Immediately stops the pedestrian from whatever it's doing. They stop fighting, animations, etc. they forget what they were doing.
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        CLEAR_PED_TASKS_IMMEDIATELY = 0xAAA34F8A7CB32098,
        /// <summary>
        /// ped = Ped you want to perform this task.
        /// target = the Entity they should aim at.
        /// distanceToStopAt = distance from the target, where the ped should stop to aim.
        /// StartAimingDist = distance where the ped should start to aim.
        ///
        /// > Ped ped
        /// > Entity target
        /// > float distanceToStopAt
        /// > float StartAimingDist
        ///
        /// </summary>
        TASK_GOTO_ENTITY_AIMING = 0xA9DA48FAB8A76C12,
        /// <summary>
        /// Checks if there is a cover point at position
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS = 0xA98B8E3C088E5A31,
        /// <summary>
        /// meleeStyles: AR_GRAPPLE_BACK_FROM_BACK, AR_GRAPPLE_MOUNT_FACEDOWN_FROM_FRONT, AR_ALLIGATOR_LEAPKILL, AR_ALLIGATOR_WAIST_AUTOKILL_FRONT
        ///
        /// > Ped ped
        /// > Ped meleeTarget
        /// > Hash meleeStyle
        /// > float p3
        /// > float p4
        /// > Any p5
        /// > Any p6
        ///
        /// </summary>
        TASK_PUT_PED_DIRECTLY_INTO_MELEE = 0x1C6CD14A876FFE39,
        /// <summary>
        /// grappleStyle: AR_GRAPPLE_STRUGGLE, AR_ALLIGATOR_LEG_GRAB_CHALLENGE_FAIL, AR_GRAPPLE_BACK_FROM_BACK, AR_GRAPPLE_BACK_DEFEND, AR_GRAPPLE_FRONT_FROM_FRONT
        ///
        /// > Ped ped
        /// > Ped grappleTarget
        /// > Hash grappleStyle
        /// > float p3
        /// > float p4
        /// > Any p5
        /// > Any p6
        ///
        /// </summary>
        TASK_PUT_PED_DIRECTLY_INTO_GRAPPLE = 0xA05F3F20889D7A5B,
        /// <summary>
        /// Not implemented.
        ///
        /// > Ped ped
        /// > float maxCruiseSpeed
        ///
        /// </summary>
        SET_DRIVE_TASK_MAX_CRUISE_SPEED = 0x404A5AA9B9F0B746,
        /// <summary>
        /// Returns scenario
        ///
        /// > Hash scenarioHash
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > Any p5
        /// > Any p6
        /// > Any p7
        ///
        /// </summary>
        CREATE_SCENARIO_POINT_HASH = 0x94B745CE41DB58A1,
        /// <summary>
        /// Returns scenario
        ///
        /// > Entity entity
        /// > Hash scenarioHash
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > Any p6
        /// > Any p7
        /// > Any p8
        ///
        /// </summary>
        CREATE_SCENARIO_POINT_HASH_ATTACHED_TO_ENTITY = 0x794AB1379A74064D,
        /// <summary>
        /// p1 is always true
        ///
        /// > int scenario
        /// > BOOL p1
        ///
        /// </summary>
        _GET_SCENARIO_POINT_COORDS = 0xA8452DD321607029,
        /// <summary>
        /// p1 is always true
        ///
        /// > int Scenario
        /// > BOOL p1
        ///
        /// </summary>
        _GET_SCENARIO_POINT_HEADING = 0xB93EA7184BAA85C3,
        /// <summary>
        /// Despite its name, it only attacks ONE hated target. The one closest to the specified position.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int flags
        /// > Any p6
        ///
        /// </summary>
        TASK_COMBAT_HATED_TARGETS_IN_AREA = 0x4CF5F55DAC3280A0,
        /// <summary>
        /// Despite its name, it only attacks ONE hated target. The one closest hated target.
        ///
        /// > Ped ped
        /// > float radius
        /// > int flags
        /// > Any p3
        ///
        /// </summary>
        TASK_COMBAT_HATED_TARGETS_AROUND_PED = 0x7BF835BB9E2698C8,
        /// <summary>
        /// This native checks if a ped is on the ground, in pain from a (gunshot) wound.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_IN_WRITHE = 0xDEB6D52126E7D640,
        /// <summary>
        /// Makes the ped run to take cover
        ///
        /// > Ped ped
        ///
        /// </summary>
        TASK_STAY_IN_COVER = 0xE5DA8615A6180789,
        /// <summary>
        /// shootatEntity:
        /// If true, peds will shoot at Entity till it is dead.
        /// If false, peds will just walk till they reach the entity and will cease shooting.
        ///
        /// > Ped ped
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        /// > Any p5
        /// > Any p6
        /// > Any p7
        /// > Any p8
        /// > Any p9
        /// > Any p10
        ///
        /// </summary>
        TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY = 0x97465886D35210E9,
        /// <summary>
        /// Makes the ped ragdoll like when falling from a great height
        ///
        /// > Ped ped
        /// > int p1
        /// > int p2
        /// > int p3
        ///
        /// </summary>
        SET_HIGH_FALL_TASK = 0x8C825BDC7741D37C,
        /// <summary>
        /// motionStateHash: see FORCE_PED_MOTION_STATE
        ///
        /// > Ped ped
        /// > Hash motionStateHash
        /// > BOOL p2
        ///
        /// </summary>
        TASK_FORCE_MOTION_STATE = 0x4F056E1AFFEF17AB,
        /// <summary>
        /// Returns hash of the underlying move network def, see move_networks.xml
        /// https://alloc8or.re/rdr3/doc/misc/move_networks.txt
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_TASK_MOVE_NETWORK_ID = 0xCACC2F9D994504B7,
        /// <summary>
        /// This function is hard-coded to always return false.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_BEING_ARRESTED = 0x90A09F3A45FED688,
        /// <summary>
        /// carriableSlot:
        ///  7 > Back of a horse
        ///  6 > Right side of a horse
        ///  5 > Left side of a horse
        /// flags:
        ///  512: enables the prompt being the name of the item when using a generic item
        ///
        /// > Entity entity
        /// > Hash carryConfig
        /// > Ped carrier
        /// > int carriableSlot
        /// > int flags
        ///
        /// </summary>
        TASK_CARRIABLE = 0xF0B4F759F35CC7F5,
        /// <summary>
        /// getupSetHash: see nm_blend_out_sets.meta
        ///
        /// > Ped ped
        /// > int flags
        /// > Hash getupSetHash
        /// > const char* p3
        /// > const char* p4
        /// > float p5
        ///
        /// </summary>
        UNHOGTIE_PED = 0x79559BAD83CCD038,
        /// <summary>
        /// grappleStyle: AR_GRAPPLE_MOUNT_STANDING_FROM_FRONT, AR_GRAPPLE_MOUNT_STANDING_FROM_RIGHT, AR_GRAPPLE_MOUNT_STANDING_FROM_BACK, AR_GRAPPLE_MOUNT_STANDING_FROM_LEFT, AR_GRAPPLE_MOUNT_FROM_FRONT, AR_WOLF_EXECUTION_ENTER_FROM_BACK, AR_GRAPPLE_DRAG_FRONT_ON_ASS, AR_GRAPPLE_FRONT_FROM_LEFT_FAR, AR_BEAR_CHALLENGE_FRONT, AR_GRAPPLE_FRONT_FROM_FRONT, AR_GRAPPLE_MOUNT_FACEUP_FROM_FRONT
        ///
        /// > Ped ped
        /// > Ped targetPed
        /// > Hash grappleStyle
        /// > int p3
        /// > float p4
        /// > int p5
        /// > int p6
        ///
        /// </summary>
        TASK_GRAPPLE = 0x779A2FFACEFAEA7B,
        /// <summary>
        /// Baits: see 0x9B0C7FA063E67629
        ///
        /// > Ped ped
        /// > const char* bait
        /// > BOOL withoutBuoy
        ///
        /// </summary>
        TASK_SWAP_FISHING_BAIT = 0x2C28AC30A72722DA,
        /// <summary>
        /// category:
        /// enum class eEmoteCategory
        /// {
        /// 	Reaction,
        /// 	Action,
        /// 	Taunts,
        /// 	Greets,
        /// 	TwirlGun,
        /// 	Dances
        /// };
        /// 
        /// p2: usually 2
        /// 
        /// emoteType: https://alloc8or.re/rdr3/doc/enums/eEmoteType.txt
        ///
        /// > Ped ped
        /// > int category
        /// > int p2
        /// > Hash emoteType
        /// > BOOL p4
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL p8
        ///
        /// </summary>
        TASK_PLAY_EMOTE_WITH_HASH = 0xB31A277C1AC7B7FF,
        /// <summary>
        /// Similar to 0xB31A277C1AC7B7FF but checks if the ped's inventory contains the specified emote kit.
        ///
        /// > Ped ped
        /// > int category
        /// > int p2
        /// > Hash emoteType
        /// > BOOL p4
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL p8
        ///
        /// </summary>
        _TASK_PLAY_EMOTE = 0x884E3436CC1F41DD,
        /// <summary>
        /// Opens/closes containers: ChestDugUp
        ///
        /// > Entity entity
        /// > BOOL open
        ///
        /// </summary>
        _0x188F8071F244B9B8 = 0x188F8071F244B9B8,
        /// <summary>
        /// groundSetting: 0: spawn on ground, 2 (1?): do not spawn on ground
        /// p7: -1 in R* Scripts
        /// Returns compositeId
        ///
        /// > Hash asset
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > int groundSetting
        /// > Any* p6
        /// > int p7
        ///
        /// </summary>
        _0x5B4BBE80AD5972DC = 0x5B4BBE80AD5972DC,
        /// <summary>
        /// Returns true while a hat is being picked up
        ///
        /// > Object hatObject
        ///
        /// </summary>
        _0x11CD066F54DA0133 = 0x11CD066F54DA0133,
        /// <summary>
        /// Returns true while a hat is being picked up. Similar to 0x11CD066F54DA0133
        ///
        /// > Object hatObject
        ///
        /// </summary>
        _0x4ECCC2815CA79AE2 = 0x4ECCC2815CA79AE2,
        /// <summary>
        /// Only used in R* Scripts fishing_core and av_fishing_river
        ///
        /// > Ped ped
        /// > Any* p1
        ///
        /// </summary>
        _0xF3735ACD11ACD500 = 0xF3735ACD11ACD500,
        /// <summary>
        /// Only used in R* Scripts fishing_core and av_fishing_river
        ///
        /// > Ped ped
        /// > Any* p1
        ///
        /// </summary>
        _0xF3735ACD11ACD501 = 0xF3735ACD11ACD501,
        /// <summary>
        /// Baits: p_fishHook02x, p_baitBread01x, p_baitCorn01x, p_baitCheese01x, p_baitWorm01x, p_baitCricket01x, p_crawdad01x, p_finisheDragonfly01x, p_finisdFishlure01x, p_finishdCrawd01x, p_finisheDragonflyLegendary01x, p_finisdFishlureLegendary01x, p_finishdCrawdLegendary01x, p_lgoc_spinner_v4
        ///
        /// > Ped ped
        /// > const char* bait
        /// > BOOL withoutBuoy
        /// > BOOL instantly
        ///
        /// </summary>
        _0x9B0C7FA063E67629 = 0x9B0C7FA063E67629,
        TASK_JUMP = 0x0AE4086104E067B1,
        _TASK_JUMP_2 = 0x91083103137D7254,
        TASK_COWER = 0x3EB1FE9E8E908E15,
        TASK_HANDS_UP = 0xF2EAB31979A7F910,
        TASK_KNOCKED_OUT = 0xF90427F00A495A28,
        TASK_KNOCKED_OUT_AND_HOGTIED = 0x42AC6401ABB8C7E5,
        UPDATE_TASK_HANDS_UP_DURATION = 0xA98FCAFD7893C834,
        TASK_DUCK = 0xA14B5FBF986BAC23,
        _TASK_BOARD_VEHICLE = 0xE53D17AD837CBF7C,
        _TASK_DISEMBARK_VEHICLE = 0xA7C6854BB5A4192A,
        _TASK_BOARD_VEHICLE_2 = 0xE41A09C8DDFF7AA4,
        TASK_DISEMBARK_NEAREST_TRAIN_CARRIAGE = 0x0A11F3BDEC03ED5F,
        TASK_ENTER_VEHICLE = 0xC20E50AA46D09CA8,
        TASK_LEAVE_VEHICLE = 0xD3DBCE61A490BE02,
        TASK_MOUNT_ANIMAL = 0x92DB0739813C5186,
        TASK_HITCH_ANIMAL = 0x9030AD4B6207BFE8,
        TASK_VEHICLE_DRIVE_TO_COORD = 0xE2A2AA2F659D77A7,
        _TASK_VEHICLE_DRIVE_TO_COORD_2 = 0xF0108F01FB105DA2,
        TASK_VEHICLE_DRIVE_WANDER = 0x480142959D337D00,
        TASK_FOLLOW_TO_OFFSET_OF_ENTITY = 0x304AE42E357B8C7E,
        TASK_FOLLOW_TO_OFFSET_OF_COORD = 0x2E3676282C18A692,
        TASK_GO_STRAIGHT_TO_COORD = 0xD76B57B44F1E6F8B,
        TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY = 0x61E360B7E040D12E,
        TASK_MOVE_IN_TRAFFIC = 0x8AA1593AEC087A29,
        TASK_MOVE_IN_TRAFFIC_TO_DESTINATION = 0xDCA3A13F7A45338B,
        TASK_MOVE_IN_TRAFFIC_AWAY_FROM_ENTITY = 0x13DED0BC45600FE1,
        _TASK_MOVE_IN_TRAFFIC_4 = 0x79482C12482A860D,
        TASK_FOLLOW_POINT_ROUTE = 0x0E14C5550DC3CD1D,
        TASK_ENTER_ANIM_SCENE = 0xC2329B0206426644,
        TASK_MOVE_BE_IN_FORMATION = 0x4AA5AA97C65E4A2F,
        TASK_GO_TO_ENTITY = 0x6A071245EB0D1882,
        TASK_FOLLOW_AND_CONVERSE_WITH_PED = 0x489FFCCCE7392B55,
        TASK_WANDER_AND_CONVERSE_WITH_PED = 0x8AC76D1408731732,
        TASK_LEAD_AND_CONVERSE = 0xAA19711D33C6708C,
        TASK_SEEK_CLEAR_LOS_TO_ENTITY = 0x8D7F2A63688C20A4,
        TASK_GO_TO_WHISTLE = 0xBAD6545608CECA6E,
        TASK_LEAD_HORSE = 0x9A7A4A54596FE09D,
        TASK_STOP_LEADING_HORSE = 0xED27560703F37258,
        _TASK_FLEE_FROM_COORD = 0x6879FF208ED87F2A,
        _TASK_FLEE_FROM_PED = 0x7B74D8EEDE9B5727,
        TASK_FLEE_COORD = 0x58428248BF4B64E4,
        TASK_FLEE_PED = 0xFD45175A6DFD7CE9,
        TASK_FLEE_COORD_VIA = 0x390E0B697D25EAF5,
        TASK_FLEE_PED_VIA = 0x5802E0F910E4CF1D,
        TASK_FLY_AWAY = 0xE86A537B5A3C297C,
        TASK_FLY_TO_COORD = 0xD6CFC2D59DA72042,
        TASK_FLYING_CIRCLE = 0x72997893BFB8ECCC,
        TASK_WALK_AWAY = 0x04ACFAC71E6858F9,
        TASK_SHOCKING_EVENT_REACT = 0x452419CBD838065B,
        TASK_WANDER_IN_AREA = 0xE054346CA3A0F315,
        TASK_WANDER_IN_VOLUME = 0x9FDA168777B28424,
        TASK_WANDER_SWIM = 0x527EA3DB8BC7F03B,
        TASK_PLANT_BOMB = 0x965FEC691D55E9BF,
        TASK_ANIMAL_INTERACTION = 0xCD181A959CFDD7F4,
        TASK_COMBAT_ANIMAL_WARN = 0xF960F3D57B660E96,
        TASK_COMBAT_ANIMAL_CHARGE_PED = 0xEE3AA414CF99F368,
        TASK_AMBIENT_ANIMAL_STALK = 0x37C13863ABA1B4A3,
        TASK_AMBIENT_ANIMAL_HUNT = 0x4B39D8F9D0FE7749,
        TASK_ANIMAL_UNALERTED = 0x21FDF9A25CFE1CE5,
        TASK_ANIMAL_ALERTED = 0x979D93372FC8C565,
        TASK_ANIMAL_FLEE = 0xA899B61C66F09134,
        TASK_EAT = 0xBD7949BD07299672,
        TASK_BARK = 0x83BFC1F836B2F3F2,
        TASK_FOLLOW_PAVEMENT_TO_COORD = 0x1B1475414E70DD8E,
        TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED = 0x17F58B88D085DBAC,
        SET_PED_PATH_CAN_USE_CLIMBOVERS = 0x8E06A6FE76C9EFF4,
        SET_PED_PATH_CAN_USE_LADDERS = 0x77A5B103C87F476E,
        SET_PED_PATH_CAN_DROP_FROM_HEIGHT = 0xE361C5C71C431A4F,
        SET_PED_PATH_CLIMB_COST_MODIFIER = 0x88E32DB8C1A4AA4B,
        SET_PED_PATH_DEEP_SNOW_COST_MODIFIER = 0xE8C296B75EACC357,
        SET_PED_PATH_FOLIAGE_COST_MODIFIER = 0x3AD8EFF9703BE657,
        SET_PED_PATH_MAY_ENTER_WATER = 0xF35425A4204367EC,
        _SET_PED_PATH_MAY_ENTER_DEEP_WATER = 0x9DE63896B176EA94,
        SET_PED_PATH_PREFER_TO_AVOID_WATER = 0x38FE1EC73743793C,
        SET_PED_PATH_AVOID_FIRE = 0x4455517B28441E60,
        TASK_GO_TO_COORD_ANY_MEANS = 0x5BC448CB78FA3E88,
        TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS = 0x1DD45F9ECFDB1BC9,
        TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED = 0xB8ECD61F531A7B02,
        TASK_PLAY_ANIM = 0xEA47FE3719165B94,
        TASK_PLAY_ANIM_ADVANCED = 0x83CDB10EA29B370B,
        TASK_PLAY_UPPER_ANIM_FACING_ENTITY = 0xAD67214236AB1CFE,
        STOP_ANIM_TASK = 0x97FF36A1D40EA00A,
        TASK_SCRIPTED_ANIMATION = 0x126EF75F1E17ABE5,
        PLAY_ENTITY_SCRIPTED_ANIM = 0x77A1EEC547E7FCF1,
        STOP_ANIM_PLAYBACK = 0xEE08C992D238C5D1,
        SET_ANIM_FILTER = 0x87B66D77D545DB66,
        SET_ANIM_RATE = 0x032D49C5E359C847,
        CAN_START_ITEM_INTERACTION = 0x2D19BC4DF626CBE7,
        _TASK_ITEM_INTERACTION = 0xAE72E7DF013AAA61,
        _TASK_ITEM_INTERACTION_2 = 0x72F52AA2D2B172CC,
        _TASK_ITEM_INTERACTION_3 = 0xD61D5E1AD9876DEB,
        _GET_ITEM_INTERACTION_FROM_PED = 0x6AA3DCA2C6F5EB6D,
        IS_PED_RUNNING_INSPECTION_TASK = 0x038B1F1674F0E242,
        IS_PED_RUNNING_TASK_ITEM_INTERACTION = 0xEC7E480FF8BD0BED,
        TASK_EVASIVE_ANIM = 0x5F22926E1BCE9B08,
        TASK_LOOK_AT_COORD = 0x6FA46612594F7973,
        TASK_CLEAR_LOOK_AT = 0x0F804F1DB19B9689,
        OPEN_SEQUENCE_TASK = 0xE8854A4326B9E12B,
        CLOSE_SEQUENCE_TASK = 0x39E72BC99E6360CB,
        TASK_PERFORM_SEQUENCE = 0x5ABA3986D90D8A3B,
        _TASK_PERFORM_SEQUENCE_2 = 0x4FC0AF869D6E309D,
        CLEAR_SEQUENCE_TASK = 0x3841422E9C488D8C,
        SET_SEQUENCE_TO_REPEAT = 0x58C70CF3A41E4AE7,
        GET_IS_TASK_ACTIVE = 0xB0760331C7AA4155,
        IS_PED_SCENARIO_REACT_LOOKING = 0x916B8E075ABC8B4E,
        GET_ACTIVE_VEHICLE_MISSION_TYPE = 0x534AEBA6E5ED4CAB,
        TASK_LEAVE_ANY_VEHICLE = 0x504D54DF3F6F2247,
        TASK_USE_RANDOM_SCENARIO_IN_GROUP = 0x14747F4A5971DE4E,
        TASK_AIM_GUN_AT_COORD = 0x6671F3EEC681BDA1,
        TASK_AIM_AT_COORD = 0x4AF1D73861212F52,
        TASK_AIM_AT_ENTITY = 0xCF7569BD0FB480A0,
        TASK_SHOOT_AT_COORD = 0x46A6CC01E0826106,
        CLEAR_PED_TASKS = 0xE1EF3C1216AFF2CD,
        CLEAR_PED_SECONDARY_TASK = 0x176CECF6F920D707,
        TASK_EVERYONE_LEAVE_VEHICLE_IN_ORDER = 0x6F1C49F275BD25B3,
        TASK_INVESTIGATE = 0x5C8514540D27FBFB,
        TASK_GOTO_ENTITY_OFFSET = 0xE39B4FF4FDEBDE27,
        TASK_GOTO_ENTITY_OFFSET_XY = 0x338E7EF52B6095A9,
        TASK_GOTO_ENTITY_OFFSET_XYZ = 0xFA6DA9D151769392,
        TASK_GOTO_ENTITY_OFFSET_XY_AIMING = 0x901BD69984400F62,
        TASK_GOTO_ENTITY_OFFSET_XYZ_AIMING = 0x41B0832CA96B5351,
        TASK_FOLLOW_ENTITY_WHILE_AIMING_AT_ENTITY = 0x2D532EAA142CF83F,
        TASK_VEHICLE_MISSION = 0x659427E0EF36BCDE,
        _TASK_VEHICLE_DRIVE_TO_DESTINATION = 0x7F241A0D14354583,
        _TASK_VEHICLE_DRIVE_TO_DESTINATION_2 = 0x391073B9D3CCE2BA,
        _TASK_VEHICLE_DRIVE_TO_POINT = 0x089FF2FB965F0A29,
        _TASK_VEHICLE_DRIVE_TO_POINT_2 = 0x6524A8981E8BE7C9,
        TASK_VEHICLE_ESCORT = 0x0FA6E4B75F302400,
        TASK_BOAT_MISSION = 0x15C86013127CE63F,
        TASK_WEAPON = 0x7157B82D60E4BC46,
        TASK_DRIVE_BY = 0x2F8AF0E82773A171,
        SET_DRIVEBY_TASK_TARGET = 0xE5B302114D8162EE,
        CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK = 0xC35B5CDB2824CF69,
        IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK = 0x8785E6E40C7A8818,
        GET_IS_PED_AIMING_IN_THE_AIR = 0x8785E6E40C7A8819,
        IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK = 0xA320EF046186FA3B,
        TASK_WARP_PED_INTO_VEHICLE = 0x9A7D091411C5F684,
        TASK_SHOOT_AT_ENTITY = 0x08DA95E8298AE772,
        TASK_SHOOT_WITH_WEAPON = 0x08AA95E8298AE772,
        _TASK_CLIMB_2 = 0xDF1D85BCAF60D537,
        TASK_CLIMB_LADDER = 0xB6C987F9285A3814,
        TASK_PERFORM_SEQUENCE_FROM_PROGRESS = 0x89221B16730234F0,
        SET_PED_DESIRED_MOVE_BLEND_RATIO = 0x1E982AC8716912C5,
        GET_PED_DESIRED_MOVE_BLEND_RATIO = 0x8517D4A6CA8513ED,
        TASK_SET_SPHERE_DEFENSIVE_AREA = 0x933C06518B52A9A4,
        TASK_CLEAR_DEFENSIVE_AREA = 0x95A6C46A31D1917D,
        TASK_PED_SLIDE_TO_COORD = 0xD04FE6765D990A06,
        ADD_COVER_POINT = 0xD5C12A75C7B9497F,
        REMOVE_COVER_POINT = 0xAE287C923D891715,
        GET_SCRIPTED_COVER_POINT_COORDS = 0x594A1028FC2A3E85,
        TASK_COMBAT_PED = 0xF166E48407BAC484,
        TASK_COMBAT_PED_TIMED = 0x944F30DCB7096BDE,
        _TASK_COMBAT_PED_3 = 0xC624414FA748B9BA,
        TASK_SEEK_COVER_FROM_POS = 0x75AC2B60386D89F2,
        TASK_SEEK_COVER_FROM_PED = 0x84D32B3BEC531324,
        TASK_SEEK_COVER_TO_COVER_POINT = 0xD43D95C7A869447F,
        TASK_SEEK_COVER_TO_COORDS = 0x39246A6958EF072C,
        TASK_PUT_PED_DIRECTLY_INTO_COVER = 0x4172393E6BE1FECE,
        TASK_COMPANION_AMBIENT = 0xE017CF6E2527FE4F,
        TASK_GUARD = 0xB9FB242EACCAF30F,
        TASK_GUARD_CURRENT_POSITION = 0x4A58A47A72E3FCB4,
        _TASK_GUARD_ASSIGNED_DEFENSIVE_AREA_2 = 0x1FC9B33976BACD6C,
        TASK_GUARD_ASSIGNED_DEFENSIVE_AREA = 0xD2A207EEBDF9889B,
        TASK_STAND_GUARD = 0xAE032F8BBA959E90,
        SET_DRIVE_TASK_CRUISE_SPEED = 0x5C9B84BD7D31D908,
        ADD_COVER_BLOCKING_AREA = 0x45C597097DD7CB81,
        REMOVE_ALL_COVER_BLOCKING_AREAS = 0xDB6708C0B46F56D8,
        TASK_ROB_PED = 0x7BB967F85D8CCBDB,
        _GET_SCENARIO_POINT_ENTITY = 0x295514F198EFD0CA,
        _SET_SCENARIO_POINT_FLAG = 0x5AF19B6CC2115D34,
        _IS_SCENARIO_POINT_FLAG_SET = 0x8569C38D2FB80650,
        DOES_SCENARIO_POINT_EXIST = 0x841475AC96E794D1,
        _GET_ENTITY_SCENARIO_POINT_IS_ATTACHED_TO = 0x7467165EE97D3C68,
        _GET_PED_USING_SCENARIO_POINT = 0x5BA659955369B0E2,
        _SET_SCENARIO_POINT_COORDS = 0x2056AB38DF06825C,
        _SET_SCENARIO_POINT_HEADING = 0xD3A0DA8F91612C6E,
        GET_SCENARIO_POINTS_IN_AREA = 0x345EC3B7EBDE1CB5,
        _GET_SCENARIO_POINT_PED_IS_USING = 0xDF7993356F52359A,
        GET_RANSACK_SCENARIO_POINT_PED_IS_USING = 0xD04241BBF6D03A5E,
        _DELETE_SCENARIO_POINT = 0x81948DFE4F5A0283,
        TASK_USE_SCENARIO_POINT = 0xCCDAE6324B6A821C,
        _TASK_USE_SCENARIO_POINT_2 = 0x0F6641449DD86FBE,
        TASK_START_SCENARIO_IN_PLACE_HASH = 0x524B54361229154F,
        _TASK_START_SCENARIO_IN_PLACE_2 = 0xA917E39F2CEFD215,
        TASK_START_SCENARIO_AT_POSITION = 0x4D1F61FC34AF3CD1,
        _TASK_USE_NEAREST_SCENARIO_TO_COORD = 0x322BFDEA666E2B0E,
        TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP = 0x58E2E0F23F6B76C3,
        TASK_USE_NEAREST_TRAIN_SCENARIO_TO_COORD_WARP = 0x3774B03456DD6106,
        TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD = 0x9FDA1B3D7E7028B3,
        TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP = 0x97A28E63F0BA5631,
        TASK_RIDE_TRAIN = 0x37FB1C870E2EC2C6,
        DOES_SCENARIO_EXIST_IN_AREA = 0x5A59271FFADD33C1,
        DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA_HASH = 0x6EEAD6AF637DA752,
        FIND_SCENARIO_OF_TYPE_HASH = 0xF533D68FF970D190,
        IS_SCENARIO_OCCUPIED = 0x788756D73AC2E07C,
        PED_HAS_USE_SCENARIO_TASK = 0x295E3CCEC879CCD7,
        PLAY_ANIM_ON_RUNNING_SCENARIO = 0x748040460F8DF5DC,
        DOES_SCENARIO_GROUP_EXIST = 0xF9034C136C9E00D3,
        _DOES_SCENARIO_GROUP_EXIST_HASH = 0x76E98B52369A289C,
        IS_SCENARIO_GROUP_ENABLED = 0x367A09DED4E05B99,
        _IS_SCENARIO_GROUP_ENABLED_HASH = 0xDCC374913DE6AAA6,
        SET_SCENARIO_GROUP_ENABLED = 0x02C8E5B49848664E,
        _SET_SCENARIO_GROUP_ENABLED_HASH = 0x9925EDDB6EAB88CD,
        RESET_SCENARIO_GROUPS_ENABLED = 0xDD902D0349AFAD3A,
        FORCE_SCENARIO_GROUP_PRIORITY = 0x444C910A5058E568,
        _IS_SCENARIO_POINT_ACTIVE = 0x0CC36D4156006509,
        _SET_SCENARIO_POINT_ACTIVE = 0xEEE4829304F93EEE,
        IS_SCENARIO_TYPE_ENABLED = 0x3A815DB3EA088722,
        SET_SCENARIO_TYPE_ENABLED = 0xEB47EC4E34FB7EE1,
        _SET_SCENARIO_TYPE_ENABLED_HASH = 0xD00E50E673802D71,
        RESET_SCENARIO_TYPES_ENABLED = 0x0D40EE2A7F2B2D6D,
        _GET_SCENARIO_POINT_TYPE_PED_IS_USING = 0x2D0571BB55879DA2,
        _GET_SCENARIO_POINT_TYPE = 0xA92450B5AE687AAF,
        IS_PED_ACTIVE_IN_SCENARIO = 0xAA135F9482C82CC3,
        IS_PED_EXITING_SCENARIO = 0x0C3CB2E600C8977D,
        TASK_COMBAT_HATED_TARGETS_NO_LOS_TEST = 0xB5BC69D9C4060BC3,
        TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED = 0x2BBA30B854534A0C,
        TASK_COMBAT_HATED_TARGETS = 0x8182B561A29BD597,
        TASK_THROW_PROJECTILE = 0x7285951DBF6B5A51,
        _TASK_THROW_PROJECTILE_2 = 0x7282356DFF6B5A51,
        TASK_WHISTLE_ANIM = 0xD6401A1B2F63BED6,
        TASK_SWAP_WEAPON = 0xA21C51255B205245,
        TASK_RELOAD_WEAPON = 0x62D2916F56B9CD2D,
        TASK_PICK_UP_WEAPON = 0x55B0ECFD98596624,
        IS_PED_GETTING_UP = 0x2A74E1D5F2F00EEC,
        TASK_ANIMAL_WRITHE = 0x8C038A39C4A4B6D6,
        _TASK_ANIMAL_BLEED_OUT = 0x30A768C30D385EC5,
        TASK_REVIVE_TARGET = 0x356088527D9EBAAD,
        OPEN_PATROL_ROUTE = 0xA36BFB5EE89F3D82,
        CLOSE_PATROL_ROUTE = 0xB043ECA801B8CBC1,
        ADD_PATROL_ROUTE_NODE = 0x8EDF950167586B7C,
        ADD_PATROL_ROUTE_LINK = 0x23083260DEC3A551,
        CREATE_PATROL_ROUTE = 0xAF8A443CCC8018DC,
        DELETE_PATROL_ROUTE = 0x7767DD9D65E91319,
        TASK_PATROL = 0xBDA5DF49D080FE4E,
        _TASK_PATROL_2 = 0x964B06C88E4C86DB,
        TASK_VEHICLE_SHOOT_AT_PED = 0x10AB107B887214D8,
        TASK_VEHICLE_AIM_AT_PED = 0xE41885592B08B097,
        TASK_VEHICLE_SHOOT_AT_COORD = 0x5190796ED39C9B6D,
        TASK_VEHICLE_AIM_AT_COORD = 0x447C1E9EF844BC0F,
        TASK_VEHICLE_GOTO_NAVMESH = 0x195AEEB13CEFE2EE,
        TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD = 0x11315AB3385B8AC0,
        TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD_USING_COMBAT_STYLE = 0x639C0425A0B4E77E,
        TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY = 0xB2A16444EAD9AE47,
        TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY_USING_COMBAT_STYLE = 0x78426D0982D083C9,
        TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY_USING_COMBAT_STYLE = 0xCEF0117C233026AD,
        TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD = 0xA55547801EB331FC,
        TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD_USING_COMBAT_STYLE = 0x87BD711FC31EA273,
        REQUEST_WAYPOINT_RECORDING = 0x9EEFB62EB27B5792,
        GET_IS_WAYPOINT_RECORDING_LOADED = 0xCB4E8BE8A0063C5D,
        REMOVE_WAYPOINT_RECORDING = 0xFF1B8B4AA1C25DC8,
        WAYPOINT_RECORDING_GET_NUM_POINTS = 0x5343532C01A07234,
        WAYPOINT_RECORDING_GET_COORD = 0x2FB897405C90B361,
        WAYPOINT_RECORDING_GET_SPEED_AT_POINT = 0x005622AEBC33ACA9,
        WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT = 0xB629A298081F876F,
        TASK_FOLLOW_WAYPOINT_RECORDING_ADVANCED = 0x0CFC13EBC19BCA52,
        TASK_FOLLOW_WAYPOINT_RECORDING = 0x0759591819534F7B,
        TASK_FOLLOW_WAYPOINT_RECORDING_AT_OFFSET = 0xBE9B0520BD7C445B,
        TASK_FOLLOW_ENTITY_ALONG_WAYPOINT_RECORDING_AT_OFFSET = 0x4D2B787BAE9AB760,
        IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED = 0xE03B3F2D3DC59B64,
        GET_PED_WAYPOINT_PROGRESS = 0x2720AAA75001E094,
        GET_PED_WAYPOINT_DISTANCE = 0xE6A877C64CAF1BC5,
        SET_PED_WAYPOINT_ROUTE_OFFSET = 0xED98E10B0AFCE4B4,
        GET_WAYPOINT_DISTANCE_ALONG_ROUTE = 0xA5B769058763E497,
        WAYPOINT_PLAYBACK_GET_IS_PAUSED = 0x701375A7D43F01CB,
        WAYPOINT_PLAYBACK_GET_IS_AIMING = 0xD73A5D1F0325C71C,
        WAYPOINT_PLAYBACK_GET_IS_SHOOTING = 0xA5B94DF8AF058F46,
        WAYPOINT_PLAYBACK_PAUSE = 0x0F342546AA06FED5,
        WAYPOINT_PLAYBACK_RESUME = 0x244F70C84C547D2D,
        WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0x7D7D2B47FA788E85,
        WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0x6599D834B12D0800,
        GET_PED_WAYPOINT_OVERRIDE_SPEED = 0xD39A2F3E7FCAFF08,
        USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE = 0x5A353B8E6B1095B5,
        WAYPOINT_PLAYBACK_START_AIMING_AT_PED = 0x20E330937C399D29,
        WAYPOINT_PLAYBACK_START_AIMING_AT_ENTITY = 0x4F158205E0C74385,
        WAYPOINT_PLAYBACK_START_AIMING_AT_COORD = 0x8968400D900ED8B3,
        WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED = 0xE70BA7B90F8390DC,
        WAYPOINT_PLAYBACK_START_SHOOTING_AT_ENTITY = 0x4AF458F71C1196D2,
        WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD = 0x057A25CFCC9DB671,
        WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING = 0x47EFA040EBB8E2EA,
        ASSISTED_MOVEMENT_REMOVE_ROUTE = 0x3548536485DD792B,
        ASSISTED_MOVEMENT_IS_ROUTE_LOADED = 0x60F9A4393A21F741,
        ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES = 0xD5002D78B7162E1B,
        SET_ENABLE_SPEED_RESTRAIN_FOR_WAYPOINT_RECORDING_LEADER = 0x295F03DC97BEEBC1,
        SET_UP_SPEED_RESTRAIN_INFORMATION_FOR_PLAYER_FOLLOWER = 0xB5C51DD544F14F58,
        TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING = 0x3123FAA6DB1CF7ED,
        _TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING_2 = 0x041D17A9E221AE30,
        IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE = 0xF5134943EA29868C,
        GET_VEHICLE_WAYPOINT_PROGRESS = 0x9824CFF8FC66E159,
        GET_VEHICLE_WAYPOINT_TARGET_POINT = 0x416B62AC8B9E5BBD,
        VEHICLE_WAYPOINT_PLAYBACK_PAUSE = 0x8A4E6AC373666BC5,
        VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED = 0x4D6D30AB18B0B089,
        VEHICLE_WAYPOINT_PLAYBACK_RESUME = 0xDC04FCAA7839D492,
        VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0x5CEB25A7D2848963,
        VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0x121F0593E0A431D7,
        GET_VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0x3DC971EB22F73447,
        TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0x90D2156198831D69,
        TASK_SET_STEALTH_MOVEMENT = 0x4C3FA937B44A90FA,
        TASK_SET_CROUCH_MOVEMENT = 0x17293C633C8AC019,
        TASK_MOVE_NETWORK_BY_NAME = 0x2D537BA194896636,
        TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS = 0x139805C2A67C4795,
        TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS = 0x7B6A04F98BBAFB2C,
        TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS_ATTACHED = 0xF92171093BCABED4,
        IS_TASK_MOVE_NETWORK_ACTIVE = 0x921CE12C489C4C41,
        IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION = 0x30ED88D5E0C56A37,
        REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION = 0xD01015C7316AE176,
        GET_TASK_MOVE_NETWORK_STATE = 0x717E4D1F2048376D,
        SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT = 0xD5BB4025AE449A4E,
        SET_TASK_MOVE_NETWORK_SIGNAL_BOOL = 0xB0A6CFD2C69C1088,
        _SET_TASK_MOVE_NETWORK_SIGNAL_VECTOR = 0x4662BFE01938D98D,
        GET_TASK_MOVE_NETWORK_EVENT = 0xB4F47213DF45A64C,
        IS_MOVE_BLEND_RATIO_STILL = 0x349CE7B56DAFD95C,
        IS_MOVE_BLEND_RATIO_WALKING = 0xF133BBBE91E1691F,
        IS_MOVE_BLEND_RATIO_RUNNING = 0xD4D8636C0199A939,
        IS_MOVE_BLEND_RATIO_SPRINTING = 0x24A2AD74FA9814E2,
        IS_PED_STILL = 0xAC29253EEF8F0180,
        IS_PED_WALKING = 0xDE4C184B2B9B071A,
        IS_PED_RUNNING = 0xC5286FFC176F28A2,
        IS_PED_SPRINTING = 0x57E457CD2C0FC168,
        IS_PED_IN_HIT_REACT = 0xF330A5C062B29BED,
        TASK_ARREST_PED = 0xF3B9A78A178572B1,
        _IS_PED_ARRESTING_ANY_PED = 0xA9CC7856D52DBD25,
        UNCUFF_PED = 0x67406F2C8F87FC4F,
        IS_PED_CUFFED = 0x74E559B3BC910685,
        _IS_PED_DUELLING = 0xC8B29D18022EA2B7,
        TASK_DUEL = 0x5D5B0D5BC3626E5A,
        GET_IS_CARRIABLE_ENTITY = 0x0CCFE72B43C9CF96,
        TASK_PLACE_CARRIED_ENTITY_AT_COORD = 0xC7F0B43DCDC57E3D,
        TASK_PLACE_CARRIED_ENTITY_ON_MOUNT = 0x6D3D87C57B3D52C7,
        TASK_DUMP_CARRIABLE_FROM_PARENT = 0x17CA98707B15926A,
        TASK_PICKUP_CARRIABLE_ENTITY = 0x502EC17B1BED4BFA,
        TASK_HOGTIE_TARGET_PED = 0x27829AFD3E03AC1A,
        _TASK_CUT_FREE_HOGTIED_TARGET_PED = 0x81D16C4FF3A77ADF,
        _TASK_CUT_FREE_HOGTIED_TARGET_PED_2 = 0x525421A507216084,
        TASK_LOOT_ENTITY = 0x48FAE038401A2888,
        TASK_BREAK_VEHICLE_DOOR_LOCK = 0xBB28D1BC9EA8A6A5,
        TASK_LOOT_NEAREST_ENTITY = 0xCF1501CBC4059412,
        TASK_LASSO_PED = 0xC716EB2BD16370A3,
        TASK_HOGTIEABLE = 0x6AFD8FE0D723328F,
        _MAKE_OBJECT_CARRIABLE = 0x78B4567E18B54480,
        MAKE_OBJECT_NOT_CARRIABLE = 0x67BFCED22909834D,
        SET_TEAM_CARRIABLE_ENTITY = 0x545BF19F86E80F11,
        IS_TEAM_CARRIABLE_ENTITY = 0x559A6F8C5133B4EE,
        SET_ENHANCED_BREAK_FREE = 0x1BF9D36A5EAFFBAE,
        _IS_PED_LEADING_HORSE = 0xEFC4303DDC6E60D3,
        _GET_LED_HORSE_FROM_PED = 0xED1F514AF4732258,
        TASK_TURN_TO_FACE_CLOSEST_PED = 0x84179419DBDD36F2,
        TASK_CONFRONT = 0x3A2A2071DF5CC569,
        TASK_POLICE = 0x87BE56724650408E,
        TASK_MELEE = 0x482C99D0B38D1B0A,
        _TASK_INTIMIDATED = 0x648B75D44930D6BD,
        _TASK_INTIMIDATED_2 = 0x933ACC1A1771A288,
        TASK_PERSISTENT_CHARACTER = 0x4391700CBD89C3D8,
        IS_EMOTE_TASK_RUNNING = 0xCF9B71C0AF824036,
        _0xFFB520A3E16F7B7B = 0xFFB520A3E16F7B7B,
        _0x8B1FDF63C3193EDA = 0x8B1FDF63C3193EDA,
        _0x28EF780BDEA8A639 = 0x28EF780BDEA8A639,
        _0xE05A5D39BE6E93AF = 0xE05A5D39BE6E93AF,
        _0x3FFCD7BBA074CC80 = 0x3FFCD7BBA074CC80,
        _0xBAAB791AA72C2821 = 0xBAAB791AA72C2821,
        _0xA052608A12559BBB = 0xA052608A12559BBB,
        _0xDE0C8B145EA466FF = 0xDE0C8B145EA466FF,
        _0xEB67D4E056C85A81 = 0xEB67D4E056C85A81,
        _0x78D8C1D4EB80C588 = 0x78D8C1D4EB80C588,
        _0x673A8779D229BA5A = 0x673A8779D229BA5A,
        _0x2E1D6D87346BB7D2 = 0x2E1D6D87346BB7D2,
        _0xE8F1A5B4CED3725A = 0xE8F1A5B4CED3725A,
        _0x3923EC958249657D = 0x3923EC958249657D,
        _0xA42DC7919159CCCF = 0xA42DC7919159CCCF,
        _0x76610D12A838EBDE = 0x76610D12A838EBDE,
        _0x244430C13BA5258E = 0x244430C13BA5258E,
        _0xE6A151364C600B24 = 0xE6A151364C600B24,
        _0x1632EB9386CDBE64 = 0x1632EB9386CDBE64,
        _0x8798CF6815B8FE0F = 0x8798CF6815B8FE0F,
        _0x5B68D0007D9C92EB = 0x5B68D0007D9C92EB,
        _0x82ED59F095056550 = 0x82ED59F095056550,
        _0xE01C8DC8EDD28D31 = 0xE01C8DC8EDD28D31,
        _0x098CAA6DBE7D8D82 = 0x098CAA6DBE7D8D82,
        _0x1948BBE561A2375A = 0x1948BBE561A2375A,
        _0x013A7BA5015C1372 = 0x013A7BA5015C1372,
        _0x70F7A1EAB1AE3AA8 = 0x70F7A1EAB1AE3AA8,
        _0xC6170856E54557B2 = 0xC6170856E54557B2,
        _0xF948F4356F010F11 = 0xF948F4356F010F11,
        _0x8BB283A7888AD1AD = 0x8BB283A7888AD1AD,
        _0x12990818C1D35886 = 0x12990818C1D35886,
        _0x7C015D8BCEC72CF4 = 0x7C015D8BCEC72CF4,
        _0x42CFD8FD8CC8DC69 = 0x42CFD8FD8CC8DC69,
        _0x216343750545A486 = 0x216343750545A486,
        _0x06ECF3925BC2ABAE = 0x06ECF3925BC2ABAE,
        _0xFA30E2254461ADEB = 0xFA30E2254461ADEB,
        _0xB35370D5353995CB = 0xB35370D5353995CB,
        _0x804425C4BBD00883 = 0x804425C4BBD00883,
        _0x05A0100EA714DB68 = 0x05A0100EA714DB68,
        _0xBC864A70AD55E0C1 = 0xBC864A70AD55E0C1,
        _0x678D3226CF70B9C8 = 0x678D3226CF70B9C8,
        _0x508F5053E3F6F0C4 = 0x508F5053E3F6F0C4,
        _0x23767D80C7EED7C6 = 0x23767D80C7EED7C6,
        _0x9FF5F9B24E870748 = 0x9FF5F9B24E870748,
        _0xA710DC5D25F8B942 = 0xA710DC5D25F8B942,
        _0xE7FA07624574B79A = 0xE7FA07624574B79A,
        _0x541E5B41DCA45828 = 0x541E5B41DCA45828,
        _0xBD70108D01875299 = 0xBD70108D01875299,
        _0x1A7D63CB1B0BB223 = 0x1A7D63CB1B0BB223,
        _0xB2D15D3551FE4FAE = 0xB2D15D3551FE4FAE,
        _0xDF94844D474F31E5 = 0xDF94844D474F31E5,
        _0xEBA2081E0A5F4D17 = 0xEBA2081E0A5F4D17,
        _0x141BC64C8D7C5529 = 0x141BC64C8D7C5529,
        _0x55CD5FDDD4335C1E = 0x55CD5FDDD4335C1E,
        _0x1D125814EBC517EB = 0x1D125814EBC517EB,
        _0x583AE9AF9CEE0958 = 0x583AE9AF9CEE0958,
        _0xA263ADBBC8056214 = 0xA263ADBBC8056214,
        _0x34C0010188D7C54A = 0x34C0010188D7C54A,
        _0x2416EC2F31F75266 = 0x2416EC2F31F75266,
        _0x41323F4E0C4AE94B = 0x41323F4E0C4AE94B,
        _0x5EA655F01D93667A = 0x5EA655F01D93667A,
        _0x9420FB11B8D77948 = 0x9420FB11B8D77948,
        _0x6BA606AB3A83BC4D = 0x6BA606AB3A83BC4D,
        _0x59872EA4CBD11C56 = 0x59872EA4CBD11C56,
        _0xE116F6F2DA2D777E = 0xE116F6F2DA2D777E,
        _0x50AA09A0DA64E73C = 0x50AA09A0DA64E73C,
        _0xE5831AA1E2FD147C = 0xE5831AA1E2FD147C,
        _0xDF8A5855B9F9A97B = 0xDF8A5855B9F9A97B,
        _0x098036CAB8373D36 = 0x098036CAB8373D36,
        _0x10C44F633E2D6D9E = 0x10C44F633E2D6D9E,
        _0x7FB78B2199C10E92 = 0x7FB78B2199C10E92,
        _0xEB2ED1DC3AEC0654 = 0xEB2ED1DC3AEC0654,
        _0x2A10538D0A005E81 = 0x2A10538D0A005E81,
        _0x4F57397388E1DFF8 = 0x4F57397388E1DFF8,
        _0xBEDBE39B5FD98FD6 = 0xBEDBE39B5FD98FD6,
        _0xEA31F199A73801D3 = 0xEA31F199A73801D3,
        _0x8360C47380B6F351 = 0x8360C47380B6F351,
        _0xADC45010BC17AF0E = 0xADC45010BC17AF0E,
        _0x974DA3408DEC4E79 = 0x974DA3408DEC4E79,
        _0x6EF4E31B4D5D2DA0 = 0x6EF4E31B4D5D2DA0,
        _0x22CD2C33ED4467A1 = 0x22CD2C33ED4467A1,
        _0x91CB5E431F579BA1 = 0x91CB5E431F579BA1,
        _0x370F57C47F68EBCA = 0x370F57C47F68EBCA,
        _0x6718F40313A2B5A6 = 0x6718F40313A2B5A6,
        _0xC47D9080A9A8856A = 0xC47D9080A9A8856A,
        _0xA7479FB665361EDB = 0xA7479FB665361EDB,
        _0xE69FDA40AAC3EFC0 = 0xE69FDA40AAC3EFC0,
        _0xEFD875C2791EBEFD = 0xEFD875C2791EBEFD,
        _0x152664AA3188B193 = 0x152664AA3188B193,
        _0xE7BBC4E56B989449 = 0xE7BBC4E56B989449,
        _0xA9E7672F8C6C6F74 = 0xA9E7672F8C6C6F74,
        _0x0A98A362C5A19A43 = 0x0A98A362C5A19A43,
        _0x849791EBBDBA0362 = 0x849791EBBDBA0362,
        _0x640A602946A8C972 = 0x640A602946A8C972,
        _0x01AF8A3729231A43 = 0x01AF8A3729231A43,
        _0xB219612B5568E9EC = 0xB219612B5568E9EC,
        _0x2E20878FD208A68E = 0x2E20878FD208A68E,
        _0x4161648394262FDF = 0x4161648394262FDF,
        _0x9C8F42A5D1859DC1 = 0x9C8F42A5D1859DC1,
        _0xF97F462779B31786 = 0xF97F462779B31786,
        _0x6C269F673C47031E = 0x6C269F673C47031E,
        _0x9667CCE29BFA0780 = 0x9667CCE29BFA0780,
        _0x00FFE0F85253C572 = 0x00FFE0F85253C572,
        _0xFDECCA06E8B81346 = 0xFDECCA06E8B81346,
        _0x2D657B10F211C572 = 0x2D657B10F211C572,
        _0x79197F7D2BB5E73A = 0x79197F7D2BB5E73A,
        _0x0D322AEF8878B8FE = 0x0D322AEF8878B8FE,
        _0xD508FA229F1C4900 = 0xD508FA229F1C4900,
        _0xB8E213D02F37947D = 0xB8E213D02F37947D,
        _0x1ACBC313966C21F3 = 0x1ACBC313966C21F3,
        _0x02EBBB3989B7E695 = 0x02EBBB3989B7E695,
        _0x90703A8F75EE4ABD = 0x90703A8F75EE4ABD,
        _0xD999E379265A4501 = 0xD999E379265A4501,
        _0x74F0209674864CBD = 0x74F0209674864CBD,
        _0xE1C105E6BBA48270 = 0xE1C105E6BBA48270,
        _0x1AC5A8AB50CFAA33 = 0x1AC5A8AB50CFAA33,
        _0xBEEFBB608D2AA68A = 0xBEEFBB608D2AA68A,
        _0x19BC99C678FBA139 = 0x19BC99C678FBA139,
        _0x5D9B0BAAF04CF65B = 0x5D9B0BAAF04CF65B,
        _0x9B6A58FDB0024F12 = 0x9B6A58FDB0024F12,
        _0xBC3F847AE2C3DC65 = 0xBC3F847AE2C3DC65,
        _0x450080DDEDB91258 = 0x450080DDEDB91258,
        _0x954451EA2D2120FB = 0x954451EA2D2120FB,
        _0x0F4F6C4CE471259D = 0x0F4F6C4CE471259D,
        _0xB8E3486D107F4194 = 0xB8E3486D107F4194,
        _0x827A58CED9D4D5B4 = 0x827A58CED9D4D5B4,
        _0x4A7D73989F52EB37 = 0x4A7D73989F52EB37,
        _0xB79817DB31FF72B9 = 0xB79817DB31FF72B9,
        _0x65D281985F2BDFC2 = 0x65D281985F2BDFC2,
        _0x885D19AC2B6FBFF4 = 0x885D19AC2B6FBFF4,
        _0x2064B33F6E6B92D4 = 0x2064B33F6E6B92D4,
        _0xCE4E669400E5F8AA = 0xCE4E669400E5F8AA,
        _0x2EB977293923C723 = 0x2EB977293923C723,
        _0xE9225354FB7437A7 = 0xE9225354FB7437A7,
        _0x764DB5A48390FBAD = 0x764DB5A48390FBAD,
        _0x8F8C84363810691A = 0x8F8C84363810691A,
        _0xFF8AFCA532B500D4 = 0xFF8AFCA532B500D4,
        _0xFE5D28B9B7837CC1 = 0xFE5D28B9B7837CC1,
        _0x2B8AF29A78024BD3 = 0x2B8AF29A78024BD3,
        _0x0365000D8BF86531 = 0x0365000D8BF86531,
        _0x865732725536EE39 = 0x865732725536EE39,
        _0x0E184495B27BB57D = 0x0E184495B27BB57D,
        _0x358A1A751B335A11 = 0x358A1A751B335A11,
        _0xE55478C5EDF70AC2 = 0xE55478C5EDF70AC2,
        _0x5A40040BB5AE3EA2 = 0x5A40040BB5AE3EA2,
        _0x2C497BDEF897C6DF = 0x2C497BDEF897C6DF,
        _0x30B391915538EBE2 = 0x30B391915538EBE2,
        _0x0000A8ACDC2E1B6A = 0x0000A8ACDC2E1B6A,
        _0x3F8387DB1B9F31B7 = 0x3F8387DB1B9F31B7,
        _0x756C7B4C43DF0422 = 0x756C7B4C43DF0422,
        _0x351F74ED6177EBE7 = 0x351F74ED6177EBE7,
        _0x6C50B9DCCCA70023 = 0x6C50B9DCCCA70023,
        _0x643FD1556F621772 = 0x643FD1556F621772,
        _0xAF2EF28CE3084505 = 0xAF2EF28CE3084505,
        _0x5217B7B6DB78E1F3 = 0x5217B7B6DB78E1F3,
        _0xF718931A82EEB898 = 0xF718931A82EEB898,
        _0x3ACC128510142B9D = 0x3ACC128510142B9D,
        _0x5C885E0978B6AD60 = 0x5C885E0978B6AD60,
        _0xE9A6400D1A0E7A55 = 0xE9A6400D1A0E7A55,
        _0x615DC4A82E90BB48 = 0x615DC4A82E90BB48,
        _0x099D4A855D53B03B = 0x099D4A855D53B03B,
        _0x844CEEE428EA35B0 = 0x844CEEE428EA35B0,
        _0x9585FF23C4B8EDE0 = 0x9585FF23C4B8EDE0,
        _0xEAF87DA2BE78A15B = 0xEAF87DA2BE78A15B,
        _0x3BBEECC5B8F35318 = 0x3BBEECC5B8F35318,
        _0x7981037A96E7D174 = 0x7981037A96E7D174,
        _0x908BB14BCE85C80E = 0x908BB14BCE85C80E,
        _0x1F7A9A9C38C13A56 = 0x1F7A9A9C38C13A56,
        _0x3FEB770D8ED9047A = 0x3FEB770D8ED9047A,
        _0x30146C25686B7836 = 0x30146C25686B7836,
        _0x59AE5CA4FFB4E378 = 0x59AE5CA4FFB4E378,
        _0x748D5E0D2A1A4C61 = 0x748D5E0D2A1A4C61,
        _0xEED08A3A98B847E2 = 0xEED08A3A98B847E2,
        _0x651F0530083C0E5A = 0x651F0530083C0E5A,
        _0x9EBD34958AB6F824 = 0x9EBD34958AB6F824,
        _0x10ADFDF07B7DFFBA = 0x10ADFDF07B7DFFBA,
        _0x36D188AECB26094B = 0x36D188AECB26094B,
        _0xE2CF104ADD49D4BF = 0xE2CF104ADD49D4BF,
        _0xAB591AE6B48B913E = 0xAB591AE6B48B913E,
        _0x4687E69D258BBE41 = 0x4687E69D258BBE41,
        _0x03D741CB4052E26C = 0x03D741CB4052E26C,
        _0x73F0D0327BFA0812 = 0x73F0D0327BFA0812,
        _0x5E5D96BE25E9DF68 = 0x5E5D96BE25E9DF68,
        _0x5758B1EE0C3FD4AC = 0x5758B1EE0C3FD4AC,
        _0x96C6ED22FB742C3E = 0x96C6ED22FB742C3E,
        _0xDF56A2B50C04DEA4 = 0xDF56A2B50C04DEA4,
        _0x722D6A49200174FE = 0x722D6A49200174FE,
        _0x8E1DDE26D270CC5E = 0x8E1DDE26D270CC5E,
        _0xA6A76D666A281F2D = 0xA6A76D666A281F2D,
        _0xA21AA2F0C2180125 = 0xA21AA2F0C2180125,
        _0xE47DD64B9F02677D = 0xE47DD64B9F02677D,
        _0xFF745B0346E19E2C = 0xFF745B0346E19E2C,
        _0xB8F52A3F84A7CC59 = 0xB8F52A3F84A7CC59,
        _0x6AFDA2264925BD11 = 0x6AFDA2264925BD11,
        _0x816A3ACD265E2297 = 0x816A3ACD265E2297,
        _0x4E806A395D43A458 = 0x4E806A395D43A458,
        _0x9ADDBB9242179D56 = 0x9ADDBB9242179D56,
        _0xAA0AF6025160243A = 0xAA0AF6025160243A,
        _0x7CB99FADDE73CD1B = 0x7CB99FADDE73CD1B,
        _0xF3C3503276F4A034 = 0xF3C3503276F4A034,
        _0x6DAC799857EF3F11 = 0x6DAC799857EF3F11,
        _0x920684BE432875B1 = 0x920684BE432875B1,
        _0x6AFD84AEAA3EA538 = 0x6AFD84AEAA3EA538,
        _0xBD1C3C0F271C39D3 = 0xBD1C3C0F271C39D3,
        _0x1ECF56C040FD839C = 0x1ECF56C040FD839C,
        _0xF40A109B4B79A848 = 0xF40A109B4B79A848,
        _0xAC5045AB7F1A34FD = 0xAC5045AB7F1A34FD,
        _0x2948235DB2058E99 = 0x2948235DB2058E99,
        _0xB2F47A1AFDFCC595 = 0xB2F47A1AFDFCC595,
        _0x41D1331AFAD5A091 = 0x41D1331AFAD5A091,
        _0x801BD27403F3CBA0 = 0x801BD27403F3CBA0,
        _0x0FE797DD9F70DFA6 = 0x0FE797DD9F70DFA6,
        _0xFC7F71CF49F70B6B = 0xFC7F71CF49F70B6B,
        _0xE01F55B2896F6B37 = 0xE01F55B2896F6B37,
        _0xE62754D09354F6CF = 0xE62754D09354F6CF,
        _0x4BA972D0E5AD8122 = 0x4BA972D0E5AD8122,
        _0x1F298C7BD30D1240 = 0x1F298C7BD30D1240,
        _0x1A52076D26E09004 = 0x1A52076D26E09004,
        _0xCE71C2F9BAA3F975 = 0xCE71C2F9BAA3F975,
        _0xB520DBDA7FCF573F = 0xB520DBDA7FCF573F,
        _0x31BB338F64D5C861 = 0x31BB338F64D5C861,
        _0x517D01BF27B682D1 = 0x517D01BF27B682D1,
        _0x88FD60D846D9CD63 = 0x88FD60D846D9CD63,
        _0x9050DF2C53801208 = 0x9050DF2C53801208,
        _0x22CDBF317C40A122 = 0x22CDBF317C40A122,
        _0x5952DFA38FA529FE = 0x5952DFA38FA529FE,
        _0x6A1AF481407BF6E9 = 0x6A1AF481407BF6E9,
        _0xBDFEEB7600BCD938 = 0xBDFEEB7600BCD938,
        _0xEC516FE805D2CB2D = 0xEC516FE805D2CB2D,
        _0x59AEA4DC640814B9 = 0x59AEA4DC640814B9,
        _0x11C7CE1AE38911B5 = 0x11C7CE1AE38911B5,
        _0xD0ABC4EA3B5E21A0 = 0xD0ABC4EA3B5E21A0,
    }
    public static class NATIVE_TASK_EXTENSIONS
    {
        public static void Call(this NATIVE_TASK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_TASK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}