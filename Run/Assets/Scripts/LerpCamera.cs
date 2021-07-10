using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour
{
    public GameObject destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destination == null)
            return;

        transform.position = Vector3.Lerp(transform.position, destination.transform.position, 0.01f);
       // 나 자신의 위치를 갱신 , 두번째 인자 - 목표지점 위치
       // 카메라가 목표지점을 계속 따라가는 것 
    }
}
