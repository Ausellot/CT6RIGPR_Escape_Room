using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableItem : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var ray = cam.ViewportPointToRay(Vector3.one * 0.5f);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 0.5f))
            {
                bool Item = hit.transform.name == "Waredrobe";

                if (Item)
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = false;
                    hit.transform.GetComponent<Rigidbody>().AddForce(transform.forward + (Vector3.up * 0.2f), ForceMode.Impulse);
                }



            }

        }
    }
}
