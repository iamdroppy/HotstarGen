using System;
namespace Hotstar
{
    public enum NATIVE_PROPSET : ulong
    { 
        /// <summary>
        /// Same as _REQUEST_PROP_SET
        ///
        /// > Hash hash
        ///
        /// </summary>
        _REQUEST_PROP_SET_2 = 0xE72F591958F3ACAB,
        /// <summary>
        /// Same as _HAS_PROP_SET_LOADED
        ///
        /// > Hash hash
        ///
        /// </summary>
        _HAS_PROP_SET_LOADED_2 = 0xD090ABEF4D6A7D96,
        /// <summary>
        /// Same as _CREATE_PROP_SET
        ///
        /// > Hash hash
        /// > float x
        /// > float y
        /// > float z
        /// > int p4
        /// > float p5
        /// > float p6
        /// > BOOL p7
        /// > BOOL p8
        ///
        /// </summary>
        _CREATE_PROP_SET_2 = 0x899C97A1CCE7D483,
        /// <summary>
        /// Same as CREATE_PROP_SET_INSTANCE_ATTACHED_TO_ENTITY
        ///
        /// > Hash hash
        /// > float x
        /// > float y
        /// > float z
        /// > Entity entity
        /// > float p5
        /// > BOOL p6
        /// > int p7
        /// > BOOL p8
        ///
        /// </summary>
        _CREATE_PROP_SET_4 = 0xACA7FB30269096D4,
        /// <summary>
        /// Some light propsets hashes: 1475377277, 280720199
        ///
        /// > Vehicle vehicle
        /// > Hash lightPropset
        ///
        /// </summary>
        _ADD_LIGHT_PROP_SET_TO_VEHICLE = 0xC0F0417A90402742,
        _REQUEST_PROP_SET = 0xF3DE57A46D5585E9,
        _HAS_PROP_SET_LOADED = 0x48A88FC684C55FDC,
        _SET_PROP_SET_AS_NO_LONGER_NEEDED = 0x909E3C7FAE539FB1,
        _DELETE_PROP_SET = 0x58AC173A55D9D7B4,
        _RELEASE_PROP_SET = 0xB1964A83B345B4AB,
        _CREATE_PROP_SET = 0xE65C5CBA95F0E510,
        CREATE_PROP_SET_INSTANCE_ATTACHED_TO_ENTITY = 0x9609DBDDE18FAD8C,
        DOES_PROP_SET_EXIST = 0x7DDDCF815E650FF5,
        _DOES_PROP_SET_OF_TYPE_EXIST_NEAR_COORDS = 0x72068021F498E6E3,
        IS_PROP_SET_FULLY_LOADED = 0xF42DB680A8B2A4D9,
        _SET_PROP_SET_VISIBLE = 0x9D096A5BD02F953E,
        _IS_PROP_SET_VISIBLE = 0x0CE8AAFE9E433A23,
        _GET_PROP_SET_MODEL = 0xA6A9712955F53D9C,
        _GET_VEHICLE_PROP_SET_HASH = 0x36F69E7A22655653,
        _GET_ENTITIES_FROM_PROP_SET = 0x738271B660FE0695,
        _GET_VEHICLE_PROP_SET = 0xCE2ACD6F602803E5,
        _DOES_VEHICLE_HAVE_ANY_PROP_SET = 0x53784CEA0159439B,
        _REMOVE_VEHICLE_PROP_SETS = 0x3BCF32FF37EA9F1D,
        _GET_VEHICLE_LIGHT_PROP_SET = 0xA079300AF757FB1A,
        _DOES_VEHICLE_HAVE_ANY_LIGHT_PROP_SET = 0xC9B4B3A36F81FD75,
        _REMOVE_VEHICLE_LIGHT_PROP_SETS = 0xE31C0CB1C3186D40,
        _GET_PROP_SET_AT_COORDS = 0xC061E50F8D299F95,
        _0xC4B67EF3FD65622D = 0xC4B67EF3FD65622D,
        _0x58E0B01D45CA7357 = 0x58E0B01D45CA7357,
        _0xC1AB7EEFD3E6EE49 = 0xC1AB7EEFD3E6EE49,
        _0xD80FAF919A2E56EA = 0xD80FAF919A2E56EA,
        _0x155B2FBE72D7D1D0 = 0x155B2FBE72D7D1D0,
        _0x75F90E4051CC084C = 0x75F90E4051CC084C,
        _0x7264F9CA87A9830B = 0x7264F9CA87A9830B,
        _0x0790473EEE1977D3 = 0x0790473EEE1977D3,
        _0xCFC0BD09BB1B73FF = 0xCFC0BD09BB1B73FF,
        _0x8F3333F0A6900B3C = 0x8F3333F0A6900B3C,
    }
    public static class NATIVE_PROPSET_EXTENSIONS
    {
        public static void Call(this NATIVE_PROPSET hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PROPSET hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}