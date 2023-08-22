using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam1;
    public Camera cam2;
    void Start()
    {
        cam1.enabled=true;
        cam2.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("c"))
        {
            cam1.enabled=!cam1.enabled;
            cam2.enabled=!cam2.enabled;
        }
        
    }
}
