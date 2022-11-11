class Vector
{
    public double x { get; set; }
    public double y { get; set; }
    public Vector (double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Vector Add (Vector v)
    {
        return new Vector(x + v.x, y + v.y);
    }
    public Vector Sub (Vector v)
    {
        return new Vector(x - v.x, y - v.y);
    }
    public Vector Scalar (double val)
    {
        return new Vector (x*val, y * val);
    }
    public double Cross (Vector v)
    {
        return x*v.x + y*v.y;
    }
}

