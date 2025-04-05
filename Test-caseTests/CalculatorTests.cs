using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 3, -2)]
        [TestCase(100, 200, 300)]
        public void Add_TwoNumbers_ReturnsCorrectSum(int a, int b, int expected)
        {
            var calculator = new Calculator();
            int result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
