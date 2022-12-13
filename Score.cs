class Score {


    private int CurrentScore;

    public int get_score() {
        return CurrentScore;
        }

    public Score(int defaultScore) {
        CurrentScore = defaultScore;
    }

    public void SetCurrentScore(int newScore) {
        CurrentScore = newScore;
    }
}
