using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChoice : MonoBehaviour // 씬에서 넘어 올 때, 플레이러프리펩스 정보로 선택한 캐릭터만 활성화한다.
{
    public GameObject player1;
    public GameObject player2;

    public void Start()
    {
        if(PlayerPrefs.GetInt("Player_num") == 1)
        {
            player1.SetActive(true);
            player2.SetActive(false);
        }

        else
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }
}
