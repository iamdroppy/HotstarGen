using System;
namespace Hotstar
{
    public enum NATIVE_SHAPETEST : ulong
    { 
        /// <summary>
        /// Asynchronously starts a line-of-sight (raycast) world probe shape test.
        /// 
        /// Use the handle with 0x3D87450E15D98694 or 0x65287525D951F6BE until it returns 0 or 2.
        /// 
        /// p8 is a bit mask with bits 1, 2 and/or 4, relating to collider types; 4 should usually be used.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int flags
        /// > Entity entity
        /// > int p8
        ///
        /// </summary>
        START_SHAPE_TEST_LOS_PROBE = 0x7EE9F5D83DD4F90E,
        /// <summary>
        /// Does the same as 0x7EE9F5D83DD4F90E, except blocking until the shape test completes.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int flags
        /// > Entity entity
        /// > int p8
        ///
        /// </summary>
        START_EXPENSIVE_SYNCHRONOUS_SHAPE_TEST_LOS_PROBE = 0x377906D8A31E5586,
        /// <summary>
        /// Returns the result of a shape test: 0 if the handle is invalid, 1 if the shape test is still pending, or 2 if the shape test has completed, and the handle should be invalidated.
        /// 
        /// When used with an asynchronous shape test, this native should be looped until returning 0 or 2, after which the handle is invalidated.
        ///
        /// > int shapeTestHandle
        /// > BOOL* hit
        /// > Vector3* endCoords
        /// > Vector3* surfaceNormal
        /// > Entity* entityHit
        ///
        /// </summary>
        GET_SHAPE_TEST_RESULT = 0xEDE8AC7C5108FB1D,
        START_SHAPE_TEST_BOX = 0xFE466162C4401D18,
        START_SHAPE_TEST_CAPSULE = 0x28579D1B8F8AAC80,
        START_SHAPE_TEST_SWEPT_SPHERE = 0xAA5B7C8309F73230,
        _START_SHAPE_TEST_SURROUNDING_COORDS = 0x9839013D8B6014F1,
        _0x04AA59CA40571C2E = 0x04AA59CA40571C2E,
    }
    public static class NATIVE_SHAPETEST_EXTENSIONS
    {
        public static void Call(this NATIVE_SHAPETEST hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_SHAPETEST hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}