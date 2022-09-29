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
            Console.WriteLine("test");
            Assert.Equal(actual, expectedToken);
        }
    }
}
