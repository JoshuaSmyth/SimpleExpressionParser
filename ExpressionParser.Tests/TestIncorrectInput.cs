using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ExpressionParser.Tests
{
    [TestFixture]
    internal class TestIncorrectInput
    {
        private readonly RpnCalculator m_RpnCalculator = new RpnCalculator();

        [TestFixtureSetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(true);
        }



        [Test]
        [ExpectedException(typeof(ExpressionParserException))]
        public void TestInfixToRpn_001()
        {
            const string infixExpression = "cos(0.0";
            var evaluationContext = m_RpnCalculator.Compile(infixExpression);

            var ouput = m_RpnCalculator.Evaluate(evaluationContext);
            Assert.IsTrue(ouput == 1.0);
        }

        [Test]
        [ExpectedException(typeof(ExpressionParserException))]
        public void TestInfixToRpn_002()
        {
            const string infixExpression = "";
            var evaluationContext = m_RpnCalculator.Compile(infixExpression);
            var ouput = m_RpnCalculator.Evaluate(evaluationContext);

        }
    }
}
