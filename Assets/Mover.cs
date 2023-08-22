using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float force1 = 3f;
    public float upforce = 10f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey("up"))
        {
            rb.AddForce(0,0,force1);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0,0,-force1);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(force1, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-force1, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upforce, 0);
        }
    }
        
    
}
