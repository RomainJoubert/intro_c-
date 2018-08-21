using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void MessageTest()
        {
        }

        [TestMethod()]
        public void getHelloMessageTest_bonsoir()
        {
            DateTime date = new DateTime(2018, 08, 23, 19, 00, 00);
            Message test = new Message(new FakeDateTime(date));
            String result = test.getHelloMessage();
            Assert.IsTrue(result.Contains("Bonsoir"));

        }

        [TestMethod()]
        public void getHelloMessageTest_bonjour()
        {
            DateTime date = new DateTime(2018, 08, 23, 10, 00, 00);
            Message test = new Message(new FakeDateTime(date));
            String result = test.getHelloMessage();
            Assert.IsTrue(result.Contains("Bonjour"));
        }

        [TestMethod()]
        public void getHelloMessageTest_bonaprem()
        {
            DateTime date = new DateTime(2018, 08, 23, 15, 00, 00);
            Message test = new Message(new FakeDateTime(date));
            String result = test.getHelloMessage();
            Assert.IsTrue(result.Contains("Bon après-midi"));

        }


        [TestMethod()]
        public void getHelloMessageTest_weekend()
        {
            DateTime date = new DateTime(2018, 08, 27, 08, 59, 00);
            Message test = new Message(new FakeDateTime(date));
            String result = test.getHelloMessage();
            Assert.IsTrue(result.Contains("Bon weekend"));

        }
    }
}