using Exceptions_Homework_06._12_25.Exception;
using System;

namespace Exceptions_Homework_06._12_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İstifadəçidən iki ədəd alın və onları bölün.Bölmə zamanı sıfıra bölmə xətası(DivideByZeroException) 
            baş verə bilər, bunu try-catch ilə tutun və istifadəçiyə uyğun mesaj verin.
            Sonda, proqram "Proqram başa çatdı" mesajı ilə bitsin(finally bloku ilə)
            */

            Console.WriteLine("Entered number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered second number: ");
            int numberSecond = int.Parse(Console.ReadLine());

            try
            {
                var res = number / numberSecond;
            }
            catch
            {
                throw new DivideByZeroException();
            }
            finally
            {
                Console.WriteLine("Programs was ended");
            }

            /*
            NegativeNumberException adlı xüsusi exception yaradın.İstifadəçidən ədəd istəyin.
            Əgər ədəd mənfidirsə, NegativeNumberException atın və try-catch ilə tutub uyğun mesaj çap edin.
            */

            Console.WriteLine("Entered number: ");
            int num = int.Parse(Console.ReadLine());

            var result = GetPositiveNumber(num);
            Console.WriteLine(result);

            /*
            Bir metod yazın ki, daxil edilən iki ədədin cəmi, fərqi, hasilini və bölməsini
            Tuple şəklində qaytarsın.Əsas proqramda bu metodu çağırıb nəticələri çap edin.
            */

            Console.WriteLine("Entered first number : ");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entered second number : ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("You can choose only these sign \n /, *, +, -");
            var operators = Console.ReadLine();

            AricmeticOperations(number1, number2, operators);
        }

        /* tapsiriq 2
        (int number, string message) GetPositiveNumber(int number,string message)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            return (number, message);
        }*/

        static int GetPositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            return number;
        }

        static (int num1, int num2, string operators) AricmeticOperations(int getNum1, int getNum2, string getOperators)
        {
            int operationResult;
            switch (getOperators)
            {
                case "/":
                    operationResult = getNum1 / getNum2;
                    Console.WriteLine($"{getNum1} {getOperators} {getNum2} = {operationResult}");
                    break;
                case "*":
                    operationResult = getNum1 * getNum2;
                    Console.WriteLine($"{getNum1} {getOperators} {getNum2} = {operationResult}");
                    break;
                case "+":
                    operationResult = getNum1 + getNum2;
                    Console.WriteLine($"{getNum1} {getOperators} {getNum2} = {operationResult}");
                    break;
                case "-":
                    operationResult = getNum1 - getNum2;
                    Console.WriteLine($"{getNum1} {getOperators} {getNum2} = {operationResult}");
                    break;
                default: 
                    throw new NegativeNumberException(getOperators);
                    break;
            }
                
            return (getNum1, getNum2, getOperators);
        }
    }
}
