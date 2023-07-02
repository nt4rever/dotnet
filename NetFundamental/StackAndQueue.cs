using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class StackAndQueue
    {
        public void TestQueue()
        {
            Queue<string> strings = new Queue<string>();
            for (int i = 0; i < 5; i++)
            {
                strings.Enqueue($"Record {i + 1}");
            }
            while (strings.Count > 0)
            {
                Console.WriteLine(strings.Dequeue());
            }
        }

        public void TestStack()
        {
            Stack<string> strings = new Stack<string>();
            for (int i = 0; i < 5; i++)
            {
                strings.Push($"Record {i + 1}");
            }
            while (strings.Count > 0)
            {
                Console.WriteLine(strings.Pop());
            }
        }

        struct CharCount
        {
            public int Brackets;
            public int Braces;
            public int Parentheses;
        }

        public void Example()
        {
            string text = "(({{}})){}[({})]";
            var counts = new CharCount();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (stack.Count == 0 || text[i].Equals('(') || text[i].Equals('[') || text[i].Equals('{')) stack.Push(text[i]);
                else
                {
                    var top = stack.Pop();
                    if (top == '[' && text[i] == ']') counts.Brackets++;
                    if (top == '(' && text[i] == ')') counts.Parentheses++;
                    if (top == '{' && text[i] == '}') counts.Braces++;
                }
            }
            Console.WriteLine($"Brackets '[]': {counts.Brackets} \nBraces '{{}}': {counts.Braces} \nParentheses '()': {counts.Parentheses}");
        }
    }
}
