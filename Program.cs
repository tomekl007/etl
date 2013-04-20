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


            WebClient webClient = new WebClient();
            String filePath = @"\temp.html";
            webClient.DownloadFile("http://www.findata.co.nz/markets/NYSE/symbols/Q.htm", filePath);

         

            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();

            // There are various options, set as needed
            htmlDoc.OptionFixNestedTags = true;

            // filePath is a path to a file containing the html
            htmlDoc.Load(filePath);
          //  Console.WriteLine("" + htmlDoc.DocumentNode.SelectSingleNode("//body").InnerText);

            // Use:  htmlDoc.LoadHtml(xmlString);  to load from a string (was htmlDoc.LoadXML(xmlString)

            // ParseErrors is an ArrayList containing any errors from the Load statement
            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {
                Console.WriteLine("paresErrors != null" );
                foreach(var s  in htmlDoc.ParseErrors){
                    Console.WriteLine(s.Reason);
                }
                

            }
          
              
            FileHelper fileHelper = new FileHelper("NYSE","Q");
            //tr
            Console.WriteLine("TR----------------");
            HtmlNodeCollection allTr = htmlDoc.DocumentNode.SelectNodes("//tr");
            //HtmlNodeCollection allTd = htmlDoc.DocumentNode.SelectNodes("//tr//td");
            //Console.WriteLine("after reg-------->");
            //foreach (HtmlNode n in allTd)
              //  Console.WriteLine(n.InnerText);

            
           // bool firstIteration = true;//first element not put to file
            int i = 0;
            foreach (HtmlNode node in allTr)
            {

                if (i>=2)
                {
                    //Console.WriteLine(node.InnerText);
                   

                    HtmlNodeCollection allTdForTr = node.ChildNodes;
                    fileHelper.saveLineToFile( allTdForTr);
                }
                if (i < 2)
                    i++;

            }

            fileHelper.closeFile();
  

           

        }
    }
}
