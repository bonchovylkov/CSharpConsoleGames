using Snake.Engine;
using Snake.Entities;
using Snake.Enums;
using Snake.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{


    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            game.Init();
            game.Play();

            //int lastFoodTime = 0;
            //int negativePoints = 0;

            //Position[] directions = CreatePositions().ToArray();

            //double sleepTime = 100;
            //Direction direction = Direction.Right;
            

            //Console.BufferHeight = Console.WindowHeight;
            //lastFoodTime = Environment.TickCount;

            //var factories = GameObjectFactoryProvider.InitializeFactories();

            //var obstacles = (ObstacleSet)factories.ExecuteCreation(GameItems.ObstacleSet);
            //obstacles.Draw();

            //var snake = (Snake.Entities.Snake)factories.ExecuteCreation(GameItems.Snake);
            //snake.Draw();

            //Food food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);
            //food.Draw();

            //while (true)
            //{
            //    negativePoints++;

            //    direction = Game.GetDirection(direction);

            //    var snakeNewHead = snake.CalculateNewSnakeHead(directions[(int)direction]);

            //    if (snake.CollideWith(snakeNewHead) || obstacles.CollideWith(snakeNewHead))
            //    {
            //        Console.SetCursorPosition(0, 0);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Game over!");
            //        int userPoints = (snake.Items.Count() - 6) * 100 - negativePoints;
            //        userPoints = Math.Max(userPoints, 0);
            //        Console.WriteLine("Your points are: {0}", userPoints);
            //        return;
            //    }

            //    snake.UpdateHead(snakeNewHead);
            //    snake.UpdateSnakeHeadDisplay(direction);
            //    snake.Draw();

            //    if (snakeNewHead.CollideWith(food))
            //    {
            //        // feeding the snake
            //        food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);
            //        food.Draw();

            //        lastFoodTime = Environment.TickCount;
            //        sleepTime--;

            //        Obstacle obstacle = (Obstacle)factories.ExecuteCreation(GameItems.Obstacle, obstacles, snake, food);
            //        obstacles.AddObstacle(obstacle);
            //        obstacle.Draw();
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }

            //    if (Environment.TickCount - lastFoodTime >= FOOD_DISAPPEAR_TIME)
            //    {
            //        negativePoints = negativePoints + 50;
            //        food.Disappear();

            //        food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);

            //        lastFoodTime = Environment.TickCount;
            //    }

            //    food.Draw();

            //    sleepTime -= 0.01;

            //    Thread.Sleep((int)sleepTime);
            //}
        }
    }
}
