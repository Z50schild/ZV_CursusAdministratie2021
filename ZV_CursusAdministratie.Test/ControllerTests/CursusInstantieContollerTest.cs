using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using ZV_CursusAdministratie.Controllers;
using ZV_CursusAdministratie.Entities;
using ZV_CursusAdministratie.Repositories;

namespace ZV_CursusAdministratie.Test
{
    [TestClass]
    public class CursusInstantiecontrollerTest
    {
        [TestMethod]
        public void CursusInstantieController_GetCursusInstantie_NotNull()
        {
            //Arrange
            var mockRepository = new Mock<ICursusInstantieRepository>();
            var controller = new CursusInstantieController(mockRepository.Object);

            //Act
            var result = controller.GetAllCursusInstanties();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CursusInstatnieController_GetCursusInstantie_TypeOfIEnumerable()
        {
            //Arrange
            var mockRepository = new Mock<ICursusInstantieRepository>();
            var controller = new CursusInstantieController(mockRepository.Object);

            //Act
            var result = controller.GetAllCursusInstanties();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<CursusInstantie>));
        }
    }
}
