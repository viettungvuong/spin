using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private int score;
    public Text scoretext;
    public static Scoring instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
    }

    public void CongDiem()
    {
        score++;
        scoretext.text = score.ToString();
    }

    public int GetDiem()
    {
        return score;
    }

    public void ResetDiem()
    {
        score = 0;
    }
}
