using System;
namespace Hotstar
{
    public enum NATIVE_PATHFIND : ulong
    { 
        /// <summary>
        /// Returns true if the id is non zero.
        ///
        /// > int vehicleNodeId
        ///
        /// </summary>
        IS_VEHICLE_NODE_ID_VALID = 0x5829A02AF4F0B3CB,
        /// <summary>
        /// Gets a value indicating whether the specified position is on a road.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_POINT_ON_ROAD = 0x125BF4ABFC536B09,
        /// <summary>
        /// Returns whether navmesh for the region is loaded.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_NAVMESH_LOADED_IN_AREA = 0xF813C7E63F9062A5,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_IGNORE_NO_GPS_FLAG = 0x72751156E7678833,
        SET_ROADS_IN_AREA = 0xBF1A602B5BA52FEE,
        SET_ROADS_IN_ANGLED_AREA = 0x1A5AA1208AF5DB59,
        SET_ROADS_IN_VOLUME = 0xC1799FAFD2FDF52B,
        RESET_ROADS_IN_VOLUME = 0xD17672447692478E,
        SET_ROADS_BACK_TO_ORIGINAL = 0x1EE7063B80FFC77C,
        SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA = 0x0027501B9F3B407E,
        GET_CLOSEST_VEHICLE_NODE = 0x240A18690AE96513,
        GET_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0x23CFFD4CCB243354,
        GET_NTH_CLOSEST_VEHICLE_NODE = 0x5A6D8DF6FBC5D0C4,
        GET_NTH_CLOSEST_VEHICLE_NODE_ID = 0x116443008E5CEFC3,
        GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0x591B40D4390DB54A,
        GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING = 0x4114EAA8A7F7766D,
        GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION = 0x2FAC235A6062F14A,
        GET_VEHICLE_NODE_POSITION = 0x8E8D72FF24DEE1FB,
        GET_VEHICLE_NODE_IS_SWITCHED_OFF = 0x28533DBDDF7C2C97,
        GET_CLOSEST_ROAD = 0x132F52BBA570FE92,
        ARE_NODES_LOADED_FOR_AREA = 0xF7B79A50B905A30D,
        _REQUEST_PATHS_PREFER_ACCURATE_BOUNDINGSTRUCT = 0x07FB139B592FA687,
        GET_RANDOM_VEHICLE_NODE = 0x93E0DB8440B73A7D,
        SET_PED_PATHS_IN_AREA = 0x34F060F4BF92E018,
        GET_SAFE_COORD_FOR_PED = 0xB61C8E878A4199CA,
        SET_PED_PATHS_BACK_TO_ORIGINAL = 0xE04B48F2CC926253,
        ADD_NAVMESH_REQUIRED_REGION = 0x387EAD7EE42F6685,
        _NAVMESH_ACTIVATE_SWAP = 0x7C334FF4D9215912,
        _NAVMESH_DEACTIVATE_SWAP = 0x527B97C203BB8606,
        _NAVMESH_IS_SWAP_ACTIVE = 0x5AC0944C156E5F44,
        _NAVMESH_DOES_SWAP_EXIST = 0x495CFAB2924237C7,
        _NAVMESH_ASSIGN_NAVMESH_TO_VEHICLE = 0x44026E3DB3CED602,
        ADD_NAVMESH_BLOCKING_OBJECT = 0xFCD5C8E06E502F5A,
        REMOVE_NAVMESH_BLOCKING_OBJECT = 0x46399A7895957C0E,
        DOES_NAVMESH_BLOCKING_OBJECT_EXIST = 0x0EAEB0DB4B132399,
        _ADD_NAVMESH_BLOCKING_VOLUME = 0x19C7567D2F2287D6,
        _REMOVE_NAVMESH_BLOCKING_VOLUME = 0x2C87C3E1C7B96EE2,
        _DOES_NAVMESH_BLOCKING_VOLUME_EXIST = 0xDE0EA444735C1368,
        NAVMESH_REQUEST_PATH = 0x348F211CA2404039,
        _GET_HEIGHTMAP_BOTTOM_Z_FOR_POSITION = 0x336511A34F2E5185,
        SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME = 0x0B919E1FB47CC4E0,
        GET_GPS_BLIP_ROUTE_LENGTH = 0xBBB45C3CF5C8AA85,
        GET_GPS_BLIP_ROUTE_FOUND = 0x869DAACBBE9FA006,
        SIMULATED_ROUTE_IS_LOADED = 0x240915043CB799D7,
        SIMULATED_ROUTE_TRAVEL_TO_POINT = 0xA1A3DE1C215C7394,
        SIMULATED_ROUTE_GET_ETA = 0x2DD5F78D73B24172,
        _0xAFE2AE66F6251C66 = 0xAFE2AE66F6251C66,
        _0x4358BCF14C91761C = 0x4358BCF14C91761C,
        _0xB03944057FD735BA = 0xB03944057FD735BA,
        _0x6C3F12ECEB6D2E2A = 0x6C3F12ECEB6D2E2A,
        _0x5A4E1A41E3A02AD0 = 0x5A4E1A41E3A02AD0,
        _0xCA27A86CAA4E98ED = 0xCA27A86CAA4E98ED,
        _0xA3791B915B8B84C6 = 0xA3791B915B8B84C6,
        _0xE5EF9DE716FF737E = 0xE5EF9DE716FF737E,
        _0xCF213A5FC3ABFC08 = 0xCF213A5FC3ABFC08,
        _0x01708E8DD3FF8C65 = 0x01708E8DD3FF8C65,
        _0x5A3B54ADDF5472A3 = 0x5A3B54ADDF5472A3,
        _0xA33914B00CA55756 = 0xA33914B00CA55756,
        _0x6DAD6630AE4A74CB = 0x6DAD6630AE4A74CB,
        _0x661BB1E1FF77742D = 0x661BB1E1FF77742D,
        _0x3A0F82F6EE2291C8 = 0x3A0F82F6EE2291C8,
        _0x8800776E410EB669 = 0x8800776E410EB669,
        _0xF61CFEDEAB627BFA = 0xF61CFEDEAB627BFA,
        _0xD470725E0703D22F = 0xD470725E0703D22F,
        _0x430F8319AE56C8A9 = 0x430F8319AE56C8A9,
        _0xEFC535C9FAF563B3 = 0xEFC535C9FAF563B3,
        _0x665B21666351CB37 = 0x665B21666351CB37,
        _0x54F4D7B6670FBB5A = 0x54F4D7B6670FBB5A,
        _0x34C9AF25649172D0 = 0x34C9AF25649172D0,
        _0xF2A2177AC848B3A8 = 0xF2A2177AC848B3A8,
        _0x4BDEBEA5702B97A9 = 0x4BDEBEA5702B97A9,
        _0x264E9A5CD78C338F = 0x264E9A5CD78C338F,
        _0x869A7015BD4606E9 = 0x869A7015BD4606E9,
        _0xFD5BB35AAB83FD48 = 0xFD5BB35AAB83FD48,
        _0x4907D0E4FB26EE65 = 0x4907D0E4FB26EE65,
        _0x65A8196B8D7F5E0B = 0x65A8196B8D7F5E0B,
    }
    public static class NATIVE_PATHFIND_EXTENSIONS
    {
        public static void Call(this NATIVE_PATHFIND hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PATHFIND hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}