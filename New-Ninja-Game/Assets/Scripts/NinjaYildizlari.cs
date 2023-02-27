using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaYildizlari : MonoBehaviour
{
    [SerializeField]
    GameObject gameObject;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(20, 0),ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >0.6)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Mermi")
        {
            Destroy(col.gameObject);
        }
    }
}
