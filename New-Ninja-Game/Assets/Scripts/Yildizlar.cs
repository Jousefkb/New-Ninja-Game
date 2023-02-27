using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameObject Yildiz;

public class Yildizlar : MonoBehaviour
{
    NinjaStats ninja;

    List<GameObject> YildizList = new List<GameObject>();
    int YildizDegeri = 1;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 Yildizpos = gameObject.transform.position;
        YildizList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    //yýldýza deðdiðimiz anda yok olur.
    public void OnCollisionEnter2D(Collision2D col)
    {

            if (col.gameObject.CompareTag("Yildiz"))
            {
                Destroy(col.gameObject);
             YildizSayaci.instance.SayaçDegistir(YildizDegeri);
             SonDegerler.instance.OyunSonuSayacý(YildizDegeri);
             //KalanHp.instance.HpSayar(YildizDegeri);
          }
        }
    }


