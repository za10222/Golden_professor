using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button_close : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.parent.gameObject.SetActive(false);
    }
}
