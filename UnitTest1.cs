using Microsoft.VisualStudio.TestTools.UnitTesting;
using labss;

namespace labssTest
{
    [TestClass]
    public class RandomNumberGeneratorTests
    {
        [TestMethod]
        public void TestRandomNumberGeneration()
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();

            int randomNumber = generator.GenerateRandomNumber();

            Assert.IsTrue(randomNumber >= 1 && randomNumber <= 700);
        }
    }

}
