using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Configuration;

namespace ParsXtmlExamle
{
    class DatabaseHelper
    {
        private String stockName;
        private String letter;
        private String separator = "-";
        private static readonly string connectionString = 
            ConfigurationManager.ConnectionStrings["StocExchangeEntities"].ConnectionString;
        private String filePath;
       

        public DatabaseHelper(String stockName, String letter)
        {
            this.stockName = stockName;
            this.letter = letter;
            filePath = getFileName();
           
        }

        private string getFileName()
        {
            return stockName + separator + letter;
        }

        public void LoadCompaniesToDatabase(){

            Console.WriteLine("loading to db for lettter : " + letter);
            List<String> companiesToAdd = readAllSymbolsAndNames();
            
            ObjectContext context = new ObjectContext(connectionString);
            ObjectSet<Company> company = context.CreateObjectSet<Company>();
            Console.WriteLine("nr of records before persist : "+ company.Count() );

            for (int i = 0; i < companiesToAdd.Count; i+=2 )
            {
                Company c = new Company();
                c.Symbol = companiesToAdd[i];
                c.Name = companiesToAdd[i + 1];
                company.AddObject(c);
            }

            //Console.WriteLine(company.Count());
            //Company c = new Company();
           // c.Symbol = "CYST";
           // c.Name = "WAR";
         //   company.AddObject(c);

            try
            {
                context.SaveChanges();
            }
            catch (Exception e) 
            {
                Console.WriteLine("--catched : "  + e.Message);
            }



            ObjectSet<Company> company2 = context.CreateObjectSet<Company>();
            Console.WriteLine("after insering number of records is : " + company2.Count());
            context.Dispose();
            
        }

        //return all symbols and names for all companies
        private List<String> readAllSymbolsAndNames()
        {
            List<String> symbolsAndNames = new List<String>();

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0 || counter == 1)
                {
                  //  Console.WriteLine("adding : " + line);
                    symbolsAndNames.Add(line);
                    
                    
                }
                
                //Console.WriteLine(line);

                counter++;
                if (counter == 9)
                {
                    counter = 0;
                }

            }

            file.Close();

            Console.WriteLine("----------------------------");
          //  foreach (String s in symbolsAndNames)
          //      Console.WriteLine(s);

            return symbolsAndNames;
           
           
        }
      


        internal void LoadRecordsToDatabase()
        {
            List<String> recordsToAdd = readAllRecordsAndSymbol();
        }

        private List<string> readAllRecordsAndSymbol()
        {
            List<String> symbolAndRecordsData = new List<String>();

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                
                if (counter !=1 && counter !=7)
                {
                      Console.WriteLine("adding : " + line);
                    if(!String.IsNullOrEmpty(line))
                        symbolAndRecordsData.Add(line);


                }

                //Console.WriteLine(line);

                counter++;
                if (counter == 9)
                {
                    counter = 0;
                }

            }

            file.Close();

            Console.WriteLine("----------------------------");
            foreach (String s in symbolAndRecordsData)
                  Console.WriteLine(s);

            return symbolAndRecordsData;
        }
    }
}
