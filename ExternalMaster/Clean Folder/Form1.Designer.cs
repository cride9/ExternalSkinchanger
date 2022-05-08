namespace ExternalMaster {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Misc = new System.Windows.Forms.GroupBox();
            this.Radar = new System.Windows.Forms.CheckBox();
            this.csgopid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThirdpersonBind = new System.Windows.Forms.TextBox();
            this.Thirdperson = new System.Windows.Forms.CheckBox();
            this.NoFlash = new System.Windows.Forms.CheckBox();
            this.Bhop = new System.Windows.Forms.CheckBox();
            this.ESP = new System.Windows.Forms.GroupBox();
            this.loadcfg = new System.Windows.Forms.Button();
            this.cfgsave = new System.Windows.Forms.Button();
            this.Fov = new System.Windows.Forms.CheckBox();
            this.Glow = new System.Windows.Forms.CheckBox();
            this.Aim = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TriggerbotBind = new System.Windows.Forms.TextBox();
            this.Triggerbot = new System.Windows.Forms.CheckBox();
            this.SkinChanger = new System.Windows.Forms.TabControl();
            this.Pistols = new System.Windows.Forms.TabPage();
            this.USP = new System.Windows.Forms.Label();
            this.USPSkin = new System.Windows.Forms.ComboBox();
            this.DesertEagleSkin = new System.Windows.Forms.ComboBox();
            this.FiveSevenSkin = new System.Windows.Forms.ComboBox();
            this.Tec9Skin = new System.Windows.Forms.ComboBox();
            this.CZSkin = new System.Windows.Forms.ComboBox();
            this.P250Skin = new System.Windows.Forms.ComboBox();
            this.BerettaSkin = new System.Windows.Forms.ComboBox();
            this.GlockSkin = new System.Windows.Forms.ComboBox();
            this.FiveSeven = new System.Windows.Forms.Label();
            this.Tec9 = new System.Windows.Forms.Label();
            this.DesertEagle = new System.Windows.Forms.Label();
            this.CZ = new System.Windows.Forms.Label();
            this.p250 = new System.Windows.Forms.Label();
            this.Dual = new System.Windows.Forms.Label();
            this.Glock = new System.Windows.Forms.Label();
            this.Misc.SuspendLayout();
            this.ESP.SuspendLayout();
            this.Aim.SuspendLayout();
            this.SkinChanger.SuspendLayout();
            this.Pistols.SuspendLayout();
            this.SuspendLayout();
            // 
            // Misc
            // 
            this.Misc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Misc.Controls.Add(this.Radar);
            this.Misc.Controls.Add(this.csgopid);
            this.Misc.Controls.Add(this.label1);
            this.Misc.Controls.Add(this.ThirdpersonBind);
            this.Misc.Controls.Add(this.Thirdperson);
            this.Misc.Controls.Add(this.NoFlash);
            this.Misc.Controls.Add(this.Bhop);
            this.Misc.Location = new System.Drawing.Point(12, 8);
            this.Misc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Misc.Name = "Misc";
            this.Misc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Misc.Size = new System.Drawing.Size(167, 180);
            this.Misc.TabIndex = 0;
            this.Misc.TabStop = false;
            this.Misc.Text = "Misc";
            // 
            // Radar
            // 
            this.Radar.AutoSize = true;
            this.Radar.Location = new System.Drawing.Point(15, 67);
            this.Radar.Name = "Radar";
            this.Radar.Size = new System.Drawing.Size(56, 17);
            this.Radar.TabIndex = 6;
            this.Radar.Text = "Radar";
            this.Radar.UseVisualStyleBackColor = true;
            this.Radar.CheckedChanged += new System.EventHandler(this.radarcheckbox_CheckedChanged);
            // 
            // csgopid
            // 
            this.csgopid.AutoSize = true;
            this.csgopid.Location = new System.Drawing.Point(112, 162);
            this.csgopid.Name = "csgopid";
            this.csgopid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.csgopid.Size = new System.Drawing.Size(49, 13);
            this.csgopid.TabIndex = 5;
            this.csgopid.Text = "XDDXDX";
            this.csgopid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cride™️";
            // 
            // ThirdpersonBind
            // 
            this.ThirdpersonBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ThirdpersonBind.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdpersonBind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ThirdpersonBind.Location = new System.Drawing.Point(15, 113);
            this.ThirdpersonBind.Name = "ThirdpersonBind";
            this.ThirdpersonBind.Size = new System.Drawing.Size(100, 22);
            this.ThirdpersonBind.TabIndex = 1;
            this.ThirdpersonBind.Text = "Unbinded";
            this.ThirdpersonBind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThirdpersonBind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThirdpersonBind_KeyPress);
            // 
            // Thirdperson
            // 
            this.Thirdperson.AutoSize = true;
            this.Thirdperson.Location = new System.Drawing.Point(15, 90);
            this.Thirdperson.Name = "Thirdperson";
            this.Thirdperson.Size = new System.Drawing.Size(88, 17);
            this.Thirdperson.TabIndex = 3;
            this.Thirdperson.Text = "Thirdperson";
            this.Thirdperson.UseVisualStyleBackColor = true;
            this.Thirdperson.CheckedChanged += new System.EventHandler(this.Thirdperson_CheckedChanged);
            // 
            // NoFlash
            // 
            this.NoFlash.AutoSize = true;
            this.NoFlash.Location = new System.Drawing.Point(15, 44);
            this.NoFlash.Name = "NoFlash";
            this.NoFlash.Size = new System.Drawing.Size(68, 17);
            this.NoFlash.TabIndex = 2;
            this.NoFlash.Text = "NoFlash";
            this.NoFlash.UseVisualStyleBackColor = true;
            this.NoFlash.CheckedChanged += new System.EventHandler(this.NoFlash_CheckedChanged);
            // 
            // Bhop
            // 
            this.Bhop.AutoSize = true;
            this.Bhop.Location = new System.Drawing.Point(15, 21);
            this.Bhop.Name = "Bhop";
            this.Bhop.Size = new System.Drawing.Size(54, 17);
            this.Bhop.TabIndex = 0;
            this.Bhop.Text = "Bhop";
            this.Bhop.UseVisualStyleBackColor = true;
            this.Bhop.CheckedChanged += new System.EventHandler(this.Bhop_CheckedChanged);
            // 
            // ESP
            // 
            this.ESP.Controls.Add(this.loadcfg);
            this.ESP.Controls.Add(this.cfgsave);
            this.ESP.Controls.Add(this.Fov);
            this.ESP.Controls.Add(this.Glow);
            this.ESP.Location = new System.Drawing.Point(185, 8);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(200, 86);
            this.ESP.TabIndex = 1;
            this.ESP.TabStop = false;
            this.ESP.Text = "ESP";
            // 
            // loadcfg
            // 
            this.loadcfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loadcfg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadcfg.Location = new System.Drawing.Point(109, 50);
            this.loadcfg.Name = "loadcfg";
            this.loadcfg.Size = new System.Drawing.Size(75, 23);
            this.loadcfg.TabIndex = 3;
            this.loadcfg.Text = "Load CFG";
            this.loadcfg.UseVisualStyleBackColor = false;
            this.loadcfg.Click += new System.EventHandler(this.loadcfg_Click);
            // 
            // cfgsave
            // 
            this.cfgsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cfgsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cfgsave.Location = new System.Drawing.Point(109, 21);
            this.cfgsave.Name = "cfgsave";
            this.cfgsave.Size = new System.Drawing.Size(75, 23);
            this.cfgsave.TabIndex = 2;
            this.cfgsave.Text = "Save CFG";
            this.cfgsave.UseVisualStyleBackColor = false;
            this.cfgsave.Click += new System.EventHandler(this.savecfg);
            // 
            // Fov
            // 
            this.Fov.AutoSize = true;
            this.Fov.Location = new System.Drawing.Point(15, 45);
            this.Fov.Name = "Fov";
            this.Fov.Size = new System.Drawing.Size(44, 17);
            this.Fov.TabIndex = 1;
            this.Fov.Text = "Fov";
            this.Fov.UseVisualStyleBackColor = true;
            this.Fov.CheckedChanged += new System.EventHandler(this.Fov_CheckedChanged);
            // 
            // Glow
            // 
            this.Glow.AutoSize = true;
            this.Glow.Location = new System.Drawing.Point(15, 21);
            this.Glow.Name = "Glow";
            this.Glow.Size = new System.Drawing.Size(53, 17);
            this.Glow.TabIndex = 0;
            this.Glow.Text = "Glow";
            this.Glow.UseVisualStyleBackColor = true;
            this.Glow.CheckedChanged += new System.EventHandler(this.Glow_CheckedChanged);
            // 
            // Aim
            // 
            this.Aim.Controls.Add(this.linkLabel1);
            this.Aim.Controls.Add(this.TriggerbotBind);
            this.Aim.Controls.Add(this.Triggerbot);
            this.Aim.Location = new System.Drawing.Point(185, 101);
            this.Aim.Name = "Aim";
            this.Aim.Size = new System.Drawing.Size(200, 87);
            this.Aim.TabIndex = 2;
            this.Aim.TabStop = false;
            this.Aim.Text = "Aim";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.linkLabel1.Location = new System.Drawing.Point(145, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Youtube";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TriggerbotBind
            // 
            this.TriggerbotBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TriggerbotBind.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerbotBind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TriggerbotBind.Location = new System.Drawing.Point(94, 20);
            this.TriggerbotBind.Name = "TriggerbotBind";
            this.TriggerbotBind.Size = new System.Drawing.Size(100, 22);
            this.TriggerbotBind.TabIndex = 0;
            this.TriggerbotBind.Text = "Unbinded";
            this.TriggerbotBind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TriggerbotBind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TriggerbotBind_KeyPress);
            // 
            // Triggerbot
            // 
            this.Triggerbot.AutoSize = true;
            this.Triggerbot.Location = new System.Drawing.Point(15, 22);
            this.Triggerbot.Name = "Triggerbot";
            this.Triggerbot.Size = new System.Drawing.Size(79, 17);
            this.Triggerbot.TabIndex = 0;
            this.Triggerbot.Text = "Triggerbot";
            this.Triggerbot.UseVisualStyleBackColor = true;
            this.Triggerbot.CheckedChanged += new System.EventHandler(this.Triggerbot_CheckedChanged);
            // 
            // SkinChanger
            // 
            this.SkinChanger.Controls.Add(this.Pistols);
            this.SkinChanger.Location = new System.Drawing.Point(12, 194);
            this.SkinChanger.Name = "SkinChanger";
            this.SkinChanger.SelectedIndex = 0;
            this.SkinChanger.Size = new System.Drawing.Size(367, 255);
            this.SkinChanger.TabIndex = 3;
            // 
            // Pistols
            // 
            this.Pistols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Pistols.Controls.Add(this.USP);
            this.Pistols.Controls.Add(this.USPSkin);
            this.Pistols.Controls.Add(this.DesertEagleSkin);
            this.Pistols.Controls.Add(this.FiveSevenSkin);
            this.Pistols.Controls.Add(this.Tec9Skin);
            this.Pistols.Controls.Add(this.CZSkin);
            this.Pistols.Controls.Add(this.P250Skin);
            this.Pistols.Controls.Add(this.BerettaSkin);
            this.Pistols.Controls.Add(this.GlockSkin);
            this.Pistols.Controls.Add(this.FiveSeven);
            this.Pistols.Controls.Add(this.Tec9);
            this.Pistols.Controls.Add(this.DesertEagle);
            this.Pistols.Controls.Add(this.CZ);
            this.Pistols.Controls.Add(this.p250);
            this.Pistols.Controls.Add(this.Dual);
            this.Pistols.Controls.Add(this.Glock);
            this.Pistols.Location = new System.Drawing.Point(4, 22);
            this.Pistols.Name = "Pistols";
            this.Pistols.Padding = new System.Windows.Forms.Padding(3);
            this.Pistols.Size = new System.Drawing.Size(359, 229);
            this.Pistols.TabIndex = 0;
            this.Pistols.Text = "Pistols";
            // 
            // USP
            // 
            this.USP.AutoSize = true;
            this.USP.Location = new System.Drawing.Point(6, 6);
            this.USP.Name = "USP";
            this.USP.Size = new System.Drawing.Size(37, 13);
            this.USP.TabIndex = 15;
            this.USP.Text = "USP-S";
            // 
            // USPSkin
            // 
            this.USPSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.USPSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.USPSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.USPSkin.FormattingEnabled = true;
            this.USPSkin.Items.AddRange(new object[] {
            "The Traitor",
            "Neo-Noir",
            "Kill Confirmed",
            "Monster Mashup",
            "Cortex",
            "Caiman",
            "Orion",
            "Serum",
            "Whiteout",
            "Target Acquired",
            "Ticket to Hell",
            "Flashback",
            "Cyrex",
            "Guardian",
            "Overgrowth",
            "Dark Water",
            "Orange Anolis",
            "Ancient Visions",
            "Road Rash",
            "Black Lotus",
            "Blueprint",
            "Lead Conduit",
            "Torque",
            "Blood Tiger",
            "Stainless",
            "Purple DDPAT",
            "Check Engine",
            "Business Class",
            "Night Ops",
            "Pathfinder",
            "Para Green",
            "Royal Blue",
            "Forest Leaves"});
            this.USPSkin.Location = new System.Drawing.Point(156, 6);
            this.USPSkin.Name = "USPSkin";
            this.USPSkin.Size = new System.Drawing.Size(197, 21);
            this.USPSkin.TabIndex = 14;
            this.USPSkin.SelectedIndexChanged += new System.EventHandler(this.USPSkin_SelectedIndexChanged);
            // 
            // DesertEagleSkin
            // 
            this.DesertEagleSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DesertEagleSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesertEagleSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.DesertEagleSkin.FormattingEnabled = true;
            this.DesertEagleSkin.Items.AddRange(new object[] {
            "Ocean Drive",
            "Printstream",
            "Code Red",
            "Golden Koi",
            "Mecha Industries",
            "Kumicho Dragon",
            "Conspiracy",
            "Cobalt Disruption",
            "Hypnotic",
            "Fennec Fox",
            "Trigger Discipline",
            "Light Rail",
            "Directive",
            "Naga",
            "Crimson Web",
            "Heirloom",
            "Emerald Jörmungandr",
            "Sunset Storm 弐",
            "Sunset Storm 壱",
            "Hand Cannon",
            "Pilot",
            "Blaze",
            "Blue Ply",
            "Oxide Blaze",
            "Corinthian",
            "Bronze Deco",
            "Sputnik",
            "Night Heist",
            "Meteorite",
            "Urban Rubble",
            "The Bronze",
            "Midnight Storm",
            "Night",
            "Urban DDPAT",
            "Mudder"});
            this.DesertEagleSkin.Location = new System.Drawing.Point(156, 198);
            this.DesertEagleSkin.Name = "DesertEagleSkin";
            this.DesertEagleSkin.Size = new System.Drawing.Size(197, 21);
            this.DesertEagleSkin.TabIndex = 13;
            this.DesertEagleSkin.SelectedIndexChanged += new System.EventHandler(this.DesertEagleSkin_SelectedIndexChanged);
            // 
            // FiveSevenSkin
            // 
            this.FiveSevenSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FiveSevenSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiveSevenSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.FiveSevenSkin.FormattingEnabled = true;
            this.FiveSevenSkin.Items.AddRange(new object[] {
            "Angry Mob",
            "Hyper Beast",
            "Fairy Tale",
            "Monkey Business",
            "Fowl Play",
            "Fall Hazard",
            "Boost Protocol",
            "Buddy",
            "Triumvirate",
            "Retrobution",
            "Copper Galaxy",
            "Case Hardened",
            "Berries And Cherries",
            "Neon Kimono",
            "Scrawl",
            "Flame Test",
            "Capillary",
            "Scumbria",
            "Violent Daimyo",
            "Urban Hazard",
            "Nightshade",
            "Kami",
            "Crimson Blossom",
            "Nitro",
            "Silver Quartz",
            "Withered Vine",
            "Hot Shot",
            "Orange Peel",
            "Candy Apple",
            "Coolant",
            "Contractor",
            "Forest Night",
            "Anodized Gunmetal",
            "Jungle"});
            this.FiveSevenSkin.Location = new System.Drawing.Point(156, 171);
            this.FiveSevenSkin.Name = "FiveSevenSkin";
            this.FiveSevenSkin.Size = new System.Drawing.Size(197, 21);
            this.FiveSevenSkin.TabIndex = 12;
            this.FiveSevenSkin.SelectedIndexChanged += new System.EventHandler(this.FiveSevenSkin_SelectedIndexChanged);
            // 
            // Tec9Skin
            // 
            this.Tec9Skin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tec9Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tec9Skin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Tec9Skin.FormattingEnabled = true;
            this.Tec9Skin.Items.AddRange(new object[] {
            "Decimator",
            "Fuel Injector",
            "Remote Control",
            "Brother",
            "Bamboozle",
            "Re-Entry",
            "Avalanche",
            "Titanium Bit",
            "Red Quartz",
            "Nuclear Threat",
            "Flash Out",
            "Fubar",
            "Snek-9",
            "Cracked Opal",
            "Cut Out",
            "Ice Cap",
            "Jambiya",
            "Isaac",
            "Sandstorm",
            "Blue Titanium",
            "Safety Net",
            "Blast From the Past",
            "Terrace",
            "Toxic",
            "Brass",
            "Ossified",
            "Rust Leaf",
            "Orange Murano",
            "Hades",
            "VariCamo",
            "Phoenix Chalk",
            "Bamboo Forest",
            "Urban DDPAT",
            "Army Mesh",
            "Groundwater",
            "Tornado"});
            this.Tec9Skin.Location = new System.Drawing.Point(156, 144);
            this.Tec9Skin.Name = "Tec9Skin";
            this.Tec9Skin.Size = new System.Drawing.Size(197, 21);
            this.Tec9Skin.TabIndex = 11;
            this.Tec9Skin.SelectedIndexChanged += new System.EventHandler(this.Tec9Skin_SelectedIndexChanged);
            // 
            // CZSkin
            // 
            this.CZSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CZSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CZSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CZSkin.FormattingEnabled = true;
            this.CZSkin.Items.AddRange(new object[] {
            "Victoria",
            "Xiangliu",
            "Yellow Jacket",
            "The Fuschia Is Now",
            "Eco",
            "Tacticat",
            "Red Astor",
            "Pole Position",
            "Tigris",
            "Tread Plate",
            "Syndicate",
            "Chalice",
            "Circaetus",
            "Vendetta",
            "Distressed",
            "Polymer",
            "Imprint",
            "Hexane",
            "Twist",
            "Poison Dart",
            "Crimson Web",
            "Emerald Quartz",
            "Emerald",
            "Nitro",
            "Tuxedo",
            "Midnight Palm",
            "Silver",
            "Framework",
            "Jungle Dashed",
            "Indigo",
            "Army Sheen",
            "Green Plaid"});
            this.CZSkin.Location = new System.Drawing.Point(156, 117);
            this.CZSkin.Name = "CZSkin";
            this.CZSkin.Size = new System.Drawing.Size(197, 21);
            this.CZSkin.TabIndex = 10;
            this.CZSkin.SelectedIndexChanged += new System.EventHandler(this.CZSkin_SelectedIndexChanged);
            // 
            // P250Skin
            // 
            this.P250Skin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.P250Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P250Skin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.P250Skin.FormattingEnabled = true;
            this.P250Skin.Items.AddRange(new object[] {
            "See Ya Later",
            "Asiimov",
            "Muertos",
            "Cartel",
            "Undertow",
            "Mehndi",
            "Franklin",
            "Cyber Shell",
            "Inferno",
            "X-Ray",
            "Nevermore",
            "Red Rock",
            "Wingshot",
            "Supernova",
            "Splash",
            "Digital Architect",
            "Vino Primo",
            "Nuclear Threat",
            "Contaminant",
            "Cassette",
            "Verdigris",
            "Ripple",
            "Iron Clad",
            "Valence",
            "Steel Disruption",
            "Hive",
            "Black & Tan",
            "Bengal Tiger",
            "Exchanger",
            "Whiteout",
            "Modern Hunter",
            "Dark Filigree",
            "Crimson Kimono",
            "Contamination",
            "Metallic DDPAT",
            "Facets",
            "Gunsmoke",
            "Drought",
            "Forest Night",
            "Facility Draft",
            "Mint Kimono",
            "Boreal Forest",
            "Sand Dune",
            "Bone Mask"});
            this.P250Skin.Location = new System.Drawing.Point(156, 89);
            this.P250Skin.Name = "P250Skin";
            this.P250Skin.Size = new System.Drawing.Size(197, 21);
            this.P250Skin.TabIndex = 9;
            this.P250Skin.SelectedIndexChanged += new System.EventHandler(this.P250Skin_SelectedIndexChanged);
            // 
            // BerettaSkin
            // 
            this.BerettaSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BerettaSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BerettaSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.BerettaSkin.FormattingEnabled = true;
            this.BerettaSkin.Items.AddRange(new object[] {
            "Melondrama",
            "Cobra Strike",
            "Twin Turbo",
            "Dezastre",
            "Royal Consorts",
            "Urban Shock",
            "Marina",
            "Hemoglobin",
            "Duelist",
            "Cobalt Quartz",
            "Demolition",
            "Tread",
            "Balance",
            "Elite 1.6",
            "Shred",
            "Ventilators",
            "Cartel",
            "Dualing Dragons",
            "Retribution",
            "Panther",
            "Black Limba",
            "Emerald",
            "Anodized Navy",
            "Drift Wood",
            "Switch Board",
            "Pyre",
            "Stained",
            "Oil Change",
            "Heist",
            "Moon in Libra",
            "Briar",
            "Contractor",
            "Colony"});
            this.BerettaSkin.Location = new System.Drawing.Point(156, 62);
            this.BerettaSkin.Name = "BerettaSkin";
            this.BerettaSkin.Size = new System.Drawing.Size(197, 21);
            this.BerettaSkin.TabIndex = 8;
            this.BerettaSkin.SelectedIndexChanged += new System.EventHandler(this.BerettaSkin_SelectedIndexChanged);
            // 
            // GlockSkin
            // 
            this.GlockSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GlockSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GlockSkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.GlockSkin.FormattingEnabled = true;
            this.GlockSkin.Items.AddRange(new object[] {
            "Neo-Noir",
            "Bullet Queen",
            "Wasteland Rebel",
            "Snack Attack",
            "Vogue",
            "Water Elemental",
            "Twilight Galaxy",
            "Moonrise",
            "Weasel",
            "Royal Legion",
            "Grinder",
            "Steel Disruption",
            "Dragon Tattoo",
            "Pink DDPAT",
            "Franklin",
            "Synth Leaf",
            "Nuclear Garden",
            "Fade",
            "Brass",
            "Clear Polymer",
            "Sacrifice",
            "Oxide Blaze",
            "Warhawk",
            "Off World",
            "Ironwork",
            "Wraiths",
            "Bunsen Burner",
            "Catacombs",
            "Blue Fissure",
            "Reactor",
            "Candy Apple",
            "Red Tire",
            "High Beam",
            "Night",
            "Death Rattle",
            "Groundwater",
            "Sand Dune"});
            this.GlockSkin.Location = new System.Drawing.Point(156, 33);
            this.GlockSkin.Name = "GlockSkin";
            this.GlockSkin.Size = new System.Drawing.Size(197, 21);
            this.GlockSkin.TabIndex = 7;
            this.GlockSkin.SelectedIndexChanged += new System.EventHandler(this.GlockSkin_SelectedIndexChanged);
            // 
            // FiveSeven
            // 
            this.FiveSeven.AutoSize = true;
            this.FiveSeven.Location = new System.Drawing.Point(6, 171);
            this.FiveSeven.Name = "FiveSeven";
            this.FiveSeven.Size = new System.Drawing.Size(61, 13);
            this.FiveSeven.TabIndex = 6;
            this.FiveSeven.Text = "Five-Seven";
            // 
            // Tec9
            // 
            this.Tec9.AutoSize = true;
            this.Tec9.Location = new System.Drawing.Point(7, 144);
            this.Tec9.Name = "Tec9";
            this.Tec9.Size = new System.Drawing.Size(32, 13);
            this.Tec9.TabIndex = 5;
            this.Tec9.Text = "Tec-9";
            // 
            // DesertEagle
            // 
            this.DesertEagle.AutoSize = true;
            this.DesertEagle.Location = new System.Drawing.Point(6, 198);
            this.DesertEagle.Name = "DesertEagle";
            this.DesertEagle.Size = new System.Drawing.Size(71, 13);
            this.DesertEagle.TabIndex = 4;
            this.DesertEagle.Text = "Desert Eagle";
            // 
            // CZ
            // 
            this.CZ.AutoSize = true;
            this.CZ.Location = new System.Drawing.Point(6, 117);
            this.CZ.Name = "CZ";
            this.CZ.Size = new System.Drawing.Size(61, 13);
            this.CZ.TabIndex = 3;
            this.CZ.Text = "CZ75-Auto";
            // 
            // p250
            // 
            this.p250.AutoSize = true;
            this.p250.Location = new System.Drawing.Point(6, 89);
            this.p250.Name = "p250";
            this.p250.Size = new System.Drawing.Size(31, 13);
            this.p250.TabIndex = 2;
            this.p250.Text = "P250";
            // 
            // Dual
            // 
            this.Dual.AutoSize = true;
            this.Dual.Location = new System.Drawing.Point(6, 62);
            this.Dual.Name = "Dual";
            this.Dual.Size = new System.Drawing.Size(71, 13);
            this.Dual.TabIndex = 1;
            this.Dual.Text = "Dual Beretta";
            // 
            // Glock
            // 
            this.Glock.AutoSize = true;
            this.Glock.Location = new System.Drawing.Point(6, 33);
            this.Glock.Name = "Glock";
            this.Glock.Size = new System.Drawing.Size(51, 13);
            this.Glock.TabIndex = 0;
            this.Glock.Text = "Glock-18";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(396, 461);
            this.Controls.Add(this.SkinChanger);
            this.Controls.Add(this.Aim);
            this.Controls.Add(this.ESP);
            this.Controls.Add(this.Misc);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 500);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CoolHack";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.ESP.ResumeLayout(false);
            this.ESP.PerformLayout();
            this.Aim.ResumeLayout(false);
            this.Aim.PerformLayout();
            this.SkinChanger.ResumeLayout(false);
            this.Pistols.ResumeLayout(false);
            this.Pistols.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Misc;
        public System.Windows.Forms.CheckBox Thirdperson;
        public System.Windows.Forms.CheckBox NoFlash;
        public System.Windows.Forms.CheckBox Bhop;
        public System.Windows.Forms.GroupBox ESP;
        public System.Windows.Forms.CheckBox Fov;
        public System.Windows.Forms.CheckBox Glow;
        public System.Windows.Forms.GroupBox Aim;
        public System.Windows.Forms.CheckBox Triggerbot;
        public System.Windows.Forms.TextBox TriggerbotBind;
        public System.Windows.Forms.TextBox ThirdpersonBind;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label csgopid;
        public System.Windows.Forms.TabControl SkinChanger;
        public System.Windows.Forms.TabPage Pistols;
        public System.Windows.Forms.Label USP;
        public System.Windows.Forms.ComboBox USPSkin;
        public System.Windows.Forms.ComboBox DesertEagleSkin;
        public System.Windows.Forms.ComboBox FiveSevenSkin;
        public System.Windows.Forms.ComboBox Tec9Skin;
        public System.Windows.Forms.ComboBox CZSkin;
        public System.Windows.Forms.ComboBox P250Skin;
        public System.Windows.Forms.ComboBox BerettaSkin;
        public System.Windows.Forms.ComboBox GlockSkin;
        public System.Windows.Forms.Label FiveSeven;
        public System.Windows.Forms.Label Tec9;
        public System.Windows.Forms.Label DesertEagle;
        public System.Windows.Forms.Label CZ;
        public System.Windows.Forms.Label p250;
        public System.Windows.Forms.Label Dual;
        public System.Windows.Forms.Label Glock;
        private System.Windows.Forms.Button cfgsave;
        private System.Windows.Forms.Button loadcfg;
        public System.Windows.Forms.CheckBox Radar;
    }
}

