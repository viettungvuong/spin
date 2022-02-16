using UnityEngine;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class PlayGames : MonoBehaviour
{
    static string leaderboardID = "CgkI2-es-Y0MEAIQAg";
    public static PlayGamesPlatform platform;
    public static bool login;

    void Start()
    {
        if (platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            platform = PlayGamesPlatform.Activate();
        }

        Social.Active.localUser.Authenticate(success =>
        {
            if (success)
            {
                login = true;
            }
            else
            {
                login = false;
            }
        });

    }

    public static void AddScoreToLeaderboard(int a)
    {
        if (Social.Active.localUser.authenticated)
        {
            Social.ReportScore(a, leaderboardID, success => { });
        }
    }

    public static void ShowLeaderboard()
    {
        if (Social.Active.localUser.authenticated)
        {
            platform.ShowLeaderboardUI();
        }
    }

    public void ShowAchievements()
    {
        if (Social.Active.localUser.authenticated)
        {
            platform.ShowAchievementsUI();
        }
    }
    

}

