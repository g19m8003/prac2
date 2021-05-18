using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenResettingHouseSeedCountIs4()
        {
            //Arrange:
            House hs= new House (0,0);
            //Act:
            hs.ResetHouse();
            //Assert:
            Assert.AreEqual(4,hs.GetCount(),"When we reset a house it should have 4 seeds");
        }
    }
}