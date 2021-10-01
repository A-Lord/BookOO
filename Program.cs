using BookOO;


Point first = new Point(2, 3);
Point second = new Point(-4, 0);
first.Print();
second.Print();
Color purple = new Color("purple");
Console.WriteLine($"{purple._red} {purple._green} {purple._blue}");


    foreach (int i in Enum.GetValues(typeof(CardColor)))
    {
        string color = i.ToString();
        for (int j = 0; j < 14; j++)
        {

            Card outPutCard = new Card(color, j);
            Console.WriteLine($"The {outPutCard._Color} {outPutCard._rank}");
        }
    }

