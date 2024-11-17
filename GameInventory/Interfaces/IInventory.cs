using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Interfaces
{
    public interface IInventory
    {
        List<IItem> Items { get; }
        void AddItem();
        void RemoveItem();

    }
}
