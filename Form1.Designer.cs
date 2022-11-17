namespace _8082_Waymo_PC
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readyManualOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readyONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readyOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setComPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixture1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sNPartIdentifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flexFlowURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnableFlexFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChamberTest = new System.Windows.Forms.ToolStripMenuItem();
            this.hRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRead = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tmrScanIn = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.lstTest = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.grpFixture_1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFix_1_Operator = new System.Windows.Forms.Label();
            this.lblFix_1_SN = new System.Windows.Forms.Label();
            this.lblFix_1_Status = new System.Windows.Forms.Label();
            this.grpFixture_2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFix_2_Operator = new System.Windows.Forms.Label();
            this.lblFix_2_SN = new System.Windows.Forms.Label();
            this.lblFix_2_Status = new System.Windows.Forms.Label();
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.grpZebraTest = new System.Windows.Forms.GroupBox();
            this.lblTestScan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpOperator = new System.Windows.Forms.GroupBox();
            this.btnOperClose = new System.Windows.Forms.Button();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.grpFixture_Prog = new System.Windows.Forms.GroupBox();
            this.cmbFix_2_Prg = new System.Windows.Forms.ComboBox();
            this.cmbFix_1_Prg = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnSavePrograms = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpSN_Verify = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSV_New = new System.Windows.Forms.TextBox();
            this.txtHR_New = new System.Windows.Forms.TextBox();
            this.lblSV_Current = new System.Windows.Forms.Label();
            this.lblHR_Current = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSave_ID = new System.Windows.Forms.Button();
            this.btnClose_ID = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.grpFlexFlowUrl = new System.Windows.Forms.GroupBox();
            this.btnCloseFlexUrl = new System.Windows.Forms.Button();
            this.txtNew_FlexFlowUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveFlexUrl = new System.Windows.Forms.Button();
            this.grpSetComPorts = new System.Windows.Forms.GroupBox();
            this.txtZebra = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCloseComports = new System.Windows.Forms.Button();
            this.txtReadyCom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveCom = new System.Windows.Forms.Button();
            this.txtFlexError = new System.Windows.Forms.TextBox();
            this.grpChamberTest = new System.Windows.Forms.GroupBox();
            this.btnCloseChamber = new System.Windows.Forms.Button();
            this.lblChamberStatus = new System.Windows.Forms.Label();
            this.grpStation = new System.Windows.Forms.GroupBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSaveStation = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFlexMsg = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpFixture_1.SuspendLayout();
            this.grpFixture_2.SuspendLayout();
            this.grpZebraTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOperator.SuspendLayout();
            this.grpFixture_Prog.SuspendLayout();
            this.grpSN_Verify.SuspendLayout();
            this.grpFlexFlowUrl.SuspendLayout();
            this.grpSetComPorts.SuspendLayout();
            this.grpChamberTest.SuspendLayout();
            this.grpStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1349, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serialPortToolStripMenuItem,
            this.communicationsToolStripMenuItem,
            this.programSettingsToolStripMenuItem,
            this.ChamberTest,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(973, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.serialPortToolStripMenuItem.Text = "Operator Login";
            this.serialPortToolStripMenuItem.Click += new System.EventHandler(this.serialPortToolStripMenuItem_Click);
            // 
            // communicationsToolStripMenuItem
            // 
            this.communicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readyManualOperationToolStripMenuItem,
            this.testScannerToolStripMenuItem,
            this.setComPortsToolStripMenuItem});
            this.communicationsToolStripMenuItem.Name = "communicationsToolStripMenuItem";
            this.communicationsToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.communicationsToolStripMenuItem.Text = "Communications";
            // 
            // readyManualOperationToolStripMenuItem
            // 
            this.readyManualOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readyONToolStripMenuItem,
            this.readyOFFToolStripMenuItem});
            this.readyManualOperationToolStripMenuItem.Name = "readyManualOperationToolStripMenuItem";
            this.readyManualOperationToolStripMenuItem.Size = new System.Drawing.Size(486, 44);
            this.readyManualOperationToolStripMenuItem.Text = "Ready Signal Manual Operation";
            // 
            // readyONToolStripMenuItem
            // 
            this.readyONToolStripMenuItem.Name = "readyONToolStripMenuItem";
            this.readyONToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            this.readyONToolStripMenuItem.Text = "Ready ON";
            this.readyONToolStripMenuItem.Click += new System.EventHandler(this.readyONToolStripMenuItem_Click_1);
            // 
            // readyOFFToolStripMenuItem
            // 
            this.readyOFFToolStripMenuItem.Name = "readyOFFToolStripMenuItem";
            this.readyOFFToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            this.readyOFFToolStripMenuItem.Text = "Ready OFF";
            this.readyOFFToolStripMenuItem.Click += new System.EventHandler(this.readyOFFToolStripMenuItem_Click_1);
            // 
            // testScannerToolStripMenuItem
            // 
            this.testScannerToolStripMenuItem.Name = "testScannerToolStripMenuItem";
            this.testScannerToolStripMenuItem.Size = new System.Drawing.Size(486, 44);
            this.testScannerToolStripMenuItem.Text = "Test Scanner";
            this.testScannerToolStripMenuItem.Click += new System.EventHandler(this.testScannerToolStripMenuItem_Click);
            // 
            // setComPortsToolStripMenuItem
            // 
            this.setComPortsToolStripMenuItem.Name = "setComPortsToolStripMenuItem";
            this.setComPortsToolStripMenuItem.Size = new System.Drawing.Size(486, 44);
            this.setComPortsToolStripMenuItem.Text = "Set ComPorts";
            this.setComPortsToolStripMenuItem.Click += new System.EventHandler(this.setComPortsToolStripMenuItem_Click);
            // 
            // programSettingsToolStripMenuItem
            // 
            this.programSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixture1ToolStripMenuItem,
            this.sNPartIdentifyToolStripMenuItem,
            this.flexFlowURLToolStripMenuItem,
            this.tsEnableFlexFlow,
            this.debugToolStripMenuItem,
            this.stationNameToolStripMenuItem});
            this.programSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.programSettingsToolStripMenuItem.Name = "programSettingsToolStripMenuItem";
            this.programSettingsToolStripMenuItem.Size = new System.Drawing.Size(218, 36);
            this.programSettingsToolStripMenuItem.Text = "Program Settings";
            // 
            // fixture1ToolStripMenuItem
            // 
            this.fixture1ToolStripMenuItem.Name = "fixture1ToolStripMenuItem";
            this.fixture1ToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.fixture1ToolStripMenuItem.Text = "Fixture Programs";
            this.fixture1ToolStripMenuItem.Click += new System.EventHandler(this.fixture1ToolStripMenuItem_Click);
            // 
            // sNPartIdentifyToolStripMenuItem
            // 
            this.sNPartIdentifyToolStripMenuItem.Name = "sNPartIdentifyToolStripMenuItem";
            this.sNPartIdentifyToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.sNPartIdentifyToolStripMenuItem.Text = "SN Part Identify";
            this.sNPartIdentifyToolStripMenuItem.Click += new System.EventHandler(this.sNPartIdentifyToolStripMenuItem_Click);
            // 
            // flexFlowURLToolStripMenuItem
            // 
            this.flexFlowURLToolStripMenuItem.Name = "flexFlowURLToolStripMenuItem";
            this.flexFlowURLToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.flexFlowURLToolStripMenuItem.Text = "IP Settings";
            this.flexFlowURLToolStripMenuItem.Click += new System.EventHandler(this.flexFlowURLToolStripMenuItem_Click);
            // 
            // tsEnableFlexFlow
            // 
            this.tsEnableFlexFlow.Checked = true;
            this.tsEnableFlexFlow.CheckOnClick = true;
            this.tsEnableFlexFlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsEnableFlexFlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsEnableFlexFlow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEnableFlexFlow.Name = "tsEnableFlexFlow";
            this.tsEnableFlexFlow.Size = new System.Drawing.Size(332, 44);
            this.tsEnableFlexFlow.Text = "FlexFlow Enabled";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.CheckOnClick = true;
            this.debugToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.debugToolStripMenuItem_CheckStateChanged);
            // 
            // stationNameToolStripMenuItem
            // 
            this.stationNameToolStripMenuItem.Name = "stationNameToolStripMenuItem";
            this.stationNameToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.stationNameToolStripMenuItem.Text = "Station Name";
            this.stationNameToolStripMenuItem.Click += new System.EventHandler(this.stationNameToolStripMenuItem_Click);
            // 
            // ChamberTest
            // 
            this.ChamberTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRToolStripMenuItem,
            this.sVToolStripMenuItem});
            this.ChamberTest.Name = "ChamberTest";
            this.ChamberTest.Size = new System.Drawing.Size(181, 36);
            this.ChamberTest.Text = "Chamber Test";
            // 
            // hRToolStripMenuItem
            // 
            this.hRToolStripMenuItem.Name = "hRToolStripMenuItem";
            this.hRToolStripMenuItem.Size = new System.Drawing.Size(180, 44);
            this.hRToolStripMenuItem.Text = "HR";
            this.hRToolStripMenuItem.Click += new System.EventHandler(this.hRToolStripMenuItem_Click);
            // 
            // sVToolStripMenuItem
            // 
            this.sVToolStripMenuItem.Name = "sVToolStripMenuItem";
            this.sVToolStripMenuItem.Size = new System.Drawing.Size(180, 44);
            this.sVToolStripMenuItem.Text = "SV";
            this.sVToolStripMenuItem.Click += new System.EventHandler(this.sVToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // lstRead
            // 
            this.lstRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRead.FormattingEnabled = true;
            this.lstRead.HorizontalScrollbar = true;
            this.lstRead.ItemHeight = 30;
            this.lstRead.Location = new System.Drawing.Point(1655, 9);
            this.lstRead.Margin = new System.Windows.Forms.Padding(2);
            this.lstRead.Name = "lstRead";
            this.lstRead.Size = new System.Drawing.Size(147, 1024);
            this.lstRead.TabIndex = 2;
            this.lstRead.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "disable P1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(79, 316);
            this.txtScan.Margin = new System.Windows.Forms.Padding(2);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(293, 31);
            this.txtScan.TabIndex = 4;
            this.txtScan.Visible = false;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "enable 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 598);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "enable 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(71, 203);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 84);
            this.button4.TabIndex = 7;
            this.button4.Text = "disable P2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tmrScanIn
            // 
            this.tmrScanIn.Tick += new System.EventHandler(this.tmrScanIn_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(71, 733);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 84);
            this.button5.TabIndex = 8;
            this.button5.Text = "Buffer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 500;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // lstTest
            // 
            this.lstTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTest.FormattingEnabled = true;
            this.lstTest.HorizontalScrollbar = true;
            this.lstTest.ItemHeight = 30;
            this.lstTest.Location = new System.Drawing.Point(1933, 92);
            this.lstTest.Margin = new System.Windows.Forms.Padding(2);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(486, 754);
            this.lstTest.TabIndex = 9;
            this.lstTest.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(271, 733);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 84);
            this.button6.TabIndex = 10;
            this.button6.Text = "Show Params";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // grpFixture_1
            // 
            this.grpFixture_1.Controls.Add(this.label3);
            this.grpFixture_1.Controls.Add(this.label2);
            this.grpFixture_1.Controls.Add(this.lblFix_1_Operator);
            this.grpFixture_1.Controls.Add(this.lblFix_1_SN);
            this.grpFixture_1.Controls.Add(this.lblFix_1_Status);
            this.grpFixture_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFixture_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFixture_1.Location = new System.Drawing.Point(15, 77);
            this.grpFixture_1.Margin = new System.Windows.Forms.Padding(2);
            this.grpFixture_1.Name = "grpFixture_1";
            this.grpFixture_1.Padding = new System.Windows.Forms.Padding(2);
            this.grpFixture_1.Size = new System.Drawing.Size(704, 500);
            this.grpFixture_1.TabIndex = 12;
            this.grpFixture_1.TabStop = false;
            this.grpFixture_1.Text = "Fixture 1       HR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Number";
            // 
            // lblFix_1_Operator
            // 
            this.lblFix_1_Operator.AutoSize = true;
            this.lblFix_1_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_1_Operator.Location = new System.Drawing.Point(23, 387);
            this.lblFix_1_Operator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_1_Operator.Name = "lblFix_1_Operator";
            this.lblFix_1_Operator.Size = new System.Drawing.Size(152, 55);
            this.lblFix_1_Operator.TabIndex = 2;
            this.lblFix_1_Operator.Text = "label2";
            // 
            // lblFix_1_SN
            // 
            this.lblFix_1_SN.AutoSize = true;
            this.lblFix_1_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_1_SN.Location = new System.Drawing.Point(23, 243);
            this.lblFix_1_SN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_1_SN.Name = "lblFix_1_SN";
            this.lblFix_1_SN.Size = new System.Drawing.Size(152, 55);
            this.lblFix_1_SN.TabIndex = 1;
            this.lblFix_1_SN.Text = "label2";
            // 
            // lblFix_1_Status
            // 
            this.lblFix_1_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFix_1_Status.AutoSize = true;
            this.lblFix_1_Status.BackColor = System.Drawing.Color.White;
            this.lblFix_1_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFix_1_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFix_1_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_1_Status.Location = new System.Drawing.Point(23, 97);
            this.lblFix_1_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_1_Status.Name = "lblFix_1_Status";
            this.lblFix_1_Status.Size = new System.Drawing.Size(241, 87);
            this.lblFix_1_Status.TabIndex = 0;
            this.lblFix_1_Status.Text = "label2";
            this.lblFix_1_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFixture_2
            // 
            this.grpFixture_2.Controls.Add(this.label4);
            this.grpFixture_2.Controls.Add(this.label5);
            this.grpFixture_2.Controls.Add(this.lblFix_2_Operator);
            this.grpFixture_2.Controls.Add(this.lblFix_2_SN);
            this.grpFixture_2.Controls.Add(this.lblFix_2_Status);
            this.grpFixture_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFixture_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFixture_2.Location = new System.Drawing.Point(772, 77);
            this.grpFixture_2.Margin = new System.Windows.Forms.Padding(2);
            this.grpFixture_2.Name = "grpFixture_2";
            this.grpFixture_2.Padding = new System.Windows.Forms.Padding(2);
            this.grpFixture_2.Size = new System.Drawing.Size(704, 500);
            this.grpFixture_2.TabIndex = 13;
            this.grpFixture_2.TabStop = false;
            this.grpFixture_2.Text = "Fixture 2       SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Serial Number";
            // 
            // lblFix_2_Operator
            // 
            this.lblFix_2_Operator.AutoSize = true;
            this.lblFix_2_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_2_Operator.Location = new System.Drawing.Point(23, 387);
            this.lblFix_2_Operator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_2_Operator.Name = "lblFix_2_Operator";
            this.lblFix_2_Operator.Size = new System.Drawing.Size(152, 55);
            this.lblFix_2_Operator.TabIndex = 2;
            this.lblFix_2_Operator.Text = "label2";
            // 
            // lblFix_2_SN
            // 
            this.lblFix_2_SN.AutoSize = true;
            this.lblFix_2_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_2_SN.Location = new System.Drawing.Point(23, 243);
            this.lblFix_2_SN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_2_SN.Name = "lblFix_2_SN";
            this.lblFix_2_SN.Size = new System.Drawing.Size(152, 55);
            this.lblFix_2_SN.TabIndex = 1;
            this.lblFix_2_SN.Text = "label2";
            // 
            // lblFix_2_Status
            // 
            this.lblFix_2_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFix_2_Status.AutoSize = true;
            this.lblFix_2_Status.BackColor = System.Drawing.Color.White;
            this.lblFix_2_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFix_2_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFix_2_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix_2_Status.Location = new System.Drawing.Point(23, 97);
            this.lblFix_2_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFix_2_Status.Name = "lblFix_2_Status";
            this.lblFix_2_Status.Size = new System.Drawing.Size(241, 87);
            this.lblFix_2_Status.TabIndex = 0;
            this.lblFix_2_Status.Text = "label2";
            this.lblFix_2_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // grpZebraTest
            // 
            this.grpZebraTest.BackColor = System.Drawing.Color.White;
            this.grpZebraTest.Controls.Add(this.lblTestScan);
            this.grpZebraTest.Controls.Add(this.label7);
            this.grpZebraTest.Controls.Add(this.btnClose);
            this.grpZebraTest.Controls.Add(this.label6);
            this.grpZebraTest.Controls.Add(this.pictureBox1);
            this.grpZebraTest.Location = new System.Drawing.Point(751, 726);
            this.grpZebraTest.Margin = new System.Windows.Forms.Padding(2);
            this.grpZebraTest.Name = "grpZebraTest";
            this.grpZebraTest.Padding = new System.Windows.Forms.Padding(2);
            this.grpZebraTest.Size = new System.Drawing.Size(453, 517);
            this.grpZebraTest.TabIndex = 15;
            this.grpZebraTest.TabStop = false;
            this.grpZebraTest.Text = "Test Scan Box";
            this.grpZebraTest.Visible = false;
            // 
            // lblTestScan
            // 
            this.lblTestScan.BackColor = System.Drawing.Color.White;
            this.lblTestScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScan.ForeColor = System.Drawing.Color.Black;
            this.lblTestScan.Location = new System.Drawing.Point(20, 298);
            this.lblTestScan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTestScan.Name = "lblTestScan";
            this.lblTestScan.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTestScan.Size = new System.Drawing.Size(412, 31);
            this.lblTestScan.TabIndex = 9;
            this.lblTestScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Size = new System.Drawing.Size(412, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "BenchTop Devices, LLC";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Location = new System.Drawing.Point(333, 457);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Size = new System.Drawing.Size(175, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Scan Barcode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_8082_Waymo_PC.Properties.Resources.BTD_barcode;
            this.pictureBox1.Location = new System.Drawing.Point(153, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpOperator
            // 
            this.grpOperator.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpOperator.Controls.Add(this.btnOperClose);
            this.grpOperator.Controls.Add(this.txtOperator);
            this.grpOperator.Controls.Add(this.label11);
            this.grpOperator.Controls.Add(this.label12);
            this.grpOperator.Controls.Add(this.button8);
            this.grpOperator.Location = new System.Drawing.Point(496, 659);
            this.grpOperator.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperator.Name = "grpOperator";
            this.grpOperator.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperator.Size = new System.Drawing.Size(540, 517);
            this.grpOperator.TabIndex = 16;
            this.grpOperator.TabStop = false;
            this.grpOperator.Text = "Operator Assign";
            this.grpOperator.Visible = false;
            // 
            // btnOperClose
            // 
            this.btnOperClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnOperClose.Location = new System.Drawing.Point(384, 455);
            this.btnOperClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnOperClose.Name = "btnOperClose";
            this.btnOperClose.Size = new System.Drawing.Size(110, 51);
            this.btnOperClose.TabIndex = 8;
            this.btnOperClose.Text = "CLOSE";
            this.btnOperClose.UseVisualStyleBackColor = false;
            this.btnOperClose.Click += new System.EventHandler(this.btnOperClose_Click);
            // 
            // txtOperator
            // 
            this.txtOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator.Location = new System.Drawing.Point(37, 85);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(2);
            this.txtOperator.MaxLength = 20;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(467, 44);
            this.txtOperator.TabIndex = 7;
            this.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Operator Info";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(75, 216);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Size = new System.Drawing.Size(407, 80);
            this.label12.TabIndex = 5;
            this.label12.Text = "Scan or Enter Operator";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SpringGreen;
            this.button8.Location = new System.Drawing.Point(31, 454);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 54);
            this.button8.TabIndex = 2;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // grpFixture_Prog
            // 
            this.grpFixture_Prog.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpFixture_Prog.Controls.Add(this.cmbFix_2_Prg);
            this.grpFixture_Prog.Controls.Add(this.cmbFix_1_Prg);
            this.grpFixture_Prog.Controls.Add(this.button9);
            this.grpFixture_Prog.Controls.Add(this.btnSavePrograms);
            this.grpFixture_Prog.Controls.Add(this.label14);
            this.grpFixture_Prog.Controls.Add(this.label13);
            this.grpFixture_Prog.Location = new System.Drawing.Point(15, 742);
            this.grpFixture_Prog.Margin = new System.Windows.Forms.Padding(2);
            this.grpFixture_Prog.Name = "grpFixture_Prog";
            this.grpFixture_Prog.Padding = new System.Windows.Forms.Padding(2);
            this.grpFixture_Prog.Size = new System.Drawing.Size(361, 434);
            this.grpFixture_Prog.TabIndex = 17;
            this.grpFixture_Prog.TabStop = false;
            this.grpFixture_Prog.Text = "Fixture Settings";
            this.grpFixture_Prog.Visible = false;
            // 
            // cmbFix_2_Prg
            // 
            this.cmbFix_2_Prg.FormattingEnabled = true;
            this.cmbFix_2_Prg.Location = new System.Drawing.Point(55, 249);
            this.cmbFix_2_Prg.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFix_2_Prg.Name = "cmbFix_2_Prg";
            this.cmbFix_2_Prg.Size = new System.Drawing.Size(233, 33);
            this.cmbFix_2_Prg.TabIndex = 9;
            // 
            // cmbFix_1_Prg
            // 
            this.cmbFix_1_Prg.FormattingEnabled = true;
            this.cmbFix_1_Prg.Location = new System.Drawing.Point(55, 97);
            this.cmbFix_1_Prg.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFix_1_Prg.Name = "cmbFix_1_Prg";
            this.cmbFix_1_Prg.Size = new System.Drawing.Size(233, 33);
            this.cmbFix_1_Prg.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MistyRose;
            this.button9.Location = new System.Drawing.Point(229, 366);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 51);
            this.button9.TabIndex = 7;
            this.button9.Text = "CLOSE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSavePrograms
            // 
            this.btnSavePrograms.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSavePrograms.Location = new System.Drawing.Point(4, 362);
            this.btnSavePrograms.Margin = new System.Windows.Forms.Padding(2);
            this.btnSavePrograms.Name = "btnSavePrograms";
            this.btnSavePrograms.Size = new System.Drawing.Size(165, 54);
            this.btnSavePrograms.TabIndex = 6;
            this.btnSavePrograms.Text = "Save/Exit";
            this.btnSavePrograms.UseVisualStyleBackColor = false;
            this.btnSavePrograms.Click += new System.EventHandler(this.btnSavePrograms_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 221);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(253, 26);
            this.label14.TabIndex = 5;
            this.label14.Text = "Select Fixture 2 Program";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(253, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Select Fixture 1 Program";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(476, 580);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 85);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSN_Verify
            // 
            this.grpSN_Verify.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpSN_Verify.Controls.Add(this.label20);
            this.grpSN_Verify.Controls.Add(this.txtSV_New);
            this.grpSN_Verify.Controls.Add(this.txtHR_New);
            this.grpSN_Verify.Controls.Add(this.lblSV_Current);
            this.grpSN_Verify.Controls.Add(this.lblHR_Current);
            this.grpSN_Verify.Controls.Add(this.label19);
            this.grpSN_Verify.Controls.Add(this.label18);
            this.grpSN_Verify.Controls.Add(this.label17);
            this.grpSN_Verify.Controls.Add(this.btnSave_ID);
            this.grpSN_Verify.Controls.Add(this.btnClose_ID);
            this.grpSN_Verify.Controls.Add(this.label16);
            this.grpSN_Verify.Location = new System.Drawing.Point(152, 713);
            this.grpSN_Verify.Margin = new System.Windows.Forms.Padding(2);
            this.grpSN_Verify.Name = "grpSN_Verify";
            this.grpSN_Verify.Padding = new System.Windows.Forms.Padding(2);
            this.grpSN_Verify.Size = new System.Drawing.Size(540, 396);
            this.grpSN_Verify.TabIndex = 20;
            this.grpSN_Verify.TabStop = false;
            this.grpSN_Verify.Text = "SN Part ID";
            this.grpSN_Verify.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(293, 203);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 26);
            this.label20.TabIndex = 16;
            this.label20.Text = "NEW";
            // 
            // txtSV_New
            // 
            this.txtSV_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSV_New.Location = new System.Drawing.Point(358, 189);
            this.txtSV_New.Margin = new System.Windows.Forms.Padding(2);
            this.txtSV_New.MaxLength = 2;
            this.txtSV_New.Name = "txtSV_New";
            this.txtSV_New.Size = new System.Drawing.Size(76, 50);
            this.txtSV_New.TabIndex = 15;
            this.txtSV_New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSV_New.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSV_New_KeyPress);
            // 
            // txtHR_New
            // 
            this.txtHR_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHR_New.Location = new System.Drawing.Point(358, 106);
            this.txtHR_New.Margin = new System.Windows.Forms.Padding(2);
            this.txtHR_New.MaxLength = 2;
            this.txtHR_New.Name = "txtHR_New";
            this.txtHR_New.Size = new System.Drawing.Size(76, 50);
            this.txtHR_New.TabIndex = 14;
            this.txtHR_New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHR_New.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHR_New_KeyPress);
            // 
            // lblSV_Current
            // 
            this.lblSV_Current.AutoSize = true;
            this.lblSV_Current.BackColor = System.Drawing.Color.PowderBlue;
            this.lblSV_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSV_Current.ForeColor = System.Drawing.Color.Black;
            this.lblSV_Current.Location = new System.Drawing.Point(155, 189);
            this.lblSV_Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSV_Current.Name = "lblSV_Current";
            this.lblSV_Current.Size = new System.Drawing.Size(74, 44);
            this.lblSV_Current.TabIndex = 13;
            this.lblSV_Current.Text = "HR";
            // 
            // lblHR_Current
            // 
            this.lblHR_Current.AutoSize = true;
            this.lblHR_Current.BackColor = System.Drawing.Color.PowderBlue;
            this.lblHR_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHR_Current.ForeColor = System.Drawing.Color.Black;
            this.lblHR_Current.Location = new System.Drawing.Point(155, 106);
            this.lblHR_Current.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHR_Current.Name = "lblHR_Current";
            this.lblHR_Current.Size = new System.Drawing.Size(74, 44);
            this.lblHR_Current.TabIndex = 12;
            this.lblHR_Current.Text = "HR";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(28, 189);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 44);
            this.label19.TabIndex = 11;
            this.label19.Text = "SV";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(28, 106);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 44);
            this.label18.TabIndex = 10;
            this.label18.Text = "HR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(295, 123);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 26);
            this.label17.TabIndex = 9;
            this.label17.Text = "NEW";
            // 
            // btnSave_ID
            // 
            this.btnSave_ID.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave_ID.Location = new System.Drawing.Point(38, 269);
            this.btnSave_ID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave_ID.Name = "btnSave_ID";
            this.btnSave_ID.Size = new System.Drawing.Size(165, 54);
            this.btnSave_ID.TabIndex = 8;
            this.btnSave_ID.Text = "Save";
            this.btnSave_ID.UseVisualStyleBackColor = false;
            this.btnSave_ID.Click += new System.EventHandler(this.btnSave_ID_Click);
            // 
            // btnClose_ID
            // 
            this.btnClose_ID.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose_ID.Location = new System.Drawing.Point(397, 272);
            this.btnClose_ID.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose_ID.Name = "btnClose_ID";
            this.btnClose_ID.Size = new System.Drawing.Size(110, 51);
            this.btnClose_ID.TabIndex = 7;
            this.btnClose_ID.Text = "CLOSE";
            this.btnClose_ID.UseVisualStyleBackColor = false;
            this.btnClose_ID.Click += new System.EventHandler(this.btnClose_ID_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(134, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 26);
            this.label16.TabIndex = 6;
            this.label16.Text = "CURRENT";
            // 
            // grpFlexFlowUrl
            // 
            this.grpFlexFlowUrl.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpFlexFlowUrl.Controls.Add(this.btnCloseFlexUrl);
            this.grpFlexFlowUrl.Controls.Add(this.txtNew_FlexFlowUrl);
            this.grpFlexFlowUrl.Controls.Add(this.label8);
            this.grpFlexFlowUrl.Controls.Add(this.label9);
            this.grpFlexFlowUrl.Controls.Add(this.btnSaveFlexUrl);
            this.grpFlexFlowUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlexFlowUrl.Location = new System.Drawing.Point(79, 600);
            this.grpFlexFlowUrl.Margin = new System.Windows.Forms.Padding(2);
            this.grpFlexFlowUrl.Name = "grpFlexFlowUrl";
            this.grpFlexFlowUrl.Padding = new System.Windows.Forms.Padding(2);
            this.grpFlexFlowUrl.Size = new System.Drawing.Size(1173, 470);
            this.grpFlexFlowUrl.TabIndex = 21;
            this.grpFlexFlowUrl.TabStop = false;
            this.grpFlexFlowUrl.Text = "Set FlexFlow URL";
            this.grpFlexFlowUrl.Visible = false;
            // 
            // btnCloseFlexUrl
            // 
            this.btnCloseFlexUrl.BackColor = System.Drawing.Color.MistyRose;
            this.btnCloseFlexUrl.Location = new System.Drawing.Point(979, 397);
            this.btnCloseFlexUrl.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseFlexUrl.Name = "btnCloseFlexUrl";
            this.btnCloseFlexUrl.Size = new System.Drawing.Size(167, 51);
            this.btnCloseFlexUrl.TabIndex = 9;
            this.btnCloseFlexUrl.Text = "CLOSE";
            this.btnCloseFlexUrl.UseVisualStyleBackColor = false;
            this.btnCloseFlexUrl.Click += new System.EventHandler(this.btnCloseFlexUrl_Click);
            // 
            // txtNew_FlexFlowUrl
            // 
            this.txtNew_FlexFlowUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew_FlexFlowUrl.Location = new System.Drawing.Point(25, 198);
            this.txtNew_FlexFlowUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNew_FlexFlowUrl.MaxLength = 200;
            this.txtNew_FlexFlowUrl.Name = "txtNew_FlexFlowUrl";
            this.txtNew_FlexFlowUrl.Size = new System.Drawing.Size(1125, 44);
            this.txtNew_FlexFlowUrl.TabIndex = 8;
            this.txtNew_FlexFlowUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(424, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 44);
            this.label8.TabIndex = 6;
            this.label8.Text = " Current URL";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(375, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Size = new System.Drawing.Size(407, 80);
            this.label9.TabIndex = 5;
            this.label9.Text = "Enter New URL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveFlexUrl
            // 
            this.btnSaveFlexUrl.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSaveFlexUrl.Location = new System.Drawing.Point(31, 395);
            this.btnSaveFlexUrl.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFlexUrl.Name = "btnSaveFlexUrl";
            this.btnSaveFlexUrl.Size = new System.Drawing.Size(165, 54);
            this.btnSaveFlexUrl.TabIndex = 2;
            this.btnSaveFlexUrl.Text = "Save";
            this.btnSaveFlexUrl.UseVisualStyleBackColor = false;
            this.btnSaveFlexUrl.Click += new System.EventHandler(this.btnSaveFlexUrl_Click);
            // 
            // grpSetComPorts
            // 
            this.grpSetComPorts.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpSetComPorts.Controls.Add(this.txtZebra);
            this.grpSetComPorts.Controls.Add(this.label21);
            this.grpSetComPorts.Controls.Add(this.btnCloseComports);
            this.grpSetComPorts.Controls.Add(this.txtReadyCom);
            this.grpSetComPorts.Controls.Add(this.label10);
            this.grpSetComPorts.Controls.Add(this.btnSaveCom);
            this.grpSetComPorts.Location = new System.Drawing.Point(585, 387);
            this.grpSetComPorts.Margin = new System.Windows.Forms.Padding(2);
            this.grpSetComPorts.Name = "grpSetComPorts";
            this.grpSetComPorts.Padding = new System.Windows.Forms.Padding(2);
            this.grpSetComPorts.Size = new System.Drawing.Size(946, 470);
            this.grpSetComPorts.TabIndex = 22;
            this.grpSetComPorts.TabStop = false;
            this.grpSetComPorts.Text = "Set Comports";
            this.grpSetComPorts.Visible = false;
            // 
            // txtZebra
            // 
            this.txtZebra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtZebra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZebra.Location = new System.Drawing.Point(334, 239);
            this.txtZebra.Margin = new System.Windows.Forms.Padding(2);
            this.txtZebra.MaxLength = 200;
            this.txtZebra.Name = "txtZebra";
            this.txtZebra.Size = new System.Drawing.Size(151, 44);
            this.txtZebra.TabIndex = 11;
            this.txtZebra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(16, 234);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(318, 44);
            this.label21.TabIndex = 10;
            this.label21.Text = "Scanner Comport";
            // 
            // btnCloseComports
            // 
            this.btnCloseComports.BackColor = System.Drawing.Color.MistyRose;
            this.btnCloseComports.Location = new System.Drawing.Point(817, 395);
            this.btnCloseComports.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseComports.Name = "btnCloseComports";
            this.btnCloseComports.Size = new System.Drawing.Size(110, 51);
            this.btnCloseComports.TabIndex = 9;
            this.btnCloseComports.Text = "CLOSE";
            this.btnCloseComports.UseVisualStyleBackColor = false;
            this.btnCloseComports.Click += new System.EventHandler(this.btnCloseComports_Click);
            // 
            // txtReadyCom
            // 
            this.txtReadyCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReadyCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyCom.Location = new System.Drawing.Point(297, 122);
            this.txtReadyCom.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadyCom.MaxLength = 200;
            this.txtReadyCom.Name = "txtReadyCom";
            this.txtReadyCom.Size = new System.Drawing.Size(151, 44);
            this.txtReadyCom.TabIndex = 7;
            this.txtReadyCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 44);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ready Comport";
            // 
            // btnSaveCom
            // 
            this.btnSaveCom.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSaveCom.Location = new System.Drawing.Point(31, 395);
            this.btnSaveCom.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCom.Name = "btnSaveCom";
            this.btnSaveCom.Size = new System.Drawing.Size(165, 54);
            this.btnSaveCom.TabIndex = 2;
            this.btnSaveCom.Text = "Save";
            this.btnSaveCom.UseVisualStyleBackColor = false;
            this.btnSaveCom.Click += new System.EventHandler(this.btnSaveCom_Click);
            // 
            // txtFlexError
            // 
            this.txtFlexError.BackColor = System.Drawing.Color.Red;
            this.txtFlexError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlexError.ForeColor = System.Drawing.Color.White;
            this.txtFlexError.Location = new System.Drawing.Point(15, 695);
            this.txtFlexError.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlexError.Multiline = true;
            this.txtFlexError.Name = "txtFlexError";
            this.txtFlexError.ReadOnly = true;
            this.txtFlexError.Size = new System.Drawing.Size(751, 324);
            this.txtFlexError.TabIndex = 23;
            this.txtFlexError.Visible = false;
            // 
            // grpChamberTest
            // 
            this.grpChamberTest.BackColor = System.Drawing.Color.Aqua;
            this.grpChamberTest.Controls.Add(this.btnCloseChamber);
            this.grpChamberTest.Controls.Add(this.lblChamberStatus);
            this.grpChamberTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChamberTest.Location = new System.Drawing.Point(1535, 91);
            this.grpChamberTest.Margin = new System.Windows.Forms.Padding(2);
            this.grpChamberTest.Name = "grpChamberTest";
            this.grpChamberTest.Padding = new System.Windows.Forms.Padding(2);
            this.grpChamberTest.Size = new System.Drawing.Size(1045, 407);
            this.grpChamberTest.TabIndex = 24;
            this.grpChamberTest.TabStop = false;
            this.grpChamberTest.Text = "Chamber Test";
            this.grpChamberTest.Visible = false;
            // 
            // btnCloseChamber
            // 
            this.btnCloseChamber.BackColor = System.Drawing.Color.MistyRose;
            this.btnCloseChamber.Location = new System.Drawing.Point(188, 306);
            this.btnCloseChamber.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseChamber.Name = "btnCloseChamber";
            this.btnCloseChamber.Size = new System.Drawing.Size(167, 80);
            this.btnCloseChamber.TabIndex = 10;
            this.btnCloseChamber.Text = "CLOSE";
            this.btnCloseChamber.UseVisualStyleBackColor = false;
            this.btnCloseChamber.Click += new System.EventHandler(this.btnCloseChamber_Click);
            // 
            // lblChamberStatus
            // 
            this.lblChamberStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChamberStatus.AutoSize = true;
            this.lblChamberStatus.BackColor = System.Drawing.Color.White;
            this.lblChamberStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChamberStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblChamberStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamberStatus.Location = new System.Drawing.Point(17, 83);
            this.lblChamberStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChamberStatus.Name = "lblChamberStatus";
            this.lblChamberStatus.Size = new System.Drawing.Size(241, 87);
            this.lblChamberStatus.TabIndex = 1;
            this.lblChamberStatus.Text = "label2";
            this.lblChamberStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpStation
            // 
            this.grpStation.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpStation.Controls.Add(this.txtStationName);
            this.grpStation.Controls.Add(this.button7);
            this.grpStation.Controls.Add(this.btnSaveStation);
            this.grpStation.Controls.Add(this.label22);
            this.grpStation.Location = new System.Drawing.Point(2076, 502);
            this.grpStation.Margin = new System.Windows.Forms.Padding(2);
            this.grpStation.Name = "grpStation";
            this.grpStation.Padding = new System.Windows.Forms.Padding(2);
            this.grpStation.Size = new System.Drawing.Size(486, 434);
            this.grpStation.TabIndex = 18;
            this.grpStation.TabStop = false;
            this.grpStation.Text = "Station Name";
            this.grpStation.Visible = false;
            // 
            // txtStationName
            // 
            this.txtStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(24, 159);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(431, 44);
            this.txtStationName.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MistyRose;
            this.button7.Location = new System.Drawing.Point(345, 362);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 51);
            this.button7.TabIndex = 7;
            this.button7.Text = "CLOSE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSaveStation
            // 
            this.btnSaveStation.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSaveStation.Location = new System.Drawing.Point(4, 362);
            this.btnSaveStation.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveStation.Name = "btnSaveStation";
            this.btnSaveStation.Size = new System.Drawing.Size(165, 54);
            this.btnSaveStation.TabIndex = 6;
            this.btnSaveStation.Text = "Save/Exit";
            this.btnSaveStation.UseVisualStyleBackColor = false;
            this.btnSaveStation.Click += new System.EventHandler(this.btnSaveStation_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(99, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(250, 31);
            this.label22.TabIndex = 4;
            this.label22.Text = "Enter Station Name";
            // 
            // txtFlexMsg
            // 
            this.txtFlexMsg.Location = new System.Drawing.Point(1267, 948);
            this.txtFlexMsg.Multiline = true;
            this.txtFlexMsg.Name = "txtFlexMsg";
            this.txtFlexMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFlexMsg.Size = new System.Drawing.Size(1214, 317);
            this.txtFlexMsg.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2589, 1277);
            this.Controls.Add(this.txtFlexMsg);
            this.Controls.Add(this.grpStation);
            this.Controls.Add(this.grpChamberTest);
            this.Controls.Add(this.grpFlexFlowUrl);
            this.Controls.Add(this.txtFlexError);
            this.Controls.Add(this.grpSetComPorts);
            this.Controls.Add(this.grpOperator);
            this.Controls.Add(this.grpFixture_Prog);
            this.Controls.Add(this.grpSN_Verify);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.grpZebraTest);
            this.Controls.Add(this.grpFixture_2);
            this.Controls.Add(this.grpFixture_1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "_8082_Waymo_PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFixture_1.ResumeLayout(false);
            this.grpFixture_1.PerformLayout();
            this.grpFixture_2.ResumeLayout(false);
            this.grpFixture_2.PerformLayout();
            this.grpZebraTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOperator.ResumeLayout(false);
            this.grpOperator.PerformLayout();
            this.grpFixture_Prog.ResumeLayout(false);
            this.grpFixture_Prog.PerformLayout();
            this.grpSN_Verify.ResumeLayout(false);
            this.grpSN_Verify.PerformLayout();
            this.grpFlexFlowUrl.ResumeLayout(false);
            this.grpFlexFlowUrl.PerformLayout();
            this.grpSetComPorts.ResumeLayout(false);
            this.grpSetComPorts.PerformLayout();
            this.grpChamberTest.ResumeLayout(false);
            this.grpChamberTest.PerformLayout();
            this.grpStation.ResumeLayout(false);
            this.grpStation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox lstRead;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tmrScanIn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationsToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ToolStripMenuItem readyManualOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readyONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readyOFFToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpFixture_1;
        private System.Windows.Forms.Label lblFix_1_Status;
        private System.Windows.Forms.Label lblFix_1_Operator;
        private System.Windows.Forms.Label lblFix_1_SN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpFixture_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFix_2_Operator;
        private System.Windows.Forms.Label lblFix_2_SN;
        private System.Windows.Forms.Label lblFix_2_Status;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.GroupBox grpZebraTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.ToolStripMenuItem programSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixture1ToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpFixture_Prog;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnSavePrograms;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFix_2_Prg;
        private System.Windows.Forms.ComboBox cmbFix_1_Prg;
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.ToolStripMenuItem sNPartIdentifyToolStripMenuItem;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpSN_Verify;
        private System.Windows.Forms.Label lblSV_Current;
        private System.Windows.Forms.Label lblHR_Current;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSave_ID;
        private System.Windows.Forms.Button btnClose_ID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHR_New;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSV_New;
        private System.Windows.Forms.ToolStripMenuItem testScannerToolStripMenuItem;
        private System.Windows.Forms.Label lblTestScan;
        private System.Windows.Forms.ToolStripMenuItem flexFlowURLToolStripMenuItem;
        private System.Windows.Forms.Button btnOperClose;
        private System.Windows.Forms.GroupBox grpFlexFlowUrl;
        private System.Windows.Forms.TextBox txtNew_FlexFlowUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveFlexUrl;
        private System.Windows.Forms.Button btnCloseFlexUrl;
        private System.Windows.Forms.ToolStripMenuItem setComPortsToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSetComPorts;
        private System.Windows.Forms.TextBox txtZebra;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCloseComports;
        private System.Windows.Forms.TextBox txtReadyCom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveCom;
        private System.Windows.Forms.TextBox txtFlexError;
        private System.Windows.Forms.ToolStripMenuItem ChamberTest;
        private System.Windows.Forms.ToolStripMenuItem hRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sVToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpChamberTest;
        private System.Windows.Forms.Button btnCloseChamber;
        private System.Windows.Forms.Label lblChamberStatus;
        private System.Windows.Forms.ToolStripMenuItem tsEnableFlexFlow;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationNameToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpStation;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSaveStation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFlexMsg;
    }
}

