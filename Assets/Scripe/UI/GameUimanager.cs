using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUimanager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject DayUi;
    private GameObject MoneyUi;
    void Start()
    {
        //初始化Dayui
        DayUi = transform.Find("Image_Day").gameObject;
        MoneyUi = transform.Find("Image_Money").gameObject;
        //var DayText = DayUi.transform.Find("Text_Day").GetComponent<Text>();
        //DayText.text = "第" + day + "天";
    }

    void GameUiupdate()
    {
        //更新天数ui
        Image DayImage = DayUi.GetComponent<Image>();
        DayImage.fillAmount = (float)GameManager.mymanager.framenow/ GameManager.mymanager.frameday;//计算百分比
        var DayText = DayUi.transform.Find("Text_Day").GetComponent<Text>();
        DayText.text = "第" + GameManager.mymanager.day + "天";

        //更新金钱ui
        Text MoneyText = MoneyUi.transform.Find("Text_Money").GetComponent<Text>();
        MoneyText.text = "经费:"+GameManager.mymanager.money;
    }
    // Update is called once per frame
    void Update()
    {
        GameUiupdate();
    }
}
