﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoAlbum : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject album;
    private bool isShown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShown = !isShown;
            album.SetActive(isShown);
        }
    }
}
