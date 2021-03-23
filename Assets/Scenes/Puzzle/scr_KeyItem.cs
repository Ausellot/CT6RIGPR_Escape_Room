using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_KeyItem : MonoBehaviour
{
    
    public byte keyType;
    public GameObject Door1;
    public GameObject RoomManager;

   

    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);
        int i = 0;

        while (i < hitColliders.Length && transform.parent.name == "Grab")
        {
            //Debug.Log(hitColliders[i].name + " at the " + i.ToString() + "th place. User at " + gameObject.transform.position.ToString() + " Distance = " + (Vector3.Distance(gameObject.transform.position, hitColliders[i].gameObject.transform.position).ToString()));
            if (hitColliders[i].GetComponent<scr_LockedLocation>() != null)
            {
                //Debug.Log("KeyContact with " + hitColliders[i].name + " at the " + i.ToString() + "th place");
                if (hitColliders[i].GetComponent<scr_LockedLocation>().lockType == keyType && Vector3.Distance(gameObject.transform.position, hitColliders[i].transform.position) < 0.5f)
                {
                    if (Door1 != null)
                    {
                        Door1.GetComponent<scr_DoorManager>().KeyInput = true;
                        Destroy(gameObject);
                    }                    
                    if (RoomManager != null)
                    {
                        RoomManager.GetComponent<RoomVariables>().RoomsPowered = true;
                        Destroy(gameObject);
                    }

                }
            }
            i++;
        }
    }
}
