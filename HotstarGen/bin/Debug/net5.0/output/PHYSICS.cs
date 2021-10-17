using System;
namespace Hotstar
{
    public enum NATIVE_PHYSICS : ulong
    { 
        /// <summary>
        /// Attaches entity 1 to entity 2.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        /// > Any p5
        /// > Any p6
        /// > Any p7
        /// > Any p8
        /// > Any p9
        /// > Any p10
        /// > Any p11
        /// > Any p12
        /// > Any p13
        /// > Any p14
        /// > Any p15
        /// > Any p16
        /// > Any p17
        /// > Any p18
        /// > Any p19
        /// > Any p20
        ///
        /// </summary>
        ATTACH_ENTITIES_TO_ROPE = 0x3D95EC8B6D940AC3,
        /// <summary>
        /// Forces a rope to a certain length.
        ///
        /// > int ropeId
        /// > float length
        ///
        /// </summary>
        ROPE_FORCE_LENGTH = 0xD009F759A723DB1B,
        /// <summary>
        /// Attaches a rope to two entities.
        ///
        /// > int ropeId
        /// > Entity entity1
        /// > Entity entity2
        /// > float ent1X
        /// > float ent1Y
        /// > float ent1Z
        /// > float ent2X
        /// > float ent2Y
        /// > float ent2Z
        /// > const char* boneName1
        /// > const char* boneName2
        ///
        /// </summary>
        _0x462FF2A432733A44 = 0x462FF2A432733A44,
        ADD_ROPE = 0xE832D760399EB220,
        _ADD_ROPE_2 = 0xE9C59F6809373A99,
        DELETE_ROPE = 0x52B4829281364649,
        DELETE_CHILD_ROPE = 0xAA5D6B1888E4DB20,
        DOES_ROPE_EXIST = 0xFD5448BE3111ED96,
        ROPE_DRAW_SHADOW_ENABLED = 0xF159A63806BB5BA8,
        GET_ROPE_VERTEX_COUNT = 0x3655F544CD30F0B5,
        DETACH_ROPE_FROM_ENTITY = 0xBCF3026912A8647D,
        ROPE_SET_UPDATE_ORDER = 0xDC57A637A20006ED,
        GET_ROPE_LAST_VERTEX_COORD = 0x21BB0FBD3E217C2D,
        GET_ROPE_VERTEX_COORD = 0xEA61CA8E80F09E4D,
        START_ROPE_WINDING = 0x1461C72C889E343E,
        STOP_ROPE_WINDING = 0xCB2D4AB84A19AA7C,
        START_ROPE_UNWINDING_FRONT = 0x538D1179EC1AA9A9,
        STOP_ROPE_UNWINDING_FRONT = 0xFFF3A50779EFBBB3,
        SET_DAMPING = 0xEEA3B200A6FEB65B,
        ACTIVATE_PHYSICS = 0x710311ADF0E20730,
        BREAK_ENTITY_GLASS = 0x2E648D16F6E308F3,
        SET_DISABLE_BREAKING = 0x5CEC1A84620E7D5B,
        SET_DISABLE_FRAG_DAMAGE = 0x01BA3AED21C16CFB,
        _0x6076213101A47B3B = 0x6076213101A47B3B,
        _0x4CFA2B7FAE115ECB = 0x4CFA2B7FAE115ECB,
        _0x79C2BEC82CFD7F7F = 0x79C2BEC82CFD7F7F,
        _0x7A54D82227A139DB = 0x7A54D82227A139DB,
        _0xE54BF2CE6C7D23A9 = 0xE54BF2CE6C7D23A9,
        _0x9C24846D0A4A2776 = 0x9C24846D0A4A2776,
        _0x0CB16D05E03FB525 = 0x0CB16D05E03FB525,
        _0xF27F1A8DE4F50A1B = 0xF27F1A8DE4F50A1B,
        _0x21D0890D88DFB0B0 = 0x21D0890D88DFB0B0,
        _0xE9CD9A67834985A7 = 0xE9CD9A67834985A7,
        _0x69C810B72291D831 = 0x69C810B72291D831,
        _0xB7469CB9AC3C0FD4 = 0xB7469CB9AC3C0FD4,
        _0xC64E7A62632AD2FE = 0xC64E7A62632AD2FE,
        _0x9B4F7E3E4F9C77B3 = 0x9B4F7E3E4F9C77B3,
        _0x06AADE17334F7A40 = 0x06AADE17334F7A40,
        _0x0348469DAA17576C = 0x0348469DAA17576C,
        _0x6EA0E93CFFA472CC = 0x6EA0E93CFFA472CC,
        _0xBDDA142759307528 = 0xBDDA142759307528,
        _0x32F4DBFDFCCCC735 = 0x32F4DBFDFCCCC735,
        _0xF8CA39D5C0D1D9A1 = 0xF8CA39D5C0D1D9A1,
        _0xEAF529446488EB18 = 0xEAF529446488EB18,
        _0x31160EC47E7C9549 = 0x31160EC47E7C9549,
        _0x5E981C764DF33117 = 0x5E981C764DF33117,
        _0xFB9153A54AC713E8 = 0xFB9153A54AC713E8,
        _0xD699E688B49C0FD2 = 0xD699E688B49C0FD2,
        _0xBB3E9B073E66C3C9 = 0xBB3E9B073E66C3C9,
        _0x522FA3F490E2F7AC = 0x522FA3F490E2F7AC,
        _0x3900491C0D61ED4B = 0x3900491C0D61ED4B,
        _0xC89E7410A93AC19A = 0xC89E7410A93AC19A,
        _0x1D97DA8ACB5D2582 = 0x1D97DA8ACB5D2582,
        _0x3C6490D940FF5D0B = 0x3C6490D940FF5D0B,
        _0x00F611A794A3C36E = 0x00F611A794A3C36E,
        _0x10DAA76CB8A201A1 = 0x10DAA76CB8A201A1,
        _0x461FCBDEB4D06717 = 0x461FCBDEB4D06717,
        _0x423C6B1F3786D28B = 0x423C6B1F3786D28B,
        _0x76BAD9D538BCA1AA = 0x76BAD9D538BCA1AA,
        _0xB40EA9E0D2E2F7F3 = 0xB40EA9E0D2E2F7F3,
        _0x3D69537039F8D824 = 0x3D69537039F8D824,
        _0x751DF00EEFF122E3 = 0x751DF00EEFF122E3,
        _0x8D59079C37C21D78 = 0x8D59079C37C21D78,
        _0x814D453FCFDF119F = 0x814D453FCFDF119F,
        _0x1FC92BDBA1106BD2 = 0x1FC92BDBA1106BD2,
        _0xDEDE679ED29DD4E7 = 0xDEDE679ED29DD4E7,
        _0xF1EA2A881EB7F2CD = 0xF1EA2A881EB7F2CD,
        _0x5A989B7EE3672A56 = 0x5A989B7EE3672A56,
        _0x483D4E917B0D35A9 = 0x483D4E917B0D35A9,
        _0xEE360CFC80C8B2BC = 0xEE360CFC80C8B2BC,
        _0x8EEDFD8921389928 = 0x8EEDFD8921389928,
        _0x5BD7457221CC5FF4 = 0x5BD7457221CC5FF4,
    }
    public static class NATIVE_PHYSICS_EXTENSIONS
    {
        public static void Call(this NATIVE_PHYSICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_PHYSICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}