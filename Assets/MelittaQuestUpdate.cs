using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelittaQuestUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public AudioClip demonsound;
    public void OnTriggerEnter2D(Collider2D collider)
    {

        Destroy(GameObject.Find("Aufgabe2"));
        Destroy(GameObject.Find("doorblock"));
        GetComponent<AudioSource>().PlayOneShot(demonsound);

    }
}
