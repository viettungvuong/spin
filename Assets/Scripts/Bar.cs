using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour, IPool
{
    // Start is called before the first frame update
    public void OnObjectSpawn()
    {
        int rand = Random.Range(0, 4);
        Color color = new Color32();
        switch (rand)
        {
            case 0:
                color = new Color32(235, 217, 32, 255); //yellow
                break;
            case 1:
                color = new Color32(233, 26, 26, 255); // red
                break;
            case 2:
                color = new Color32(71, 211, 79, 255); // green
                break;
            case 3:
                color = new Color32(44, 86, 130, 255); // blue
                break;
        }
        transform.localScale = new Vector3(Screen.width, transform.localScale.y, transform.localScale.z);
        GetComponent<SpriteRenderer>().color = color;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
