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
            
            GameObject.Find("FanLight1").GetComponent<Light>().range = 30;
            GameObject.Find("FanLight2").GetComponent<Light>().range = 30;
            //FanLight1 CellingFanRotater
            //FanLight2 CellingFanRotater2

            //placeholder:
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().UseSoundList[0] = false;
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().UseSoundList[1] = true;
            GameObject.Find("RadioSound").GetComponent<Scr_WorldSound>().EarlyCut();

            Debug.Log("Power is on!");
            metaUpdated = true;
        }

        if (RoomsPowered)
        {
            GameObject.Find("CellingFanRotater").transform.Rotate(new Vector3(0f,0f,Time.deltaTime * 15f));
            GameObject.Find("CellingFanRotater2").transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 15f));
        }
    }
}
