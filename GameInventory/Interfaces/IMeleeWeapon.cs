using GameInventory.Enums;

namespace GameInventory.Interfaces
{
    public interface IMeleeWeapon : IWeapon
    {
        float AttackSpeed { get; set; }
        float CalculateMeleDamage(ItemRarity rarity, float weight, float attackSpeed);
        void Attack();
    }
}
