using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     InvokeRepeating("Test",1f,0.5f);   // 대기 주기 한번 지정하면 바꾸기 어려움 
    // }
    // void Test(){
    //     Debug.Log("Test");
    // }

    private void Start(){
        StartCoroutine("Test"); // 테스트 함수 코루틴 시켜라
    }
    IEnumerator Test(){ // 코루틴의 반환값 주의
        yield return new WaitForSeconds(1f); // 1초 대기후 다음 내용 실행
    
        while(true){ // 무한루프
            Debug.Log("Test");

            yield return null; // 한프레임만큼 대기 
        }
    }
}
