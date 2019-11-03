using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Manager mymanager;
     void Awake()
    {

        Application.targetFrameRate = 120 ;
        if (mymanager == null)
        {
            mymanager = new Manager();                  
            mymanager.students.Add(new Student("qingzheng", "长得很胖\n爱吃饭", 34, 100, 0.2, State.Idle));
            mymanager.students.Add(new Student("sb", "长得很瘦\n不爱吃饭", 34, 100, 0.2, State.Idle));
            mymanager.tasks.Add(new Task("超级水刊", 0.1, 100));
            mymanager.tasks.Add(new Task("超级顶刊max", 0.1, 100));

        }
    }
    private void Update()
    {
        mymanager.framenow = (mymanager.framenow + 1);
        if (mymanager.framenow%mymanager.frameday==0)
        {
            mymanager.day = mymanager.day + 1;
            mymanager.money = mymanager.money + 1;
            mymanager.framenow = 0;
        }
        
    }

}

 
