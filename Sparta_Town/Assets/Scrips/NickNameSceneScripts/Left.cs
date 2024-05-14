using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Left : MonoBehaviour, IPointerClickHandler //플레이어 1 (왼쪽) 선택시 정보 저장과 배경색 투명도 변화
{
    public GameObject other;
    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt("Player_num", 1);

        Color color = this.GetComponent<Image>().color;
        color.a = 0.6f;
        this.GetComponent<Image>().color = color;
        
        color.a = 0.4f;
        other.GetComponent<Image>().color = color;
    }

}