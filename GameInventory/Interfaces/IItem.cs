using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Interfaces
{
    public interface IItem
    {
        bool IsStackable();
        void Use();
    }
}
