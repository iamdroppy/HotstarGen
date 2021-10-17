using System;
namespace Hotstar
{
    public enum NATIVE_GRAPHICS : ulong
    { 
        /// <summary>
        /// Always returns 200.
        ///
        ///
        /// </summary>
        _GET_MAX_NUMBER_OF_LOCAL_PHOTOS = 0x8E587FCD30E05592,
        /// <summary>
        /// type must be less than or equal to 20
        ///
        /// > Entity entity
        /// > int type
        ///
        /// </summary>
        _SET_LIGHTS_TYPE_FOR_ENTITY = 0xAB72C67163DC4DB4,
        /// <summary>
        /// Sets the checkpoint color.
        ///
        /// > int checkpoint
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        SET_CHECKPOINT_RGBA = 0xCAAFC225E33B1D15,
        /// <summary>
        /// Sets the checkpoint icon color.
        ///
        /// > int checkpoint
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        SET_CHECKPOINT_RGBA2 = 0x99AFF17222D4DEB4,
        /// <summary>
        /// Draws a rectangle on the screen.
        /// 
        /// -x: The relative X point of the center of the rectangle. (0.0-1.0, 0.0 is the left edge of the screen, 1.0 is the right edge of the screen)
        /// 
        /// -y: The relative Y point of the center of the rectangle. (0.0-1.0, 0.0 is the top edge of the screen, 1.0 is the bottom edge of the screen)
        /// 
        /// -width: The relative width of the rectangle. (0.0-1.0, 1.0 means the whole screen width)
        /// 
        /// -height: The relative height of the rectangle. (0.0-1.0, 1.0 means the whole screen height)
        /// 
        /// -R: Red part of the color. (0-255)
        /// 
        /// -G: Green part of the color. (0-255)
        /// 
        /// -B: Blue part of the color. (0-255)
        /// 
        /// -A: Alpha part of the color. (0-255, 0 means totally transparent, 255 means totally opaque)
        ///
        /// > float x
        /// > float y
        /// > float width
        /// > float height
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > BOOL p8
        /// > BOOL p9
        ///
        /// </summary>
        DRAW_RECT = 0x405224591DF02025,
        /// <summary>
        /// Sets a flag defining whether or not script draw commands should continue being drawn behind the pause menu. This is usually used for draw commands that are used with a world render target.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU = 0x906B86E6D7896B9E,
        /// <summary>
        /// Sets the draw order for script draw commands.
        ///
        /// > int drawOrder
        ///
        /// </summary>
        SET_SCRIPT_GFX_DRAW_ORDER = 0xCFCC78391C8B3814,
        /// <summary>
        /// Draws a 2D sprite on the screen.
        /// 
        /// Parameters:
        /// textureDict - Name of texture dictionary to load texture from
        /// 
        /// textureName - Name of texture to load from texture dictionary
        /// 
        /// screenX/Y - Screen offset (0.5 = center)
        /// scaleX/Y - Texture scaling. Negative values can be used to flip the texture on that axis. (0.5 = half)
        /// 
        /// heading - Texture rotation in degrees (default = 0.0) positive is clockwise, measured in degrees
        /// 
        /// red,green,blue - Sprite color (default = 255/255/255)
        /// 
        /// alpha - opacity level
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > float screenX
        /// > float screenY
        /// > float width
        /// > float height
        /// > float heading
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > BOOL p11
        ///
        /// </summary>
        DRAW_SPRITE = 0xC9884ECADE94CB34,
        /// <summary>
        /// Probably changes tvs from being a 3d audio to being "global" audio
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_TV_AUDIO_FRONTEND = 0x64437C98FCC5F291,
        /// <summary>
        /// Hardcoded to always set x to 1280 and y to 720.
        ///
        /// > int* x
        /// > int* y
        ///
        /// </summary>
        GET_SCREEN_RESOLUTION = 0x66773C92835D0909,
        /// <summary>
        /// Does not affect weapons, particles, fire/explosions, flashlights or the sun.
        /// When set to true, all emissive textures (including ped components that have light effects), street lights, building lights, vehicle lights, etc will all be turned off.
        /// 
        /// state: True turns off all artificial light sources in the map: buildings, street lights, car lights, etc. False turns them back on.
        ///
        /// > BOOL state
        ///
        /// </summary>
        SET_ARTIFICIAL_LIGHTS_STATE = 0xB2797619A7C7747B,
        /// <summary>
        /// Creates a tracked point, useful for checking the visibility of a 3D point on screen.
        ///
        ///
        /// </summary>
        CREATE_TRACKED_POINT = 0xFB405CB357C69CB9,
        /// <summary>
        /// Example: https://pastebin.com/tTgpER9A
        ///
        /// > int slot
        /// > Any p1
        ///
        /// </summary>
        _GENERATE_SWATCH_TEXTURE_DIRECTLY = 0x646ED1A1D28487DF,
        /// <summary>
        /// Example:
        /// local hash = GetHashKey("CLOTHING_ITEM_M_EYES_001_TINT_001")
        /// _GENERATE_SWATCH_TEXTURE(0, hash, 0, true)
        ///
        /// > int slotId
        /// > Hash componentHash
        /// > int p2
        /// > BOOL p3
        ///
        /// </summary>
        _GENERATE_SWATCH_TEXTURE = 0x160921255327C591,
        /// <summary>
        /// When this is set to ON, shadows only draw as you get nearer.
        /// 
        /// When OFF, they draw from a further distance.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER = 0x8FBFD2AEB196B369,
        /// <summary>
        /// Possible values:
        /// "CSM_ST_POINT"
        /// "CSM_ST_LINEAR"
        /// "CSM_ST_BOX3x3"
        /// "CSM_ST_BOX4x4"
        /// "CSM_ST_DITHER2_LINEAR"
        /// "CSM_ST_CUBIC"
        /// "CSM_ST_POISSON16"
        /// "CSM_ST_SOFT8"
        /// "CSM_ST_SOFT16"
        /// "CSM_ST_SOFT32"
        /// "CSM_ST_DITHER16_RPDB"
        /// "CSM_ST_POISSON16_RPDB_GNORM"
        /// "CSM_ST_HIGHRES_BOX4x4"
        /// "CSM_ST_ESM"
        ///
        /// > const char* type
        ///
        /// </summary>
        CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE = 0xCE4774E0F9AD48D1,
        /// <summary>
        /// Resets the effect of SET_PARTICLE_FX_OVERRIDE
        ///
        /// > const char* name
        ///
        /// </summary>
        RESET_PARTICLE_FX_OVERRIDE = 0x274B3DABF7E72DEF,
        /// <summary>
        /// https://imgur.com/a/I2swSDJ
        /// 
        /// Old name: _SET_PICKUP_OBJECT_GLOW_ENABLED
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PICKUP_LIGHT = 0x7DFB49BCDB73089A,
        /// <summary>
        /// Enables/disables a kind of 'shiny' effect on metals.
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PEARLESCENT_FX_ENABLED = 0x72E30372E7CC4415,
        /// <summary>
        /// Removes all decals in range from a position, it includes the bullet holes, blood pools, petrol...
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float range
        ///
        /// </summary>
        REMOVE_DECALS_IN_RANGE = 0x86DE59FA02902B40,
        /// <summary>
        /// Creates blood pools for the given ped in some interval for a few seconds.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _ADD_BLOOD_POOLS_FOR_PED = 0xDFCE8CE9F3EBE93F,
        /// <summary>
        /// ENABLE_*
        ///
        /// > float strength
        ///
        /// </summary>
        _SET_EXTRA_TIMECYCLE_MODIFIER_STRENGTH = 0x6FE93BCC7BF12B63,
        /// <summary>
        /// IS_*
        ///
        /// > Hash videoCliphash
        ///
        /// </summary>
        _IS_TV_PLAYLIST_ITEM_PLAYING = 0x4D562223E0EB65F3,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_MOVIE_SUBTITLES = 0x6FC9B065229C0787,
        /// <summary>
        /// enum class eSnowCoverageType
        /// {
        /// 	Primary,
        /// 	Secondary,
        /// 	Xmas,
        /// 	XmasSecondary // since b1232
        /// };
        ///
        /// > int type
        ///
        /// </summary>
        _SET_SNOW_COVERAGE_TYPE = 0xF02A9C330BBFC5C7,
        /// <summary>
        /// 0 = Normal
        /// 1 = Trees flickering
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x1A9F09AB458D49C6 = 0x1A9F09AB458D49C6,
        /// <summary>
        /// Sets an unknown value related to timecycles.
        ///
        /// > int unk
        ///
        /// </summary>
        _0x297B72E2AF094742 = 0x297B72E2AF094742,
        /// <summary>
        /// SET_TRA*
        ///
        /// > float strength
        ///
        /// </summary>
        _0xBB6C707F20D955D4 = 0xBB6C707F20D955D4,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0x5199405EABFBD7F0 = 0x5199405EABFBD7F0,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0xBF2DD155B2ADCD0A = 0xBF2DD155B2ADCD0A,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0x37D7BDBA89F13959 = 0x37D7BDBA89F13959,
        /// <summary>
        /// effectName2, p2 and p3 are unused
        /// 
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        /// > const char* effectName2
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        _0x26DD2FB0A88CC412 = 0x26DD2FB0A88CC412,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0xC5CB91D65852ED7E = 0xC5CB91D65852ED7E,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0x2D4F9C852CE8A253 = 0x2D4F9C852CE8A253,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0xAD74C22A541AB987 = 0xAD74C22A541AB987,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        /// > float strength
        ///
        /// </summary>
        _0xCAB4DD2D5B2B7246 = 0xCAB4DD2D5B2B7246,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        /// > int p1
        /// > float p2
        ///
        /// </summary>
        _0xF972F0AB16DC5260 = 0xF972F0AB16DC5260,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        /// > int p1
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        _0x63011D0C7C6519E0 = 0x63011D0C7C6519E0,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0xB958D97A0DFAA0C2 = 0xB958D97A0DFAA0C2,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0xA201A3D0AC087C37 = 0xA201A3D0AC087C37,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > const char* effectName
        /// > int p1
        /// > BOOL p2
        /// > BOOL* p3
        ///
        /// </summary>
        _0xFBF161FCFEC8589E = 0xFBF161FCFEC8589E,
        /// <summary>
        /// ANIMPOSTFX_*
        /// 
        /// Known effects: MP_Trans_SceneToPhoto
        /// MP_Trans_WinLose
        /// SpectateFilter
        /// MP_CharacterCreatorPhoto
        /// MP_Trans_PhotoToScene
        /// InterrogationHit
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _0x842CCC9491FFCD9B = 0x842CCC9491FFCD9B,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0xF3E039322BFBD4D8 = 0xF3E039322BFBD4D8,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0x38D9D50F2085E9B3 = 0x38D9D50F2085E9B3,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0x9B8D5D4CB8AF58B3 = 0x9B8D5D4CB8AF58B3,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0xC76FC4C2FC5F4405 = 0xC76FC4C2FC5F4405,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0xEDA5CBECF56E1386 = 0xEDA5CBECF56E1386,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0xEEF83A759AE06A27 = 0xEEF83A759AE06A27,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0xE75CDDEBF618C8FF = 0xE75CDDEBF618C8FF,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        /// > Hash effectNameHash
        ///
        /// </summary>
        _0x71845905BCCDE781 = 0x71845905BCCDE781,
        /// <summary>
        /// Returns whether the 'killFX' setting is enabled.
        /// 
        /// ANIMPOSTFX_*
        ///
        ///
        /// </summary>
        _0xFF584F097C17FA8F = 0xFF584F097C17FA8F,
        /// <summary>
        /// ANIMPOSTFX_*
        ///
        ///
        /// </summary>
        _0x3DA7A10583A4BEC0 = 0x3DA7A10583A4BEC0,
        /// <summary>
        /// Doesn't actually return anything.
        /// 
        /// ANIMPOSTFX_*
        ///
        ///
        /// </summary>
        _0xC37792A3F9C90771 = 0xC37792A3F9C90771,
        /// <summary>
        /// Returns proxyInteriorIndex
        ///
        /// > int interiorId
        ///
        /// </summary>
        _0x5D1C5D8E62E8EE1C = 0x5D1C5D8E62E8EE1C,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x94B261F1F35293E1 = 0x94B261F1F35293E1,
        FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO = 0x7DFF8F94937D2659,
        LOAD_MISSION_CREATOR_PHOTO = 0x84F0BA7462FF8D58,
        GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO = 0xC71B50AE58D07369,
        BEGIN_TAKE_HIGH_QUALITY_PHOTO = 0xA15BFFC0A01B34E1,
        GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO = 0x4A3DA74C3CCB1725,
        FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO = 0xD45547D8396F002A,
        SAVE_HIGH_QUALITY_PHOTO = 0x57639FD876B68A91,
        GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO = 0xD6663EC374092383,
        FREE_MEMORY_FOR_LOW_QUALITY_PHOTO = 0x614682E715ADBAAC,
        DRAW_LOW_QUALITY_PHOTO_TO_PHONE = 0xF1142E5D64B47802,
        _GET_CURRENT_NUMBER_OF_LOCAL_PHOTOS = 0x78C56B8A7B1D000C,
        GET_STATUS_OF_SORTED_LIST_OPERATION = 0xB28894CD7408BD0C,
        DRAW_LIGHT_WITH_RANGE = 0xD2D9E04C0DF927F4,
        UPDATE_LIGHTS_ON_ENTITY = 0xBDBACB52A03CC760,
        _SET_LIGHTS_COLOR_FOR_ENTITY = 0x6EC2A67962296F49,
        _SET_LIGHTS_INTENSITY_FOR_ENTITY = 0x07C0F87AAC57F2E4,
        _DRAW_MARKER = 0x2A32FAA57B937173,
        CREATE_CHECKPOINT_WITH_NAMEHASH = 0x175668836B44CBB0,
        DELETE_CHECKPOINT = 0x0DED5B0C8EBAAE12,
        ATTACH_TV_AUDIO_TO_ENTITY = 0x40866A418EB8EFDE,
        GET_SCREEN_COORD_FROM_WORLD_COORD = 0xCB50D7AFCC8B0EC6,
        SET_TRACKED_POINT_INFO = 0xF6FDA3D4404D4F2C,
        IS_TRACKED_POINT_VISIBLE = 0xCBB056BA159FB48D,
        DESTROY_TRACKED_POINT = 0x37A59922109F8F1C,
        _IS_TRACKED_POINT_VALID = 0xF2FDDCC8C6BAE1B3,
        ADD_VEG_MODIFIER_SPHERE = 0xFA50F79257745E74,
        REMOVE_VEG_MODIFIER_SPHERE = 0x9CF1836C03FB67A2,
        _ENABLE_STATIC_VEG_MODIFIER = 0xDFEA23EC90113657,
        _DISABLE_STATIC_VEG_MODIFIER = 0xDD0BC0EDCB2162F6,
        _IS_STATIC_VEG_MODIFIER_ENABLED = 0xDE9BAD3292AA6D5E,
        _CREATE_SWATCH_TEXTURE_DICT = 0x3D084D5568FB4028,
        _DESTROY_SWATCH_TEXTURE_DICT = 0xDAD7FB8402651654,
        CASCADE_SHADOWS_SET_CASCADE_BOUNDS = 0xD9EDB2E4512D563E,
        CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE = 0xF7C29D7C12C36F03,
        TOGGLE_PAUSED_RENDERPHASES = 0xEF9E1C45732F55FA,
        GET_TOGGLE_PAUSED_RENDERPHASES_STATUS = 0x86ED21BDB2791CE8,
        RESET_PAUSED_RENDERPHASES = 0xCCD9AAD85E1B559E,
        _SET_HIDOF_ENV_BLUR_PARAMS = 0xCC23AA1A7CBFE840,
        _GET_PHOTO_MODE_EXPOSURE = 0x06C0D8BB6B04A709,
        _GET_PHOTO_MODE_CONTRAST = 0x98F4154989B81EC6,
        START_PARTICLE_FX_NON_LOOPED_AT_COORD = 0x2E80BF72EF7C87AC,
        START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD = 0xFB97618457994A62,
        START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE = 0x3FAA72BD940C3AC0,
        START_PARTICLE_FX_NON_LOOPED_ON_ENTITY = 0xFF4C64C513388C12,
        START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY = 0xE6CFE43937061143,
        _START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE_2 = 0xC695870B8A149B96,
        SET_PARTICLE_FX_NON_LOOPED_COLOUR = 0x60B85BED6577A35B,
        SET_PARTICLE_FX_NON_LOOPED_ALPHA = 0xE8A35938A7026CEA,
        _SET_PARTICLE_FX_NON_LOOPED_EMITTER_SCALE = 0x56C392C2BD78B024,
        START_PARTICLE_FX_LOOPED_AT_COORD = 0xBA32867E86125D3A,
        START_PARTICLE_FX_LOOPED_ON_PED_BONE = 0xE689C1B1432BB8AF,
        START_PARTICLE_FX_LOOPED_ON_ENTITY = 0xBD41E1440CE39800,
        START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE = 0xD3BA6EC7F2FBD5E9,
        START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY = 0x8F90AB32E1944BDE,
        START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE = 0x9C56621462FFE7A6,
        STOP_PARTICLE_FX_LOOPED = 0x22970F3A088B133B,
        DOES_PARTICLE_FX_LOOPED_EXIST = 0x9DD5AFF561E88F2A,
        SET_PARTICLE_FX_LOOPED_OFFSETS = 0xD3A4A95FC94FE83B,
        SET_PARTICLE_FX_LOOPED_EVOLUTION = 0x3674F389B0FACD80,
        SET_PARTICLE_FX_LOOPED_COLOUR = 0x239879FC61C610CC,
        SET_PARTICLE_FX_LOOPED_ALPHA = 0x88786E76234F7054,
        SET_PARTICLE_FX_LOOPED_SCALE = 0x1A9E1C0D98D093B7,
        SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST = 0x9B04D471DA0AD7AA,
        REMOVE_PARTICLE_FX = 0x459598F579C98929,
        REMOVE_PARTICLE_FX_FROM_ENTITY = 0x92884B4A49D81325,
        REMOVE_PARTICLE_FX_IN_RANGE = 0x87B5905ECA623B68,
        USE_PARTICLE_FX_ASSET = 0xA10DB07FC234DD12,
        SET_PARTICLE_FX_OVERRIDE = 0xBE711A169E9C7E95,
        SET_PARTICLE_FX_BULLET_IMPACT_SCALE = 0xA53C8D7D0F8C74D0,
        _BLOCK_PICKUP_OBJECT_LIGHT = 0x50C14328119E1DD1,
        BLOCK_PICKUP_PLACEMENT_LIGHT = 0x0552AA3FFC5B87AA,
        ALLOW_PICKUP_LIGHT_SYNC = 0x7C348310A6E2FB91,
        REMOVE_DECALS_FROM_OBJECT = 0xFB8972BAE0013140,
        ADD_DECAL = 0x57CB267624EF85C0,
        _ADD_BLOOD_POOL = 0xFA2ECC78A6014D4F,
        _ADD_BLOOD_POOL_2 = 0xF708298675ABDC6A,
        _ADD_BLOOD_POOLS_FOR_PED_WITH_PARAMS = 0xC349EE1E6EFA494B,
        START_PETROL_TRAIL_DECALS = 0x46F246D6504F0031,
        ADD_PETROL_TRAIL_DECAL_INFO = 0x73354FB6D03D2E8A,
        END_PETROL_TRAIL_DECALS = 0x0E126AAE933F3B56,
        REMOVE_DECAL = 0x49A720552EB0BB88,
        IS_DECAL_ALIVE = 0x3E4B4E5CF5D3EEB5,
        SET_TIMECYCLE_MODIFIER = 0xFA08722A5EA82DA7,
        SET_TIMECYCLE_MODIFIER_STRENGTH = 0xFDB74C9CC54C3F37,
        SET_TRANSITION_TIMECYCLE_MODIFIER = 0xFF927A09F481D80C,
        CLEAR_TIMECYCLE_MODIFIER = 0x0E3F4AF2D63491FB,
        GET_TIMECYCLE_MODIFIER_INDEX = 0xA705394293E2B3D3,
        GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX = 0x2DA67BA3C8A6755D,
        SET_TV_CHANNEL = 0x593FAF7FC9401A56,
        GET_TV_CHANNEL = 0xF90FBFD68F3C59AE,
        SET_TV_VOLUME = 0x73A97068787D7231,
        DRAW_TV_CHANNEL = 0xC0A145540254A840,
        SET_TV_CHANNEL_PLAYLIST = 0xDEC6B25F5DC8925B,
        ANIMPOSTFX_PLAY = 0x4102732DF6B4005F,
        _ANIMPOSTFX_PLAY_TIMED = 0x3A9A281FF71249E9,
        ANIMPOSTFX_STOP = 0xB4FD7446BAB2F394,
        ANIMPOSTFX_IS_RUNNING = 0x4A123E85D7C4CA0B,
        ANIMPOSTFX_STOP_ALL = 0x66560A0D4C64FD21,
        ANIMPOSTFX_IS_PRELOADING_BY_STACKHASH = 0x59EA80079B86D8C7,
        ANIMPOSTFX_HAS_EVENT_TRIGGERED_BY_STACKHASH = 0x9AB192A9EF980EED,
        PEDSHOT_IS_AVAILABLE = 0xAF6E67D073D2DCE2,
        _SET_CLOUD_LAYER = 0xB8C984C0D47F4F07,
        _SET_CLOUD_NOISE = 0xFE7966DF01452F32,
        _SET_CLOUD_HEIGHT = 0xC332C91388F5580B,
        ENABLE_ENTITYMASK = 0xFAAD23DE7A54FC14,
        DISABLE_ENTITYMASK = 0x5C9978A2A3DC3D0D,
        _ADD_ENTITY_TO_ENTITY_MASK = 0xC6F81FCD15350323,
        _ADD_ENTITY_TO_ENTITY_MASK_WITH_INTENSITY = 0x958DEBD9353C0935,
        _REMOVE_ENTITY_FROM_ENTITY_MASK = 0x56A786E87FF53478,
        _0x2705D18C11B61046 = 0x2705D18C11B61046,
        _0x8E6AFF353C09652E = 0x8E6AFF353C09652E,
        _0x564837D4A9EDE296 = 0x564837D4A9EDE296,
        _0x9F6D859C80708B26 = 0x9F6D859C80708B26,
        _0x86076AE35CBBE55F = 0x86076AE35CBBE55F,
        _0xFA91736933AB3D93 = 0xFA91736933AB3D93,
        _0x8B3296278328B5EB = 0x8B3296278328B5EB,
        _0x0D5B19C34068FEE7 = 0x0D5B19C34068FEE7,
        _0x75D568607909333E = 0x75D568607909333E,
        _0xD1031B83AC093BC7 = 0xD1031B83AC093BC7,
        _0x9937FACBBF267244 = 0x9937FACBBF267244,
        _0x8952E857696B8A79 = 0x8952E857696B8A79,
        _0x494A9874F17A7D50 = 0x494A9874F17A7D50,
        _0x13430D3D5A45F14B = 0x13430D3D5A45F14B,
        _0xA42EDF1E88734A7E = 0xA42EDF1E88734A7E,
        _0x4C11CCACB7C02B6E = 0x4C11CCACB7C02B6E,
        _0xCC3B787E73E64160 = 0xCC3B787E73E64160,
        _0x171C18E994C1A395 = 0x171C18E994C1A395,
        _0xA04EF43030593ABC = 0xA04EF43030593ABC,
        _0xA21AF60C9F99CCC5 = 0xA21AF60C9F99CCC5,
        _0xC28F62AC9774FC1B = 0xC28F62AC9774FC1B,
        _0xEB48CE48EEC41FD4 = 0xEB48CE48EEC41FD4,
        _0xA2A51869BDED733B = 0xA2A51869BDED733B,
        _0x98A7CD5EA379A854 = 0x98A7CD5EA379A854,
        _0xDFE332A5DA6FE7C9 = 0xDFE332A5DA6FE7C9,
        _0x27219300C36A8D40 = 0x27219300C36A8D40,
        _0xAE7BF7CA9E4BA48D = 0xAE7BF7CA9E4BA48D,
        _0xBD3324281E8B9933 = 0xBD3324281E8B9933,
        _0xEC3F7F24EEEB3BA3 = 0xEC3F7F24EEEB3BA3,
        _0x9F158A49B0D84C3C = 0x9F158A49B0D84C3C,
        _0x910E260AEAD855DE = 0x910E260AEAD855DE,
        _0x503941F65DBA24EC = 0x503941F65DBA24EC,
        _0x815653A42C5ABE76 = 0x815653A42C5ABE76,
        _0xFF8018C778349234 = 0xFF8018C778349234,
        _0x21F00E08CBB5F37B = 0x21F00E08CBB5F37B,
        _0x5AC6E0FA028369DE = 0x5AC6E0FA028369DE,
        _0xEC3D8C228FE553D7 = 0xEC3D8C228FE553D7,
        _0xF5793BB386E1FF9C = 0xF5793BB386E1FF9C,
        _0x5CD6A2CCE5087161 = 0x5CD6A2CCE5087161,
        _0xC8D0611D9A0CF5D3 = 0xC8D0611D9A0CF5D3,
        _0x62B9F9A1272AED80 = 0x62B9F9A1272AED80,
        _0x9229ED770975BD9E = 0x9229ED770975BD9E,
        _0x9DDC222D85D5AF2A = 0x9DDC222D85D5AF2A,
        _0x4FB67D172C4476F3 = 0x4FB67D172C4476F3,
        _0x3C61B52B00848C26 = 0x3C61B52B00848C26,
        _0xD1472AFF30C103D6 = 0xD1472AFF30C103D6,
        _0x8DCCC98DC0DBF9E4 = 0x8DCCC98DC0DBF9E4,
        _0x6E8EB45A4F4460EB = 0x6E8EB45A4F4460EB,
        _0x2A1625858887D4E6 = 0x2A1625858887D4E6,
        _0x4046493D2EEACA0E = 0x4046493D2EEACA0E,
        _0xE63D68F455CA0B47 = 0xE63D68F455CA0B47,
        _0x53ED07BF368EDA59 = 0x53ED07BF368EDA59,
        _0xB032C085D9A03907 = 0xB032C085D9A03907,
        _0xFB680A9B33D0EDBE = 0xFB680A9B33D0EDBE,
        _0x41F88A85A579A61D = 0x41F88A85A579A61D,
        _0xB9C92616929CC25D = 0xB9C92616929CC25D,
        _0xDD9DC1AB63D513CE = 0xDD9DC1AB63D513CE,
        _0x812C1563185C6FB2 = 0x812C1563185C6FB2,
        _0x4BD66B4E3427689B = 0x4BD66B4E3427689B,
        _0xF5E45CB1CF965D2D = 0xF5E45CB1CF965D2D,
        _0xF2F543D48F319A3A = 0xF2F543D48F319A3A,
        _0x1460B644397453EB = 0x1460B644397453EB,
        _0xCD284E2F6AC27EE9 = 0xCD284E2F6AC27EE9,
        _0x453D16D41FC51D3E = 0x453D16D41FC51D3E,
        _0xC06F2F45A73EABCD = 0xC06F2F45A73EABCD,
        _0x67B0778C62E74423 = 0x67B0778C62E74423,
        _0x6C03118E9E5C1A14 = 0x6C03118E9E5C1A14,
        _0x25CA89B2A39DCC69 = 0x25CA89B2A39DCC69,
        _0x5C674EB487891F6B = 0x5C674EB487891F6B,
        _0x32DE2BFFDA43E62A = 0x32DE2BFFDA43E62A,
        _0xD543487A1F12828F = 0xD543487A1F12828F,
        _0xD9BC98B55BCFAA9B = 0xD9BC98B55BCFAA9B,
        _0x48FE0DB54045B975 = 0x48FE0DB54045B975,
        _0x735762E8D7573E42 = 0x735762E8D7573E42,
        _0x981C7D863980FA51 = 0x981C7D863980FA51,
        _0xA0F4D12D6042F6D5 = 0xA0F4D12D6042F6D5,
        _0x8996FA6AD9FE4E90 = 0x8996FA6AD9FE4E90,
        _0xC38B4952B728397A = 0xC38B4952B728397A,
        _0xFD05B1DDE83749FA = 0xFD05B1DDE83749FA,
        _0xC2B8164C3BE871A4 = 0xC2B8164C3BE871A4,
        _0x3E2FDDBE435A8787 = 0x3E2FDDBE435A8787,
        _0x55285F885F662169 = 0x55285F885F662169,
        _0xD9C24F53631F2372 = 0xD9C24F53631F2372,
        _0x196D3ACBEBA4A44B = 0x196D3ACBEBA4A44B,
        _0xA1A86055792FB249 = 0xA1A86055792FB249,
        _0x402E1A61D2587FCD = 0x402E1A61D2587FCD,
        _0x5C9C3A466B3296A8 = 0x5C9C3A466B3296A8,
        _0xA15CCAB8AD038291 = 0xA15CCAB8AD038291,
        _0x285438C26C732F9D = 0x285438C26C732F9D,
        _0xBFCB17895BB99E4E = 0xBFCB17895BB99E4E,
        _0x113857D66A9CABE6 = 0x113857D66A9CABE6,
        _0x9D1B0B5066205692 = 0x9D1B0B5066205692,
        _0xC489FE31AC726512 = 0xC489FE31AC726512,
        _0x10C1767B93257480 = 0x10C1767B93257480,
        _0x085C5B61A0114F32 = 0x085C5B61A0114F32,
        _0x1FF8731BE1DFC0C0 = 0x1FF8731BE1DFC0C0,
        _0xFC9B53C072F418E0 = 0xFC9B53C072F418E0,
        _0xE8A8378BF651079C = 0xE8A8378BF651079C,
        _0xE92012611461A42A = 0xE92012611461A42A,
        _0x249CD6B7285536F2 = 0x249CD6B7285536F2,
        _0xAF4D239B8903FCBE = 0xAF4D239B8903FCBE,
        _0x519928DF02EB5101 = 0x519928DF02EB5101,
        _0x1C6306E5BC25C29C = 0x1C6306E5BC25C29C,
    }
    public static class NATIVE_GRAPHICS_EXTENSIONS
    {
        public static void Call(this NATIVE_GRAPHICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_GRAPHICS hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}