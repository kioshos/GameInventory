using GameInventory.Enums;
using GameInventory.Items;

namespace GameInventory
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Sword testSword = new Sword();
            Sword test1Sword = new Sword();
            Sword test2Sword = new Sword("Katana", "A very sharp object", WeaponType.Melee, ItemRarity.Legendary, 1.5f,2.5f);
            Console.WriteLine(testSword.ToString());
            Console.WriteLine(test1Sword.ToString());
            Console.WriteLine(test2Sword.ToString());
            test2Sword.Use();
        }
    }
}