using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour // 적은 닉네임 저장 후 메인씬으로 넘어간다.
{
    public InputField inputName;
    private string playerName;

    public void StartGame()
    {
        playerName = inputName.text;

        if (2 <= playerName.Length && playerName.Length <= 10)
        {   
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }
}
