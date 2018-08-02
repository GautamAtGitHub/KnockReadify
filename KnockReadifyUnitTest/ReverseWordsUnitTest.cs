using KnockReadify.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockReadifyUnitTest
{
    [TestClass]
    public class ReverseWordsUnitTest
    {
        [TestMethod]
        public void TestMethodGetReverseWords()
        {
            using (ReverseWordsController controller = new ReverseWordsController())
            {
                var result = controller.Get("Hello Awesome Readify"); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result;

                Assert.AreEqual(StatusCodes.Status200OK, actionResult.StatusCode);
                Assert.AreEqual("olleH emosewA yfidaeR", actionResult.Value);
            }
        }

        [TestMethod]
        public void TestMethodGetReverseWordsNull()
        {
            using (ReverseWordsController controller = new ReverseWordsController())
            {
                var result = controller.Get(null); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result;

                Assert.AreEqual(StatusCodes.Status400BadRequest, actionResult.StatusCode);
            }
        }
    }
}
