using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 80;
            int mapHeight = 40;
            Console.SetWindowSize( // задаем размер экрана
       Math.Min(mapWidth, Console.LargestWindowWidth),
       Math.Min(mapHeight, Console.LargestWindowHeight));

            Walls walls = new Walls(mapWidth, mapHeight);
            walls.Draw();
         
            // отрисовка точек
            Point p = new Point(10, 10, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(mapWidth, mapHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                snake.Move();

                Thread.Sleep(150);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }               
    }
}
