using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculator
{
    /// <summary>
    /// Class used to calculate Infix and postfix equations
    /// </summary>
    public class Calc
    {
        /// <summary>
        /// Determines whether or not to calculate trig functions
        /// in radians or degrees
        /// </summary>
        public bool inDeg = false;

        /// <summary>
        /// Determins the precedence of each operator
        /// </summary>
        /// <param name="op">operator as a string</param>
        /// <returns>precendce score as a number</returns>
        public int precedence(string op)
        {
            switch (op)
            {
                case "+":
                case "—":
                    return 1;
                case "x":
                case "/":
                    return 2;
                case "^":
                    return 3;
                case "-":
                    return 4;
            }
            return -1;
        }
        /// <summary>
        /// Tokenizes the equation to solve large and complex numbers/equations
        /// 
        /// We Tokenize large number (i.e. 100) all as one token (['100']) vs tokenizing
        /// them as three seperate tokens (['1', '0', '0']) Otherwise the program
        /// Will think this is three seperate numbers
        /// </summary>
        /// <param name="equation">Equatoin to be tokenized</param>
        /// <returns>List of strings, i.e. the tokenized equation</returns>
        public List<string> TokenizeEquation(string equation)
        {
            var delimiters = new[] { '(', '+', '—', 'x', '/', ')', '^', }; // list of delimiters to separate from
            var buffer = ""; // buffer currently set to empty, used to determine large numbers
            var result = new List<string>(); // results stored as a list
            foreach (var ch in equation) // for each character in the equation
            {
                if (delimiters.Contains(ch)) // if the character is a delimiter
                {
                    if (buffer.Length > 0) result.Add(buffer); // add buffer to results
                    result.Add(ch.ToString()); // add character to results
                    buffer = ""; // clear buffer
                }
                else // if character is a number
                {
                    buffer += ch; // add character to buffer
                }
            }
            if (buffer.Length > 0) result.Add(buffer); // add buffer to results
            return result;
        }
        /// <summary>
        /// Converts Infix equation to a Postfix equation
        /// Original sample came from GeeksForGeeks, More understanding and
        /// conteptual ideas from Comp Sci in 5 from Youtube
        /// </summary>
        /// <param name="inFix">Tokenized original equation</param>
        /// <returns>Tokenized Infix equation</returns>
        public List<string> toPostFix(List<string> inFix)
        {
            try
            {
                List<string> result = new List<string>(); // result stack
                Stack<string> stack = new Stack<string>(); // temp stack
                for (int i = 0; i < inFix.Count; i++) // foreach character in tokenized infix equation
                {
                    string ch = inFix[i]; // get character
                    double chNum;
                    //bool isNum = Int32.TryParse(ch, out chNum); // check if character is a number
                    bool isNum = Double.TryParse(ch, out chNum);
                    if (isNum) // if character is a number
                    {
                        result.Add(ch); // add character to results
                    }
                    else if (ch == "(") // if open parenthesis
                    {
                        stack.Push(ch); // push to temp stack
                    }
                    else if (ch == ")") // if closed parenthesis
                    {
                        while (stack.Count > 0 && stack.Peek() != "(") // while the stack has items and the item is not a closing bracket
                        {
                            result.Add(stack.Pop()); // add non-parehtnesis functions to results

                        }
                        if (stack.Count > 0 && stack.Peek() != "(") // if last element is not an open perenthesis
                        {
                            return new List<string>();
                        }
                        else
                        {
                            stack.Pop(); // found opening parenthesis, remove from stack (we dont want parenthesis in postfix equation)
                        }

                    }
                    else
                    {
                        while (stack.Count > 0 && precedence(ch) <= precedence(stack.Peek())) // check the precedence of currenct function to that in the stack
                        {
                            result.Add(stack.Pop()); // add to result if precedence is less
                        }
                        stack.Push(ch); // add to stack if precedence is more
                    }
                }
                while (stack.Count > 0) // while stack has any leftover function
                {
                    result.Add(stack.Pop()); // add them to results
                }
                if (result.Contains("("))
                { // checks if original equation only had one open parenthesis
                    return new List<string>();
                }
                return result;
            }
            catch (Exception err)
            {
                return new List<string>();
            }
        }
        /// <summary>
        /// Evaluates a Postfix Equation
        /// Original sample came from GeeksForGeeks, More understanding and
        /// conteptual ideas from Comp Sci in 5 from Youtube
        /// </summary>
        /// <param name="PostFix">Postfix equation given as a token</param>
        /// <returns>number result of postfix equation</returns>
        public string PostFixEvaluator(List<string> PostFix)
        {
            try
            {
                Stack stack = new Stack(); // temp stack
                double a, b, ans; // first in stack, second in stack, some combination of the two
                for (int i = 0; i < PostFix.Count; i++) // foreach character in postfix equation
                {
                    string ch = PostFix[i]; // get character in equation
                    if (ch.Equals("+")) // if character is a '+' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a + b; // calculates first + second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("—")) // if character is a '-' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop();
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a - b; // calculates first - second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("x")) // if character is a 'x' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a * b; // calculates first x second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("/")) // if character is a '/' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a / b; // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("^"))
                    { // if character is a '^' sign
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = Math.Pow(a, b); // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("ln"))
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        a = Convert.ToDouble(sa); // convert string to double
                        ans = Math.Log(a); // calculate log of number
                        stack.Push(ans.ToString()); // push number to stack
                    }
                    else if (ch.Equals("log"))
                    {
                        string sa = (string)stack.Pop();
                        a = Convert.ToDouble(sa);
                        ans = Math.Log(a, 10);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("sin"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Sin(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Sin((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());

                    }
                    else if (ch.Equals("cos"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Cos(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Cos((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("tan"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Tan(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Tan((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("-"))
                    {
                        string sa = (string)stack.Pop();
                        a = Convert.ToDouble(sa);
                        ans = -a;
                        stack.Push(ans.ToString());
                    }
                    else // if character is a number
                    {
                        stack.Push(PostFix[i]); // add number to stack
                    }


                }
                return (string)stack.Pop(); // final number in stack is the answer

            }
            catch (Exception err)
            {
                return "Syntax Error";
            }
        }
    }
}
