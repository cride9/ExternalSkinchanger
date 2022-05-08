using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cGlow {
        public static void DoGlow() {

            while (true) {

                Thread.Sleep(1);

                if (!Main.Initialized)
                    continue;

                if (!Main.bGlow)
                    return;

                for (int i = 0; i < 32; i++) {

                    Entity BaseEntity = Main.GetEntitybyIndex(i);
                    Entity Local = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                    if (BaseEntity.ID == 0)
                        continue;

                    if (BaseEntity.m_bDormant() || BaseEntity.m_iHealth() < 1)
                        continue;

                    if (Local.m_iTeamNum() != BaseEntity.m_iTeamNum()) {

                        Draw(BaseEntity.m_iGlowIndex(), 115, 118, 201, 160);
                    }
                }
            }
        }
        static void Draw(int index, float R, float G, float B, float A) {

            //"client.dll+" + ReadHex(hazedumper.signatures.dwGlowObjectManager) + ",";

            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x8), "float", (R / 255).ToString());   // Red
            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0xC), "float", (G / 255).ToString());   // Green
            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x10), "float", (B / 255).ToString());  // Blue
            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x14), "float", (A / 255).ToString());  // Alpha

            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x28), "int", "1");
            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x29), "int", "1");
            Main.Memory.WriteMemory(Main.GlowObjectManager + Main.ReadHex(index * 0x38 + 0x2D), "int", "2");
        }

        
    }
}
