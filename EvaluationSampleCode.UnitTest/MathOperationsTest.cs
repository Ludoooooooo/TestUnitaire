using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTest
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        [DataRow(1, 1, 2)]
        public void TestAdd(int numberOne, int numberTwo, int expectedResult)
        {
            //Arrange
            var mathoperations = new MathOperations();

            // Act
            var result = mathoperations.Add(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, 5, 2)]
        //[DataRow(100, 5, 5)]    //Pour voir si ça marche
        public void TestDivide(int numberOne, int numberTwo, int expectedResult)
        {
            //Arrange
            var mathoperations = new MathOperations();

            // Act
            var result = mathoperations.Divide(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestClass]
        public class TestGetOddNumbers
        {
            [TestMethod]
            public void GetOddNumbers_LimitPos()
            {
                // Arrange
                int limit = 20;
                var limitepos = new MathOperations();

                // Act
                var result = limitepos.GetOddNumbers(limit);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual((limit / 2), result.Count()); // cb d'élem dans la liste
                Assert.IsTrue(result.All(num => num % 2 != 0));
            }
        }
    }
}
