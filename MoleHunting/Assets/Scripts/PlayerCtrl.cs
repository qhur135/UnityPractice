using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    bool run = false;

    private void Update(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal,0f,vertical);

        if(movement != Vector3.zero){
            transform.Translate(movement*Time.deltaTime,Space.World);
            Animator anim = GetComponent<Animator>();
            anim.SetBool("Run",true);
            
            transform.forward = Vector3.Lerp(transform.forward,movement,0.05f); // 바라보는 방향 지정 . 보강법
        }
        else{
            Animator anim = GetComponent<Animator>();
            anim.SetBool("Run",false);
        }

        if(Input.GetButtonDown("Jump")==true){ 
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up*300f); // 이동
            Animator anim = GetComponent<Animator>();
            anim.SetBool("Jump",true); // 애니메이션
        }
    }
    private void OnCollisionEnter(Collision collision) {
        Animator anim = GetComponent<Animator>();
        anim.SetBool("Jump",false);
    }
}
