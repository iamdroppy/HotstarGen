using System;
namespace Hotstar
{
    public enum NATIVE_MAP : ulong
    { 
        /// <summary>
        /// Returns the Blip handle of given Entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_BLIP_FROM_ENTITY = 0x6D2C41A8BD6D6FD0,
        /// <summary>
        /// Removes any existing modifiers and sets the style.
        ///
        /// > Blip blip
        /// > Hash styleHash
        ///
        /// </summary>
        _BLIP_SET_STYLE = 0xEDD964B7984AC291,
        /// <summary>
        /// https://alloc8or.re/rdr3/doc/enums/eBlipModifier.txt
        /// 
        /// Old name: _BLIP_SET_MODIFIER
        ///
        /// > Blip blip
        /// > Hash modifierHash
        ///
        /// </summary>
        BLIP_ADD_MODIFIER = 0x662D364ABF16DE2F,
        /// <summary>
        /// If modifierHash is 0, ALL modifiers will be removed.
        ///
        /// > Blip blip
        /// > Hash modifierHash
        ///
        /// </summary>
        BLIP_REMOVE_MODIFIER = 0xB059D7BD3D78C16F,
        /// <summary>
        /// Example:
        /// const char* playerString = VAR_STRING(10, "PLAYER_STRING", GET_PLAYER_NAME(PLAYER_ID()));
        /// _SET_BLIP_NAME_FROM_PLAYER_STRING(blip, playerString);
        ///
        /// > Blip blip
        /// > const char* playerString
        ///
        /// </summary>
        _SET_BLIP_NAME_FROM_PLAYER_STRING = 0x9CB1A1623062F402,
        /// <summary>
        /// Doesn't actually return anything.
        ///
        ///
        /// </summary>
        FORCE_SONAR_BLIPS_THIS_FRAME = 0xEE1C7BA69BB74B08,
        /// <summary>
        /// Clears the GPS flags.
        ///
        ///
        /// </summary>
        CLEAR_GPS_FLAGS = 0x4D3771237C79FF41,
        /// <summary>
        /// Does the same as SET_GPS_MULTI_ROUTE_RENDER(false);
        ///
        ///
        /// </summary>
        CLEAR_GPS_MULTI_ROUTE = 0x9E0AB9AAEE87CE28,
        /// <summary>
        /// If Minimap / Radar should be displayed.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        DISPLAY_RADAR = 0x1B3DA717B9AFF828,
        /// <summary>
        /// Reveals the entire minimap (FOW = Fog of War)
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MINIMAP_HIDE_FOW = 0x4B8F743A4A6D2FF8,
        /// <summary>
        /// Locks the minimap to the specified angle in integer degrees.
        /// 
        /// angle: The angle in whole degrees. If less than 0 or greater than 360, unlocks the angle.
        ///
        /// > int angle
        ///
        /// </summary>
        LOCK_MINIMAP_ANGLE = 0x0BFD145EF819FB3A,
        /// <summary>
        /// Example:
        /// local regionHash = GetHashKey('REGION_ROA_ANNESBURG')
        /// local styleHash = GetHashKey('BLIP_STYLE_WANTED_REGION')
        /// 
        /// _MAP_ENABLE_REGION_BLIP(regionHash, styleHash)
        ///
        /// > Hash regionHash
        /// > Hash styleHash
        ///
        /// </summary>
        _MAP_ENABLE_REGION_BLIP = 0x563FCB6620523917,
        /// <summary>
        /// hash can be the hash of "guarma" or "world".
        ///
        /// > Hash zone
        ///
        /// </summary>
        _0xA657EC9DBC6CC900 = 0xA657EC9DBC6CC900,
        GET_MAIN_PLAYER_BLIP_ID = 0x5CD2889B2B381D45,
        BLIP_ADD_FOR_COORDS = 0x554D9D53F696D002,
        BLIP_ADD_FOR_ENTITY = 0x23F74C2FDA6E7C61,
        BLIP_ADD_FOR_PICKUP_PLACEMENT = 0xA486008892065FB9,
        BLIP_ADD_FOR_RADIUS = 0x45F13B7E0A15C880,
        _BLIP_ADD_FOR_AREA = 0xEC174ADBCB611ECC,
        _BLIP_ADD_FOR_VOLUME = 0xA6EF0C54A3443E70,
        SET_BLIP_FLASH_TIMER = 0x02FF4CF43B7209D1,
        SET_BLIP_FLASHES = 0x0DF2B55F717DDB10,
        TRIGGER_SONAR_BLIP = 0x72DD432F3CDFC0EE,
        _TRIGGER_SONAR_BLIP_2 = 0x0C7A2289A5C4D7C9,
        ALLOW_SONAR_BLIPS = 0x6E6E64788C07D2E0,
        SET_BLIP_COORDS = 0x4FF674F5E23D49CE,
        GET_BLIP_COORDS = 0x201C319797BDA603,
        SET_BLIP_SPRITE = 0x74F74D3207ED525C,
        SET_BLIP_NAME_FROM_TEXT_FILE = 0x0A062D6D7C0B2C2C,
        SET_BLIP_NAME_TO_PLAYER_NAME = 0x093DD5A31BC2B459,
        SET_BLIP_ROTATION = 0x6049966A94FBE706,
        SET_BLIP_SCALE = 0xD38744167B2FA257,
        REMOVE_BLIP = 0xF2C3C9DA47AAA54A,
        DOES_BLIP_EXIST = 0xCD82FA174080B3B1,
        _DOES_ENTITY_HAVE_BLIP = 0x9FA00E2FC134A9D0,
        SET_RADAR_ZOOM = 0xCAF6489DA2C8DD9E,
        _IS_BLIP_ATTACHED_TO_ANY_ENTITY = 0xE9F676788F8D5E1E,
        IS_BLIP_ON_MINIMAP = 0x46534526B9CD2D17,
        SET_GPS_FLAGS = 0x5DE61C90DDECFA2D,
        SET_GPS_CUSTOM_ROUTE_RENDER = 0xF6CEF599FC470B33,
        CLEAR_GPS_CUSTOM_ROUTE = 0x1EAA5674B4D181C5,
        START_GPS_MULTI_ROUTE = 0x3D3D15AF7BCAAF83,
        ADD_POINT_TO_GPS_MULTI_ROUTE = 0x64C59DD6834FA942,
        SET_GPS_MULTI_ROUTE_RENDER = 0x4426D65E029A4DC0,
        _START_GPS_CUSTOM_ROUTE_FROM_WAYPOINT_RECORDING_ROUTE = 0x6B44F13D888F770D,
        CLEAR_GPS_PLAYER_WAYPOINT = 0x08FDC6F796E350D1,
        SET_WAYPOINT_OFF = 0xFA8C41E8020D3439,
        IS_WAYPOINT_ACTIVE = 0x202B1BBFC6AB5EE4,
        _GET_WAYPOINT_COORDS = 0x29B30D07C3F7873B,
        _HIDE_ACTIVE_POINTS_OF_INTEREST = 0xA1B4052C2A3DCC1E,
        _SHOW_ACTIVE_POINTS_OF_INTEREST = 0x3FBB838AEA30C1D8,
        _FIND_CLOSEST_GPS_POSITION = 0x3FDA2B79AEEE351C,
        SET_RADAR_AS_EXTERIOR_THIS_FRAME = 0xA8EBBAE986FB5457,
        _SET_FOW_UPDATE_PLAYER_OVERRIDE = 0x63E7279D04160477,
        _SET_MINIMAP_FOW_OVERRIDE_REVEAL_SCALE = 0xE5A7F70B7C0F3271,
        _SET_MINIMAP_FOW_SHOULD_UPDATE = 0x632AA10BF7EA53D3,
        SET_MINIMAP_FOW_REVEAL_COORDINATE = 0x73348402566ECB6E,
        SET_MINIMAP_FOW_REVEAL_VOLUME = 0x63CBBD6CA6F321F9,
        RESET_MINIMAP_FOW = 0xEB3CB3386C775D72,
        _REVEAL_MINIMAP_FOW = 0xF8096DF9B87246E3,
        UNLOCK_MINIMAP_ANGLE = 0x5373DE8E179BC2A0,
        _MAP_DISABLE_REGION_BLIP = 0x6786D7AFAC3162B3,
        _MAP_IS_REGION_HIGHLIGHTED_WITH_STYLE = 0xE38450DBCBC70E3D,
        _MAP_DISCOVERY_SET_ENABLED = 0xDA98246C7A3C2189,
        _MAP_IS_DISCOVERY_ACTIVE = 0x3F81EA4275D39D6F,
        _SET_PAUSEMAP_COORDS_WITH_RADIUS = 0xE0884C184728C75B,
        _0x3E593DF9C2962EC6 = 0x3E593DF9C2962EC6,
        _0xBD62D98799A3DAF0 = 0xBD62D98799A3DAF0,
        _0x250C75EB1728CC0D = 0x250C75EB1728CC0D,
        _0x01B928CA2E198B01 = 0x01B928CA2E198B01,
        _0xDEEDE7C41742E011 = 0xDEEDE7C41742E011,
        _0xD3F58E9316B7FC2A = 0xD3F58E9316B7FC2A,
        _0xF08E42BFA46BDFF8 = 0xF08E42BFA46BDFF8,
        _0xF47A1EB2A538A3A3 = 0xF47A1EB2A538A3A3,
        _0x9C113883487FD53C = 0x9C113883487FD53C,
        _0x1392105DA88BBFFB = 0x1392105DA88BBFFB,
        _0xE057FEA9A22EB3EE = 0xE057FEA9A22EB3EE,
        _0xD8C7162AB2E2AF45 = 0xD8C7162AB2E2AF45,
        _0x7C9F4CDF402CA82A = 0x7C9F4CDF402CA82A,
        _0x44813684F72B563C = 0x44813684F72B563C,
        _0x97F6F158CC5B5CA2 = 0x97F6F158CC5B5CA2,
        _0xBB68D4D3CA3DE402 = 0xBB68D4D3CA3DE402,
        _0x3CB8859F04763C78 = 0x3CB8859F04763C78,
        _0x7563CBCA99253D1A = 0x7563CBCA99253D1A,
        _0x1726963E6049DB53 = 0x1726963E6049DB53,
    }
    public static class NATIVE_MAP_EXTENSIONS
    {
        public static void Call(this NATIVE_MAP hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_MAP hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}