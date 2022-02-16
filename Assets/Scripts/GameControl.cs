using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Text help1, help2;
    public GameObject ball1, ball2, bar1, bar2;
    void Start()
    {
        help1.text = "";
        help2.text = "";
        ball1.GetComponent<SpriteRenderer>().enabled = false;
        ball2.GetComponent<SpriteRenderer>().enabled = false;
        bar1.GetComponent<SpriteRenderer>().enabled = false;
        bar2.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnApplicationQuit()
    {
        Ad.instance.bannerView.Destroy();
    }
}
