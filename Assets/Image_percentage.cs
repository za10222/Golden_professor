using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_percentage : MonoBehaviour
{
    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {
        transform.Find("Text").GetComponent<Text>().text=GetComponent<Image>().fillAmount*100+"%";
    }
}
