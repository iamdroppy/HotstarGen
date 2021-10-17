using System;
namespace Hotstar
{
    public enum NATIVE_CAM : ulong
    { 
        /// <summary>
        /// ease - smooth transition between the camera's positions
        /// easeTime - Time in milliseconds for the transition to happen
        /// 
        /// If you have created a script (rendering) camera, and want to go back to the 
        /// character (gameplay) camera, call this native with render set to 0.
        /// Setting ease to 1 will smooth the transition.
        ///
        /// > BOOL render
        /// > BOOL ease
        /// > int easeTime
        /// > BOOL p3
        /// > BOOL p4
        /// > Any p5
        ///
        /// </summary>
        RENDER_SCRIPT_CAMS = 0x33281167E4942E4F,
        /// <summary>
        /// BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
        ///
        /// > Cam cam
        /// > BOOL p1
        ///
        /// </summary>
        DESTROY_CAM = 0x4E67E0B6D7FD5145,
        /// <summary>
        /// BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
        ///
        /// > BOOL p0
        ///
        /// </summary>
        DESTROY_ALL_CAMS = 0x163600D6E136C9F8,
        /// <summary>
        /// Returns whether or not the passed camera handle exists.
        ///
        /// > Cam cam
        ///
        /// </summary>
        DOES_CAM_EXIST = 0x153AD457764FD704,
        /// <summary>
        /// Set camera as active/inactive.
        ///
        /// > Cam cam
        /// > BOOL active
        ///
        /// </summary>
        SET_CAM_ACTIVE = 0x87295BCA613800C8,
        /// <summary>
        /// Returns whether or not the passed camera handle is active.
        ///
        /// > Cam cam
        ///
        /// </summary>
        IS_CAM_ACTIVE = 0x63EFCC7E1810B8E6,
        /// <summary>
        /// Sets the position of the cam.
        ///
        /// > Cam cam
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        SET_CAM_COORD = 0xF9EE7D419EE49DE6,
        /// <summary>
        /// Sets the rotation of the cam.
        ///
        /// > Cam cam
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int rotationOrder
        ///
        /// </summary>
        SET_CAM_ROT = 0x63DFA6810AD78719,
        /// <summary>
        /// Sets the field of view of the cam.
        /// 
        /// Min: 1.0f
        /// Max: 130.0f
        ///
        /// > Cam cam
        /// > float fieldOfView
        ///
        /// </summary>
        SET_CAM_FOV = 0x27666E5988D9D429,
        /// <summary>
        /// Last param determines if its relative to the Entity
        ///
        /// > Cam cam
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > BOOL isRelative
        ///
        /// </summary>
        ATTACH_CAM_TO_ENTITY = 0xFDC0DF7F6FB0A592,
        /// <summary>
        /// Allows you to aim and shoot at the direction the camera is facing.
        ///
        /// > Cam cam
        /// > BOOL toggle
        ///
        /// </summary>
        SET_CAM_AFFECTS_AIMING = 0x3CB9E8BDE5E76F33,
        /// <summary>
        /// p7 (length) determines the length of the spline, affects camera path and duration of transition between previous node and this one
        /// 
        /// p8 big values ~100 will slow down the camera movement before reaching this node
        /// 
        /// p9 != 0 seems to override the rotation/pitch (bool?)
        ///
        /// > Cam camera
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > int length
        /// > int p8
        /// > int p9
        ///
        /// </summary>
        ADD_CAM_SPLINE_NODE = 0xF1F57F9D230F9CD1,
        /// <summary>
        /// Can use this with SET_CAM_SPLINE_PHASE to set the float it this native returns.
        /// 
        /// (returns 1.0f when no nodes has been added, reached end of non existing spline)
        ///
        /// > Cam cam
        ///
        /// </summary>
        GET_CAM_SPLINE_PHASE = 0x095EDCD24D90033A,
        /// <summary>
        /// Fades the screen in.
        /// 
        /// duration: The time the fade should take, in milliseconds.
        ///
        /// > int duration
        ///
        /// </summary>
        DO_SCREEN_FADE_IN = 0x6A053CF596F67DF7,
        /// <summary>
        /// Fades the screen out.
        /// 
        /// duration: The time the fade should take, in milliseconds.
        ///
        /// > int duration
        ///
        /// </summary>
        DO_SCREEN_FADE_OUT = 0x40C719A5E410B9E4,
        /// <summary>
        /// Sets the camera position relative to heading in float from -360 to +360.
        /// 
        /// Heading is alwyas 0 in aiming camera.
        ///
        /// > float heading
        /// > float p1
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_RELATIVE_HEADING = 0x5D1EB123EAC5D071,
        /// <summary>
        /// Sets the camera pitch.
        /// 
        /// Parameters:
        /// x = pitches the camera on the x axis.
        /// Value2 = always seems to be hex 0x3F800000 (1.000000 float).
        ///
        /// > float x
        /// > float Value2
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_RELATIVE_PITCH = 0xFB760AF4F537B8BF,
        /// <summary>
        /// Sets the amplitude for the gameplay (i.e. 3rd or 1st) camera to shake.
        ///
        /// > float amplitude
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE = 0x570E35F5C4A44838,
        /// <summary>
        /// minimum: Degrees between -180f and 180f.
        /// maximum: Degrees between -180f and 180f.
        /// 
        /// Clamps the gameplay camera's current yaw.
        /// 
        /// Eg. _CLAMP_GAMEPLAY_CAM_YAW(0.0f, 0.0f) will set the horizontal angle directly behind the player.
        ///
        /// > float minimum
        /// > float maximum
        ///
        /// </summary>
        _CLAMP_GAMEPLAY_CAM_YAW = 0x14F3947318CA8AD2,
        /// <summary>
        /// minimum: Degrees between -90f and 90f.
        /// maximum: Degrees between -90f and 90f.
        /// 
        /// Clamps the gameplay camera's current pitch.
        /// 
        /// Eg. _CLAMP_GAMEPLAY_CAM_PITCH(0.0f, 0.0f) will set the vertical angle directly behind the player.
        ///
        /// > float minimum
        /// > float maximum
        ///
        /// </summary>
        _CLAMP_GAMEPLAY_CAM_PITCH = 0x326C7AA308F3DF6A,
        /// <summary>
        /// Does the same as 0x9C473089A934C930
        ///
        ///
        /// </summary>
        _DISABLE_FIRST_PERSON_CAM_THIS_FRAME_2 = 0x05AB44D906738426,
        /// <summary>
        /// p6 & p7 - possibly length or time
        ///
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > BOOL p4
        /// > int p5
        /// > int p6
        /// > int p7
        /// > Any p8
        ///
        /// </summary>
        SET_GAMEPLAY_ENTITY_HINT = 0xD1F7F32640ADFD12,
        /// <summary>
        /// SET_CAM_*
        ///
        /// > Cam cam
        /// > BOOL p1
        ///
        /// </summary>
        _0x1B8F3CE5A6001298 = 0x1B8F3CE5A6001298,
        /// <summary>
        /// Returns true if player is in first person
        ///
        ///
        /// </summary>
        _0xD1BA66940E94C547 = 0xD1BA66940E94C547,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        ///
        /// </summary>
        _0x77D65669A05D1A1A = 0x77D65669A05D1A1A,
        STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP = 0x8C7C7FF7CF0E5153,
        CREATE_CAM = 0xE72CDBA7F0A02DD6,
        CREATE_CAM_WITH_PARAMS = 0x40C23491CE83708E,
        CREATE_CAMERA = 0x57CDF879EA466C46,
        CREATE_CAMERA_WITH_PARAMS = 0x98B99B9F27E2D60B,
        IS_CAM_RENDERING = 0x4415F8A6C536D39F,
        GET_RENDERING_CAM = 0x03A8931ECC8015D6,
        GET_CAM_COORD = 0x6B12F11C2A9F0344,
        GET_CAM_ROT = 0x9BF96B57254E7889,
        GET_CAM_FOV = 0x8101D32A0A6B0F60,
        SET_CAM_PARAMS = 0xA47BBFFFB83D4D0A,
        SET_CAM_NEAR_CLIP = 0xA924028272A61364,
        SET_CAM_FAR_CLIP = 0x5E32817BF6302111,
        SET_CAM_MOTION_BLUR_STRENGTH = 0x45FD891364181F9E,
        ATTACH_CAM_TO_PED_BONE = 0xDFC1E4A44C0324CA,
        DETACH_CAM = 0x05B41DDBEB559556,
        POINT_CAM_AT_COORD = 0x948B39341C3A40C2,
        POINT_CAM_AT_ENTITY = 0xFC2867E6074D3A61,
        STOP_CAM_POINTING = 0xCA1B30A3357C71F1,
        _SET_CAM_FOCUS_DISTANCE = 0x11F32BB61B756732,
        SET_CAM_SPLINE_PHASE = 0xF1898A68E7C15636,
        SET_CAM_SPLINE_DURATION = 0xFF6311652CA91015,
        SET_CAM_SPLINE_SMOOTHING_STYLE = 0x84B3645618E726B0,
        SET_CAM_ACTIVE_WITH_INTERP = 0x8B15AE2987C1AC8F,
        IS_CAM_INTERPOLATING = 0x578F8F1CAA17BD2B,
        SHAKE_CAM = 0xF9A7BCF5D050D4E7,
        IS_CAM_SHAKING = 0x2EEB402BD7320159,
        STOP_CAM_SHAKING = 0xB78CC4B4706614B0,
        PLAY_CAM_ANIM = 0xA263DDF694D563F6,
        IS_SCREEN_FADED_OUT = 0xF5472C80DF2FF847,
        IS_SCREEN_FADED_IN = 0x37F9A426FBCF4AF2,
        IS_SCREEN_FADING_OUT = 0x02F39BEFE7B88D00,
        IS_SCREEN_FADING_IN = 0x0CECCC63FFA2EF24,
        SET_WIDESCREEN_BORDERS = 0xD7F4D54CF80AFA34,
        GET_GAMEPLAY_CAM_COORD = 0x595320200B98596E,
        GET_GAMEPLAY_CAM_ROT = 0x0252D2B5582957A6,
        GET_GAMEPLAY_CAM_FOV = 0xF6A96E5ACEEC6E50,
        GET_GAMEPLAY_CAM_RELATIVE_HEADING = 0xC4ABF536048998AA,
        GET_GAMEPLAY_CAM_RELATIVE_PITCH = 0x99AADEBBA803F827,
        SHAKE_GAMEPLAY_CAM = 0xD9B31B4650520529,
        IS_GAMEPLAY_CAM_SHAKING = 0xEA4C5F4AA0A4DBEF,
        STOP_GAMEPLAY_CAM_SHAKING = 0xE0DE43D290FB65F9,
        SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE = 0x82E41D6ADE924FCA,
        IS_GAMEPLAY_CAM_RENDERING = 0x8660EA714834E412,
        IS_GAMEPLAY_CAM_LOOKING_BEHIND = 0x8FE0D24FFD04D5A2,
        _DISABLE_CAM_COLLISION_FOR_ENTITY = 0xD904F75DBD7AB865,
        DISABLE_CAM_COLLISION_FOR_OBJECT = 0x7E3F546ACFE6C8D9,
        IS_SPHERE_VISIBLE = 0x2E941B5FFA2989C6,
        _ANIMATE_GAMEPLAY_CAM_ZOOM = 0x2126C740A4AC370B,
        SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE = 0xFA1D5E8D1C3CCD67,
        _DISABLE_FIRST_PERSON_CAM_THIS_FRAME = 0x9C473089A934C930,
        IS_FOLLOW_VEHICLE_CAM_ACTIVE = 0xA40C2F51FB589E9A,
        IS_AIM_CAM_ACTIVE = 0x698F456FB909E077,
        IS_FIRST_PERSON_AIM_CAM_ACTIVE = 0xF63134C54B6EC212,
        IS_FIRST_PERSON_CAMERA_ACTIVE = 0xA24C1D341C6E0D53,
        GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR = 0xB4132CA1B0EE1365,
        _SET_FIRST_PERSON_CAM_PITCH_RANGE = 0x715B7F5E8BED32A2,
        GET_FINAL_RENDERED_CAM_COORD = 0x5352E025EC2B416F,
        GET_FINAL_RENDERED_CAM_ROT = 0x602685BD85DD26CA,
        GET_FINAL_RENDERED_CAM_FOV = 0x04AF77971E508F6A,
        SET_GAMEPLAY_COORD_HINT = 0xFA33B8C69A4A6A0F,
        SET_GAMEPLAY_PED_HINT = 0x90FB951648851733,
        SET_GAMEPLAY_VEHICLE_HINT = 0xE2B2BB7DAC280515,
        SET_GAMEPLAY_OBJECT_HINT = 0xC40551D65F2BF297,
        IS_GAMEPLAY_HINT_ACTIVE = 0x2E04AB5FEE042D4A,
        STOP_GAMEPLAY_HINT = 0x1BCEC33D54CFCA8A,
        SET_GAMEPLAY_HINT_FOV = 0x661E58BC6F00A49A,
        SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR = 0xDDDC54181868F81F,
        SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET = 0x421192A2DA48FD01,
        _SET_GAMEPLAY_HINT_ANIM_OFFSETX = 0xF86B6F93727C59C9,
        _SET_GAMEPLAY_HINT_ANIM_OFFSETY = 0x29E74F819150CC32,
        _FREEZE_GAMEPLAY_CAM_THIS_FRAME = 0x027CAB2C3AF27010,
        SET_CINEMATIC_BUTTON_ACTIVE = 0xB90411F480457A6C,
        IS_CINEMATIC_CAM_RENDERING = 0xBF7C780731AADBF8,
        _DISABLE_VEHICLE_FIRST_PERSON_CAM_THIS_FRAME = 0xA5929C2E57AC90D1,
        _INVALIDATE_VEHICLE_IDLE_CAM = 0x634F4A0562CF19B8,
        FORCE_CINEMATIC_RENDERING_THIS_UPDATE = 0x702B75DC9D3EDE56,
        SET_CINEMATIC_MODE_ACTIVE = 0xCE7A90B160F75046,
        _TRIGGER_MISSION_FAILED_CAM = 0x9A92C06ACBAF9731,
        IS_DEATH_FAIL_CAMERA_RUNNING = 0x139EFB0A71DD9011,
        CINEMATIC_LOCATION_TRIGGER_SCRIPTED_SHOT_EVENT = 0x02389579A53C3276,
        CINEMATIC_LOCATION_STOP_SCRIPTED_SHOT_EVENT = 0x6D4D25C2137FF511,
        _GET_PHOTO_MODE_FOCAL_LENGTH = 0x2533BAFFBE737E54,
        _GET_PHOTO_MODE_FOCUS_DISTANCE = 0x18FC740FFDCD7454,
        _GET_PHOTO_MODE_DOF = 0x4653A741D17F2CD0,
        _0xFC3F638BE2B6BB02 = 0xFC3F638BE2B6BB02,
        _0xE4B7945EF4F1BFB2 = 0xE4B7945EF4F1BFB2,
        _0x1FC6C727D30FFDDE = 0x1FC6C727D30FFDDE,
        _0x9F97E85EC142255E = 0x9F97E85EC142255E,
        _0x42ED56B02E05D109 = 0x42ED56B02E05D109,
        _0xCF69EA05CD9C33C9 = 0xCF69EA05CD9C33C9,
        _0x20389408F0E93B9A = 0x20389408F0E93B9A,
        _0x81DCFD13CF39920E = 0x81DCFD13CF39920E,
        _0x69D65E89FFD72313 = 0x69D65E89FFD72313,
        _0xE296208C273BD7F0 = 0xE296208C273BD7F0,
        _0xC64ABC0676AF262B = 0xC64ABC0676AF262B,
        _0xA2B1C7EF759A63CE = 0xA2B1C7EF759A63CE,
        _0x73FF6BE63DC18819 = 0x73FF6BE63DC18819,
        _0x450769C833D58844 = 0x450769C833D58844,
        _0x8459B3E64257B21D = 0x8459B3E64257B21D,
        _0x0961B089947BA6D0 = 0x0961B089947BA6D0,
        _0x04084490CC302CFB = 0x04084490CC302CFB,
        _0x1DD95A8D6B24A0C9 = 0x1DD95A8D6B24A0C9,
        _0xC3E9E5D4F413B773 = 0xC3E9E5D4F413B773,
        _0x0060B31968E60E41 = 0x0060B31968E60E41,
        _0xFEFDDC6E8FDF8A75 = 0xFEFDDC6E8FDF8A75,
        _0x4285804FD65D8066 = 0x4285804FD65D8066,
        _0x251241CAEC707106 = 0x251241CAEC707106,
        _0x43AB9D5A7D415478 = 0x43AB9D5A7D415478,
        _0x39073DA4EDDBC91D = 0x39073DA4EDDBC91D,
        _0x70A6658D476C6187 = 0x70A6658D476C6187,
        _0x18C3DFAC458783BB = 0x18C3DFAC458783BB,
        _0xF1A6FEEDF3776EF9 = 0xF1A6FEEDF3776EF9,
        _0xE6F364DE6C2FDEFE = 0xE6F364DE6C2FDEFE,
        _0x0F1FFEF5D54AE832 = 0x0F1FFEF5D54AE832,
        _0x3C8F74E8FE751614 = 0x3C8F74E8FE751614,
        _0x06557F6D96C86881 = 0x06557F6D96C86881,
        _0x190F7DA1AC09A8EF = 0x190F7DA1AC09A8EF,
        _0xBCDA0BA8762FACB9 = 0xBCDA0BA8762FACB9,
        _0x6C1053C433A573CF = 0x6C1053C433A573CF,
        _0x449995EA846D3FC2 = 0x449995EA846D3FC2,
        _0x8910C24B7E0046EC = 0x8910C24B7E0046EC,
        _0x74F1D22EFA71FAB8 = 0x74F1D22EFA71FAB8,
        _0x718C6ECF5E8CBDD4 = 0x718C6ECF5E8CBDD4,
        _0x8370D34BD2E60B73 = 0x8370D34BD2E60B73,
        _0x1CFB749AD4317BDE = 0x1CFB749AD4317BDE,
        _0x90DA5BA5C2635416 = 0x90DA5BA5C2635416,
        _0x632BE8D84846FA56 = 0x632BE8D84846FA56,
        _0x71D71E08A7ED5BD7 = 0x71D71E08A7ED5BD7,
        _0x7E40A01B11398FCB = 0x7E40A01B11398FCB,
        _0xDC62CD70658E7A02 = 0xDC62CD70658E7A02,
        _0x796085220ADCC847 = 0x796085220ADCC847,
        _0xB6A80E1E3A5444F1 = 0xB6A80E1E3A5444F1,
        _0x8B1A5FE7E41E52B2 = 0x8B1A5FE7E41E52B2,
        _0x05BD5E4088B30A66 = 0x05BD5E4088B30A66,
        _0xC205B3C54C6A4E37 = 0xC205B3C54C6A4E37,
        _0x93759A83D0D844E7 = 0x93759A83D0D844E7,
        _0x88544C0E3291DCAE = 0x88544C0E3291DCAE,
        _0xF48664E9C83825E3 = 0xF48664E9C83825E3,
        _0x1F6EBD94680252CE = 0x1F6EBD94680252CE,
        _0xE28F73212A813E82 = 0xE28F73212A813E82,
        _0x4D2F46D1B28D90FB = 0x4D2F46D1B28D90FB,
        _0x65B205BF30C13DDB = 0x65B205BF30C13DDB,
        _0x641092322A8852AB = 0x641092322A8852AB,
        _0xDB382FE20C2DA222 = 0xDB382FE20C2DA222,
        _0x2DD3149DC34A3F4C = 0x2DD3149DC34A3F4C,
        _0x3C486E334520579D = 0x3C486E334520579D,
        _0x41E452A3C580D1A7 = 0x41E452A3C580D1A7,
        _0x9AC65A36D3C0C189 = 0x9AC65A36D3C0C189,
        _0x975F6EBB62632FE3 = 0x975F6EBB62632FE3,
        _0x1811A02277A9E49D = 0x1811A02277A9E49D,
        _0xE3639DB78B3B5400 = 0xE3639DB78B3B5400,
        _0x986F7A51EE3E1F92 = 0x986F7A51EE3E1F92,
        _0x5B637D6F3B67716A = 0x5B637D6F3B67716A,
        _0xC252C0CC969AF79A = 0xC252C0CC969AF79A,
        _0xE2BB2D6A9FE2ECDE = 0xE2BB2D6A9FE2ECDE,
        _0x6E969927CF632608 = 0x6E969927CF632608,
        _0x6072B7420A83A03F = 0x6072B7420A83A03F,
        _0x1204EB53A5FBC63D = 0x1204EB53A5FBC63D,
        _0x6519238858AF5479 = 0x6519238858AF5479,
        _0x2F994CC29CAA9D22 = 0x2F994CC29CAA9D22,
        _0xA14D5FE82BCB1D9E = 0xA14D5FE82BCB1D9E,
        _0x6DFD37E586D4F44F = 0x6DFD37E586D4F44F,
        _0x80D7A3E39B120BC4 = 0x80D7A3E39B120BC4,
        _0x63E5841A9264D016 = 0x63E5841A9264D016,
        _0x16E9ABDD34DDD931 = 0x16E9ABDD34DDD931,
        _0x7CE9DC58E3E4755F = 0x7CE9DC58E3E4755F,
        _0x3B8E3AD9677CE12B = 0x3B8E3AD9677CE12B,
        _0xDF7F5BE9150E47E4 = 0xDF7F5BE9150E47E4,
        _0xB85C13E0BF1F2A1C = 0xB85C13E0BF1F2A1C,
        _0x066167C63111D8CF = 0x066167C63111D8CF,
        _0xA8BA2E0204D8486F = 0xA8BA2E0204D8486F,
        _0xC3742F1FDF0A6824 = 0xC3742F1FDF0A6824,
        _0x0FF7125F07DEB84F = 0x0FF7125F07DEB84F,
        _0x6CAB0BA160B168D2 = 0x6CAB0BA160B168D2,
        _0x1B3C2D961F5FC0E1 = 0x1B3C2D961F5FC0E1,
        _0x2412216FCC7B4E3E = 0x2412216FCC7B4E3E,
        _0xAA235E2F2C09E952 = 0xAA235E2F2C09E952,
        _0x595550376B7EA230 = 0x595550376B7EA230,
        _0x465F04F68AD38197 = 0x465F04F68AD38197,
        _0xEA113BF9B0C0C5D7 = 0xEA113BF9B0C0C5D7,
        _0xBC016635D6A73B31 = 0xBC016635D6A73B31,
        _0xA54D643D0773EB65 = 0xA54D643D0773EB65,
        _0xC3AEBB276825A359 = 0xC3AEBB276825A359,
        _0x1D931B7CC0EE3956 = 0x1D931B7CC0EE3956,
        _0x0E94C95EC3185FA9 = 0x0E94C95EC3185FA9,
        _0x0B0F914459731F60 = 0x0B0F914459731F60,
        _0x6A4D224FC7643941 = 0x6A4D224FC7643941,
        _0x798BE43C9393632B = 0x798BE43C9393632B,
        _0xDD0B7C5AE58F721D = 0xDD0B7C5AE58F721D,
        _0xC285FD21294A1C49 = 0xC285FD21294A1C49,
        _0xB8B207C34285E978 = 0xB8B207C34285E978,
        _0x0A5A4F1979ABB40E = 0x0A5A4F1979ABB40E,
        _0x927B810E43E99932 = 0x927B810E43E99932,
        _0x4138EE36BC3DC0A7 = 0x4138EE36BC3DC0A7,
        _0xFEB8646818294C75 = 0xFEB8646818294C75,
        _0x29E6655DF3590B0D = 0x29E6655DF3590B0D,
        _0xAC77757C05DE9E5A = 0xAC77757C05DE9E5A,
        _0x8E036B41C37D0E5F = 0x8E036B41C37D0E5F,
        _0x1D9F72DD4FD9A9D7 = 0x1D9F72DD4FD9A9D7,
        _0x7B0279170961A73F = 0x7B0279170961A73F,
        _0x728491FB3DFFEF99 = 0x728491FB3DFFEF99,
        _0x14C4A49E36C29E49 = 0x14C4A49E36C29E49,
        _0xF824530B612FE0CE = 0xF824530B612FE0CE,
        _0xEF9A3132A0AA6B19 = 0xEF9A3132A0AA6B19,
        _0x5060FA977CEA4455 = 0x5060FA977CEA4455,
        _0x2AB7C81B3F70570C = 0x2AB7C81B3F70570C,
        _0x8505E05FC8822843 = 0x8505E05FC8822843,
    }
    public static class NATIVE_CAM_EXTENSIONS
    {
        public static void Call(this NATIVE_CAM hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_CAM hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}