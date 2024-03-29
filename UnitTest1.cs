using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using labss;

namespace LabbTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateRandomArray()
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int [] array = randomNumberGenerator.GenerateRandomArray();

            Assert.IsNotNull(array);
            Assert.AreEqual(array.Length, 8);

            foreach (int num in array)
            {
                Assert.IsTrue(num >= 1 && num <= 700);
            }
        }
    }
}
