using System;
namespace Hotstar
{
    public enum NATIVE_EVENT : ulong
    { 
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Hash eventType
        /// > float x
        /// > float y
        /// > float z
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > float p8
        /// > int p9
        /// > int p10
        ///
        /// </summary>
        ADD_SHOCKING_EVENT_AT_POSITION = 0xD9F8455409B525E9,
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Hash eventType
        /// > Entity entity
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > BOOL p8
        /// > BOOL p9
        /// > int p10
        /// > int p11
        ///
        /// </summary>
        ADD_SHOCKING_EVENT_FOR_ENTITY = 0x7FD8F3BE76F89422,
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Hash eventType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        IS_SHOCKING_EVENT_IN_SPHERE = 0x9DB47E16060D6354,
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Hash eventType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > BOOL p5
        ///
        /// </summary>
        _REMOVE_ALL_SHOCKING_EVENTS_OF_TYPE_IN_AREA = 0x6A648D42BF271DC7,
        /// <summary>
        /// eventType: https://alloc8or.re/rdr3/doc/enums/eEventType.txt
        ///
        /// > Hash eventType
        /// > BOOL p1
        ///
        /// </summary>
        _REMOVE_ALL_SHOCKING_EVENTS_OF_TYPE = 0x118873DD538490B4,
        SET_DECISION_MAKER = 0x8AE2F981CDDB8FA4,
        _CREATE_SHOCKING_EVENT = 0xCA1315C33B9A2847,
        REMOVE_SHOCKING_EVENT = 0xE8BB3CC253A34559,
        REMOVE_ALL_SHOCKING_EVENTS = 0xD47A168C2AB90DC4,
        _REMOVE_ALL_SHOCKING_EVENTS_IN_AREA = 0xB4C71BA9CAB097BD,
        REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS = 0xDB249021652420C5,
        SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME = 0x84994FAD4E4E4E69,
        _0x6B9C5C38838FB6E6 = 0x6B9C5C38838FB6E6,
        _0x36D0F2BA2C0D9BDE = 0x36D0F2BA2C0D9BDE,
        _0x7C511E91738A0828 = 0x7C511E91738A0828,
        _0xB6F4825153920582 = 0xB6F4825153920582,
        _0x4B2B1A891D437CA7 = 0x4B2B1A891D437CA7,
        _0x9520175B35E2268D = 0x9520175B35E2268D,
        _0x18E93EBFC1FCFA48 = 0x18E93EBFC1FCFA48,
        _0x56B3410626A473E7 = 0x56B3410626A473E7,
        _0x608AD36A644A97FE = 0x608AD36A644A97FE,
        _0x4465C3D1475BD3FD = 0x4465C3D1475BD3FD,
        _0x2DD42FAD06E6F19E = 0x2DD42FAD06E6F19E,
        _0xA86B0EE9B39D15D6 = 0xA86B0EE9B39D15D6,
        _0x26054EB81AC0893B = 0x26054EB81AC0893B,
        _0xBB1E41DD3D3C6250 = 0xBB1E41DD3D3C6250,
        _0xAD17A18215DD23D6 = 0xAD17A18215DD23D6,
        _0xC6A7DC546E94FED5 = 0xC6A7DC546E94FED5,
        _0x796EECFF0C6D39BE = 0x796EECFF0C6D39BE,
        _0x797B3D4D92E56094 = 0x797B3D4D92E56094,
        _0x822A001BCEA5BD81 = 0x822A001BCEA5BD81,
        _0x38497F139981C5C9 = 0x38497F139981C5C9,
        _0x1D1B448D719415AB = 0x1D1B448D719415AB,
        _0x83D43F0FD5276E4D = 0x83D43F0FD5276E4D,
        _0xE28D7FC9FD32ABEB = 0xE28D7FC9FD32ABEB,
        _0x1A5C5D350068A673 = 0x1A5C5D350068A673,
        _0xAD8F2424C6E1E3A8 = 0xAD8F2424C6E1E3A8,
        _0xE2C2FBB7825FFC66 = 0xE2C2FBB7825FFC66,
    }
    public static class NATIVE_EVENT_EXTENSIONS
    {
        public static void Call(this NATIVE_EVENT hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_EVENT hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}