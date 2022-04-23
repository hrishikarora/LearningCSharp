int score, highScore = 120;
string playerName, highScorePlayerName = "Hrishik", score1;

Console.WriteLine("Input Player Name");
playerName = Console.ReadLine();

Console.WriteLine("Input your score");
score1 = Console.ReadLine();
score = Int32.Parse(score1);

HighScoreChecker(score, playerName);





void HighScoreChecker(int score, string playerName)
{
    if(score>highScore)
    {
        highScore = score;
        highScorePlayerName = playerName;
        Console.WriteLine($"HighScore Player is {playerName} and score is {score}");
    }
    else if(score<highScore)
    {
        Console.WriteLine($"{playerName} couldn't beat highscore which is {highScore}");
    }

    else
    {
        Console.WriteLine("score is equal to highscore but unfortunately you couldn't beat the score");
    }

}