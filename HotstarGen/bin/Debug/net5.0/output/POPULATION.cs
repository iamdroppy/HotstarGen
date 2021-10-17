using System;
namespace Hotstar
{
    public enum NATIVE_POPULATION : ulong
    { 
        GET_NUM_MODELS_IN_POPULATION_SET = 0xA1E3171ED0E47564,
        GET_PED_MODEL_NAME_IN_POPULATION_SET = 0x3EAFA1C533B7139E,
        GET_RANDOM_MODEL_FROM_POPULATION_SET = 0x6B12ED8C77E8567B,
        _CREATE_POPZONE_FROM_VOLUME = 0x9AC1C64FE46B6D09,
        _DELETE_SCRIPT_POPZONE = 0xA6E6A66FC4CA4224,
        _IS_POPZONE_VALID = 0xA5BD585005EFCAD4,
        SET_POPZONE_POPULATION_SET = 0x3E6A49D9B519E85C,
        SET_SPAWNER_INFO_PRIORITY = 0x60CDE717A6D47769,
        CLEAR_SPAWNER_INFO_PRIORITY = 0x217A54DE2D200305,
        DISABLE_AMBIENT_ROAD_POPULATION = 0xC6DCC2A3A8825C85,
        ENABLE_AMBIENT_ROAD_POPULATION = 0xBC90BDF4E5228EA1,
        _0x7E6BC0B94F5928F0 = 0x7E6BC0B94F5928F0,
        _0x578E2FA64E847C60 = 0x578E2FA64E847C60,
        _0x08892122769770D5 = 0x08892122769770D5,
        _0x0F1861101C9A9944 = 0x0F1861101C9A9944,
        _0x638FCFC6042A9473 = 0x638FCFC6042A9473,
        _0xB56D41A694E42E86 = 0xB56D41A694E42E86,
        _0x74C2B3DC0B294102 = 0x74C2B3DC0B294102,
        _0x18262CAFEBB5FBE1 = 0x18262CAFEBB5FBE1,
        _0xA1CFB35069D23C23 = 0xA1CFB35069D23C23,
        _0x2161278C6322F740 = 0x2161278C6322F740,
        _0xF45E46DEECF7DF6E = 0xF45E46DEECF7DF6E,
        _0x8EC7CD701F872F87 = 0x8EC7CD701F872F87,
        _0xC4533E3E87125C9E = 0xC4533E3E87125C9E,
        _0xF74E134F40192884 = 0xF74E134F40192884,
        _0xDBBF12EA7C1029B2 = 0xDBBF12EA7C1029B2,
        _0x247F86595D396344 = 0x247F86595D396344,
        _0x324AB2A68AD8AEE5 = 0x324AB2A68AD8AEE5,
        _0x2660E7720EDC4BD0 = 0x2660E7720EDC4BD0,
        _0x595478B3BBC3076D = 0x595478B3BBC3076D,
        _0xEC116EDB683AD479 = 0xEC116EDB683AD479,
    }
    public static class NATIVE_POPULATION_EXTENSIONS
    {
        public static void Call(this NATIVE_POPULATION hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_POPULATION hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}