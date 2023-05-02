// Mini project to use inheritance and interfaces

namespace InheritanceMiniProject
{
    public class InventoryItemModel : IInventoryItem 
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }

}