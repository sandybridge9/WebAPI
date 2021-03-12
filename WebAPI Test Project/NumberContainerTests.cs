using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Models;
using System.Linq;

namespace WebAPI_Test_Project
{
    [TestClass]
    public class NumberContainerTests
    {
        [TestMethod]
        public void Test_BubbleSort_CorrectOrder()
        {
            int[] testNumbers = new int[] { 5, 2, 8, 10, 1 };
            int[] expectedResults = new int[]{1, 2, 5, 8, 10};
            var testContainer = new NumberContainer() { Numbers = testNumbers };
            var actualResults = testContainer.BubbleSort();
            //Assert.AreEqual(expectedResults, actualResults, "The result array is not equal to the expected array.");
            Assert.IsTrue(expectedResults.SequenceEqual(actualResults));
        }

        [TestMethod]
        public void Test_QuickSort_CorrectOrder()
        {
            int[] testNumbers = new int[] { 5, 2, 8, 10, 1 };
            int[] expectedResults = new int[] { 1, 2, 5, 8, 10 };
            var testContainer = new NumberContainer() { Numbers = testNumbers };
            var actualResults = testContainer.QuickSort();
            //Assert.AreEqual(expectedResults, actualResults, "The result array is not equal to the expected array.");
            Assert.IsTrue(expectedResults.SequenceEqual(actualResults));
        }
    }
}
