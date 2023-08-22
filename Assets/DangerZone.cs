using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLight;
    float duration=5.0f;
    Color color0=Color.red;
    Color color1=Color.white;
    //sound 
    public AudioSource bgMusic;
    public AudioSource safeMusic;
    public AudioSource dangerMusic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        bgMusic.Stop();
        dangerMusic.Play();
        Debug.Log("danger zone");
        // myLight.intensity=2.0f;
        myLight.intensity=Mathf.PingPong(Time.time,0.6f);
        float t=Mathf.PingPong(Time.time,duration)/duration;
        myLight.color=Color.Lerp(color0,color1,t);
    }

    void OnTriggerExit(Collider other)
    {
        dangerMusic.Stop();
        safeMusic.Play();
        bgMusic.PlayDelayed(5.0f);
        myLight.intensity=1.0f;
        myLight.color=color1;
        Debug.Log("safe zone");

    }
}
