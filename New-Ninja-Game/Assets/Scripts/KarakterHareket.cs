using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
     public GameObject karakter;
    const float hareketGucu = 8;
    Rigidbody2D myRigidbody2D;
    float yatayInput;
    float dikeyInput;
    float grounded;
    bool isGrounded;
    public Transform pos;
    public LayerMask groundLayers;
    float zipla = 8;
    // Start is called before the first frame update
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;
        yatayInput = Input.GetAxis("Horizontal");
        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketGucu;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            myRigidbody2D.velocity = Vector2.up * zipla;
        }

        isGrounded = Physics2D.OverlapCapsule(pos.position, new Vector2(6.5f, 8.5f), CapsuleDirection2D.Horizontal,0, groundLayers);
        if (Input.GetKeyUp(KeyCode.W) && isGrounded)
        {
            if (myRigidbody2D.velocity.y > 0)
            {

            }
        }
        transform.rotation = Quaternion.Euler(0, 0, 0);
        }

   void FixedUpdate()
   {
     myRigidbody2D.velocity = new Vector2(hareketGucu * yatayInput, myRigidbody2D.velocity.y);
   }

}
