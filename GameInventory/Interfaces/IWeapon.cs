using GameInventory.Enums;

namespace GameInventory.Interfaces
{
    public interface IWeapon : IItem
    {
        WeaponTypes Type { get; set; }
        ItemRarity Rarity { get; set; }
        float Damage { get; set; }

        void DisplayDamage();
    }
}
