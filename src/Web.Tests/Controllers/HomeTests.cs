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
            ContentResult result = controller.Index() as ContentResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
