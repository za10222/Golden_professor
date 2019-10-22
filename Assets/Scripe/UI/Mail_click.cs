using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mail_click : MonoBehaviour, IPointerClickHandler
{
    private string Showtext = "你好\n今年年底发不出两篇顶会论你就等着滚蛋吧！\n祝好-您的boss";
    public GameObject Mailtext_ui;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(123);

        var text=Mailtext_ui.transform.Find("Text").GetComponent<Text>();
        text.text =Showtext;
        Mailtext_ui.SetActive(true);
    }

 

 
}
