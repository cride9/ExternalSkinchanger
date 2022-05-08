using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cFakelag {
        public static void DoFakelag() {
            while (true) {

                if (!Main.Initialized)
                    continue;

                Thread.Sleep(1);

                if (!Main.bFakelag) {
                    Main.bSendPacket(true);
                    return;
                }

                Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                if (pLocal.ID == 0 || pLocal.m_iHealth() < 1) {
                    Main.bSendPacket(true);
                    continue;
                }

                if (Main.Memory.ReadByte($"engine.dll+{Main.ReadHex(hazedumper.signatures.dwClientState)},{Main.ReadHex(hazedumper.signatures.clientstate_choked_commands)}") < 4)
                    Main.bSendPacket(false);
                else
                    Main.bSendPacket(true);
            }
        }
    }
}
