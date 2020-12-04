using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Grab : MonoBehaviour
{
    public Camera cam;

    public Transform slot;

    public PickableItem pickedItem;

    float rotSpeed = 200f;

    void Update()
    {              
        //rotation, this is quiet simple but after trying out different ways of doing it this was best
        if (Input.GetKey(KeyCode.Q)) { transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.E)) { transform.Rotate(-Vector3.right * rotSpeed * Time.deltaTime); }

        //pick up item
        if (Input.GetMouseButtonDown(0))
        {

            if (pickedItem)
            {
                DropItem(pickedItem);
            }

            else
            {
                var ray = cam.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    var pickable = hit.transform.GetComponent<PickableItem>();



                    if (pickable)
                  {
                    PickItem(pickable);
                  }
                }

            }
        }
        
    }

    void PickItem(PickableItem item)
    {
        pickedItem = item;

        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        item.transform.SetParent(slot);

        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;


    }

    void DropItem(PickableItem item)
    {
        pickedItem = null;

        item.transform.SetParent(null);

        item.Rb.isKinematic = false;

        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }
}

