using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// Mini project to use inheritance and interfaces

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public class InventoryItemModel
    {
        public string ProductName { get; set; }
    }

    public class VehicleModel : InventoryItemModel
    {
        public decimal DealerFee { get; set; }
    }

    public class BookModel : InventoryItemModel
    {
        public int NumberOfPages { get; set; }
    }

}