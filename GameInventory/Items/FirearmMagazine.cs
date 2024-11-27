using GameInventory.Enums;
using GameInventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory.Items
{
    public class FirearmMagazine : IFirearmMagazine, IItem
    {
        public BulletType BulletType { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public ItemType ItemType { get; set; }
        public float Weight { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentMagazineCapacity { get; set; }

        List<Bullet> _bullets = new List<Bullet>();
        
        public FirearmMagazine(string name, string descritpion, BulletType bulletType, int magazineCapacity)
        {
            Name = name;
            Descritpion = descritpion;
            CurrentMagazineCapacity = magazineCapacity;
            MagazineCapacity = magazineCapacity;
        }

        public FirearmMagazine()
        {
            CurrentMagazineCapacity = MagazineCapacity;
        }
        public FirearmMagazine(List<Bullet> bullets)
        {
          _bullets = bullets;     

        }

        public bool IsEmpty() => CurrentMagazineCapacity == 0;
        public bool IsFull() => CurrentMagazineCapacity == MagazineCapacity;
        public bool IsStackable() => true;

        public void LoadBullets(int amount, Bullet bullet)
        {
            if (CurrentMagazineCapacity + amount <= MagazineCapacity)
            {
                CurrentMagazineCapacity += amount;
                Console.WriteLine($"Loaded {amount} bullets.");
                
            }
            else
            {
                Console.WriteLine("Too many bullets! Can't overload the magazine.");
            }
        }

        public void UnloadBullet(Bullet bullet)
        {
            _bullets.Remove(bullet);
        }
    }
}