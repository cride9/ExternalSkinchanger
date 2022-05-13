using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace ExternalMaster {
    internal class cNightmode {

    public static void NightMode() {
            //while (true) {
            //    System.Threading.Thread.Sleep(1);

            //    //m_hTonemapController = 0x31CC; //DT_CSPlayer
            //    //m_bUseCustomAutoExposureMin = 0x9D8 //DT_EnvTonemapController
            //    //m_flCustomAutoExposureMin = 0x9DC; //DT_EnvTonemapController
            //    //m_flCustomAutoExposureMax = 0x9E0; //DT_EnvTonemapController

            //    if (!Main.Initialized)
            //        continue;

            //    if (!Main.bNightMode) {
            //        Main.Memory.WriteMemory("client.dll+531FCF0", "float", "1");
            //        Main.Memory.WriteMemory("client.dll+531FCEC", "float", "1");
            //        return;
            //    }

            //    Main.Memory.WriteMemory("client.dll+531FCF0", "float", "0.4");
            //    Main.Memory.WriteMemory("client.dll+531FCEC", "float", "0.4");

            //    //https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://hyades.shoutca.st:8043/autodj&t=.pls
            //}
            //if (Main.bNightMode)

            if (!Main.bNightMode)
                return;
            
            using (var client = new WebClient()) {
                client.DownloadFile("https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://192.95.39.65:5607/listen.pls?sid=1&t=.pls", "radio.pls");
                while (client.IsBusy)
                    Thread.Sleep(100);
            }

            FileInfo info = new FileInfo("radio.pls");

            Process process = new Process();
            ProcessStartInfo startInfo = process.StartInfo;
            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();

            Thread.Sleep(1000);

            process.StandardInput.WriteLine($"{Main.vlcpath.First()}:");
            process.StandardInput.Flush();
            process.StandardInput.WriteLine($"cd {Main.vlcpath}");
            process.StandardInput.Flush();
            process.StandardInput.WriteLine($"vlc {info.Directory.FullName}\\radio.pls");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
        }
    }
}
