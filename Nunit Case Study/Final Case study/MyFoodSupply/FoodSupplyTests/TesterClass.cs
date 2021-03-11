using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFoodSupply;
namespace FoodSupplyTests
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
        //Food Details Test
        [Test]
        [TestCase("Biryani",1,"2022/02/01",100.00)]
        [TestCase("Pizza",1,"2023/01/02",99.00)]
        [TestCase("Coke", 4, "2023/10/02", 30.00)]
        public void FoodDetail_ObjectCreation_Created(string name,int dishType,DateTime expiryDate,double price)
        {
            FoodDetail food = p.CreateFoodDetail(name, dishType, expiryDate, price);
            Assert.That(food.Name,Is.EqualTo(name));
            Assert.That(food.DishType, Is.EqualTo((FoodDetail.Category)dishType));
            Assert.That(food.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(food.Price, Is.EqualTo(price));
        }
        [Test]
        [TestCase("", 1, "2022/02/01", 100.00)]
        [TestCase(null, 1, "2023/01/02", 99.00)]
        public void FoodDetail_EmptyParameter_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var food = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(food.Message, Is.EqualTo("Dish name cannot be empty. Please provide valid value"));
        }
        [Test]
        [TestCase("Biryani", 1, "2022/02/01", 0)]
        [TestCase("Pizza", 1, "2023/01/02", -99.00)]
        public void FoodDetail_PriceLessThanZero_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var food = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(food.Message, Is.EqualTo("Incorrect value for dish price. Please provide valid value"));
        }
        [Test]
        [TestCase("Biryani", 1, "2020/02/01", 100.00)]
        [TestCase("Pizza", 1, "2019/01/02", 99.00)]
        public void FoodDetail_ExpiryDateLessThanCurrentDate_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var food = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(food.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }

        //Supply Details Test
        [Test]
        [TestCase(2,"2022/10/01", "Swiggy",5.00)]
        [TestCase(1,"2021/06/02","Zomato",7.00 )]
        [TestCase(1, "2021/10/02", "Dominos", 2.00)]
        public void SupplyDetail_ObjectCreation_Created(int count,DateTime requestDate,string sellerName,double packingCharge)
        {
            FoodDetail food = p.CreateFoodDetail("Pizza", 1, DateTime.Parse("2023/01/02"), 99.00);
            SupplyDetail supply = p.CreateSupplyDetail(count, requestDate, sellerName, packingCharge, food);
            Assert.AreEqual(typeof(SupplyDetail), supply.GetType());
            Assert.That(supply.Count, Is.EqualTo(count));
            Assert.That(supply.RequestDate, Is.EqualTo(requestDate));
            Assert.That(supply.SellerName, Is.EqualTo(sellerName));
            Assert.That(supply.FoodItem, Is.EqualTo(food));
        }
        [Test]
        [TestCase(0, "2022/10/01", "Swiggy", 5.00)]
        [TestCase(null, "2021/06/02", "Zomato", 7.00)]
        public void SupplyDetails_ItemCountLessThanOrZero_ThrowsException(int count, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = p.CreateFoodDetail("Pizza", 1, DateTime.Parse("2023/01/02"), 99.00);
            var supply = Assert.Throws<Exception>(() => p.CreateSupplyDetail(count, requestDate, sellerName, packingCharge,food));
            Assert.That(supply.Message, Is.EqualTo("Incorrect food item count. Please check"));
        }
        [Test]
        [TestCase(1, "2020/10/01", "Swiggy", 5.00)]
        [TestCase(2, "2019/06/02", "Zomato", 7.00)]
        public void SupplyDetails_RequestDateLessThanCurrentDate_ThrowsException(int count, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = p.CreateFoodDetail("Pizza", 1, DateTime.Parse("2023/01/02"), 99.00);
            var supply = Assert.Throws<Exception>(() => p.CreateSupplyDetail(count, requestDate, sellerName, packingCharge, food));
            Assert.That(supply.Message, Is.EqualTo("Incorrect food request date. Please provide valid value"));
        }
        [Test]
        [TestCase(1, "2020/10/01", "Swiggy", 5.00)]
        [TestCase(2, "2019/06/02", "Zomato", 7.00)]
        public void SupplyDetails_FoodItemNull_ThrowsException(int count, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = p.CreateFoodDetail("Pizza", 1, DateTime.Parse("2023/01/02"), 99.00);
            var supply = p.CreateSupplyDetail(count, requestDate, sellerName, packingCharge, food);
            Assert.AreEqual(supply, food);
        }
    }
}
