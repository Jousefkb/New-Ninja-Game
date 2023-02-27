using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject karakter;
    private Vector3 PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //karakter takip
        PlayerPos = new Vector3(karakter.transform.position.x, karakter.transform.position.y, karakter.transform.position.z);   

    }
}
