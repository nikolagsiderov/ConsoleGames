using System;
using System.Threading;

namespace SnakeGame
{
    // spawn fruits
    // move snake
    // grow snake
    // create snake

    class Startup
    {
        static bool eaten = false;

        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 100;

            Run();
        }

        static void Run()
        {
            while (true)
            {
                if (eaten)
                {
                    SpawnFruits();
                }

                MoveSnake();
                GrowSnake();

                Console.Clear();

                Thread.Sleep(100);

                CreateSnake();
            }
        }

        static void SpawnFruits()
        {
            Fruit fruit = new Fruit();
            fruit.Symbol = '@';

            Random randomGen = new Random();
            int chanceOfX = randomGen.Next(1, 100);
            int chanceOfY = randomGen.Next(1, 40);

            Console.SetCursorPosition(chanceOfX, chanceOfY);
            Console.Write(fruit.Symbol);
        }

        static void MoveSnake()
        {

        }

        static void GrowSnake()
        {

        }

        static void CreateSnake()
        {
            Snake snake = new Snake();
            snake.Symbol = 'O';
            snake.Body.Add(snake.Symbol);
            snake.BodyCoordinatesX.Add(1);
            snake.BodyCoordinatesY.Add(1);

            for (int i = 0; i < snake.Body.Count; i++)
            {
                Console.SetCursorPosition(snake.BodyCoordinatesX[i], snake.BodyCoordinatesY[i]);
                Console.Write(snake.Symbol);
            }
        }
    }
}
