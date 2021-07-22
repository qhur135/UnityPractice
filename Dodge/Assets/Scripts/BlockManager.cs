using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BlockCreate",0.5f,0.5f); // 해당 함수 반복 실행
    }
    void BlockCreate()
    {
        GameObject obj = Instantiate(Resources.Load("Block")) as GameObject;

        Vector3 pos = obj.transform.position;
        pos.x = Random.Range(-5f, 5f);
        pos.z = Random.Range(-5f, 5f);
        obj.transform.position = pos;
    }
    public void PlayerDestroy(){ // 다른 클래스에서 호출
        CancelInvoke("BlockCreate"); // invoke 멈춘다
    }
}
