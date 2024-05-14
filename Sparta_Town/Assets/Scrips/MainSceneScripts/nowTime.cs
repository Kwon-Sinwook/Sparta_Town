using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nowTime : MonoBehaviour  // 현재 시간을 가져온다.
{
    public Text nowtime;

    void Update()
    {
        nowtime.text = DateTime.Now.ToString(("tt:HH:mm:ss"));
    }
}
