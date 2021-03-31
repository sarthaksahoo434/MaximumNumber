using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2._3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MaximumNumberCheck check = new MaximumNumberCheck();
            [TestMethod]
            //Act
            public void Given_MaxNumberAt1StPosition_WhenChecked_ThenReturn_SameNumber()
            {
                int expectedResult = 44;
                int result = MaximumNumberCheck.MaximumIntegerNumber(44, 33, 11);
                //Assert
                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            //Act
            public void Given_MaxNumberAt2ndPosition_WhenChecked_ThenReturn_SameNumber()
            {
                int expectedResult = 44;
                int result = MaximumNumberCheck.MaximumIntegerNumber(33, 44, 11);
                //Assert
                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            //Act
            public void Given_MaxNumberAt3rdPosition_WhenChecked_ThenReturn_SameNumber()
            {
                int expectedResult = 44;
                int result = MaximumNumberCheck.MaximumIntegerNumber(33, 11, 44);
                //Assert
                Assert.AreEqual(expectedResult, result);
            }

            [TestMethod]
            //Act
            public void Given_MaxFloatNumberAt1stPosition_WhenChecked_ThenReturn_SameNumber()
            {
                double expectedResult = 111.44;
                double result = MaximumNumberCheck.MaximumFloatNumber(111.44, 44.20, 33.65);
                //Assert
                Assert.AreEqual(expectedResult, result);
            }
    }
}
