using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadacha01;

namespace BankAcoountTests
{
    public class BankAccountTests
    {
        [TestFixture]
        public class BankAcountTests
        {
            [Test]
            public void AcountInitializeWithPositiveValue()
            {
                BankAccount acount = new BankAccount(2000m);
                Assert.AreEqual(2000m, acount.Balance);
            }
        }
    }
}
