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
        //[TestMethod()]
        //public void MessageTest()
        //{
        //}

        [TestMethod()]
        public void getHelloMessageTest_bonsoir()
        {
            //Etant donné l'instanciation d'un nouveau message
            Message test = new Message(9, 13, 18);

            //Lorsque qu'on appelle getHelloMessage et que j'instancie une nouvelle date avec comme horaire 20h
            DateTime date = new DateTime(2018, 08, 23, 20, 00, 00);
            String result = test.getHelloMessage(date);

            //Alors "Bonsoir" s'affiche
            Assert.IsTrue(result.Contains("Bonsoir"));

        }

        [TestMethod()]
        public void getHelloMessageTest_bonjour()
        {
            //Etant donné l'instanciation d'un nouveau message
            Message test = new Message(9, 13, 18);

            //Lorsque qu'on appelle getHelloMessage et que j'instancie une nouvelle date avec comme horaire 10h
            DateTime date = new DateTime(2018, 08, 23, 10, 00, 00);
            String result = test.getHelloMessage(date);

            //Alors "Bonjour" s'affiche
            Assert.IsTrue(result.Contains("Bonjour"));
        }

        [TestMethod()]
        public void getHelloMessageTest_bonaprem()
        {
            //Etant donné l'instanciation d'un nouveau message
            Message test = new Message(9, 13, 18);

            //Lorsque qu'on appelle getHelloMessage et que j'instancie une nouvelle date avec comme horaire 15h
            DateTime date = new DateTime(2018, 08, 23, 15, 00, 00);
            String result = test.getHelloMessage(date);

            //Alors "Bonjour" s'affiche
            Assert.IsTrue(result.Contains("Bon après-midi"));

        }


        [TestMethod()]
        public void getHelloMessageTest_weekend()
        {
            //Etant donné l'instanciation d'un nouveau message
            Message test = new Message(9, 13, 18);

            //Lorsque qu'on appelle getHelloMessage et que j'instancie une nouvelle date avec comme horaire 10h mais un samedi
            DateTime date = new DateTime(2018, 08, 25, 10, 00, 00);
            String result = test.getHelloMessage(date);

            //Alors "Bonjour" s'affiche
            Assert.IsTrue(result.Contains("Bon weekend"));

        }
    }
}