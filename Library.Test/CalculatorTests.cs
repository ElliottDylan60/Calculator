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
        [InlineData("1+1", "1 1 +")]
        [InlineData("-5.78+-(4—2.23)+sin(0)xcos(1)/(1+tan(2xln(-3+2x(1.23+9.111))))", "5.78 - 4 2.23 — - + 0 sin 1 cos x 1 2 3 - 2 1.23 9.111 + x + ln x tan + / +")]
        void postfix_testInfixToPostfix(string infix, string expected) {
            List<string> token = calculate.TokenizeEquation(infix);
            List<string> expectedToken = calculate.TokenizeEquation(expected);
            List<string> actual = calculate.toPostFix(token);
            Assert.Equal(actual, expectedToken);
        }
        [Theory]
        [InlineData("-5.78+-(4—2.23)+sin(0)xcos(1)/(1+tan(2xln(-3+2x(1.23+99.111))))", "-7.55")]
        [InlineData("sin(0)/sin(0)", "Divide By Zero")]
        [InlineData("0/0", "Divide By Zero")]
        [InlineData("(4+8)+", "Syntax Error")]
        [InlineData("sin(0)+584", "584")]
        [InlineData("584+sin(0)", "584")]
        [InlineData("0+0", "0")]
        [InlineData("ln(0)", "-∞")]
        [InlineData("1000000^1000000", "∞")]
        void postfixEval_Test(string infix, string expected) {
            List<string> token = calculate.TokenizeEquation(infix);
            List<string> postfix = calculate.toPostFix(token);
            string result = calculate.PostFixEvaluator(postfix);

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData("", "")]
        void postfixEvalRadians_Test(string infix, string expected) {
            List<string> token = calculate.TokenizeEquation(infix);
            List<string> postfix = calculate.toPostFix(token);
            string result = calculate.PostFixEvaluator(postfix);

            Assert.Equal(expected, result);
        }
    }
}
