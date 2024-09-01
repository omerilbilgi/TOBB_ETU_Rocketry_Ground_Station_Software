using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

using System.IO.Ports;
using System.Globalization;
using System.Threading;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace RocketUI
{
    public partial class Form1 : Form
    {
        



        // GÜNCELLENECEK
        public byte paketNumarasıHYI = 0;
        ////////////////////////////////////////  
        public readonly int Takim_ID = 913028;
        public readonly int mapZoomCount = 20; //10-20
        ////////////////////////////////////////    
        static readonly int DATA_COUNT = 24;
        public readonly string filenameRoket = "RoketValues.csv";
        // GÜNCELLENECEK /

        private SerialPort serialPort_YerIst = new SerialPort();
        SerialPort SerialPort_HYI = new SerialPort();

        public static string HYI_Port = "";
        public static int HYI_BaudRate = 19200;
        public static int HYI_DataBits = 8;
        public static int HYI_StopBits = 1;
        public static int HYI_Parity = 0;

        private readonly string dataTitles = "packageNum_Ana,patlama1,patlama2,Irtifa_basinc_Ana,GPSIrtifa_Ana,basinc_Ana,X_jiro,Y_jiro,Z_jiro,X_ivme,Y_ivme,Z_ivme,Aci_Ana,GPSe_Ana,GPSb_Ana,GPSSatNum_ana,packageNum_Gorev,GPSIrtifa_Gorev,sicaklik_Gorev,nem_Gorev,basinc_Gorev,GPSe_Gorev,GPSb_Gorev,GPSSatNum_Gorev";
        private string recivedData = "0,0,0,0,0,0,0,0,0,0,0,0,0,39.9103241,32.8529681,0,0,0,0,0,0,39.9103241,32.8529681,0";
        private string[] values = new string[DATA_COUNT];

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            this.InitializeComponent();
            //InitializeCharts();


            //timer1.Start();
            FetchAvailablePorts();
            values = recivedData.Split(',');
            btnBaglantiyiBitir.Enabled = false;
        }
        // baglantı was done.
        #region BAGLANTI BASLATMA / BITIRME 
        //FetchAvailablePorts  was done.
        private void FetchAvailablePorts()
        {
            numericUpDownBaudRate.Value = 11500;
            comboBoxComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(ports);
            
            if (ports.Length > 0)
            {
                comboBoxComPort.SelectedIndex = comboBoxComPort.Items.Count - 1;
            }
            else
            {
                comboBoxComPort.Text = "Takili Cihaz Yok!";
                lblDurum.ForeColor = Color.Red;
                lblDurum.Text = "Baglanti Yok!";
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) //.
        {
            try
            {
                if (serialPort_YerIst.IsOpen)
                {
                    recivedData = serialPort_YerIst.ReadLine();
                    this.Invoke(new Action(ProcessingData));
                    
                    this.Invoke(new Action(ValueUpdate));
                    
                }
            }
            catch (Exception) { }

        }

        // ProcessingData was done.
        private void ProcessingData() // gelen veri stringi values'e yazıldı
        {
            try { values = recivedData.Split(','); }
            catch (Exception) { for (int i = 0; i < DATA_COUNT; i++) values[i] = "-1"; }
        }

        // btnBaglan_Click  was done.
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            serialPort_YerIst = new SerialPort();

            if (comboBoxComPort.SelectedItem != null)
            {
                serialPort_YerIst.PortName = comboBoxComPort.SelectedItem.ToString();
                btnBaglan.Enabled = false;
                btnBaglantiyiBitir.Enabled = true;
            }
            else
            {
                FetchAvailablePorts();
                MessageBox.Show("COM PORT'u Yeniden Seciniz ");
                btnBaglan.Enabled = true;
                btnBaglantiyiBitir.Enabled = false;
            }

            serialPort_YerIst.BaudRate = (int)numericUpDownBaudRate.Value;
            // Parity, veri iletiminde hataları tespit etmek için kullanılan bir yöntemdir. Parity.None ayarı, parity bitinin kullanılmayacağını belirtir.
            serialPort_YerIst.Parity = Parity.None;
            // DataBits, seri iletişimde her bir karakterin kaç bit ile ifade edileceğini belirler.
            serialPort_YerIst.DataBits = 8;
            // StopBits.One ayarı, her veri bloğunun sonunda bir stop biti kullanılacağını belirtir.
            serialPort_YerIst.StopBits = StopBits.One;
            // ReadBufferSize, seri portun okuma tamponunun (buffer) boyutunu belirler.
            serialPort_YerIst.ReadBufferSize = 200000000;
            //DataReceived olayına bir olay işleyicisi (event handler) atar.
            //Bu, serialPort_YerIst nesnesi üzerinden veri alındığında serialPort_DataReceived metodunun otomatik olarak çağrılmasını sağlar.
            //Bu metod içinde, alınan verinin nasıl işleneceği tanımlanır.
            serialPort_YerIst.DataReceived += serialPort_DataReceived;



            
            try
            {
                serialPort_YerIst.Open();
                Thread.Sleep(1000);
                lblDurum.ForeColor = Color.Green;
                lblDurum.Text = "Baglandi!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured while opening port");
                FetchAvailablePorts();
                btnBaglan.Enabled = true;
                btnBaglantiyiBitir.Enabled = false;
            }
             
        }

        // btnBaglantiyiBitir_Click  was done.
        private void btnBaglantiyiBitir_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort_YerIst.IsOpen)
                {
                    //serialPort_YerIst.DiscardInBuffer();
                    //serialPort_YerIst.DiscardOutBuffer();
                    serialPort_YerIst.ReadTimeout = 500; // 500 ms
                    serialPort_YerIst.WriteTimeout = 500; // 500 ms
                    serialPort_YerIst.Close();
                    lblDurum.Text = "Baglanti Yok!";
                }
                else
                {
                    lblDurum.Text = "Cihaz Baglantisi Koptu!";
                }
                btnBaglan.Enabled = true;
                btnBaglantiyiBitir.Enabled = false;
                lblDurum.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured while closing port");
            }
        }

        Thread HYIDataSendThread = null;
        private void btnHakemIletisim_Click(object sender, EventArgs e) //.
        {
            if (HYIDataSendThread == null)
            {
                using (HYI hyi = new HYI())
                {
                    if (hyi.ShowDialog() == DialogResult.OK)
                    {
                        HYI_Port = hyi.HYI_Port();
                        HYI_BaudRate = hyi.HYI_BaudRate();
                        HYI_DataBits = hyi.HYI_DataBits();
                        HYI_StopBits = hyi.HYI_StopBits();
                        HYI_Parity = hyi.HYI_Parity();
                        HYI_Baglan();
                    }

                }
            }
            else
            {
                if (SerialPort_HYI.IsOpen)
                {
                    SerialPort_HYI.ReadTimeout = 500; // 500 ms
                    SerialPort_HYI.WriteTimeout = 500; // 500 ms
                    SerialPort_HYI.Close();
                    MessageBox.Show("Bağlantı Sonlandırılıyor");
                }
                lblHakemDurum.Text = "Bağlantı Sonlandırıldı!";
                lblHakemDurum.ForeColor = Color.White;
                btnHakemIletisim.Text = "Hakem Yer Istasyonuna Baglan";
                HYIDataSendThread?.Abort();
                HYIDataSendThread = null;
            }
        }

        public void HYI_Baglan() //.
        {
            SerialPort_HYI = new SerialPort();
            if (HYI_Port != null && HYI_Port != "")
            {
                try
                {
                    SerialPort_HYI.PortName = HYI_Port;
                    SerialPort_HYI.BaudRate = HYI_BaudRate;
                    SerialPort_HYI.Parity = (Parity)HYI_Parity;
                    SerialPort_HYI.DataBits = HYI_DataBits;
                    SerialPort_HYI.StopBits = (StopBits)HYI_StopBits;
                    SerialPort_HYI.ReadBufferSize = 200000000;
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Port Secmediniz");
                lblHakemDurum.ForeColor = Color.Red;
                lblHakemDurum.Text = "Baglanti Kurulamadi";
            }

            try
            {
                SerialPort_HYI.Open();
                btnHakemIletisim.Enabled = false;
                Thread.Sleep(1000);
                if (SerialPort_HYI.IsOpen)
                {
                    lblHakemDurum.ForeColor = Color.Green;
                    lblHakemDurum.Text = "Baglandi!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured while opening port");
                FetchAvailablePorts();
                lblHakemDurum.ForeColor = Color.Red;
                lblHakemDurum.Text = "Baglanti Kurulamadi";
            }
        }

        private void SerialPort_HYI_dataSend() //.
        {
            try
            {
                if (HYIDataSendThread == null)
                {
                    HYIDataSendThread = new Thread(() =>
                    {
                        byte[] paketstr = new byte[78];
                        while (SerialPort_HYI.IsOpen)
                        {
                            try
                            {
                                paketstr = PaketOlustur();
                                SerialPort_HYI.Write(paketstr, 0, paketstr.Length);
                                Thread.Sleep(250);

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.StackTrace);
                            }
                        }
                    });
                    HYIDataSendThread.Start();
                    btnHakemIletisim.Text = "Hakem Yer Istasyonu Baglantısını Kes";
                    Thread.Sleep(1000);
                    btnHakemIletisim.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HYI Paket Gonderilemedi. Bağlantı Sonlandırılıyor\n" + ex);
                lblHakemDurum.Text = "Bağlantı Kesildi";
                lblHakemDurum.ForeColor = Color.Red;
                SerialPort_HYI.Close();
                HYIDataSendThread?.Abort();
                HYIDataSendThread = null;
            }

        }
        private void ValueUpdate() //.
        {
            Thread.Sleep(100);

            textBoxPaketNum_AnaBil.Text = GetPinValue(PackageElements.packageNum_Ana);
            textBoxAci_AnaBil.Text = GetPinValue(PackageElements.Aci_Ana);
            textBoxBasincIrtifa_AnaBil.Text = GetPinValue(PackageElements.Irtifa_basinc_Ana);
            textBoxGPSIrtifa_AnaBil.Text = GetPinValue(PackageElements.GPSIrtifa_Ana);

            textBoxBasinc_AnaBil.Text = GetPinValue(PackageElements.basinc_Ana);
            textBoxGPSEnlem_AnaBil.Text = GetPinValue(PackageElements.GPSe_Ana);
            textBoxGPSBoylam_AnaBil.Text = GetPinValue(PackageElements.GPSb_Ana);
            textBoxJiroX_AnaBil.Text = GetPinValue(PackageElements.X_jiro);
            textBoxJiroY_AnaBil.Text = GetPinValue(PackageElements.Y_jiro);
            textBoxJiroZ_AnaBil.Text = GetPinValue(PackageElements.Z_jiro);
            textBoxIvmeX_AnaBil.Text = GetPinValue(PackageElements.X_ivme);
            textBoxIvmeY_AnaBil.Text = GetPinValue(PackageElements.Y_ivme);
            textBoxIvmeZ_AnaBil.Text = GetPinValue(PackageElements.Z_ivme);
            textBoxGPSSatNum_AnaBil.Text = GetPinValue(PackageElements.GPSSatNum_ana);

            textBoxPaketNum_GorevYuku.Text = GetPinValue(PackageElements.packageNum_Gorev);
            textBoxSicaklik_GorevYuku.Text = GetPinValue(PackageElements.sicaklik_Gorev);
            textBoxNem_GorevYuku.Text = GetPinValue(PackageElements.nem_Gorev);
            textBoxBasinc_GorevYuku.Text = GetPinValue(PackageElements.basinc_Gorev);
            textBoxGPSEnlem_GorevYuku.Text = GetPinValue(PackageElements.GPSe_Gorev);
            textBoxGPSBoylam_GorevYuku.Text = GetPinValue(PackageElements.GPSb_Gorev);
            textBoxGPSIrtifa_GorevYuku.Text = GetPinValue(PackageElements.GPSIrtifa_Gorev);
            textBoxGPSSatNum_GorevYuku.Text = GetPinValue(PackageElements.GPSSatNum_Gorev);

            UpdateChart(chartAltitudeMain, GetPinValueFloat(PackageElements.GPSIrtifa_Ana));
            UpdateChart(chartAltitudePayload, GetPinValueFloat(PackageElements.GPSIrtifa_Gorev));
            UpdateChart(chartPressureMain, GetPinValueFloat(PackageElements.basinc_Ana));
            UpdateChart(chartPressurePayload, GetPinValueFloat(PackageElements.basinc_Gorev));
            SetStatus();

            switch (PatlamaToByte())
            {
                case 0:
                    patlama1_no.Visible = true;
                    patlama1_yes.Visible = false;
                    patlama2_no.Visible = true;
                    patlama2_yes.Visible = false;
                    break;
                case 1:
                    patlama1_no.Visible = true;
                    patlama1_yes.Visible = false;
                    patlama2_no.Visible = false;
                    patlama2_yes.Visible = true;
                    break;
                case 2:
                    patlama1_no.Visible = false;
                    patlama1_yes.Visible = true;
                    patlama2_no.Visible = true;
                    patlama2_yes.Visible = false;
                    timer1.Start();
                    break;
                case 3:
                    patlama1_no.Visible = false;
                    patlama1_yes.Visible = true;
                    patlama2_no.Visible = false;
                    patlama2_yes.Visible = true;
                    break;
            }

            if (SerialPort_HYI.IsOpen)
                SerialPort_HYI_dataSend();


            /*
             HYI kısmı eklenecek 
             refreshMap kısmı eklenecek
             */


            try
            {
                RefreshMapToNewGPS();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error While Refreshing GPS"); }
        }


        #endregion
        


        // ekrandaki timer metodu
        // timer1_Tick was done.
        private int secondsPassed = 0;
        private int minutePassed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsPassed++;
            if (secondsPassed == 60) {
                secondsPassed = 0;
                minutePassed++;
            }
            label3.Text = $"Geçen Süre: {minutePassed} : {secondsPassed} ";
        }

        enum PackageElements
        {
            packageNum_Ana,
            statusAna,
            Irtifa_basinc_Ana,
            GPSIrtifa_Ana,
            basinc_Ana,
            X_jiro,
            Y_jiro,
            Z_jiro,
            X_ivme,
            Y_ivme,
            Z_ivme,
            Aci_Ana,
            GPSe_Ana,
            GPSb_Ana,
            GPSSatNum_ana,
            statusGorev,
            packageNum_Gorev,
            GPSIrtifa_Gorev,
            sicaklik_Gorev,
            nem_Gorev,
            basinc_Gorev,
            GPSe_Gorev,
            GPSb_Gorev,
            GPSSatNum_Gorev
        }

        #region EK FONKSIYONLAR
        private string GetPinValue(PackageElements pe) //.
        {
            return values[(int)pe];
        }

        private float GetPinValueFloat(PackageElements pe) //.
        {
            return float.Parse(GetPinValue(pe).IndexOf(".") >= 0 ? GetPinValue(pe).Replace(".", ",") : GetPinValue(pe));
        }

        private Double GetPinValueDouble(PackageElements pe) //.
        {
            try { return Double.Parse(GetPinValue(pe)); }
            catch { return Double.NaN; }
        }

        private byte PatlamaToByte() //.
        {
            if (!GetBit(0, (byte)GetPinValueFloat(PackageElements.statusAna)) && !GetBit(1, (byte)GetPinValueFloat(PackageElements.statusAna))) return 0x00;
            else if (!GetBit(0, (byte)GetPinValueFloat(PackageElements.statusAna)) && GetBit(1, (byte)GetPinValueFloat(PackageElements.statusAna))) return 0x01;
            else if (GetBit(0, (byte)GetPinValueFloat(PackageElements.statusAna)) && !GetBit(1, (byte)GetPinValueFloat(PackageElements.statusAna))) return 0x02;
            else if (GetBit(0, (byte)GetPinValueFloat(PackageElements.statusAna)) && GetBit(1, (byte)GetPinValueFloat(PackageElements.statusAna))) return 0x03;
            else return 0x00;
        }

        private void UpdateChart(Chart chart1, double value) //.
        {
            // Yeni veri noktasını ekle
            chart1.Series[0].Points.AddY(value);

            // Veri noktalarının sayısını sınırla
            if (chart1.Series[0].Points.Count > 100)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }

            // Grafik kontrolünü yeniden çiz
            chart1.Invalidate();
        }

        void SetStatus() //.
        {
            checkBoxGPS.Checked = GetBit(2, (byte)GetPinValueFloat(PackageElements.statusAna)) || GetBit(6, (byte)GetPinValueFloat(PackageElements.statusAna)) || GetBit(7, (byte)GetPinValueFloat(PackageElements.statusAna));
            checkBoxBME.Checked = GetBit(3, (byte)GetPinValueFloat(PackageElements.statusAna));
            checkBoxbBNO.Checked = GetBit(4, (byte)GetPinValueFloat(PackageElements.statusAna));
            checkBoxSD.Checked = GetBit(5, (byte)GetPinValueFloat(PackageElements.statusAna));

            checkBoxGps_gorev.Checked = GetBit(2, (byte)GetPinValueFloat(PackageElements.statusGorev)) || GetBit(6, (byte)GetPinValueFloat(PackageElements.statusGorev)) || GetBit(7, (byte)GetPinValueFloat(PackageElements.statusGorev));
            checkBoxBME_gorev.Checked = GetBit(3, (byte)GetPinValueFloat(PackageElements.statusGorev));
            checkBoxSD_gorev.Checked = GetBit(5, (byte)GetPinValueFloat(PackageElements.statusGorev));
            
        }

        private void RefreshMapToNewGPS() //.
        {
            UpdateMap(gMapMain, (double)GetPinValueDouble(PackageElements.GPSe_Ana), (double)GetPinValueDouble(PackageElements.GPSb_Ana));
            gMapMain.ShowCenter = true;
            UpdateMap(gMapPayload, (double)GetPinValueDouble(PackageElements.GPSe_Gorev), (double)GetPinValueDouble(PackageElements.GPSb_Gorev));
            gMapPayload.ShowCenter = true;
        }

        List<PointLatLng> points_ana = new List<PointLatLng>();
        List<PointLatLng> points_gorev = new List<PointLatLng>();

        PointLatLng previousPoint_ana;
        PointLatLng previousPoint_gorev;

        private void UpdateMap(GMapControl gMapControl, double latitude, double longitude) //.
        {
            if (latitude != 0 && longitude != 0)
            {
                PointLatLng point = new PointLatLng(latitude, longitude);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                gMapControl.Overlays.Clear();
                GMapOverlay overlay = new GMapOverlay("markers");
                overlay.Markers.Add(marker);
                gMapControl.Overlays.Add(overlay);
                gMapControl.Position = point;


                if (gMapControl == gMapMain)
                {
                    if (previousPoint_ana != null)
                    {
                        points_ana.Add(previousPoint_ana);
                        points_ana.Add(point);
                        GMapRoute route = new GMapRoute(points_ana, "route");
                        overlay.Routes.Add(route);
                    }
                    previousPoint_ana = point;
                }
                else if (gMapControl == gMapPayload)
                {
                    if (previousPoint_gorev != null)
                    {
                        points_gorev.Add(previousPoint_gorev);
                        points_gorev.Add(point);
                        GMapRoute route = new GMapRoute(points_gorev, "route");
                        overlay.Routes.Add(route);
                    }
                    previousPoint_gorev = point;
                }
            }
        }


        public bool GetBit(byte bitNumber, byte b) => (b & (1 << bitNumber)) != 0; //.

        private void SetChartAtBegin(Chart chart1, String AxisY)
        {

          //  chart1.Series[0].BorderWidth = 2;

         //   chart1.Series[0].MarkerStyle = MarkerStyle.Square;
          //  chart1.Series[0].MarkerColor = Color.Green;

            chart1.ChartAreas[0].AxisX.Title = "Zaman";
            chart1.ChartAreas[0].AxisY.Title = AxisY;
           // chart1.Series[0].ChartType = SeriesChartType.Line;
        }
        #endregion

        Thread FileSaveThread = null;
        #region EVENTS

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //.
        {
            try
            {
                if (serialPort_YerIst.IsOpen)
                {
                    MessageBox.Show("Yer Istasyonu COM PORT baglantisini kapatmadiniz! Otomatik sonlandiriliyor...");
                    serialPort_YerIst.ReadTimeout = 500; // 500 ms
                    serialPort_YerIst.WriteTimeout = 500; // 500 ms
                    serialPort_YerIst.Close();
                }
                if (SerialPort_HYI.IsOpen)
                {
                    MessageBox.Show("Hakem Istasyonu COM PORT baglantisini kapatmadiniz! Otomatik sonlandiriliyor...");
                    SerialPort_HYI.ReadTimeout = 500; // 500 ms
                    SerialPort_HYI.WriteTimeout = 500; // 500 ms
                    SerialPort_HYI.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
            FileSaveThread?.Abort();
            HYIDataSendThread?.Abort();
        }

        private void Form1_Load(object sender, EventArgs e) //.
        {
            // Main
            // GMapControl ayarları
            gMapMain.MapProvider = GMapProviders.GoogleMap;
            gMapMain.Position = new PointLatLng(GetPinValueDouble(PackageElements.GPSe_Ana), GetPinValueDouble(PackageElements.GPSb_Ana));
            gMapMain.MinZoom = 1;
            gMapMain.MaxZoom = 100;
            gMapMain.Zoom = 20;
            gMapMain.Dock = DockStyle.Fill; // Haritayı formun tamamına yay
            gMapMain.DragButton = MouseButtons.Left;
            gMapMain.MouseWheelZoomEnabled = true;

            // İşaret ekleme örneği
            var markers_main = new GMapOverlay("markers");
            var marker_main = new GMarkerGoogle(new PointLatLng(39.9103241f, 32.8529681f), GMarkerGoogleType.red_dot);
            markers_main.Markers.Add(marker_main);
            gMapMain.Overlays.Add(markers_main);


            // Payload
            // GMapControl ayarları
            gMapPayload.MapProvider = GMapProviders.GoogleMap;
            gMapPayload.Position = new PointLatLng(GetPinValueDouble(PackageElements.GPSe_Ana), GetPinValueDouble(PackageElements.GPSb_Ana));
            gMapPayload.MinZoom = 1;
            gMapPayload.MaxZoom = 100;
            gMapPayload.Zoom = 20;
            gMapPayload.Dock = DockStyle.Fill; // Haritayı formun tamamına yay
            gMapPayload.DragButton = MouseButtons.Left;
            gMapPayload.MouseWheelZoomEnabled = true;

            // İşaret ekleme örneği
            var markers_payload = new GMapOverlay("markers");
            var marker_payload = new GMarkerGoogle(new PointLatLng(39.9103241f, 32.8529681f), GMarkerGoogleType.red_dot);
            markers_payload.Markers.Add(marker_payload);
            gMapMain.Overlays.Add(markers_payload);


            patlama1_no.Visible = true;
            patlama1_yes.Visible = false;
            patlama2_no.Visible = true;
            patlama2_yes.Visible = false;

            SetChartAtBegin(chartPressureMain, "Basınç");
            SetChartAtBegin(chartPressurePayload, "Basınç");
            SetChartAtBegin(chartAltitudeMain, "GPS İrtifa");
            SetChartAtBegin(chartAltitudePayload, "GPS İrtifa");
        }

        private void btnRefresh_Click(object sender, EventArgs e) //.
        {
            FetchAvailablePorts();

            gMapMain.Position = new PointLatLng(39.9103241f, 32.8529681f);
            gMapMain.Zoom = 20;
            gMapPayload.Position = new PointLatLng(39.9103241f, 32.8529681f);
            gMapPayload.Zoom = 20;

            patlama1_no.Visible = true;
            patlama1_yes.Visible = false;
            patlama2_no.Visible = true;
            patlama2_yes.Visible = false;
        }

        private void btnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            if (FileSaveThread == null)
            {
                lblDosyaKayit.Text = "Kayit Ediliyor!";
                FileSaveThread = new Thread(() =>
                {
                    while (true)
                    {
                        if (!File.Exists(filenameRoket))
                        {
                            File.WriteAllText(filenameRoket, dataTitles + "\n" + recivedData + "\n");
                        }
                        else
                        {
                            File.AppendAllText(filenameRoket, recivedData + "\n");
                        }
                        Thread.Sleep(100);
                    }
                }
                );
                FileSaveThread.Start();
                lblDosyaKayit.Text = "Kayit Ediliyor!";
                btnDosyayaKaydet.Text = "Kaydi Bitir";
            }
            else
            {
                FileSaveThread.Abort();
                FileSaveThread = null;
                lblDosyaKayit.Text = "Kayit Edilmiyor!";
                btnDosyayaKaydet.Text = "Dosyaya Kaydetmeye Basla";
            }
        }

        #endregion

        // HYI
        #region 78 BIT DONUSTURUCU

        public byte CheckSumHesapla(byte[] o)
        {
            byte checkSum = 0;
            for (int i = 4; i < 75; i++)
            {
                checkSum += o[i];
            }
            return checkSum;
        }

        byte[] byteArray = new byte[4];
        public byte[] PaketOlustur()
        {
            byte[] olusturalacak_paket = new byte[78];
            olusturalacak_paket[0] = 0xFF; // Sabit
            olusturalacak_paket[1] = 0xFF; // Sabit
            olusturalacak_paket[2] = 0x54; // Sabit
            olusturalacak_paket[3] = 0x52; // Sabit
            olusturalacak_paket[4] = (byte)Takim_ID; // Takim ID =
            olusturalacak_paket[5] = paketNumarasıHYI; // Sayac degeri = 0; 

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Irtifa_basinc_Ana));
            olusturalacak_paket[6] = byteArray[0];
            olusturalacak_paket[7] = byteArray[1];
            olusturalacak_paket[8] = byteArray[2];
            olusturalacak_paket[9] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSIrtifa_Ana));
            olusturalacak_paket[10] = byteArray[0];
            olusturalacak_paket[11] = byteArray[1];
            olusturalacak_paket[12] = byteArray[2];
            olusturalacak_paket[13] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSe_Ana));
            olusturalacak_paket[14] = byteArray[0];
            olusturalacak_paket[15] = byteArray[1];
            olusturalacak_paket[16] = byteArray[2];
            olusturalacak_paket[17] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSb_Ana));
            olusturalacak_paket[18] = byteArray[0];
            olusturalacak_paket[19] = byteArray[1];
            olusturalacak_paket[20] = byteArray[2];
            olusturalacak_paket[21] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSIrtifa_Gorev));
            olusturalacak_paket[22] = byteArray[0];
            olusturalacak_paket[23] = byteArray[1];
            olusturalacak_paket[24] = byteArray[2];
            olusturalacak_paket[25] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSe_Gorev));
            olusturalacak_paket[26] = byteArray[0];
            olusturalacak_paket[27] = byteArray[1];
            olusturalacak_paket[28] = byteArray[2];
            olusturalacak_paket[29] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.GPSb_Gorev));
            olusturalacak_paket[30] = byteArray[0];
            olusturalacak_paket[31] = byteArray[1];
            olusturalacak_paket[32] = byteArray[2];
            olusturalacak_paket[33] = byteArray[3];

            olusturalacak_paket[34] = 0x00;
            olusturalacak_paket[35] = 0x00;
            olusturalacak_paket[36] = 0x00;
            olusturalacak_paket[37] = 0x00;
            olusturalacak_paket[38] = 0x00;
            olusturalacak_paket[39] = 0x00;
            olusturalacak_paket[40] = 0x00;
            olusturalacak_paket[41] = 0x00;
            olusturalacak_paket[42] = 0x00;
            olusturalacak_paket[43] = 0x00;
            olusturalacak_paket[44] = 0x00;
            olusturalacak_paket[45] = 0x00;

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.X_jiro));
            olusturalacak_paket[46] = byteArray[0];
            olusturalacak_paket[47] = byteArray[1];
            olusturalacak_paket[48] = byteArray[2];
            olusturalacak_paket[49] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Y_jiro));
            olusturalacak_paket[50] = byteArray[0];
            olusturalacak_paket[51] = byteArray[1];
            olusturalacak_paket[52] = byteArray[2];
            olusturalacak_paket[53] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Z_jiro));
            olusturalacak_paket[54] = byteArray[0];
            olusturalacak_paket[55] = byteArray[1];
            olusturalacak_paket[56] = byteArray[2];
            olusturalacak_paket[57] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.X_ivme));
            olusturalacak_paket[58] = byteArray[0];
            olusturalacak_paket[59] = byteArray[1];
            olusturalacak_paket[60] = byteArray[2];
            olusturalacak_paket[61] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Y_ivme));
            olusturalacak_paket[62] = byteArray[0];
            olusturalacak_paket[63] = byteArray[1];
            olusturalacak_paket[64] = byteArray[2];
            olusturalacak_paket[65] = byteArray[3];


            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Z_ivme));
            olusturalacak_paket[66] = byteArray[0];
            olusturalacak_paket[67] = byteArray[1];
            olusturalacak_paket[68] = byteArray[2];
            olusturalacak_paket[69] = byteArray[3];

            byteArray = GetBytesFromFloat(GetPinValueFloat(PackageElements.Aci_Ana));
            olusturalacak_paket[70] = byteArray[0];
            olusturalacak_paket[71] = byteArray[1];
            olusturalacak_paket[72] = byteArray[2];
            olusturalacak_paket[73] = byteArray[3];

          //  olusturalacak_paket[74] = PatlamaToByte();  // henüz eklenmedi
            olusturalacak_paket[75] = CheckSumHesapla(olusturalacak_paket);
            olusturalacak_paket[76] = 0x0D; // Sabit
            olusturalacak_paket[77] = 0x0A; // Sabit

            paketNumarasıHYI++;
            for (int i = 0; i < 78; i++)
            {
                olusturalacak_paket[i] = Convert.ToByte(string.Format("0x{0:X2}", olusturalacak_paket[i]), 16);
            }
            return olusturalacak_paket;
        }
        public static byte[] GetBytesFromFloat(float value)
        {
            byte[] bytes = new byte[4];
            int intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
            bytes[0] = (byte)(intValue & 0xff);
            bytes[1] = (byte)((intValue >> 8) & 0xff);
            bytes[2] = (byte)((intValue >> 16) & 0xff);
            bytes[3] = (byte)((intValue >> 24) & 0xff);
            return bytes;
        }
        #endregion

        
    }
}


/*  private void InitializeCharts()
        {
            SetupChart(chartAltitudeMain, "Ana İrtifa");
            SetupChart(chartAltitudePayload, "Görev Yükü İrtifa");
            SetupChart(chartPressureMain, "Ana Basınç");
            SetupChart(chartPressurePayload, "Görev Yükü Basınç");

            Timer timer = new Timer();
            timer.Interval = 1000; // Her 1 saniyede bir veri eklemek için
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void SetupChart(CartesianChart chart, string title)
        {
            chart.AxisX.Add(new Axis
            {
                Title = "Zaman",
                LabelFormatter = value => new DateTime((long)value).ToString("mm:ss")
            });

            chart.AxisY.Add(new Axis
            {
                Title = title,
                LabelFormatter = value => value.ToString("N")
            });

            chart.Series = new SeriesCollection
        {
            new LineSeries
            {
                Title = title,
                Values = new ChartValues<double> { }
            }
        };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AddDataPoint(chartAltitudeMain.Series[0].Values);
            AddDataPoint(chartAltitudePayload.Series[0].Values);
            AddDataPoint(chartPressureMain.Series[0].Values);
            AddDataPoint(chartPressurePayload.Series[0].Values);
        }

        private void AddDataPoint(IChartValues values)
        {
            if (values.Count > 20) // Sadece son 20 veriyi tutmak için
            {
                values.RemoveAt(0);
            }

            values.Add(random.Next(0, 100)); // Rastgele veri eklemek için
        }*/