namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMode = new System.Windows.Forms.Panel();
            this.panelModesGreyOut = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnHue = new System.Windows.Forms.Button();
            this.btnTheatreChaseLights = new System.Windows.Forms.Button();
            this.btnKnightRider = new System.Windows.Forms.Button();
            this.btnBreathing = new System.Windows.Forms.Button();
            this.btnBeacon = new System.Windows.Forms.Button();
            this.btnAudioMeter = new System.Windows.Forms.Button();
            this.btnStaticColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageConnections = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHue = new System.Windows.Forms.Panel();
            this.checkBoxHueLoopmode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHueSpd = new System.Windows.Forms.NumericUpDown();
            this.trackBarHueSpd = new System.Windows.Forms.TrackBar();
            this.PanelStaticColor = new System.Windows.Forms.Panel();
            this.numericUpDownStaticColorBlue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarStaticColorBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownStaticColorGreen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarStaticColorGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownStaticColorRed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarStaticColorRed = new System.Windows.Forms.TrackBar();
            this.PanelBreathing = new System.Windows.Forms.Panel();
            this.numericUpDownBreathingSpd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarBreathingSpd = new System.Windows.Forms.TrackBar();
            this.numericUpDownBreathingBlue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarBreathingBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownBreathingGreen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarBreathingGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownBreathingRed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarBreathingRed = new System.Windows.Forms.TrackBar();
            this.panelBeacon = new System.Windows.Forms.Panel();
            this.numericUpDownBeaconSpd = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarBeaconSpd = new System.Windows.Forms.TrackBar();
            this.numericUpDownBeaconBlue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarBeaconBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownBeaconGreen = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarBeaconGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownBeaconRed = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBarBeaconRed = new System.Windows.Forms.TrackBar();
            this.panelTheatreChaseLights = new System.Windows.Forms.Panel();
            this.panelTheatreChaseLights2 = new System.Windows.Forms.Panel();
            this.numericUpDownTheatreChaseLightsBlue = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBarTheatreChaseLightsBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownTheatreChaseLightsGreen = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBarTheatreChaseLightsGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownTheatreChaseLightsRed = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBarTheatreChaseLightsRed = new System.Windows.Forms.TrackBar();
            this.checkBoxTheatreChaseLightsColorWheel = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDownTheatreChaseLightsSpd = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBarTheatreChaseLightsSpd = new System.Windows.Forms.TrackBar();
            this.panelKnightRider = new System.Windows.Forms.Panel();
            this.numericUpDownKnightRiderSpd = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBarKnightRiderSpd = new System.Windows.Forms.TrackBar();
            this.numericUpDownKnightRiderBlue = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.trackBarKnightRiderBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownKnightRiderGreen = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBarKnightRiderGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownKnightRiderRed = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.trackBarKnightRiderRed = new System.Windows.Forms.TrackBar();
            this.panelManageConnections = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.StatusLine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelAudioMeter = new System.Windows.Forms.Panel();
            this.checkBoxAudioMeterChangeColor = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.numericUpDownAudioMeterRed = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.trackBarAudioMeterRed = new System.Windows.Forms.TrackBar();
            this.panelAudiometer2 = new System.Windows.Forms.Panel();
            this.numericUpDownAudioMeterBlue = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.trackBarAudioMeterBlue = new System.Windows.Forms.TrackBar();
            this.numericUpDownAudioMeterGreen = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.trackBarAudioMeterGreen = new System.Windows.Forms.TrackBar();
            this.panelOff = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMode.SuspendLayout();
            this.panelModesGreyOut.SuspendLayout();
            this.PanelHue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueSpd)).BeginInit();
            this.PanelStaticColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorRed)).BeginInit();
            this.PanelBreathing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingRed)).BeginInit();
            this.panelBeacon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconRed)).BeginInit();
            this.panelTheatreChaseLights.SuspendLayout();
            this.panelTheatreChaseLights2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsSpd)).BeginInit();
            this.panelKnightRider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderRed)).BeginInit();
            this.panelManageConnections.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelAudioMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterRed)).BeginInit();
            this.panelAudiometer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterGreen)).BeginInit();
            this.panelOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMode
            // 
            this.PanelMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PanelMode.Controls.Add(this.panelModesGreyOut);
            this.PanelMode.Controls.Add(this.label2);
            this.PanelMode.Controls.Add(this.btnManageConnections);
            this.PanelMode.Location = new System.Drawing.Point(0, -2);
            this.PanelMode.Name = "PanelMode";
            this.PanelMode.Size = new System.Drawing.Size(248, 548);
            this.PanelMode.TabIndex = 0;
            // 
            // panelModesGreyOut
            // 
            this.panelModesGreyOut.Controls.Add(this.btnOff);
            this.panelModesGreyOut.Controls.Add(this.btnHue);
            this.panelModesGreyOut.Controls.Add(this.btnTheatreChaseLights);
            this.panelModesGreyOut.Controls.Add(this.btnKnightRider);
            this.panelModesGreyOut.Controls.Add(this.btnBreathing);
            this.panelModesGreyOut.Controls.Add(this.btnBeacon);
            this.panelModesGreyOut.Controls.Add(this.btnAudioMeter);
            this.panelModesGreyOut.Controls.Add(this.btnStaticColor);
            this.panelModesGreyOut.Enabled = false;
            this.panelModesGreyOut.Location = new System.Drawing.Point(40, 72);
            this.panelModesGreyOut.Name = "panelModesGreyOut";
            this.panelModesGreyOut.Size = new System.Drawing.Size(207, 341);
            this.panelModesGreyOut.TabIndex = 24;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(5, 272);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(202, 33);
            this.btnOff.TabIndex = 22;
            this.btnOff.Text = "Off";
            this.btnOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnHue
            // 
            this.btnHue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnHue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHue.FlatAppearance.BorderSize = 0;
            this.btnHue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnHue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHue.ForeColor = System.Drawing.Color.White;
            this.btnHue.Location = new System.Drawing.Point(5, 0);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(202, 33);
            this.btnHue.TabIndex = 12;
            this.btnHue.Text = "Hue";
            this.btnHue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHue.UseVisualStyleBackColor = false;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
            // 
            // btnTheatreChaseLights
            // 
            this.btnTheatreChaseLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTheatreChaseLights.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnTheatreChaseLights.FlatAppearance.BorderSize = 0;
            this.btnTheatreChaseLights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTheatreChaseLights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnTheatreChaseLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheatreChaseLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTheatreChaseLights.ForeColor = System.Drawing.Color.White;
            this.btnTheatreChaseLights.Location = new System.Drawing.Point(5, 156);
            this.btnTheatreChaseLights.Name = "btnTheatreChaseLights";
            this.btnTheatreChaseLights.Size = new System.Drawing.Size(202, 33);
            this.btnTheatreChaseLights.TabIndex = 19;
            this.btnTheatreChaseLights.Text = "Theatre Chase Lights";
            this.btnTheatreChaseLights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheatreChaseLights.UseVisualStyleBackColor = false;
            this.btnTheatreChaseLights.Click += new System.EventHandler(this.btnTheatreChaseLights_Click);
            // 
            // btnKnightRider
            // 
            this.btnKnightRider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnKnightRider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnKnightRider.FlatAppearance.BorderSize = 0;
            this.btnKnightRider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnKnightRider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnKnightRider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnightRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKnightRider.ForeColor = System.Drawing.Color.White;
            this.btnKnightRider.Location = new System.Drawing.Point(5, 195);
            this.btnKnightRider.Name = "btnKnightRider";
            this.btnKnightRider.Size = new System.Drawing.Size(202, 33);
            this.btnKnightRider.TabIndex = 20;
            this.btnKnightRider.Text = "Knight Rider";
            this.btnKnightRider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKnightRider.UseVisualStyleBackColor = false;
            this.btnKnightRider.Click += new System.EventHandler(this.btnKnightRider_Click);
            // 
            // btnBreathing
            // 
            this.btnBreathing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBreathing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBreathing.FlatAppearance.BorderSize = 0;
            this.btnBreathing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBreathing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnBreathing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreathing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBreathing.ForeColor = System.Drawing.Color.White;
            this.btnBreathing.Location = new System.Drawing.Point(5, 78);
            this.btnBreathing.Name = "btnBreathing";
            this.btnBreathing.Size = new System.Drawing.Size(202, 33);
            this.btnBreathing.TabIndex = 16;
            this.btnBreathing.Text = "Breathing";
            this.btnBreathing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreathing.UseVisualStyleBackColor = false;
            this.btnBreathing.Click += new System.EventHandler(this.btnBreathing_Click);
            // 
            // btnBeacon
            // 
            this.btnBeacon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBeacon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBeacon.FlatAppearance.BorderSize = 0;
            this.btnBeacon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBeacon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnBeacon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBeacon.ForeColor = System.Drawing.Color.White;
            this.btnBeacon.Location = new System.Drawing.Point(5, 117);
            this.btnBeacon.Name = "btnBeacon";
            this.btnBeacon.Size = new System.Drawing.Size(202, 33);
            this.btnBeacon.TabIndex = 18;
            this.btnBeacon.Text = "Beacon";
            this.btnBeacon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeacon.UseVisualStyleBackColor = false;
            this.btnBeacon.Click += new System.EventHandler(this.btnBeacon_Click);
            // 
            // btnAudioMeter
            // 
            this.btnAudioMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAudioMeter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAudioMeter.FlatAppearance.BorderSize = 0;
            this.btnAudioMeter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAudioMeter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAudioMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudioMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAudioMeter.ForeColor = System.Drawing.Color.White;
            this.btnAudioMeter.Location = new System.Drawing.Point(5, 234);
            this.btnAudioMeter.Name = "btnAudioMeter";
            this.btnAudioMeter.Size = new System.Drawing.Size(202, 33);
            this.btnAudioMeter.TabIndex = 21;
            this.btnAudioMeter.Text = "Audio Meter";
            this.btnAudioMeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAudioMeter.UseVisualStyleBackColor = false;
            this.btnAudioMeter.Click += new System.EventHandler(this.btnAudioMeter_Click);
            // 
            // btnStaticColor
            // 
            this.btnStaticColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnStaticColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnStaticColor.FlatAppearance.BorderSize = 0;
            this.btnStaticColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStaticColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnStaticColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaticColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStaticColor.ForeColor = System.Drawing.Color.White;
            this.btnStaticColor.Location = new System.Drawing.Point(5, 39);
            this.btnStaticColor.Name = "btnStaticColor";
            this.btnStaticColor.Size = new System.Drawing.Size(202, 33);
            this.btnStaticColor.TabIndex = 14;
            this.btnStaticColor.Text = "Static Color";
            this.btnStaticColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaticColor.UseVisualStyleBackColor = false;
            this.btnStaticColor.Click += new System.EventHandler(this.btnStaticColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "MODES";
            // 
            // btnManageConnections
            // 
            this.btnManageConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnManageConnections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnManageConnections.FlatAppearance.BorderSize = 0;
            this.btnManageConnections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnManageConnections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnManageConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageConnections.ForeColor = System.Drawing.Color.White;
            this.btnManageConnections.Location = new System.Drawing.Point(46, 486);
            this.btnManageConnections.Name = "btnManageConnections";
            this.btnManageConnections.Size = new System.Drawing.Size(202, 33);
            this.btnManageConnections.TabIndex = 22;
            this.btnManageConnections.Text = "Manage Connections";
            this.btnManageConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageConnections.UseVisualStyleBackColor = false;
            this.btnManageConnections.Click += new System.EventHandler(this.btnManageConnections_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Speed";
            // 
            // PanelHue
            // 
            this.PanelHue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.PanelHue.Controls.Add(this.checkBoxHueLoopmode);
            this.PanelHue.Controls.Add(this.label3);
            this.PanelHue.Controls.Add(this.numericUpDownHueSpd);
            this.PanelHue.Controls.Add(this.label1);
            this.PanelHue.Controls.Add(this.trackBarHueSpd);
            this.PanelHue.Location = new System.Drawing.Point(253, 70);
            this.PanelHue.Name = "PanelHue";
            this.PanelHue.Size = new System.Drawing.Size(463, 461);
            this.PanelHue.TabIndex = 18;
            this.PanelHue.Visible = false;
            // 
            // checkBoxHueLoopmode
            // 
            this.checkBoxHueLoopmode.AutoSize = true;
            this.checkBoxHueLoopmode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.checkBoxHueLoopmode.FlatAppearance.BorderSize = 0;
            this.checkBoxHueLoopmode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.checkBoxHueLoopmode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxHueLoopmode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHueLoopmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHueLoopmode.Location = new System.Drawing.Point(387, 108);
            this.checkBoxHueLoopmode.Name = "checkBoxHueLoopmode";
            this.checkBoxHueLoopmode.Size = new System.Drawing.Size(12, 11);
            this.checkBoxHueLoopmode.TabIndex = 21;
            this.checkBoxHueLoopmode.UseVisualStyleBackColor = true;
            this.checkBoxHueLoopmode.CheckedChanged += new System.EventHandler(this.checkBoxHueLoopmode_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Closed loop mode";
            // 
            // numericUpDownHueSpd
            // 
            this.numericUpDownHueSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownHueSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownHueSpd.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownHueSpd.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHueSpd.Location = new System.Drawing.Point(369, 46);
            this.numericUpDownHueSpd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownHueSpd.Name = "numericUpDownHueSpd";
            this.numericUpDownHueSpd.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownHueSpd.TabIndex = 19;
            this.numericUpDownHueSpd.ValueChanged += new System.EventHandler(this.numericUpDownHueSpd_ValueChanged);
            // 
            // trackBarHueSpd
            // 
            this.trackBarHueSpd.LargeChange = 1;
            this.trackBarHueSpd.Location = new System.Drawing.Point(15, 38);
            this.trackBarHueSpd.Maximum = 500;
            this.trackBarHueSpd.Name = "trackBarHueSpd";
            this.trackBarHueSpd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarHueSpd.Size = new System.Drawing.Size(348, 45);
            this.trackBarHueSpd.TabIndex = 18;
            this.trackBarHueSpd.TickFrequency = 50;
            this.trackBarHueSpd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarHueSpd.Value = 20;
            this.trackBarHueSpd.Scroll += new System.EventHandler(this.trackBarHueSpd_Scroll);
            // 
            // PanelStaticColor
            // 
            this.PanelStaticColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.PanelStaticColor.Controls.Add(this.numericUpDownStaticColorBlue);
            this.PanelStaticColor.Controls.Add(this.label6);
            this.PanelStaticColor.Controls.Add(this.trackBarStaticColorBlue);
            this.PanelStaticColor.Controls.Add(this.numericUpDownStaticColorGreen);
            this.PanelStaticColor.Controls.Add(this.label4);
            this.PanelStaticColor.Controls.Add(this.trackBarStaticColorGreen);
            this.PanelStaticColor.Controls.Add(this.numericUpDownStaticColorRed);
            this.PanelStaticColor.Controls.Add(this.label5);
            this.PanelStaticColor.Controls.Add(this.trackBarStaticColorRed);
            this.PanelStaticColor.Location = new System.Drawing.Point(253, 70);
            this.PanelStaticColor.Name = "PanelStaticColor";
            this.PanelStaticColor.Size = new System.Drawing.Size(463, 461);
            this.PanelStaticColor.TabIndex = 22;
            this.PanelStaticColor.Visible = false;
            // 
            // numericUpDownStaticColorBlue
            // 
            this.numericUpDownStaticColorBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownStaticColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownStaticColorBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownStaticColorBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.numericUpDownStaticColorBlue.Location = new System.Drawing.Point(369, 261);
            this.numericUpDownStaticColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStaticColorBlue.Name = "numericUpDownStaticColorBlue";
            this.numericUpDownStaticColorBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownStaticColorBlue.TabIndex = 25;
            this.numericUpDownStaticColorBlue.ValueChanged += new System.EventHandler(this.numericUpDownStaticColorBlue_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Blue";
            // 
            // trackBarStaticColorBlue
            // 
            this.trackBarStaticColorBlue.LargeChange = 1;
            this.trackBarStaticColorBlue.Location = new System.Drawing.Point(15, 253);
            this.trackBarStaticColorBlue.Maximum = 255;
            this.trackBarStaticColorBlue.Name = "trackBarStaticColorBlue";
            this.trackBarStaticColorBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarStaticColorBlue.TabIndex = 24;
            this.trackBarStaticColorBlue.TickFrequency = 15;
            this.trackBarStaticColorBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarStaticColorBlue.Value = 20;
            this.trackBarStaticColorBlue.Scroll += new System.EventHandler(this.trackBarStaticColorBlue_Scroll);
            // 
            // numericUpDownStaticColorGreen
            // 
            this.numericUpDownStaticColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownStaticColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownStaticColorGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownStaticColorGreen.ForeColor = System.Drawing.Color.Lime;
            this.numericUpDownStaticColorGreen.Location = new System.Drawing.Point(369, 152);
            this.numericUpDownStaticColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStaticColorGreen.Name = "numericUpDownStaticColorGreen";
            this.numericUpDownStaticColorGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownStaticColorGreen.TabIndex = 22;
            this.numericUpDownStaticColorGreen.ValueChanged += new System.EventHandler(this.numericUpDownStaticColorGreen_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Green";
            // 
            // trackBarStaticColorGreen
            // 
            this.trackBarStaticColorGreen.LargeChange = 1;
            this.trackBarStaticColorGreen.Location = new System.Drawing.Point(15, 144);
            this.trackBarStaticColorGreen.Maximum = 255;
            this.trackBarStaticColorGreen.Name = "trackBarStaticColorGreen";
            this.trackBarStaticColorGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarStaticColorGreen.TabIndex = 21;
            this.trackBarStaticColorGreen.TickFrequency = 15;
            this.trackBarStaticColorGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarStaticColorGreen.Value = 20;
            this.trackBarStaticColorGreen.Scroll += new System.EventHandler(this.trackBarStaticColorGreen_Scroll);
            // 
            // numericUpDownStaticColorRed
            // 
            this.numericUpDownStaticColorRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownStaticColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownStaticColorRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownStaticColorRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownStaticColorRed.Location = new System.Drawing.Point(369, 46);
            this.numericUpDownStaticColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStaticColorRed.Name = "numericUpDownStaticColorRed";
            this.numericUpDownStaticColorRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownStaticColorRed.TabIndex = 19;
            this.numericUpDownStaticColorRed.ValueChanged += new System.EventHandler(this.numericUpDownStaticColorRed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Red";
            // 
            // trackBarStaticColorRed
            // 
            this.trackBarStaticColorRed.LargeChange = 1;
            this.trackBarStaticColorRed.Location = new System.Drawing.Point(15, 38);
            this.trackBarStaticColorRed.Maximum = 255;
            this.trackBarStaticColorRed.Name = "trackBarStaticColorRed";
            this.trackBarStaticColorRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarStaticColorRed.TabIndex = 18;
            this.trackBarStaticColorRed.TickFrequency = 15;
            this.trackBarStaticColorRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarStaticColorRed.Value = 20;
            this.trackBarStaticColorRed.Scroll += new System.EventHandler(this.trackBarStaticColorRed_Scroll);
            // 
            // PanelBreathing
            // 
            this.PanelBreathing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.PanelBreathing.Controls.Add(this.numericUpDownBreathingSpd);
            this.PanelBreathing.Controls.Add(this.label10);
            this.PanelBreathing.Controls.Add(this.trackBarBreathingSpd);
            this.PanelBreathing.Controls.Add(this.numericUpDownBreathingBlue);
            this.PanelBreathing.Controls.Add(this.label7);
            this.PanelBreathing.Controls.Add(this.trackBarBreathingBlue);
            this.PanelBreathing.Controls.Add(this.numericUpDownBreathingGreen);
            this.PanelBreathing.Controls.Add(this.label8);
            this.PanelBreathing.Controls.Add(this.trackBarBreathingGreen);
            this.PanelBreathing.Controls.Add(this.numericUpDownBreathingRed);
            this.PanelBreathing.Controls.Add(this.label9);
            this.PanelBreathing.Controls.Add(this.trackBarBreathingRed);
            this.PanelBreathing.Location = new System.Drawing.Point(253, 70);
            this.PanelBreathing.Name = "PanelBreathing";
            this.PanelBreathing.Size = new System.Drawing.Size(463, 461);
            this.PanelBreathing.TabIndex = 26;
            this.PanelBreathing.Visible = false;
            // 
            // numericUpDownBreathingSpd
            // 
            this.numericUpDownBreathingSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBreathingSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBreathingSpd.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBreathingSpd.ForeColor = System.Drawing.Color.White;
            this.numericUpDownBreathingSpd.Location = new System.Drawing.Point(369, 361);
            this.numericUpDownBreathingSpd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBreathingSpd.Name = "numericUpDownBreathingSpd";
            this.numericUpDownBreathingSpd.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBreathingSpd.TabIndex = 28;
            this.numericUpDownBreathingSpd.ValueChanged += new System.EventHandler(this.numericUpDownBreathingSpd_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(12, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Speed";
            // 
            // trackBarBreathingSpd
            // 
            this.trackBarBreathingSpd.LargeChange = 1;
            this.trackBarBreathingSpd.Location = new System.Drawing.Point(15, 353);
            this.trackBarBreathingSpd.Maximum = 500;
            this.trackBarBreathingSpd.Name = "trackBarBreathingSpd";
            this.trackBarBreathingSpd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarBreathingSpd.Size = new System.Drawing.Size(348, 45);
            this.trackBarBreathingSpd.TabIndex = 27;
            this.trackBarBreathingSpd.TickFrequency = 50;
            this.trackBarBreathingSpd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBreathingSpd.Value = 20;
            this.trackBarBreathingSpd.Scroll += new System.EventHandler(this.trackBarBreathingSpd_Scroll);
            // 
            // numericUpDownBreathingBlue
            // 
            this.numericUpDownBreathingBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBreathingBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBreathingBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBreathingBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.numericUpDownBreathingBlue.Location = new System.Drawing.Point(369, 261);
            this.numericUpDownBreathingBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBreathingBlue.Name = "numericUpDownBreathingBlue";
            this.numericUpDownBreathingBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBreathingBlue.TabIndex = 25;
            this.numericUpDownBreathingBlue.ValueChanged += new System.EventHandler(this.numericUpDownBreathingBlue_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(12, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Blue";
            // 
            // trackBarBreathingBlue
            // 
            this.trackBarBreathingBlue.LargeChange = 1;
            this.trackBarBreathingBlue.Location = new System.Drawing.Point(15, 253);
            this.trackBarBreathingBlue.Maximum = 255;
            this.trackBarBreathingBlue.Name = "trackBarBreathingBlue";
            this.trackBarBreathingBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarBreathingBlue.TabIndex = 24;
            this.trackBarBreathingBlue.TickFrequency = 15;
            this.trackBarBreathingBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBreathingBlue.Value = 20;
            this.trackBarBreathingBlue.Scroll += new System.EventHandler(this.trackBarBreathingBlue_Scroll);
            // 
            // numericUpDownBreathingGreen
            // 
            this.numericUpDownBreathingGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBreathingGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBreathingGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBreathingGreen.ForeColor = System.Drawing.Color.Lime;
            this.numericUpDownBreathingGreen.Location = new System.Drawing.Point(369, 152);
            this.numericUpDownBreathingGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBreathingGreen.Name = "numericUpDownBreathingGreen";
            this.numericUpDownBreathingGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBreathingGreen.TabIndex = 22;
            this.numericUpDownBreathingGreen.ValueChanged += new System.EventHandler(this.numericUpDownBreathingGreen_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(12, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Green";
            // 
            // trackBarBreathingGreen
            // 
            this.trackBarBreathingGreen.LargeChange = 1;
            this.trackBarBreathingGreen.Location = new System.Drawing.Point(15, 144);
            this.trackBarBreathingGreen.Maximum = 255;
            this.trackBarBreathingGreen.Name = "trackBarBreathingGreen";
            this.trackBarBreathingGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarBreathingGreen.TabIndex = 21;
            this.trackBarBreathingGreen.TickFrequency = 15;
            this.trackBarBreathingGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBreathingGreen.Value = 20;
            this.trackBarBreathingGreen.Scroll += new System.EventHandler(this.trackBarBreathingGreen_Scroll);
            // 
            // numericUpDownBreathingRed
            // 
            this.numericUpDownBreathingRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBreathingRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBreathingRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBreathingRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownBreathingRed.Location = new System.Drawing.Point(369, 46);
            this.numericUpDownBreathingRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBreathingRed.Name = "numericUpDownBreathingRed";
            this.numericUpDownBreathingRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBreathingRed.TabIndex = 19;
            this.numericUpDownBreathingRed.ValueChanged += new System.EventHandler(this.numericUpDownBreathingRed_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Red";
            // 
            // trackBarBreathingRed
            // 
            this.trackBarBreathingRed.LargeChange = 1;
            this.trackBarBreathingRed.Location = new System.Drawing.Point(15, 38);
            this.trackBarBreathingRed.Maximum = 255;
            this.trackBarBreathingRed.Name = "trackBarBreathingRed";
            this.trackBarBreathingRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarBreathingRed.TabIndex = 18;
            this.trackBarBreathingRed.TickFrequency = 15;
            this.trackBarBreathingRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBreathingRed.Value = 20;
            this.trackBarBreathingRed.Scroll += new System.EventHandler(this.trackBarBreathingRed_Scroll);
            // 
            // panelBeacon
            // 
            this.panelBeacon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelBeacon.Controls.Add(this.numericUpDownBeaconSpd);
            this.panelBeacon.Controls.Add(this.label11);
            this.panelBeacon.Controls.Add(this.trackBarBeaconSpd);
            this.panelBeacon.Controls.Add(this.numericUpDownBeaconBlue);
            this.panelBeacon.Controls.Add(this.label12);
            this.panelBeacon.Controls.Add(this.trackBarBeaconBlue);
            this.panelBeacon.Controls.Add(this.numericUpDownBeaconGreen);
            this.panelBeacon.Controls.Add(this.label13);
            this.panelBeacon.Controls.Add(this.trackBarBeaconGreen);
            this.panelBeacon.Controls.Add(this.numericUpDownBeaconRed);
            this.panelBeacon.Controls.Add(this.label14);
            this.panelBeacon.Controls.Add(this.trackBarBeaconRed);
            this.panelBeacon.Location = new System.Drawing.Point(253, 70);
            this.panelBeacon.Name = "panelBeacon";
            this.panelBeacon.Size = new System.Drawing.Size(463, 461);
            this.panelBeacon.TabIndex = 29;
            this.panelBeacon.Visible = false;
            // 
            // numericUpDownBeaconSpd
            // 
            this.numericUpDownBeaconSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBeaconSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBeaconSpd.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBeaconSpd.ForeColor = System.Drawing.Color.White;
            this.numericUpDownBeaconSpd.Location = new System.Drawing.Point(369, 361);
            this.numericUpDownBeaconSpd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBeaconSpd.Name = "numericUpDownBeaconSpd";
            this.numericUpDownBeaconSpd.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBeaconSpd.TabIndex = 28;
            this.numericUpDownBeaconSpd.ValueChanged += new System.EventHandler(this.numericUpDownBeaconSpd_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(12, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Speed";
            // 
            // trackBarBeaconSpd
            // 
            this.trackBarBeaconSpd.LargeChange = 1;
            this.trackBarBeaconSpd.Location = new System.Drawing.Point(15, 353);
            this.trackBarBeaconSpd.Maximum = 500;
            this.trackBarBeaconSpd.Name = "trackBarBeaconSpd";
            this.trackBarBeaconSpd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarBeaconSpd.Size = new System.Drawing.Size(348, 45);
            this.trackBarBeaconSpd.TabIndex = 27;
            this.trackBarBeaconSpd.TickFrequency = 50;
            this.trackBarBeaconSpd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBeaconSpd.Value = 20;
            this.trackBarBeaconSpd.Scroll += new System.EventHandler(this.trackBarBeaconSpd_Scroll);
            // 
            // numericUpDownBeaconBlue
            // 
            this.numericUpDownBeaconBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBeaconBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBeaconBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBeaconBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.numericUpDownBeaconBlue.Location = new System.Drawing.Point(369, 261);
            this.numericUpDownBeaconBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBeaconBlue.Name = "numericUpDownBeaconBlue";
            this.numericUpDownBeaconBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBeaconBlue.TabIndex = 25;
            this.numericUpDownBeaconBlue.ValueChanged += new System.EventHandler(this.numericUpDownBeaconBlue_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(12, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Blue";
            // 
            // trackBarBeaconBlue
            // 
            this.trackBarBeaconBlue.Location = new System.Drawing.Point(15, 253);
            this.trackBarBeaconBlue.Maximum = 255;
            this.trackBarBeaconBlue.Name = "trackBarBeaconBlue";
            this.trackBarBeaconBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarBeaconBlue.TabIndex = 24;
            this.trackBarBeaconBlue.TickFrequency = 15;
            this.trackBarBeaconBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBeaconBlue.Value = 20;
            this.trackBarBeaconBlue.Scroll += new System.EventHandler(this.trackBarBeaconBlue_Scroll);
            // 
            // numericUpDownBeaconGreen
            // 
            this.numericUpDownBeaconGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBeaconGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBeaconGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBeaconGreen.ForeColor = System.Drawing.Color.Lime;
            this.numericUpDownBeaconGreen.Location = new System.Drawing.Point(369, 152);
            this.numericUpDownBeaconGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBeaconGreen.Name = "numericUpDownBeaconGreen";
            this.numericUpDownBeaconGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBeaconGreen.TabIndex = 22;
            this.numericUpDownBeaconGreen.ValueChanged += new System.EventHandler(this.numericUpDownBeaconGreen_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(12, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Green";
            // 
            // trackBarBeaconGreen
            // 
            this.trackBarBeaconGreen.LargeChange = 1;
            this.trackBarBeaconGreen.Location = new System.Drawing.Point(15, 144);
            this.trackBarBeaconGreen.Maximum = 255;
            this.trackBarBeaconGreen.Name = "trackBarBeaconGreen";
            this.trackBarBeaconGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarBeaconGreen.TabIndex = 21;
            this.trackBarBeaconGreen.TickFrequency = 15;
            this.trackBarBeaconGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBeaconGreen.Value = 20;
            this.trackBarBeaconGreen.Scroll += new System.EventHandler(this.trackBarBeaconGreen_Scroll);
            // 
            // numericUpDownBeaconRed
            // 
            this.numericUpDownBeaconRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownBeaconRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBeaconRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownBeaconRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownBeaconRed.Location = new System.Drawing.Point(369, 46);
            this.numericUpDownBeaconRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBeaconRed.Name = "numericUpDownBeaconRed";
            this.numericUpDownBeaconRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownBeaconRed.TabIndex = 19;
            this.numericUpDownBeaconRed.ValueChanged += new System.EventHandler(this.numericUpDownBeaconRed_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(12, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Red";
            // 
            // trackBarBeaconRed
            // 
            this.trackBarBeaconRed.LargeChange = 1;
            this.trackBarBeaconRed.Location = new System.Drawing.Point(15, 38);
            this.trackBarBeaconRed.Maximum = 255;
            this.trackBarBeaconRed.Name = "trackBarBeaconRed";
            this.trackBarBeaconRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarBeaconRed.TabIndex = 18;
            this.trackBarBeaconRed.TickFrequency = 15;
            this.trackBarBeaconRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBeaconRed.Value = 20;
            this.trackBarBeaconRed.Scroll += new System.EventHandler(this.trackBarBeaconRed_Scroll);
            // 
            // panelTheatreChaseLights
            // 
            this.panelTheatreChaseLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelTheatreChaseLights.Controls.Add(this.panelTheatreChaseLights2);
            this.panelTheatreChaseLights.Controls.Add(this.checkBoxTheatreChaseLightsColorWheel);
            this.panelTheatreChaseLights.Controls.Add(this.label19);
            this.panelTheatreChaseLights.Controls.Add(this.numericUpDownTheatreChaseLightsSpd);
            this.panelTheatreChaseLights.Controls.Add(this.label15);
            this.panelTheatreChaseLights.Controls.Add(this.trackBarTheatreChaseLightsSpd);
            this.panelTheatreChaseLights.Location = new System.Drawing.Point(253, 70);
            this.panelTheatreChaseLights.Name = "panelTheatreChaseLights";
            this.panelTheatreChaseLights.Size = new System.Drawing.Size(463, 461);
            this.panelTheatreChaseLights.TabIndex = 30;
            this.panelTheatreChaseLights.Visible = false;
            // 
            // panelTheatreChaseLights2
            // 
            this.panelTheatreChaseLights2.Controls.Add(this.numericUpDownTheatreChaseLightsBlue);
            this.panelTheatreChaseLights2.Controls.Add(this.label16);
            this.panelTheatreChaseLights2.Controls.Add(this.trackBarTheatreChaseLightsBlue);
            this.panelTheatreChaseLights2.Controls.Add(this.numericUpDownTheatreChaseLightsGreen);
            this.panelTheatreChaseLights2.Controls.Add(this.label17);
            this.panelTheatreChaseLights2.Controls.Add(this.trackBarTheatreChaseLightsGreen);
            this.panelTheatreChaseLights2.Controls.Add(this.numericUpDownTheatreChaseLightsRed);
            this.panelTheatreChaseLights2.Controls.Add(this.label18);
            this.panelTheatreChaseLights2.Controls.Add(this.trackBarTheatreChaseLightsRed);
            this.panelTheatreChaseLights2.Location = new System.Drawing.Point(3, 117);
            this.panelTheatreChaseLights2.Name = "panelTheatreChaseLights2";
            this.panelTheatreChaseLights2.Size = new System.Drawing.Size(459, 344);
            this.panelTheatreChaseLights2.TabIndex = 30;
            // 
            // numericUpDownTheatreChaseLightsBlue
            // 
            this.numericUpDownTheatreChaseLightsBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownTheatreChaseLightsBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTheatreChaseLightsBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownTheatreChaseLightsBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.numericUpDownTheatreChaseLightsBlue.Location = new System.Drawing.Point(366, 264);
            this.numericUpDownTheatreChaseLightsBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTheatreChaseLightsBlue.Name = "numericUpDownTheatreChaseLightsBlue";
            this.numericUpDownTheatreChaseLightsBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownTheatreChaseLightsBlue.TabIndex = 25;
            this.numericUpDownTheatreChaseLightsBlue.ValueChanged += new System.EventHandler(this.numericUpDownTheatreChaseLightsBlue_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(9, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Blue";
            // 
            // trackBarTheatreChaseLightsBlue
            // 
            this.trackBarTheatreChaseLightsBlue.LargeChange = 1;
            this.trackBarTheatreChaseLightsBlue.Location = new System.Drawing.Point(12, 256);
            this.trackBarTheatreChaseLightsBlue.Maximum = 255;
            this.trackBarTheatreChaseLightsBlue.Name = "trackBarTheatreChaseLightsBlue";
            this.trackBarTheatreChaseLightsBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarTheatreChaseLightsBlue.TabIndex = 24;
            this.trackBarTheatreChaseLightsBlue.TickFrequency = 15;
            this.trackBarTheatreChaseLightsBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTheatreChaseLightsBlue.Value = 20;
            this.trackBarTheatreChaseLightsBlue.Scroll += new System.EventHandler(this.trackBarTheatreChaseLightsBlue_Scroll);
            // 
            // numericUpDownTheatreChaseLightsGreen
            // 
            this.numericUpDownTheatreChaseLightsGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownTheatreChaseLightsGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTheatreChaseLightsGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownTheatreChaseLightsGreen.ForeColor = System.Drawing.Color.Lime;
            this.numericUpDownTheatreChaseLightsGreen.Location = new System.Drawing.Point(366, 155);
            this.numericUpDownTheatreChaseLightsGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTheatreChaseLightsGreen.Name = "numericUpDownTheatreChaseLightsGreen";
            this.numericUpDownTheatreChaseLightsGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownTheatreChaseLightsGreen.TabIndex = 22;
            this.numericUpDownTheatreChaseLightsGreen.ValueChanged += new System.EventHandler(this.numericUpDownTheatreChaseLightsGreen_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.Location = new System.Drawing.Point(9, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Green";
            // 
            // trackBarTheatreChaseLightsGreen
            // 
            this.trackBarTheatreChaseLightsGreen.LargeChange = 1;
            this.trackBarTheatreChaseLightsGreen.Location = new System.Drawing.Point(12, 147);
            this.trackBarTheatreChaseLightsGreen.Maximum = 255;
            this.trackBarTheatreChaseLightsGreen.Name = "trackBarTheatreChaseLightsGreen";
            this.trackBarTheatreChaseLightsGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarTheatreChaseLightsGreen.TabIndex = 21;
            this.trackBarTheatreChaseLightsGreen.TickFrequency = 15;
            this.trackBarTheatreChaseLightsGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTheatreChaseLightsGreen.Value = 20;
            this.trackBarTheatreChaseLightsGreen.Scroll += new System.EventHandler(this.trackBarTheatreChaseLightsGreen_Scroll);
            // 
            // numericUpDownTheatreChaseLightsRed
            // 
            this.numericUpDownTheatreChaseLightsRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownTheatreChaseLightsRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTheatreChaseLightsRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownTheatreChaseLightsRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownTheatreChaseLightsRed.Location = new System.Drawing.Point(366, 49);
            this.numericUpDownTheatreChaseLightsRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTheatreChaseLightsRed.Name = "numericUpDownTheatreChaseLightsRed";
            this.numericUpDownTheatreChaseLightsRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownTheatreChaseLightsRed.TabIndex = 19;
            this.numericUpDownTheatreChaseLightsRed.ValueChanged += new System.EventHandler(this.numericUpDownTheatreChaseLightsRed_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(9, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Red";
            // 
            // trackBarTheatreChaseLightsRed
            // 
            this.trackBarTheatreChaseLightsRed.LargeChange = 1;
            this.trackBarTheatreChaseLightsRed.Location = new System.Drawing.Point(12, 41);
            this.trackBarTheatreChaseLightsRed.Maximum = 255;
            this.trackBarTheatreChaseLightsRed.Name = "trackBarTheatreChaseLightsRed";
            this.trackBarTheatreChaseLightsRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarTheatreChaseLightsRed.TabIndex = 18;
            this.trackBarTheatreChaseLightsRed.TickFrequency = 15;
            this.trackBarTheatreChaseLightsRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTheatreChaseLightsRed.Value = 20;
            this.trackBarTheatreChaseLightsRed.Scroll += new System.EventHandler(this.trackBarTheatreChaseLightsRed_Scroll);
            // 
            // checkBoxTheatreChaseLightsColorWheel
            // 
            this.checkBoxTheatreChaseLightsColorWheel.AutoSize = true;
            this.checkBoxTheatreChaseLightsColorWheel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.checkBoxTheatreChaseLightsColorWheel.FlatAppearance.BorderSize = 0;
            this.checkBoxTheatreChaseLightsColorWheel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.checkBoxTheatreChaseLightsColorWheel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxTheatreChaseLightsColorWheel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxTheatreChaseLightsColorWheel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTheatreChaseLightsColorWheel.Location = new System.Drawing.Point(387, 97);
            this.checkBoxTheatreChaseLightsColorWheel.Name = "checkBoxTheatreChaseLightsColorWheel";
            this.checkBoxTheatreChaseLightsColorWheel.Size = new System.Drawing.Size(12, 11);
            this.checkBoxTheatreChaseLightsColorWheel.TabIndex = 22;
            this.checkBoxTheatreChaseLightsColorWheel.UseVisualStyleBackColor = true;
            this.checkBoxTheatreChaseLightsColorWheel.CheckedChanged += new System.EventHandler(this.checkBoxTheatreChaseLightsColorWheel_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(12, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Use color wheel instead of manual control";
            // 
            // numericUpDownTheatreChaseLightsSpd
            // 
            this.numericUpDownTheatreChaseLightsSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownTheatreChaseLightsSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTheatreChaseLightsSpd.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownTheatreChaseLightsSpd.ForeColor = System.Drawing.Color.White;
            this.numericUpDownTheatreChaseLightsSpd.Location = new System.Drawing.Point(369, 47);
            this.numericUpDownTheatreChaseLightsSpd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownTheatreChaseLightsSpd.Name = "numericUpDownTheatreChaseLightsSpd";
            this.numericUpDownTheatreChaseLightsSpd.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownTheatreChaseLightsSpd.TabIndex = 28;
            this.numericUpDownTheatreChaseLightsSpd.ValueChanged += new System.EventHandler(this.numericUpDownTheatreChaseLightsSpd_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Speed";
            // 
            // trackBarTheatreChaseLightsSpd
            // 
            this.trackBarTheatreChaseLightsSpd.LargeChange = 1;
            this.trackBarTheatreChaseLightsSpd.Location = new System.Drawing.Point(15, 39);
            this.trackBarTheatreChaseLightsSpd.Maximum = 500;
            this.trackBarTheatreChaseLightsSpd.Name = "trackBarTheatreChaseLightsSpd";
            this.trackBarTheatreChaseLightsSpd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarTheatreChaseLightsSpd.Size = new System.Drawing.Size(348, 45);
            this.trackBarTheatreChaseLightsSpd.TabIndex = 27;
            this.trackBarTheatreChaseLightsSpd.TickFrequency = 50;
            this.trackBarTheatreChaseLightsSpd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTheatreChaseLightsSpd.Value = 20;
            this.trackBarTheatreChaseLightsSpd.Scroll += new System.EventHandler(this.trackBarTheatreChaseLightsSpd_Scroll);
            // 
            // panelKnightRider
            // 
            this.panelKnightRider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelKnightRider.Controls.Add(this.numericUpDownKnightRiderSpd);
            this.panelKnightRider.Controls.Add(this.label20);
            this.panelKnightRider.Controls.Add(this.trackBarKnightRiderSpd);
            this.panelKnightRider.Controls.Add(this.numericUpDownKnightRiderBlue);
            this.panelKnightRider.Controls.Add(this.label21);
            this.panelKnightRider.Controls.Add(this.trackBarKnightRiderBlue);
            this.panelKnightRider.Controls.Add(this.numericUpDownKnightRiderGreen);
            this.panelKnightRider.Controls.Add(this.label22);
            this.panelKnightRider.Controls.Add(this.trackBarKnightRiderGreen);
            this.panelKnightRider.Controls.Add(this.numericUpDownKnightRiderRed);
            this.panelKnightRider.Controls.Add(this.label23);
            this.panelKnightRider.Controls.Add(this.trackBarKnightRiderRed);
            this.panelKnightRider.Location = new System.Drawing.Point(253, 70);
            this.panelKnightRider.Name = "panelKnightRider";
            this.panelKnightRider.Size = new System.Drawing.Size(463, 461);
            this.panelKnightRider.TabIndex = 29;
            this.panelKnightRider.Visible = false;
            // 
            // numericUpDownKnightRiderSpd
            // 
            this.numericUpDownKnightRiderSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownKnightRiderSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownKnightRiderSpd.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKnightRiderSpd.ForeColor = System.Drawing.Color.White;
            this.numericUpDownKnightRiderSpd.Location = new System.Drawing.Point(369, 361);
            this.numericUpDownKnightRiderSpd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownKnightRiderSpd.Name = "numericUpDownKnightRiderSpd";
            this.numericUpDownKnightRiderSpd.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownKnightRiderSpd.TabIndex = 28;
            this.numericUpDownKnightRiderSpd.ValueChanged += new System.EventHandler(this.numericUpDownKnightRiderSpd_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label20.Location = new System.Drawing.Point(12, 323);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Speed";
            // 
            // trackBarKnightRiderSpd
            // 
            this.trackBarKnightRiderSpd.LargeChange = 1;
            this.trackBarKnightRiderSpd.Location = new System.Drawing.Point(15, 353);
            this.trackBarKnightRiderSpd.Maximum = 500;
            this.trackBarKnightRiderSpd.Name = "trackBarKnightRiderSpd";
            this.trackBarKnightRiderSpd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarKnightRiderSpd.Size = new System.Drawing.Size(348, 45);
            this.trackBarKnightRiderSpd.TabIndex = 27;
            this.trackBarKnightRiderSpd.TickFrequency = 50;
            this.trackBarKnightRiderSpd.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarKnightRiderSpd.Value = 20;
            this.trackBarKnightRiderSpd.Scroll += new System.EventHandler(this.trackBarKnightRiderSpd_Scroll);
            // 
            // numericUpDownKnightRiderBlue
            // 
            this.numericUpDownKnightRiderBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownKnightRiderBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownKnightRiderBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKnightRiderBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.numericUpDownKnightRiderBlue.Location = new System.Drawing.Point(369, 261);
            this.numericUpDownKnightRiderBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKnightRiderBlue.Name = "numericUpDownKnightRiderBlue";
            this.numericUpDownKnightRiderBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownKnightRiderBlue.TabIndex = 25;
            this.numericUpDownKnightRiderBlue.ValueChanged += new System.EventHandler(this.numericUpDownKnightRiderBlue_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label21.Location = new System.Drawing.Point(12, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Blue";
            // 
            // trackBarKnightRiderBlue
            // 
            this.trackBarKnightRiderBlue.LargeChange = 1;
            this.trackBarKnightRiderBlue.Location = new System.Drawing.Point(15, 253);
            this.trackBarKnightRiderBlue.Maximum = 255;
            this.trackBarKnightRiderBlue.Name = "trackBarKnightRiderBlue";
            this.trackBarKnightRiderBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarKnightRiderBlue.TabIndex = 24;
            this.trackBarKnightRiderBlue.TickFrequency = 15;
            this.trackBarKnightRiderBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarKnightRiderBlue.Value = 20;
            this.trackBarKnightRiderBlue.Scroll += new System.EventHandler(this.trackBarKnightRiderBlue_Scroll);
            // 
            // numericUpDownKnightRiderGreen
            // 
            this.numericUpDownKnightRiderGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownKnightRiderGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownKnightRiderGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKnightRiderGreen.ForeColor = System.Drawing.Color.Lime;
            this.numericUpDownKnightRiderGreen.Location = new System.Drawing.Point(369, 152);
            this.numericUpDownKnightRiderGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKnightRiderGreen.Name = "numericUpDownKnightRiderGreen";
            this.numericUpDownKnightRiderGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownKnightRiderGreen.TabIndex = 22;
            this.numericUpDownKnightRiderGreen.ValueChanged += new System.EventHandler(this.numericUpDownKnightRiderGreen_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label22.Location = new System.Drawing.Point(12, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Green";
            // 
            // trackBarKnightRiderGreen
            // 
            this.trackBarKnightRiderGreen.LargeChange = 1;
            this.trackBarKnightRiderGreen.Location = new System.Drawing.Point(15, 144);
            this.trackBarKnightRiderGreen.Maximum = 255;
            this.trackBarKnightRiderGreen.Name = "trackBarKnightRiderGreen";
            this.trackBarKnightRiderGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarKnightRiderGreen.TabIndex = 21;
            this.trackBarKnightRiderGreen.TickFrequency = 15;
            this.trackBarKnightRiderGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarKnightRiderGreen.Value = 20;
            this.trackBarKnightRiderGreen.Scroll += new System.EventHandler(this.trackBarKnightRiderGreen_Scroll);
            // 
            // numericUpDownKnightRiderRed
            // 
            this.numericUpDownKnightRiderRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownKnightRiderRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownKnightRiderRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKnightRiderRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownKnightRiderRed.Location = new System.Drawing.Point(369, 46);
            this.numericUpDownKnightRiderRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKnightRiderRed.Name = "numericUpDownKnightRiderRed";
            this.numericUpDownKnightRiderRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownKnightRiderRed.TabIndex = 19;
            this.numericUpDownKnightRiderRed.ValueChanged += new System.EventHandler(this.numericUpDownKnightRiderRed_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label23.Location = new System.Drawing.Point(12, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Red";
            // 
            // trackBarKnightRiderRed
            // 
            this.trackBarKnightRiderRed.LargeChange = 1;
            this.trackBarKnightRiderRed.Location = new System.Drawing.Point(15, 38);
            this.trackBarKnightRiderRed.Maximum = 255;
            this.trackBarKnightRiderRed.Name = "trackBarKnightRiderRed";
            this.trackBarKnightRiderRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarKnightRiderRed.TabIndex = 18;
            this.trackBarKnightRiderRed.TickFrequency = 15;
            this.trackBarKnightRiderRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarKnightRiderRed.Value = 20;
            this.trackBarKnightRiderRed.Scroll += new System.EventHandler(this.trackBarKnightRiderRed_Scroll);
            // 
            // panelManageConnections
            // 
            this.panelManageConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelManageConnections.Controls.Add(this.flowLayoutPanel2);
            this.panelManageConnections.Controls.Add(this.flowLayoutPanel1);
            this.panelManageConnections.Controls.Add(this.button1);
            this.panelManageConnections.Controls.Add(this.label24);
            this.panelManageConnections.Controls.Add(this.comboBox1);
            this.panelManageConnections.Location = new System.Drawing.Point(253, 70);
            this.panelManageConnections.Name = "panelManageConnections";
            this.panelManageConnections.Size = new System.Drawing.Size(463, 461);
            this.panelManageConnections.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label31);
            this.flowLayoutPanel2.Controls.Add(this.label26);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(222, 436);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 22);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Last sent data: ";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(89, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "null";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label25);
            this.flowLayoutPanel1.Controls.Add(this.StatusLine);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 436);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 22);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label25.Location = new System.Drawing.Point(3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Status:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLine
            // 
            this.StatusLine.AutoSize = true;
            this.StatusLine.ForeColor = System.Drawing.Color.OrangeRed;
            this.StatusLine.Location = new System.Drawing.Point(49, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(78, 13);
            this.StatusLine.TabIndex = 31;
            this.StatusLine.Text = "Not connected";
            this.StatusLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label24.Location = new System.Drawing.Point(12, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Select Port";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelAudioMeter
            // 
            this.panelAudioMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelAudioMeter.Controls.Add(this.checkBoxAudioMeterChangeColor);
            this.panelAudioMeter.Controls.Add(this.label29);
            this.panelAudioMeter.Controls.Add(this.numericUpDownAudioMeterRed);
            this.panelAudioMeter.Controls.Add(this.label30);
            this.panelAudioMeter.Controls.Add(this.trackBarAudioMeterRed);
            this.panelAudioMeter.Controls.Add(this.panelAudiometer2);
            this.panelAudioMeter.Location = new System.Drawing.Point(253, 70);
            this.panelAudioMeter.Name = "panelAudioMeter";
            this.panelAudioMeter.Size = new System.Drawing.Size(463, 461);
            this.panelAudioMeter.TabIndex = 31;
            this.panelAudioMeter.Visible = false;
            // 
            // checkBoxAudioMeterChangeColor
            // 
            this.checkBoxAudioMeterChangeColor.AutoSize = true;
            this.checkBoxAudioMeterChangeColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.checkBoxAudioMeterChangeColor.FlatAppearance.BorderSize = 0;
            this.checkBoxAudioMeterChangeColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.checkBoxAudioMeterChangeColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxAudioMeterChangeColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAudioMeterChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAudioMeterChangeColor.Location = new System.Drawing.Point(387, 97);
            this.checkBoxAudioMeterChangeColor.Name = "checkBoxAudioMeterChangeColor";
            this.checkBoxAudioMeterChangeColor.Size = new System.Drawing.Size(12, 11);
            this.checkBoxAudioMeterChangeColor.TabIndex = 22;
            this.checkBoxAudioMeterChangeColor.UseVisualStyleBackColor = true;
            this.checkBoxAudioMeterChangeColor.CheckedChanged += new System.EventHandler(this.checkBoxAudioMeterChangeColor_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label29.Location = new System.Drawing.Point(12, 95);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 13);
            this.label29.TabIndex = 29;
            this.label29.Text = "Change color palette on peak";
            // 
            // numericUpDownAudioMeterRed
            // 
            this.numericUpDownAudioMeterRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownAudioMeterRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAudioMeterRed.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownAudioMeterRed.ForeColor = System.Drawing.Color.White;
            this.numericUpDownAudioMeterRed.Location = new System.Drawing.Point(369, 47);
            this.numericUpDownAudioMeterRed.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownAudioMeterRed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAudioMeterRed.Name = "numericUpDownAudioMeterRed";
            this.numericUpDownAudioMeterRed.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownAudioMeterRed.TabIndex = 28;
            this.numericUpDownAudioMeterRed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAudioMeterRed.ValueChanged += new System.EventHandler(this.numericUpDownAudioMeterRed_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label30.Location = new System.Drawing.Point(12, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 26;
            this.label30.Text = "Sensitivity";
            // 
            // trackBarAudioMeterRed
            // 
            this.trackBarAudioMeterRed.LargeChange = 1;
            this.trackBarAudioMeterRed.Location = new System.Drawing.Point(15, 39);
            this.trackBarAudioMeterRed.Maximum = 1500;
            this.trackBarAudioMeterRed.Minimum = 100;
            this.trackBarAudioMeterRed.Name = "trackBarAudioMeterRed";
            this.trackBarAudioMeterRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarAudioMeterRed.Size = new System.Drawing.Size(348, 45);
            this.trackBarAudioMeterRed.TabIndex = 27;
            this.trackBarAudioMeterRed.TickFrequency = 100;
            this.trackBarAudioMeterRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAudioMeterRed.Value = 700;
            this.trackBarAudioMeterRed.Scroll += new System.EventHandler(this.trackBarAudioMeterRed_Scroll);
            // 
            // panelAudiometer2
            // 
            this.panelAudiometer2.Controls.Add(this.numericUpDownAudioMeterBlue);
            this.panelAudiometer2.Controls.Add(this.label27);
            this.panelAudiometer2.Controls.Add(this.trackBarAudioMeterBlue);
            this.panelAudiometer2.Controls.Add(this.numericUpDownAudioMeterGreen);
            this.panelAudiometer2.Controls.Add(this.label28);
            this.panelAudiometer2.Controls.Add(this.trackBarAudioMeterGreen);
            this.panelAudiometer2.Location = new System.Drawing.Point(3, 117);
            this.panelAudiometer2.Name = "panelAudiometer2";
            this.panelAudiometer2.Size = new System.Drawing.Size(459, 344);
            this.panelAudiometer2.TabIndex = 30;
            // 
            // numericUpDownAudioMeterBlue
            // 
            this.numericUpDownAudioMeterBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownAudioMeterBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAudioMeterBlue.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownAudioMeterBlue.ForeColor = System.Drawing.Color.White;
            this.numericUpDownAudioMeterBlue.Location = new System.Drawing.Point(366, 155);
            this.numericUpDownAudioMeterBlue.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownAudioMeterBlue.Name = "numericUpDownAudioMeterBlue";
            this.numericUpDownAudioMeterBlue.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownAudioMeterBlue.TabIndex = 22;
            this.numericUpDownAudioMeterBlue.ValueChanged += new System.EventHandler(this.numericUpDownAudioMeterBlue_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label27.Location = new System.Drawing.Point(9, 117);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 20;
            this.label27.Text = "Hysterisis";
            // 
            // trackBarAudioMeterBlue
            // 
            this.trackBarAudioMeterBlue.LargeChange = 1;
            this.trackBarAudioMeterBlue.Location = new System.Drawing.Point(12, 147);
            this.trackBarAudioMeterBlue.Maximum = 600;
            this.trackBarAudioMeterBlue.Name = "trackBarAudioMeterBlue";
            this.trackBarAudioMeterBlue.Size = new System.Drawing.Size(348, 45);
            this.trackBarAudioMeterBlue.TabIndex = 21;
            this.trackBarAudioMeterBlue.TickFrequency = 100;
            this.trackBarAudioMeterBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAudioMeterBlue.Value = 500;
            this.trackBarAudioMeterBlue.Scroll += new System.EventHandler(this.trackBarAudioMeterBlue_Scroll);
            // 
            // numericUpDownAudioMeterGreen
            // 
            this.numericUpDownAudioMeterGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.numericUpDownAudioMeterGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAudioMeterGreen.Font = new System.Drawing.Font("UNIT-A2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownAudioMeterGreen.ForeColor = System.Drawing.Color.White;
            this.numericUpDownAudioMeterGreen.Location = new System.Drawing.Point(366, 49);
            this.numericUpDownAudioMeterGreen.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDownAudioMeterGreen.Name = "numericUpDownAudioMeterGreen";
            this.numericUpDownAudioMeterGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownAudioMeterGreen.TabIndex = 19;
            this.numericUpDownAudioMeterGreen.ValueChanged += new System.EventHandler(this.numericUpDownAudioMeterGreen_ValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label28.Location = new System.Drawing.Point(9, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "Peak Threshold";
            // 
            // trackBarAudioMeterGreen
            // 
            this.trackBarAudioMeterGreen.LargeChange = 1;
            this.trackBarAudioMeterGreen.Location = new System.Drawing.Point(12, 41);
            this.trackBarAudioMeterGreen.Maximum = 700;
            this.trackBarAudioMeterGreen.Name = "trackBarAudioMeterGreen";
            this.trackBarAudioMeterGreen.Size = new System.Drawing.Size(348, 45);
            this.trackBarAudioMeterGreen.TabIndex = 18;
            this.trackBarAudioMeterGreen.TickFrequency = 100;
            this.trackBarAudioMeterGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAudioMeterGreen.Value = 600;
            this.trackBarAudioMeterGreen.Scroll += new System.EventHandler(this.trackBarAudioMeterGreen_Scroll);
            // 
            // panelOff
            // 
            this.panelOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panelOff.Controls.Add(this.label33);
            this.panelOff.Location = new System.Drawing.Point(253, 70);
            this.panelOff.Name = "panelOff";
            this.panelOff.Size = new System.Drawing.Size(463, 461);
            this.panelOff.TabIndex = 32;
            this.panelOff.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label33.Location = new System.Drawing.Point(12, 9);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(163, 26);
            this.label33.TabIndex = 26;
            this.label33.Text = "LED strip is off :(\r\nTo turn it back on select a mode.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.NeoPixelTiny;
            this.pictureBox2.Location = new System.Drawing.Point(640, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pictureBox1.Location = new System.Drawing.Point(248, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 33);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(725, 543);
            this.Controls.Add(this.panelAudioMeter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelManageConnections);
            this.Controls.Add(this.panelKnightRider);
            this.Controls.Add(this.panelTheatreChaseLights);
            this.Controls.Add(this.PanelBreathing);
            this.Controls.Add(this.PanelStaticColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelHue);
            this.Controls.Add(this.PanelMode);
            this.Controls.Add(this.panelBeacon);
            this.Controls.Add(this.panelOff);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NeoPixel Controller";
            this.PanelMode.ResumeLayout(false);
            this.PanelMode.PerformLayout();
            this.panelModesGreyOut.ResumeLayout(false);
            this.PanelHue.ResumeLayout(false);
            this.PanelHue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHueSpd)).EndInit();
            this.PanelStaticColor.ResumeLayout(false);
            this.PanelStaticColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaticColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStaticColorRed)).EndInit();
            this.PanelBreathing.ResumeLayout(false);
            this.PanelBreathing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreathingRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathingRed)).EndInit();
            this.panelBeacon.ResumeLayout(false);
            this.panelBeacon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeaconRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeaconRed)).EndInit();
            this.panelTheatreChaseLights.ResumeLayout(false);
            this.panelTheatreChaseLights.PerformLayout();
            this.panelTheatreChaseLights2.ResumeLayout(false);
            this.panelTheatreChaseLights2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheatreChaseLightsSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheatreChaseLightsSpd)).EndInit();
            this.panelKnightRider.ResumeLayout(false);
            this.panelKnightRider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnightRiderRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnightRiderRed)).EndInit();
            this.panelManageConnections.ResumeLayout(false);
            this.panelManageConnections.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelAudioMeter.ResumeLayout(false);
            this.panelAudioMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterRed)).EndInit();
            this.panelAudiometer2.ResumeLayout(false);
            this.panelAudiometer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAudioMeterGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioMeterGreen)).EndInit();
            this.panelOff.ResumeLayout(false);
            this.panelOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.Button btnBreathing;
        private System.Windows.Forms.Button btnAudioMeter;
        private System.Windows.Forms.Button btnStaticColor;
        private System.Windows.Forms.Button btnBeacon;
        private System.Windows.Forms.Button btnKnightRider;
        private System.Windows.Forms.Button btnTheatreChaseLights;
        private System.Windows.Forms.Button btnManageConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHue;
        private System.Windows.Forms.TrackBar trackBarHueSpd;
        private System.Windows.Forms.NumericUpDown numericUpDownHueSpd;
        private System.Windows.Forms.CheckBox checkBoxHueLoopmode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelStaticColor;
        private System.Windows.Forms.NumericUpDown numericUpDownStaticColorBlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarStaticColorBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownStaticColorGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarStaticColorGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownStaticColorRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarStaticColorRed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelBreathing;
        private System.Windows.Forms.NumericUpDown numericUpDownBreathingSpd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarBreathingSpd;
        private System.Windows.Forms.NumericUpDown numericUpDownBreathingBlue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarBreathingBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownBreathingGreen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarBreathingGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBreathingRed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarBreathingRed;
        private System.Windows.Forms.Panel panelBeacon;
        private System.Windows.Forms.NumericUpDown numericUpDownBeaconSpd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarBeaconSpd;
        private System.Windows.Forms.NumericUpDown numericUpDownBeaconBlue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarBeaconBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownBeaconGreen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBarBeaconGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBeaconRed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBarBeaconRed;
        private System.Windows.Forms.Panel panelTheatreChaseLights;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDownTheatreChaseLightsSpd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackBarTheatreChaseLightsSpd;
        private System.Windows.Forms.NumericUpDown numericUpDownTheatreChaseLightsBlue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBarTheatreChaseLightsBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownTheatreChaseLightsGreen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBarTheatreChaseLightsGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownTheatreChaseLightsRed;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBarTheatreChaseLightsRed;
        private System.Windows.Forms.Panel panelTheatreChaseLights2;
        private System.Windows.Forms.CheckBox checkBoxTheatreChaseLightsColorWheel;
        private System.Windows.Forms.Panel panelKnightRider;
        private System.Windows.Forms.NumericUpDown numericUpDownKnightRiderSpd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBarKnightRiderSpd;
        private System.Windows.Forms.NumericUpDown numericUpDownKnightRiderBlue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar trackBarKnightRiderBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownKnightRiderGreen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackBarKnightRiderGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownKnightRiderRed;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TrackBar trackBarKnightRiderRed;
        private System.Windows.Forms.Panel panelManageConnections;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelModesGreyOut;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel panelAudioMeter;
        private System.Windows.Forms.Panel panelAudiometer2;
        private System.Windows.Forms.NumericUpDown numericUpDownAudioMeterBlue;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TrackBar trackBarAudioMeterBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownAudioMeterGreen;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TrackBar trackBarAudioMeterGreen;
        private System.Windows.Forms.CheckBox checkBoxAudioMeterChangeColor;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numericUpDownAudioMeterRed;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TrackBar trackBarAudioMeterRed;
        private System.Windows.Forms.Panel panelOff;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

