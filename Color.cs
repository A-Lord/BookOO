namespace BookOO
{
    public class Color
    {
        public int _red { get; }
        public int _green { get; }
        public int _blue { get; }
        private string[,] RGB = new string[,]
        {
            { "white", "255", "255", "255", }, //Färgens namn, Röds värde , Gröns värde, Blåtvärde
            { "black", "0", "0", "0", },
            { "red", "255", "0", "0", },
            { "orange", "255", "165", "0", },
            { "yellow", "255", "255", "0", },
            { "green", "0", "128", "0", },
            { "blue", "0", "0", "255", },
            { "purple", "128", "0", "128", },
        };

        public Color(int red, int green, int blue) //skapar och specificera vilken RGB det ska vara
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
        public Color(string textColor) //Skapar och sätter RGB till rätt färg om strängen finns i rgb arrayen
        {                              //Annars blir färgen satt till 0,0,0 = svart.
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
        public string GetRgbString()
        {
            string returnString = "R: " + _red.ToString() + " G: " + _green.ToString() + " B: " + _blue.ToString();
            return returnString;
        }

    }
    public class TextColor  //klass för att ändra färg på console text.
    {                       //sparar text färgen som används när objektet skapas.
        private ConsoleColor StartColor;
        private ConsoleColor consoleColor;
        public TextColor()
        {
            StartColor = Console.ForegroundColor;
        }
        public void ChangeColor(string Color)
        {
            if (Enum.TryParse<ConsoleColor>(Color, out consoleColor))  //om stringen innehåller en färg som finns i Enum.ConsoleColor
            {                                                          //bytes texten till den färgen, annars händer inget.
                Console.ForegroundColor = consoleColor;
                
            }
        }
        public void ResetToStartColor()     // om man vill byta färg till den färgen som consolen hade när man skapade objketet.
        {                                   // vill man ha defult färg får man använda console.resetcolor i stället.
            Console.ForegroundColor = StartColor;
        }
    }

}
