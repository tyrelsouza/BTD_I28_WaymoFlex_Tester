using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _8082_Waymo_PC
{
    public class GetUnitInfo
    {
        public string ACTION = "http://www.flextronics.com/FFTester20/GetUnitInfo";

        public string strStationName { get; set; }
        public string strSerialNumber { get; set; }
        public string strUserID { get; set; }

        public string Body()
        {
            return String.Join(
                Environment.NewLine,
                $"<strRequest>{strSerialNumber}</strRequest>",
                $"<strStationName>{strStationName}</strStationName>",
                "<strUnitInfo></strUnitInfo>",
                $"<strUserID>{strUserID}</strUserID>" // See if needs to be set
                );
        }
    }

    public class GetUnitInfoResponse
    {
        [XmlElement]
        public string GetUnitInfoResult { get; set; }
        public string Message { get; set; }

        public GetUnitInfoResponse(GetUnitInfo gi)
        {
            // If Flex Flow is not enabled, don't make an API call, and set the messages appropriately.
            if (!Properties.Settings.Default.EnableFlexFlow)
            {
                GetUnitInfoResult = "0";
                Message = "Skipping FlexFlow because Disabled";
                return;
            }

            var response = FlexFlow.Send(gi.GetType().Name, gi.Body(), gi.ACTION);
            // local variables because cant use class variable with TryGetResult

            var dict = XMLParser.ToDict(response);
            if (dict == null)
            {
                GetUnitInfoResult = "-100";
                Message = $"Error reading XML, please check your FlexFlow URL Setting ({Properties.Settings.Default.FlexURL}) is correct, or check the FlexFlow logs.";
                return;
            }

            dict.TryGetValue("GetUnitInfoResult", out string lGUI);
            GetUnitInfoResult = lGUI;

            Message = response;

        }

        public Boolean IsOkay()
        {
            /// If not okay, Message is error message NEED TO Display to screen.
            if (GetUnitInfoResult == "0")
            {
                return true;
            }
            return false;
        }

    }
}


