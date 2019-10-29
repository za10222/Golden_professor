using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student_information : MonoBehaviour
{
    // Start is called before the first frame update
    public int mystudent_id;
    private void OnEnable()
    {
        var mystudent = GameManager.mymanager.findStudent(mystudent_id);
        transform.Find("Text_Work").GetComponent<Text>().text = "当前工作:"+ mystudent.State.GetType().Name;
        transform.Find("Text_Status").GetComponent<Text>().text = "心情:"+mystudent.Mood;
        transform.Find("Text_Basicinfor").GetComponent<Text>().text = "姓名:" + mystudent.Name+"\n"+"个人介绍："+mystudent.Description;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
