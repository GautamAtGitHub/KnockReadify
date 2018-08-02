using KnockReadify.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockReadifyUnitTest
{
    [TestClass]
    public class FibonacciUnitTest
    {
        [TestMethod]
        public void TestMethodGetFibonacciValid()
        {
            using (FibonacciController controller = new FibonacciController())
            {
                var result = controller.Get(10); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result;

                Assert.AreEqual(StatusCodes.Status200OK, actionResult.StatusCode);
                Assert.AreEqual("55", actionResult.Value);
            }
        }

        [TestMethod]
        public void TestMethodGetFibonacciNegative()
        {
            using (FibonacciController controller = new FibonacciController())
            {
                var result = controller.Get(-5); //Negative input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result;

                Assert.AreEqual(StatusCodes.Status400BadRequest, actionResult.StatusCode);
            }
        }
    }
}
