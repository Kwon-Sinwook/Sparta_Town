using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
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
