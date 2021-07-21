using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 10f;
    public Text txtTime;
    float timer = 0f;

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
}
