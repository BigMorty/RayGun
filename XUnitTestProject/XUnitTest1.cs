using RayGun;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TryShootBugX()
        {

            Bug bug = new Bug();
            Raygun gun = new Raygun();

            gun.FireAt(bug);

            Assert.True(bug.IsDead());
            Assert.True(gun.HasAmmo());
        }

        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void TestBugDodges(bool didDodge, bool shouldBeDead)
        {

            Bug bug = new Bug();
            Raygun gun = new Raygun();

            if (didDodge)
            {
                bug.Dodge();
            }

            gun.FireAt(bug);

            if (shouldBeDead)
            {
                Assert.True(bug.IsDead());
            }
            else
            {
                Assert.False(bug.IsDead());
            }
        }
    }
}
