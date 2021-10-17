using System;
namespace Hotstar
{
    public enum NATIVE_BRAIN : ulong
    { 
        /// <summary>
        /// Registers a script for any object with a specific model hash.
        ///
        /// > const char* scriptName
        /// > Hash modelHash
        /// > int p2
        /// > float activationRange
        /// > int p4
        /// > int p5
        ///
        /// </summary>
        REGISTER_OBJECT_SCRIPT_BRAIN = 0x16AF9B4EEAC3B305,
        /// <summary>
        /// Returns threadId
        ///
        /// > Entity entity
        /// > const char* scriptName
        /// > int scriptStackSize
        /// > BOOL p3
        ///
        /// </summary>
        _0x4E4507CC5E4DB869 = 0x4E4507CC5E4DB869,
        /// <summary>
        /// Common flags: 250, 99999
        ///
        /// > int flag
        ///
        /// </summary>
        _0xA6AC35DB4A7957A8 = 0xA6AC35DB4A7957A8,
        /// <summary>
        /// Called with flag 0 before 0xA6AC35DB4A7957A8 in net_entity_brain
        ///
        /// > int flag
        ///
        /// </summary>
        _0x4AA5EA1EDFB25786 = 0x4AA5EA1EDFB25786,
        ENABLE_SCRIPT_BRAIN_SET = 0x1CF6E5C6750EADBD,
        DISABLE_SCRIPT_BRAIN_SET = 0x3F44EA613A5B2676,
        _0x6F62FAE266DCFC81 = 0x6F62FAE266DCFC81,
        _0x38F1E09224EECA09 = 0x38F1E09224EECA09,
        _0x6818D1A194E29983 = 0x6818D1A194E29983,
        _0xA32B0B05EFF75730 = 0xA32B0B05EFF75730,
        _0x74C333E34DF74E8A = 0x74C333E34DF74E8A,
    }
    public static class NATIVE_BRAIN_EXTENSIONS
    {
        public static void Call(this NATIVE_BRAIN hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_BRAIN hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}