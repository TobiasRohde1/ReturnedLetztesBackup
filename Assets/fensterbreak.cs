using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fensterbreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioClip shatter;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Find("scherben").GetComponent<Renderer>().enabled = true;
        GameObject.Find("scherben (1)").GetComponent<Renderer>().enabled = true;
        GetComponent<AudioSource>().PlayOneShot(shatter);
        Destroy(gameObject, 0.99f);
    }
}
