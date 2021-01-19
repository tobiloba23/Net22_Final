using System;

namespace Net22_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Subsccriber StockBroker = new Subsccriber("Securities Company");
            Service StockExchange = new Service("Stock prices");

            StockExchange.subscriptionList += StockBroker.onRequest;

            StockExchange.send(StockExchange.Product, StockBroker.Name);

        }
    }
}
