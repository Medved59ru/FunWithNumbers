using System;


namespace FunWithNumbers
{
   public class InputOutput
    {
        public static void GreetingMessage()
        {
            Console.Write("Введите число: ");
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
      

        public static int GetFromConsoleThe(string number)
        {
            int userNumber;
            while (true)
            {
               
                bool parseResult = int.TryParse(number, out int localNumber);
                if (parseResult && localNumber >= 0 && localNumber <= 100)
                {
                   userNumber = localNumber;
                   break;
                }
                else
                {
                    Console.WriteLine("Что-то не то... Нужно ввести целое число от 0 до 100");
                    GreetingMessage();
                    number = Console.ReadLine();
                }
                
            }
            return userNumber;
        }

        
    }
}
