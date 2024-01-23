using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClock : MonoBehaviour
{
    public Text timeTxt;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeOnScreen());
    }

    void GetCurrentTime()
    {

        timeTxt.text = DateTime.Now.ToString("hh:mm");
    }
    IEnumerator TimeOnScreen()
    {
        while(true)
        {
            GetCurrentTime();
            yield return new WaitForSeconds(60);
        }

    }
}
