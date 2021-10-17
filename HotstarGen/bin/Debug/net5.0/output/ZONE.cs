using System;
namespace Hotstar
{
    public enum NATIVE_ZONE : ulong
    { 
        /// <summary>
        /// Returns name hash, see common:/data/levels/rdr3/mapzones.meta
        /// 
        /// type (-1 matches any type):
        /// class CMapZone
        /// {
        /// public:
        /// 	enum class Type
        /// 	{
        /// 		STATE,
        /// 		TOWN,
        /// 		LAKE,
        /// 		RIVER,
        /// 		OIL_SPILL,
        /// 		SWAMP,
        /// 		OCEAN,
        /// 		CREEK,
        /// 		POND,
        /// 		GLACIER,
        /// 		DISTRICT,
        /// 		TEXT_PRINTED,
        /// 		TEXT_WRITTEN
        /// 	};
        /// };
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int type
        ///
        /// </summary>
        _GET_MAP_ZONE_AT_COORDS = 0x43AD8FC02B429D33,
        /// <summary>
        /// Returns the zone's name hash if its type matches one of the following:
        /// - LAKE
        /// - RIVER
        /// - OIL_SPILL
        /// - SWAMP
        /// - OCEAN
        /// - CREEK
        /// - POND
        /// - GLACIER
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        _GET_WATER_MAP_ZONE_AT_COORDS = 0x5BA7A68A346A5A91,
    }
    public static class NATIVE_ZONE_EXTENSIONS
    {
        public static void Call(this NATIVE_ZONE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_ZONE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}