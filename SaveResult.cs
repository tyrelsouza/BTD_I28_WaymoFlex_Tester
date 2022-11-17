using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _8082_Waymo_PC
{
    public class SaveResult
    {
        public string ACTION = "http://www.flextronics.com/FFTester20/SaveResult";

        public string strSerialNumber { get; set; }
        public string strStationName { get; set; }
        public string strStationType { get; set; }

        public DateTime dtStartBatchTimestamp { get; set; }
        public DateTime dtEndBatchTimestamp { get; set; }
        public string strOperator { get; set; }
        public string strTestResults { get; set; }
        public string strBenchtopRefNumber { get; set; }
        public string strParameters { get; set; } // test parameters from serial
        public I28FlexStatus i28FlexStatus { get; set; }

        public string strDeltaValue {get; set; }
        public string strDeltaMinimum {get; set; }
        public string strDeltaMaximum {get; set; }
        public string strPTValue {get; set; }
        public string strPTMinimum {get; set; }
        public string strPTMaximum {get; set; }

        public string Body()
        {
            return String.Join(
                Environment.NewLine,
                "<strXMLResultText>",
                "<![CDATA[",
                 "<BATCH>",
                $"<FACTORY TESTER=\"{strStationName}\" />",
                 " <PANEL>",
                $" <DUT ID=\"{strSerialNumber}\" TIMESTAMP=\"{dtEndBatchTimestamp.ToString("o")}\" STATUS=\"{i28FlexStatus.flexStatus}\">",
                 "   <GROUP>",
                $"    <TEST NAME=\"OPERATOR\" STATUS=\"Passed\" VALUE=\"{strOperator}\" />",
                $"    <TEST NAME=\"TestResult\" STATUS=\"{i28FlexStatus.flexStatus}\" VALUE=\"{strTestResults}\" />",
                 "   </GROUP>",
                 "  </DUT>",
                 " </PANEL>",
                 "</BATCH>",
                 "]]>",
                 "</strXMLResultText>",
                 $"<strTestRefNo>{strBenchtopRefNumber}</strTestRefNo>"
                );
        }

        public void Dumpy()
        {
            //Directory.CreateDirectory("C:\\dumpy"); // force make the dumpy directory
            //Directory.CreateDirectory("C:\\dumpy\\inbox"); // force make the dumpy directory
            LogText("to dumpy: " + strStationType + " " + strDeltaValue + " " + strDeltaMinimum + " " + strDeltaMaximum);

            var dump = String.Join(
                Environment.NewLine,
                "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>",
                "<Event xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"dumptruck.xsd\">",
                $"  <start_time>{dtStartBatchTimestamp.ToUniversalTime().ToString("o")}</start_time>",
                $"  <end_time>{dtEndBatchTimestamp.ToUniversalTime().ToString("o")}</end_time>",
                $"  <unit_serial>{strSerialNumber}</unit_serial>",
                $"  <station_name>{Properties.Settings.Default.StationName}</station_name>",
                $"  <station_type>{strStationType.ToLower()}_leakdecay</station_type>", // e.g.: sv_leakdecay
                $"  <outcome>{i28FlexStatus.outcome}</outcome>",
                $"  <operator_name>{strOperator}</operator_name>",
                 i28FlexStatus.error ? ErrorElement() : SuccessElement(),
                 "</Event>"
             );
            var filename = $"C:\\dumpy\\inbox\\benchtop_8082_{dtStartBatchTimestamp.ToString("h_mm_ss")}.xml";
            File.WriteAllText(filename, dump);
        }

        private string SuccessElement()
        {

            return String.Join(
                 Environment.NewLine,
             "  <TestParameter>",
             $"    <name>Delta Pa</name>",
             $"    <parameter_status>{i28FlexStatus.parameterStatus}</parameter_status>",
             $"    <numeric_value>{strDeltaValue}</numeric_value>",
             $"    <numeric_minimum>{strDeltaMinimum}</numeric_minimum>",
             $"    <numeric_maximum>{strDeltaMaximum}</numeric_maximum>",
             "  </TestParameter>",
             "  <TestParameter>",
             "    <name>Volumetric Pressure (mbar)</name>",
             $"    <parameter_status>{i28FlexStatus.parameterStatus}</parameter_status>",
             $"    <numeric_value>{strPTValue}</numeric_value>",
             $"    <numeric_minimum>{strPTMinimum}</numeric_minimum>",
             $"    <numeric_maximum>{strPTMaximum}</numeric_maximum>",
             "  </TestParameter>",
             "  <MediaParameter>",
             "    <filename>TEST_PARAMETERS.txt</filename>",
             "    <filetype>TXT</filetype>",
             $"    <encoded_file>{base64(strParameters)}</encoded_file>",
             "  </MediaParameter>");
        }
        private string ErrorElement()
        {
            return String.Join(
                 Environment.NewLine,
                 "<FailureCode>",
                 $"<code>{i28FlexStatus.failureCode}</code> ",
                 $"<details>{i28FlexStatus.failureDetails}</details>",
                 "</FailureCode>"
                 );
        }

        public string base64(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
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



    public class SaveResultResponse
    {
        [XmlElement]
        public string SaveResultResult { get; set; }
        public string Message { get; set; }
        public string strTestRefNo { get; set; }


        public SaveResultResponse(SaveResult sr)
        {
            // If Flex Flow is not enabled, don't make an API call, and set the messages appropriately.
            if (!Properties.Settings.Default.EnableFlexFlow)
            {
                SaveResultResult = "0";
                Message = "Skipping FlexFlow because Disabled";
                strTestRefNo = sr.strBenchtopRefNumber;
                return;
            }

            var response = FlexFlow.Send(sr.GetType().Name, sr.Body(), sr.ACTION);
            var dict = XMLParser.ToDict(response);
            if (dict == null)
            {
                SaveResultResult = "-100";
                Message = $"Error reading XML, please check your FlexFlow URL Setting ({Properties.Settings.Default.FlexURL}) is correct, or check the FlexFlow logs.";
                return;
            }
            dict.TryGetValue("SaveResultResult", out string lSRR);
            dict.TryGetValue("strTestRefNo", out string lTRN);
            SaveResultResult = lSRR;
            strTestRefNo = lTRN;
            Message = response; // Just set message as response.
        }
        public Boolean IsOkay()
        {
            /// If not okay, Message is error message NEED TO Display to screen.
            if (SaveResultResult == "0")
            {
                return true;
            }
            return false;
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
