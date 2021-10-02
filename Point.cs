namespace BookOO
{
    public class Point
    {
        public float X { get; }
        public float Y { get; }
        public Point() //skickar man inte in ett  värde sätts x och y till 0;
        { }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void Print() //en print funktion om man vill får x och y utprintade i rätt format.
        {
            Console.WriteLine($"({X},{Y})");
        }
    }
}
