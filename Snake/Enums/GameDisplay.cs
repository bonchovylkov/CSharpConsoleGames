using System.ComponentModel;

namespace Snake.Enums
{
    public enum GameDisplay
    {
        [Description("*")]
        SnakeBody,
        [Description(">")]
        SnakeHeadRight,
        [Description("<")]
        SnakeHeadLeft,
        [Description("^")]
        SnakeHeadUp,
        [Description("v")]
        SnakeHeadDown,
        [Description("@")]
        Food,
        [Description("=")]
        Obstacle,
        [Description(" ")]
        Empty,
    }
}
