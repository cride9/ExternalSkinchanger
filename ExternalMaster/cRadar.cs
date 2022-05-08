using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalMaster {
    internal class cRadar {
        public static void Radar() {

            while (true) {

                if (!Main.Initialized)
                    continue;

                if (!Main.bRadar)
                    return;

                for (int i = 0; i < 32; i++) {

                    Entity pEnt = Main.GetEntitybyIndex(i);
                    Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                    if (pEnt.ID == 0)
                        continue;

                    if (pEnt.m_iHealth() < 1)
                        continue;

                    if (pEnt.m_iTeamNum() == pLocal.m_iTeamNum())
                        continue;

                    pEnt.m_bSpotted(true);
                }

                Thread.Sleep(1);
            }
        }
    }
}
