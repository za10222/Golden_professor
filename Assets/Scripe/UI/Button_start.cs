﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Button_start : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public UnityEvent Clickevnet;

    public void OnPointerClick(PointerEventData eventData)
    {
        Clickevnet.Invoke();
    
    }
}
