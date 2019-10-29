using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student_card : MonoBehaviour
{
    public int  mystudent_id;
    // Start is called before the first frame update
    void OnEnable()
    {
        var mystudent = GameManager.mymanager.findStudent(mystudent_id);
        Debug.Log("studentcard:"+ mystudent_id); 
        transform.Find("Text_Studentname").GetComponent<Text>().text=mystudent.Name;
        transform.Find("Text_Status").GetComponent<Text>().text = mystudent.State.GetType().Name;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
