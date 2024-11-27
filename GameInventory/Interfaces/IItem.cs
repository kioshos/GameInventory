using GameInventory.Enums;

namespace GameInventory.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        string Descritpion { get; set; }
        ItemType ItemType { get; set; }
        float Weight { get; set; }
        bool IsStackable();
    }
}
