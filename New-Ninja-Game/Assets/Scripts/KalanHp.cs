using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KalanHp : MonoBehaviour
{
    public static KalanHp instance;
    //public TextMeshProUGUI text;
   // public int hp = 3;
    //public GameObject gameOverScreen;
    NinjaStats ninjaStats;
    // Start is called before the first frame update
    void Start()
    {
        //if (instance == null)
        //{
        //    instance = this;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        //if (hp > 0)
        //{
        //    gameOverScreen.SetActive(false);
        //}
        //else if (hp <= 0)
        //{
        //    Destroy(gameObject);
        //    gameOverScreen.SetActive(true);

        //}
        //OyunKontrol.isGameOver = true;
    }
    //public void HpSayar(int coinvalue) { 
    // void OnCollisionEnter2D(Collision2D collision)
    //    {
    //        if (collision.collider.CompareTag("Mermi"))
    //        {
    //            hp--;
    //        }
    //    }
    //        hp += coinvalue;
    //        text.text = "HP =  " + hp.ToString();
    //}
}
