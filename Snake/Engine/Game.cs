using Snake.Entities;
using Snake.Enums;
using Snake.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake.Engine
{
    public class Game
    {
        const int FOOD_DISAPPEAR_TIME = 8000;
        public int LastFoodTime { get; set; }
        public int NegativePoints { get; set; }
        public double SleepTime { get; set; }
        public Direction CurrentDirection { get; set; }
        public IList<Position> Directions { get; set; }


        private ICollection<Position> CreatePositions()
        {
            return new Position[]
            {
                new Position(0, 1), // right
                new Position(0, -1), // Left
                new Position(1, 0), // Down
                new Position(-1, 0), // Up
            };
        }

        public  void Init()
        {
            this.LastFoodTime = Environment.TickCount;
            this.NegativePoints = 0;
            this.SleepTime = 100;
            this.CurrentDirection = Direction.Right;
            this.Directions = CreatePositions().ToArray();

            Console.BufferHeight = Console.WindowHeight;
        }

        public void Play()
        {

            var factories = GameObjectFactoryProvider.InitializeFactories();

            var obstacles = (ObstacleSet)factories.ExecuteCreation(GameItems.ObstacleSet);
            obstacles.Draw();

            var snake = (Snake.Entities.Snake)factories.ExecuteCreation(GameItems.Snake);
            snake.Draw();

            var food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);
            food.Draw();

            while (true)
            {
                this.NegativePoints++;

                this.CurrentDirection = GetDirection(this.CurrentDirection);

                var snakeNewHead = ((Snake.Entities.Snake)snake).CalculateNewSnakeHead(this.Directions[(int)this.CurrentDirection]);

                if (snake.CollideWith(snakeNewHead) || obstacles.CollideWith(snakeNewHead))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over!");
                    int userPoints = (snake.Items.Count() - 6) * 100 - NegativePoints;
                    userPoints = Math.Max(userPoints, 0);
                    Console.WriteLine("Your points are: {0}", userPoints);
                    return;
                }

                snake.UpdateHead(snakeNewHead);
                snake.UpdateSnakeHeadDisplay(CurrentDirection);
                snake.Draw();

                if (snakeNewHead.CollideWith(food))
                {
                    // feeding the snake
                    food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);
                    food.Draw();

                    LastFoodTime = Environment.TickCount;
                    SleepTime--;
                    
                    Obstacle obstacle = (Obstacle)factories.ExecuteCreation(GameItems.Obstacle, obstacles, snake, food);
                    obstacles.AddObstacle(obstacle);
                    obstacle.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Environment.TickCount - LastFoodTime >= FOOD_DISAPPEAR_TIME)
                {
                    NegativePoints = NegativePoints + 50;
                    food.Disappear();

                    food = (Food)factories.ExecuteCreation(GameItems.Food, obstacles, snake);

                    LastFoodTime = Environment.TickCount;
                }

                food.Draw();

                SleepTime -= 0.01;

                Thread.Sleep((int)SleepTime);
            }
        }

        public Direction GetDirection(Direction oldDirection)
        {
            Direction direction = oldDirection;

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    if (oldDirection != Direction.Right) direction = Direction.Left;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (oldDirection != Direction.Left) direction = Direction.Right;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (oldDirection != Direction.Down) direction = Direction.Up;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    if (oldDirection != Direction.Up) direction = Direction.Down;
                }
            }

            return direction;
        }
    }
}
