using System;
using System.Collections.Generic;

namespace stockPurchaseDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks["CAT"] = "Caterpillar";
            stocks.Add("ORCL", "Oracle");
            stocks["MSFT"] = "Microsoft";
            stocks.Add("GMY", "Gummy Bears");
            stocks["TSLA"] = "Tesla";

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add(new Dictionary<string, double>(){ {"GE", 230.31} });
            purchases.Add(new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add(new Dictionary<string, double>(){ {"GE", 406.34} });
        }
    }
}
