using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketScript : MonoBehaviour
{
    float timer;
    Rigidbody2D rb;
    //g�lleye bir hareket verir
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 0), ForceMode2D.Impulse);
    }

        
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.7)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
    //ninja y�ld�z�, g�lleye de�ince g�lleyi yok eder
    public void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag =="NinjaYildizi")
        { 
                Destroy(col.gameObject); 
        }
        if (col.gameObject.tag == "Ninja")
        {
            Destroy(gameObject);
        }
        
    }
}
