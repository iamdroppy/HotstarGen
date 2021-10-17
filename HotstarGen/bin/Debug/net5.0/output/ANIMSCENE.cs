using System;
namespace Hotstar
{
    public enum NATIVE_ANIMSCENE : ulong
    { 
        /// <summary>
        /// Pauses all script threads except the one that called it.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _PAUSE_SCRIPT_THREADS = 0x37C1257849DEF24A,
        _CREATE_ANIM_SCENE = 0x1FCA98E33C1437B3,
        _DELETE_ANIM_SCENE = 0x84EEDB2C6E650000,
        TRIGGER_ANIM_SCENE_SKIP = 0x4B85B3CF9197AEDF,
        _CLEAR_ANIM_SCENE_WAS_SKIPPED = 0x8A8208AE92BF87A5,
        DOES_ANIM_SCENE_EXIST = 0x25557E324489393C,
        _DOES_ENTITY_WITH_ID_EXIST_IN_ANIM_SCENE = 0x6F1F0B17109309DA,
        LOAD_ANIM_SCENE = 0xAF068580194D9DC7,
        IS_ANIM_SCENE_LOADED = 0x477122B8D05E7968,
        _IS_ANIM_SCENE_LOADING = 0x59606519FF9D3EC2,
        IS_ANIM_SCENE_METADATA_LOADED = 0x95531A4A20CCE7BC,
        START_ANIM_SCENE = 0xF4D94AF761768700,
        RESET_ANIM_SCENE = 0x8FDF221F13537936,
        ABORT_ANIM_SCENE = 0x718CF1328D20C2B3,
        RESUME_ANIM_SCENE_FROM_LAST_CHECKPOINT = 0x8E1BA705F63C1925,
        IS_ANIM_SCENE_RUNNING = 0xCBFC7725DE6CE2E0,
        IS_ANIM_SCENE_FINISHED = 0xD8254CB2C586412B,
        IS_ANIM_SCENE_EXITING_THIS_FRAME = 0xCDC5512A407CF08D,
        HAS_ANIM_SCENE_EXITED = 0xF94692EB9DC15D74,
        IS_ANIM_SCENE_IN_SECTION = 0x8D81E7824B7753F7,
        FADE_ANIM_SCENE_AUDIO_IN = 0xA41351EA2A18A0AD,
        FADE_ANIM_SCENE_AUDIO_OUT = 0x323E3AD772BA5D57,
        BLOCK_ANIM_SCENE_FADING_NEXT_FRAME = 0x1B70811D3BF75DB9,
        SET_ANIM_SCENE_ORIGIN = 0x020894BF17A02EF2,
        GET_ANIM_SCENE_ORIGIN = 0xADF1D53F3B1FE0A7,
        SET_ANIM_SCENE_PAUSED = 0xD6824B7D24DC0CE0,
        _IS_ANIM_SCENE_PAUSED = 0x4B4038796F0D6566,
        SET_ANIM_SCENE_RATE = 0x75820B801CFF262A,
        _GET_ANIM_SCENE_RATE = 0x43C21623E42B821B,
        GET_ANIM_SCENE_PHASE = 0x3FBC3F51BF12DFBF,
        _GET_ANIM_SCENE_TIME = 0x61BE7D6186260002,
        _GET_ANIM_SCENE_DURATION = 0x49F1D143ADE32656,
        SET_ANIM_SCENE_ENTITY = 0x8B720AD451CA2AB3,
        REMOVE_ANIM_SCENE_ENTITY = 0x2BF96692C67F3E53,
        IS_ENTITY_EXITING_ANIM_SCENE_THIS_FRAME = 0x005E6F28DD7ED58D,
        COULD_ANIM_SCENE_ENTITY_REACH_EXIT_NEXT_FRAME = 0x73616E64696C616E,
        HAS_ENTITY_EXITED_ANIM_SCENE = 0xB89FCFF19DAFFF28,
        _GET_ANIM_SCENE_PED = 0xE5822422197BBBA3,
        _GET_ANIM_SCENE_OBJECT = 0xFB5674687A1B2814,
        _GET_ANIM_SCENE_VEHICLE = 0x430EE0A19BC5A287,
        SET_ANIM_SCENE_BOOL = 0x519E96C2C68B404B,
        GET_ANIM_SCENE_BOOL = 0x07A6F6447ECA9B64,
        SET_ANIM_SCENE_FLOAT = 0x6BC5104E68CBEFE8,
        GET_ANIM_SCENE_FLOAT = 0xCC24CB07F60B496E,
        SET_ANIM_SCENE_INT = 0x3A379D2166CF5B92,
        GET_ANIM_SCENE_INT = 0x2B7277484CC095FD,
        GET_ANIM_SCENE_ENTITY_LOCATION_DATA = 0x8398438D8F14F56D,
        IS_ENTITY_PLAYING_ANIM_SCENE = 0x3AB6C7B0BB0DF4B1,
        ATTACH_ANIM_SCENE_TO_ENTITY = 0xDC418495DBA327A1,
        ATTACH_ANIM_SCENE_TO_ENTITY_PRESERVING_LOCATION = 0x1C0B105C3F30B88D,
        DETACH_ANIM_SCENE = 0x6843A1AA3A336DFF,
        DETACH_ANIM_SCENE_PRESERVING_LOCATION = 0xA2507C4948C83D2E,
        TAKE_OWNERSHIP_OF_ANIM_SCENE = 0xF7A4C571E572D237,
        CHECK_OWNERSHIP_OF_ANIM_SCENE = 0x661B8683611B9B97,
        SET_ANIM_SCENE_PLAYBACK_LIST = 0xAB5E7CAB074D6B84,
        SET_ANIM_SCENE_PLAY_LIST = 0x15598CFB25F3DC7E,
        REQUEST_ANIM_SCENE_PLAY_LIST = 0xDF7B5144E25CD3FE,
        _RELEASE_ANIM_SCENE_PLAY_LIST = 0xAE6ADA8FE7E84ACC,
        GET_ANIM_SCENE_CURRENT_ACTIVE_CAMERA_COUNT = 0x4822A65D5AF64E69,
        WAS_ANIM_SCENE_SKIPPED = 0xEF324E9550A394D5,
        _0x4B85B3CF91972222 = 0x4B85B3CF91972222,
        _0x9D1ECA9337BE9FC3 = 0x9D1ECA9337BE9FC3,
        _0xF8D1D2DAB6007EEF = 0xF8D1D2DAB6007EEF,
        _0x9E036D5204FFBBC8 = 0x9E036D5204FFBBC8,
        _0x73616E64696C132E = 0x73616E64696C132E,
        _0x4CDFFE3189EBDBD0 = 0x4CDFFE3189EBDBD0,
        _0x34A0671BE613D3D0 = 0x34A0671BE613D3D0,
        _0xD70C7A30412F8FA0 = 0xD70C7A30412F8FA0,
        _0x9AAE3C1148A09BCA = 0x9AAE3C1148A09BCA,
        _0xA96619FE85159ED2 = 0xA96619FE85159ED2,
        _0x337F1CC8EE895601 = 0x337F1CC8EE895601,
        _0x1C5D33A4293E6DDE = 0x1C5D33A4293E6DDE,
        _0xA9016536015DE29D = 0xA9016536015DE29D,
        _0x1F0E401031E20146 = 0x1F0E401031E20146,
        _0xAE5ADA4FE3E21ADC = 0xAE5ADA4FE3E21ADC,
        _0x1407F5115FB9583E = 0x1407F5115FB9583E,
        _0x23E33CB9F4A3F547 = 0x23E33CB9F4A3F547,
        _0x0DF57F86FE71DBE5 = 0x0DF57F86FE71DBE5,
        _0x1AD896BF43619551 = 0x1AD896BF43619551,
        _0x5D7BFDA2290B4E39 = 0x5D7BFDA2290B4E39,
        _0xFDFC14799373283F = 0xFDFC14799373283F,
        _0xB727A847862CB00A = 0xB727A847862CB00A,
        _0xA1300DE03E5D1973 = 0xA1300DE03E5D1973,
        _0x53CB3970BA02E3CC = 0x53CB3970BA02E3CC,
        _0xB1A196BAFE650402 = 0xB1A196BAFE650402,
        _0xAE6DE22DE0ED4554 = 0xAE6DE22DE0ED4554,
        _0x61B2AAEF645DDAF0 = 0x61B2AAEF645DDAF0,
        _0x07706C4CC9C6CC9E = 0x07706C4CC9C6CC9E,
        _0x3641FCD53E59B335 = 0x3641FCD53E59B335,
        _0x99B2A2E3655DEAF1 = 0x99B2A2E3655DEAF1,
        _0xBC781D24AA11F179 = 0xBC781D24AA11F179,
        _0x3B393716C3FD8237 = 0x3B393716C3FD8237,
        _0xE12D7B4B959644CD = 0xE12D7B4B959644CD,
        _0xC1193521E3B9FADD = 0xC1193521E3B9FADD,
        _0x7C709C01D43D94CD = 0x7C709C01D43D94CD,
        _0x41AFA5F228B0B6B0 = 0x41AFA5F228B0B6B0,
        _0x2DB524750DC41ED4 = 0x2DB524750DC41ED4,
        _0xEA41D44A8D42057B = 0xEA41D44A8D42057B,
        _0xCDCD7B2D49AEE73A = 0xCDCD7B2D49AEE73A,
    }
    public static class NATIVE_ANIMSCENE_EXTENSIONS
    {
        public static void Call(this NATIVE_ANIMSCENE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_ANIMSCENE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}