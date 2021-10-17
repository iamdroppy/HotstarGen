using System;
namespace Hotstar
{
    public enum NATIVE_DATAFILE : ulong
    { 
        /// <summary>
        /// Adds the given request ID to the watch list.
        ///
        /// > int id
        ///
        /// </summary>
        DATAFILE_WATCH_REQUEST_ID = 0xA5834834CA8FD7FC,
        /// <summary>
        /// Types:
        /// 1 = Boolean
        /// 2 = Integer
        /// 3 = Float
        /// 4 = String
        /// 5 = Vector3
        /// 6 = Object
        /// 7 = Array
        ///
        /// > Any* objectData
        /// > const char* key
        ///
        /// </summary>
        DATADICT_GET_TYPE = 0x92E11E3CA4C7CDF0,
        /// <summary>
        /// Types:
        /// 1 = Boolean
        /// 2 = Integer
        /// 3 = Float
        /// 4 = String
        /// 5 = Vector3
        /// 6 = Object
        /// 7 = Array
        ///
        /// > Any* arrayData
        /// > int arrayIndex
        ///
        /// </summary>
        DATAARRAY_GET_TYPE = 0x151DAFE6B3B9888F,
        /// <summary>
        /// Old name: _DATAFILE_GET_DATA_NODE_INDEX
        ///
        /// > int* p0
        /// > Any* p1
        ///
        /// </summary>
        PARSEDDATA_RQ_FILLOUT_NODE = 0x83C3ED532B6E5D07,
        /// <summary>
        /// Old name: _DATAFILE_GET_HASH
        ///
        /// > Hash* p0
        /// > Any* p1
        ///
        /// </summary>
        PARSEDDATA_RQ_FILLOUT_HASH = 0xFBFF3FF2F5E80C0B,
        /// <summary>
        /// Old name: _DATAFILE_GET_STRING
        ///
        /// > char* p0
        /// > Any* p1
        ///
        /// </summary>
        _PARSEDDATA_RQ_FILLOUT_STRING_63 = 0x08EAF8E9F2EB7B2E,
        /// <summary>
        /// Old name: _DATAFILE_GET_VECTOR
        ///
        /// > Vector3* p0
        /// > Any* p1
        ///
        /// </summary>
        _PARSEDDATA_RQ_FILLOUT_VECTOR = 0x06FBF89B12DA279C,
        /// <summary>
        /// Old name: _DATAFILE_GET_FLOAT
        ///
        /// > float* p0
        /// > Any* p1
        ///
        /// </summary>
        _PARSEDDATA_RQ_FILLOUT_FLOAT = 0x7F034FC3E891B57A,
        /// <summary>
        /// Old name: _DATAFILE_GET_INT
        ///
        /// > int* p0
        /// > Any* p1
        ///
        /// </summary>
        _PARSEDDATA_RQ_FILLOUT_INT = 0xEF44ACC657352A35,
        /// <summary>
        /// Old name: _DATAFILE_GET_BOOL
        ///
        /// > BOOL* p0
        /// > Any* p1
        ///
        /// </summary>
        _PARSEDDATA_RQ_FILLOUT_BOOL = 0x0D9138F3F8261DF7,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x3168BA5D6DECE323 = 0x3168BA5D6DECE323,
        DATAFILE_HAS_LOADED_FILE_DATA = 0x17279C820464CEE0,
        DATAFILE_HAS_VALID_FILE_DATA = 0xE60100389E50EADE,
        DATAFILE_SELECT_ACTIVE_FILE = 0x46102A0989AD80B5,
        DATAFILE_DELETE_REQUESTED_FILE = 0x604B8ED1A482F9DF,
        UGC2_SET_PLAYER_DATA = 0xE79C70E77E0973C7,
        DATAFILE_UGC_SELECT_DATA = 0x790EC421078F5C4E,
        DATAFILE_CREATE = 0x56B7291FB953DD51,
        DATAFILE_DELETE = 0x9FB90EEDEA9F2D5C,
        DATAFILE_GET_FILE_DICT = 0xBBD8CF823CAE557C,
        DATADICT_IS_DICT_VALID = 0x4607D57C5F7D332A,
        DATADICT_IS_ARRAY_VALID = 0xB04B69CF277D15C0,
        DATADICT_SET_INT = 0x26FDF5E99AA2F3E9,
        DATADICT_GET_BOOL = 0x175E915A486EE548,
        DATADICT_GET_INT = 0x9D896A3B87D96E2B,
        DATADICT_GET_FLOAT = 0x814643ECA258ADF5,
        DATADICT_GET_STRING = 0xE37B38C0B4E95DFA,
        DATADICT_GET_VECTOR = 0xE459C941431E0FFA,
        DATADICT_GET_DICT = 0x4D7A30130F46AC9C,
        DATADICT_GET_ARRAY = 0x1B5447CF18544B18,
        DATAARRAY_GET_BOOL = 0xAB1231D2DE52F2D3,
        DATAARRAY_GET_INT = 0x96DEA500B6EBBE53,
        DATAARRAY_GET_FLOAT = 0xA9D003CF419CB81E,
        DATAARRAY_GET_STRING = 0xB6790A8FF80F889F,
        DATAARRAY_GET_VECTOR = 0x850DA2750DA14E9A,
        DATAARRAY_GET_DICT = 0xA010655985853485,
        DATAARRAY_GET_COUNT = 0x6A885BF69239E539,
        _DATAFILE_UNLOAD = 0x129567F0C05F81B9,
        PARSEDDATA_IS_FILE_VALID = 0x7907969497EA92F5,
        PARSEDDATA_IS_FILE_LOADED = 0x603AC35FD4602C76,
        _DATAFILE_REGISTER_QUERY = 0xAE156A747C39A741,
        _DATAFILE_GET_NUM_NODES = 0xDF01B1F7A886B42D,
        _DATAFILE_GET_NUM_CHILDREN = 0x6BEB168D5195E7AB,
        PARSEDDATA_RQ_FILLOUT_STRING_127 = 0x951327435DC5164B,
        _0xBC0DF006A4952C68 = 0xBC0DF006A4952C68,
        _0x9F130129EBC31B34 = 0x9F130129EBC31B34,
        _0x277251C161B4C3F4 = 0x277251C161B4C3F4,
        _0x1C65CC931C0F946F = 0x1C65CC931C0F946F,
        _0x7681B677400C7071 = 0x7681B677400C7071,
        _0x4F9E3ED7617123AC = 0x4F9E3ED7617123AC,
        _0xCA56DD6AB7A39F64 = 0xCA56DD6AB7A39F64,
        _0xD97D8D905F1562F2 = 0xD97D8D905F1562F2,
        _0xE13634BB6BAF0734 = 0xE13634BB6BAF0734,
        _0x91DED5DD64BB2691 = 0x91DED5DD64BB2691,
        _0xED4413CEE1BF142C = 0xED4413CEE1BF142C,
        _0xB2B42607F7867576 = 0xB2B42607F7867576,
        _0x52FC26D2D2FC2987 = 0x52FC26D2D2FC2987,
        _0x44B3A36933AC009C = 0x44B3A36933AC009C,
        _0xA63CD20F19B961AB = 0xA63CD20F19B961AB,
    }
    public static class NATIVE_DATAFILE_EXTENSIONS
    {
        public static void Call(this NATIVE_DATAFILE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_DATAFILE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}