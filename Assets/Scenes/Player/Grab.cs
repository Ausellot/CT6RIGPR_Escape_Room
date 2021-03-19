using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Grab : MonoBehaviour
{
    public Camera cam;
    public Transform slot;
    public PickableItem pickedItem;
    public GameObject camDevice;
    private bool camDestroyed;

    float rotSpeed = 200f;

    void Start()
    {
        camDestroyed = false;
    }

    void Update()
    {              
        //rotation, this is quiet simple but after trying out different ways of doing it this was best
        if (Input.GetKey(KeyCode.Q)) { transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.E)) { transform.Rotate(-Vector3.right * rotSpeed * Time.deltaTime); }

        //pick up item
        if (Input.GetMouseButtonDown(1))
        {
            if (pickedItem)
            {
                DropItem(pickedItem);
            }
            else
            {
                var ray = cam.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit, 4.5f))
                {
                    var pickable = hit.transform.GetComponent<PickableItem>();
                    
                    if (pickable)
                    {
                        if (pickable.CanBePickedUp)
                        {
                            PickItem(pickable);
                        }
                    }

                    if ((pickable.tag == camDevice.tag) && camDestroyed == false)
                    {
                        Destroy(camDevice);
                        camDestroyed = true;
                        pickedItem = null;
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

        //allows an object to always start forward, regardless of previous rotations
        transform.localRotation = Quaternion.Euler(90, 0, 0);

        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;


    }

    void DropItem(PickableItem item)
    {
        if (CanSeeHeldItem())
        {
            pickedItem = null;

            item.transform.SetParent(null);

            item.Rb.isKinematic = false;

            item.Rb.AddForce(item.transform.parent.forward * 2, ForceMode.VelocityChange);

            
        }
    }

    bool CanSeeHeldItem()
    {
        var ray = cam.ViewportPointToRay(Vector3.one * 0.5f);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1.25f))
        {
            //returns if it hit something
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == transform.GetChild(0).gameObject.name)
            {
                return true;
            }

        }
        else
        {
            //it must have not hit anything
            return true;
        }



        return false;
    }
}

