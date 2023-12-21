using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTest
{
    [TestClass]
    public class CustomStackTest
    {
        [TestMethod]
        public void TestCount()
        {
            //Arrange
            var customstack = new CustomStack();

            //Act
            var result = customstack.Count();

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestPush()
        {
            //Arrange
            int value = 1;
            var customstack = new CustomStack();
            

            //Act
            customstack.Push(value);

            //Assert
            Assert.AreEqual(1, customstack.Push);
        }
    }
}
