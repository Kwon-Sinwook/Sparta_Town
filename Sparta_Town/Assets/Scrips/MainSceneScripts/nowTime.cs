using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nowTime : MonoBehaviour
{
    public Text nowtime;

    // Update is called once per frame
    void Update()
    {
        nowtime.text = DateTime.Now.ToString(("tt:HH:mm:ss"));
    }
}
