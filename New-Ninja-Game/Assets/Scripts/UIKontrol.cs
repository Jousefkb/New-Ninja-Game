using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject oynaButon = default;

    [SerializeField]
    GameObject Ninjaprefab = default;

    GameObject Ninja;
    Text puanText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OyunBasladi()
    {
     
        oynaButon.gameObject.SetActive(false);
       // Ninja = Instantiate(Ninjaprefab);
        PuaniGuncelle();
    }
    public void OyunBitti()
    {
      //  Ninja.gameObject.SetActive(false);
        oynaButon.gameObject.SetActive(true);
    }
    void PuaniGuncelle()
    {
        //puanText.text = ;
    }

}
