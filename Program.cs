using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace ParsXtmlExamle
{
    class Program
    {

        static List<string> alphabet = new List<string>();
        static List<string> stocks = new List<string>();


        static void Main(string[] args)
        {
            //initialization 
            for (char ch = 'A'; ch <= 'Z'; ch++){
                alphabet.Add(ch.ToString());
            }


            stocks.Add("NYSE");
            stocks.Add("NASDAQ");
            stocks.Add("AMEX");

            // * is placeholder to replace by stock and ^ for letter
            String baseUrl = "http://www.findata.co.nz/markets/*/symbols/^";

            Extractor ex = new Extractor(baseUrl, stocks[0], alphabet[22],".htm");
            ex.Extract();

         

           

           

        }
    }
}
