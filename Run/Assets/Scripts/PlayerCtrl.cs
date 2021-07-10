using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl : MonoBehaviour
{
    public float jumpPower=300;
    int jumpCount = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true && jumpCount>0)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpPower);
            jumpCount--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumpCount = 2; // 발판에 닿으면 점프카운터 회복
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Destroy(other.gameObject); // 아이템과 부딪히면 아이템 사라짐
        }
        else if(other.tag == "Enemy")
        {
            transform.DetachChildren();
            Destroy(gameObject); // 장애물과 부딪히면 플레이어 사라짐
        }
    }
}
