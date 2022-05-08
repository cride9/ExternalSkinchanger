using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cRemoveFlash {
        public static void RemoveFlash() {
            while (true) {

                Thread.Sleep(1);

                if (!Main.Initialized)
                    continue;

                if (!Main.bFlash) {
                    Main.Memory.WriteMemory($"{Main.ReadHex(Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}"))}+{Main.ReadHex(hazedumper.netvars.m_flFlashMaxAlpha)}", "float", "255");
                    return;
                }
                Main.Memory.WriteMemory($"{Main.ReadHex(Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}"))}+{Main.ReadHex(hazedumper.netvars.m_flFlashMaxAlpha)}", "float", "51");
            }
        }
    }
}
