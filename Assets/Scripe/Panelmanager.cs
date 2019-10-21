using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] panels;
    public Button_start button_start;
    void Start()
    {
        button_start.Clickevnet.AddListener(Button_start_click);
    }
    void Button_start_click()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
