using System;

namespace CalculatorNS
{
    public class Calculator
    {
        public string GetFirstNumber()

        {
            Console.Write("Enter first number: ");
            return Console.ReadLine();
        }

        public string GetOperator()
        {
            Console.Write("Enter operator (+,-,/,*): ");
            return Console.ReadLine();
        }

        public string GetSecondNumber()
        {
            Console.Write("Enter second number: ");
            return Console.ReadLine();
        }

        public bool IsInputValid(string first, string op, string second)
        {
            int num1 = 0;
            int num2 = 0;
            if (first =="")
            {
                Console.WriteLine("First number is empty");
                return false;
            }

            if (op=="")
            {
                Console.WriteLine("Operator is empty");
                return false;
            }

            if (second=="")
            {
                Console.WriteLine("Second number is empty");
                return false;
            }

            if (!int.TryParse(first, out num1))
            {
                Console.WriteLine("First number must be numerical");
                return false;
            }

            if (!int.TryParse(second, out num2))
            {
                Console.WriteLine("Second number must be numerical");
                return false;
            }  
            
            if (!(op =="+" || op=="-" || op =="*" || op=="/"))
            {
                Console.WriteLine("Invalid Input");
                return false;
            }

            if(op=="/" && second =="0")
            {
                Console.WriteLine("Division by 0 is not allowed");
                return false;
            }

            return true;
        }

        public double GetResult(string first, string op, string second)
        {
            double result = 0.0;
            switch (op)
            {
                case "+":
                    result = int.Parse(first) + int.Parse(second);
                    break;
                case "-":
                    result = int.Parse(first) - int.Parse(second);
                    break;
                case "*":
                    result = int.Parse(first) * int.Parse(second);
                    break;
                case "/":
                    result = Math.Round(double.Parse(first) / double.Parse(second),2);
                    break;
            }
            return result;
        }

        public void GenerateResult()
        {
            string num1;
            string op;
            string num2;

            do
            {
                num1 = GetFirstNumber();
                op = GetOperator();
                num2 = GetSecondNumber();
            } while (!IsInputValid(num1,op,num2));

            Console.WriteLine(num1+" "+op+" "+num2+" "+" = "+ GetResult(num1,op,num2));
        }


        public static void Main()
        {
            Calculator cal = new Calculator();
            cal.GenerateResult();
        }

    }
}
