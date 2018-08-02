using KnockReadify.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockReadifyUnitTest
{
    [TestClass]
    public class TriangleTypeUnitTest
    {
        [TestMethod]
        public void TestMethodGetTriangleTypeScalene()
        {
            using (TriangleTypeController controller = new TriangleTypeController())
            {
                var result = controller.Get(5, 7, 10); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result.Result;

                Assert.AreEqual(StatusCodes.Status200OK, actionResult.StatusCode);
                Assert.AreEqual("Scalene", actionResult.Value);
            }
        }

        [TestMethod]
        public void TestMethodGetTriangleTypeIsoceles()
        {
            using (TriangleTypeController controller = new TriangleTypeController())
            {
                var result = controller.Get(5, 5, 8); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result.Result;

                Assert.AreEqual(StatusCodes.Status200OK, actionResult.StatusCode);
                Assert.AreEqual("Isosceles", actionResult.Value);
            }
        }

        [TestMethod]
        public void TestMethodGetTriangleTypeEquilateral()
        {
            using (TriangleTypeController controller = new TriangleTypeController())
            {
                var result = controller.Get(5, 5, 5); // Positive input

                //Assert
                Assert.IsInstanceOfType(result, typeof(IActionResult));

                ObjectResult actionResult = (ObjectResult)result.Result;

                Assert.AreEqual(StatusCodes.Status200OK, actionResult.StatusCode);
                Assert.AreEqual("Equilateral", actionResult.Value);
            }
        }
    }
}
