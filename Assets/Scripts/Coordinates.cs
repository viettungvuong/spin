using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinates : MonoBehaviour
{
    static Camera cam;
    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    public static float Left
    {
        get
        {
            if (cam)
                return cam.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;

            return 0.0f;
        }
    }
    public float Right
    {
        get
        {
            if (cam)
                return cam.ViewportToWorldPoint(new Vector3(1.0f, 0f, 0f)).x;

            return 0.0f;
        }
    }

    /// <summary>
    /// Top side of the screen in world coordinates
    /// </summary>
    public float Top
    {
        get
        {
            if (cam)
                return cam.ViewportToWorldPoint(new Vector3(0f, 1.0f, 0f)).y;

            return 0.0f;
        }
    }

    /// <summary>
    /// Bottom side of the screen in world coordinates
    /// </summary>
    public float Bottom
    {
        get
        {
            if (cam)
                return cam.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;

            return 0.0f;
        }
    }
}
