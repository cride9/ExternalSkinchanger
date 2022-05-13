using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalMaster {
    public class Entity {

        public int ID;

        public int m_iHealth() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_iHealth)}");
        }
        public bool m_bDormant() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.signatures.m_bDormant)}") == 1 ? true : false;
        }
        public int m_iTeamNum() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_iTeamNum)}");
        }
        public int m_iGlowIndex() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_iGlowIndex)}");
        }
        public int m_fFlags() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_fFlags)}");
        }
        public bool m_bGunGameImmunity() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_bGunGameImmunity)}") == 1 ? true : false;
        }
        public bool m_bIsScoped() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_bIsScoped)}") == 1 ? true : false;
        }
        public bool m_bSpotted() {

            return Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_bSpotted)}") == 1 ? true : false;
        }
        public bool m_bSpotted(bool value) {

            return Main.Memory.WriteMemory($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_bSpotted)}", "int", $"{(value ? 1 : 0)}");
        }
        public int WeaponBase() {
            var activeweapon = Main.Memory.ReadInt($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_hActiveWeapon)}");
            return Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwEntityList + ( (activeweapon & 0xFFF) - 1) * 0x10)}");
        }
        public float m_nTickBase() {
            return Main.Memory.ReadFloat($"{Main.ReadHex(ID)}+{Main.ReadHex(hazedumper.netvars.m_nTickBase)}", "", false);
        }
    }
}
