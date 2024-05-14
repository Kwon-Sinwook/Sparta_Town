using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChoice : MonoBehaviour
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
