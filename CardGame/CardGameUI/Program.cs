

// ********* PRO TIP ****************
// There is more than one way to accomplish something.
// Pick the way that is easiest to maintain and improve.

BlackjackDeck deck = new BlackjackDeck();
var hand = deck.DealCards();

foreach (var card in hand)
{
  System.Console.WriteLine(card);
}

Console.ReadLine();

