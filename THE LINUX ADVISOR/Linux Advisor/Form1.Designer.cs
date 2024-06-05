namespace Linux_Advisor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_Experience = new System.Windows.Forms.GroupBox();
            this.btn_Accustomed = new System.Windows.Forms.Button();
            this.btn_Expert = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Advanced = new System.Windows.Forms.Button();
            this.gbx_Purpose = new System.Windows.Forms.GroupBox();
            this.btn_Server = new System.Windows.Forms.Button();
            this.btn_HomeServer = new System.Windows.Forms.Button();
            this.btn_Work = new System.Windows.Forms.Button();
            this.btn_Gaming = new System.Windows.Forms.Button();
            this.btn_DailyDriver = new System.Windows.Forms.Button();
            this.btn_Education = new System.Windows.Forms.Button();
            this.gbx_Stability = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Very = new System.Windows.Forms.Button();
            this.btn_NotAtAll = new System.Windows.Forms.Button();
            this.btn_Extremely = new System.Windows.Forms.Button();
            this.btn_Usable = new System.Windows.Forms.Button();
            this.gbx_Release = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_RollingRelease = new System.Windows.Forms.Button();
            this.btn_SeasonalRelease = new System.Windows.Forms.Button();
            this.gbx_Interface = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_WM = new System.Windows.Forms.Button();
            this.btn_DE = new System.Windows.Forms.Button();
            this.gbx_DisplayServer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Wayland = new System.Windows.Forms.Button();
            this.btn_X11 = new System.Windows.Forms.Button();
            this.pbx_GUI = new System.Windows.Forms.PictureBox();
            this.gbx_Distros = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_VisitDistro = new System.Windows.Forms.Button();
            this.lbx_RecommendedDistributions = new System.Windows.Forms.ListBox();
            this.btn_Ventoy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.wb_Youtube = new System.Windows.Forms.WebBrowser();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.lbl_VideoLink = new System.Windows.Forms.Label();
            this.gbx_WM_Drop = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_WM_Check = new System.Windows.Forms.Button();
            this.gbx_DE_Drop = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_DE_Check = new System.Windows.Forms.Button();
            this.gbx_Experience.SuspendLayout();
            this.gbx_Purpose.SuspendLayout();
            this.gbx_Stability.SuspendLayout();
            this.gbx_Release.SuspendLayout();
            this.gbx_Interface.SuspendLayout();
            this.gbx_DisplayServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_GUI)).BeginInit();
            this.gbx_Distros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbx_WM_Drop.SuspendLayout();
            this.gbx_DE_Drop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(266, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO THE GNU/LINUX ADVISOR";
            // 
            // gbx_Experience
            // 
            this.gbx_Experience.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Experience.Controls.Add(this.btn_Accustomed);
            this.gbx_Experience.Controls.Add(this.btn_Expert);
            this.gbx_Experience.Controls.Add(this.btn_New);
            this.gbx_Experience.Controls.Add(this.btn_Advanced);
            this.gbx_Experience.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Experience.Location = new System.Drawing.Point(11, 110);
            this.gbx_Experience.Name = "gbx_Experience";
            this.gbx_Experience.Size = new System.Drawing.Size(776, 91);
            this.gbx_Experience.TabIndex = 1;
            this.gbx_Experience.TabStop = false;
            this.gbx_Experience.Text = "WHAT IS YOUR EXPERIENCE LEVEL WITH LINUX?";
            this.gbx_Experience.Enter += new System.EventHandler(this.gbx_Experience_Enter);
            // 
            // btn_Accustomed
            // 
            this.btn_Accustomed.BackColor = System.Drawing.Color.Tan;
            this.btn_Accustomed.Location = new System.Drawing.Point(205, 31);
            this.btn_Accustomed.Name = "btn_Accustomed";
            this.btn_Accustomed.Size = new System.Drawing.Size(180, 42);
            this.btn_Accustomed.TabIndex = 1;
            this.btn_Accustomed.Text = "ACCUSTOMED";
            this.btn_Accustomed.UseVisualStyleBackColor = false;
            this.btn_Accustomed.Click += new System.EventHandler(this.btn_Accustomed_Click);
            // 
            // btn_Expert
            // 
            this.btn_Expert.BackColor = System.Drawing.Color.Tan;
            this.btn_Expert.Location = new System.Drawing.Point(577, 31);
            this.btn_Expert.Name = "btn_Expert";
            this.btn_Expert.Size = new System.Drawing.Size(180, 42);
            this.btn_Expert.TabIndex = 1;
            this.btn_Expert.Text = "EXPERT";
            this.btn_Expert.UseVisualStyleBackColor = false;
            this.btn_Expert.Click += new System.EventHandler(this.btn_Expert_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Tan;
            this.btn_New.Location = new System.Drawing.Point(20, 31);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(180, 42);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "NEW";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Advanced
            // 
            this.btn_Advanced.BackColor = System.Drawing.Color.Tan;
            this.btn_Advanced.Location = new System.Drawing.Point(391, 31);
            this.btn_Advanced.Name = "btn_Advanced";
            this.btn_Advanced.Size = new System.Drawing.Size(180, 42);
            this.btn_Advanced.TabIndex = 0;
            this.btn_Advanced.Text = "ADVANCED";
            this.btn_Advanced.UseVisualStyleBackColor = false;
            this.btn_Advanced.Click += new System.EventHandler(this.btn_Advanced_Click);
            // 
            // gbx_Purpose
            // 
            this.gbx_Purpose.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Purpose.Controls.Add(this.btn_Server);
            this.gbx_Purpose.Controls.Add(this.btn_HomeServer);
            this.gbx_Purpose.Controls.Add(this.btn_Work);
            this.gbx_Purpose.Controls.Add(this.btn_Gaming);
            this.gbx_Purpose.Controls.Add(this.btn_DailyDriver);
            this.gbx_Purpose.Controls.Add(this.btn_Education);
            this.gbx_Purpose.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Purpose.Location = new System.Drawing.Point(12, 207);
            this.gbx_Purpose.Name = "gbx_Purpose";
            this.gbx_Purpose.Size = new System.Drawing.Size(776, 141);
            this.gbx_Purpose.TabIndex = 2;
            this.gbx_Purpose.TabStop = false;
            this.gbx_Purpose.Text = "WHAT IS THE PURPOSE OF THE INSTALL?";
            this.gbx_Purpose.Visible = false;
            this.gbx_Purpose.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.Color.Tan;
            this.btn_Server.Location = new System.Drawing.Point(515, 79);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(242, 42);
            this.btn_Server.TabIndex = 3;
            this.btn_Server.Text = "SERVER";
            this.btn_Server.UseVisualStyleBackColor = false;
            this.btn_Server.Visible = false;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btn_HomeServer
            // 
            this.btn_HomeServer.BackColor = System.Drawing.Color.Tan;
            this.btn_HomeServer.Location = new System.Drawing.Point(267, 79);
            this.btn_HomeServer.Name = "btn_HomeServer";
            this.btn_HomeServer.Size = new System.Drawing.Size(242, 42);
            this.btn_HomeServer.TabIndex = 2;
            this.btn_HomeServer.Text = "HOME SERVER";
            this.btn_HomeServer.UseVisualStyleBackColor = false;
            this.btn_HomeServer.Visible = false;
            this.btn_HomeServer.Click += new System.EventHandler(this.btn_HomeServer_Click);
            // 
            // btn_Work
            // 
            this.btn_Work.BackColor = System.Drawing.Color.Tan;
            this.btn_Work.Location = new System.Drawing.Point(20, 79);
            this.btn_Work.Name = "btn_Work";
            this.btn_Work.Size = new System.Drawing.Size(242, 42);
            this.btn_Work.TabIndex = 1;
            this.btn_Work.Text = "WORK";
            this.btn_Work.UseVisualStyleBackColor = false;
            this.btn_Work.Visible = false;
            this.btn_Work.Click += new System.EventHandler(this.btn_Work_Click);
            // 
            // btn_Gaming
            // 
            this.btn_Gaming.BackColor = System.Drawing.Color.Tan;
            this.btn_Gaming.Location = new System.Drawing.Point(515, 31);
            this.btn_Gaming.Name = "btn_Gaming";
            this.btn_Gaming.Size = new System.Drawing.Size(242, 42);
            this.btn_Gaming.TabIndex = 1;
            this.btn_Gaming.Text = "GAMING";
            this.btn_Gaming.UseVisualStyleBackColor = false;
            this.btn_Gaming.Click += new System.EventHandler(this.btn_Gaming_Click);
            // 
            // btn_DailyDriver
            // 
            this.btn_DailyDriver.BackColor = System.Drawing.Color.Tan;
            this.btn_DailyDriver.Location = new System.Drawing.Point(20, 31);
            this.btn_DailyDriver.Name = "btn_DailyDriver";
            this.btn_DailyDriver.Size = new System.Drawing.Size(242, 42);
            this.btn_DailyDriver.TabIndex = 0;
            this.btn_DailyDriver.Text = "DAILY DRIVER";
            this.btn_DailyDriver.UseVisualStyleBackColor = false;
            this.btn_DailyDriver.Click += new System.EventHandler(this.btn_DailyDriver_Click);
            // 
            // btn_Education
            // 
            this.btn_Education.BackColor = System.Drawing.Color.Tan;
            this.btn_Education.Location = new System.Drawing.Point(268, 31);
            this.btn_Education.Name = "btn_Education";
            this.btn_Education.Size = new System.Drawing.Size(242, 42);
            this.btn_Education.TabIndex = 0;
            this.btn_Education.Text = "EDUCATION";
            this.btn_Education.UseVisualStyleBackColor = false;
            this.btn_Education.Click += new System.EventHandler(this.button8_Click);
            // 
            // gbx_Stability
            // 
            this.gbx_Stability.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Stability.Controls.Add(this.textBox1);
            this.gbx_Stability.Controls.Add(this.btn_Very);
            this.gbx_Stability.Controls.Add(this.btn_NotAtAll);
            this.gbx_Stability.Controls.Add(this.btn_Extremely);
            this.gbx_Stability.Controls.Add(this.btn_Usable);
            this.gbx_Stability.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Stability.Location = new System.Drawing.Point(12, 589);
            this.gbx_Stability.Name = "gbx_Stability";
            this.gbx_Stability.Size = new System.Drawing.Size(776, 154);
            this.gbx_Stability.TabIndex = 3;
            this.gbx_Stability.TabStop = false;
            this.gbx_Stability.Text = "HOW STABLE DO YOU WANT IT TO BE?";
            this.gbx_Stability.Visible = false;
            this.gbx_Stability.Enter += new System.EventHandler(this.gbx_Stability_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(737, 55);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btn_Very
            // 
            this.btn_Very.BackColor = System.Drawing.Color.Tan;
            this.btn_Very.Location = new System.Drawing.Point(205, 31);
            this.btn_Very.Name = "btn_Very";
            this.btn_Very.Size = new System.Drawing.Size(180, 42);
            this.btn_Very.TabIndex = 1;
            this.btn_Very.Text = "VERY";
            this.btn_Very.UseVisualStyleBackColor = false;
            this.btn_Very.Click += new System.EventHandler(this.btn_Very_Click);
            // 
            // btn_NotAtAll
            // 
            this.btn_NotAtAll.BackColor = System.Drawing.Color.Tan;
            this.btn_NotAtAll.Location = new System.Drawing.Point(577, 31);
            this.btn_NotAtAll.Name = "btn_NotAtAll";
            this.btn_NotAtAll.Size = new System.Drawing.Size(180, 42);
            this.btn_NotAtAll.TabIndex = 1;
            this.btn_NotAtAll.Text = "NOT AT ALL";
            this.btn_NotAtAll.UseVisualStyleBackColor = false;
            this.btn_NotAtAll.Visible = false;
            this.btn_NotAtAll.Click += new System.EventHandler(this.btn_NotAtAll_Click);
            // 
            // btn_Extremely
            // 
            this.btn_Extremely.BackColor = System.Drawing.Color.Tan;
            this.btn_Extremely.Location = new System.Drawing.Point(20, 31);
            this.btn_Extremely.Name = "btn_Extremely";
            this.btn_Extremely.Size = new System.Drawing.Size(180, 42);
            this.btn_Extremely.TabIndex = 0;
            this.btn_Extremely.Text = "EXTREMELY";
            this.btn_Extremely.UseVisualStyleBackColor = false;
            this.btn_Extremely.Click += new System.EventHandler(this.btn_Extremely_Click);
            // 
            // btn_Usable
            // 
            this.btn_Usable.BackColor = System.Drawing.Color.Tan;
            this.btn_Usable.Location = new System.Drawing.Point(391, 31);
            this.btn_Usable.Name = "btn_Usable";
            this.btn_Usable.Size = new System.Drawing.Size(180, 42);
            this.btn_Usable.TabIndex = 0;
            this.btn_Usable.Text = "USABLE";
            this.btn_Usable.UseVisualStyleBackColor = false;
            this.btn_Usable.Visible = false;
            this.btn_Usable.Click += new System.EventHandler(this.btn_Usable_Click);
            // 
            // gbx_Release
            // 
            this.gbx_Release.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Release.Controls.Add(this.textBox2);
            this.gbx_Release.Controls.Add(this.btn_RollingRelease);
            this.gbx_Release.Controls.Add(this.btn_SeasonalRelease);
            this.gbx_Release.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Release.Location = new System.Drawing.Point(12, 353);
            this.gbx_Release.Name = "gbx_Release";
            this.gbx_Release.Size = new System.Drawing.Size(776, 230);
            this.gbx_Release.TabIndex = 4;
            this.gbx_Release.TabStop = false;
            this.gbx_Release.Text = "DO YOU WANT A ROLLING OR SEASONAL RELEASE?";
            this.gbx_Release.Visible = false;
            this.gbx_Release.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(20, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(737, 135);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btn_RollingRelease
            // 
            this.btn_RollingRelease.BackColor = System.Drawing.Color.Tan;
            this.btn_RollingRelease.Location = new System.Drawing.Point(391, 31);
            this.btn_RollingRelease.Name = "btn_RollingRelease";
            this.btn_RollingRelease.Size = new System.Drawing.Size(366, 42);
            this.btn_RollingRelease.TabIndex = 1;
            this.btn_RollingRelease.Text = "ROLLING RELEASE";
            this.btn_RollingRelease.UseVisualStyleBackColor = false;
            this.btn_RollingRelease.Visible = false;
            this.btn_RollingRelease.Click += new System.EventHandler(this.btn_RollingRelease_Click);
            // 
            // btn_SeasonalRelease
            // 
            this.btn_SeasonalRelease.BackColor = System.Drawing.Color.Tan;
            this.btn_SeasonalRelease.Location = new System.Drawing.Point(19, 31);
            this.btn_SeasonalRelease.Name = "btn_SeasonalRelease";
            this.btn_SeasonalRelease.Size = new System.Drawing.Size(366, 42);
            this.btn_SeasonalRelease.TabIndex = 0;
            this.btn_SeasonalRelease.Text = "SEASONAL RELEASE";
            this.btn_SeasonalRelease.UseVisualStyleBackColor = false;
            this.btn_SeasonalRelease.Click += new System.EventHandler(this.btn_SeasonalRelease_Click);
            // 
            // gbx_Interface
            // 
            this.gbx_Interface.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Interface.Controls.Add(this.textBox3);
            this.gbx_Interface.Controls.Add(this.btn_WM);
            this.gbx_Interface.Controls.Add(this.btn_DE);
            this.gbx_Interface.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Interface.Location = new System.Drawing.Point(12, 749);
            this.gbx_Interface.Name = "gbx_Interface";
            this.gbx_Interface.Size = new System.Drawing.Size(776, 187);
            this.gbx_Interface.TabIndex = 6;
            this.gbx_Interface.TabStop = false;
            this.gbx_Interface.Text = "WHICH USER INTERFACE DO YOU PREFER?";
            this.gbx_Interface.Visible = false;
            this.gbx_Interface.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(20, 79);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(737, 91);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // btn_WM
            // 
            this.btn_WM.BackColor = System.Drawing.Color.Tan;
            this.btn_WM.Location = new System.Drawing.Point(391, 31);
            this.btn_WM.Name = "btn_WM";
            this.btn_WM.Size = new System.Drawing.Size(366, 42);
            this.btn_WM.TabIndex = 1;
            this.btn_WM.Text = "WINDOW MANAGER";
            this.btn_WM.UseVisualStyleBackColor = false;
            this.btn_WM.Visible = false;
            this.btn_WM.Click += new System.EventHandler(this.btn_WM_Click);
            // 
            // btn_DE
            // 
            this.btn_DE.BackColor = System.Drawing.Color.Tan;
            this.btn_DE.Location = new System.Drawing.Point(19, 31);
            this.btn_DE.Name = "btn_DE";
            this.btn_DE.Size = new System.Drawing.Size(366, 42);
            this.btn_DE.TabIndex = 0;
            this.btn_DE.Text = "DESKTOP ENVIRONMENT";
            this.btn_DE.UseVisualStyleBackColor = false;
            this.btn_DE.Click += new System.EventHandler(this.btn_DE_Click);
            // 
            // gbx_DisplayServer
            // 
            this.gbx_DisplayServer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_DisplayServer.Controls.Add(this.button1);
            this.gbx_DisplayServer.Controls.Add(this.button2);
            this.gbx_DisplayServer.Controls.Add(this.textBox4);
            this.gbx_DisplayServer.Controls.Add(this.btn_Wayland);
            this.gbx_DisplayServer.Controls.Add(this.btn_X11);
            this.gbx_DisplayServer.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_DisplayServer.Location = new System.Drawing.Point(795, 614);
            this.gbx_DisplayServer.Name = "gbx_DisplayServer";
            this.gbx_DisplayServer.Size = new System.Drawing.Size(606, 322);
            this.gbx_DisplayServer.TabIndex = 11;
            this.gbx_DisplayServer.TabStop = false;
            this.gbx_DisplayServer.Text = "DISTRIBUTION FILTERS";
            this.gbx_DisplayServer.Visible = false;
            this.gbx_DisplayServer.Enter += new System.EventHandler(this.gbx_DisplayServer_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(307, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "X86_64 -64bit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Location = new System.Drawing.Point(18, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "X86 - 32bit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(20, 79);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(565, 184);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // btn_Wayland
            // 
            this.btn_Wayland.BackColor = System.Drawing.Color.Tan;
            this.btn_Wayland.Location = new System.Drawing.Point(307, 31);
            this.btn_Wayland.Name = "btn_Wayland";
            this.btn_Wayland.Size = new System.Drawing.Size(278, 42);
            this.btn_Wayland.TabIndex = 1;
            this.btn_Wayland.Text = "WAYLAND";
            this.btn_Wayland.UseVisualStyleBackColor = false;
            this.btn_Wayland.Click += new System.EventHandler(this.btn_Wayland_Click);
            // 
            // btn_X11
            // 
            this.btn_X11.BackColor = System.Drawing.Color.Tan;
            this.btn_X11.Location = new System.Drawing.Point(18, 31);
            this.btn_X11.Name = "btn_X11";
            this.btn_X11.Size = new System.Drawing.Size(279, 42);
            this.btn_X11.TabIndex = 0;
            this.btn_X11.Text = "X11";
            this.btn_X11.UseVisualStyleBackColor = false;
            this.btn_X11.Click += new System.EventHandler(this.btn_X11_Click);
            // 
            // pbx_GUI
            // 
            this.pbx_GUI.Location = new System.Drawing.Point(793, 207);
            this.pbx_GUI.Name = "pbx_GUI";
            this.pbx_GUI.Size = new System.Drawing.Size(606, 402);
            this.pbx_GUI.TabIndex = 12;
            this.pbx_GUI.TabStop = false;
            this.pbx_GUI.Click += new System.EventHandler(this.pbx_GUI_Click);
            // 
            // gbx_Distros
            // 
            this.gbx_Distros.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_Distros.Controls.Add(this.textBox6);
            this.gbx_Distros.Controls.Add(this.btn_VisitDistro);
            this.gbx_Distros.Controls.Add(this.lbx_RecommendedDistributions);
            this.gbx_Distros.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Distros.Location = new System.Drawing.Point(1408, 14);
            this.gbx_Distros.Name = "gbx_Distros";
            this.gbx_Distros.Size = new System.Drawing.Size(321, 673);
            this.gbx_Distros.TabIndex = 13;
            this.gbx_Distros.TabStop = false;
            this.gbx_Distros.Text = "RECOMMENDED DISTROS";
            this.gbx_Distros.Enter += new System.EventHandler(this.gbx_Distros_Enter);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 603);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(290, 55);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "* Choose a distro from the list and push \"Visit Distro\", it will take you to the " +
    "download page for the distro.";
            // 
            // btn_VisitDistro
            // 
            this.btn_VisitDistro.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_VisitDistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VisitDistro.Location = new System.Drawing.Point(16, 555);
            this.btn_VisitDistro.Name = "btn_VisitDistro";
            this.btn_VisitDistro.Size = new System.Drawing.Size(290, 42);
            this.btn_VisitDistro.TabIndex = 2;
            this.btn_VisitDistro.Text = "VISIT DISTRO";
            this.btn_VisitDistro.UseVisualStyleBackColor = false;
            this.btn_VisitDistro.Click += new System.EventHandler(this.btn_VisitDistro_Click);
            // 
            // lbx_RecommendedDistributions
            // 
            this.lbx_RecommendedDistributions.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_RecommendedDistributions.FormattingEnabled = true;
            this.lbx_RecommendedDistributions.ItemHeight = 16;
            this.lbx_RecommendedDistributions.Location = new System.Drawing.Point(16, 33);
            this.lbx_RecommendedDistributions.Name = "lbx_RecommendedDistributions";
            this.lbx_RecommendedDistributions.Size = new System.Drawing.Size(290, 516);
            this.lbx_RecommendedDistributions.TabIndex = 0;
            this.lbx_RecommendedDistributions.SelectedIndexChanged += new System.EventHandler(this.lbx_RecommendedDistributions_SelectedIndexChanged);
            // 
            // btn_Ventoy
            // 
            this.btn_Ventoy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ventoy.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventoy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ventoy.Location = new System.Drawing.Point(16, 31);
            this.btn_Ventoy.Name = "btn_Ventoy";
            this.btn_Ventoy.Size = new System.Drawing.Size(286, 42);
            this.btn_Ventoy.TabIndex = 14;
            this.btn_Ventoy.Text = "VENTOY ";
            this.btn_Ventoy.UseVisualStyleBackColor = false;
            this.btn_Ventoy.Click += new System.EventHandler(this.btn_Ventoy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.btn_Ventoy);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1408, 693);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 243);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GET STARTED FOR REAL";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(16, 76);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(286, 156);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // wb_Youtube
            // 
            this.wb_Youtube.Location = new System.Drawing.Point(793, 207);
            this.wb_Youtube.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Youtube.Name = "wb_Youtube";
            this.wb_Youtube.Size = new System.Drawing.Size(605, 400);
            this.wb_Youtube.TabIndex = 16;
            this.wb_Youtube.Visible = false;
            this.wb_Youtube.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_Youtube_DocumentCompleted);
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(127, 943);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.ReadOnly = true;
            this.txtVideoLink.Size = new System.Drawing.Size(1603, 20);
            this.txtVideoLink.TabIndex = 17;
            this.txtVideoLink.Visible = false;
            this.txtVideoLink.TextChanged += new System.EventHandler(this.txtVideoLink_TextChanged);
            // 
            // lbl_VideoLink
            // 
            this.lbl_VideoLink.AutoSize = true;
            this.lbl_VideoLink.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VideoLink.Location = new System.Drawing.Point(13, 943);
            this.lbl_VideoLink.Name = "lbl_VideoLink";
            this.lbl_VideoLink.Size = new System.Drawing.Size(108, 20);
            this.lbl_VideoLink.TabIndex = 18;
            this.lbl_VideoLink.Text = "VIDEO LINK";
            this.lbl_VideoLink.Visible = false;
            // 
            // gbx_WM_Drop
            // 
            this.gbx_WM_Drop.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_WM_Drop.Controls.Add(this.comboBox1);
            this.gbx_WM_Drop.Controls.Add(this.btn_WM_Check);
            this.gbx_WM_Drop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_WM_Drop.Location = new System.Drawing.Point(793, 110);
            this.gbx_WM_Drop.Name = "gbx_WM_Drop";
            this.gbx_WM_Drop.Size = new System.Drawing.Size(609, 91);
            this.gbx_WM_Drop.TabIndex = 19;
            this.gbx_WM_Drop.TabStop = false;
            this.gbx_WM_Drop.Text = "TOP WINDOW MANAGERS!";
            this.gbx_WM_Drop.Visible = false;
            this.gbx_WM_Drop.Enter += new System.EventHandler(this.gbx_WM_Drop_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_WM_Check
            // 
            this.btn_WM_Check.BackColor = System.Drawing.Color.Tan;
            this.btn_WM_Check.Location = new System.Drawing.Point(423, 31);
            this.btn_WM_Check.Name = "btn_WM_Check";
            this.btn_WM_Check.Size = new System.Drawing.Size(164, 42);
            this.btn_WM_Check.TabIndex = 1;
            this.btn_WM_Check.Text = "CHECK OUT";
            this.btn_WM_Check.UseVisualStyleBackColor = false;
            this.btn_WM_Check.Click += new System.EventHandler(this.btn_WM_Check_Click);
            // 
            // gbx_DE_Drop
            // 
            this.gbx_DE_Drop.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbx_DE_Drop.Controls.Add(this.comboBox2);
            this.gbx_DE_Drop.Controls.Add(this.btn_DE_Check);
            this.gbx_DE_Drop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_DE_Drop.Location = new System.Drawing.Point(793, 110);
            this.gbx_DE_Drop.Name = "gbx_DE_Drop";
            this.gbx_DE_Drop.Size = new System.Drawing.Size(609, 91);
            this.gbx_DE_Drop.TabIndex = 20;
            this.gbx_DE_Drop.TabStop = false;
            this.gbx_DE_Drop.Text = "TOP DESKTOP ENVIRONMENTS!";
            this.gbx_DE_Drop.Visible = false;
            this.gbx_DE_Drop.Enter += new System.EventHandler(this.gbx_DE_Drop_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(395, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_DE_Check
            // 
            this.btn_DE_Check.BackColor = System.Drawing.Color.Tan;
            this.btn_DE_Check.Location = new System.Drawing.Point(423, 31);
            this.btn_DE_Check.Name = "btn_DE_Check";
            this.btn_DE_Check.Size = new System.Drawing.Size(164, 42);
            this.btn_DE_Check.TabIndex = 1;
            this.btn_DE_Check.Text = "CHECK OUT";
            this.btn_DE_Check.UseVisualStyleBackColor = false;
            this.btn_DE_Check.Click += new System.EventHandler(this.btn_DE_Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1742, 948);
            this.Controls.Add(this.gbx_DE_Drop);
            this.Controls.Add(this.gbx_WM_Drop);
            this.Controls.Add(this.lbl_VideoLink);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.wb_Youtube);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_Distros);
            this.Controls.Add(this.pbx_GUI);
            this.Controls.Add(this.gbx_DisplayServer);
            this.Controls.Add(this.gbx_Interface);
            this.Controls.Add(this.gbx_Release);
            this.Controls.Add(this.gbx_Stability);
            this.Controls.Add(this.gbx_Purpose);
            this.Controls.Add(this.gbx_Experience);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "THE GNU/LINUX ADVISOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_Experience.ResumeLayout(false);
            this.gbx_Purpose.ResumeLayout(false);
            this.gbx_Stability.ResumeLayout(false);
            this.gbx_Stability.PerformLayout();
            this.gbx_Release.ResumeLayout(false);
            this.gbx_Release.PerformLayout();
            this.gbx_Interface.ResumeLayout(false);
            this.gbx_Interface.PerformLayout();
            this.gbx_DisplayServer.ResumeLayout(false);
            this.gbx_DisplayServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_GUI)).EndInit();
            this.gbx_Distros.ResumeLayout(false);
            this.gbx_Distros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_WM_Drop.ResumeLayout(false);
            this.gbx_DE_Drop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_Experience;
        private System.Windows.Forms.Button btn_Accustomed;
        private System.Windows.Forms.Button btn_Expert;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Advanced;
        private System.Windows.Forms.GroupBox gbx_Purpose;
        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btn_HomeServer;
        private System.Windows.Forms.Button btn_Work;
        private System.Windows.Forms.Button btn_Gaming;
        private System.Windows.Forms.Button btn_DailyDriver;
        private System.Windows.Forms.Button btn_Education;
        private System.Windows.Forms.GroupBox gbx_Stability;
        private System.Windows.Forms.Button btn_Very;
        private System.Windows.Forms.Button btn_NotAtAll;
        private System.Windows.Forms.Button btn_Extremely;
        private System.Windows.Forms.Button btn_Usable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbx_Release;
        private System.Windows.Forms.Button btn_RollingRelease;
        private System.Windows.Forms.Button btn_SeasonalRelease;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbx_Interface;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_WM;
        private System.Windows.Forms.Button btn_DE;
        private System.Windows.Forms.GroupBox gbx_DisplayServer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Wayland;
        private System.Windows.Forms.Button btn_X11;
        private System.Windows.Forms.PictureBox pbx_GUI;
        private System.Windows.Forms.GroupBox gbx_Distros;
        private System.Windows.Forms.Button btn_VisitDistro;
        private System.Windows.Forms.ListBox lbx_RecommendedDistributions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Ventoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.WebBrowser wb_Youtube;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Label lbl_VideoLink;
        private System.Windows.Forms.GroupBox gbx_WM_Drop;
        private System.Windows.Forms.Button btn_WM_Check;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbx_DE_Drop;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_DE_Check;
    }
}

