using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUimanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DayUi;
    private int day;
    void Start()
    {
        day = 0;
        //初始化Dayui
        Image DayImage = DayUi.GetComponent<Image>();
        DayImage.fillAmount = 0;
        var DayText = DayUi.transform.Find("Text_Day").GetComponent<Text>();
        DayText.text = "第"+day+"天";
    }

    void DayUiupdate()
    {
        Image DayImage = DayUi.GetComponent<Image>();
        DayImage.fillAmount+=Time.deltaTime /3;
        if(DayImage.fillAmount >= 1)
        {
            DayImage.fillAmount = 0;
            var DayText = DayUi.transform.Find("Text_Day").GetComponent<Text>();
            day = day + 1;
            DayText.text = "第" + day + "天";
          
        }
    }
    // Update is called once per frame
    void Update()
    {
        DayUiupdate();
    }
}
