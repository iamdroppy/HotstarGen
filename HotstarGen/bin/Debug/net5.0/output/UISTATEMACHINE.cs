using System;
namespace Hotstar
{
    public enum NATIVE_UISTATEMACHINE : ulong
    { 
        _UIFLOWBLOCK_REQUEST = 0xC0081B34E395CE48,
        _UIFLOWBLOCK_RELEASE = 0xF320A77DD5F781DF,
        _UIFLOWBLOCK_IS_LOADED = 0x10A93C057B6BD944,
        _UIFLOWBLOCK_ENTER = 0x3B7519720C9DCB45,
        UI_STATE_MACHINE_EXISTS = 0x5D15569C0FEBF757,
        UI_STATE_MACHINE_CREATE = 0x4C6F2C4B7A03A266,
        UI_STATE_MACHINE_CAN_REQUEST_TRANSITION = 0xF7C180F57F85D0B8,
        UI_STATE_MACHINE_REQUEST_TRANSITION = 0x7EA9C3547E80350E,
        UI_STATE_MACHINE_REQUEST_EXIT = 0x6B9FE4F0BA521A19,
        UI_STATE_MACHINE_DESTROY = 0x4EB122210A90E2D8,
        UI_STATE_MACHINE_DESTROY_AND_CLEAR = 0x2738D68D2B4E09E7,
        _0x11E73195E735B25B = 0x11E73195E735B25B,
    }
    public static class NATIVE_UISTATEMACHINE_EXTENSIONS
    {
        public static void Call(this NATIVE_UISTATEMACHINE hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_UISTATEMACHINE hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}