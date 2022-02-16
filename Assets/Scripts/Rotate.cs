using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public static bool rotate = true;
    private static float k;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Scoring.instance.GetDiem() <= 20)
            k = 4.25f;
        else
            k = 5.75f;
        if (rotate)
            transform.Rotate(Vector3.forward * k);
        else
            transform.Rotate(-Vector3.forward * k);
    }
}
