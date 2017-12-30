using LifeLine.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Tests
{
    [TestClass]
    class BloodDonorRepositoryTest
    {
        BloodDonorRepository repo;
        [TestInitialize]
        public void TestSetUp()
        {

            BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new BloodDonorRepository();
        }
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = repo.GetBloodDonors();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }

}
