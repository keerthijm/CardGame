using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame;
using CardGame.Controllers;
using CardGame.Models;

namespace CardGame.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
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

        [TestMethod]
        public void Index1S()
        {
            // Arrange
            HomeController controller = new HomeController();

           
            // Act
            ViewResult result = controller.Index("1S") as ViewResult;

            

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.NotRecognised, result.ViewBag.Message);
        }

        [TestMethod]
        public void Index2B()
        {
            // Arrange
            HomeController controller = new HomeController();


            // Act
            ViewResult result = controller.Index("2B") as ViewResult;



            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.NotRecognised, result.ViewBag.Message);
        }

        [TestMethod]
        public void Index2S1S()
        {
            // Arrange
            HomeController controller = new HomeController();


            // Act
            ViewResult result = controller.Index("2S,1S") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.NotRecognised, result.ViewBag.Message);
        }

        [TestMethod]
        public void Index3H3H()
        {
            // Arrange
            HomeController controller = new HomeController();
            
            // Act
            ViewResult result = controller.Index("3H,3H") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.Duplicated, result.ViewBag.Message);
        }

        [TestMethod]
        public void Index4D5D4D()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("4D,5D,4D") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.Duplicated, result.ViewBag.Message);
        }

        [TestMethod]
        public void IndexJRJRJR()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("JR,JR,JR") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.TowJokers, result.ViewBag.Message);
        }

        [TestMethod]
        public void Index2S3D()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("2S|3D") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            // Assert
            Assert.AreEqual(ErrorMessage.InvalidInputString, result.ViewBag.Message);
        }


        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
