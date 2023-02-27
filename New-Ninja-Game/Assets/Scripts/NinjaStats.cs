using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class NinjaStats : MonoBehaviour
{
       public int hp = 3;
    
    
    [SerializeField]
    GameObject ninjaYildizlariPrefab;
    public static bool isGameOver;
    public GameObject gameOverScreen;
    //public static YildizSayaci instance;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text;
    int SonYildiz = 1;
    private void Awake()
    {
        isGameOver = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Vector3 NinjaYildizlariPos = gameObject.transform.position;
            Instantiate(ninjaYildizlariPrefab, NinjaYildizlariPos, Quaternion.identity);
        }
        if (hp > 0)
        {
            gameOverScreen.SetActive(false);
        }
        else if (hp <= 0)
        {
            Destroy(gameObject);
            gameOverScreen.SetActive(true);

        }
        OyunKontrol.isGameOver = true;
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Mermi") || collision.collider.CompareTag("Dikenler"))
        {
            --hp;
            text1.text = "HP = " + hp.ToString();
        }

    }
}
