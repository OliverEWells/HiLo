class Game {

    Player player = new Player();

    Score score = new Score(300);
    

    Deck deck = new Deck();

    Card CurrentCard;

    public Game() {
        CurrentCard = deck.DrawRandomCard();
    }

    public void Play() {

        var keepPlaying = true;
        while (keepPlaying) {

            Console.WriteLine("");
            Console.WriteLine($"The card is: {CurrentCard.Description()}");

            var nextCard = deck.DrawRandomCard();
            var guess = player.Guess();
            var current= score.get_score();


            if (guess == "h") {
                if (nextCard.IsHigher(CurrentCard)) {
                    current += 100;
                } else {
                    current -= 75;
                }

            } else if (guess == "l") {
                if (nextCard.IsHigher(CurrentCard)) {
                    current -= 75;
                } else {
                    current += 100;
                }
            }

            score.SetCurrentScore(current);

            Console.WriteLine($"Next card was: {nextCard.Description()}");
            Console.WriteLine($"Yours score is: {current}");
            CurrentCard = nextCard;

            keepPlaying = player.KeepPlaying();            
        }
    }
}
