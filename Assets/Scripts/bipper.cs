using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bipper : MonoBehaviour
{
    public GameObject other;
    private float distance;
    public AudioSource[] sounds;
    public AudioSource noise1;
    public AudioSource noise2;
    void Start(){
        distance = Vector2.Distance (this.transform.position, other.transform.position);
        sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
        noise2 = sounds[1];
    }

    void Update()
    {
        float newDistance = Vector2.Distance (this.transform.position, other.transform.position);
        if(newDistance<distance){
            Closer();
        }else if(newDistance>distance){
            Further();
        } 
        
        distance=newDistance;
    }

    void Closer(){
        Debug.Log("close"+distance);
        noise1.Play();
    }

    void Further(){
        Debug.Log("far"+distance);
        noise2.Play();
    }
}
