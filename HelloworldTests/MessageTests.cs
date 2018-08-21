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
            //Etant donné l'instanciation d'un nouveau message
            Message test = new Message(9, 13, 18);

            //Lorsque qu'on appelle getHelloMessage
            DateTime date = new DateTime(2018,08,21,20,00,00);
            String result = test.getHelloMessage(date);

            //Alors l'utilisateur de l'ordinateur s'affiche
            Assert.IsTrue(result.Contains("Bonsoir"));

        }
    }
}