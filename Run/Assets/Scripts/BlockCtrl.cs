using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCtrl : MonoBehaviour
{
    public float movespeed=3f;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.left + new Vector3(0f,Random.Range(-0.1f,0.1f), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction *Time.deltaTime *movespeed);
    }
}
