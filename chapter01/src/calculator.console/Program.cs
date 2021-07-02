using System;
using System.Linq;

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

        public class Calculator
        {
            private int _state = 0;

            string _firstNumber;
            string _currentNumber = string.Empty;
            char _operation;

            public Action<string> ResultChanged = null;

            public void PushNumber(string value)
            {
                if (_state == 1)
                {
                    _state = 2;
                }

                _currentNumber += value;

                ResultChanged?.Invoke(_currentNumber);
            }

            public void PushOperation(char operation)
            {
                if (_state == 0 || _state == 2)
                {
                    if (_state == 2)
                    {
                        _currentNumber = Calculate(int.Parse(_firstNumber), int.Parse(_currentNumber), _operation).ToString();
                        ResultChanged?.Invoke(_currentNumber);
                    }

                    _firstNumber = _currentNumber;

                    _currentNumber = string.Empty;

                    _state = 1;
                }

                if (_state == 1)
                {
                    if (operation != '=')
                    {
                        _operation = operation;
                    }
                }
            }

            private int Calculate(int number1, int number2, char operation)
            {
                switch (operation)
                {
                    case '+':
                        return number1 + number2;
                    case '-':
                        return number1 - number2;
                    case '*':
                        return number1 * number2;
                    case '/':
                        return number1 / number2;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
