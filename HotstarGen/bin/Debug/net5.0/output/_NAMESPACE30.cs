using System;
namespace Hotstar
{
    public enum NATIVE__NAMESPACE30 : ulong
    { 
        /// <summary>
        /// Shows the cursor on screen for one frame.
        ///
        ///
        /// </summary>
        _SET_MOUSE_CURSOR_ACTIVE_THIS_FRAME = 0xF12E4CCAF249DC10,
        /// <summary>
        /// Changes the mouse cursor's sprite.
        /// 
        /// spriteId's: https://github.com/femga/rdr3_discoveries/tree/master/graphics/HUD/cursor_sprites#readme
        ///
        /// > int spriteId
        ///
        /// </summary>
        _SET_MOUSE_CURSOR_SPRITE = 0x7F5858AAB5A58CCE,
        /// <summary>
        /// Returns true if player is moving mouse while cursor is active
        ///
        ///
        /// </summary>
        _0x2B8B605F2A9E64BF = 0x2B8B605F2A9E64BF,
        /// <summary>
        /// Returns true if player is holding LMB while cursor is active
        ///
        ///
        /// </summary>
        _0x61CAE9D1FD055E44 = 0x61CAE9D1FD055E44,
        /// <summary>
        /// Returns true when player releases LMB if cursor is active
        ///
        ///
        /// </summary>
        _0xF7F51A57349739F2 = 0xF7F51A57349739F2,
        _0x0546B117BB17548B = 0x0546B117BB17548B,
    }
    public static class NATIVE__NAMESPACE30_EXTENSIONS
    {
        public static void Call(this NATIVE__NAMESPACE30 hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE__NAMESPACE30 hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}