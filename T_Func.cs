using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace TonyFunctions
{

    
    public class T_Func
    {
        public static double caniseeit;
        #region Conversions
        /// <summary>
        /// Converts  to mm (inch)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double in_to_mm(double toConvert)
        {
            double dblConverted = (toConvert / .03937007);
            return dblConverted;

        }
        /// <summary>
        /// Converts to mm (inch)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal in_to_mm(decimal toConvert)
        {
            decimal decConverted = (toConvert / (decimal).03937007);
            return decConverted;
            

        }
        /// <summary>
        /// Converts to Inches (mm)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double mm_to_in(double toConvert)
        {
            double dblConverted = (toConvert * .03937007);
            return dblConverted;
           

        }
        /// <summary>
        /// Converts  to Inches (mm)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal mm_to_in(decimal toConvert)
        {
            decimal decConverted = (toConvert * (decimal).03937007);
            return decConverted;
            

        }
        #endregion Conversions

        #region Area and Volume

        /// <summary>
        /// Calculates Area of circle (Rad in inches)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double Area_Circle_Rad_in(double dblRad)
        {
            double dblArea = (dblRad * 2) * Math.PI;
            return dblArea;

        }

        /// <summary>
        /// Calculates Area of circle (Rad in inches)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal Area_Circle_Rad_in(decimal decRad)
        {
            decimal decArea = (decRad * 2) * (decimal)Math.PI;
            return decArea;

        }

        /// <summary>
        /// Calculates Volume of Cyl (Rad in inches,Height)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double Vol_Cyl_Rad_in(double dblRad, double dblHgt)
        {
            double dblVolume = ((dblRad * 2) * Math.PI) * dblHgt;
            return dblVolume;

        }

        /// <summary>
        /// Calculates Volume of Cyl (Rad in inches,Height)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal Vol_Cyl_Rad_in(decimal decRad, decimal decHgt)
        {
            decimal decVolume = ((decRad * 2) * (decimal)Math.PI) * decHgt;
            return decVolume;

        }

        /////////
        /// <summary>
        /// Calculates Area of circle (Dia in inches)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double Area_Circle_Dia_in(double dblDia)
        {
            double dblArea = dblDia * Math.PI;
            return dblArea;

        }

        /// <summary>
        /// Calculates Area of circle (Dia in inches)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal Area_Circle_Dia_in(decimal decDia)
        {
            decimal decArea = decDia  * (decimal)Math.PI;
            return decArea;

        }

        /// <summary>
        /// Calculates Volume of Cyl (Dia in inches,Height)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static double Vol_Cyl_Dia_in(double dblDia, double dblHgt)
        {
            double dblVolume = (dblDia * Math.PI) * dblHgt;
            return dblVolume;

        }

        /// <summary>
        /// Calculates Volume of Cyl (Dia in inches,Height)
        /// </summary>
        /// <param name="toConvert"></param>
        /// <returns></returns>
        public static decimal Vol_Cyl_Dia_in(decimal decDia, decimal decHgt)
        {
            decimal decVolume = (decDia * (decimal)Math.PI) * decHgt;
            return decVolume;

        }



        #endregion Area and Volume

        #region String Stuff

      /// <summary>
      /// Takes string and returns SPLIT string array  (string to split, split char)
      /// </summary>
      /// <param name="strToSplit"></param>
      /// <param name="chrSplitter"></param>
      /// <returns></returns>
        public static string[] saSplit (string strToSplit, char chrSplitter)
        {
            string[] saToReturn = strToSplit.Split(new Char[] { chrSplitter });//splits string

            return saToReturn;
        }

        #endregion String Stuff

    }
}
