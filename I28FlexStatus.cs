using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8082_Waymo_PC
{
    public class I28FlexStatus
    {
        /// <summary>
        ///  The status to send to FlexFlow SaveResult
        /// </summary>
        public string flexStatus { get; set; }
        /// <summary>
        /// The status to send to Waymo as a single test parameter status
        /// </summary>
        public string parameterStatus { get; set; }
        /// <summary>
        /// The overall test status to send to Waymo
        /// </summary>
        public string outcome { get; set; }
        /// <summary>
        /// Whether there was an error, or the test finished to completion
        /// </summary>
        public bool error { get; set; }
        /// <summary>
        /// A human readable failure code to send as a Failure to Waymo
        /// </summary>
        public string failureCode { get; set; }
        /// <summary>
        /// A full details of the failure to send to Waymo, (explains failureCode in length)
        /// </summary>
        public string failureDetails { get; set; }

        public I28FlexStatus (string code)
        {
            switch (code.ToUpper())
            {
                /* NON ERRORS */
                case "A": // Accept
                    flexStatus = "Passed";
                    parameterStatus = "PASS";
                    outcome = "TEST_PASS";
                    error = false;
                    break;
                case "R": // Reject
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = false;
                    break;
                /* ERRORS */
                case "PL":  // Below Pressure
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = true;
                    failureCode = "pressure_low";
                    failureDetails = "Equipment reported error code PL, Pressure Low. Unable to run leak test.";
                    break;
                case "SL": // Severe Leak
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = true;
                    failureCode = "severe_leak";
                    failureDetails = "Equipment reported error code SL, Severe Leak. Unable to run leak test.";
                    break;
                case "PH": // Above Pressure
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = true;
                    failureCode = "pressure_high";
                    failureDetails = "Equipment reported error code PH, Pressure High. Unable to run leak test.";
                    break;
                case "SI": // Stop Button
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = true;
                    failureCode = "test_stopped";
                    failureDetails = "Operator pressed stop button, test aborted.";
                    break;
                 /* FALLBACK - Error */
                default: // No idea, just log it and fail.
                    flexStatus = "Failed";
                    parameterStatus = "FAIL";
                    outcome = "TEST_FAIL";
                    error = true;
                    failureCode = "unknown_error";
                    failureDetails = $"Encountered error code {code}, an unknown error has occurred.";
                    break;
            }
        }
    }
}
