using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    private float accumulate, k;
    void Start()
    {
        accumulate = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Scoring.instance.GetDiem() <= 20)
            k = 0.045f;
        /*else if (Scoring.instance.GetDiem()==25)
            k = 0.14f;*/
        else
            k = 0.065f;
        transform.position = new Vector3(transform.position.x, transform.position.y - k, transform.position.z);
        accumulate = accumulate + k;
        if (accumulate >= 1f)
        {
            accumulate = 0f;
            SpawnBar.Spawn();
        }
    }
}
