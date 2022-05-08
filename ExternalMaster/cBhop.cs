using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ExternalMaster {
    internal class cBhop {
        public static void DoBhop() {
            int Jumping;

            while (true) {

                Thread.Sleep(1);

                if (!Main.Initialized)
                    continue;

                if (!Main.bBhop)
                    return;

                if (Main.GetAsyncKeyState(Keys.Space) < 0) { // while pressing the space

                    Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

                    if (pLocal.ID == 0 || pLocal.m_iHealth() < 1)
                        continue;

                    Jumping = pLocal.m_fFlags();

                    if (Jumping == 257 || Jumping == 263) { // on ground

                        // 4 - not jumping
                        // 5 - jumping
                        Main.Memory.WriteMemory($"client.dll+{Main.ReadHex(hazedumper.signatures.dwForceJump)}", "int", "5");
                        Thread.Sleep(20);
                        Main.Memory.WriteMemory($"client.dll+{Main.ReadHex(hazedumper.signatures.dwForceJump)}", "int", "4");
                    }
                }
            }
        }
    }
}
