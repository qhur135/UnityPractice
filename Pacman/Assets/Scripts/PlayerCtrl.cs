using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Text txtScore;
    public Text Result;
    int curScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal,0f,vertical);
        transform.Translate(movement * Time.deltaTime * moveSpeed); // 힘으로 이동하는 것이 아니라 일정한 속도로 원하는 곳으로 이동하도록 함
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Item"){
            Destroy(other.gameObject);
            curScore+=1;
            txtScore.text = curScore.ToString();

            if(curScore==8){
                Result.text = "Clear";
                Time.timeScale = 0.1f; // 시간이 흐르는 속도 - 시간이 본래 시간의 1/10로 흐름 시간이 느리게 흐른다
            }
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag =="Enemy"){
            Destroy(gameObject);
            Result.text = "Game Over";
        }
    }
}
