using GameInventory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Interfaces
{
    public interface IMeleWeapon : IWeapon
    {
        float AttackSpeed { get; set; }
        float CalculateMeleDamage(ItemRarity rarity, float weight, float attackSpeed);
    }
}
