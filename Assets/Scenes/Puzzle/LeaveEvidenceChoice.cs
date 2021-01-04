using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveEvidenceChoice : MonoBehaviour
{
    public GameObject LeaveEvChoiceInstructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "LeaveEvChoice")
        {
            LeaveEvChoiceInstructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("EvidenceFinalChoice");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "LeaveEvChoice")
        {
            LeaveEvChoiceInstructions.SetActive(false);
        }
    }
}
