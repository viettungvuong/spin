using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text finalscore, bestscore;
    public static GameOver instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        AudioClip audio = Resources.Load<AudioClip>("fail");
        AudioSource audiosrc = GetComponent<AudioSource>();
        audiosrc.PlayOneShot(audio);
        finalscore.text = Scoring.instance.GetDiem().ToString();

        if (PlayerPrefs.GetInt("BestScore") < Scoring.instance.GetDiem())
        {
            PlayerPrefs.SetInt("BestScore", Scoring.instance.GetDiem());
            PlayGames.AddScoreToLeaderboard(Scoring.instance.GetDiem());
        }

        bestscore.text = "Best: " + PlayerPrefs.GetInt("BestScore").ToString();

        Scoring.instance.ResetDiem();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
