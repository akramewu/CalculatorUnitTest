using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(3, 5);

            Assert.That(result,Is.EqualTo(8));
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Subtract(5, 3);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void ShouldCheckStringValue()
        {
            var sut = new SimpleCalculator();
            
            var fullName = sut.String("Akramul","Islam");

            Assert.That(fullName, Is.EqualTo("Akramul Islam"));
        }
    }
}
