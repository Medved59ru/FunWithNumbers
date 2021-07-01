using System;
using System.Collections.Generic;

namespace FunWithNumbers
{
    public class Game
    {
        private int _computerNumber;
        private  bool stopTheGame;
        private Random rnd = new Random();
        public static int GameProperty;

        Dictionary<MessageEnum, string> messageForPrint = new Dictionary<MessageEnum, string>
        {
            [MessageEnum.CORRECT] = "ВЕРНО",
            [MessageEnum.LESS] = "МЕНЬШЕ",
            [MessageEnum.MORE] = "БОЛЬШЕ"
        };
        

        public Game()
        {
            _computerNumber = GetRndNumber(0,100);
            GameProperty = _computerNumber;
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
                message = messageForPrint[MessageEnum.CORRECT];   
                stopTheGame = true;
            }
            else if (_computerNumber < userNumber)
            {
                message = messageForPrint[MessageEnum.LESS];
            }
            else
            {
                message = messageForPrint[MessageEnum.MORE];
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
                        _computerNumber = GetRndNumber(0,100);
                        stopTheGame = false;
                    }

                }
            }

        }

        private int GetRndNumber(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
    }
}
