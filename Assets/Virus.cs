 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Virus : BoyMover
{
    // Start is called before the first frame update
    //public TMP_Text mypoints ;
    //declare points
    //public float points=0f;

    public GameObject virus;
    //public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("virus has been hit");
        rb.useGravity=true;
        Destroy(virus,2);
        virusHitPoints();

        // points=points-5;
        // mypoints.text="points"+points;
    }
}
