using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cTriggerBot {
        public static void DoTrigger() {

            int crosshairid;

            while (true) {

                if (!Main.Initialized)
                    continue;

                if (!Main.bTrigger)
                    return;

                Thread.Sleep(1);

                Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                if (Main.GetAsyncKeyState(Main.Trigger_Bind) < 0) {

                    if (pLocal.ID == 0 || pLocal.m_iHealth() < 1)
                        continue;

                    crosshairid = Main.Memory.ReadInt($"{Main.ReadHex(Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}"))}+{Main.ReadHex(hazedumper.netvars.m_iCrosshairId)}");

                    if (crosshairid == 0 || crosshairid > 64)
                        continue;

                    Main.Memory.WriteMemory($"client.dll+{Main.ReadHex(hazedumper.signatures.dwForceAttack)}", "int", "5");
                    Thread.Sleep(20);
                    Main.Memory.WriteMemory($"client.dll+{Main.ReadHex(hazedumper.signatures.dwForceAttack)}", "int", "4");
                }
            }
        }
    }
}
