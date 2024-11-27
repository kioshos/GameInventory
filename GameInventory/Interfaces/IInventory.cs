namespace GameInventory.Interfaces
{
    public interface IInventory
    {
        List<IItem> Items { get; }
        void AddItem();
        void RemoveItem();

    }
}
