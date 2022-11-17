using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace _8082_Waymo_PC
{
     class FlexFlow
    {
        public static string Send(string className, string body, string action)
        {
            string response;
            response = Task.Run(async () => await EnvelopeAndSend(className, body, action)).Result;

            Directory.CreateDirectory("C:\\benchtoplogs");
            File.WriteAllText($"C:\\benchtoplogs\\response_{DateTime.Now:h_mm_ss}.txt", response);
            return response;
        }

        public static async Task<string> EnvelopeAndSend(string className, string body, string action)
        {
            HttpResponseMessage response;
            // should serialized properly, but the CData jank makes it hard.
            var envelope = String.Join(
                Environment.NewLine,
                 "<?xml version=\"1.0\" encoding=\"utf-8\"?>",
                 "<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">",
                 "<soap12:Body>",
                $"<{className} xmlns=\"http://www.flextronics.com/FFTester20\">",
                  body,
                $"</{className}>",
                 "</soap12:Body>",
                 "</soap12:Envelope>"
                );
            
            // Debugging logs
            Directory.CreateDirectory("C:\\benchtoplogs");
            File.WriteAllText($"C:\\benchtoplogs\\envelope_{DateTime.Now:h_mm_ss}.txt", envelope);
            response = await PostXmlRequest(envelope, action);
            var x = await response.Content.ReadAsStringAsync();
            LogText("got xml string");
            return x;
        }

        public static async Task<HttpResponseMessage> PostXmlRequest(string envelope, string action)
        {
            string FlexFlowURL = Properties.Settings.Default.FlexURL; //URL for Flex Flow Stuff
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/soap+xml;charset=UTF-8");

                var httpContent = new StringContent(envelope, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("SOAPAction", action);

                var x =  await httpClient.PostAsync(FlexFlowURL, httpContent);
                LogText("Got Post data back.");
                return x;
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
