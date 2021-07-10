using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public float interval= 2f;

    public float maxY = 2.5f;
    public float minY = -2.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BlockCreate", 0.5f, interval);
    }
    void BlockCreate()
    {
        int randomNumber = Random.Range(0, 3);
        GameObject obj = null;
        if (randomNumber == 0)
        {
            obj = Instantiate(Resources.Load("Block")) as GameObject;
        }
        if (randomNumber == 1)
        {
            obj = Instantiate(Resources.Load("Item")) as GameObject;
        }
        if (randomNumber == 2)
        {
            obj = Instantiate(Resources.Load("Enemy")) as GameObject;
        }
        obj.transform.SetY(Random.Range(minY, maxY));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
