using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bar") && (collision.gameObject.GetComponent<SpriteRenderer>().color != Color.white))
        {
            Color color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            string mau = this.gameObject.name;
            Color compare = new Color();
            if (mau == "yellowball")
                compare = new Color32(235, 217, 32, 255);
            else if (mau == "blueball")
                compare = new Color32(44, 86, 130, 255);
            else if (mau == "greenball")
                compare = new Color32(71, 211, 79, 255);
            else if (mau == "redball")
                compare = new Color32(233, 26, 26, 255);
            if (color == compare)
            {

                Scoring.instance.CongDiem();
                collision.gameObject.SetActive(false);
                AudioClip audio = Resources.Load<AudioClip>("win");
                AudioSource audiosrc = GetComponent<AudioSource>();
                audiosrc.PlayOneShot(audio);
            }
            else if (color != compare)
            {
                Debug.Log("Sai");
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }

    }
}
