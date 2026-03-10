using Exceptions_06_12_25.Exception;
using System;
using System.Collections.Generic;


namespace Exceptions_06_12_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            var users = Console.ReadLine().Trim();
            Console.WriteLine(Finduser(users));
            
            Tuple<string, int> tupla = new Tuple<string, int>("Tupla-item1", 32);
            Console.WriteLine(tupla.Item1);
            Console.WriteLine(tupla.Item2);

            (string name, int age,bool isCheck) info = new("Seyid", 32,false);

            Console.WriteLine(info.age + "-" + info.name + "-" + info.isCheck);

            // List<()> iki morterizeyle yazilan tuple sayilir

            List<(string, int)> familyData = new List<(string, int)>()
            {
                ("Seyid",30),
                ("Umid",31),
                ("Ali",25),
                ("Heyder",21)
            };

            foreach (var item in familyData)
            {
                Console.WriteLine(item.ToTuple() + " " + item.Item2);
            }

            int zero = 0;
            int ten = 10;
            int five = 5;

            Console.WriteLine((DayOfWeek)1 + " enum " + DayOfWeek.Tuesday + " enum " + (int)DayOfWeek.Friday);

            // IO exception-lar

            try
            {
                //int diveded = ten / zero;
                int fiveded = ten / five;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            //------------------------------------------------------------------------

            try
            {
                int diveded = ten / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                throw new NullReferenceException("Operations is Aricmetic.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            //------------------------------------------------------------------------

            try
            {
                Console.WriteLine("Open try");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Close catch");
                throw new DivideByZeroException(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            var result = getUserInfo("s",7,true);
            Console.WriteLine(result);
        }

        //Tuple Mehod

        static (string name, int age, bool isActive) getUserInfo(string name, int age, bool isFalse)
        {
            // codes thing
            return (name, age, isFalse);
        }
        
        static string Finduser(string userData)
        {
            List<string> userList = new List<string>() { "Fazil", "Seyid", "Umid" };

            if (!userList.Contains(userData))
            {
                throw new UserWasNotFoundException(userData);
            }
            return userData;
        }
    }
}
