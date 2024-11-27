using GameInventory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Interfaces
{
    public interface IWeapon
    {
        WeaponTypes Type { get; set; }
        ItemRarity Rarity { get; set; }
        float Damage { get; set; }

        void DisplayDamage();
    }
}
