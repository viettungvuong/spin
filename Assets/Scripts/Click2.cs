using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        AudioClip audio = Resources.Load<AudioClip>("tap");
        AudioSource audiosrc = GetComponent<AudioSource>();
        audiosrc.PlayOneShot(audio);
        transform.localScale = new Vector2(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f);
        SceneManager.LoadScene("Menu");
    }
}
