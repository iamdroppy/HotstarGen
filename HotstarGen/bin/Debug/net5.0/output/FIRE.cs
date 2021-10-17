using System;
namespace Hotstar
{
    public enum NATIVE_FIRE : ulong
    { 
        /// <summary>
        /// Starts a fire:
        /// 
        /// xyz: Location of fire
        /// maxChildren: The max amount of times a fire can spread to other objects. Must be 25 or less, or the function will do nothing.
        /// isGasFire: Whether or not the fire is powered by gasoline.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int p3
        /// > float p4
        /// > BOOL p5
        /// > const char* soundsetName
        /// > float p7
        /// > int p8
        ///
        /// </summary>
        START_SCRIPT_FIRE = 0x6B83617E04503888,
        /// <summary>
        /// explosionType:
        /// enum eExplosionTag
        /// {
        /// 	EXP_TAG_DONTCARE = -1,
        /// 	EXP_TAG_GRENADE,
        /// 	EXP_TAG_STICKYBOMB,
        /// 	EXP_TAG_MOLOTOV,
        /// 	EXP_TAG_MOLOTOV_VOLATILE,
        /// 	EXP_TAG_HI_OCTANE,
        /// 	EXP_TAG_CAR,
        /// 	EXP_TAG_PLANE,
        /// 	EXP_TAG_PETROL_PUMP,
        /// 	EXP_TAG_DIR_STEAM,
        /// 	EXP_TAG_DIR_FLAME,
        /// 	EXP_TAG_DIR_WATER_HYDRANT,
        /// 	EXP_TAG_BOAT,
        /// 	EXP_TAG_BULLET,
        /// 	EXP_TAG_SMOKEGRENADE,
        /// 	EXP_TAG_BZGAS,
        /// 	EXP_TAG_GAS_CANISTER,
        /// 	EXP_TAG_EXTINGUISHER,
        /// 	EXP_TAG_TRAIN,
        /// 	EXP_TAG_DIR_FLAME_EXPLODE,
        /// 	EXP_TAG_VEHICLE_BULLET,
        /// 	EXP_TAG_BIRD_CRAP,
        /// 	EXP_TAG_FIREWORK,
        /// 	EXP_TAG_TORPEDO,
        /// 	EXP_TAG_TORPEDO_UNDERWATER,
        /// 	EXP_TAG_LANTERN,
        /// 	EXP_TAG_DYNAMITE,
        /// 	EXP_TAG_DYNAMITESTACK,
        /// 	EXP_TAG_DYNAMITE_VOLATILE,
        /// 	EXP_TAG_RIVER_BLAST,
        /// 	EXP_TAG_PLACED_DYNAMITE,
        /// 	EXP_TAG_FIRE_ARROW,
        /// 	EXP_TAG_DYNAMITE_ARROW,
        /// 	EXP_TAG_PHOSPHOROUS_BULLET,
        /// 	EXP_TAG_LIGHTNING_STRIKE,
        /// 	EXP_TAG_TRACKING_ARROW,
        /// 	EXP_TAG_POISON_BOTTLE
        /// };
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        ///
        /// </summary>
        ADD_EXPLOSION = 0x7D6F58F69DA92530,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        ///
        /// </summary>
        ADD_OWNED_EXPLOSION = 0xD84A917A64D4D016,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > Hash explosionFx
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        ///
        /// </summary>
        ADD_EXPLOSION_WITH_USER_VFX = 0x53BA259F3A67A99E,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_EXPLOSION_IN_AREA = 0x8391BA4313A25AD3,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_EXPLOSION_ACTIVE_IN_AREA = 0xD96E82AEBFFAAFF0,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        IS_EXPLOSION_IN_SPHERE = 0xD62DD846D82CBB90,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float angle
        ///
        /// </summary>
        IS_EXPLOSION_IN_ANGLED_AREA = 0x5AE661ECD18524C9,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > Volume volume
        ///
        /// </summary>
        _IS_EXPLOSION_IN_VOLUME = 0xE24822A4CFC9107A,
        /// <summary>
        /// explosionType: see ADD_EXPLOSION
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float radius
        ///
        /// </summary>
        _GET_ENTITY_INSIDE_EXPLOSION_AREA = 0x8002DDAB58594D78,
        REMOVE_SCRIPT_FIRE = 0x790125C36E194069,
        START_ENTITY_FIRE = 0xC4DC7418A44D6822,
        STOP_ENTITY_FIRE = 0x8390751DC40C1E98,
        IS_ENTITY_ON_FIRE = 0x1BD7C371CE257C3E,
        GET_NUMBER_OF_FIRES_IN_RANGE = 0xF9617BC6FAE61E08,
        STOP_FIRE_IN_RANGE = 0xDB38F247BD421708,
        _STOP_FIRE_IN_BOX = 0xB7C7BDC375AEA9A4,
        GET_CLOSEST_FIRE_POS = 0xB646FB657F448261,
        _IS_ENTITY_CONSUMED_BY_FIRE = 0xCDC25355C0D65963,
        _0x754937C28271BC65 = 0x754937C28271BC65,
        _0x559FC1D310813031 = 0x559FC1D310813031,
        _0x41B87A6495EE13DD = 0x41B87A6495EE13DD,
        _0xA4454592DCF7C992 = 0xA4454592DCF7C992,
        _0xB7DF150605EEDC9B = 0xB7DF150605EEDC9B,
        _0x34AE85C7CA4857AA = 0x34AE85C7CA4857AA,
        _0x68F6A75FDF5A70D6 = 0x68F6A75FDF5A70D6,
        _0x24DB6B9F2B719043 = 0x24DB6B9F2B719043,
        _0xAB7993BA61A4674F = 0xAB7993BA61A4674F,
    }
    public static class NATIVE_FIRE_EXTENSIONS
    {
        public static void Call(this NATIVE_FIRE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_FIRE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}