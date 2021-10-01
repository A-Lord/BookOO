namespace BookOO
{
    public class Point
    {
        private int X { get; }
        private int Y { get; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"({X},{Y})");
        }
    }
}
