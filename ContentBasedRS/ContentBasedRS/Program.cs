using System;
using System.Linq;

namespace ContentBasedRS
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Models.DataContext();

            var item = context.Fact_DirectSalesOrder.FirstOrDefault();

            Console.WriteLine(item.OrderDate);
        }
    }
}
