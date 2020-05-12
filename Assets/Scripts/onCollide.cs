using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollide : MonoBehaviour
{
    public AudioSource[] sounds;
    public AudioSource noise1;
    private void Start() {
    
    sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log(this.name + " Trigger with name=" + other.name+" tag="+other.tag);
        noise1.Play();

    }
}
