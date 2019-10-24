using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Button_student : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent Clickevnet;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        Clickevnet.Invoke();
    }
}
