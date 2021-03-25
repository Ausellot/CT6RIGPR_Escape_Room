using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoAlbum : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject album;
    private bool isShown;
    public static bool isActive;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isActive = false;
            isShown = !isShown;
            album.SetActive(isShown);
        }
    }
}
