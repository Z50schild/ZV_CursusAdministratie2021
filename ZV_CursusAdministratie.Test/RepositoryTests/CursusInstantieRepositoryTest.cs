using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Entities;
using ZV_CursusAdministratie.Repositories;

namespace ZV_CursusAdministratie.Test.RepositoryTests
{
    [TestClass]
    public class CursusInstantieRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var testData = GetCursusInstantieList(3);
            var dbSetMock = new Mock<DbSet<CursusInstantie>>();
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.Provider).Returns(testData.AsQueryable().Provider);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.Expression).Returns(testData.AsQueryable().Expression);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.ElementType).Returns(testData.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.GetEnumerator()).Returns(testData.AsQueryable().GetEnumerator());

            var context = new Mock<CursusAdminContext>();
            context.Setup(s => s.Set<CursusInstantie>()).Returns(dbSetMock.Object);

            //Act
            var repository = new CursusInstantieRepository(context.Object);
            var result = repository.GetAllCursusInstanties();

            //Assert
            CollectionAssert.AreEqual(testData, result.ToList());
        }

        public Cursus GetCursus(int number = 1)
        {
            return new Cursus
            {
                Id = number,
                Titel = $"Cursus{number}",
                Code = $"cs{number}",
                Duur = 5,
                CursusInstanties = new List<CursusInstantie>()
            };
        }

        public CursusInstantie GetCursusInstantie(int number = 1)
        {
            return new CursusInstantie
            {
                Id = number,
                Cursus = GetCursus(number),
                CursusId = GetCursus(number).Id,
                Startdatum = new DateTime(2020, 03, 14)
            };
        }

        public List<CursusInstantie> GetCursusInstantieList( int count = 1)
        {
            var testList = new List<CursusInstantie>();
            for (var i=1; i<= count; i++)
            {
                testList.Add(GetCursusInstantie(i));
            }
            return testList;
        }
    }
}
