using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Printing;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using TonyFunctions;
using System.Net;

namespace _8082_Waymo_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Properties.Settings.Default.Save();
            Connect_Prev_I28();
            //Find_Comports();
            //Connect_Ready_Port();
            //Connect_Zebra_Port();
            //Connect_DebBug();
            System.IO.Directory.CreateDirectory("c:\\BTD\\Waymo");
            this.WindowState = FormWindowState.Maximized;
            txtScan.Focus();
            Settings_On_Startup();

            tsEnableFlexFlow.Click += TsEnableFlexFlow_Click;
        }



        #region Define Variables
        bool blnConnectedToI28 = false;
        bool blnReadyMatched = false;//indicates that previous com was in list
        bool blnFix_1_Enabled = false;//used to confirm channel start is unassigned
        bool blnFix_2_Enabled = false;
        bool blnFix_1_Scanned = false;//used to toggle fixture scan
        bool blnFix_2_Scanned = false;//used to toggle fixture scan
        bool blnSerNumScanned = false;//used for first run thru
        bool blnGather_Param = false;//trying to get consistant read
        bool blnGather_Result = false;
        bool blnTesting = false; //determines when to ignore file also when I28 is running
        bool blnTesting_Fix_1 = false;//fixure one in use
        bool blnTesting_Fix_2 = false;//fixure two in use
        bool blnParamStart = false;//used to extract params
        bool blnSendParam = false;//allows weeding
        bool blnFixInfoComplete = false;//helps with first run thru
        bool blnTestScan;//used to test scanner serial data recieved
        bool blnHR = false;//used to determine correct serial # /  Fixture
        bool blnSV = false;//used to determine correct serial # /  Fixture
        bool blnChamberTest = false;//avoids data collection in serialport
        bool blnChamActive = false;//used to know when to parse string.
        // Properties.Settings.Default.EnableFlexFlow //used for when their network is down
        string strScanned_Serial_Num;//scanned camera serial number
        string strActiveSerial_Num;//Active Serial Under Test and Displayed on Status Box
        string strTestString;
        string strConnectInfo;
        string strFolderPath = "c:\\BTD\\DMD-III Seq\\";
        string strFile_with_Path = Properties.Settings.Default.Default_File;//file to write data to
        string strFileToRead;
        string strReadyCom = Properties.Settings.Default.ReadyCom;//last used ready signal com port
        string strI28_Com = Properties.Settings.Default.I28;//last used I28 Com
        string strZebra_Com = Properties.Settings.Default.Zebra;//last used scanner com
        string strDebugPort = Properties.Settings.Default.DebugPort;//used by me
        string strFromScannerCom;//read into serial port
        string strOperator = "Unknown";//operator name
        string strFix_1_Prog = Properties.Settings.Default.Fix_1_Prog;
        string strFix_2_Prog = Properties.Settings.Default.Fix_2_Prog;
        string strHR_Check = Properties.Settings.Default.HR_ID;//used to determine correct serial # /  Fixture
        string strSV_Check = Properties.Settings.Default.SV_ID;//used to determine correct serial # /  Fixture

        DateTime dtActiveTestStartTime;
        DateTime dtActiveTestEndTime;
        ArrayList CurrentConfig = new ArrayList();
        List<string> Prog_Config = new List<string>();
        #region Constants
        //variables for common messages
        string Ci = "IN TEST";
        string Cp = "TEST PASSED";
        string Cf = "TEST FAILED";
        string Cr = "FIXTURE READY";
        string Cn = "NOT READY";
        string Cs = "SCANNED";
        string Csb = "Stop Pushed";//error message sentinel 
        string Cpl = "Press Low";//error message sentinel 
        string Cph = "Press High";//error message sentinel 
        string Csl = "Severe Leak";//error message sentinel 
        #endregion


        #endregion

        #region Methods

        public void Connect_Prev_I28()
        {
            serialPort1.Close();
            try
            {

                serialPort1.BaudRate = 115200;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = strI28_Com;
                serialPort1.NewLine = "\r\n";
                serialPort1.ReadTimeout = 1000;
                serialPort1.Dispose();

                serialPort1.Open();
                bool blnOpen = serialPort1.IsOpen;
                serialPort1.DiscardOutBuffer();

                serialPort1.WriteLine("Exit");
                serialPort1.WriteLine("I\\M\\Instrument Name");


                try
                {
                    strTestString = serialPort1.ReadLine();
                }
                catch (TimeoutException e)
                {
                    LogText("exception:" + e.Message);
                    //MessageBox.Show("Communication Problem Connecting", "Error");

                    serialPort1.Close();

                }


                if (strTestString.Contains("I28"))
                {

                    blnConnectedToI28 = true;
                    serialPort1.NewLine = "\r\n";

                    //lstRead.Items.Add(strTemp);

                    string[] strSPlit = TonyFunctions.T_Func.saSplit(strTestString, '=');
                    String strTrimmed = strSPlit[1].Substring(0, 8);



                    strConnectInfo = ("Connected to: " + strTrimmed + " Using " + strI28_Com);
                    label1.Text = (strConnectInfo);
                    serialPort1.WriteLine("SERVICE\\B\\SET DEFAULT CUS. RES HDRS=YES");
                    //String strTemp = serialPort1.ReadLine();


                    serialPort1.ReadTimeout = 1000;
                    serialPort1.WriteLine("Exit");
                    DisableProgram_1();
                    DisableProgram_2();
                    AutoSetComports();



                }
                else
                {
                    Find_Comports();
                }



            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);
                Find_Comports(); 
                //MessageBox.Show("Verify Com Settings for Scanner and Ready Signal", "NO CONNECTION");
            }

            //AutoSetComports();

        }
        public void Find_Comports()
        {
            serialPort1.Close();
            //search for active comports
            foreach (string s in SerialPort.GetPortNames())
            {
                //toolStripComboBox_ComPorts.Items.Add(s);
                //lstComList.Add(s);

                if (!blnConnectedToI28)
                {
                    try
                    {

                        serialPort1.BaudRate = 115200;
                        serialPort1.Handshake = Handshake.None;
                        serialPort1.PortName = s;
                        serialPort1.NewLine = "\r\n";
                        serialPort1.ReadTimeout = 1000;
                        serialPort1.Dispose();

                        serialPort1.Open();
                        bool blnOpen = serialPort1.IsOpen;
                        serialPort1.DiscardOutBuffer();

                        serialPort1.WriteLine("Exit");
                        serialPort1.WriteLine("I\\M\\Instrument Name");


                        try
                        {
                            strTestString = serialPort1.ReadLine();
                        }
                        catch (TimeoutException e)
                        {
                            LogText("exception:" + e.Message);
                            //MessageBox.Show("Communication Problem Connecting", "Error");

                            serialPort1.Close();

                        }


                        if (strTestString!=null&& strTestString.Contains("I28"))
                        {

                            blnConnectedToI28 = true;
                            serialPort1.NewLine = "\r\n";
                            Properties.Settings.Default.I28 = strI28_Com;
                            Properties.Settings.Default.Save();


                            //lstRead.Items.Add(strTemp);

                            string[] strSPlit = TonyFunctions.T_Func.saSplit(strTestString, '=');
                            String strTrimmed = strSPlit[1].Substring(0, 8);



                            strConnectInfo = ("Connected to: " + strTrimmed + " Using " + s);
                            label1.Text = (strConnectInfo);
                            serialPort1.WriteLine("SERVICE\\B\\SET DEFAULT CUS. RES HDRS=YES");
                            //String strTemp = serialPort1.ReadLine();


                            serialPort1.ReadTimeout = 1000;
                            serialPort1.WriteLine("Exit");
                            AutoSetComports();
                            DisableProgram_1();
                            DisableProgram_2();



                        }



                    }
                    catch (Exception e)
                    {
                        LogText("exception:" + e.Message);
                        //MessageBox.Show("Communication Problem Connecting", "Error");
                    }
                }
            }

            if (!blnConnectedToI28)
            {
                DialogResult result = MessageBox.Show("Check Cables, Click Retry", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Retry)
                {
                    Find_Comports();
                }

                else if (result == DialogResult.Cancel)
                {
                    Close();
                }

            }
        }




        public void Connect_DebBug()
        {

            foreach (string s in SerialPort.GetPortNames())
            {

                if (strDebugPort == s)
                {


                    serialPort4.BaudRate = 115200;
                    serialPort4.Handshake = Handshake.None;
                    serialPort4.PortName = strDebugPort;
                    serialPort4.NewLine = "\r\n";
                    serialPort4.ReadTimeout = 1000;
                    serialPort4.Dispose();

                    serialPort4.Open();
                    bool blnOpen = serialPort4.IsOpen;
                    serialPort4.DiscardOutBuffer();
                    sndbg("Debug Auto Connected");

                }
            }

        }
        public void Settings_On_Startup()
        {
            grpFixture_1.BackColor = System.Drawing.Color.LightSteelBlue;
            grpFixture_2.BackColor = System.Drawing.Color.LightSteelBlue;


            lblFix_1_Operator.Text = "";
            lblFix_2_Operator.Text = "";
            lblFix_1_SN.Text = "";
            lblFix_2_SN.Text = "";
            lblFix_1_Status.Text = Cn;
            lblFix_2_Status.Text = Cn;
            DisableProgram_1();
            DisableProgram_2();
            tsEnableFlexFlow.Checked = Properties.Settings.Default.EnableFlexFlow;
        }
        public void sndbg(string strToSend)
        {
            if (serialPort4.IsOpen)
            {
                serialPort4.WriteLine(strToSend);
            }

        }

        public void AutoSetComports()
        {

            SetSer2(Properties.Settings.Default.ReadyCom);
            SetSer3(Properties.Settings.Default.Zebra);
            //SetSer4(Properties.Settings.Default.DebugPort);
        }
        public void SetSer2(string strComport)//ready signal
        {
            this.Invoke((MethodInvoker)(() => lstTest.Items.Add(strComport + " Ready")));
            try { 
            serialPort2.BaudRate = 9600;
            serialPort2.Handshake = Handshake.None;

            serialPort2.NewLine = "\r\n";
            serialPort2.ReadTimeout = 1000;
            serialPort2.Dispose();
            if (!serialPort2.IsOpen)
            {
                serialPort2.PortName = strComport;
                serialPort2.Open();
                serialPort2.WriteLine("a");
            }
            serialPort2.DiscardOutBuffer();
            blnReadyMatched = true;
                if (serialPort2.IsOpen)
                {
                    this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Enable Port Open")));
                }
        }catch(Exception e)
            {
                LogText("exception:" + e.Message);
                MessageBox.Show("Comport Doesn't Exist for Ready", "NO CONNECTION");
            }

        }
        public void SetSer3(string strComport)//Zebra
        {
            this.Invoke((MethodInvoker)(() => lstTest.Items.Add(strComport+" Scanner")));
            try
            {
                serialPort3.BaudRate = 9600;
                serialPort3.Handshake = Handshake.None;

                serialPort3.NewLine = "\r\n";
                serialPort3.ReadTimeout = 1000;
                serialPort3.Dispose();
                if (!serialPort3.IsOpen)
                {
                    serialPort3.PortName = strComport;
                    serialPort3.Open();

                }
                serialPort3.DiscardOutBuffer();
                if (serialPort3.IsOpen)
                {
                    
                        this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Scanner Port Open")));
                    
                }

            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);
                MessageBox.Show("Comport Doesn't Exist for Scanner", "NO CONNECTION");
            }

        }
        public void SetSer4(string strComport)//Debug
        {
            
            serialPort4.BaudRate = 115200;
            serialPort4.Handshake = Handshake.None;
            serialPort4.PortName = strComport;
            serialPort4.NewLine = "\r\n";
            serialPort4.ReadTimeout = 1000;
            serialPort4.Dispose();

            serialPort4.Open();
            bool blnOpen = serialPort4.IsOpen;
            serialPort4.DiscardOutBuffer();
            sndbg("Debug Auto Connected");

        }


        public void DisableProgram_1()
        {
            blnTesting = false;
            blnGather_Param = false;
            blnGather_Result = false;
            blnSendParam = false;
            
            serialPort1.WriteLine("Exit");
            
            try
            {

               
                serialPort1.WriteLine("P1\\I\\1=Unassign all Prog");
                
                blnFix_1_Enabled = false;

                if (blnReadyMatched)
                {
                    serialPort2.WriteLine("a");
                }
                
                
                

            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);

                lstRead.Items.Add(e);
                MessageBox.Show("Communication Error with I28", "Error");
                
            }

        }
        public void DisableProgram_2()
        {
            blnTesting = false;
            blnGather_Param = false;
            blnGather_Result = false;
            blnSendParam = false;
           
            serialPort1.WriteLine("Exit");
            try
            {


                serialPort1.WriteLine("P2\\I\\7=Unassign all Prog");
                
                blnFix_2_Enabled = false;
                if (blnReadyMatched)
                {
                    serialPort2.WriteLine("a");
                }

            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);
                lstRead.Items.Add(e);
                MessageBox.Show("Communication Error with I28", "Error");
               
            }
        }
        public void Enable_Fixture_1(string SerNum)
        {
            DisableProgram_2();
            
            serialPort1.WriteLine("P"+ strFix_1_Prog+"\\I\\1=Start Channel");
            blnFix_1_Enabled = true;
            string strFullPrg = "M\\S1TCAP=" + strFix_1_Prog;
            serialPort1.WriteLine(strFullPrg);
            //serialPort1.WriteLine("M\\S1TCAP=1");
            serialPort1.WriteLine("Barcode=" + SerNum);
            Prog_Config.Clear();//clears list of parameters
            blnGather_Param = true;
            blnFix_1_Scanned = false;
            //blnFix_2_Scanned = false;
            strActiveSerial_Num = SerNum;
            txtScan.Clear();
            strScanned_Serial_Num = "";
            serialPort2.WriteLine("A");
            this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cr));
            grpFixture_1.BackColor = System.Drawing.Color.LightSteelBlue;

            serialPort1.WriteLine("I\\S\\RS232 1 Report=Cur Prog Config");
        }
        public void Enable_Fixture_2(string SerNum)
        {
            DisableProgram_1();
            
            serialPort1.WriteLine("P" + strFix_2_Prog + "\\I\\7=Start Channel");
            blnFix_2_Enabled = true;
            string strFullPrg = "M\\S1TCAP=" + strFix_2_Prog;
            serialPort1.WriteLine(strFullPrg);
            //serialPort1.WriteLine("M\\S1TCAP=2");
            serialPort1.WriteLine("Barcode=" + SerNum);
            Prog_Config.Clear();//clears list of parameters
            blnGather_Param = true;
            //blnFix_1_Scanned = false;
            blnFix_2_Scanned = false;
            strActiveSerial_Num = SerNum;
            txtScan.Clear();
            strScanned_Serial_Num = "";
            serialPort2.WriteLine("A");
            this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cr));
            grpFixture_2.BackColor = System.Drawing.Color.LightSteelBlue;

            serialPort1.WriteLine("I\\S\\RS232 1 Report=Cur Prog Config");
        }

        public void Enable_Fixture_Buffer()
        {
            if (CheckIfNetworkOrOffline())
            {

                if (strScanned_Serial_Num != "" && (blnFix_1_Scanned || blnFix_2_Scanned))
                {

                    GetUnitInfo gi = new GetUnitInfo
                    {
                        strSerialNumber = strScanned_Serial_Num,
                        strStationName = Properties.Settings.Default.StationName,
                        strUserID = "admin",
                    };


                    if (blnFix_1_Scanned)
                    {
                        this.Invoke((MethodInvoker)(() => lblMessage.Text = "getting response"));
                        LogText("getting Response");

                        var unitInfo = new GetUnitInfoResponse(gi);
                        if (unitInfo.IsOkay())
                        {
                            LogText("unit1 is okay");
                            this.Invoke((MethodInvoker)(() => lblMessage.Text = "0"));
                            txtFlexMsg.Text = "";
                           //txtFlexMsg.Visible = false;
                            LogText(unitInfo.GetUnitInfoResult);

                            // Check if Fixture on Waymo is available
                            Enable_Fixture_1(strScanned_Serial_Num);
                            //Enable_Fixture_1("strScanned_Serial_Num");
                            LogText("enabling program 1");
                        }
                        else
                        {
                            LogText("unit1 is not okay" + unitInfo.GetUnitInfoResult + unitInfo.Message);

                            // ERROR: FlexFlow says part is not ready, Anthony reset Scans
                            this.Invoke((MethodInvoker)(() => lblFix_1_SN.Text = ""));
                            this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cn));
                            DisableProgram_1();
                            LogText("disabling program 1");
                            this.Invoke((MethodInvoker)(() => lblMessage.Text = "Not Valid"));
                           // txtFlexMsg.Visible = true;
                            this.Invoke((MethodInvoker)(() => txtFlexMsg.Text = unitInfo.Message));

                            //txtFlexError.Visible = true;
                            //try {
                            //    this.Invoke((MethodInvoker)(() => txtFlexError.Text = unitInfo.Message)); // same as below 
                            //}
                            //catch (Exception e) {
                            //    LogText("lblmsg:" + e.Message);
                            //}

                        }

                    }
                    if (blnFix_2_Scanned)
                    {
                        this.Invoke((MethodInvoker)(() => lblMessage.Text = "getting response"));
                        var unitInfo = new GetUnitInfoResponse(gi);

                        if (unitInfo.IsOkay())
                        {
                            LogText("unit2 is okay");

                            LogText(unitInfo.GetUnitInfoResult);

                            this.Invoke((MethodInvoker)(() => lblMessage.Text = "0"));
                            txtFlexMsg.Text = "";
                            //txtFlexMsg.Visible = false;


                            sndbg("Sending to Enable Fixture 2");
                            Enable_Fixture_2(strScanned_Serial_Num);
                            LogText("enabling program 2");

                        }
                        else
                        {
                            LogText("unit2 is not okay" + unitInfo.GetUnitInfoResult + unitInfo.Message);

                            // ERROR: FlexFlow says part is not ready, Anthony reset Scans
                            this.Invoke((MethodInvoker)(() => lblFix_2_SN.Text = ""));
                            this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cn));
                            DisableProgram_2();
                            LogText("disabling program 2");
                            this.Invoke((MethodInvoker)(() => lblMessage.Text = "Not Valid"));
                            //txtFlexMsg.Visible = true;
                            this.Invoke((MethodInvoker)(() => txtFlexMsg.Text = unitInfo.Message));
                            


                            //txtFlexError.Visible = true;
                            //try
                            //{
                            //    this.Invoke((MethodInvoker)(() => txtFlexError.Text = unitInfo.Message));
                            //}
                            //catch (Exception e)
                            //{
                            //    LogText("lblmsg: " + e.Message);
                            //}

                        }
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("No Internet Connection\r\n\r\nGo to [Program Settings], and disable FlexFlow if intentional. Otherwise if not connected due to error, check Connections and press Retry\r\n\r\nCancel to Exit Program","Communication Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                LogText("No Internet Connection");

                if (result == DialogResult.Retry)
                {
                    Enable_Fixture_Buffer();
                    LogText("Enabled Fixture Buffer");
                }
                else
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        // close the form on the forms thread
                        this.Close();
                    });
                }


            }
        }

        public void Results_To_Send(string strTestResults)
        {
            if (blnFix_1_Enabled)
            {
                string[] I28Split = TonyFunctions.T_Func.saSplit(strTestResults, ' ');
                
                switch (I28Split[7])
                {
                    case "A"://accept
                        grpFixture_1.BackColor = System.Drawing.Color.LimeGreen;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cp));
                        break;
                    case "R"://reject
                        grpFixture_1.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cf));
                        break;
                    case "SI"://stop
                        grpFixture_1.BackColor = System.Drawing.Color.LightSteelBlue;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Csb));
                        break;
                    case "PL"://below pressure
                        grpFixture_1.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cpl));
                        break;
                    case "PH"://above pressure
                        grpFixture_1.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cph));
                        break;
                    case "SL"://severe leak
                        grpFixture_1.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Csl));
                        break;

                }
                
                SaveAndDump("HR", strTestResults, I28Split); //i28[33] should be barcode here, but is not.

                blnTesting = false;
                blnTesting_Fix_1 = false;
                DisableProgram_1();
            }
            if (blnFix_2_Enabled)
            {
                string[] I28Split = TonyFunctions.T_Func.saSplit(strTestResults, ' ');
                switch (I28Split[7])
                {
                    case "A"://accept
                        grpFixture_2.BackColor = System.Drawing.Color.LimeGreen;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cp));
                        break;
                    case "R"://reject
                        grpFixture_2.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cf));
                        break;
                    case "SI"://stop button
                        grpFixture_2.BackColor = System.Drawing.Color.LightSteelBlue;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Csb));
                        break;
                    case "PL"://below pressure
                        grpFixture_2.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cpl));
                        break;
                    case "PH"://above pressure
                        grpFixture_2.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cph));
                        break;
                    case "SL"://severe leak
                        grpFixture_2.BackColor = System.Drawing.Color.Red;
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Csl));
                        break;
                }

                
                SaveAndDump("SV", strTestResults, I28Split); //i28[33] should be barcode here, but is not.


                blnTesting = false;
                blnTesting_Fix_2 = false;
                DisableProgram_2();
                

                //lstTest.Items.Add(strTestResults);


            }
            sndbg("Results in, next is enable Fixture Buffer");
            Enable_Fixture_Buffer();
            blnGather_Result = false;
        }

        private void SaveAndDump(string stationType, string strTestResults, string[] I28Split)
        {
            var serialNo = strActiveSerial_Num; //I28Split[33];
            SaveResult sr = new SaveResult
            {
                strStationType = stationType,
                strSerialNumber = serialNo,
                strTestResults = strTestResults,
                strBenchtopRefNumber = I28Split[6],
                strOperator = strOperator,
                strStationName = Properties.Settings.Default.StationName,
                dtStartBatchTimestamp = dtActiveTestStartTime.ToUniversalTime(),
                dtEndBatchTimestamp = dtActiveTestEndTime.ToUniversalTime(),
                strParameters = String.Join(Environment.NewLine, Prog_Config),
                i28FlexStatus = new I28FlexStatus(I28Split[7]),
                strDeltaValue = null,
                strDeltaMinimum = Prog_Config[25].Split('=')[1].Split('\t')[0],
                strDeltaMaximum = Prog_Config[26].Split('=')[1].Split('\t')[0],
                strPTValue = null,
                strPTMinimum = null,
                strPTMaximum = null
            };
            this.Invoke((MethodInvoker)(() => lblMessage.Text = ""));

            var savedResponse = new SaveResultResponse(sr);
            if (!savedResponse.IsOkay())
            {
                LogText("Save result okay");
                txtFlexError.Visible = true;
                this.Invoke((MethodInvoker)(() => txtFlexError.Text = savedResponse.Message));
            }

            if (!sr.i28FlexStatus.error)
            {
                sr.strDeltaValue = I28Split[46];
                
                sr.strPTValue = null;
                int ptIndex = Array.IndexOf(I28Split, "FPR");
                if (ptIndex > 0) {
                    sr.strPTValue = I28Split[ptIndex +1];
                }
                sr.strPTMinimum = Prog_Config[21].Split('=')[1].Split('\t')[0];
                sr.strPTMaximum = Prog_Config[23].Split('=')[1].Split('\t')[0];

                LogText("flex status okay");
                LogText("i28split: " + String.Join(Environment.NewLine, I28Split));
            } else {
                // Ensure Null
                LogText("flex status error");
            }

            try { 
                sr.Dumpy();
            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);
            }
        }

        public void Test_Gather(string strParameters)
        {
            Prog_Config.Add(strParameters);
        }
     
       
        public void Scan_Input(string strScan)
        {
            if (debugToolStripMenuItem.Checked)
            {
                this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Something Scanned")));
            }

            txtFlexError.Visible = false;
            //sndbg("something Scanned");
            if (strScan == "Fixture 1")
                {
                    blnFix_1_Scanned = true;
                    blnFix_2_Scanned = false;
                if (debugToolStripMenuItem.Checked)
                {
                    this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Fixture 1 Scanned")));
                }
            }

            if (strScan == "Fixture 2") {
                blnFix_2_Scanned = true;
                blnFix_1_Scanned = false;
                if (debugToolStripMenuItem.Checked) {
                    this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Fixture 2 Scanned")));
                }
            }

             if(!strScan.Contains("Fixture")) {
                strScanned_Serial_Num = strScan;
                blnSerNumScanned = true;
                if (debugToolStripMenuItem.Checked) {
                    this.Invoke((MethodInvoker)(() => lstTest.Items.Add("Serial # Scanned")));
                }
            }

            if (!blnTesting_Fix_1 && blnFix_1_Scanned && blnSerNumScanned) {
                if(Check_HR(strScanned_Serial_Num)) {
                    this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cs));
                    grpFixture_1.BackColor = System.Drawing.Color.LightSteelBlue;
                    this.Invoke((MethodInvoker)(() => lblFix_1_SN.Text = ""));
                    this.Invoke((MethodInvoker)(() => lblFix_1_Operator.Text = ""));
                    blnFixInfoComplete=true;
                     
                    if (!blnTesting_Fix_2) {
                        this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cn));
                        grpFixture_2.BackColor = System.Drawing.Color.LightSteelBlue;
                    }
                }
            }
            if (!blnTesting_Fix_2 && blnFix_2_Scanned && blnSerNumScanned) {
                if (Check_SV(strScanned_Serial_Num)) {
                    this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Cs));
                    grpFixture_2.BackColor = System.Drawing.Color.LightSteelBlue;
                    this.Invoke((MethodInvoker)(() => lblFix_2_SN.Text = ""));
                    this.Invoke((MethodInvoker)(() => lblFix_2_Operator.Text = ""));
                    blnFixInfoComplete = true;
                    sndbg("Not in Test Fixture 2 Scan");
                    if (!blnTesting_Fix_1) {
                        this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Cn));
                        grpFixture_1.BackColor = System.Drawing.Color.LightSteelBlue;
                    }
                }
            }

            if (!blnTesting&&blnFixInfoComplete) {
                Enable_Fixture_Buffer();
                blnFixInfoComplete=false;
                blnSerNumScanned = false;
            }

        }

         public Boolean Check_HR(string strsernum)
         {
             string strToCheck = strsernum.Substring(3, 2);
             if (strToCheck == strHR_Check)
             {
                 this.Invoke((MethodInvoker)(() => lblMessage.Text = ""));
                 return true;

             }
             else
             {
                 blnFix_1_Scanned = false;
                 blnSerNumScanned = false;
                 strScanned_Serial_Num = "";
                 this.Invoke((MethodInvoker)(() => lblMessage.Text = "Fixture/Part MisMatch"));
                 return false;
             }

         }
         public Boolean Check_SV(string strsernum)
         {
             string strToCheck = strsernum.Substring(3, 2);
             if (strToCheck == strSV_Check)
             {
                 this.Invoke((MethodInvoker)(() => lblMessage.Text = ""));
                 return true;

             }
             else
             {
                 blnFix_1_Scanned = false;
                 blnSerNumScanned = false;
                 strScanned_Serial_Num = "";
                 this.Invoke((MethodInvoker)(() =>lblMessage.Text = "Fixture/Part MisMatch"));
                 return false;
             }

         }
         public void Fixture_Results(string strStatus)
         {
             if (blnFix_1_Enabled)
             {
                 switch (strStatus)
                 {
                     case "In Test":
                         grpFixture_1.BackColor = System.Drawing.Color.Yellow;
                         this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Ci));
                         this.Invoke((MethodInvoker)(() => lblFix_1_SN.Text = strActiveSerial_Num));
                         this.Invoke((MethodInvoker)(() => lblFix_1_Operator.Text = strOperator));
                         blnTesting_Fix_1 = true;
                         serialPort2.WriteLine("a");
                         
                             break;
                         

                 }

             }

             if (blnFix_2_Enabled)
             {
                 switch (strStatus)
                 {
                     case "In Test":
                         grpFixture_2.BackColor = System.Drawing.Color.Yellow;
                         this.Invoke((MethodInvoker)(() => lblFix_2_Status.Text = Ci));
                         this.Invoke((MethodInvoker)(() => lblFix_2_SN.Text = strActiveSerial_Num));
                         this.Invoke((MethodInvoker)(() => lblFix_2_Operator.Text = strOperator));
                         blnTesting_Fix_2 = true;
                         

                         serialPort2.WriteLine("a");

                         break;


                 }

             }

         }
        public void ChamberTestResults(string strTestResults)
        {

            string[] I28Split = TonyFunctions.T_Func.saSplit(strTestResults, ' ');

            switch (I28Split[7])
            {
                case "A"://accept
                    grpChamberTest.BackColor = System.Drawing.Color.LimeGreen;
                    this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = Cp));
                    break; 
                case "R"://reject
                    grpChamberTest.BackColor = System.Drawing.Color.Red;
                    this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = Cf));
                    break;
                case "SI"://stop
                    grpChamberTest.BackColor = System.Drawing.Color.LightSteelBlue;
                    this.Invoke((MethodInvoker)(() => lblFix_1_Status.Text = Csb));
                    break;
                case "PL"://below pressure
                    grpChamberTest.BackColor = System.Drawing.Color.Red;
                    this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = Cpl));
                    break;
                case "PH"://above pressure
                    grpChamberTest.BackColor = System.Drawing.Color.Red;
                    this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = Cph));
                    break;
                case "SL"://severe leak
                    grpChamberTest.BackColor = System.Drawing.Color.Red;
                    this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = Csl));
                    break;

            }
            this.Invoke((MethodInvoker)(() => btnCloseChamber.Visible = true));
            blnChamActive = false;

        }
        

        public void ReadFromDMD()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "unknown.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt";

            savefile.InitialDirectory = strFolderPath;

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                strFile_with_Path = savefile.FileName;

            }
            if (blnConnectedToI28)
            {
                using (StreamWriter outputFile = new StreamWriter(strFile_with_Path))
                {

                    outputFile.Close();


                }
                serialPort1.DiscardInBuffer();
                lstRead.Items.Clear();
                try
                {
                    serialPort1.WriteLine("[DumpDB");
                    Thread.Sleep(300);

                    while (serialPort1.BytesToRead != 0)
                    {
                        try
                        {
                            string strReadDmd = serialPort1.ReadLine();

                            if (!strReadDmd.Contains(";Waiting_"))
                            {

                                this.Invoke((MethodInvoker)(() => lstRead.Items.Add(strReadDmd)));
                                using (StreamWriter outputFile = new StreamWriter(strFile_with_Path, true))
                                {

                                    outputFile.WriteLine(strReadDmd);


                                }
                            }

                        }
                        catch (TimeoutException e)
                        {
                            LogText("exception:" + e.Message);
                            serialPort1.Close();

                        }

                    }

                }
                catch (Exception e)
                {
                    LogText("exception:" + e.Message);
                    MessageBox.Show("Communication Problem", "Error");

                }
            }



        }

        public void AddSeq()
        {
            openFileDialog1.InitialDirectory = strFolderPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileToRead = openFileDialog1.FileName;
            }
            lstRead.Items.Clear();

            using (StreamReader sr = new StreamReader(strFileToRead))
            {
                while (!sr.EndOfStream)
                {
                    string strReadFile = sr.ReadLine();
                    serialPort1.WriteLine(strReadFile);
                    this.Invoke((MethodInvoker)(() => lstRead.Items.Add(strReadFile)));

                }
            }

        }


#endregion



        private void retrieveSequencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFromDMD();

        }



        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSeq();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE the Existing Sequences?", "Delete Existing Sequences", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                serialPort1.WriteLine("[clrdb");
                Thread.Sleep(2000);
                AddSeq();
            }
            else
            {
                this.Invoke((MethodInvoker)(() => lstRead.Items.Add("Delete and Send Aborted")));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!blnChamberTest) 
            { 
            int intBytesLeft = serialPort1.BytesToRead;

            while (intBytesLeft != 0)
            {
                string strFromI28 = serialPort1.ReadLine();
                this.Invoke((MethodInvoker)(() => lstRead.Items.Add(strFromI28)));
                intBytesLeft = serialPort1.BytesToRead;
                if (strFromI28.Contains("Start Streaming"))
                {
                    dtActiveTestStartTime = DateTime.Now;
                    blnTesting = true;
                    //lstTest.Items.Add("In Test");
                    Fixture_Results("In Test");
                    this.Invoke((MethodInvoker)(() => lblMessage.Text = ""));

                }
                if (strFromI28.Contains("Stop Streaming"))
                {
                    dtActiveTestEndTime = DateTime.Now;
                    //lstTest.Items.Add("Stop  Test");
                    blnGather_Result = true;
                    // this.Invoke((MethodInvoker)(() => lblMessage.Text = "Compiling Data"));

                }
                if (blnGather_Result)
                {
                    LogText("serialResult: " + strFromI28);
                    string[] I28Split = TonyFunctions.T_Func.saSplit(strFromI28, '\t');
                    if (I28Split[1] == "R")
                    {
                        Results_To_Send(strFromI28);

                    }
                }

                if (blnGather_Param)
                {
                    if (strFromI28.Contains("Start, Current Program Config Report"))
                    {
                        LogText("serialResult: start");

                        blnSendParam = true;

                    }
                    if (blnSendParam)
                    {
                        Test_Gather(strFromI28);
                    }

                    if (strFromI28.Contains("Stop, Current Program Config Report"))
                    {
                        LogText("serialResult: stop");

                        blnSendParam = false;
                        blnGather_Param = false;

                    }

                }




            }
        }
            if (blnChamberTest)
            {
                int intBytesLeft = serialPort1.BytesToRead;

                while (intBytesLeft != 0)
                {
                    string strFromI28 = serialPort1.ReadLine();
                    //this.Invoke((MethodInvoker)(() => lstRead.Items.Add(strFromI28)));
                    intBytesLeft = serialPort1.BytesToRead;
                    if (strFromI28.Contains("Start Streaming"))
                    {

                        this.Invoke((MethodInvoker)(() => btnCloseChamber.Visible = false));
                        this.Invoke((MethodInvoker)(() => lblChamberStatus.Text = "In Test"));
                        this.Invoke((MethodInvoker)(() => lblMessage.Text = ""));

                    }
                    if (strFromI28.Contains("Stop Streaming"))
                    {
                        blnChamActive = true;
                        // dtActiveTestEndTime = DateTime.Now;
                        //lstTest.Items.Add("Stop  Test");
                        // blnGather_Result = true;
                        // this.Invoke((MethodInvoker)(() => lblMessage.Text = "Compiling Data"));
                        
                    }

                    if (blnChamActive)
                    {
                        string[] I28Split = TonyFunctions.T_Func.saSplit(strFromI28, '\t');
                        LogText("serialResult: ");

                        if (I28Split[1] == "R")
                        {
                            ChamberTestResults(strFromI28);

                        }


                    }


                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DisableProgram_1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blnFix_1_Scanned = true;
            Enable_Fixture_Buffer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFlexError.Visible = true;
            txtFlexError.Text= $"Error reading XML, please check your FlexFlow URL Setting ({Properties.Settings.Default.FlexURL}) is correct, or check the FlexFlow logs.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisableProgram_2();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            int intBufferSize = serialPort1.BytesToRead;
            lstRead.Items.Add(intBufferSize);
            //serialPort1.DiscardInBuffer();
           
            
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {
            tmrScanIn.Enabled = true;
            
        }

        private void tmrScanIn_Tick(object sender, EventArgs e)
        {
            Scan_Input(txtScan.Text);
            tmrScanIn.Enabled = false;
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            tmrDelay.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (string s in Prog_Config)
            {
                
                //lstTest.Items.Add(s);
                
            }
        }

        private void btnTestReady_Click(object sender, EventArgs e)
        {
            if (blnReadyMatched)
            {
                serialPort2.WriteLine("a");
                serialPort2.WriteLine("A");

            }
            
        }

        private void btnSaveReadyCOM_Click(object sender, EventArgs e)
        {
            serialPort2.WriteLine("a");
            Properties.Settings.Default.ReadyCom = strReadyCom;
            Properties.Settings.Default.Save();
            blnReadyMatched = true;
            
        }

        private void readyONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            serialPort2.WriteLine("A");
        }

        private void readyOFFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            serialPort2.WriteLine("a");
        }

       

        private void btnZebraReady_Click(object sender, EventArgs e)
        {
            grpZebraTest.Visible = true;

        }

        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                strFromScannerCom = serialPort3.ReadLine();

                if (grpZebraTest.Visible == false && grpOperator.Visible == false)
                {
                    Scan_Input(strFromScannerCom);
                }



                if (grpOperator.Visible == true)
                {
                    this.Invoke((MethodInvoker)(() => txtOperator.Text = strFromScannerCom));


                }

                if (blnTestScan)
                {
                    this.Invoke((MethodInvoker)(() => lblTestScan.Text = strFromScannerCom));

                }
            }
            catch (Exception ex)
            {
                LogText("exception:" + ex.Message);
                MessageBox.Show("Scan Error\r\n\r\nRetry Scan", "Error");
            }
            
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            blnTestScan = false;
            grpZebraTest.Visible = false;
        }

        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            grpOperator.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            strOperator = txtOperator.Text;
            grpOperator.Visible = false;
        }

        private void fixture1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i != 98)
            {
                i++;
                cmbFix_1_Prg.Items.Add(Convert.ToString(i));
                cmbFix_2_Prg.Items.Add(Convert.ToString(i));

            }

            cmbFix_1_Prg.SelectedItem = Properties.Settings.Default.Fix_1_Prog;
            cmbFix_2_Prg.SelectedItem = Properties.Settings.Default.Fix_2_Prog;
            
            grpFixture_Prog.Visible = true;
            
        }

        private void btnSavePrograms_Click(object sender, EventArgs e)
        {
            strFix_1_Prog = cmbFix_1_Prg.GetItemText(cmbFix_1_Prg.SelectedItem);
            Properties.Settings.Default.Fix_1_Prog = strFix_1_Prog;
            Properties.Settings.Default.Save();
            strFix_2_Prog = cmbFix_2_Prg.GetItemText(cmbFix_2_Prg.SelectedItem);
            Properties.Settings.Default.Fix_2_Prog = strFix_2_Prog;
            Properties.Settings.Default.Save();
            grpFixture_Prog.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            grpFixture_Prog.Visible = false;
        }

        private void btnDebugClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DebugPort = strDebugPort;
            Properties.Settings.Default.Save();
        }

        private void sNPartIdentifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)(() => lblHR_Current.Text = strHR_Check));
            this.Invoke((MethodInvoker)(() => lblSV_Current.Text = strSV_Check));                      
            grpSN_Verify.Visible = true;
        }

        private void txtHR_New_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters or numbers

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;

            }
        }
        private void txtSV_New_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters or numbers

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;

            }
        }

        private void btnSave_ID_Click(object sender, EventArgs e)
        {
            if (txtHR_New.Text != "")
            {
                strHR_Check = txtHR_New.Text;
                Properties.Settings.Default.HR_ID = strHR_Check;
                Properties.Settings.Default.Save();
            }
            if (txtSV_New.Text != "")
            {
                strSV_Check = txtSV_New.Text;
                Properties.Settings.Default.SV_ID = strSV_Check;
                Properties.Settings.Default.Save();
            }

            grpSN_Verify.Visible = false;
            txtHR_New.Text = "";
            txtSV_New.Text = "";

        }

        private void btnClose_ID_Click(object sender, EventArgs e)
        {
            grpSN_Verify.Visible = false;
            txtHR_New.Text = "";
            txtSV_New.Text = "";
        }

        private void testScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blnTestScan = true;
            grpZebraTest.Visible = true;
        }

        private void btnOperClose_Click(object sender, EventArgs e)
        {
            grpOperator.Visible = false;
        }

        private void btnCloseFlexUrl_Click(object sender, EventArgs e)
        {
            grpFlexFlowUrl.Visible = false;
        }

        private void flexFlowURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpFlexFlowUrl.Visible = true;
            grpFlexFlowUrl.Text= Properties.Settings.Default.FlexURL;//URL for Flex Flow Stuff
            //txtCur_FlexFlowUrl.Text = Properties.Settings.Default.FlexURL;//URL for Flex Flow Stuff

        }

        private void btnSaveFlexUrl_Click(object sender, EventArgs e)
        {
            if (txtNew_FlexFlowUrl.Text != "")
            {
                Properties.Settings.Default.FlexURL = txtNew_FlexFlowUrl.Text;
                Properties.Settings.Default.Save();
                grpFlexFlowUrl.Visible = false;
            }
        }

        private void setComPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpSetComPorts.Visible = true;
            txtReadyCom.Text = Properties.Settings.Default.ReadyCom;
            txtZebra.Text = Properties.Settings.Default.Zebra;
        }

        private void btnSaveCom_Click(object sender, EventArgs e)
        {
            if (txtReadyCom.Text != "")
            {
                Properties.Settings.Default.ReadyCom = txtReadyCom.Text;
                Properties.Settings.Default.Save();
                SetSer2(Properties.Settings.Default.ReadyCom);
            }

            if (txtZebra.Text != "")
            {
                Properties.Settings.Default.Zebra = txtZebra.Text;
                Properties.Settings.Default.Save();
                SetSer3(Properties.Settings.Default.Zebra);
            }
            grpSetComPorts.Visible = false;
        }

        private void btnCloseComports_Click(object sender, EventArgs e)
        {
            grpSetComPorts.Visible = false;
        }

        

        public static bool CheckIfNetworkOrOffline()
        {
            // TODO: @Anthony - I think you need to remove this to enable data being sent to their mgf-inspector
            // when flexflow is disabled
            if (!Properties.Settings.Default.EnableFlexFlow)
            {
                LogText("enable flexflow false");

                return true;
            }
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://google.com/generate_204"))
                LogText("got to google.");

                return true;
            }
            catch (Exception e)
            {
                LogText("exception:" + e.Message);

                return false;
            }
        }

        private void btnCloseChamber_Click(object sender, EventArgs e)
        {
            grpChamberTest.Visible = false;
            blnChamberTest = false;
            blnChamActive = false;
            serialPort1.WriteLine("P10\\I\\1=Unassign all Prog");
            serialPort1.WriteLine("P11\\I\\1=Unassign all Prog");
            serialPort2.WriteLine("a");


        }

        private void hRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("P10\\I\\1=Start Channel");
            blnFix_1_Enabled = true;
            string strFullPrg = "M\\S1TCAP=10";
            serialPort1.WriteLine(strFullPrg);
            blnChamberTest = true;
            grpChamberTest.Visible = true;
            serialPort2.WriteLine("A");
            grpChamberTest.Text = "HR Chamber Test";
            lblChamberStatus.Text = "Insert Empty HR Chamber";
        }
        private void sVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("P11\\I\\7=Start Channel");
            blnFix_1_Enabled = true;
            string strFullPrg = "M\\S1TCAP=11";
            serialPort1.WriteLine(strFullPrg);
            blnChamberTest = true;
            grpChamberTest.Visible = true;
            serialPort2.WriteLine("A");
            grpChamberTest.Text = "SV Chamber Test";
            lblChamberStatus.Text = "Insert Empty SV Chamber";

        }

        private void TsEnableFlexFlow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableFlexFlow = tsEnableFlexFlow.Checked;
            Properties.Settings.Default.Save();
        }

        private void debugToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (debugToolStripMenuItem.Checked)
            {
                lstTest.Visible = true;
            }
            else
            {
                lstTest.Visible = false;
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Version: " + Properties.Settings.Default.Version);
        }

        private void stationNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpStation.Visible = true;
            txtStationName.Text = Properties.Settings.Default.StationName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grpStation.Visible = false;
        }

        private void btnSaveStation_Click(object sender, EventArgs e)
        {
            if (txtStationName.TextLength > 0)
            {
                Properties.Settings.Default.StationName = txtStationName.Text;
                Properties.Settings.Default.Save();
                grpStation.Visible = false;

            }
            else
            {
                MessageBox.Show("Enter a Value or Click Close");

            }
        }

        public static void LogText(string message)
        {
            if (Properties.Settings.Default.DebugLogs)
            {
                if (!Directory.Exists(Properties.Settings.Default.LogDirectory))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.LogDirectory);
                }
                using (StreamWriter w = File.AppendText($"{Properties.Settings.Default.LogDirectory}\\log_form1.txt"))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                    w.WriteLine($"  :{message}");
                    w.WriteLine("-------------------------------");
                }
            }
        }
    }
}
