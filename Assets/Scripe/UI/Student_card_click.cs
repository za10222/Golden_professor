using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Student_card_click : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(123);
        var s=GameObject.Find("StudentUi").transform.Find("Image");
        var s1 = s.transform.Find("Student_Information");
        var s2=s1.GetComponent<Student_information>();
        s2   .mystudent_id = transform.GetComponent<Student_card>().mystudent_id;
        s.gameObject.SetActive(true);
    }

    // Start is called before the first frame updat
}
