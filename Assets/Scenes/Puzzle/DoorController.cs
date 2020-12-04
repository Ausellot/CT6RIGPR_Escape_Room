using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            Animator Anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E)) 
            { 
                Anim.SetTrigger("OpenClose");
            }
        }
    }
}
