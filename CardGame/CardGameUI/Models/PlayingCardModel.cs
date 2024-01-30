









public class PlayingCardModel
{
  public CardSuit Suit { get; set; }
  public CardValue Value { get; set; }
  public override string ToString()
  {
    return $"{Value} {Suit}";
  }
}

