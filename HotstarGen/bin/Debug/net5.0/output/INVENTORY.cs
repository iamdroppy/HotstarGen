using System;
namespace Hotstar
{
    public enum NATIVE_INVENTORY : ulong
    { 
        /// <summary>
        /// Returns a unique inventory ID for this ped.
        /// For the local player ped, it is an eInventories value.
        /// For other peds, it is the inventory address casted to unsigned int.
        /// 
        /// enum eInventories
        /// {
        /// 	INVENTORY_INVALID,
        /// 	INVENTORY_SP_PLAYER,
        /// 	INVENTORY_MP_PLAYER,
        /// 	INVENTORY_MP_MISSION,
        /// 	INVENTORY_SECOND_SCREEN,
        /// 	INVENTORY_SP_BACKUP,
        /// 	INVENTORY_SP_SNAPSHOT,
        /// 	INVENTORY_0xDE2AE452,
        /// 	INVENTORY_0x399D9B3A,
        /// 	INVENTORY_0x4BD43FA7,
        /// 	INVENTORY_0x9529D251,
        /// 	INVENTORY_0xA75776AC,
        /// 	INVENTORY_MAX_ID = 11,
        /// 	INVENTORY_IDS_COUNT
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        _INVENTORY_GET_INVENTORY_ID_FROM_PED = 0x13D234A2A3F66E63,
        /// <summary>
        /// inventoryId: see _INVENTORY_GET_PED_INVENTORY_ID
        ///
        /// > int inventoryId
        ///
        /// </summary>
        _INVENTORY_ARE_LOCAL_CHANGES_ALLOWED = 0x0FBBFFC891A97C81,
        _INVENTORY_IS_GUID_VALID = 0xB881CA836CC4B6D4,
        INVENTORY_GET_GUID_FROM_ITEMID = 0x886DFD3E185C8A89,
        INVENTORY_GET_INVENTORY_ITEM = 0x9700E8EFC4AB9089,
        _INVENTORY_CREATE_ITEM_COLLECTION = 0x80D78BDC9D88EF07,
        _INVENTORY_CREATE_ITEM_COLLECTION_WITH_FILTER = 0x640F890C3E5A3FFD,
        _INVENTORY_GET_ITEM_FROM_COLLECTION_INDEX = 0x82FA24C3D3FCD9B7,
        _INVENTORY_RELEASE_ITEM_COLLECTION = 0x42A2F33A1942E865,
        _INVENTORY_IS_ITEM_EXPIRED = 0x0137C77A2EC64536,
        _INVENTORY_GET_ITEM_EXPIRY_TIME = 0x4A606C17276E1BCC,
        INVENTORY_GET_CHILDREN_IN_SLOT_COUNT = 0x033EE4B89F3AC545,
        _INVENTORY_FITS_SLOT_ID = 0x780C5B9AE2819807,
        INVENTORY_DISABLE_MISSION_INVENTORY_PICKUPS = 0xE1F389F03DC83673,
        _INVENTORY_USE_MISSION_INVENTORY = 0xA6AA9F56BC6CFF58,
        INVENTORY_COPY_MP_INVENTORY_TO_MISSION_INVENTORY = 0x644CCB76A76CFBD6,
        _INVENTORY_IS_PLAYER_INVENTORY_MIRRORING_TRANSACTIONS = 0xFC7563F482781A3D,
        _0xADDD1E7C0ECF7D95 = 0xADDD1E7C0ECF7D95,
        _0xE80E50BEE276A54A = 0xE80E50BEE276A54A,
        _0x112BCA290D2EB53C = 0x112BCA290D2EB53C,
        _0x46743BBFEDBC859E = 0x46743BBFEDBC859E,
        _0x65A5F70F4A292EBE = 0x65A5F70F4A292EBE,
        _0x70E3A884ED000A01 = 0x70E3A884ED000A01,
        _0x9A113C660AEA3832 = 0x9A113C660AEA3832,
        _0xD740F11FBC8AEF43 = 0xD740F11FBC8AEF43,
        _0xF9933164965533B7 = 0xF9933164965533B7,
        _0x4AEF1FB5B9011D75 = 0x4AEF1FB5B9011D75,
        _0xA4550FE9C512E3DD = 0xA4550FE9C512E3DD,
        _0x245D07651B1D183B = 0x245D07651B1D183B,
        _0x2BAE4880DCDD560B = 0x2BAE4880DCDD560B,
        _0x2E1CDC1FF3B8473E = 0x2E1CDC1FF3B8473E,
        _0x0C093C1787F18519 = 0x0C093C1787F18519,
        _0xAB5F12746A099A0E = 0xAB5F12746A099A0E,
        _0x4C543D5DFCD2DAFD = 0x4C543D5DFCD2DAFD,
        _0x5D6182F3BCE1333B = 0x5D6182F3BCE1333B,
        _0x025A1B1FB03FBF61 = 0x025A1B1FB03FBF61,
        _0xCD9A485F2B383B44 = 0xCD9A485F2B383B44,
        _0xCB5D11F9508A928D = 0xCB5D11F9508A928D,
        _0xD80A8854DB5CFBA5 = 0xD80A8854DB5CFBA5,
        _0x3E4E811480B3AE79 = 0x3E4E811480B3AE79,
        _0xB4158C8C9A3B5DCE = 0xB4158C8C9A3B5DCE,
        _0xDCCAA7C3BFD88862 = 0xDCCAA7C3BFD88862,
        _0xF2753D691BCDA314 = 0xF2753D691BCDA314,
        _0x734311E2852760D0 = 0x734311E2852760D0,
        _0x22E590F108289A9D = 0x22E590F108289A9D,
        _0x88B58B83A43A8CAB = 0x88B58B83A43A8CAB,
        _0xD08685BA892DBFAB = 0xD08685BA892DBFAB,
        _0x0349404A22736740 = 0x0349404A22736740,
        _0x6D2F987736A42D4C = 0x6D2F987736A42D4C,
        _0x766315A564594401 = 0x766315A564594401,
        _0x6A564540FAC12211 = 0x6A564540FAC12211,
        _0x3D10D7179D7034AF = 0x3D10D7179D7034AF,
        _0x227522FD59DDB7E8 = 0x227522FD59DDB7E8,
        _0xC97E0D2302382211 = 0xC97E0D2302382211,
        _0xE787F05DFC977BDE = 0xE787F05DFC977BDE,
        _0xB1DD74A1F5536622 = 0xB1DD74A1F5536622,
        _0xE843D21A8E2498AA = 0xE843D21A8E2498AA,
        _0xBE012571B25F5ACA = 0xBE012571B25F5ACA,
        _0x6452B1D357D81742 = 0x6452B1D357D81742,
        _0xB991FE166FAF84FD = 0xB991FE166FAF84FD,
        _0x9AC53CB6907B4428 = 0x9AC53CB6907B4428,
        _0x9D21B185ABC2DBC4 = 0x9D21B185ABC2DBC4,
        _0x75CFAC49301E134F = 0x75CFAC49301E134F,
        _0x9D21B185ABC2DBC5 = 0x9D21B185ABC2DBC5,
        _0x75CFAC49301E134E = 0x75CFAC49301E134E,
        _0x46DB71883EE9D5AF = 0x46DB71883EE9D5AF,
        _0x951847CEF3D829FF = 0x951847CEF3D829FF,
        _0x6862E4D93F64CF01 = 0x6862E4D93F64CF01,
        _0x597F571DDEE3FFAC = 0x597F571DDEE3FFAC,
        _0x3112ADB9D5F3426B = 0x3112ADB9D5F3426B,
        _0xE36D4A38D28D9CFB = 0xE36D4A38D28D9CFB,
        _0x7C7E4AB748EA3B07 = 0x7C7E4AB748EA3B07,
        _0xC04F47D488EF9EBA = 0xC04F47D488EF9EBA,
        _0x9E58207B194488AC = 0x9E58207B194488AC,
        _0xFD41D1D4350F6413 = 0xFD41D1D4350F6413,
        _0x9B4E793B1CB6550A = 0x9B4E793B1CB6550A,
        _0xF666EF30F4F0AC4E = 0xF666EF30F4F0AC4E,
        _0xD5D72F1624F3BA7C = 0xD5D72F1624F3BA7C,
        _0xE3A46370F70F3607 = 0xE3A46370F70F3607,
        _0xE1F45A67A9F0DCBC = 0xE1F45A67A9F0DCBC,
        _0x6968CE7AC32F6788 = 0x6968CE7AC32F6788,
        _0x97A3646645727F42 = 0x97A3646645727F42,
        _0xBB7F968675B34B0C = 0xBB7F968675B34B0C,
    }
    public static class NATIVE_INVENTORY_EXTENSIONS
    {
        public static void Call(this NATIVE_INVENTORY hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_INVENTORY hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}