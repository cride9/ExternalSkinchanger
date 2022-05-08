using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class NewSkinChanger {

		enum KnifeIDs : int {

			WEAPON_KNIFE_T = 59,
			WEAPON_KNIFE_CT = 42,
			WEAPON_KNIFE_KARAM = 507,
			WEAPON_KNIFE_BAYONET = 500,
			WEAPON_KNIFE_CLASSIC = 503,
			WEAPON_KNIFE_FLIP = 505,
			WEAPON_KNIFE_GUT = 506,
			WEAPON_KNIFE_M9 = 508,
			WEAPON_KNIFE_HUNTSMAN = 509,
			WEAPON_KNIFE_FALCHION = 512,
			WEAPON_KNIFE_BOWIE = 514,
			WEAPON_KNIFE_BUTTERFLY = 515,
			WEAPON_KNIFE_DAGGERS = 516,
			WEAPON_KNIFE_PARACORD = 517,
			WEAPON_KNIFE_SURVIVAL = 518,
			WEAPON_KNIFE_URSUS = 519,
			WEAPON_KNIFE_NAVAJA = 520,
			WEAPON_KNIFE_NOMAD = 521,
			WEAPON_KNIFE_STILETTO = 522,
			WEAPON_KNIFE_TALON = 523,
			WEAPON_KNIFE_SKELETON = 525,
		}
		enum WeaponIDs : int {
			WEAPON_NONE,
			WEAPON_DEAGLE,
			WEAPON_ELITE,
			WEAPON_FIVESEVEN,
			WEAPON_GLOCK,
			WEAPON_P228,
			WEAPON_USP,
			WEAPON_AK47,
			WEAPON_AUG,
			WEAPON_AWP,
			WEAPON_FAMAS,
			WEAPON_G3SG1,
			WEAPON_GALIL,
			WEAPON_GALILAR,
			WEAPON_M249,
			WEAPON_M3,
			WEAPON_M4A1,
			WEAPON_MAC10,
			WEAPON_MP5NAVY,
			WEAPON_P90,
			WEAPON_SCOUT,
			WEAPON_SG550,
			WEAPON_SG552,
			WEAPON_TMP,
			WEAPON_UMP45,
			WEAPON_XM1014,
			WEAPON_BIZON,
			WEAPON_MAG7,
			WEAPON_NEGEV,
			WEAPON_SAWEDOFF,
			WEAPON_TEC9,
			WEAPON_TASER,
			WEAPON_HKP2000,
			WEAPON_MP7,
			WEAPON_MP9,
			WEAPON_NOVA,
			WEAPON_P250,
			WEAPON_SCAR17,
			WEAPON_SCAR20,
			WEAPON_SG556,
			WEAPON_SSG08,
			WEAPON_KNIFEGG,
			WEAPON_KNIFE,
			WEAPON_FLASHBANG,
			WEAPON_HEGRENADE,
			WEAPON_SMOKEGRENADE,
			WEAPON_MOLOTOV,
			WEAPON_DECOY,
			WEAPON_INCGRENADE,
			WEAPON_C4
		}

		static int WeaponIndex;
		static int EntityList;
		static int CurrentWeaponID;

		readonly static int[] uspskins = { 1040, 653, 504, 991, 705, 339, 313, 221, 1065, 1027, 1136, 817, 637, 290, 183, 60, 922, 318, 1102, 657, 540, 489, 217, 277, 818, 796, 364, 236, 443, 454, 332, 25 };
		readonly static int[] glockskins = { 988, 957, 586, 1100, 963, 353, 437, 694, 607, 532, 381, 230, 48, 84, 1016, 732, 789, 38, 159, 1039, 918, 808, 713, 680, 623, 495, 479, 399, 278, 367, 3, 1079, 799, 40, 293, 2, 208 };
		readonly static int[] berettaskins = { 1126, 658, 747, 978, 625, 396, 261, 220, 447, 249, 153, 1091, 895, 903, 710, 544, 528, 491, 307, 276, 190, 453, 28, 824, 998, 860, 43, 1086, 1005, 450, 330, 46, 47 };
		readonly static int[] p250skins = { 678, 551, 404, 388, 271, 258, 295, 1044, 907, 125, 813, 668, 501, 358, 162, 1081, 749, 168, 982, 968, 848, 650, 592, 426, 230, 219, 928, 1030, 786, 102, 164, 741, 466, 373, 34, 207, 15, 825, 78, 777, 467, 77, 99, 27 };
		readonly static int[] CZskins = { 270, 643, 476, 269, 709, 687, 543, 435, 350, 268, 1064, 325, 1036, 976, 944, 622, 602, 218, 334, 315, 12, 859, 453, 322, 297, 933, 32, 1076, 147, 333, 298, 366 };
		readonly static int[] tec9skins = { 889, 614, 791, 964, 839, 555, 520, 272, 248, 179, 905, 816, 722, 684, 671, 599, 539, 303, 289, 216, 795, 1024, 463, 374, 159, 36, 733, 738, 439, 235, 1010, 459, 17, 242, 2, 206 };
		readonly static int[] fivesevenskins = { 837, 660, 979, 427, 352, 1082, 1093, 906, 530, 510, 274, 44, 1002, 464, 1128, 693, 646, 605, 585, 387, 223, 265, 729, 254, 252, 932, 377, 141, 3, 784, 46, 78, 210, 151 };
		readonly static int[] desertskins = { 1090, 962, 711, 185, 805, 527, 351, 231, 61, 764, 1050, 841, 603, 397, 232, 273, 757, 470, 469, 328, 347, 37, 945, 645, 509, 425, 1056, 1006, 296, 237, 992, 468, 40, 17, 90 };

		private static void GetSkin(int WeaponID) {

			switch (WeaponID) {
				case (int)WeaponIDs.WEAPON_DEAGLE:
					SetSkin(desertskins[Main.desertskin]);
					break;
				case (int)WeaponIDs.WEAPON_ELITE:
					SetSkin(berettaskins[Main.berettaskin]);
					break;
				case (int)WeaponIDs.WEAPON_FIVESEVEN:
					SetSkin(fivesevenskins[Main.fivesevenskin]);
					break;
				case (int)WeaponIDs.WEAPON_GLOCK:
					SetSkin(glockskins[Main.glockskin]);
					break;
				case (int)WeaponIDs.WEAPON_USP:
					SetSkin(504);
					break;
				case (int)WeaponIDs.WEAPON_AK47:
					SetSkin(302);
					break;
				case (int)WeaponIDs.WEAPON_AUG:
					SetSkin(305);
					break;
				case (int)WeaponIDs.WEAPON_AWP:
					SetSkin(279);
					break;
				case (int)WeaponIDs.WEAPON_FAMAS:
					SetSkin(178);
					break;
				case (int)WeaponIDs.WEAPON_G3SG1:
					SetSkin(493);
					break;
				case (int)WeaponIDs.WEAPON_GALIL:
					SetSkin(379);
					break;
				case (int)WeaponIDs.WEAPON_GALILAR:
					SetSkin(379);
					break;
				case (int)WeaponIDs.WEAPON_M249:
					SetSkin(648);
					break;
				case (int)WeaponIDs.WEAPON_M3:
					SetSkin(648);
					break;
				case (int)WeaponIDs.WEAPON_M4A1:
					SetSkin(309);
					break;
				case (int)WeaponIDs.WEAPON_MAC10:
					SetSkin(433);
					break;
				case (int)WeaponIDs.WEAPON_MP5NAVY:
					SetSkin(433);
					break;
				case (int)WeaponIDs.WEAPON_P90:
					SetSkin(359);
					break;
				case (int)WeaponIDs.WEAPON_SCOUT:
					SetSkin(624);
					break;
				case (int)WeaponIDs.WEAPON_SG550:
					SetSkin(624);
					break;
				case (int)WeaponIDs.WEAPON_SG552:
					SetSkin(624);
					break;
				case (int)WeaponIDs.WEAPON_TMP:
					SetSkin(624);
					break;
				case (int)WeaponIDs.WEAPON_UMP45:
					SetSkin(556);
					break;
				case (int)WeaponIDs.WEAPON_XM1014:
					SetSkin(320);
					break;
				case (int)WeaponIDs.WEAPON_BIZON:
					SetSkin(236);
					break;
				case (int)WeaponIDs.WEAPON_MAG7:
					SetSkin(703);
					break;
				case (int)WeaponIDs.WEAPON_NEGEV:
					SetSkin(432);
					break;
				case (int)WeaponIDs.WEAPON_SAWEDOFF:
					SetSkin(517);
					break;
				case (int)WeaponIDs.WEAPON_TEC9:
					SetSkin(tec9skins[Main.tec9skin]);
					break;
				case (int)WeaponIDs.WEAPON_HKP2000:
					SetSkin(287);
					break;
				case (int)WeaponIDs.WEAPON_MP7:
					SetSkin(696);
					break;
				case (int)WeaponIDs.WEAPON_MP9:
					SetSkin(482);
					break;
				case (int)WeaponIDs.WEAPON_NOVA:
					SetSkin(537);
					break;
				case (int)WeaponIDs.WEAPON_P250:
					SetSkin(p250skins[Main.p250skin]);
					break;
				case (int)WeaponIDs.WEAPON_SCAR17:
					SetSkin(597);
					break;
				case (int)WeaponIDs.WEAPON_SCAR20:
					SetSkin(597);
					break;
				case (int)WeaponIDs.WEAPON_SG556:
					SetSkin(598);
					break;
				case (int)WeaponIDs.WEAPON_SSG08:
					SetSkin(624);
					break;
				case 61: // usp-s
					SetSkin(uspskins[Main.uspskin]);
					break;
				case 63: // cz-auto
					SetSkin(CZskins[Main.czskin]);
					break;
				case 60: // m4a1-s
					SetSkin(644);
					break;
				default:
					SetSkin(0);
					break;

			}
		}

		public static void SkinChanger() {

			while (true) {

				if (!Main.Initialized)
					continue;

				Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

				if (pLocal.ID == 0 || pLocal.m_iHealth() < 1)
					continue;

				for (int i = 0; i < 3; i++) {

					// Shadow Daggers: 516
					// Karambit: 507

					WeaponIndex = Main.Memory.Read2Byte($"{Main.ReadHex(pLocal.ID)}+{Main.ReadHex(hazedumper.netvars.m_hMyWeapons + i * 0x4)}") & 0xfff;
					EntityList = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwEntityList + (WeaponIndex - 1) * 0x10)}");
					CurrentWeaponID = Main.Memory.Read2Byte($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_iItemDefinitionIndex)}");

					// Im pretty sure it's outdated but here you go
					// Skin ID list: https://steamcommunity.com/sharedfiles/filedetails/?id=880595913

					GetSkin(CurrentWeaponID);

				}
				//Thread.Sleep(1);
			}
		}
		private static void SetSkin(int skinid) {

			int CurrentSkin = Main.Memory.ReadInt($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_nFallbackPaintKit)}");

			if (CurrentSkin != skinid) {

				Main.Memory.WriteMemory($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_iItemIDHigh)}", "int", $"{-1}");
				if (skinid == 279)
					Main.Memory.WriteMemory($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_flFallbackWear)}", "float", $"{0.9999f}");
				else
					Main.Memory.WriteMemory($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_flFallbackWear)}", "float", $"{0.0001f}");
				Main.Memory.WriteMemory($"{Main.ReadHex(EntityList)}+{Main.ReadHex(hazedumper.netvars.m_nFallbackPaintKit)}", "int", $"{skinid}");

				Main.Memory.WriteMemory($"engine.dll+{Main.ReadHex(hazedumper.signatures.dwClientState)},{Main.ReadHex(hazedumper.signatures.clientstate_delta_ticks)}", "int", "-1");
			}
		}
	}
}
