using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpClick : MonoBehaviour
{
    static bool dabam = false;
    public Text help1, help2;
    public GameObject ball1, ball2, bar1, bar2;

    private void OnMouseDown()
    {
        Debug.Log("Da bam");
        AudioClip audio = Resources.Load<AudioClip>("tap");
        AudioSource audiosrc = GetComponent<AudioSource>();
        audiosrc.PlayOneShot(audio);

        if (!dabam)
        {
            transform.localScale = new Vector2(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f);
            dabam = true;
            help1.text = "PASS";
            help2.text = "LOSE!";
            ball1.GetComponent<SpriteRenderer>().enabled = true;
            ball2.GetComponent<SpriteRenderer>().enabled = true;
            bar1.GetComponent<SpriteRenderer>().enabled = true;
            bar2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            transform.localScale = new Vector2(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f);
            dabam = false;
            help1.text = "";
            help2.text = "";
            ball1.GetComponent<SpriteRenderer>().enabled = false;
            ball2.GetComponent<SpriteRenderer>().enabled = false;
            bar1.GetComponent<SpriteRenderer>().enabled = false;
            bar2.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
