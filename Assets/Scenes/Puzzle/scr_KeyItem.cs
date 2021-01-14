﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_KeyItem : MonoBehaviour
{
    
    public byte keyType;
    public GameObject Door1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);
        int i = 0;
       
        while (i < hitColliders.Length)
        {
            if (hitColliders[i].GetComponent<scr_LockedLocation>() != null)
            {
                Debug.Log("KeyContact");
                if (hitColliders[i].GetComponent<scr_LockedLocation>().lockType == keyType)
                {
                    Door1.GetComponent<scr_DoorManager>().KeyInput = true;
                    Destroy(gameObject);
                }
            }
            i++;
        }
    }
}
