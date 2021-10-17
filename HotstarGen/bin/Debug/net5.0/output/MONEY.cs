using System;
namespace Hotstar
{
    public enum NATIVE_MONEY : ulong
    { 
        _MONEY_GET_CASH_BALANCE = 0x0C02DABFA3B98176,
        _MONEY_DECREMENT_CASH_BALANCE = 0x466BC8769CF26A7A,
        _MONEY_INCREMENT_CASH_BALANCE = 0xBC3422DC91667621,
        _NETWORK_GET_STRING_CASH_BALANCE = 0x282D36FF103D78DF,
        _NETWORK_IS_MONEY_BALANCE_NOT_LESS_THAN = 0xAEC5F0119867E457,
        _NETWORK_GET_CASH_BALANCE = 0x8A67120DBC299525,
        _0xA46FD001D1BE896C = 0xA46FD001D1BE896C,
        _0x07AD9E43FD478527 = 0x07AD9E43FD478527,
    }
    public static class NATIVE_MONEY_EXTENSIONS
    {
        public static void Call(this NATIVE_MONEY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_MONEY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}