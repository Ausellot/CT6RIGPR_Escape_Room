using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMoveDebugLight : MonoBehaviour
{
    //this is the location the item will go to at the game start.
    public Vector3 GoToPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = GoToPosition;
    }
  
}
