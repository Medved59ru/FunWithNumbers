using System;


namespace FunWithNumbers
{
    public class Game
    {
         private int _computerNumber;
        private static bool stopTheGame;
        Random rnd = new Random();

       
        public Game()
        {
            _computerNumber = rnd.Next(0, 101);
        }

        public Game (int ComputerNumber)
        {
            _computerNumber = ComputerNumber;
        }

        public string CompareComputerNumberWith(int userNumber)
        {
            
            string message = "";

            if (_computerNumber == userNumber)
            {
                message = MessageEnum.ВЕРНО.ToString();
                stopTheGame = true;
            }
            else if (_computerNumber < userNumber)
            {
                message = MessageEnum.МЕНЬШЕ.ToString();
            }
            else
            {
                message = MessageEnum.БОЛЬШЕ.ToString();
            }
            return message;
        }

               
        public void Play()
        {
            int userNumber = InputOutput.GetFromConsoleThe();

            string message = CompareComputerNumberWith(userNumber);

            InputOutput.Print(message);

            while (!stopTheGame)
            {
                userNumber = InputOutput.GetFromConsoleThe();
                message = CompareComputerNumberWith(userNumber);
                InputOutput.Print(message);

                if (stopTheGame == true)
                {
                    InputOutput.Print("Играем еще? \n Y - Продолжим/ Любая другая лавиша - Закончить");

                    if (Console.ReadLine().ToLowerInvariant() == "y")
                    {
                        _computerNumber = rnd.Next(0, 101);
                        stopTheGame = false;
                    }

                }
            }

        }
    }
}
