namespace BookOO
{
    public class Card
    {
        public CardColor _Color { get; }
        public string _rank { get; } = "";
        public Card(string inColor, int rank)
        {
            CardColor isInColor;
            if (CardColor.TryParse(inColor, out isInColor))
            {
                _Color = isInColor;
            }
            if (rank < 10)
                _rank = ((CardRank)rank).ToString();
            if (rank < 14 & rank > 9 )
            {
                rank -= 10;
                CardSymbols cardSymbols = new CardSymbols(rank);
                _rank = cardSymbols.GetCardSmybol();
            }
        }
    }
    public class CardSymbols
    {
        public string _cardSymbol { get; } = "";
        private string[] specialSymbols = new string[] { "$", "%", "^", "&" };
        public CardSymbols(int sNumber)
        {
            _cardSymbol = specialSymbols[sNumber];
        }
        public string GetCardSmybol()
        {
            return _cardSymbol;
        }
    }
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
}











