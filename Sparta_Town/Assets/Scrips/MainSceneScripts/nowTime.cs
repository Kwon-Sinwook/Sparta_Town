using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nowTime : MonoBehaviour  // ���� �ð��� �����´�.
{
    public Text nowtime;

    void Update()
    {
        nowtime.text = DateTime.Now.ToString(("tt:HH:mm:ss"));
    }
}
