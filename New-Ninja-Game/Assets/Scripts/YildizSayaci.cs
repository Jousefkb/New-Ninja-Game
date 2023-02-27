using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class YildizSayaci : MonoBehaviour
{
    public static YildizSayaci instance;
    public TextMeshProUGUI text;
    int yildiz;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }   
    }
    public void SayaçDegistir (int coinValue)
    {
        yildiz += coinValue;

        text.text = "X" + yildiz.ToString();
    }
    

}
