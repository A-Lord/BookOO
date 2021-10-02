using System;
using BookOO;


Point first = new Point(2, 3);
Point second = new Point(-4, 0);
first.Print();
second.Print(); //testar point's print metod.

Color purple = new Color("purple"); //sätter purples RGB värden till rätt värde för färgen purple.
Color ownColor = new Color(0, 8, 190); //och här sätter jag dom till egna värden

Console.WriteLine($"{purple._red} {purple._green} {purple._blue}"); //kan får ut varje färg för sej
Console.WriteLine($"{ ownColor.GetRgbString()}");                   // eller använda den här metoden för att få en formaterad sträng med alla värdena.

TextColor CardTextColor = new TextColor(); 
//Har gjort en klass som gör att man kan byta färg på texten lättare. Den sparar
//även vilken färg man har på texten när man skapar  TextColor objektet, sen kan man skicka en sträng som motsvarar en av console 
//färgerna så byts text färgen till den.



   //kör igenom for loppen 1 gåmng för varje färg i cardcolor enumen
foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
{
    CardTextColor.ChangeColor(color.ToString()); //gör om CardColor till sträng och byter text till den färgen med TextColor klassen
                                                 //Sen skapar vi ett av varje kort i den färgen och skriver ut den i consolen.
    foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
    {
        Card outPutCard = new Card(color, rank);       
        Console.WriteLine($"The {outPutCard._Color} {outPutCard._rank}");
    }
    Console.ResetColor();   //reset color finns redan så onödigt att lägga till i klassen, går dock att gör ResetToStartColor
                           // för att ändra till den textfärg som consolen hade när objektet initierades. 
                           
}

