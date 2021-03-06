﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    enum Currencies { AUD = 1, CYN, DKK, EUR, INR, NZD, AED, GBP, USD, VND };

    /// <summary>
    /// GUI program that converts currencies.
    /// 
    /// Author Quintus Cardozo April 2015
    /// Student Number: n9703578
    /// 
    /// </summary>
    static class Currency_Exchange_Class {

        private static double[] xRates = { 0, 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };

        /// <summary>
        /// Provides country names and currency code which  can be used to initialise a Combo Box
        /// </summary>
        /// <returns> string array each elemnt of which contains the country name and three letter currency code</returns>
        public static string[] InitialiseComboBox() {

            string[] countries = {   "",
                                    "Australia (AUD)",
                                    "China (CNY)",
                                    "Denmark (DKK)",
                                    "Europe (EUR)",
                                    "India (INR)",
                                    "New Zealand (NZD)",
                                    "United Arab Emirates (AED)",
                                    "United Kingdom (GBP)",
                                    "United States (USD)",
                                    "Vietnam (VND)" };

            return countries;
        } //end InitialiseComboBox()             

        /// <summary>
        /// Converts the amount entered by the user to Australian dollars first and then converts that
        /// to the currency they want.
        /// </summary>
        /// <param name="from">User's currecy type</param>
        /// <param name="to">Cureency the user wants to convert to</param>
        /// <param name="amount">The amount the user entered</param>
        /// <returns></returns>
        public static double CurrencyConversion(Currencies from, Currencies to, double amount) {
            double amountAustralian = amount / xRates[(int)from];
            double convertedAmount = Math.Round(amountAustralian * xRates[(int)to], 4);
            return convertedAmount;
        }

    }//end class
}