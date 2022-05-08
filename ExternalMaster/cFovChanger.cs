using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExternalMaster {
    internal class cFovChanger {
        public static void FovChanger() {
            while (true) {

                Thread.Sleep(1);

                if (!Main.Initialized)
                    continue;

                if (!Main.bFov)
                    return;

                Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                if (!pLocal.m_bIsScoped()) {

                    //m_zoomlevel == 1 ; 40
                    //m_zoomlevel == 2 ; 15

                    Main.ChangeFov(110);
                }
            }
        }
    }
}
