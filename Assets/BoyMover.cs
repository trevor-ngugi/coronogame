using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoyMover : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public float force1=10f;

    public TMP_Text mypoints ;
    //declare points
    public float points=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            anim.Play("run");
            rb.AddForce(0,0,force1);
            addPoints();
            // points=points+1;
            // mypoints.text="points:"+points;  
        }
        if(Input.GetKey("a"))
        {
            anim.Play("run");
            rb.AddForce(-force1,0,0);
            
        }
        if(Input.GetKey("d"))
        {
            anim.Play("run");
            rb.AddForce(force1,0,0);
        }
        if(Input.GetKey("s"))
        {
            anim.Play("backwards-run");
            rb.AddForce(0,0,-force1);
            subPoints();
            // points=points-1;
            // mypoints.text="points:"+points; 
        }
        if(Input.GetKey("h"))
        {
            anim.Play("wave");
        }
        
    }
    public void addPoints()
    {
        points=points+1;
        mypoints.text="points:"+points;
    }
    public void subPoints()
    {
        points=points-1;
        mypoints.text="points:"+points;
    }

    public void virusHitPoints()
    {
        points=points-5;
        mypoints.text="points:"+points;
    }
}
