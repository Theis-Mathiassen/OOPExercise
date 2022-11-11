namespace _09
{
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }
        public bool Intersect (Point point)
        {
            return Math.Sqrt(Math.Pow(Center.x - point.x,2) + Math.Pow(Center.y - point.y, 2)) <= Radius;
        }
        public bool Intersect(Circle circle)
        {
            if (circle == this)
                return false;
            double distance = Math.Sqrt(Math.Pow(Center.x - circle.Center.x, 2) + Math.Pow(Center.y - circle.Center.y, 2));
            if (distance + circle.Radius < Radius)
            {
                return false;
            }
            if (distance + Radius < circle.Radius)
            {
                return false;
            }
            if (distance < circle.Radius + Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}