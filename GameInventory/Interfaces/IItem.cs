using GameInventory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
