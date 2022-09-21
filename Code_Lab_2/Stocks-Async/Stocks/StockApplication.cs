using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Stock
{
    class StockApplication
    {
        static async Task Main(string[] args)
        {
            //prints titles to the console and file destination
            //string docPath = @"C:\Users\cliao\source\repos\test1\Stock\Lab1_output.txt";
            //string docPath = @"C:\Users\samga\Documents\School\CECS 475\Labs\Lab 1\Lab1_output.txt";
            string docPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lab1_output.txt");
            string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + "Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";
            using (FileStream fs = File.Create(docPath)) { }   
            Console.WriteLine(titles);
            using (StreamWriter outputFile = new StreamWriter(docPath, true))
            {
                outputFile.WriteLine(titles);
            }

            var tasks = new List<Task>();

            StockBroker b1 = new StockBroker("Broker 1");
            StockBroker b2 = new StockBroker("Broker 2");
            StockBroker b3 = new StockBroker("Broker 3");
            StockBroker b4 = new StockBroker("Broker 4");

            //starts creating the stocks and brokers
            Stock stock1 = new Stock("Technology", 160, 5, 15);
            Stock stock2 = new Stock("Retail", 30, 2, 6);
            Stock stock3 = new Stock("Banking", 90, 4, 10);
            Stock stock4 = new Stock("Commodity", 500, 20, 50);

            
            //b1.AddStock(stock1);
            //b1.AddStock(stock2);
            tasks.Add(b1.AddStock(stock1));
            tasks.Add(b1.AddStock(stock2));
           

            
            //b2.AddStock(stock1);
            //b2.AddStock(stock3);
            //b2.AddStock(stock4);
            tasks.Add(b2.AddStock(stock1));
            tasks.Add(b2.AddStock(stock3));
            tasks.Add(b2.AddStock(stock4));

            
            //b3.AddStock(stock1);
            //b3.AddStock(stock3);
            tasks.Add(b3.AddStock(stock1));
            tasks.Add(b3.AddStock(stock3));

            
            //b4.AddStock(stock1);
            //b4.AddStock(stock2);
            //b4.AddStock(stock3);
            //b4.AddStock(stock4);
            tasks.Add(b4.AddStock(stock1));
            tasks.Add(b4.AddStock(stock2));
            tasks.Add(b4.AddStock(stock3));
            tasks.Add(b4.AddStock(stock4));

            await Task.WhenAll(tasks);
        }
    }
}