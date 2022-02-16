using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [System.Serializable]
    public class GamePooling
    {
        public GameObject prefab;
        public int size;
    }
    public GamePooling pool;
    public static Pool instance; //singleton

    private void Awake()
    {
        instance = this;
    }
    public Queue<GameObject> queue;
    void Start()
    {
        queue = new Queue<GameObject>();
        for (int i = 0; i < pool.size; i++)
        {
            GameObject obj = Instantiate(pool.prefab);
            obj.SetActive(false);
            queue.Enqueue(obj);
        }
    }

    // Update is called once per frame
    public GameObject SpawnFromPool(Vector3 position)
    {
        GameObject spawn = queue.Dequeue();
        spawn.SetActive(true);
        spawn.transform.position = position;
        IPool ipool = spawn.GetComponent<IPool>();
        if (ipool != null)
            ipool.OnObjectSpawn();
        queue.Enqueue(spawn);
        return spawn;
    }
}
