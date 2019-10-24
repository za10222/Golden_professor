using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] panels; //0:开始界面 1:游戏界面1 2:邮箱界面 3：学生界面
    public Button_start button_start;
    public Button_mail button_mail;
    public Button_student button_student;
    void Start()
    {
        button_start.Clickevnet.AddListener(Button_start_click);
        button_mail.Clickevnet.AddListener(Button_mail_click);
        button_student.Clickevnet.AddListener(Button_student_click);
    }
    void Button_start_click()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
    }
    void Button_mail_click()
    {
        panels[2].SetActive(true);
    }
    void Button_student_click()
    {
        panels[3].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
