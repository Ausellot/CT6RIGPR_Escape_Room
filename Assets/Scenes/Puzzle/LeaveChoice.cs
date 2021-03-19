using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveChoice : MonoBehaviour
{
    public GameObject LeaveChoiceInstructions;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "LeaveChoice")
        {
            LeaveChoiceInstructions.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                if(Barrel.destroyEnding == true)
                {
                    SceneManager.LoadScene("DestroyFinalChoice");
                }
                else if (CameraShot.cameraEnding == true)
                {
                    SceneManager.LoadScene("EvidenceFinalChoice");
                }
                else if(Barrel.destroyEnding != true && CameraShot.cameraEnding != true)
                {
                    SceneManager.LoadScene("LeaveFinalChoice");
                }
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "LeaveChoice")
        {
            LeaveChoiceInstructions.SetActive(false);
        }
    }
}
