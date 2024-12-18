﻿using GameInventory.Enums;
using GameInventory.Interfaces;

namespace GameInventory.Items
{
    /// <summary>
    /// TODO: Builder
    /// </summary>
    public class Sword : IMeleeWeapon, IItem
    {
        private static int _id = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public WeaponTypes Type { get; set; }
        public float Weight { get; set; }
        public ItemRarity Rarity { get; set; }
        public float Damage { get; set; }
        public float AttackSpeed { get; set; }
        public ItemType ItemType { get; set; }

        public Sword()
        {
            Id = _id++;
            Name = "Rusty sword";
            Descritpion = "Just an old rusty sword";
            Type = WeaponTypes.Melee;
            Weight = 2.2f;
            Damage = 2f;
            AttackSpeed = 1f;
            ItemType = ItemType.Weapon;
        }
        
        public Sword(string name, string description, WeaponTypes type,  ItemRarity rarity, float weight, float attackSpeed)
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

        public void Attack()
        {
            Console.WriteLine($"You attacked the enemy with your {Name} sword. Dealt {Damage:F2} damage.");
        }
        public void DisplayDamage()
        {
           Console.WriteLine($"Damage of {Name} = {Damage:F2}");
        }
        public override string ToString()
        {
            return $"Sword: \nId: {Id}, \nName: {Name}, \nDamage: {Damage:F2}, \nRarity: {Rarity}, \nAttackSpeed: {AttackSpeed}\n";
        }

        public bool IsStackable() => false;

       }
}
