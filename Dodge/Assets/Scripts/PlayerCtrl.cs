using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 10f;
    public Text txtTime;
    float timer = 0f;
    public BlockManager blockManager;

    // Update is called once per frame
    void Update()
    {
        float horizonal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizonal, 0f, vertical);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed);

        timer += Time.deltaTime;
        txtTime.text = timer.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
            Destroy(gameObject);
    }
    private void OnDestroy() { // 플레이어가 파괴되면
        blockManager.PlayerDestroy(); // 블럭 생성 멈춰라
    }

    
}
