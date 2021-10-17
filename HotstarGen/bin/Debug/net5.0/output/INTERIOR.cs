using System;
namespace Hotstar
{
    public enum NATIVE_INTERIOR : ulong
    { 
        /// <summary>
        /// Gets the room hash key from the room that the specified entity is in. Each room in every interior has a unique key. Returns 0 if the entity is outside.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ROOM_KEY_FROM_ENTITY = 0x076E46E0EB52AFC6,
        /// <summary>
        /// Seems to do the exact same as INTERIOR::GET_ROOM_KEY_FROM_ENTITY
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_KEY_FOR_ENTITY_IN_ROOM = 0x27D7B6F79E1F4603,
        /// <summary>
        /// Returns the handle of the interior that the entity is in. Returns 0 if outside.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_INTERIOR_FROM_ENTITY = 0xB417689857646F61,
        /// <summary>
        /// Does something similar to INTERIOR::DISABLE_INTERIOR.
        /// 
        /// You don't fall through the floor but everything is invisible inside and looks the same as when INTERIOR::DISABLE_INTERIOR is used. Peds behaves normally inside. 
        ///
        /// > Interior interior
        ///
        /// </summary>
        UNPIN_INTERIOR = 0x07FD1A0B814F6055,
        /// <summary>
        /// Hashed version of GET_INTERIOR_AT_COORDS_WITH_TYPE
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Hash typeHash
        ///
        /// </summary>
        GET_INTERIOR_AT_COORDS_WITH_TYPEHASH = 0x3543AEA1816D1D2B,
        /// <summary>
        /// Returns true if the collision at the specified coords is marked as being outside (false if there's an interior)
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        IS_COLLISION_MARKED_OUTSIDE = 0xF291396B517E25B2,
        IS_VALID_INTERIOR = 0x017C1B3159F79F6C,
        _GET_INTERIOR_INFO = 0x8451E87D3C2B0286,
        _GET_INTERIOR_MINIMAP_HASH = 0x3039BE60B3749716,
        _GET_INTERIOR_POSITION = 0x2C9746D0CA15BE1C,
        IS_INTERIOR_SCENE = 0x4200F14D6F840A9A,
        CLEAR_ROOM_FOR_ENTITY = 0xA1762D5BBFCA13A8,
        FORCE_ROOM_FOR_ENTITY = 0xBC29A9894C976945,
        FORCE_ROOM_FOR_GAME_VIEWPORT = 0x115B4AA8FB28AB43,
        CLEAR_ROOM_FOR_GAME_VIEWPORT = 0x951A049765E0D450,
        _GET_INTERIOR_FROM_GAME_VIEWPORT = 0xBC8A281FF125C655,
        GET_INTERIOR_AT_COORDS = 0xCDD36C9E5C469070,
        PIN_INTERIOR_IN_MEMORY = 0xBD3D33EABF680168,
        IS_INTERIOR_READY = 0x941560D2D45DBFC8,
        GET_INTERIOR_AT_COORDS_WITH_TYPE = 0xAAD6170AA33B13C0,
        GET_INTERIOR_FROM_COLLISION = 0x5054D1A5218FA696,
        ACTIVATE_INTERIOR_ENTITY_SET = 0x174D0AAB11CED739,
        DEACTIVATE_INTERIOR_ENTITY_SET = 0x33B81A2C07A51FFF,
        IS_INTERIOR_ENTITY_SET_ACTIVE = 0x32810CA2125F5842,
        _IS_INTERIOR_ENTITY_SET_VALID = 0xD56FF170710FC826,
        DISABLE_INTERIOR = 0x3C2B92A1A07D4FCE,
        _0x5BD616735F16BF5C = 0x5BD616735F16BF5C,
        _0xB5EF6FEF2DC9EBED = 0xB5EF6FEF2DC9EBED,
        _0x2533F2AB0EB9C6F9 = 0x2533F2AB0EB9C6F9,
        _0xFE2B3D5500B1B2E4 = 0xFE2B3D5500B1B2E4,
    }
    public static class NATIVE_INTERIOR_EXTENSIONS
    {
        public static void Call(this NATIVE_INTERIOR hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_INTERIOR hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}