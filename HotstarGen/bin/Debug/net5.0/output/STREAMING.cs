using System;
namespace Hotstar
{
    public enum NATIVE_STREAMING : ulong
    { 
        /// <summary>
        /// Request a model to be loaded into memory.
        ///
        /// > Hash model
        /// > BOOL p1
        ///
        /// </summary>
        REQUEST_MODEL = 0xFA28FE3A6246FC30,
        /// <summary>
        /// Checks if the specified model has loaded into memory.
        ///
        /// > Hash model
        ///
        /// </summary>
        HAS_MODEL_LOADED = 0x1283B8B89DD5D1B6,
        /// <summary>
        /// Marks the model as no longer needed.
        ///
        /// > Hash model
        ///
        /// </summary>
        SET_MODEL_AS_NO_LONGER_NEEDED = 0x4AD96EF928BD4F9A,
        /// <summary>
        /// Returns whether the specified model exists in the game.
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_IN_CDIMAGE = 0xD6F3B6D7716CFF8E,
        /// <summary>
        /// Returns whether the specified model is valid
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_VALID = 0x392C8D8E07B70EFC,
        /// <summary>
        /// Returns whether the specified model represents a vehicle.
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_A_VEHICLE = 0x354F62672DE7DB0A,
        /// <summary>
        /// Alias for HAS_ANIM_SET_LOADED.
        ///
        /// > const char* clipSet
        ///
        /// </summary>
        HAS_CLIP_SET_LOADED = 0x1F23D6B6DA1CC3B2,
        /// <summary>
        /// Alias for REMOVE_ANIM_SET.
        ///
        /// > const char* clipSet
        ///
        /// </summary>
        REMOVE_CLIP_SET = 0x817FA1B1EE7CD6F0,
        /// <summary>
        /// Old name: _REQUEST_IMAP
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        REQUEST_IPL_HASH = 0x59767C5A7A9AE6DA,
        /// <summary>
        /// Old name: _REQUEST_IMAP_2
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        REQUEST_IPL_BY_HASH = 0x9E211A378F95C97C,
        /// <summary>
        /// Old name: _REMOVE_IMAP
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        REMOVE_IPL_HASH = 0x5A3E5CF7B4014B96,
        /// <summary>
        /// Old name: _REMOVE_IMAP_2
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        REMOVE_IPL_BY_HASH = 0x431E3AB760629B34,
        /// <summary>
        /// Old name: _IS_IMAP_ACTIVE
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        IS_IPL_ACTIVE_HASH = 0xD779B9B910BD3B7C,
        /// <summary>
        /// Old name: _IS_IMAP_ACTIVE_2
        ///
        /// > Hash imapHash
        ///
        /// </summary>
        IS_IPL_ACTIVE_BY_HASH = 0x93AC1B91CB6D9913,
        /// <summary>
        /// It seems to make the entity's coords mark the point from which LOD-distances are measured. In my testing, setting a vehicle as the focus entity and moving that vehicle more than 300 distance units away from the player will make the level of detail around the player go down drastically (shadows disappear, textures go extremely low res, etc). The player seems to be the default focus entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        SET_FOCUS_ENTITY = 0x955AEDD58F4BD309,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x19ABCC581D28E6F9 = 0x19ABCC581D28E6F9,
        /// <summary>
        /// Sorts some unknown data.
        /// 
        /// Likely SORT_*
        ///
        ///
        /// </summary>
        _0xB9B9E47EDB9D63DB = 0xB9B9E47EDB9D63DB,
        IS_MODEL_A_PED = 0xC3F09DE9D6D17DDA,
        _IS_MODEL_AN_OBJECT = 0x274EE1B90CFA669E,
        _HAS_COLLISION_LOADED_AT_COORD = 0xDA8B2EAF29E872E2,
        REQUEST_COLLISION_AT_COORD = 0x0A3720F162A033C9,
        REQUEST_COLLISION_FOR_MODEL = 0xF1767BE37F661551,
        HAS_COLLISION_FOR_MODEL_LOADED = 0x210A79C9EC89778F,
        REQUEST_ADDITIONAL_COLLISION_AT_COORD = 0x83A8D71650D1894F,
        DOES_ANIM_DICT_EXIST = 0x537F44CB0D7F150D,
        REQUEST_ANIM_DICT = 0xA862A2AD321F94B4,
        HAS_ANIM_DICT_LOADED = 0x27FF6FE8009B40CA,
        REMOVE_ANIM_DICT = 0x4763145053A33D46,
        REQUEST_MOVE_NETWORK_DEF = 0x2B6529C54D29037A,
        HAS_MOVE_NETWORK_DEF_LOADED = 0x2C04D89A0FB4E244,
        REMOVE_MOVE_NETWORK_DEF = 0x57A197AD83F66BBF,
        REQUEST_CLIP_SET = 0xEF7611B57A820126,
        _REQUEST_CLIP_SET_BY_HASH = 0xAC37644A538F7524,
        _REQUEST_SCENARIO_TYPE = 0x19A6BE7D9C6884D3,
        _HAS_SCENARIO_TYPE_LOADED = 0x9427C94D2E4094A4,
        _GET_IMAP_POSITION_AND_HEADING = 0x9C77964B0E07B633,
        _IS_POSITION_INSIDE_IMAP_STREAMING_EXTENTS = 0x73B40D97D7BAAD77,
        SET_GAME_PAUSES_FOR_STREAMING = 0xB3BC8250F4FE8B63,
        GET_NUMBER_OF_STREAMING_REQUESTS = 0x30CCCC4D88E654CA,
        REQUEST_PTFX_ASSET = 0x001FF43843028E0C,
        HAS_PTFX_ASSET_LOADED = 0x13A3F30A9ED0BC31,
        REMOVE_PTFX_ASSET = 0x042F9049EA419E86,
        REQUEST_NAMED_PTFX_ASSET = 0xF2B2353BBC0D4E8F,
        HAS_NAMED_PTFX_ASSET_LOADED = 0x65BB72F29138F5D6,
        REMOVE_NAMED_PTFX_ASSET = 0xF20866829E1C81A2,
        SET_POPULATION_BUDGET_MULTIPLIER = 0x2F9AC754FE179D58,
        GET_POPULATION_BUDGET_MULTIPLIER = 0x8A3945405B31048F,
        CLEAR_FOCUS = 0x86CCAF7CE493EFBE,
        SET_FOCUS_POS_AND_VEL = 0x25F6EF88664540E2,
        IS_ENTITY_FOCUS = 0xF87DE697E9A06EC6,
        SET_MAPDATACULLBOX_ENABLED = 0x3CACC83F6FED837C,
        LOAD_SCENE_START = 0x387AD749E3B69B70,
        LOAD_SCENE_START_SPHERE = 0x513F8AA5BF2F17CF,
        LOAD_SCENE_STOP = 0x5A8B01199C3E79C3,
        IS_LOAD_SCENE_ACTIVE = 0xCF45DF50C7775F2A,
        IS_LOAD_SCENE_LOADED = 0x0909F71B5C070797,
        IS_RENDERED_SCENE_LOADED = 0x45BF3A6239A576B7,
        IS_PLAYER_SWITCH_IN_PROGRESS = 0xED20CB1F5297791D,
        PREFETCH_SRL = 0x354837E5A5BAA5AF,
        IS_SRL_LOADED = 0x5C2C88512CF6DAFB,
        BEGIN_SRL = 0x0360710033BE60D9,
        END_SRL = 0x1CE71FB33CA079FE,
        SET_SRL_TIME = 0x18231AEF458BCFF2,
        SET_HD_AREA = 0xB88B905AFA35CB4D,
        CLEAR_HD_AREA = 0xD83B22434E52728D,
        _SET_GUARMA_WORLDHORIZON_ACTIVE = 0x74E2261D2A66849A,
        _0x80B3E0597366ADF1 = 0x80B3E0597366ADF1,
        _0xA8432A14D4DC2101 = 0xA8432A14D4DC2101,
        _0x03DDBF2D73799F9E = 0x03DDBF2D73799F9E,
        _0x85B8F04555AB49B8 = 0x85B8F04555AB49B8,
        _0x9F348DE670423460 = 0x9F348DE670423460,
        _0x5288B7F0690F7C1F = 0x5288B7F0690F7C1F,
        _0x4EDDD9E9CA5AF985 = 0x4EDDD9E9CA5AF985,
        _0xB223249B7798EEED = 0xB223249B7798EEED,
        _0xA0AE7653E8181725 = 0xA0AE7653E8181725,
        _0x66BC28E50E85270E = 0x66BC28E50E85270E,
        _0xDEEE1F265B7ECEF5 = 0xDEEE1F265B7ECEF5,
        _0x071769BCB24379E5 = 0x071769BCB24379E5,
        _0xF01D21DF39554115 = 0xF01D21DF39554115,
        _0xA03A6812529AD9C8 = 0xA03A6812529AD9C8,
        _0x20D504994FDC4412 = 0x20D504994FDC4412,
        _0x31108BB5715D035F = 0x31108BB5715D035F,
        _0xC2C05DEFE85A0B64 = 0xC2C05DEFE85A0B64,
        _0x040EE319EFD1D3B5 = 0x040EE319EFD1D3B5,
        _0xFC464598F6EE97B0 = 0xFC464598F6EE97B0,
        _0xAE00387E53B1E9FC = 0xAE00387E53B1E9FC,
        _0xEF1A8A484118735E = 0xEF1A8A484118735E,
        _0xD9F2FF4AF394D926 = 0xD9F2FF4AF394D926,
        _0xD346248C1DCE0D76 = 0xD346248C1DCE0D76,
        _0x7C907E8A725E5FD2 = 0x7C907E8A725E5FD2,
        _0x09FBF15D73EFC900 = 0x09FBF15D73EFC900,
        _0xF11D7CB962FCD747 = 0xF11D7CB962FCD747,
        _0xBE8DAA9D8D01DA6A = 0xBE8DAA9D8D01DA6A,
        _0x53764309C4618087 = 0x53764309C4618087,
        _0x032A14D082A9B269 = 0x032A14D082A9B269,
        _0xAFA87A7D41EE346A = 0xAFA87A7D41EE346A,
        _0x6A6E79FBE8678C98 = 0x6A6E79FBE8678C98,
        _0xCC61D8D6C19D9F14 = 0xCC61D8D6C19D9F14,
        _0xDA7FDEFF4DE86839 = 0xDA7FDEFF4DE86839,
        _0x5D5E2102B174B8D2 = 0x5D5E2102B174B8D2,
        _0x7B8C2B846C05E5AD = 0x7B8C2B846C05E5AD,
        _0x62D5F0588915B277 = 0x62D5F0588915B277,
        _0x2F4D53023F826FF0 = 0x2F4D53023F826FF0,
        _0xDABFE48BA0D457AA = 0xDABFE48BA0D457AA,
        _0xE5B76E5B56CD77DD = 0xE5B76E5B56CD77DD,
        _0x27AF48C62B281341 = 0x27AF48C62B281341,
        _0x99F92061EFE908BA = 0x99F92061EFE908BA,
        _0x05DD384F39DE1C8C = 0x05DD384F39DE1C8C,
        _0x198B85CC3C7A4593 = 0x198B85CC3C7A4593,
        _0x2A6D1DAAB9EBB262 = 0x2A6D1DAAB9EBB262,
        _0x07559B29950301FF = 0x07559B29950301FF,
        _0xD6E39DC5D46DF4AB = 0xD6E39DC5D46DF4AB,
        _0x8D56BDA343D9519F = 0x8D56BDA343D9519F,
        _0xD840C130D7AACFA5 = 0xD840C130D7AACFA5,
        _0x2E24C27B112B5B12 = 0x2E24C27B112B5B12,
    }
    public static class NATIVE_STREAMING_EXTENSIONS
    {
        public static void Call(this NATIVE_STREAMING hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_STREAMING hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}