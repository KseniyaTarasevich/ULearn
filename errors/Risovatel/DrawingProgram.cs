using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Drawing
    {
        static float x, y;
        static Graphics graphics;

        public static void InitializeGraphics(Graphics newGraphics)
        {
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            x = x0; y = y0;
        }

        public static void DrawTrajectory(Pen pen, double length, double angle)
        {
            //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ChangeCoordinates(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle));
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        public const float ShortLine = 0.04f;
        public const float LongLine = 0.375f;
        public static void DrawSideOne(double minWeightHeight)
        {
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, 0);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * ShortLine * Math.Sqrt(2), Math.PI / 4);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, Math.PI);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine - minWeightHeight * ShortLine, Math.PI / 2);

            Drawing.ChangeCoordinates(minWeightHeight * ShortLine, -Math.PI);
            Drawing.ChangeCoordinates(minWeightHeight * ShortLine * Math.Sqrt(2), 3 * Math.PI / 4);
        }

        public static void DrawSideTwo(double minWeightHeight)
        {
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, -Math.PI / 2);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * ShortLine * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, -Math.PI / 2 + Math.PI);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine - minWeightHeight * ShortLine,
                -Math.PI / 2 + Math.PI / 2);

            Drawing.ChangeCoordinates(minWeightHeight * ShortLine, -Math.PI / 2 - Math.PI);
            Drawing.ChangeCoordinates(minWeightHeight * ShortLine * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
        }

        public static void DrawSideThree(double minWeightHeight)
        {
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, Math.PI);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * ShortLine * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, Math.PI + Math.PI);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine - minWeightHeight * ShortLine,
                Math.PI + Math.PI / 2);

            Drawing.ChangeCoordinates(minWeightHeight * ShortLine, Math.PI - Math.PI);
            Drawing.ChangeCoordinates(minWeightHeight * ShortLine * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
        }

        public static void DrawSideFour(double minWeightHeight)
        {
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, Math.PI / 2);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine, Math.PI / 2 + Math.PI);
            Drawing.DrawTrajectory(Pens.Yellow, minWeightHeight * LongLine - minWeightHeight * ShortLine,
                Math.PI / 2 + Math.PI / 2);

            Drawing.ChangeCoordinates(minWeightHeight * ShortLine, Math.PI / 2 - Math.PI);
            Drawing.ChangeCoordinates(minWeightHeight * ShortLine * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }

        public static void Draw(int weight, int height, double rotateAngle, Graphics graphics)
        {
            // rotateAngle пока не используется, но будет использоваться в будущем
            Drawing.InitializeGraphics(graphics);

            var minWeightHeight = Math.Min(weight, height);

            var diagonalLength = Math.Sqrt(2) * (minWeightHeight * LongLine + minWeightHeight * ShortLine) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + weight / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Drawing.SetPosition(x0, y0);

            //Рисуем 1-ую сторону
            DrawSideOne(minWeightHeight);

            //Рисуем 2-ую сторону
            DrawSideTwo(minWeightHeight);

            //Рисуем 3-ю сторону
            DrawSideThree(minWeightHeight);

            //Рисуем 4-ую сторону
            DrawSideFour(minWeightHeight);
        }
    }
}