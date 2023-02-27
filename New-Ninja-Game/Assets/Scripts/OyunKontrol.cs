using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject ninjaPrefab = default;
    UIKontrol uikontrol;
    GameObject Ninja;
    // Start is called before the first frame update

    public static bool isGameOver;
    public GameObject gameOverScreen;
    private void Awake()
    {
        isGameOver = false;
    }
    void Start()
    {
        uikontrol = GetComponent<UIKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }
    public void OyunuBaslat()
    {
        //uikontrol.OyunBasladi();
        //Ninja = Instantiate(ninjaPrefab);
       // Ninja.transform.position = new Vector3(0, .Alt + 1.5f
    }
    public void OyunuBitir()
    {
        
        //uikontrol.OyunBitti();
    }
}
