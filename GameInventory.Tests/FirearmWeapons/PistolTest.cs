using GameInventory.FirearmWeapons;
using GameInventory.Items;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameInventory.Tests.FirearmWeapons;

[TestClass]
[TestSubject(typeof(Pistol))]
public class PistolTest
{

    [TestMethod] 
    public void Reload_WhenMagazineIsNotFull_ShouldReloadBullets()
    {
        // Arrange
        FirearmMagazine magazine = new FirearmMagazine(10);
        magazine.LoadBullets(5, new Bullet());
        Pistol pistol = new Pistol(magazine);

        // Act
        pistol.Reload();  

        // Assert
        Assert.AreEqual(10, magazine.CurrentMagazineCapacity); 
        
    }
}