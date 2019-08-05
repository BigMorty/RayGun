using NUnit.Framework;
using RayGun;

namespace Tests
{
    [TestFixture]
    public class NUnitTests
    {
        Raygun gun;

        [Test]
        public void TryShootDodgingBug()
        {

            Bug bug = new Bug();
            //Raygun gun = new Raygun();

            bug.Dodge();
            gun.FireAt(bug);

            bug.Dodge();
            gun.FireAt(bug);

            bug.Dodge();
            gun.FireAt(bug);

            Assert.IsFalse(bug.IsDead());
            Assert.IsFalse(gun.HasAmmo());
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void FireMultipleTimes(int fireCount)
        {

            Bug bug = new Bug();
            //Raygun gun = new Raygun();

            for (int i = 0; i < fireCount; i++)
            {
                gun.FireAt(bug);
            }

            if (fireCount >= 3)
            {
                Assert.IsFalse(gun.HasAmmo());
            }
            else
            {
                Assert.IsTrue(gun.HasAmmo());
            }
        }

        [SetUp]
        public void Setup()
        {
            gun = new Raygun();
        }
    }
}