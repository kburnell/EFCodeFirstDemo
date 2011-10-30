using System.Data.Entity;
using EFCodeFirst.DataContext;
using EFCodeFirst.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFCodeFirst.Tests.Integration {

    [TestClass]
    public class EFCodeFirstTest {

        [TestMethod]
        public void SomeTest() {
            Database.SetInitializer(new TestDataContextInitializer());
            DataContext.DataContext dc = new DataContext.DataContext();
            Manufacturer manufacturer = dc.Manufacturers.Find(1);
            Assert.AreNotEqual(0, manufacturer.Models.Count);
            Assert.AreNotEqual(0, manufacturer.Models[0].AvailableEngines.Count);
            Assert.IsTrue(true);
        }
    }
}