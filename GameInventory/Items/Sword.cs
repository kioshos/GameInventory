using GameInventory.Enums;
using GameInventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Items
{
    /// <summary>
    /// TODO: Builder
    /// </summary>
    public class Sword : IMeleWeapon, IWeapon, IItem
    {
        private static int _id = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public WeaponType Type { get; set; }
        public float Weight { get; set; }
        public ItemRarity Rarity { get; set; }
        public float Damage { get; set; }
        public float AttackSpeed { get; set; }

        public Sword()
        {
            Id = _id++;
            Name = "Rusty sword";
            Descritpion = "Just an old rusty sword";
            Type = WeaponType.Melee;
            Weight = 2.2f;
            Damage = 2f;
            AttackSpeed = 1f;
        }
        
        public Sword(string name, string description, WeaponType type,  ItemRarity rarity, float weight, float attackSpeed)
        {
            Id = _id++;
            Name = name;
            Descritpion = description;
            Type = type;
            Weight= weight;
            Damage = CalculateMeleDamage(rarity, weight, attackSpeed);
            Rarity = rarity;
            AttackSpeed = attackSpeed;
        }

        public float CalculateMeleDamage(ItemRarity rarity, float weight, float attackSpeed)
        {
            float damage = 2.0f;
            float rarityMultiplier = 1.0f;

            switch (rarity)
            {
                case ItemRarity.Common:
                    rarityMultiplier = 1.0f;
                    break;
                case ItemRarity.Uncommon:
                    rarityMultiplier = 1.2f;
                    break;
                case ItemRarity.Rare:
                    rarityMultiplier = 1.6f;
                    break;
                case ItemRarity.Epic:
                    rarityMultiplier = 2.0f;
                    break;
                case ItemRarity.Legendary:
                    rarityMultiplier = 2.3f;
                    break;
                case ItemRarity.Mythic:
                    rarityMultiplier = 3.0f;
                    break;
            }
            return damage * rarityMultiplier * (attackSpeed / weight);
        }
        public bool IsStackable() => false;

        public void Use()
        {
            Console.WriteLine($"You attacked the enemy with your {Name} sword. Dealt {Damage:F2} damage.");
        }

        public override string ToString()
        {
            return $"Sword: \nId: {Id}, \nName: {Name}, \nDamage: {Damage:F2}, \nRarity: {Rarity}, \nAttackSpeed: {AttackSpeed}\n";
        }


    }
}
