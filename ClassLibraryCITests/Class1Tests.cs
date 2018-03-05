using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCI.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            //Arrange
            Class1 myName = new Class1();
            //Act
            string hello = myName.GetName();
            //Assert
            Assert.AreEqual("Linda", hello);
        }

        [TestMethod()]
        public void GetAddressTest()
        {
            //Arrange
            Class1 myAddress = new Class1();
            //Act
            string elisagaardsvej = myAddress.GetAddress();
            //Assert
            Assert.AreEqual("Gartnervang", elisagaardsvej );
        }
    }
}