using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Left : MonoBehaviour, IPointerClickHandler //�÷��̾� 1 (����) ���ý� ���� ����� ���� ���� ��ȭ
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