using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cThirdPerson {
        public static void DoThirdPerson() {

            bool tp = false;

            while (true) {

                Thread.Sleep(1);

                if (!Main.Initialized)
                    continue;

                if (!Main.bThirdPerson)
                    return;

                if (Main.GetAsyncKeyState(Main.Thirdperson_Bind) < 0) {
                    tp = !tp;
                    Thread.Sleep(100);
                }

                Main.Memory.WriteMemory($"{Main.ReadHex(Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}"))}+{Main.ReadHex(hazedumper.netvars.m_iObserverMode)}", "byte", tp ? "1" : "0");
            }
        }
    }
}
