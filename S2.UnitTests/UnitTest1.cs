using S2.Oop2;
using System;
using System.Collections.Generic;
using Xunit;

namespace S2.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestContactInformation()
        {

            Assert.Throws<ArgumentException>
                (

                () => new ContanctInformation("asd.", "dtbfsnt4f")

                ); ;

        }

        [Fact]
        public void TestPerson()
        {

            Assert.Throws<ArgumentException>
                (

                () => new Person("afsfe ", new DateTime(1920,03,01), new ContanctInformation("asd.", "dtbfsnt4f"))

                );

        }

        [Fact]
        public void TestAdress()
        {

            Assert.Throws<ArgumentException>
                (

                () => new Address("adsg", "d3ffe", "", "Dgwer", "Dwerwr", new List<Person>() { new Person("afsfe ", new DateTime(1920, 03, 01)) })

                );

        }
    }
}
