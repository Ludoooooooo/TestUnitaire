using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTest


{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        [TestMethod]

        public void TestGetBoldFormat()
        {
            //Arrange
            var htmlformathelper = new HtmlFormatHelper();
            string content = "Test en Gras";
            string expectedResult = $"<b>{content}</b>";

            // Act
            string result = htmlformathelper.GetBoldFormat(content);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestGetItalicFormat()
        {
            //Arrange
            var htmlformathelper = new HtmlFormatHelper();
            string content = "Test en Italique";
            string expectedResult = $"<i>{content}</i>";

            // Act
            string result = htmlformathelper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
