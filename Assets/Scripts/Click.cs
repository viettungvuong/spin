using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Bam();
    }

    private void Bam()
    {
        if (!Rotate.rotate)
            Rotate.rotate = true;
        else
            Rotate.rotate = false;
    }


}
