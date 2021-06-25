using System;


namespace FunWithNumbers
{
    public class Game
    {
        private int _computerNumber;


        private int ComputerNumber
        {
            get => _computerNumber;
            set => _computerNumber = value;
        }

        public Game()
        {}

        public Game (int ComputerNumber)
        {
            _computerNumber = ComputerNumber;
        }

        public string CompareComputerNumberWith(int userNumber)
        {
            string message = "";

            if (ComputerNumber == userNumber)
            {
                message = "ВЕРНО!!!";
            }
            else if (ComputerNumber < userNumber)
            {
                message = "МЕНЬШЕ...";
            }
            else
            {
                message = "БОЛЬШЕ...";
            }
            return message;
        }

        public bool CheckThe(string messsage)
        {
            bool stopTheGame = false;
            if (messsage == "ВЕРНО!!!")
            {
                stopTheGame = true;
            }

            return stopTheGame;
        }

        public static int GetGoalNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 101);
        }

        public void Play(int userNumber)
        {
            ComputerNumber = GetGoalNumber();

            string message = CompareComputerNumberWith(userNumber);

            InputOutput.Print(message);

            bool stopTheGame = CheckThe(message);

            while (!stopTheGame)
            {
                InputOutput.GreetingMessage();
                userNumber = InputOutput.GetFromConsoleThe(Console.ReadLine());
                message = CompareComputerNumberWith(userNumber);
                InputOutput.Print(message);
                stopTheGame = CheckThe(message);

                if (stopTheGame == true)
                {
                    InputOutput.Print("Играем еще? \n Y - Продолжим/ Любая другая лавиша - Закончить");

                    if (Console.ReadLine().ToLowerInvariant() == "y")
                    {
                        stopTheGame = false;
                        ComputerNumber = GetGoalNumber();
                    }

                }

            }

        }
    }
}
