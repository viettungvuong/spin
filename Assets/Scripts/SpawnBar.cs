using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnBar : MonoBehaviour
{
    public static Transform bg, bar, rotate;
    public static float y2, k, i, q;
    void Start()
    {
        bg = GameObject.FindGameObjectWithTag("background").transform;
        bar = GameObject.FindGameObjectWithTag("bar").transform;
        y2 = bar.position.y;
        k = -3;
        for (int i = 0; i < 10; i++)
            Spawn();
    }

    // Update is called once per frame

    public static void Spawn()
    {
        Vector3 vt3 = new Vector3(Coordinates.Left, k, bar.position.z);
        Pool.instance.SpawnFromPool(vt3);
        if (Scoring.instance.GetDiem() <= 20)
        {
            i = 3.5f;
            q = 6.5f;
        }

        else
        {
            i = 4f;
            q = 8f;
        }

        k = k - Random.Range(i, q);
    }


}
