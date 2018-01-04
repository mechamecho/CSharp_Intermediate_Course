using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new OrderProcessor {DatePlace = DateTime.Now, TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }
}
