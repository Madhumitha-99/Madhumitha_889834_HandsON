using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;
using NUnit.Framework;
namespace GenericMedicineTests
{
    [TestFixture]
    public class TesterClass
    {
        Program p;
        [OneTimeSetUp]
        public void Init()
        {
            p = new Program();
        }

        //MedicineDetails Test
        [Test]
        [TestCase("Medicine1","GenericName","Composition","2021/10/10",120.00)]
        [TestCase("Medicine2", "GenericName2", "Composition2", "2023/05/01", 240.00)]
        [TestCase("Medicine3", "GenericName3", "Composition3", "2022/11/05", 50.00)]
        public void CreateMedicine_ObjectCreation_Created(string name,string genericName,string composition,DateTime expiryDate,double price)
        {
            Medicine med = p.CreateMedicineDetail(name, genericName, composition, expiryDate, price);
            Assert.That(med.Name, Is.EqualTo(name));
            Assert.That(med.GenericMedicineName, Is.EqualTo(genericName));
            Assert.That(med.Composition, Is.EqualTo(composition));
            Assert.That(med.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(med.PricePerStrip, Is.EqualTo(price));
        }
        [Test]
        [TestCase("Medicine1", "", "Composition", "2021/10/10", 120.00)]
        [TestCase("Medicine2", null, "Composition2", "2023/05/01", 240.00)]
        public void CreateMedicine_CalledWithEmptyParameter_ThrowsException(string name, string genericName, string composition, DateTime expiryDate, double price)
        {
            var med = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericName, composition, expiryDate, price));
            Assert.That(med.Message, Is.EqualTo("Generic Medicine name cannot be empty. Please provide valid value"));
        }
        [Test]
        [TestCase("Medicine1", "GenericName", "Composition", "2021/10/10", -50.00)]
        [TestCase("Medicine2", "GenericName2", "Composition2", "2023/05/01", -20.00)]
        [TestCase("Medicine3", "GenericName3", "Composition3", "2022/11/05", 0)]
        public void CreateMedicine_CalledWithLessThanZero_ThrowsException(string name, string genericName, string composition, DateTime expiryDate, double price)
        {
            var med = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericName, composition, expiryDate, price));
            Assert.That(med.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }
        [Test]
        [TestCase("Medicine1", "GenericName", "Composition", "2022/10/10", 50.00)]
        [TestCase("Medicine2", "GenericName2", "Composition2", "2019/05/01", 240.00)]
        [TestCase("Medicine3", "GenericName3", "Composition3", "2017/11/05", 150.00)]
        public void CreateMedicine_DateLessThanExpiryDate_ThrowsException(string name, string genericName, string composition, DateTime expiryDate, double price)
        {
            var med = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericName, composition, expiryDate, price));
            Assert.That(med.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }

        //CartonDetails Test
        [Test]
        [TestCase(10,"2022/10/01","Chennai")]
        [TestCase(20, "2021/05/01", "Bangalore")]
        [TestCase(5, "2021/10/01", "Mumbai")]
        public void CreateCarton_ObjectCreation_Created(int stripCount,DateTime launchDate,string retailerAddress)
        {
            Medicine med = p.CreateMedicineDetail("Medicine1", "GenericName", "Compostion", DateTime.Parse("2022/12/01"), 100.00);
            CartonDetail cart = p.CreateCartonDetail(stripCount,launchDate,retailerAddress,med);
            Assert.That(cart.MedicineStripCount, Is.EqualTo(stripCount));
            Assert.That(cart.LaunchDate, Is.EqualTo(launchDate));
            Assert.That(cart.RetailerAddress, Is.EqualTo(retailerAddress));
            Assert.That(cart.Medicine, Is.EqualTo(med));
        }
        [Test]
        [TestCase(0, "2022/10/01", "Chennai")]
        [TestCase(null, "2021/05/01", "Bangalore")]
        public void Carton_CalledWithLessThanZeroValue_ThrowsException(int stripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = p.CreateMedicineDetail("Medicine1", "GenericName", "Compostion", DateTime.Parse("2022/12/01"), 100.00);
            var cart = Assert.Throws<Exception>(() => p.CreateCartonDetail(stripCount, launchDate, retailerAddress, med));
            Assert.That(cart.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }
        [Test]
        [TestCase(10, "2020/10/01", "Chennai")]
        [TestCase(20, "2021/01/01", "Bangalore")]
        [TestCase(5, "2019/07/01", "Mumbai")]
        public void Carton_LaunchDateLessThanCurrentDate_ThrowsException(int stripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = p.CreateMedicineDetail("Medicine1", "GenericName", "Compostion", DateTime.Parse("2022/12/01"), 100.00);
            var cart = Assert.Throws<Exception>(() => p.CreateCartonDetail(stripCount, launchDate, retailerAddress, med));
            Assert.That(cart.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }
        [Test]
        [TestCase(10, "2020/10/01", "Chennai")]
        [TestCase(20, "2021/01/01", "Bangalore")]
        [TestCase(5, "2019/07/01", "Mumbai")]
        public void Carton_NullMedicineObject_ThrowsException(int stripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = null;
            CartonDetail cart = p.CreateCartonDetail(stripCount, launchDate, retailerAddress, med);
            Assert.AreEqual(med,cart);
        }
    }
}
