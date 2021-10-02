namespace BookOO
{
    public class Card
    {
        public CardColor _Color { get; }
        public  CardRank _rank { get; }
        public Card(CardColor inColor, CardRank rank) //tar i mot enum cardcolor och rank när man skapar ett kort.
        {
            _Color = inColor;
            _rank = rank;
        }
        //private string[] specialSymbols = new string[] { "$", "%", "^", "&" };
        // Första iterationen sparade CardRank i en string och sen en if sats om
        //CardRank's index var över 9 då bytes texten ut mot rätt symbol och jag 
        // satten en public bool IsSymbol som då också bytes till true. 

        //kör man symbolCheck på ett kort får man true om den är symbol annars false. 
        public bool SymbolCheck => _rank == CardRank.DollarSign || _rank == CardRank.Precent || _rank == CardRank.Ampersand || _rank == CardRank.Caret;
      
    }   
    // enum för varje kort färg och sen en för alla symbolerna i textformat. special symboler går inte att spara som enum
    // så $ % går inte att använda här.
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten , DollarSign , Precent , Caret , Ampersand}
}











