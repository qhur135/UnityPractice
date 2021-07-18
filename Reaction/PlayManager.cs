using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public Text question;
    public Text result;

    bool stop = true;
    
    // Start is called before the first frame update
    void Start()
    {
        result.text = "";
        stop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(string str)
    {
        if (stop == false)
        {
            stop = true;
            if (question.text == str)
            {
                result.text = "Success!";
            }
            else
            {
                result.text = "Fail..";
            }
        }   
    }
    public void OnStartClick()
    {
        if (stop == true)
        {
            stop = false;

            result.text = "";

            // 기능 추가
            int number = Random.Range(0, 4);
            if (number == 0)
            {
                question.text = "A";
            }
            else if (number == 1)
            { 
                question.text = "B";
            }
            else if (number == 2)
            {
                question.text = "C";
            }
            else if (number == 3)
            {
                question.text = "D";
            }
    }
}