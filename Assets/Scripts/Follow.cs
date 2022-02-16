using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Transform bg1, bg2;
    private float size;
    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //camera follow
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

        //background scroll
        if (transform.position.y < bg2.position.y)
        {
            bg2.position = new Vector3(bg2.position.x, bg1.position.y - size, bg2.position.z);
            SwitchBg();
            /*SpawnBar.k = SpawnBar.k - 1f;*/
        }
    }

    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }


}

