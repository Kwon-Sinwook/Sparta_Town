using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour // ������ �Ѿ�� ��, �ۼ��� �г����� �������� �����Ѵ�.
{
    private Text name;

    void Start()
    {
        name = GetComponent<Text>();
        name.text = PlayerPrefs.GetString("PlayerName");
    }

  
}
