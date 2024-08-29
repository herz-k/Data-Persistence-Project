using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static MainManager;

public class LeaderboardScript : MonoBehaviour
{
    public TextMeshProUGUI leaderText;
    List<PlayerScore> LoadLeaderboard()
    {
        List<PlayerScore> leaderboard = new List<PlayerScore>();
        int count = PlayerPrefs.GetInt("LeaderboardCount", 0);

        for (int i = 0; i < count; i++)
        {
            string playerName = PlayerPrefs.GetString("LeaderboardName_" + i, "");
            int score = PlayerPrefs.GetInt("LeaderboardScore_" + i, 0);

            PlayerScore playerScore = new PlayerScore { playerName = playerName, score = score };
            leaderboard.Add(playerScore);
        }

        return leaderboard;
    }
    void Awake()
    {
        List<PlayerScore> leaderboard = LoadLeaderboard();
        leaderText.text = "";
        int rank = 1;
        foreach (PlayerScore playerScore in leaderboard)
        {
            leaderText.text += rank + ". " + playerScore.playerName + ": " + playerScore.score + "\n";
            rank++;
        }
    }
}
