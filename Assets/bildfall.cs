using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bildfall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioClip thump;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Find("Decoration_46 (1)").GetComponent<Renderer>().enabled = true;
        GameObject.Find("Decoration_46").GetComponent<Renderer>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(thump);
        Destroy(gameObject, 0.99f);
    }
}
