using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseSink : MonoBehaviour
{
    public GameObject Sink;

    public bool SinkTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 3.0f))
            {
                var selction = hit.transform;

                if (selction.CompareTag("Sink"))
                {
                    SinkTrue = true;

                    var selectionRender = selction.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        SinkTrue = true;
                    }
                }
            }
        }
        if (SinkTrue)
        {
            Sink.GetComponent<Animator>().Play("SinkAnimation");
        }
    }
}
