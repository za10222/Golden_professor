using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentUi_mananger : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> StudentUi_card_list;
 
    private void OnEnable()
    {
        
        StudentUi_card_list = new List<GameObject>();
        var myobject = Resources.Load<GameObject>("Prefab/Student_Card");
        foreach(Student s in GameManager.mymanager.students)
        {
            var temp=Instantiate(myobject, transform.Find("Studentlist").transform.Find("Grid"));
            Debug.Log("CCC:"+ s.getid());
            temp.GetComponent<Student_card>().mystudent_id=s.getid();
            temp.SetActive(false);
            temp.SetActive(true);
            StudentUi_card_list.Add(temp);
      
        }
       
        
       
    }

    private void OnDisable()
    {
        foreach (GameObject s in StudentUi_card_list)
        {
            Destroy(s);
  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
