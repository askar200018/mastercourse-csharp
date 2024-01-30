




public abstract class Deck
{

  protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
  protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
  protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

  protected void CreateDeck()
  {
    for (int suit = 0; suit < 4; suit++)
    {
      for (int val = 0; val < 13; val++)
      {
        fullDeck.Add(new PlayingCardModel
        {
          Suit = (CardSuit)suit,
          Value = (CardValue)val,
        });
      }
    }

  }
  public void ShuffleDeck()
  {
    var rnd = new Random();
    drawPile = fullDeck.OrderBy(_ => rnd.Next()).ToList();
  }
  public abstract List<PlayingCardModel> DealCards();

  protected PlayingCardModel DrawOneCard()
  {
    PlayingCardModel output = drawPile.Take(1).First();
    drawPile.Remove(output);
    return output;
  }
}

