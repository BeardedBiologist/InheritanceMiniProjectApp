// Mini project to use inheritance and interfaces

namespace InheritanceMiniProject
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }

}