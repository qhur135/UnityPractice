using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Text txtScore;
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
        }
    }
}
