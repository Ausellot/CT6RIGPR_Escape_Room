using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomVariables : MonoBehaviour
{
    public bool RoomsPowered = false;
    bool metaUpdated = false;

    // Update is called once per frame
    void Update()
    {
        if (RoomsPowered && (!metaUpdated))
        {
            
            GameObject.Find("Celling_Fan").GetComponent<Light>().range = 30;
            GameObject.Find("Celling_Fan (1)").GetComponent<Light>().range = 30;

            //placeholder:
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().UseSoundList[0] = false;
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().UseSoundList[1] = true;
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().EarlyCut();

            Debug.Log("Power is on!");
            metaUpdated = true;
        }
    }
}
