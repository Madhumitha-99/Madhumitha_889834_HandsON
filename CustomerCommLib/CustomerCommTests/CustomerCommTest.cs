using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;
namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTest
    {
        Mock<IMailSender> mock;
        CustomerComm com;
        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IMailSender>();
            com = new CustomerComm(mock.Object);
        }

        [Test]
        [TestCase("madhu@gmail.com","madhu",true)]
       
        public void Mail(string toAddress,string name,bool expected)
        {
            
            mock.Setup(x => x.SendMail(toAddress, name)).Returns(expected);
            bool actual = com.SendMailToCustomer(toAddress, name);
            Assert.AreEqual(expected, actual);
        }
    }
}
