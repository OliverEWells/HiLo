class Card {

    string suit;
    private int number;

    public Card(string s, int n) {
        suit = s;
        number = n;
    }

    public string Name() {
        string nameOfCard = number.ToString();
        if (number == 1) {
            nameOfCard = "Ace";
        }
        else if (number == 11) {
            nameOfCard = "Jack";
        }
        else if (number == 12) {
            nameOfCard = "Queen";
        }
        else if (number == 13) {
            nameOfCard = "King";
        }
        return nameOfCard;
    }

    public bool IsHigher(Card otherCard) {
    // method on the object itself
        //okay so compare a drawn card to the previous card, the previous card is Card otherCard, it will receive that information in the game.cs file
        
        return this.number > otherCard.number; //Oh, now I get it, when you call CurrentCard, you can ask the card, CurrentCard.IsHigher(OtherCard)
    }





    // Returns a description of the card based on its suit and number
    public string Description() {
        return $"{Name()} of {suit}s";
    }
}
