using MyNewPaint.Enums;

namespace MyNewPaint.Models
{
    class Shape
    {
        public Shape(Point startingPoint, int width, int height, bool isFilled)
        {

            StartingPoint = startingPoint;
            Width = width;
            Height = height;
            this.isFilled = isFilled;
        }


        public Point StartingPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool isFilled { get; set; }
    }
}