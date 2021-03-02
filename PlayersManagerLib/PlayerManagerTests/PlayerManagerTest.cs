using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;


namespace PlayerManagerTests
{
    [TestFixture]
    public class PlayerManagerTest
    {

        Mock<IPlayerMapper> mock;
        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IPlayerMapper>();
        }
        [Test]
        [TestCase("Test",21,"India",25)]
        public void PlayerDoesntExistInDB(string name,int age,string country,int noOfMatches)
        {
            mock.Setup(x=>x.IsPlayerNameExistsInDb(name)).Returns(false);
            Player p = new Player(name, age, country, noOfMatches);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
            Assert.AreEqual(name, p.Name);
            Assert.AreEqual(age, p.Age);
            Assert.AreEqual(country, p.Country);
            Assert.AreEqual(noOfMatches, p.NoOfMatches);

        } 

    }
}
