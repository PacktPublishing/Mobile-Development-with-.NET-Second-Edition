using System;
using System.Linq;
using calculator.core;

namespace calculator.console
{
    class Program
    {
        private static char[] _numberChars = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char[] _opChars = new[] { '+', '-', '*', '/', '=' };

        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.ResultChanged = (result) =>
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}{result}");
            };

            while (true)
            {
                var key = Console.ReadKey().KeyChar;

                if(key == 'e')
                {
                    break;
                }

                if (_numberChars.Contains(key))
                {
                    calculator.PushNumber(key.ToString());
                }

                if(_opChars.Contains(key))
                {
                    calculator.PushOperation(key);
                }
            }
        }
    }
}
