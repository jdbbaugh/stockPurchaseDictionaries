using System;
using System.Collections.Generic;

namespace stockPurchaseDictionaries
{
    class Program
    {
        static void PrintDictionary(Dictionary<string, double> dict) {
            foreach(KeyValuePair<string, double> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GE", "General Electric");
            stocks["CAT"] = "Caterpillar";
            stocks.Add("ORCL", "Oracle");
            stocks["MSFT"] = "Microsoft";
            stocks.Add("GMY", "Gummy Bears");
            stocks["TSLA"] = "Tesla";

            foreach(KeyValuePair<string, string> stock in stocks) {
                // Console.WriteLine(stock.Value);
            }

            Console.WriteLine();


            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add(new Dictionary<string, double>(){ {"GE", 230.21} });
            purchases.Add(new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add(new Dictionary<string, double>(){ {"GE", 406.34} });
            purchases.Add(new Dictionary<string, double>(){ {"GM", 214.77} });
            purchases.Add(new Dictionary<string, double>(){ {"GM", 109.59} });
            purchases.Add(new Dictionary<string, double>(){ {"CAT", 493.32} });
            purchases.Add(new Dictionary<string, double>(){ {"CAT", 430.29} });
            purchases.Add(new Dictionary<string, double>(){ {"ORCL", 320.29} });
            purchases.Add(new Dictionary<string, double>(){ {"ORCL", 123.84} });
            purchases.Add(new Dictionary<string, double>(){ {"MSFT", 433.53} });
            purchases.Add(new Dictionary<string, double>(){ {"MSFT", 324.43} });
            purchases.Add(new Dictionary<string, double>(){ {"MSFT", 427.43} });
            purchases.Add(new Dictionary<string, double>(){ {"GMY", 12.40} });
            purchases.Add(new Dictionary<string, double>(){ {"GMY", 1.00} });
            purchases.Add(new Dictionary<string, double>(){ {"TSLA", 1322.44} });
            purchases.Add(new Dictionary<string, double>(){ {"TSLA", 13422.90} });

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach(Dictionary<string, double> purchase in purchases) {
                foreach(KeyValuePair<string, double> kvp in purchase) {
                    // Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
                        string stockBrand = stocks[kvp.Key];
                    if (!stockReport.ContainsKey(stockBrand)) {
                        stockReport.Add(stockBrand, kvp.Value);

                    } else {
                        stockReport[stockBrand] += kvp.Value;
                    }
                }

            }


            foreach(KeyValuePair<string, double> stock in stockReport) {
                Console.WriteLine($"The position in {stock.Key} is worth {stock.Value}");
            }
        }
    }
}
