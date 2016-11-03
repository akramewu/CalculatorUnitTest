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
    }
}
