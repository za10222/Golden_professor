using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button_start : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject canvas= GameObject.Find("Canvas");
        Debug.Log("Hi there");
        var panelmanger= canvas.GetComponent<Panelmanager>();
        panelmanger.panels[0].SetActive(true);
        panelmanger.panels[1].SetActive(false);

    }
}
