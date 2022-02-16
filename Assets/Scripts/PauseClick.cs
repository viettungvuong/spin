using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseClick : MonoBehaviour
{
    static bool paused = false;
    public GameObject player;
    static Vector3 originalScale;
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (!paused)
        {
            paused = true;
            Time.timeScale = 0;
            transform.localScale = originalScale * 0.8f;
            player.SetActive(false); 
        }
        else
        {
            paused = false;
            Time.timeScale = 1;
            transform.localScale = originalScale;
            player.SetActive(true);
        }
        Debug.Log("pause bam!");
    }
}
