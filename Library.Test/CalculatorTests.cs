using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Library.Test
{
    public class CalculatorTests
    {
        Calc calculate = new Calc();

        [Theory]
        [InlineData("1+1", "11+")]
        void postfix_testInfixToPostfix(string infix, string expected) {
            List<string> token = calculate.TokenizeEquation(infix);
            List<string> expectedToken = new List<string>();
            foreach (char ch in expected) {
                expectedToken.Add(ch.ToString());
            }
            List<string> actual = calculate.toPostFix(token);
            Assert.Equal(actual, expectedToken);
        }
        [Theory]
        [InlineData("-5.78+-(4—2.23)+sin(0)xcos(1)/(1+tan(2xln(-3+2x(1.23+99.111))))", "-7.55")]
        void postfixEval_Test(string infix, string expected) {
            List<string> token = calculate.TokenizeEquation(infix);
            List<string> postfix = calculate.toPostFix(token);
            string result = calculate.PostFixEvaluator(postfix);

            Assert.Equal(expected, result);
        }
    }
}
