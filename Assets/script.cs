using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioClip DemonSound;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        GetComponent<AudioSource>().PlayOneShot(DemonSound);
        Destroy(gameObject, 0.99f);
      
    }
}
