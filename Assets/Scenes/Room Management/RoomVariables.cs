using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomVariables : MonoBehaviour
{
    public bool RoomsPowered = false;

    // Update is called once per frame
    void Update()
    {
        if (RoomsPowered)
        {
            GameObject.Find("Celling_Fan").GetComponent<Light>().range = 30;
            GameObject.Find("Celling_Fan(1)").GetComponent<Light>().range = 30;
        }
    }
}
