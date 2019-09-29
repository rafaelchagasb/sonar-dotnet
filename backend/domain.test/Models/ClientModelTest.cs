using domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.test.Models
{
    public class ClientModelTest
    {
        [Test]
        public void TestGetFirstName()
        {
            var client = new ClientModel()
            {
                FullName = "Jackson Rogers"
            };

            Assert.AreEqual("Jackson", client.FirstName);
        }
    }
}
