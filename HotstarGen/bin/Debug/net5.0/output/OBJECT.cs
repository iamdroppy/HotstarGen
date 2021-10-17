using System;
namespace Hotstar
{
    public enum NATIVE_OBJECT : ulong
    { 
        /// <summary>
        /// Deletes the specified object, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Object* object
        ///
        /// </summary>
        DELETE_OBJECT = 0x931914268722C263,
        /// <summary>
        /// isMission - if true doesn't return mission objects
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > BOOL isMission
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        GET_CLOSEST_OBJECT_OF_TYPE = 0xE143FA2249364369,
        /// <summary>
        /// Door lock states:
        /// enum eDoorState
        /// {
        /// 	DOORSTATE_INVALID = -1,
        /// 	DOORSTATE_UNLOCKED,
        /// 	DOORSTATE_LOCKED_UNBREAKABLE,
        /// 	DOORSTATE_LOCKED_BREAKABLE,
        /// 	DOORSTATE_HOLD_OPEN_POSITIVE,
        /// 	DOORSTATE_HOLD_OPEN_NEGATIVE
        /// };
        ///
        /// > Hash doorHash
        /// > int state
        ///
        /// </summary>
        DOOR_SYSTEM_SET_DOOR_STATE = 0x6BAB9442830C7F53,
        /// <summary>
        /// Sets the ajar angle of a door.
        /// Ranges from -1.0 to 1.0, and 0.0 is closed / default.
        ///
        /// > Hash doorHash
        /// > float ajar
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_OPEN_RATIO = 0xB6E6FBA95C7324AC,
        /// <summary>
        /// Adjust the physics parameters of a prop, or otherwise known as "object". This is useful for simulated gravity.
        /// 
        /// Other parameters seem to be unknown.
        /// 
        /// p2: seems to be weight and gravity related. Higher value makes the obj fall faster. Very sensitive?
        /// p3: seems similar to p2
        /// p4: makes obj fall slower the higher the value
        /// p5: similar to p4
        ///
        /// > Object object
        /// > float weight
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float gravity
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float p10
        /// > float buoyancy
        ///
        /// </summary>
        SET_OBJECT_PHYSICS_PARAMS = 0xF6DF6E90DE7DF90F,
        /// <summary>
        /// Maximum amount of pickup models that can be disallowed is 10.
        /// 
        /// SET_LOCAL_PLAYER_*
        ///
        /// > Hash modelHash
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_LOCAL_PLAYER_CAN_USE_PICKUPS_WITH_THIS_MODEL = 0x88EAEC617CD26926,
        /// <summary>
        /// Seems to mostly have effect on wood-made objects https://imgur.com/a/32oQvOn
        ///
        /// > Object object
        /// > float burnLevel
        /// > BOOL affectAsh
        ///
        /// </summary>
        _SET_OBJECT_BURN_LEVEL = 0x2797C633DCDBBAC5,
        /// <summary>
        /// p2 is usually the same as speed parameter
        ///
        /// > Object object
        /// > float speed
        /// > float p2
        ///
        /// </summary>
        _SET_OBJECT_BURN_SPEED = 0x646564A3B7DF68F8,
        /// <summary>
        /// Returns object light intensity
        ///
        /// > Object object
        ///
        /// </summary>
        _0xFA3B61EC249B4674 = 0xFA3B61EC249B4674,
        CREATE_OBJECT = 0x509D5878EB39E842,
        CREATE_OBJECT_NO_OFFSET = 0x9A294B2138ABB884,
        PLACE_OBJECT_ON_GROUND_PROPERLY = 0x58A850EAEE20FAA3,
        SLIDE_OBJECT = 0x2FDFF4107B8C1147,
        SET_OBJECT_TARGETTABLE = 0x8A7391690F5AFD81,
        _SET_OBJECT_TARGETTABLE_2 = 0x581EDBE56E8D62C9,
        HAS_OBJECT_BEEN_BROKEN = 0x8ABFB70C49CC43E2,
        HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN = 0x761B0E69AC4D007E,
        _GET_OBJECT_OFFSET_FROM_COORDS = 0x163E252DE035A133,
        _ADD_DOOR_TO_SYSTEM_NEW = 0xD99229FE93B46286,
        _IS_DOOR_REGISTERED_WITH_NETWORK = 0xB5DED7B65C604FDF,
        REMOVE_DOOR_FROM_SYSTEM = 0x464D8E1427156FE4,
        DOOR_SYSTEM_GET_DOOR_STATE = 0x160AA1B32F6139B8,
        DOOR_SYSTEM_SET_AUTOMATIC_RATE = 0x03C27E13B42A0E82,
        DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE = 0x9BA001CB45CBF627,
        DOOR_SYSTEM_GET_OPEN_RATIO = 0x65499865FCA6E5EC,
        IS_DOOR_REGISTERED_WITH_SYSTEM = 0xC153C43EA202C8C1,
        IS_DOOR_CLOSED = 0xC531EE8A1145A149,
        DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS = 0xBFA48E2FF417213F,
        IS_POINT_IN_ANGLED_AREA = 0x2A70BAE8883E4C81,
        SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY = 0x4D89D607CB3DD1D2,
        GET_OBJECT_FRAGMENT_DAMAGE_HEALTH = 0xB6FBFD079B8D0596,
        SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN = 0x406137F8EF90EAF5,
        BREAK_OBJECT_FRAGMENT_CHILD = 0xE7E4C198B0185900,
        BREAK_ALL_OBJECT_FRAGMENT_BONES = 0x8462BE2341A55B6F,
        TRACK_OBJECT_VISIBILITY = 0xB252BC036B525623,
        IS_OBJECT_VISIBLE = 0x8B32ACE6326A7546,
        GET_RAYFIRE_MAP_OBJECT = 0xB48FCED898292E52,
        SET_STATE_OF_RAYFIRE_MAP_OBJECT = 0x5C29F698D404C5E1,
        GET_STATE_OF_RAYFIRE_MAP_OBJECT = 0x899BA936634A322E,
        DOES_RAYFIRE_MAP_OBJECT_EXIST = 0x52AF537A0C5B8AAD,
        GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE = 0x260EE4FDBDF4DB01,
        CREATE_PICKUP = 0xFBA08C503DD5FA58,
        CREATE_PICKUP_ROTATE = 0x891804727E0A98B7,
        CREATE_AMBIENT_PICKUP = 0x673966A0C0FD7171,
        CREATE_PORTABLE_PICKUP = 0x2EAF1FDB2FB55698,
        ATTACH_PORTABLE_PICKUP_TO_PED = 0x8DC39368BDD57755,
        DETACH_PORTABLE_PICKUP_FROM_PED = 0xCF463D1E9A0AECB1,
        _HIDE_PICKUP_OBJECT = 0x2777150CC7D9365E,
        SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER = 0x0BF3B3BD47D79C08,
        SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS = 0x78857FC65CADB909,
        GET_SAFE_PICKUP_COORDS = 0x6E16BC2503FF1FF0,
        GET_PICKUP_COORDS = 0x225B8B35C88029B3,
        REMOVE_ALL_PICKUPS_OF_TYPE = 0x27F9D613092159CF,
        HAS_PICKUP_BEEN_COLLECTED = 0x80EC48E6679313F9,
        REMOVE_PICKUP = 0x3288D8ACAECD2AB2,
        SET_PICKUP_DO_NOT_AUTO_PLACE_ON_GROUND = 0x634C19521485AB25,
        DOES_PICKUP_EXIST = 0xAFC1CA75AD4074D1,
        DOES_PICKUP_OBJECT_EXIST = 0xD9EFB6DBF7DAAEA3,
        GET_PICKUP_OBJECT = 0x5099BC55630B25AE,
        IS_OBJECT_A_PICKUP = 0x0378C08504160D0D,
        _IS_PICKUP_TYPE_VALID = 0x007BD043587F7C82,
        DOES_PICKUP_OF_TYPE_EXIST_IN_AREA = 0xF9C36251F6E48E33,
        SET_PICKUP_REGENERATION_TIME = 0x78015C9B4B3ECC9D,
        FORCE_PICKUP_REGENERATE = 0x758A5C1B3B1E1990,
        BLOCK_PICKUP_FROM_PLAYER_COLLECTION = 0xB8F5062070BB6DBD,
        SET_PICKUP_NOT_LOOTABLE = 0x92E87F60F21A0C3A,
        SET_TEAM_PICKUP_OBJECT = 0x53E0DF1A2A3CF0CA,
        PREVENT_COLLECTION_OF_PORTABLE_PICKUP = 0x92AEFB5F6E294023,
        SET_PICKUP_GENERATION_RANGE_MULTIPLIER = 0x318516E02DE3ECE2,
        SET_PICKUP_UNCOLLECTABLE = 0x4A8CB328CD6F1C9B,
        SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE = 0x81218CE01B672219,
        SET_PICKUP_PARTICLE_FX_SPAWN = 0xEB9740A38FD6D634,
        SET_PICKUP_PARTICLE_FX_HIGHLIGHT = 0x1607C7D9B3021DF5,
        GET_WEAPON_TYPE_FROM_PICKUP_TYPE = 0x08F96CA6C551AD51,
        _SET_OBJECT_TEXTURE_VARIATION = 0x971DA0055324D033,
        _SET_OBJECT_BURN_OPACITY = 0x7D7285EFEAB5AF15,
        _SET_OBJECT_BURN_INTENSITY = 0xC8E21C1677DC5E6F,
        _GET_PICKUP_HASH = 0x5EAAD83F8CFB4575,
        SET_FORCE_OBJECT_THIS_FRAME = 0xF538081986E49E9D,
        _MARK_OBJECT_FOR_DELETION = 0xADBE4809F19F927A,
        CREATE_OBJECT_SKELETON = 0xB6CBD40F8EA69E8A,
        SET_CUSTOM_TEXTURES_ON_OBJECT = 0xE124889AE0521FCF,
        _0xA22712E8471AA08E = 0xA22712E8471AA08E,
        _0xF6E88489B4E6EBE5 = 0xF6E88489B4E6EBE5,
        _0xE157A8A336C7F04A = 0xE157A8A336C7F04A,
        _0x46CBCF0E98A4E156 = 0x46CBCF0E98A4E156,
        _0xB3B1546D23DF8DE1 = 0xB3B1546D23DF8DE1,
        _0x3A77DAE8B4FD7586 = 0x3A77DAE8B4FD7586,
        _0x1F1FABFE9B2A1254 = 0x1F1FABFE9B2A1254,
        _0x4F89DAD4156BA145 = 0x4F89DAD4156BA145,
        _0x985767F5FA45BC44 = 0x985767F5FA45BC44,
        _0x8433E1954BE323FC = 0x8433E1954BE323FC,
        _0x6E2AA80BB0C03728 = 0x6E2AA80BB0C03728,
        _0x1BC47A9DEDC8DF5D = 0x1BC47A9DEDC8DF5D,
        _0x7F458B543006C8FE = 0x7F458B543006C8FE,
        _0xACD4F9831DFAD7F5 = 0xACD4F9831DFAD7F5,
        _0x0C0A373D181BF900 = 0x0C0A373D181BF900,
        _0xA93F925F1942E434 = 0xA93F925F1942E434,
        _0x4D8611DFE1126478 = 0x4D8611DFE1126478,
        _0x57C242543B7B8FB9 = 0x57C242543B7B8FB9,
        _0x4AE07EBA3462C5D5 = 0x4AE07EBA3462C5D5,
        _0x22031584496CFB70 = 0x22031584496CFB70,
        _0xC07B91B996C1DE89 = 0xC07B91B996C1DE89,
        _0x0943113E02322164 = 0x0943113E02322164,
        _0x614D0B4533F842D3 = 0x614D0B4533F842D3,
        _0x276AAF0F1C7F2494 = 0x276AAF0F1C7F2494,
        _0xEBA314768FB35D58 = 0xEBA314768FB35D58,
        _0x5230BF34EB0EC645 = 0x5230BF34EB0EC645,
        _0x235C863DA77BD88D = 0x235C863DA77BD88D,
        _0xAAACF33CBF9B990A = 0xAAACF33CBF9B990A,
        _0xE4EFB315BCD2A838 = 0xE4EFB315BCD2A838,
        _0xF9C1681347C8BD15 = 0xF9C1681347C8BD15,
        _0x58DE624FA7FB0E7F = 0x58DE624FA7FB0E7F,
        _0x491439AEF410A2FC = 0x491439AEF410A2FC,
        _0xFFB99FFD17F65889 = 0xFFB99FFD17F65889,
        _0xCEAB54F4632C6EF6 = 0xCEAB54F4632C6EF6,
        _0xEB6F1A9B5510A5D2 = 0xEB6F1A9B5510A5D2,
        _0xE2B3B852B537C398 = 0xE2B3B852B537C398,
        _0x6579860A5558524A = 0x6579860A5558524A,
        _0xDFA1237F5228263F = 0xDFA1237F5228263F,
        _0xF49574E2332A8F06 = 0xF49574E2332A8F06,
        _0x63E39F09310F481F = 0x63E39F09310F481F,
        _0x04D1D4E411CE52D0 = 0x04D1D4E411CE52D0,
        _0x7FCD49388BC9B775 = 0x7FCD49388BC9B775,
        _0xFA99E8E575F2FEF8 = 0xFA99E8E575F2FEF8,
        _0x3E2616E7EA539480 = 0x3E2616E7EA539480,
        _0x94F3D956BFAEAE18 = 0x94F3D956BFAEAE18,
        _0x1F5E07E14A86FAFC = 0x1F5E07E14A86FAFC,
        _0x9F52AD67D1A91BAD = 0x9F52AD67D1A91BAD,
        _0xAC9AE68F0A463752 = 0xAC9AE68F0A463752,
        _0xF92099527DB8E2A7 = 0xF92099527DB8E2A7,
        _0x20135AF9C10D2A3D = 0x20135AF9C10D2A3D,
        _0x00EE08603EADEE92 = 0x00EE08603EADEE92,
        _0xDE116ECFFDD4B997 = 0xDE116ECFFDD4B997,
        _0x44B09A23D728045A = 0x44B09A23D728045A,
        _0x3397CD4E0353DFBA = 0x3397CD4E0353DFBA,
        _0x9A74A9CADFA8A598 = 0x9A74A9CADFA8A598,
        _0xF40AB58D83C35027 = 0xF40AB58D83C35027,
        _0xCBFBD38F2E0A263B = 0xCBFBD38F2E0A263B,
        _0xD91E55B6C005EB09 = 0xD91E55B6C005EB09,
        _0xCAAF2BCCFEF37F77 = 0xCAAF2BCCFEF37F77,
        _0x08C5825A2932EA7B = 0x08C5825A2932EA7B,
        _0x7D4411D6736CD295 = 0x7D4411D6736CD295,
        _0x250EBB11E81A10BE = 0x250EBB11E81A10BE,
        _0x2BF1953C0C21AC88 = 0x2BF1953C0C21AC88,
        _0x1461DF6DB886BE3F = 0x1461DF6DB886BE3F,
        _0xF65EDE5D02A7A760 = 0xF65EDE5D02A7A760,
        _0x98D2D9C053A1F449 = 0x98D2D9C053A1F449,
        _0xE1C708BA4885796B = 0xE1C708BA4885796B,
        _0xB7017DA4D498269F = 0xB7017DA4D498269F,
        _0xD503D6F0986D58BC = 0xD503D6F0986D58BC,
        _0xAEE6C800E124CFE1 = 0xAEE6C800E124CFE1,
        _0x3DF1A0A58498E209 = 0x3DF1A0A58498E209,
    }
    public static class NATIVE_OBJECT_EXTENSIONS
    {
        public static void Call(this NATIVE_OBJECT hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_OBJECT hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}