using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _8082_Waymo_PC
{
    class XMLParser
    {
        public static Dictionary<string, string> ToDict(string xmlToParse)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Parse(xmlToParse);
            } catch ( XmlException e)
            {
                LogText("exception:" + e.Message);
                return null;
            }
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

            foreach (XElement element in doc.Descendants().Where(p => p.HasElements == false))
            {
                int keyInt = 0;
                string keyName = element.Name.LocalName;

                while (dataDictionary.ContainsKey(keyName))
                {
                    keyName = element.Name.LocalName + "_" + keyInt++;
                }

                dataDictionary.Add(keyName, element.Value);
            }
            return dataDictionary;
        }
        public static void LogText(string message)
        {
            if (Properties.Settings.Default.DebugLogs)
            {
                if (!Directory.Exists(Properties.Settings.Default.LogDirectory))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.LogDirectory);
                }
                using (StreamWriter w = File.AppendText($"{Properties.Settings.Default.LogDirectory}\\log_xmlparser.txt"))
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
