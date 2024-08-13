namespace RocketUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDownBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.btnBaglantiyiBitir = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBaglanti = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHakemDurum = new System.Windows.Forms.Label();
            this.btnHakemIletisim = new System.Windows.Forms.Button();
            this.lblDosyaKayit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDosyayaKaydet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gMapPayload = new GMap.NET.WindowsForms.GMapControl();
            this.checkBoxSD_gorev = new System.Windows.Forms.CheckBox();
            this.checkBoxBME_gorev = new System.Windows.Forms.CheckBox();
            this.checkBoxGps_gorev = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPaketNum_GorevYuku = new System.Windows.Forms.TextBox();
            this.textBoxSicaklik_GorevYuku = new System.Windows.Forms.TextBox();
            this.textBoxNem_GorevYuku = new System.Windows.Forms.TextBox();
            this.textBoxBasinc_GorevYuku = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxGPSIrtifa_GorevYuku = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxGPSEnlem_GorevYuku = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxGPSBoylam_GorevYuku = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxGPSSatNum_GorevYuku = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPaketNum_AnaBil = new System.Windows.Forms.TextBox();
            this.textBoxBasinc_AnaBil = new System.Windows.Forms.TextBox();
            this.textBoxBasincIrtifa_AnaBil = new System.Windows.Forms.TextBox();
            this.textBoxGPSIrtifa_AnaBil = new System.Windows.Forms.TextBox();
            this.textBoxGPSEnlem_AnaBil = new System.Windows.Forms.TextBox();
            this.textBoxGPSBoylam_AnaBil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxJiroX_AnaBil = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxJiroY_AnaBil = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxJiroZ_AnaBil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIvmeX_AnaBil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIvmeY_AnaBil = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIvmeZ_AnaBil = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxAci_AnaBil = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxGPSSatNum_AnaBil = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBoxGPS = new System.Windows.Forms.CheckBox();
            this.checkBoxbBNO = new System.Windows.Forms.CheckBox();
            this.checkBoxBME = new System.Windows.Forms.CheckBox();
            this.checkBoxSD = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gMapMain = new GMap.NET.WindowsForms.GMapControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.patlama2_yes = new System.Windows.Forms.PictureBox();
            this.patlama1_yes = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.patlama2_no = new System.Windows.Forms.PictureBox();
            this.patlama1_no = new System.Windows.Forms.PictureBox();
            this.chartAltitudeMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAltitudePayload = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPressureMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPressurePayload = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAltitudeMainTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).BeginInit();
            this.panelBaglanti.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama2_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama1_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama2_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama1_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitudeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitudePayload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressurePayload)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBaudRate
            // 
            this.numericUpDownBaudRate.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBaudRate.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.numericUpDownBaudRate.Location = new System.Drawing.Point(760, 7);
            this.numericUpDownBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownBaudRate.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDownBaudRate.Name = "numericUpDownBaudRate";
            this.numericUpDownBaudRate.Size = new System.Drawing.Size(113, 36);
            this.numericUpDownBaudRate.TabIndex = 5;
            this.numericUpDownBaudRate.Value = new decimal(new int[] {
            11500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Agency FB", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(613, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate:";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxComPort.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(203, 25);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(197, 36);
            this.comboBoxComPort.TabIndex = 8;
            this.comboBoxComPort.Text = "Port Secin !";
            // 
            // btnBaglantiyiBitir
            // 
            this.btnBaglantiyiBitir.BackColor = System.Drawing.Color.Maroon;
            this.btnBaglantiyiBitir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaglantiyiBitir.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnBaglantiyiBitir.ForeColor = System.Drawing.Color.White;
            this.btnBaglantiyiBitir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaglantiyiBitir.Location = new System.Drawing.Point(1073, 4);
            this.btnBaglantiyiBitir.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglantiyiBitir.Name = "btnBaglantiyiBitir";
            this.btnBaglantiyiBitir.Size = new System.Drawing.Size(172, 46);
            this.btnBaglantiyiBitir.TabIndex = 10;
            this.btnBaglantiyiBitir.Text = "Baglantıyı Bitir";
            this.btnBaglantiyiBitir.UseVisualStyleBackColor = false;
            this.btnBaglantiyiBitir.Click += new System.EventHandler(this.btnBaglantiyiBitir_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaglan.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnBaglan.ForeColor = System.Drawing.Color.White;
            this.btnBaglan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaglan.Location = new System.Drawing.Point(897, 4);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(105, 44);
            this.btnBaglan.TabIndex = 11;
            this.btnBaglan.Text = "Baglan";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // timer1
            // 
            this.timer1.Tag = "asdasdasdasdasdas";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBaglanti
            // 
            this.panelBaglanti.AutoSize = true;
            this.panelBaglanti.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBaglanti.Controls.Add(this.button2);
            this.panelBaglanti.Controls.Add(this.button1);
            this.panelBaglanti.Controls.Add(this.lblHakemDurum);
            this.panelBaglanti.Controls.Add(this.btnHakemIletisim);
            this.panelBaglanti.Controls.Add(this.lblDosyaKayit);
            this.panelBaglanti.Controls.Add(this.label1);
            this.panelBaglanti.Controls.Add(this.comboBoxComPort);
            this.panelBaglanti.Controls.Add(this.btnDosyayaKaydet);
            this.panelBaglanti.Controls.Add(this.btnBaglan);
            this.panelBaglanti.Controls.Add(this.btnBaglantiyiBitir);
            this.panelBaglanti.Controls.Add(this.btnRefresh);
            this.panelBaglanti.Controls.Add(this.lblDurum);
            this.panelBaglanti.Controls.Add(this.label2);
            this.panelBaglanti.Controls.Add(this.numericUpDownBaudRate);
            this.panelBaglanti.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaglanti.Location = new System.Drawing.Point(0, 0);
            this.panelBaglanti.Margin = new System.Windows.Forms.Padding(4);
            this.panelBaglanti.Name = "panelBaglanti";
            this.panelBaglanti.Size = new System.Drawing.Size(2415, 73);
            this.panelBaglanti.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1774, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(637, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Hakem Yer Istasyonuna Baglan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnHakemIletisim_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1316, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dosyaya Kaydetmeye Basla";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblHakemDurum
            // 
            this.lblHakemDurum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHakemDurum.AutoSize = true;
            this.lblHakemDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblHakemDurum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHakemDurum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHakemDurum.Location = new System.Drawing.Point(6136, 0);
            this.lblHakemDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHakemDurum.Name = "lblHakemDurum";
            this.lblHakemDurum.Size = new System.Drawing.Size(146, 24);
            this.lblHakemDurum.TabIndex = 11;
            this.lblHakemDurum.Text = "*HYI Bagli Degil!";
            // 
            // btnHakemIletisim
            // 
            this.btnHakemIletisim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHakemIletisim.BackColor = System.Drawing.Color.Purple;
            this.btnHakemIletisim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHakemIletisim.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnHakemIletisim.ForeColor = System.Drawing.Color.White;
            this.btnHakemIletisim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHakemIletisim.Location = new System.Drawing.Point(6311, 14);
            this.btnHakemIletisim.Margin = new System.Windows.Forms.Padding(4);
            this.btnHakemIletisim.Name = "btnHakemIletisim";
            this.btnHakemIletisim.Size = new System.Drawing.Size(301, 47);
            this.btnHakemIletisim.TabIndex = 10;
            this.btnHakemIletisim.Text = "Hakem Yer Istasyonuna Baglan";
            this.btnHakemIletisim.UseVisualStyleBackColor = false;
            // 
            // lblDosyaKayit
            // 
            this.lblDosyaKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDosyaKayit.AutoSize = true;
            this.lblDosyaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDosyaKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDosyaKayit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDosyaKayit.Location = new System.Drawing.Point(5999, 0);
            this.lblDosyaKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaKayit.Name = "lblDosyaKayit";
            this.lblDosyaKayit.Size = new System.Drawing.Size(140, 24);
            this.lblDosyaKayit.TabIndex = 9;
            this.lblDosyaKayit.Text = "*Kaydedilmiyor!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Agency FB", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM Port:";
            // 
            // btnDosyayaKaydet
            // 
            this.btnDosyayaKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDosyayaKaydet.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDosyayaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosyayaKaydet.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDosyayaKaydet.ForeColor = System.Drawing.Color.White;
            this.btnDosyayaKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDosyayaKaydet.Location = new System.Drawing.Point(3195, 4);
            this.btnDosyayaKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            this.btnDosyayaKaydet.Size = new System.Drawing.Size(312, 44);
            this.btnDosyayaKaydet.TabIndex = 8;
            this.btnDosyayaKaydet.Text = "Dosyaya Kaydetmeye Basla";
            this.btnDosyayaKaydet.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(12, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 46);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDurum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDurum.Location = new System.Drawing.Point(-4, 0);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(125, 24);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "*Baglanti Yok!";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label33.Location = new System.Drawing.Point(255, 37);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(181, 57);
            this.label33.TabIndex = 18;
            this.label33.Text = "1. Patlama";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label34.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label34.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label34.Location = new System.Drawing.Point(255, 229);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(193, 57);
            this.label34.TabIndex = 19;
            this.label34.Text = "2. Patlama";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.checkBoxSD_gorev);
            this.panel2.Controls.Add(this.checkBoxBME_gorev);
            this.panel2.Controls.Add(this.checkBoxGps_gorev);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1846, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 1294);
            this.panel2.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.gMapPayload);
            this.panel7.Location = new System.Drawing.Point(16, 745);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(536, 532);
            this.panel7.TabIndex = 36;
            // 
            // gMapPayload
            // 
            this.gMapPayload.Bearing = 0F;
            this.gMapPayload.CanDragMap = true;
            this.gMapPayload.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapPayload.GrayScaleMode = false;
            this.gMapPayload.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapPayload.LevelsKeepInMemmory = 5;
            this.gMapPayload.Location = new System.Drawing.Point(4, 4);
            this.gMapPayload.Margin = new System.Windows.Forms.Padding(4);
            this.gMapPayload.MarkersEnabled = true;
            this.gMapPayload.MaxZoom = 2;
            this.gMapPayload.MinZoom = 2;
            this.gMapPayload.MouseWheelZoomEnabled = true;
            this.gMapPayload.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapPayload.Name = "gMapPayload";
            this.gMapPayload.NegativeMode = false;
            this.gMapPayload.PolygonsEnabled = true;
            this.gMapPayload.RetryLoadTile = 0;
            this.gMapPayload.RoutesEnabled = true;
            this.gMapPayload.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapPayload.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapPayload.ShowTileGridLines = false;
            this.gMapPayload.Size = new System.Drawing.Size(528, 523);
            this.gMapPayload.TabIndex = 36;
            this.gMapPayload.Zoom = 0D;
            // 
            // checkBoxSD_gorev
            // 
            this.checkBoxSD_gorev.AutoSize = true;
            this.checkBoxSD_gorev.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSD_gorev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxSD_gorev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxSD_gorev.Location = new System.Drawing.Point(403, 39);
            this.checkBoxSD_gorev.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxSD_gorev.Name = "checkBoxSD_gorev";
            this.checkBoxSD_gorev.Size = new System.Drawing.Size(74, 20);
            this.checkBoxSD_gorev.TabIndex = 35;
            this.checkBoxSD_gorev.Text = "SD Kart";
            this.checkBoxSD_gorev.UseVisualStyleBackColor = true;
            // 
            // checkBoxBME_gorev
            // 
            this.checkBoxBME_gorev.AutoSize = true;
            this.checkBoxBME_gorev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxBME_gorev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxBME_gorev.Location = new System.Drawing.Point(487, 7);
            this.checkBoxBME_gorev.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxBME_gorev.Name = "checkBoxBME_gorev";
            this.checkBoxBME_gorev.Size = new System.Drawing.Size(58, 20);
            this.checkBoxBME_gorev.TabIndex = 34;
            this.checkBoxBME_gorev.Text = "BME";
            this.checkBoxBME_gorev.UseVisualStyleBackColor = true;
            // 
            // checkBoxGps_gorev
            // 
            this.checkBoxGps_gorev.AutoSize = true;
            this.checkBoxGps_gorev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxGps_gorev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxGps_gorev.Location = new System.Drawing.Point(403, 7);
            this.checkBoxGps_gorev.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxGps_gorev.Name = "checkBoxGps_gorev";
            this.checkBoxGps_gorev.Size = new System.Drawing.Size(60, 20);
            this.checkBoxGps_gorev.TabIndex = 33;
            this.checkBoxGps_gorev.Text = "GPS ";
            this.checkBoxGps_gorev.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(47, 80);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(494, 583);
            this.flowLayoutPanel3.TabIndex = 25;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.label15);
            this.flowLayoutPanel4.Controls.Add(this.label23);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(223, 283);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 48);
            this.label5.TabIndex = 18;
            this.label5.Text = "Paket Numarası";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 54);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sıcaklık (°C)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(6, 107);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 58);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nem (g/m³)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(5, 165);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(211, 57);
            this.label23.TabIndex = 19;
            this.label23.Text = "Basınç (HPA)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.textBoxPaketNum_GorevYuku);
            this.flowLayoutPanel2.Controls.Add(this.textBoxSicaklik_GorevYuku);
            this.flowLayoutPanel2.Controls.Add(this.textBoxNem_GorevYuku);
            this.flowLayoutPanel2.Controls.Add(this.textBoxBasinc_GorevYuku);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(238, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(228, 283);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // textBoxPaketNum_GorevYuku
            // 
            this.textBoxPaketNum_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxPaketNum_GorevYuku.Location = new System.Drawing.Point(5, 5);
            this.textBoxPaketNum_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPaketNum_GorevYuku.Name = "textBoxPaketNum_GorevYuku";
            this.textBoxPaketNum_GorevYuku.Size = new System.Drawing.Size(199, 45);
            this.textBoxPaketNum_GorevYuku.TabIndex = 14;
            this.textBoxPaketNum_GorevYuku.Text = "0";
            // 
            // textBoxSicaklik_GorevYuku
            // 
            this.textBoxSicaklik_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxSicaklik_GorevYuku.Location = new System.Drawing.Point(5, 60);
            this.textBoxSicaklik_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSicaklik_GorevYuku.Name = "textBoxSicaklik_GorevYuku";
            this.textBoxSicaklik_GorevYuku.Size = new System.Drawing.Size(199, 45);
            this.textBoxSicaklik_GorevYuku.TabIndex = 15;
            this.textBoxSicaklik_GorevYuku.Text = "0";
            // 
            // textBoxNem_GorevYuku
            // 
            this.textBoxNem_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxNem_GorevYuku.Location = new System.Drawing.Point(5, 115);
            this.textBoxNem_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNem_GorevYuku.Name = "textBoxNem_GorevYuku";
            this.textBoxNem_GorevYuku.Size = new System.Drawing.Size(199, 45);
            this.textBoxNem_GorevYuku.TabIndex = 16;
            this.textBoxNem_GorevYuku.Text = "0";
            // 
            // textBoxBasinc_GorevYuku
            // 
            this.textBoxBasinc_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxBasinc_GorevYuku.Location = new System.Drawing.Point(5, 170);
            this.textBoxBasinc_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxBasinc_GorevYuku.Name = "textBoxBasinc_GorevYuku";
            this.textBoxBasinc_GorevYuku.Size = new System.Drawing.Size(199, 45);
            this.textBoxBasinc_GorevYuku.TabIndex = 17;
            this.textBoxBasinc_GorevYuku.Text = "0";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.Controls.Add(this.label30);
            this.flowLayoutPanel7.Controls.Add(this.textBoxGPSIrtifa_GorevYuku);
            this.flowLayoutPanel7.Controls.Add(this.label16);
            this.flowLayoutPanel7.Controls.Add(this.textBoxGPSEnlem_GorevYuku);
            this.flowLayoutPanel7.Controls.Add(this.label17);
            this.flowLayoutPanel7.Controls.Add(this.textBoxGPSBoylam_GorevYuku);
            this.flowLayoutPanel7.Controls.Add(this.label32);
            this.flowLayoutPanel7.Controls.Add(this.textBoxGPSSatNum_GorevYuku);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(5, 298);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(461, 274);
            this.flowLayoutPanel7.TabIndex = 26;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(5, 5);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(217, 66);
            this.label30.TabIndex = 24;
            this.label30.Text = "GPS İrtifa";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGPSIrtifa_GorevYuku
            // 
            this.textBoxGPSIrtifa_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxGPSIrtifa_GorevYuku.Location = new System.Drawing.Point(232, 5);
            this.textBoxGPSIrtifa_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGPSIrtifa_GorevYuku.Name = "textBoxGPSIrtifa_GorevYuku";
            this.textBoxGPSIrtifa_GorevYuku.Size = new System.Drawing.Size(209, 45);
            this.textBoxGPSIrtifa_GorevYuku.TabIndex = 23;
            this.textBoxGPSIrtifa_GorevYuku.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(5, 71);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 66);
            this.label16.TabIndex = 20;
            this.label16.Text = "GPS Enlem";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGPSEnlem_GorevYuku
            // 
            this.textBoxGPSEnlem_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxGPSEnlem_GorevYuku.Location = new System.Drawing.Point(232, 76);
            this.textBoxGPSEnlem_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGPSEnlem_GorevYuku.Name = "textBoxGPSEnlem_GorevYuku";
            this.textBoxGPSEnlem_GorevYuku.Size = new System.Drawing.Size(209, 45);
            this.textBoxGPSEnlem_GorevYuku.TabIndex = 19;
            this.textBoxGPSEnlem_GorevYuku.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(5, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 66);
            this.label17.TabIndex = 22;
            this.label17.Text = "GPS Boylam";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGPSBoylam_GorevYuku
            // 
            this.textBoxGPSBoylam_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxGPSBoylam_GorevYuku.Location = new System.Drawing.Point(232, 142);
            this.textBoxGPSBoylam_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGPSBoylam_GorevYuku.Name = "textBoxGPSBoylam_GorevYuku";
            this.textBoxGPSBoylam_GorevYuku.Size = new System.Drawing.Size(209, 45);
            this.textBoxGPSBoylam_GorevYuku.TabIndex = 21;
            this.textBoxGPSBoylam_GorevYuku.Text = "0";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(5, 203);
            this.label32.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(217, 66);
            this.label32.TabIndex = 26;
            this.label32.Text = "GPS Uydu Sayısı";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGPSSatNum_GorevYuku
            // 
            this.textBoxGPSSatNum_GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxGPSSatNum_GorevYuku.Location = new System.Drawing.Point(232, 208);
            this.textBoxGPSSatNum_GorevYuku.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGPSSatNum_GorevYuku.Name = "textBoxGPSSatNum_GorevYuku";
            this.textBoxGPSSatNum_GorevYuku.Size = new System.Drawing.Size(209, 45);
            this.textBoxGPSSatNum_GorevYuku.TabIndex = 25;
            this.textBoxGPSSatNum_GorevYuku.Text = "-1";
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Agency FB", 30F);
            this.label22.ForeColor = System.Drawing.Color.DarkOrange;
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(567, 66);
            this.label22.TabIndex = 16;
            this.label22.Text = "Görev Yükü";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Agency FB", 30F);
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(533, 85);
            this.label14.TabIndex = 16;
            this.label14.Text = "Ana Bilgisayar";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel8.Controls.Add(this.label8);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel8.Controls.Add(this.label9);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(9, 91);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(519, 516);
            this.flowLayoutPanel8.TabIndex = 26;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel11.Controls.Add(this.label7);
            this.flowLayoutPanel11.Controls.Add(this.label20);
            this.flowLayoutPanel11.Controls.Add(this.label27);
            this.flowLayoutPanel11.Controls.Add(this.label28);
            this.flowLayoutPanel11.Controls.Add(this.label21);
            this.flowLayoutPanel11.Controls.Add(this.label24);
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(219, 282);
            this.flowLayoutPanel11.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "Paket Numarası";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(5, 43);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(269, 44);
            this.label20.TabIndex = 19;
            this.label20.Text = "Basınç (HPA)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(6, 87);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(268, 44);
            this.label27.TabIndex = 25;
            this.label27.Text = "Basınç İrtifa";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(7, 131);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(265, 44);
            this.label28.TabIndex = 26;
            this.label28.Text = "GPS İrtifa";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(6, 175);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(267, 39);
            this.label21.TabIndex = 20;
            this.label21.Text = "GPS Enlem";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(7, 214);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(265, 58);
            this.label24.TabIndex = 22;
            this.label24.Text = "GPS Boylam";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel12.Controls.Add(this.textBoxPaketNum_AnaBil);
            this.flowLayoutPanel12.Controls.Add(this.textBoxBasinc_AnaBil);
            this.flowLayoutPanel12.Controls.Add(this.textBoxBasincIrtifa_AnaBil);
            this.flowLayoutPanel12.Controls.Add(this.textBoxGPSIrtifa_AnaBil);
            this.flowLayoutPanel12.Controls.Add(this.textBoxGPSEnlem_AnaBil);
            this.flowLayoutPanel12.Controls.Add(this.textBoxGPSBoylam_AnaBil);
            this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(231, 4);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(193, 282);
            this.flowLayoutPanel12.TabIndex = 8;
            // 
            // textBoxPaketNum_AnaBil
            // 
            this.textBoxPaketNum_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPaketNum_AnaBil.Location = new System.Drawing.Point(4, 4);
            this.textBoxPaketNum_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaketNum_AnaBil.Name = "textBoxPaketNum_AnaBil";
            this.textBoxPaketNum_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxPaketNum_AnaBil.TabIndex = 14;
            this.textBoxPaketNum_AnaBil.Text = "0";
            // 
            // textBoxBasinc_AnaBil
            // 
            this.textBoxBasinc_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxBasinc_AnaBil.Location = new System.Drawing.Point(4, 48);
            this.textBoxBasinc_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasinc_AnaBil.Name = "textBoxBasinc_AnaBil";
            this.textBoxBasinc_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxBasinc_AnaBil.TabIndex = 15;
            this.textBoxBasinc_AnaBil.Text = "0";
            // 
            // textBoxBasincIrtifa_AnaBil
            // 
            this.textBoxBasincIrtifa_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxBasincIrtifa_AnaBil.Location = new System.Drawing.Point(4, 92);
            this.textBoxBasincIrtifa_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasincIrtifa_AnaBil.Name = "textBoxBasincIrtifa_AnaBil";
            this.textBoxBasincIrtifa_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxBasincIrtifa_AnaBil.TabIndex = 24;
            this.textBoxBasincIrtifa_AnaBil.Text = "0";
            // 
            // textBoxGPSIrtifa_AnaBil
            // 
            this.textBoxGPSIrtifa_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxGPSIrtifa_AnaBil.Location = new System.Drawing.Point(4, 136);
            this.textBoxGPSIrtifa_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGPSIrtifa_AnaBil.Name = "textBoxGPSIrtifa_AnaBil";
            this.textBoxGPSIrtifa_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxGPSIrtifa_AnaBil.TabIndex = 23;
            this.textBoxGPSIrtifa_AnaBil.Text = "0";
            // 
            // textBoxGPSEnlem_AnaBil
            // 
            this.textBoxGPSEnlem_AnaBil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGPSEnlem_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxGPSEnlem_AnaBil.Location = new System.Drawing.Point(4, 180);
            this.textBoxGPSEnlem_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGPSEnlem_AnaBil.Name = "textBoxGPSEnlem_AnaBil";
            this.textBoxGPSEnlem_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxGPSEnlem_AnaBil.TabIndex = 16;
            this.textBoxGPSEnlem_AnaBil.Text = "0";
            // 
            // textBoxGPSBoylam_AnaBil
            // 
            this.textBoxGPSBoylam_AnaBil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGPSBoylam_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxGPSBoylam_AnaBil.Location = new System.Drawing.Point(4, 224);
            this.textBoxGPSBoylam_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGPSBoylam_AnaBil.Name = "textBoxGPSBoylam_AnaBil";
            this.textBoxGPSBoylam_AnaBil.Size = new System.Drawing.Size(169, 36);
            this.textBoxGPSBoylam_AnaBil.TabIndex = 17;
            this.textBoxGPSBoylam_AnaBil.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(4, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 45);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jiroskop (dps)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel13.Controls.Add(this.label18);
            this.flowLayoutPanel13.Controls.Add(this.label19);
            this.flowLayoutPanel13.Controls.Add(this.textBoxJiroX_AnaBil);
            this.flowLayoutPanel13.Controls.Add(this.label25);
            this.flowLayoutPanel13.Controls.Add(this.textBoxJiroY_AnaBil);
            this.flowLayoutPanel13.Controls.Add(this.label26);
            this.flowLayoutPanel13.Controls.Add(this.textBoxJiroZ_AnaBil);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(4, 339);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(495, 54);
            this.flowLayoutPanel13.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(4, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(0, 39);
            this.label18.TabIndex = 19;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(12, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 47);
            this.label19.TabIndex = 20;
            this.label19.Text = "X_jiro:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxJiroX_AnaBil
            // 
            this.textBoxJiroX_AnaBil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJiroX_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxJiroX_AnaBil.Location = new System.Drawing.Point(59, 4);
            this.textBoxJiroX_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJiroX_AnaBil.Name = "textBoxJiroX_AnaBil";
            this.textBoxJiroX_AnaBil.Size = new System.Drawing.Size(101, 45);
            this.textBoxJiroX_AnaBil.TabIndex = 21;
            this.textBoxJiroX_AnaBil.Text = "0";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.SystemColors.Control;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(168, 3);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 47);
            this.label25.TabIndex = 22;
            this.label25.Text = "Y_jiro:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxJiroY_AnaBil
            // 
            this.textBoxJiroY_AnaBil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJiroY_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxJiroY_AnaBil.Location = new System.Drawing.Point(215, 4);
            this.textBoxJiroY_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJiroY_AnaBil.Name = "textBoxJiroY_AnaBil";
            this.textBoxJiroY_AnaBil.Size = new System.Drawing.Size(97, 45);
            this.textBoxJiroY_AnaBil.TabIndex = 27;
            this.textBoxJiroY_AnaBil.Text = "0";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(320, 3);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 47);
            this.label26.TabIndex = 24;
            this.label26.Text = "Z_jiro:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxJiroZ_AnaBil
            // 
            this.textBoxJiroZ_AnaBil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJiroZ_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxJiroZ_AnaBil.Location = new System.Drawing.Point(367, 4);
            this.textBoxJiroZ_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJiroZ_AnaBil.Name = "textBoxJiroZ_AnaBil";
            this.textBoxJiroZ_AnaBil.Size = new System.Drawing.Size(112, 45);
            this.textBoxJiroZ_AnaBil.TabIndex = 28;
            this.textBoxJiroZ_AnaBil.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(4, 397);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 45);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ivme (g-force)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.textBoxIvmeX_AnaBil);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.textBoxIvmeY_AnaBil);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.textBoxIvmeZ_AnaBil);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 446);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 54);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(4, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(0, 39);
            this.label10.TabIndex = 19;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(12, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 47);
            this.label11.TabIndex = 20;
            this.label11.Text = "X_jiro:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIvmeX_AnaBil
            // 
            this.textBoxIvmeX_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxIvmeX_AnaBil.Location = new System.Drawing.Point(59, 4);
            this.textBoxIvmeX_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIvmeX_AnaBil.Name = "textBoxIvmeX_AnaBil";
            this.textBoxIvmeX_AnaBil.Size = new System.Drawing.Size(101, 45);
            this.textBoxIvmeX_AnaBil.TabIndex = 21;
            this.textBoxIvmeX_AnaBil.Text = "0";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(168, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 47);
            this.label12.TabIndex = 22;
            this.label12.Text = "Y_jiro:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIvmeY_AnaBil
            // 
            this.textBoxIvmeY_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxIvmeY_AnaBil.Location = new System.Drawing.Point(215, 4);
            this.textBoxIvmeY_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIvmeY_AnaBil.Name = "textBoxIvmeY_AnaBil";
            this.textBoxIvmeY_AnaBil.Size = new System.Drawing.Size(97, 45);
            this.textBoxIvmeY_AnaBil.TabIndex = 27;
            this.textBoxIvmeY_AnaBil.Text = "0";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(320, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 47);
            this.label13.TabIndex = 24;
            this.label13.Text = "Z_jiro:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIvmeZ_AnaBil
            // 
            this.textBoxIvmeZ_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxIvmeZ_AnaBil.Location = new System.Drawing.Point(367, 4);
            this.textBoxIvmeZ_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIvmeZ_AnaBil.Name = "textBoxIvmeZ_AnaBil";
            this.textBoxIvmeZ_AnaBil.Size = new System.Drawing.Size(112, 45);
            this.textBoxIvmeZ_AnaBil.TabIndex = 28;
            this.textBoxIvmeZ_AnaBil.Text = "0";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label29);
            this.flowLayoutPanel6.Controls.Add(this.textBoxAci_AnaBil);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(9, 615);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(235, 126);
            this.flowLayoutPanel6.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Agency FB", 18F);
            this.label29.ForeColor = System.Drawing.Color.Linen;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(4, 4);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(226, 36);
            this.label29.TabIndex = 20;
            this.label29.Text = "Dünya Normaliyle Açısı : ";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAci_AnaBil
            // 
            this.textBoxAci_AnaBil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAci_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxAci_AnaBil.Location = new System.Drawing.Point(4, 44);
            this.textBoxAci_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAci_AnaBil.Name = "textBoxAci_AnaBil";
            this.textBoxAci_AnaBil.Size = new System.Drawing.Size(181, 36);
            this.textBoxAci_AnaBil.TabIndex = 23;
            this.textBoxAci_AnaBil.Text = "0";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.textBoxGPSSatNum_AnaBil);
            this.flowLayoutPanel9.Controls.Add(this.label31);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(267, 620);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(263, 68);
            this.flowLayoutPanel9.TabIndex = 32;
            // 
            // textBoxGPSSatNum_AnaBil
            // 
            this.textBoxGPSSatNum_AnaBil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxGPSSatNum_AnaBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxGPSSatNum_AnaBil.Location = new System.Drawing.Point(196, 4);
            this.textBoxGPSSatNum_AnaBil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGPSSatNum_AnaBil.Name = "textBoxGPSSatNum_AnaBil";
            this.textBoxGPSSatNum_AnaBil.Size = new System.Drawing.Size(63, 36);
            this.textBoxGPSSatNum_AnaBil.TabIndex = 23;
            this.textBoxGPSSatNum_AnaBil.Text = "-1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Agency FB", 18F);
            this.label31.ForeColor = System.Drawing.SystemColors.Control;
            this.label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label31.Location = new System.Drawing.Point(34, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(154, 40);
            this.label31.TabIndex = 24;
            this.label31.Text = "GPS Uydu Sayısı";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxGPS
            // 
            this.checkBoxGPS.AutoSize = true;
            this.checkBoxGPS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxGPS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxGPS.Location = new System.Drawing.Point(15, 6);
            this.checkBoxGPS.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxGPS.Name = "checkBoxGPS";
            this.checkBoxGPS.Size = new System.Drawing.Size(60, 20);
            this.checkBoxGPS.TabIndex = 29;
            this.checkBoxGPS.Text = "GPS ";
            this.checkBoxGPS.UseVisualStyleBackColor = true;
            // 
            // checkBoxbBNO
            // 
            this.checkBoxbBNO.AutoSize = true;
            this.checkBoxbBNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxbBNO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxbBNO.Location = new System.Drawing.Point(15, 32);
            this.checkBoxbBNO.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxbBNO.Name = "checkBoxbBNO";
            this.checkBoxbBNO.Size = new System.Drawing.Size(58, 20);
            this.checkBoxbBNO.TabIndex = 30;
            this.checkBoxbBNO.Text = "BNO";
            this.checkBoxbBNO.UseVisualStyleBackColor = true;
            // 
            // checkBoxBME
            // 
            this.checkBoxBME.AutoSize = true;
            this.checkBoxBME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxBME.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxBME.Location = new System.Drawing.Point(77, 6);
            this.checkBoxBME.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxBME.Name = "checkBoxBME";
            this.checkBoxBME.Size = new System.Drawing.Size(58, 20);
            this.checkBoxBME.TabIndex = 31;
            this.checkBoxBME.Text = "BME";
            this.checkBoxBME.UseVisualStyleBackColor = true;
            // 
            // checkBoxSD
            // 
            this.checkBoxSD.AutoSize = true;
            this.checkBoxSD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxSD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxSD.Location = new System.Drawing.Point(15, 62);
            this.checkBoxSD.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSD.Name = "checkBoxSD";
            this.checkBoxSD.Size = new System.Drawing.Size(74, 20);
            this.checkBoxSD.TabIndex = 32;
            this.checkBoxSD.Text = "SD Kart";
            this.checkBoxSD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(287, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Timer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.checkBoxSD);
            this.panel1.Controls.Add(this.checkBoxBME);
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.flowLayoutPanel9);
            this.panel1.Controls.Add(this.checkBoxbBNO);
            this.panel1.Controls.Add(this.checkBoxGPS);
            this.panel1.Controls.Add(this.flowLayoutPanel8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 1294);
            this.panel1.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gMapMain);
            this.panel6.Location = new System.Drawing.Point(12, 762);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(499, 514);
            this.panel6.TabIndex = 33;
            // 
            // gMapMain
            // 
            this.gMapMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gMapMain.Bearing = 0F;
            this.gMapMain.CanDragMap = true;
            this.gMapMain.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMain.GrayScaleMode = false;
            this.gMapMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMain.LevelsKeepInMemmory = 5;
            this.gMapMain.Location = new System.Drawing.Point(4, 4);
            this.gMapMain.Margin = new System.Windows.Forms.Padding(4);
            this.gMapMain.MarkersEnabled = true;
            this.gMapMain.MaxZoom = 2;
            this.gMapMain.MinZoom = 2;
            this.gMapMain.MouseWheelZoomEnabled = true;
            this.gMapMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMain.Name = "gMapMain";
            this.gMapMain.NegativeMode = false;
            this.gMapMain.PolygonsEnabled = true;
            this.gMapMain.RetryLoadTile = 0;
            this.gMapMain.RoutesEnabled = true;
            this.gMapMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMain.ShowTileGridLines = false;
            this.gMapMain.Size = new System.Drawing.Size(491, 507);
            this.gMapMain.TabIndex = 33;
            this.gMapMain.Zoom = 0D;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.patlama2_yes);
            this.panel3.Controls.Add(this.patlama1_yes);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.patlama2_no);
            this.panel3.Controls.Add(this.patlama1_no);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Location = new System.Drawing.Point(543, 922);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1293, 454);
            this.panel3.TabIndex = 1000;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(936, 74);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(302, 235);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // patlama2_yes
            // 
            this.patlama2_yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patlama2_yes.BackgroundImage")));
            this.patlama2_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patlama2_yes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patlama2_yes.Location = new System.Drawing.Point(309, 314);
            this.patlama2_yes.Margin = new System.Windows.Forms.Padding(4);
            this.patlama2_yes.Name = "patlama2_yes";
            this.patlama2_yes.Size = new System.Drawing.Size(67, 62);
            this.patlama2_yes.TabIndex = 28;
            this.patlama2_yes.TabStop = false;
            // 
            // patlama1_yes
            // 
            this.patlama1_yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patlama1_yes.BackgroundImage")));
            this.patlama1_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patlama1_yes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patlama1_yes.Location = new System.Drawing.Point(312, 112);
            this.patlama1_yes.Margin = new System.Windows.Forms.Padding(4);
            this.patlama1_yes.Name = "patlama1_yes";
            this.patlama1_yes.Size = new System.Drawing.Size(67, 62);
            this.patlama1_yes.TabIndex = 27;
            this.patlama1_yes.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(33, 229);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 190);
            this.panel5.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(33, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 190);
            this.panel4.TabIndex = 24;
            // 
            // patlama2_no
            // 
            this.patlama2_no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patlama2_no.BackgroundImage")));
            this.patlama2_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patlama2_no.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patlama2_no.Location = new System.Drawing.Point(309, 314);
            this.patlama2_no.Margin = new System.Windows.Forms.Padding(4);
            this.patlama2_no.Name = "patlama2_no";
            this.patlama2_no.Size = new System.Drawing.Size(67, 62);
            this.patlama2_no.TabIndex = 23;
            this.patlama2_no.TabStop = false;
            // 
            // patlama1_no
            // 
            this.patlama1_no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patlama1_no.BackgroundImage")));
            this.patlama1_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patlama1_no.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patlama1_no.Location = new System.Drawing.Point(312, 112);
            this.patlama1_no.Margin = new System.Windows.Forms.Padding(4);
            this.patlama1_no.Name = "patlama1_no";
            this.patlama1_no.Size = new System.Drawing.Size(67, 62);
            this.patlama1_no.TabIndex = 22;
            this.patlama1_no.TabStop = false;
            // 
            // chartAltitudeMain
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartAltitudeMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAltitudeMain.Legends.Add(legend1);
            this.chartAltitudeMain.Location = new System.Drawing.Point(552, 185);
            this.chartAltitudeMain.Margin = new System.Windows.Forms.Padding(4);
            this.chartAltitudeMain.Name = "chartAltitudeMain";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerStep = 2;
            series1.Name = "Series1";
            this.chartAltitudeMain.Series.Add(series1);
            this.chartAltitudeMain.Size = new System.Drawing.Size(651, 240);
            this.chartAltitudeMain.TabIndex = 25;
            this.chartAltitudeMain.Text = "chart1";
            // 
            // chartAltitudePayload
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chartAltitudePayload.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAltitudePayload.Legends.Add(legend2);
            this.chartAltitudePayload.Location = new System.Drawing.Point(1189, 174);
            this.chartAltitudePayload.Margin = new System.Windows.Forms.Padding(4);
            this.chartAltitudePayload.Name = "chartAltitudePayload";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAltitudePayload.Series.Add(series2);
            this.chartAltitudePayload.Size = new System.Drawing.Size(647, 240);
            this.chartAltitudePayload.TabIndex = 26;
            this.chartAltitudePayload.Text = "chart2";
            // 
            // chartPressureMain
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chartPressureMain.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPressureMain.Legends.Add(legend3);
            this.chartPressureMain.Location = new System.Drawing.Point(552, 529);
            this.chartPressureMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPressureMain.Name = "chartPressureMain";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPressureMain.Series.Add(series3);
            this.chartPressureMain.Size = new System.Drawing.Size(651, 286);
            this.chartPressureMain.TabIndex = 1001;
            this.chartPressureMain.Text = "chart3";
            // 
            // chartPressurePayload
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chartPressurePayload.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPressurePayload.Legends.Add(legend4);
            this.chartPressurePayload.Location = new System.Drawing.Point(1192, 519);
            this.chartPressurePayload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPressurePayload.Name = "chartPressurePayload";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPressurePayload.Series.Add(series4);
            this.chartPressurePayload.Size = new System.Drawing.Size(645, 294);
            this.chartPressurePayload.TabIndex = 1002;
            this.chartPressurePayload.Text = "chart4";
            // 
            // chartAltitudeMainTitle
            // 
            this.chartAltitudeMainTitle.AutoSize = true;
            this.chartAltitudeMainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chartAltitudeMainTitle.Location = new System.Drawing.Point(665, 100);
            this.chartAltitudeMainTitle.Name = "chartAltitudeMainTitle";
            this.chartAltitudeMainTitle.Size = new System.Drawing.Size(323, 43);
            this.chartAltitudeMainTitle.TabIndex = 1003;
            this.chartAltitudeMainTitle.Text = "İrtifa Ana Bilgisayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1393, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 43);
            this.label4.TabIndex = 1004;
            this.label4.Text = "İrtifa Görev";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(665, 470);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(350, 43);
            this.label35.TabIndex = 1005;
            this.label35.Text = "Basınç Ana Bilgisayar";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(1393, 474);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(224, 43);
            this.label36.TabIndex = 1006;
            this.label36.Text = "Basınç Görev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2415, 1367);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartAltitudeMainTitle);
            this.Controls.Add(this.chartPressurePayload);
            this.Controls.Add(this.chartPressureMain);
            this.Controls.Add(this.chartAltitudePayload);
            this.Controls.Add(this.chartAltitudeMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBaglanti);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).EndInit();
            this.panelBaglanti.ResumeLayout(false);
            this.panelBaglanti.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama2_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama1_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama2_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patlama1_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitudeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitudePayload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressurePayload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button btnBaglantiyiBitir;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBaglanti;
        private System.Windows.Forms.Button btnDosyayaKaydet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHakemIletisim;
        private System.Windows.Forms.Label lblHakemDurum;
        private System.Windows.Forms.Label lblDosyaKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxSD_gorev;
        private System.Windows.Forms.CheckBox checkBoxBME_gorev;
        private System.Windows.Forms.CheckBox checkBoxGps_gorev;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxPaketNum_GorevYuku;
        private System.Windows.Forms.TextBox textBoxSicaklik_GorevYuku;
        private System.Windows.Forms.TextBox textBoxNem_GorevYuku;
        private System.Windows.Forms.TextBox textBoxBasinc_GorevYuku;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxGPSIrtifa_GorevYuku;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxGPSEnlem_GorevYuku;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxGPSBoylam_GorevYuku;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxGPSSatNum_GorevYuku;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox patlama1_no;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox patlama2_no;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.TextBox textBoxPaketNum_AnaBil;
        private System.Windows.Forms.TextBox textBoxBasinc_AnaBil;
        private System.Windows.Forms.TextBox textBoxBasincIrtifa_AnaBil;
        private System.Windows.Forms.TextBox textBoxGPSIrtifa_AnaBil;
        private System.Windows.Forms.TextBox textBoxGPSEnlem_AnaBil;
        private System.Windows.Forms.TextBox textBoxGPSBoylam_AnaBil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxAci_AnaBil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.TextBox textBoxGPSSatNum_AnaBil;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxJiroX_AnaBil;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxJiroY_AnaBil;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxJiroZ_AnaBil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxIvmeX_AnaBil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxIvmeY_AnaBil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIvmeZ_AnaBil;
        private System.Windows.Forms.CheckBox checkBoxGPS;
        private System.Windows.Forms.CheckBox checkBoxbBNO;
        private System.Windows.Forms.CheckBox checkBoxBME;
        private System.Windows.Forms.CheckBox checkBoxSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltitudeMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltitudePayload;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressureMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressurePayload;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox patlama2_yes;
        private System.Windows.Forms.PictureBox patlama1_yes;
        private System.Windows.Forms.Label chartAltitudeMainTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private GMap.NET.WindowsForms.GMapControl gMapMain;
        private GMap.NET.WindowsForms.GMapControl gMapPayload;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

