class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double Circumference()
    {
        return 2 * radius * 3.14;
    }
    public double Area()
    {
        return radius * radius * 3.14;
    }
}