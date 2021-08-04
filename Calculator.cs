using System;

namespace Calculator{
	public class Calculator{
		static string GetFirstNum(){
			Console.Write("Enter first number: ");
			return Console.ReadLine();
		}

		static string GetOperator(){
			Console.Write("Please enter the operator(+,-,*,/): ");
			return Console.ReadLine();
		}
		
		static string GetSecondNum(){
			Console.Write("Enter second number: ");
		    return Console.ReadLine();
		}

        static bool IsInputValid(string first, string op, string second)
        {
            double num1 =0.0;
            double num2 =0.0;
            if (!Double.TryParse(first, out num1)){
                Console.WriteLine("Invalid Input! First number should be numerical");
                return false;
            }
            if (!Double.TryParse(second, out num2)){
                Console.WriteLine("Invalid Input! First number should be numerical");
                return false;
            }
            if (!(op == "+" || op == "-" || op == "*" || op == "/"))
            {
                Console.WriteLine("Invalid Operator!");
                return false;
            }
            if (op == "/" && Double.Parse(second) == 0){
                Console.WriteLine("Error! Division by 0 is not allowed");
                return false;
            }
            return true;
        }
							
		static double CalcResult(string first, string op, string second){
			double result = 0.0;
            switch (op)
            {
                case "+":
                    result = double.Parse(first) + double.Parse(second);
                    break;
                case "-":
                    result = double.Parse(first) - double.Parse(second);
                    break;
                case "*":
                    result = double.Parse(first) * double.Parse(second);
                    break;
                case "/":
                    result = Math.Round(double.Parse(first) / double.Parse(second),2);
                    break;
            }

			return result;
		}

		static void GenerateResult()
		{
            string num1;
            string op;
            string num2;
            do
            {
			num1 = GetFirstNum();
			op = GetOperator();
			num2 = GetSecondNum();
            } while (!IsInputValid(num1, op, num2));
			Console.WriteLine(num1+ " " +op+ " " +num2+" = "+CalcResult(num1, op, num2));
		}
		
		static void Main(string[] args)
        {
			GenerateResult();
		}
		
	}
}
