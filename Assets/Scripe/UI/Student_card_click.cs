using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Student_card_click : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent Clickevnet;
    public void OnPointerClick(PointerEventData eventData)
    {
        Clickevnet.Invoke();
    }

    // Start is called before the first frame updat
}
