using System;
namespace Hotstar
{
    public enum NATIVE_LOCALIZATION : ulong
    { 
        /// <summary>
        /// Same return values as GET_CURRENT_LANGUAGE
        ///
        ///
        /// </summary>
        _LOCALIZATION_GET_SYSTEM_LANGUAGE = 0x3C1A05F86AE6ACB5,
        /// <summary>
        /// 0 = american (en-US)
        /// 1 = french (fr-FR)
        /// 2 = german (de-DE)
        /// 3 = italian (it-IT)
        /// 4 = spanish (es-ES)
        /// 5 = brazilian (pt-BR)
        /// 6 = polish (pl-PL)
        /// 7 = russian (ru-RU)
        /// 8 = korean (ko-KR)
        /// 9 = chinesetrad (zh-TW)
        /// 10 = japanese (ja-JP)
        /// 11 = mexican (es-MX)
        /// 12 = chinesesimp (zh-CN)
        ///
        ///
        /// </summary>
        GET_CURRENT_LANGUAGE = 0xDB917DA5C6835FCC,
        /// <summary>
        /// Possible return values: 0, 1, 2
        ///
        ///
        /// </summary>
        _LOCALIZATION_GET_SYSTEM_DATE_FORMAT = 0x76E30B799EBEEA0F,
        /// <summary>
        /// Returns true if the current language is american, french, german, italian, spanish, brazilian or mexican.
        ///
        ///
        /// </summary>
        _0x45D50415E4D885FF = 0x45D50415E4D885FF,
    }
    public static class NATIVE_LOCALIZATION_EXTENSIONS
    {
        public static void Call(this NATIVE_LOCALIZATION hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_LOCALIZATION hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}