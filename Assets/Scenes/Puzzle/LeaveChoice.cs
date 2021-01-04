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
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("LeaveFinalChoice");
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
