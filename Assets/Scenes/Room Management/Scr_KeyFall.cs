using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_KeyFall : MonoBehaviour
{

    public GameObject KeyToDrop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (KeyToDrop != null) {
            //Debug.Log(transform.rotation.eulerAngles.y);
        if (transform.rotation.eulerAngles.y >= 110)
        {           
            KeyToDrop.GetComponent<BoxCollider>().enabled = true;
            KeyToDrop.GetComponent<Rigidbody>().useGravity = true;
        }
      }
    }
}
