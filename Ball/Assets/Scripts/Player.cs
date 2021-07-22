using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text score;
    int curScore;
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        Vector3 movement = new Vector3(horizontal,jump * 20,vertical);
        transform.Translate(movement*Time.deltaTime*moveSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        curScore = curScore + 1;
        score.text = curScore.ToString();
    }
}
