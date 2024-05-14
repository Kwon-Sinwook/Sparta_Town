using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Right : MonoBehaviour, IPointerClickHandler
{
    public GameObject other;

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt("Player_num", 2);

        Color color = this.GetComponent<Image>().color;
        color.a = 0.6f;
        this.GetComponent<Image>().color = color;

        color.a = 0.4f;
        other.GetComponent<Image>().color = color;
    }

}