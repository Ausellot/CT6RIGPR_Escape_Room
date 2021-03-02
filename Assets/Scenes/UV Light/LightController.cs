using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LightController : MonoBehaviour
{

    public Light flashlight;
    public Material green,blue,red;
    public Material reveal;


    // Update is called once per frame
    void Update()
    {
        if (transform.parent.parent.gameObject.name == "Grab")
        {
            if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == false)
            {
                flashlight.enabled = true;
            }

            else if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == true)
            {
                if (reveal != null)
                {
                    reveal.SetFloat("_LightAngle", 0f);
                }
                flashlight.enabled = false;

            }

            if (flashlight.enabled == true)
            {

                if (Input.GetKeyDown("1"))
                {
                    if (reveal != null)
                    {
                        reveal.SetFloat("_LightAngle", 0f);
                    }

                    flashlight.color = Color.green;

                    reveal = green;
                }
                else if (Input.GetKeyDown("2"))
                {
                    if (reveal != null)
                    {
                        reveal.SetFloat("_LightAngle", 0f);
                    }

                    flashlight.color = Color.blue;
                    reveal = blue;
                }
                else if (Input.GetKeyDown("3"))
                {
                    if (reveal != null)
                    {
                        reveal.SetFloat("_LightAngle", 0f);
                    }

                    flashlight.color = Color.red;
                    reveal = red;
                }
                else if (Input.GetKeyDown("0"))
                {
                    if (reveal != null)
                    {
                        reveal.SetFloat("_LightAngle", 0f);
                    }
                    flashlight.color = Color.white;
                    reveal = null;
                }

                reveal.SetVector("_LightPosition", flashlight.transform.position);
                reveal.SetVector("_LightDirection", -flashlight.transform.forward);
                reveal.SetFloat("_LightAngle", flashlight.spotAngle);

            }
        }
    }
}
