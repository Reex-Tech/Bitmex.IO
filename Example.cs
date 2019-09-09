using System;
using BitMEX.IO;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    class Program
    {

        public static string bitmexKey = "APIKEY_TESTNET";
        public static string bitmexSecret = "SECRETAPI_TESTNET";
        


        static void Main(string[] args)
        {
            BitmexApi bitmex = new BitmexApi(bitmexKey, bitmexSecret, "testnet");
            var orders = bitmex.GetOrders("XBTUSD");
            Console.WriteLine(orders);
            Console.ReadLine();
        }
    }
}
