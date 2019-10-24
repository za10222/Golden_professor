using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentUi_mananger : MonoBehaviour
{
    // Start is called before the first frame update
    public Panelmanager my_panelmanager;
    private List<GameObject> StudentUi_card_list;
    private void Awake()
    {
        StudentUi_card_list = new List<GameObject>();
    }
    private void OnEnable()
    {
  
       var myobject = Resources.Load<GameObject>("Prefab/Student_Card");
        for (int i = 0; i < 5; i++)//要从panelmanager里获得学生对象
        {
            StudentUi_card_list.Add(Instantiate(myobject, transform.Find("Studentlist").Find("Grid")));
          
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject s in StudentUi_card_list)//更新的时候更具学生的数据同步更新
        { 
           //读学生信息 同步更新ui
        }
    }
}
