using MyNewPaint.Enums;

namespace MyNewPaint.Models
{
    static class ShapeFactory
    {
        public static void DrawFactory(string shape,Rectangle rectangle, object drawObject, Graphics g)
        {
            Point[] points;

            switch (shape)
            {
                case "Rectangle":
                    if (drawObject is Brush) g.FillRectangle(drawObject as Brush, rectangle);
                    else g.DrawRectangle(drawObject as Pen, rectangle);
                    break;

                case "Circle":
                    if (drawObject is Brush) g.FillEllipse(drawObject as Brush, rectangle);
                    else g.DrawEllipse(drawObject as Pen, rectangle);
                    break;

                case "Triangle":
                    points = new Point[] { 
                        new Point(rectangle.X, rectangle.Y + rectangle.Height),
                        new Point(rectangle.X + rectangle.Width / 2, rectangle.Y),
                        new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height),
                    };

                    if (drawObject is Brush) g.FillPolygon(drawObject as Brush, points );
                    else g.DrawPolygon(drawObject as Pen, points);
                    break;

                case "Rhomb":
                    points = new Point[] {
                        new Point(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height),
                        new Point(rectangle.X, rectangle.Y + rectangle.Height / 2),
                        new Point(rectangle.X + rectangle.Width / 2, rectangle.Y),
                        new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2),
                    };

                    if (drawObject is Brush) g.FillPolygon(drawObject as Brush, points);
                    else g.DrawPolygon(drawObject as Pen, points);
                    break;

                default:
                    break;
            }
        }
    }
}