using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firlatici : MonoBehaviour
{
    public float timer;
    public GameObject roket;
    public Transform roketPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //f�rlat�c�n�n zamanlamas�
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>2)
        {
            timer = 0;
            shoot();
        }
        
    }
    //f�lart�c�dan ��kacak olan roketin create metodu
    void shoot()
    {
        Instantiate(roket, roketPos.position, Quaternion.identity);
    }
}
