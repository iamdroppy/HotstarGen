using System;
namespace Hotstar
{
    public enum NATIVE_ENTITY : ulong
    { 
        /// <summary>
        /// Checks if the Entity exists
        ///
        /// > Entity entity
        ///
        /// </summary>
        DOES_ENTITY_EXIST = 0xD42BD6EB2E0F1677,
        /// <summary>
        /// Has the entity1 got a clear line of sight to the other entity2 from the direction entity1 is facing.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT = 0xE88F19660651D566,
        /// <summary>
        /// Gets the current coordinates for a specified entity.
        /// `entity` = The entity to get the coordinates from.
        /// `alive` = Unused by the game, potentially used by debug builds in order to assert whether or not an entity was alive.
        /// 
        /// If entity is a ped and it's in a vehicle or on a mount the coords of that entity are returned. Set 'realCoords' to true when you need the true ped coords.
        ///
        /// > Entity entity
        /// > BOOL alive
        /// > BOOL realCoords
        ///
        /// </summary>
        GET_ENTITY_COORDS = 0xA86D5F069399F44D,
        /// <summary>
        /// Gets the entity's forward vector.
        ///
        /// > Hash entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_VECTOR = 0x2412D9C05BB09B97,
        /// <summary>
        /// Gets the X-component of the entity's forward vector.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_X = 0xDB0954E9960F6457,
        /// <summary>
        /// Gets the Y-component of the entity's forward vector.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_Y = 0x9A5C073ECBDA7EE7,
        /// <summary>
        /// Returns the heading of the entity in degrees. Also know as the "Yaw" of an entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_HEADING = 0xC230DD956E2F5507,
        /// <summary>
        /// Alters entity's health by 'amount'. Can be negative (to drain health).
        /// In the scripts entity2 and weaponHash are unused (zero).
        ///
        /// > Entity entity
        /// > float amount
        /// > Entity entity2
        /// > Hash weaponHash
        ///
        /// </summary>
        _CHANGE_ENTITY_HEALTH = 0x835F131E7DC8F97A,
        /// <summary>
        /// Returns the model hash from the entity
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_MODEL = 0xDA76A9F39210D365,
        /// <summary>
        /// Returns the ped's animal type hash: https://alloc8or.re/rdr3/doc/enums/eAnimalType.txt
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_ANIMAL_TYPE = 0x964000D355219FC0,
        /// <summary>
        /// Offset values are relative to the entity.
        /// 
        /// x = left/right
        /// y = forward/backward
        /// z = up/down
        ///
        /// > Entity entity
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS = 0x1899F328B0E12848,
        /// <summary>
        /// Displays the current ROLL axis of the entity [-180.0000/180.0000+]
        /// (Sideways Roll) such as a vehicle tipped on its side
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_ROLL = 0xBF966536FA8B6879,
        /// <summary>
        /// Result is in meters per second (m/s)
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_SPEED = 0xFB6BA510A533DF81,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_OBJECT_INDEX_FROM_ENTITY_INDEX = 0x280BBE5601EAA983,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_PED_INDEX_FROM_ENTITY_INDEX = 0x0F16D042BD640EA3,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_VEHICLE_INDEX_FROM_ENTITY_INDEX = 0xDF1E5AAC561AFC59,
        /// <summary>
        /// Returns the coordinates of an entity-bone.
        ///
        /// > Entity entity
        /// > int boneIndex
        ///
        /// </summary>
        GET_WORLD_POSITION_OF_ENTITY_BONE = 0x82CFA50E34681CA5,
        /// <summary>
        /// Returns:
        /// 0 = no entity
        /// 1 = ped
        /// 2 = vehicle
        /// 3 = object
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_TYPE = 0x97F696ACA466B4E0,
        /// <summary>
        /// Checks if entity is within x/y/zSize distance of x/y/z. 
        /// 
        /// Last three are unknown ints, almost always p7 = 0, p8 = 1, p9 = 0
        ///
        /// > Entity entity
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xSize
        /// > float ySize
        /// > float zSize
        /// > BOOL p7
        /// > BOOL p8
        /// > int p9
        ///
        /// </summary>
        IS_ENTITY_AT_COORD = 0x5E58342602E94718,
        /// <summary>
        /// Checks if entity1 is within the box defined by x/y/zSize of entity2.
        /// 
        /// Last three parameters are almost alwasy p5 = 0, p6 = 1, p7 = 0
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > float xSize
        /// > float ySize
        /// > float zSize
        /// > BOOL p5
        /// > BOOL p6
        /// > int p7
        ///
        /// </summary>
        IS_ENTITY_AT_ENTITY = 0xC057F02B837A27F6,
        /// <summary>
        /// Creates a spherical cone at origin that extends to surface with the angle specified. Then returns true if the entity is inside the spherical cone
        /// 
        /// Angle is measured in degrees.
        ///
        /// > Entity entity
        /// > float originX
        /// > float originY
        /// > float originZ
        /// > float edgeX
        /// > float edgeY
        /// > float edgeZ
        /// > float angle
        /// > BOOL p8
        /// > BOOL p9
        /// > Any p10
        ///
        /// </summary>
        IS_ENTITY_IN_ANGLED_AREA = 0xD3151E53134595E5,
        /// <summary>
        /// Get how much of the entity is submerged.  1.0f is whole entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_SUBMERGED_LEVEL = 0x4A77C3F73FD9E831,
        /// <summary>
        /// enum eCarriableState
        /// {
        /// 	CARRIABLE_STATE_NONE,
        /// 	CARRIABLE_STATE_TRANSITIONING_TO_HOGTIED,
        /// 	CARRIABLE_STATE_CARRIABLE_INTRO,
        /// 	CARRIABLE_STATE_CARRIABLE,
        /// 	CARRIABLE_STATE_BEING_PICKED_UP_FROM_GROUND,
        /// 	CARRIABLE_STATE_CARRIED_BY_HUMAN,
        /// 	CARRIABLE_STATE_BEING_PLACED_ON_GROUND,
        /// 	CARRIABLE_STATE_CARRIED_BY_MOUNT,
        /// 	CARRIABLE_STATE_BEING_PLACED_ON_MOUNT,
        /// 	CARRIABLE_STATE_BEING_PICKED_UP_FROM_MOUNT,
        /// 	CARRIABLE_STATE_BEING_CUT_FREE,
        /// 	CARRIABLE_STATE_BEING_PLACED_ON_GROUND_ESCAPE,
        /// 	CARRIABLE_STATE_BEING_PLACED_IN_VEHICLE
        /// };
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_CARRIABLE_ENTITY_STATE = 0x61914209C36EFDDB,
        /// <summary>
        /// Valid indices: 0 - 3
        /// Index 1 always returns a `hogtied` config, doesn't matter the entity.
        /// It's for humans only and the ped must be resurrected first if it's dead.
        ///
        /// > Entity entity
        /// > int index
        ///
        /// </summary>
        _GET_OPTIMAL_CARRY_CONFIG = 0x34F008A7E48C496B,
        /// <summary>
        /// Returns zero if the entity is not a carriable
        ///
        /// > Entity entity
        ///
        /// </summary>
        _GET_ENTITY_CARRY_CONFIG = 0x0FD25587BB306C86,
        /// <summary>
        /// flagId: see _SET_ENTITY_CARRYING_FLAG
        ///
        /// > Entity entity
        /// > int flagId
        ///
        /// </summary>
        _GET_ENTITY_CARRYING_FLAG = 0x808077647856DE62,
        /// <summary>
        /// flagId:
        /// enum eCarryingFlag
        /// {
        /// 	CARRYING_FLAG_CAN_BE_CUT_FREE = 1,
        /// 	CARRYING_FLAG_CAN_BE_CARRIED_ON_FOOT = 2,
        /// 	CARRYING_FLAG_CAN_BE_DROPPED = 4,
        /// 	CARRYING_FLAG_CAN_BE_CARRIED_WHEN_DEAD = 7,
        /// 	CARRYING_FLAG_CAN_CARRY_ANYTHING = 9,
        /// 	CARRYING_FLAG_DISABLE_PROMPT_LOS_CHECKS = 19,
        /// 	CARRYING_FLAG_FORCE_ALLOW_WARP_TO_SAFE_GROUND_LOCATION = 23,
        /// 	CARRYING_FLAG_PICKUPS_IGNORE_HEIGHT_RESTRICTIONS = 26,
        /// 	CARRYING_FLAG_CLEAN_UP_WHEN_NOT_CARRIED = 27,
        /// 	CARRYING_FLAG_BLOCK_KNOCK_OFF_PED_VARIATIONS_FROM_CARRIABLE_INTERACTIONS = 29,
        /// 	CARRYING_FLAG_HIT_WHEN_CARRIABLE = 31,
        /// 	CARRYING_FLAG_DISABLE_CARRIABLE_INTERACTIONS_ON_THIS_MOUNT = 34,
        /// 	CARRYING_FLAG_FORCE_HIDE_PROMPT_GROUP = 37,
        /// };
        ///
        /// > Entity entity
        /// > int flagId
        /// > BOOL value
        ///
        /// </summary>
        _SET_ENTITY_CARRYING_FLAG = 0x18FF3110CF47115D,
        /// <summary>
        /// p6/relative - makes the xyz force not relative to world coords, but to something else
        /// p7/highForce - setting false will make the force really low
        ///
        /// > Entity entity
        /// > int forceType
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p5
        /// > BOOL isDirectionRel
        /// > BOOL isForceRel
        /// > BOOL p8
        ///
        /// </summary>
        APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS = 0x31DA7CEC5334DB37,
        /// <summary>
        /// Attaches entity1 to bone (boneIndex) of entity2.
        /// 
        /// boneIndex - this is different to boneID, use GET_PED_BONE_INDEX to get the index from the ID. use the index for attaching to specific bones. entity1 will be attached to entity2's centre if bone index given doesn't correspond to bone indexes for that entity type.
        /// 
        /// useSoftPinning - if set to false attached entity will not detach when fixed
        /// collision - controls collision between the two entities (FALSE disables collision).
        /// isPed - pitch doesnt work when false and roll will only work on negative numbers (only peds)
        /// vertexIndex - position of vertex
        /// fixedRot - if false it ignores entity vector 
        /// 
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > int boneIndex
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > BOOL p9
        /// > BOOL useSoftPinning
        /// > BOOL collision
        /// > BOOL isPed
        /// > int vertexIndex
        /// > BOOL fixedRot
        /// > BOOL p15
        /// > BOOL p16
        ///
        /// </summary>
        ATTACH_ENTITY_TO_ENTITY = 0x6B9BBD38AB0796DF,
        /// <summary>
        /// Deletes the specified entity, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Entity* entity
        ///
        /// </summary>
        DELETE_ENTITY = 0x4CD38C78BD19A497,
        /// <summary>
        /// Must be called from a background script, otherwise it will do nothing.
        ///
        /// > Entity* entity
        ///
        /// </summary>
        _DELETE_ENTITY_2 = 0x5E94EA09E7207C16,
        /// <summary>
        /// Getter for FREEZE_ENTITY_POSITION
        ///
        /// > Entity entity
        ///
        /// </summary>
        _IS_ENTITY_FROZEN = 0x083D497D57B7400F,
        /// <summary>
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ENTITY_CLEANUP_BY_ENGINE = 0x740CB4F3F602C9F4,
        /// <summary>
        /// Makes the specified entity (ped, vehicle or object) persistent. Persistent entities will not automatically be removed by the engine.
        ///
        /// > Entity entity
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_ENTITY_AS_MISSION_ENTITY = 0xDC19C288082E586E,
        /// <summary>
        /// Marks the specified entity (ped, vehicle or object) as no longer needed.
        /// Entities marked as no longer needed, will be deleted as the engine sees fit.
        ///
        /// > Entity* entity
        ///
        /// </summary>
        SET_ENTITY_AS_NO_LONGER_NEEDED = 0x4971D2F8162B9674,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Ped* ped
        ///
        /// </summary>
        SET_PED_AS_NO_LONGER_NEEDED = 0x2595DD4236549CE3,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Vehicle* vehicle
        ///
        /// </summary>
        SET_VEHICLE_AS_NO_LONGER_NEEDED = 0x629BFA74418D6239,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Object* object
        ///
        /// </summary>
        SET_OBJECT_AS_NO_LONGER_NEEDED = 0x3AE22DEB5BA5A3E6,
        /// <summary>
        /// Sets whether the entity can be targeted without being in line-of-sight.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS = 0x6D09F32E284D0FB7,
        /// <summary>
        /// Axis - Invert Axis Flags
        ///
        /// > Entity entity
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        SET_ENTITY_COORDS_NO_OFFSET = 0x239A3351AC1DA385,
        /// <summary>
        /// Sets the entity's health. healthAmount sets the health value to that, and sets the maximum health core value. Setting healthAmount to 0 will kill the entity. Unclear what role p2 serves, but it's either 0 or an entity handle.
        ///
        /// > Entity entity
        /// > int healthAmount
        /// > Entity p2
        ///
        /// </summary>
        SET_ENTITY_HEALTH = 0xAC2767ED8BDFAB15,
        /// <summary>
        /// Sets a ped or an object totally invincible. It doesn't take any kind of damage. Peds will not ragdoll on explosions.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENTITY_INVINCIBLE = 0xA5C38736C426FCB8,
        /// <summary>
        /// Note: this native was removed in 1232 but added back in 1311
        ///
        /// > Entity entity
        ///
        /// </summary>
        _GET_ENTITY_PROOFS = 0x6CF0DAD7FA1088EA,
        /// <summary>
        /// Note that the third parameter(denoted as z) is "up and down" with positive numbers encouraging upwards movement.
        ///
        /// > Entity entity
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        SET_ENTITY_VELOCITY = 0x1C99BB7B6E96D16F,
        /// <summary>
        /// LOD distance can be 0 to 0xFFFF (higher values will result in 0xFFFF) as it is actually stored as a 16-bit value (aka uint16_t).
        ///
        /// > Entity entity
        /// > int value
        ///
        /// </summary>
        SET_ENTITY_LOD_DIST = 0x5FB407F0A7C877BF,
        /// <summary>
        /// Returns the LOD distance of an entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_LOD_DIST = 0xDF240D0C2A948683,
        /// <summary>
        /// skin - everything alpha except skin
        /// Set entity alpha level. Ranging from 0 to 255 but chnages occur after every 20 percent (after every 51).
        ///
        /// > Entity entity
        /// > int alphaLevel
        /// > BOOL skin
        ///
        /// </summary>
        SET_ENTITY_ALPHA = 0x0DF7692B1D9E7BA7,
        /// <summary>
        /// Only works with objects!
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash originalModel
        /// > Hash newModel
        /// > BOOL p6
        ///
        /// </summary>
        CREATE_MODEL_SWAP = 0x10B2218320B6F5AC,
        /// <summary>
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ENTITY_DECALS_DISABLED = 0xC64E597783BE9A1D,
        /// <summary>
        /// SET_ENTITY_R*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0x850C940EE3E7B8B5 = 0x850C940EE3E7B8B5,
        /// <summary>
        /// SET_ENTITY_LO*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0xFF9965C47FA404DA = 0xFF9965C47FA404DA,
        /// <summary>
        /// Returns false if entity is not a ped or object.
        ///
        /// > Entity entity
        /// > Hash p1
        ///
        /// </summary>
        _0x8C03CD6B5E0E85E8 = 0x8C03CD6B5E0E85E8,
        /// <summary>
        /// SET_ENTITY_A*
        ///
        /// > Entity entity
        /// > float p1
        ///
        /// </summary>
        _0xC0EDEF16D90661EE = 0xC0EDEF16D90661EE,
        /// <summary>
        /// SET_ENTITY_LO*
        ///
        /// > Entity entity
        /// > float p1
        /// > float p2
        /// > float p3
        ///
        /// </summary>
        _0xAF7F3099B9FEB535 = 0xAF7F3099B9FEB535,
        /// <summary>
        /// Most likely the getter for 0x4B436BAC8CBE9B07.
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0xE12F56CB25D9CE23 = 0xE12F56CB25D9CE23,
        /// <summary>
        /// Hardcoded to return zero/false.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        _0xDF8E49EA89A01DB1 = 0xDF8E49EA89A01DB1,
        DOES_ENTITY_BELONG_TO_THIS_SCRIPT = 0x622B1980CBE13332,
        DOES_ENTITY_HAVE_DRAWABLE = 0x20487F0DA9AF164A,
        DOES_ENTITY_HAVE_PHYSICS = 0xA512B3F1B2A0B51C,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT = 0x73BB763880CD23A6,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED = 0x9934E9C42D52D87E,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE = 0x695D7C26DE65C423,
        HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY = 0x7B6E7BEC1143AC86,
        HAS_ENTITY_CLEAR_LOS_TO_ENTITY = 0xFCDFF7B72D23A1AC,
        HAS_ENTITY_CLEAR_LOS_TO_COORD = 0x0C9DBF48C6BA6E4C,
        HAS_ENTITY_COLLIDED_WITH_ANYTHING = 0xDF18751EC74F90FF,
        GET_ANIM_DURATION = 0x9FFAF4940A54CC09,
        GET_ENTITY_ATTACHED_TO = 0x56D713888A566481,
        GET_ENTITY_HEALTH = 0x82368787EA73C0F7,
        _GET_ENTITY_HEALTH_FLOAT = 0x96C638784DB4C815,
        GET_ENTITY_MAX_HEALTH = 0x15D757606D170C3C,
        SET_ENTITY_MAX_HEALTH = 0x166E7CF68597D8B5,
        GET_ENTITY_HEIGHT = 0x296DEBC84474B375,
        GET_ENTITY_HEIGHT_ABOVE_GROUND = 0x0D3B5BAEA08F63E9,
        GET_ENTITY_MATRIX = 0x3A9B1120AF13FBF2,
        GET_IS_ANIMAL = 0x9A100F1CF4546629,
        _GET_IS_BIRD = 0xC346A546612C49A9,
        _GET_IS_PREDATOR = 0x5594AFE9DE0C01B7,
        GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS = 0x497C6B1A2C9AE69C,
        GET_ENTITY_PITCH = 0xEF355ABEFF7F5005,
        GET_ENTITY_ROTATION = 0xE09CAF86C32CB48F,
        _GET_ENTITY_SCRIPT = 0x2A08A32B6D49906F,
        GET_ENTITY_SPEED_VECTOR = 0xF2DB09816A419DC5,
        GET_ENTITY_UPRIGHT_VALUE = 0x56398BE65160C3BE,
        GET_ENTITY_VELOCITY = 0x4805D2B1D8CF94A9,
        GET_NEAREST_PLAYER_TO_ENTITY = 0x990E294FC387FB88,
        GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM = 0xB2C30C3B4AFF718C,
        _GET_NEAREST_PARTICIPANT_TO_ENTITY = 0x6888A43C35A5F630,
        PLACE_ENTITY_ON_GROUND_PROPERLY = 0x9587913B9E772D29,
        GET_ENTITY_POPULATION_TYPE = 0xADE28862B6D7B85B,
        IS_AN_ENTITY = 0x27CFF3E5A286D3DF,
        IS_ENTITY_A_PED = 0xCF8176912DDA4EA5,
        IS_ENTITY_A_MISSION_ENTITY = 0x138190F64DB4BBD1,
        IS_ENTITY_A_VEHICLE = 0xC3D96AF45FCCEC4C,
        IS_ENTITY_AN_OBJECT = 0x0A27A546A375FDEF,
        IS_ENTITY_ATTACHED = 0xEE6AD63ABF59C0B7,
        IS_ENTITY_ATTACHED_TO_ANY_OBJECT = 0x306C1F6178F01AB3,
        IS_ENTITY_ATTACHED_TO_ANY_PED = 0xC841153DED2CA89A,
        IS_ENTITY_ATTACHED_TO_ANY_VEHICLE = 0x12DF6E0D2E736749,
        IS_ENTITY_ATTACHED_TO_ENTITY = 0x154A3C529497053E,
        _IS_ENTITY_OWNED_BY_PERSISTENCE_SYSTEM = 0xA7E51B53309EAC97,
        IS_ENTITY_DEAD = 0x7D5B1F88E7504BBA,
        IS_ENTITY_IN_AIR = 0x886E37EC497200B6,
        IS_ENTITY_IN_AREA = 0x0C2634C40A16193E,
        IS_ENTITY_IN_VOLUME = 0x5A5526BC09C06623,
        IS_ENTITY_IN_WATER = 0xDDE5C125AC446723,
        _IS_ENTITY_UNDERWATER = 0xD4E5C1E93C466127,
        IS_ENTITY_ON_SCREEN = 0x613C15D5D8DB781F,
        IS_ENTITY_PLAYING_ANIM = 0xDEE49D5CA6C49148,
        IS_ENTITY_STATIC = 0x86468ADFA0F6B861,
        IS_ENTITY_TOUCHING_ENTITY = 0x9A2304A64C3C8423,
        IS_ENTITY_TOUCHING_MODEL = 0x2AE3EBC8DEB9768B,
        IS_ENTITY_UPRIGHT = 0xF6F6AFD8D4FB2658,
        IS_ENTITY_UPSIDEDOWN = 0x109DE3DA41AAD94A,
        IS_ENTITY_VISIBLE = 0xFFC96ECB7FA404CA,
        IS_ENTITY_VISIBLE_TO_SCRIPT = 0xF213C724E77F321A,
        IS_ENTITY_OCCLUDED = 0x140188E884645624,
        WOULD_ENTITY_BE_OCCLUDED = 0x3546FAB293FF2981,
        IS_ENTITY_WAITING_FOR_WORLD_COLLISION = 0x5E1CC2E8DC3111DD,
        _IS_ENTITY_ON_TRAIN_TRACK = 0x857ACB0AB4BD0D55,
        _DELETE_CARRIABLE = 0x0D0DB2B6AF19A987,
        _IS_ENTITY_FULLY_LOOTED = 0x8DE41E9902E85756,
        _GET_IS_CARRIABLE_PELT = 0x255B6DB4E3AD3C3E,
        _SET_ENTITY_CUSTOM_PICKUP_RADIUS = 0x482D17E45665DA44,
        APPLY_FORCE_TO_ENTITY = 0xF15E8F5D333F09C4,
        ATTACH_ENTITY_TO_ENTITY_PHYSICALLY = 0xB629A43CA1643481,
        GET_ENTITY_BONE_INDEX_BY_NAME = 0xBACA8FE9C76C124E,
        CLEAR_ENTITY_LAST_DAMAGE_ENTITY = 0xBB19AC7D4DCEFD0F,
        DETACH_ENTITY = 0x64CDE9D6BF8ECAD3,
        FREEZE_ENTITY_POSITION = 0x7D9EFB7AD6B19754,
        SET_ENTITY_CAN_BE_DAMAGED = 0x0D06D522B90E861F,
        _GET_ENTITY_CAN_BE_DAMAGED = 0x75DF9E73F2F005FD,
        SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP = 0x0EF1AFB18649E015,
        GET_ENTITY_COLLISION_DISABLED = 0xAA2FADD30F45A9DA,
        SET_ENTITY_COLLISION = 0xF66F820909453B8C,
        SET_ENTITY_COMPLETELY_DISABLE_COLLISION = 0xE0580EC84813875A,
        SET_ENTITY_COORDS = 0x06843DA7060A026B,
        SET_ENTITY_DYNAMIC = 0xFBFC4473F66CE344,
        SET_ENTITY_HEADING = 0xCF2B9C0645C4651B,
        _SET_ENTITY_COORDS_AND_HEADING = 0x203BEFFDBE12E96A,
        _SET_ENTITY_COORDS_AND_HEADING_NO_OFFSET = 0x0918E3565C20F03C,
        SET_ENTITY_IS_TARGET_PRIORITY = 0x0A5D170C44CB2189,
        SET_ENTITY_LOAD_COLLISION_FLAG = 0x9B9EE31AED48072E,
        HAS_COLLISION_LOADED_AROUND_ENTITY = 0xBEB1600952B9CF5C,
        SET_ENTITY_ONLY_DAMAGED_BY_PLAYER = 0x473598683095D430,
        SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP = 0x6C1F6AA2F0ADD104,
        SET_ENTITY_PROOFS = 0xFAEE099C6F890BB8,
        SET_ENTITY_QUATERNION = 0x100E7007D13E3687,
        SET_ENTITY_ROTATION = 0x9CC8314DFEDE441E,
        SET_ENTITY_VISIBLE = 0x1794B4FCC84D812F,
        SET_ENTITY_HAS_GRAVITY = 0x0CEDB728A1083FA7,
        GET_ENTITY_ALPHA = 0x1BB501624FAF2BEA,
        RESET_ENTITY_ALPHA = 0x744B9EF44779D9AB,
        _SET_ENTITY_FADE_IN = 0xA91E6CF94404E8C9,
        SET_ENTITY_ALWAYS_PRERENDER = 0xACAD101E1FB66689,
        SET_ENTITY_RENDER_SCORCHED = 0x85B8A7534E44BC23,
        REMOVE_MODEL_SWAP = 0x824E1C26A14CB817,
        CREATE_MODEL_HIDE = 0x069848B3FB3C4426,
        CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS = 0xD136090A9AAAB17D,
        REMOVE_MODEL_HIDE = 0x3F38A98576F6213A,
        CREATE_FORCED_OBJECT = 0x0961A905AFBC34C7,
        REMOVE_FORCED_OBJECT = 0x553FA683F2BCD814,
        SET_ENTITY_NO_COLLISION_ENTITY = 0xE037BF068223C38D,
        SET_ENTITY_MOTION_BLUR = 0x516C6ABD18322B63,
        SET_CAN_AUTO_VAULT_ON_ENTITY = 0x80646744FA88F9D7,
        SET_CAN_CLIMB_ON_ENTITY = 0x24AED2A608F93C4C,
        GET_MATCHING_ENTITIES = 0x84CCF9A12942C83D,
        _SEARCH_BUILDING_POOL_FOR_ENTITY_WITH_THIS_MODEL = 0x66B2B83B94B22458,
        FIND_ANIM_EVENT_PHASE = 0x42718CC559BD7776,
        FORCE_ENTITY_AI_AND_ANIMATION_UPDATE = 0x4C9E96473D4F1A88,
        _GET_ENTITY_ANIM_CURRENT_TIME = 0x627520389E288A73,
        HAS_ANIM_EVENT_FIRED = 0x5851CC48405F4A07,
        HAS_ENTITY_ANIM_FINISHED = 0xAEB40615337EF1E3,
        PLAY_ENTITY_ANIM = 0xDC6D22FAB76D4874,
        _SET_ENTITY_ANIM_CURRENT_TIME = 0x11CDABDC7783B2BC,
        _SET_ENTITY_ANIM_SPEED = 0xEAA885BA3CEA4E4A,
        STOP_ENTITY_ANIM = 0x786591D986DE9159,
        PIN_CLOSEST_MAP_ENTITY = 0x6F3068258A499E52,
        _UNPIN_MAP_ENTITY = 0xD2B9C78537ED5759,
        IS_MAP_ENTITY_PINNED = 0x1FF441D7954F8709,
        _0x3EC28DA1FFAC9DDD = 0x3EC28DA1FFAC9DDD,
        _0xAF72EC7E1B54539B = 0xAF72EC7E1B54539B,
        _0x6D58167F62238284 = 0x6D58167F62238284,
        _0xDFC2B226D56D85F6 = 0xDFC2B226D56D85F6,
        _0x935A30AA88FB1014 = 0x935A30AA88FB1014,
        _0xF3FDA9A617A15145 = 0xF3FDA9A617A15145,
        _0x5E214112806591EA = 0x5E214112806591EA,
        _0x3AB3A77672F6473F = 0x3AB3A77672F6473F,
        _0x7A49D40DE437BC8D = 0x7A49D40DE437BC8D,
        _0x978AA2323ED32209 = 0x978AA2323ED32209,
        _0x002AAC783ED323ED = 0x002AAC783ED323ED,
        _0x007AAC783ED323ED = 0x007AAC783ED323ED,
        _0x0B7CB1300CBFE19C = 0x0B7CB1300CBFE19C,
        _0x3F08C6163A4AB1D6 = 0x3F08C6163A4AB1D6,
        _0x0DB41D59E0F1502B = 0x0DB41D59E0F1502B,
        _0xC8CCDB712FBCBA92 = 0xC8CCDB712FBCBA92,
        _0xCDB682BB47C02F0A = 0xCDB682BB47C02F0A,
        _0xE19035EB65AB2932 = 0xE19035EB65AB2932,
        _0x1E804EA9B12030A4 = 0x1E804EA9B12030A4,
        _0xA88E215CEB0435C0 = 0xA88E215CEB0435C0,
        _0xE31FC20319874CB3 = 0xE31FC20319874CB3,
        _0x582F73ACFE969571 = 0x582F73ACFE969571,
        _0xBA2A089E60ED1163 = 0xBA2A089E60ED1163,
        _0xD46BF94C4C66FAB0 = 0xD46BF94C4C66FAB0,
        _0xD21C7418C590BB40 = 0xD21C7418C590BB40,
        _0x5AFFA9DDC87846F8 = 0x5AFFA9DDC87846F8,
        _0x31FEF6A20F00B963 = 0x31FEF6A20F00B963,
        _0x399657ED871B3A6C = 0x399657ED871B3A6C,
        _0x2A77EF9BEC8518F4 = 0x2A77EF9BEC8518F4,
        _0x6BCF5F3D8FFE988D = 0x6BCF5F3D8FFE988D,
        _0xEF2D9ED7CE684F08 = 0xEF2D9ED7CE684F08,
        _0x0CCEFC6C2C95DA2A = 0x0CCEFC6C2C95DA2A,
        _0x383F64263F946E45 = 0x383F64263F946E45,
        _0x8E10DF0FFA63FB65 = 0x8E10DF0FFA63FB65,
        _0xC3ABCFBC7D74AFA5 = 0xC3ABCFBC7D74AFA5,
        _0x371D179701D9C082 = 0x371D179701D9C082,
        _0xA48E4801DEBDF7E4 = 0xA48E4801DEBDF7E4,
        _0xF59FDE7B4D31A630 = 0xF59FDE7B4D31A630,
        _0x120376C23F019C6C = 0x120376C23F019C6C,
        _0x5744562E973E33CD = 0x5744562E973E33CD,
        _0xDD03FC2089AD093C = 0xDD03FC2089AD093C,
        _0xB16C780C51E51E2B = 0xB16C780C51E51E2B,
        _0xEF259AA1E097E0AD = 0xEF259AA1E097E0AD,
        _0xBD94CECFB2D65119 = 0xBD94CECFB2D65119,
        _0xE75EEA8DB59A9F39 = 0xE75EEA8DB59A9F39,
        _0x188736456D1DEDE6 = 0x188736456D1DEDE6,
        _0xC6A1A3D63F122DE7 = 0xC6A1A3D63F122DE7,
        _0x445D7D8EA66E373E = 0x445D7D8EA66E373E,
        _0x16908E859C3AB698 = 0x16908E859C3AB698,
        _0x20FAEE47427A4497 = 0x20FAEE47427A4497,
        _0x88AD6CC10D8D35B2 = 0x88AD6CC10D8D35B2,
        _0x56E0735D6273B227 = 0x56E0735D6273B227,
        _0x0FD7D7C232876E72 = 0x0FD7D7C232876E72,
        _0x0939E773925C4719 = 0x0939E773925C4719,
        _0xFF83AF534156B399 = 0xFF83AF534156B399,
        _0xB38A29CCD5447783 = 0xB38A29CCD5447783,
        _0x4B436BAC8CBE9B07 = 0x4B436BAC8CBE9B07,
        _0x2D40BCBFE9305DEA = 0x2D40BCBFE9305DEA,
        _0xEBDC12861D079ABA = 0xEBDC12861D079ABA,
        _0x6BFBDC46139C45AB = 0x6BFBDC46139C45AB,
        _0xD45BB89B53FC0CFD = 0xD45BB89B53FC0CFD,
        _0x80FDEB3A9E9AA578 = 0x80FDEB3A9E9AA578,
        _0x9C6906EF8CB20C5F = 0x9C6906EF8CB20C5F,
        _0x37B01666BAE8F7EF = 0x37B01666BAE8F7EF,
        _0xA9E6D8F2DDFC4DB9 = 0xA9E6D8F2DDFC4DB9,
        _0xD4636C2EDB0DEA8A = 0xD4636C2EDB0DEA8A,
        _0x59B57C4B06531E1E = 0x59B57C4B06531E1E,
        _0x886171A12F400B89 = 0x886171A12F400B89,
        _0xC2E71D7E0A7B4C89 = 0xC2E71D7E0A7B4C89,
        _0x6C31B06E91518269 = 0x6C31B06E91518269,
        _0x119A5714578F4E05 = 0x119A5714578F4E05,
        _0xF7424890E4A094C0 = 0xF7424890E4A094C0,
        _0x8E46E18AA828334F = 0x8E46E18AA828334F,
        _0x669655FFB29EF1A9 = 0x669655FFB29EF1A9,
        _0x1AD922AB5038DEF3 = 0x1AD922AB5038DEF3,
        _0x5826EFD6D73C4DE5 = 0x5826EFD6D73C4DE5,
        _0x36EB4D34D4A092C5 = 0x36EB4D34D4A092C5,
        _0x29BA9F78321E5A6C = 0x29BA9F78321E5A6C,
        _0xC76E94A78127412B = 0xC76E94A78127412B,
        _0x7F20092547B4DDEA = 0x7F20092547B4DDEA,
        _0xF41E2979D5BC5370 = 0xF41E2979D5BC5370,
        _0xAAACB74442C1BED3 = 0xAAACB74442C1BED3,
        _0x4735E2A4BB83D9DA = 0x4735E2A4BB83D9DA,
        _0xEAB3D91D30A344F1 = 0xEAB3D91D30A344F1,
        _0x37CEB637BA3B1A47 = 0x37CEB637BA3B1A47,
        _0x350E9211074955AF = 0x350E9211074955AF,
        _0x898586729DB5221D = 0x898586729DB5221D,
        _0xE9E7A0BAC7F57746 = 0xE9E7A0BAC7F57746,
    }
    public static class NATIVE_ENTITY_EXTENSIONS
    {
        public static void Call(this NATIVE_ENTITY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_ENTITY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}