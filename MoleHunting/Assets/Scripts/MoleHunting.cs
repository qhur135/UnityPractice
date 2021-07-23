using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleHunting : MonoBehaviour
{
    public Text txtScore;

    public Text txtBtn1;
    public Text txtBtn2;
    public Text txtBtn3;
    public Text txtRemainTime;
    float remainTime = 10f;

    int curScore = 0;
    string answer;

    bool inputEnable = true;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("ButtonRefresh",1f,1f);
    }
    void Update(){
        remainTime -= Time.deltaTime;
        
        if(remainTime>0f){
            txtRemainTime.text = remainTime.ToString("f2");
        }
        else{
            txtRemainTime.text = "0.00";
            inputEnable = false;
            CancelInvoke("ButtonRefresh");
        }   
    }
    void ButtonRefresh(){

        inputEnable = true;

        txtBtn1.text="-";
        txtBtn2.text="-";
        txtBtn3.text="-";
        int number = Random.Range(0,3);
        if(number==0){
            txtBtn1.text="0";
            answer="1";
        }
        if(number==1){
            txtBtn2.text="0";
            answer="2";
        }
        if(number==2){
            txtBtn3.text="0";
            answer="3";
        }

    }

    public void OnButton(string str){

        if(inputEnable == false)
            return;

        // inputEnable = false;

        CancelInvoke("ButtonRefresh");
        InvokeRepeating("ButtonRefresh",0f,1f);

        if(answer ==str)
            curScore+=100;
        else
            curScore-=100;

        txtScore.text = curScore.ToString();
        
    }
}
