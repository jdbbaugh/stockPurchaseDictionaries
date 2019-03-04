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
            stocks["GE"] = "General Electric";

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add(new Dictionary<string, double>(){ {"GE", 230.31} });
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
            purchases.Add(new Dictionary<string, double>(){ {"TSLA", 1322.44} });
            purchases.Add(new Dictionary<string, double>(){ {"TSLA", 13422.90} });

            Dictionary<string, double> valuation = new Dictionary<string, double>();

            foreach(Dictionary<string, double> purchase in purchases) {

            }
        }
    }
}
