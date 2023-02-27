using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SonDegerler : MonoBehaviour
{
    public static SonDegerler instance;
    public TextMeshProUGUI text;
    int yildiz;
    public GameObject gameOverScreen;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void OyunSonuSayac�(int coinValue)
    {
        yildiz += coinValue;
        if (yildiz ==10)
        {
            gameOverScreen.SetActive(true);
            Destroy(gameObject);
            yildiz += coinValue;
            text.text = "Tebrikler. T�m y�ld�zlar� toplad�n�z ";
        }

        else
        {
            text.text = "Oyun bitti. Toplanan y�ld�z = " + yildiz.ToString();
        }
        
        
        

    }
}
