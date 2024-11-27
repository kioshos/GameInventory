using GameInventory.Enums;
using GameInventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Interfaces
{
    public interface IFirearmMagazine
    {
        BulletType BulletType { get; set; }

        void LoadBullets(int count, Bullet bullet);
        void UnloadBullet(Bullet bullet);
        bool IsFull();
        bool IsEmpty();
    }
}