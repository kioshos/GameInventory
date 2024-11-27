using GameInventory.Enums;
using GameInventory.Interfaces;
using GameInventory.Items;


namespace GameInventory.FirearmWeapons
{
    public class Pistol : IFirearmWeapon
    {
        
        private FirearmMagazine _magazine;

        public string Name { get; set; }
        public string Descritpion { get; set; }
        public ItemType ItemType { get; set; }
        public float Weight { get; set; }
        private bool IsShooting = true;
        Bullet bullet;
        public Pistol(string name, string description, ItemType itemType, float weight, FirearmMagazine magazine)
        {
            Name = name;
            Descritpion = description;
            ItemType = itemType;
            Weight = weight;
            _magazine = magazine;
        }

       
        public void Reload()
        {
            if (_magazine.CurrentMagazineCapacity < _magazine.MagazineCapacity)
            {
                int toReload = _magazine.MagazineCapacity - _magazine.CurrentMagazineCapacity;
                _magazine.LoadBullets(toReload, bullet);
                Console.WriteLine("Reloading bullets!");
                IsShooting = true;
            }
            else
            {
                Console.WriteLine("Magazine is already full!");
            }
        }


        public Pistol(FirearmMagazine magazine)
        {
            _magazine = magazine; 
        }

        public void Shoot()
        {
            if (_magazine.CurrentMagazineCapacity > 0)
            {
                while (IsShooting)
                {
                    Console.WriteLine("Shoot");
                    _magazine.CurrentMagazineCapacity -= 1;

                    if (_magazine.CurrentMagazineCapacity == 0)
                    {
                        Console.WriteLine($"You have to reload your {Name}");
                        IsShooting = false;
                    }
                }
            }
            else
            {
                Console.WriteLine($"No bullets in {Name}. Reload required!");
            }
        }

        
        public bool IsStackable() => true;
    }
}