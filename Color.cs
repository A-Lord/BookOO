namespace BookOO
{
    public class Color
    {
        public int _red { get; }
        public int _green { get; }
        public int _blue { get; }
        private string[,] RGB = new string[,]
        {
            { "white", "255", "255", "255", },
            { "black", "0", "0", "0", },
            { "red", "255", "0", "0", },
            { "orange", "255", "165", "0", },
            { "yellow", "255", "255", "0", },
            { "green", "0", "128", "0", },
            { "blue", "0", "0", "255", },
            { "purple", "128", "0", "128", },
        };

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
        public Color(string textColor)
        {
            for (int i = 0; i < RGB.GetLength(0); i++)
            {
                if (textColor == RGB[i, 0])
                {
                    _red = int.Parse(RGB[i, 1]);
                    _green = int.Parse(RGB[i, 2]);
                    _blue = int.Parse(RGB[i, 3]);
                }
            }
        }
    }


}
