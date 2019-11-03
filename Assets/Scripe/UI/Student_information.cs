using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student_information : MonoBehaviour
{
    // Start is called before the first frame update
    public int mystudent_id;
    Dropdown dropdown_status;
    Dropdown dropdown_sub;


    void Awake()
    {
        dropdown_status = transform.Find("Dropdown_status").GetComponent<Dropdown>();
        dropdown_status.onValueChanged.AddListener(dropdown_status_onvaluechange);
        dropdown_sub = transform.Find("Dropdown_sub").GetComponent<Dropdown>();
        dropdown_sub.onValueChanged.AddListener(dropdown_sub_onvaluechange);

    }
    private void dropdown_sub_onvaluechange(int value)
    {
        if(value!=0)
        {
            var mystudent = GameManager.mymanager.findStudent(mystudent_id);
            //找到目标task
            mystudent.Changestate(State.Work, GameManager.mymanager.tasks[value - 1]);
            Debug.Log(mystudent.state);
        }
    }
    private void dropdown_status_onvaluechange(int value)
    {
        var mystudent = GameManager.mymanager.findStudent(mystudent_id);
        switch (value)
        {
            case 0:
                mystudent.Changestate(State.Idle);
                dropdown_sub.gameObject.SetActive(false);
                break;
            case 1:
                mystudent.Changestate(State.learning);
                dropdown_sub.gameObject.SetActive(false);
                break;
            case 2:
                mystudent.Changestate(State.Write);
                dropdown_sub.gameObject.SetActive(false);
                break;
            case 3:
                dropdown_sub.options.Clear();
                List<string> options = new List<string>();
                options.Add("无");
                foreach (var item in GameManager.mymanager.tasks)
                {
                    options.Add(item.Name);
                }
                dropdown_sub.AddOptions(options);
                dropdown_sub.gameObject.SetActive(true);
                dropdown_sub.value = 0;
                break;
        }
    }
    private void OnEnable()
    {
        var mystudent = GameManager.mymanager.findStudent(mystudent_id);
        transform.Find("Text_Work").GetComponent<Text>().text = "当前工作:"+ mystudent.state;
        transform.Find("Text_Status").GetComponent<Text>().text = "心情:"+mystudent.Mood;
        transform.Find("Text_Basicinfor").GetComponent<Text>().text = "姓名:" + mystudent.Name+"\n"+"个人介绍："+mystudent.Description;
        dropdown_sub.gameObject.SetActive(false);
        Debug.Log("status=" + mystudent.state);
        dropdown_status.value = (int)mystudent.state;
        dropdown_status_onvaluechange(dropdown_status.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
