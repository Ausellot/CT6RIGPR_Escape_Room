using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LightController : MonoBehaviour
{
    public Light flashlight;
    public Material reveal;
    

    // Start is called before the first frame update
    void Start()
    {
        flashlight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       reveal.SetVector("_LightPosition", flashlight.transform.position);
        reveal.SetVector("_LightDirection", -flashlight.transform.forward);
        reveal.SetFloat("_LightAngle", flashlight.spotAngle); 

        if(Input.GetKeyDown(KeyCode.F) && flashlight.enabled == false)
        {
            flashlight.enabled = true;
            
        


        } else if(Input.GetKeyDown(KeyCode.F) && flashlight.enabled == true)
        {
            flashlight.enabled = false;
        }
    }
}
