using UC1_FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestFindMaximum
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        MaximumNumber check = new MaximumNumber();
        [TestMethod]
        //Act
        public void Given_MaxNumberAt1StPosition_WhenChecked_ThenReturn_SameNumber()
        {
            int expectedResult = 55;
            int result = MaximumNumber.MaximumIntegerNumber(10, 22, 55);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}