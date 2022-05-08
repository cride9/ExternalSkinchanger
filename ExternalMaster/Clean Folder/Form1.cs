using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.IO;

namespace ExternalMaster {
    public partial class Main : Form {

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys keys);
        public static Mem Memory = new Mem();
        public static Keys Trigger_Bind, Thirdperson_Bind;
        public static string GlowObjectManager = "client.dll+" + ReadHex(hazedumper.signatures.dwGlowObjectManager) + ",";
        public static int uspskin, glockskin, berettaskin, p250skin, czskin, tec9skin, fivesevenskin, desertskin, CurrentWeaponID, EntityList, CurrentWeaponEntity;
        public static bool Initialized;
        public static bool bBhop, bFakelag, bFov, bGlow, bFlash, bThirdPerson, bTrigger, bRadar;

        public static string ReadHex(Int32 value) {

            return "0x" + value.ToString("X");
        }

        public Main() {
            InitializeComponent();
        }

        // wtf is that for real
        public void TriggerbotBind_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char)Keys.Escape)
                return;

            if (e.KeyChar == (char)Keys.Back)
                return;

            TriggerbotBind.Text = "";
            //Trigger_Bind = e.KeyChar;
            Trigger_Bind = (Keys)Enum.Parse(typeof(Keys), e.KeyChar.ToString(), ignoreCase: true);
        }
        public void ThirdpersonBind_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char)Keys.Escape)
                return;

            if (e.KeyChar == (char)Keys.Back)
                return;

            ThirdpersonBind.Text = "";
            //Thirdperson_Bind = e.KeyChar;
            Thirdperson_Bind = (Keys)Enum.Parse(typeof(Keys), e.KeyChar.ToString(), ignoreCase: true);

        }
        public void Bhop_CheckedChanged(object sender, EventArgs e) {

            bBhop = Bhop.Checked;

            Thread BhopThread = new Thread(() => cBhop.DoBhop()) { IsBackground = true };
            BhopThread.Start();
        }
        public void NoFlash_CheckedChanged(object sender, EventArgs e) {

            bFlash = NoFlash.Checked;

            Thread NoFlashThread = new Thread(() => cRemoveFlash.RemoveFlash()) { IsBackground = true };
            NoFlashThread.Start();
        }

        private void savecfg(object sender, EventArgs e) {

            var sw = new StreamWriter(@"config.cride", false, Encoding.UTF8);

            sw.WriteLine(Bhop.Checked ? "true" : "false");
            sw.WriteLine(NoFlash.Checked ? "true" : "false");
            sw.WriteLine(Radar.Checked ? "true" : "false");
            sw.WriteLine(Thirdperson.Checked ? "true" : "false");
            sw.WriteLine(ThirdpersonBind.Text);

            sw.WriteLine(Glow.Checked ? "true" : "false");
            sw.WriteLine(Fov.Checked ? "true" : "false");

            sw.WriteLine(Triggerbot.Checked ? "true" : "false");
            sw.WriteLine(TriggerbotBind.Text);

            sw.WriteLine(USPSkin.SelectedIndex);
            sw.WriteLine(GlockSkin.SelectedIndex);
            sw.WriteLine(BerettaSkin.SelectedIndex);
            sw.WriteLine(P250Skin.SelectedIndex);
            sw.WriteLine(CZSkin.SelectedIndex);
            sw.WriteLine(Tec9Skin.SelectedIndex);
            sw.WriteLine(FiveSevenSkin.SelectedIndex);
            sw.WriteLine(DesertEagleSkin.SelectedIndex);

            sw.Close();
        }

        private void loadcfg_Click(object sender, EventArgs e) {

            var sr = new StreamReader(@"config.cride", Encoding.UTF8);

            if (sr.EndOfStream)
                return;

            Bhop.Checked = bool.Parse(sr.ReadLine()) ? true : false;
            NoFlash.Checked = bool.Parse(sr.ReadLine()) ? true : false;
            Radar.Checked = bool.Parse(sr.ReadLine()) ? true : false;

            Thirdperson.Checked = bool.Parse(sr.ReadLine()) ? true : false;
            ThirdpersonBind.Text = sr.ReadLine();
            Thirdperson_Bind = (Keys)Enum.Parse(typeof(Keys), ThirdpersonBind.Text, ignoreCase: true);

            Glow.Checked = bool.Parse(sr.ReadLine()) ? true : false;
            Fov.Checked = bool.Parse(sr.ReadLine()) ? true : false;

            Triggerbot.Checked = bool.Parse(sr.ReadLine()) ? true : false;
            TriggerbotBind.Text = sr.ReadLine();
            Trigger_Bind = (Keys)Enum.Parse(typeof(Keys), TriggerbotBind.Text, ignoreCase: true);

            USPSkin.SelectedIndex = int.Parse(sr.ReadLine());
            GlockSkin.SelectedIndex = int.Parse(sr.ReadLine());
            BerettaSkin.SelectedIndex = int.Parse(sr.ReadLine());
            P250Skin.SelectedIndex = int.Parse(sr.ReadLine());
            CZSkin.SelectedIndex = int.Parse(sr.ReadLine());
            Tec9Skin.SelectedIndex = int.Parse(sr.ReadLine());
            FiveSevenSkin.SelectedIndex = int.Parse(sr.ReadLine());
            DesertEagleSkin.SelectedIndex = int.Parse(sr.ReadLine());

            sr.Close();
        }
        private void radarcheckbox_CheckedChanged(object sender, EventArgs e) {

            bRadar = Radar.Checked;

            Thread RadarThread = new Thread(() => cRadar.Radar()) { IsBackground = true };
            RadarThread.Start();
        }
        public void Thirdperson_CheckedChanged(object sender, EventArgs e) {

            bThirdPerson = Thirdperson.Checked;

            Thread ThirdpersonThread = new Thread(() => cThirdPerson.DoThirdPerson()) { IsBackground = true };
            ThirdpersonThread.Start();
        }
        public void Glow_CheckedChanged(object sender, EventArgs e) {

            bGlow = Glow.Checked;

            Thread GlowThread = new Thread(() => cGlow.DoGlow()) { IsBackground = true };
            GlowThread.Start();
        }
        public void Fov_CheckedChanged(object sender, EventArgs e) {

            bFov = Fov.Checked;

            Thread FovThread = new Thread(() => cFovChanger.FovChanger()) { IsBackground = true };
            FovThread.Start();
        }
        public void Triggerbot_CheckedChanged(object sender, EventArgs e) {

            bTrigger = Triggerbot.Checked;

            Thread TriggerThread = new Thread(() => cTriggerBot.DoTrigger()) { IsBackground = true };
            TriggerThread.Start();
        }
        public void Main_Load(object sender, EventArgs e) {

            int PID = Memory.GetProcIdFromName("csgo"); ;
            if (PID != 0) {

                Memory.OpenProcess(PID);
                csgopid.Text = $"PID: {PID}";

                Initialized = true;

                Thread skin = new Thread(() => NewSkinChanger.SkinChanger());
                skin.Start();
            }
        }
        public static Entity GetEntitybyIndex(int index) {

            return new Entity() { ID = Memory.ReadInt($"client.dll+{ReadHex(hazedumper.signatures.dwEntityList + index * 0x10)}") };
        }
        public static void bSendPacket(bool input) {

            Memory.WriteMemory($"engine.dll+{ReadHex(hazedumper.signatures.dwbSendPackets)}", "byte", input ? "1" : "0");
        }
        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCpYOgpBYqVzdFnYec7GXJCA");
        }
        public void USPSkin_SelectedIndexChanged(object sender, EventArgs e) {
            uspskin = USPSkin.SelectedIndex;
        }

        public void GlockSkin_SelectedIndexChanged(object sender, EventArgs e) {
            glockskin = GlockSkin.SelectedIndex;
        }

        public void BerettaSkin_SelectedIndexChanged(object sender, EventArgs e) {
            berettaskin = BerettaSkin.SelectedIndex;
        }

        public void P250Skin_SelectedIndexChanged(object sender, EventArgs e) {
            p250skin = P250Skin.SelectedIndex;
        }

        public void CZSkin_SelectedIndexChanged(object sender, EventArgs e) {
            czskin = CZSkin.SelectedIndex;
        }

        public void Tec9Skin_SelectedIndexChanged(object sender, EventArgs e) {
            tec9skin = Tec9Skin.SelectedIndex;
        }

        public void FiveSevenSkin_SelectedIndexChanged(object sender, EventArgs e) {
            fivesevenskin = FiveSevenSkin.SelectedIndex;
        }

        public void DesertEagleSkin_SelectedIndexChanged(object sender, EventArgs e) {
            desertskin = DesertEagleSkin.SelectedIndex;
        }

        public static void ChangeFov(int input) {
            Memory.WriteMemory($"{ReadHex(Memory.ReadInt($"client.dll+{ReadHex(hazedumper.signatures.dwLocalPlayer)}"))}+{ReadHex(hazedumper.netvars.m_iFOV)}", "int", input.ToString());
        }
    }
}
