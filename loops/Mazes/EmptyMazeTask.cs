namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            for (int i = 1; i < width - 2; i++)
            {
                robot.MoveTo(Direction.Right);
            }

            if (robot.Y != height - 2)
            {
                MoveDown(robot, height);
            }
        }

        public static void MoveDown(Robot robot, int height)
        {
            for (int j = 1; j < height - 2; j++)
            {
                robot.MoveTo(Direction.Down);
            }
        }
    }
}