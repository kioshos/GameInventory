using GameInventory.Enums;
using GameInventory.Items;

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