using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//the audio source is the sound they make when colliding with something.
[RequireComponent(typeof(AudioSource))]
public class PickableItem : MonoBehaviour
{

    private Rigidbody rb;
    public Rigidbody Rb => rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        float CollisionForce = collision.relativeVelocity.magnitude;
        Debug.Log("Collision at " + CollisionForce);
        if (collision.relativeVelocity.magnitude > 0.1)
        {
            GetComponent<AudioSource>().volume = CollisionForce / 8;
            GetComponent<AudioSource>().
           GetComponent<AudioSource>().Play();
        }
    }
}