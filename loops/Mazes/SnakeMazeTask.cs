namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            while (!robot.Finished)
            {
                MoveRight(robot, width);
                MoveDown(robot);
                MoveLeft(robot, width);

                if (robot.Finished)
                    break;

                MoveDown(robot);
            }
        }

        public static void MoveDown(Robot robot)
        {
            for (int j = 1; j < 3; j++)
            {
                robot.MoveTo(Direction.Down);
            }
        }

        public static void MoveRight(Robot robot, int width)
        {
            for (int i = 1; i < width - 2; i++)
            {
                robot.MoveTo(Direction.Right);
            }
        }

        public static void MoveLeft(Robot robot, int width)
        {
            for (int k = width - 2; k > 1; k--)
            {
                robot.MoveTo(Direction.Left);
            }
        }
    }
}
