using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Button_mail : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public UnityEvent Clickevnet;
    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        Clickevnet.Invoke();
    }
}
