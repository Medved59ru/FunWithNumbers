using System;

namespace FunWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "УГАДАЙ ЧИСЛО";

            Console.WriteLine("КОМПЬЮТЕР СГЕНЕРИРОВАЛ ЦЕЛОЕ ЧИСЛО ОТ 0 ДО 100 ВКЛЮЧИТЕЛЬНО. ЕГО НУЖНО УГАДАТЬ ");
            
            Game game = new Game();

            game.Play();
        }
    }
}
