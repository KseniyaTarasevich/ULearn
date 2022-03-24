using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            while (!robot.Finished)
            {
                if (width > height)
                {
                    MoveRight(robot, width, height);
                    if (robot.Finished) break;
                    robot.MoveTo(Direction.Down);
                }
                else
                {
                    MoveDown(robot, width, height);
                    if (robot.Finished) break;
                    robot.MoveTo(Direction.Right);
                }
            }
        }

        public static void MoveRight(Robot robot, int width, int height)
        {
            for (int i = 0; i < Math.Round((double)width / (double)height); i++)
            {
                robot.MoveTo(Direction.Right);
            }
        }

        public static void MoveDown(Robot robot, int width, int height)
        {
            for (int j = 0; j < Math.Round((double)height / (double)width); j++)
            {
                robot.MoveTo(Direction.Down);
            }
        }
    }
}