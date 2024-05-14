using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour // 씬에서 넘어올 때, 작성한 닉네임을 가져오고 적용한다.
{
    private Text name;

    void Start()
    {
        name = GetComponent<Text>();
        name.text = PlayerPrefs.GetString("PlayerName");
    }

  
}
