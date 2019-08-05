using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayGun;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Raygun gun;

        [TestMethod]
        public void TryShootBug()
        {

            Bug bug = new Bug();
            //Raygun gun = new Raygun();

            gun.FireAt(bug);

            Assert.IsTrue(bug.IsDead());
            Assert.IsTrue(gun.HasAmmo());
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void TryMakingHeapsOfGuns()
        {

            Raygun[] guns = new Raygun[5];
            Bug bug = new Bug();

            guns[5].FireAt(bug);

        }

        [TestInitialize]
        public void Initialize()
        {
            gun = new Raygun();
        }

        [TestCleanup]
        public void Cleanup()
        {
            gun.Recharge();
        }
    }
}
