using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Web.Controllers;

namespace Web.Tests.Controllers
{
    [TestClass]
    public class HomeCTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
