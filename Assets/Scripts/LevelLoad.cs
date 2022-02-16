using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public Animator transition;
    public static LevelLoad instance;
    private void Awake()
    {
        instance = this;
    }
    public void LoadLevel(string level)
    {
        StartCoroutine(load(level));
    }

    IEnumerator load(string level)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
}
