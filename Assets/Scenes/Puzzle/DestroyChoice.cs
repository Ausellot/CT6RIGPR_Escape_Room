using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyChoice : MonoBehaviour
{
    public GameObject DesChoiceInstructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "DesChoice")
        {
            DesChoiceInstructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("DestroyFinalChoice");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "DesChoice")
        {
            DesChoiceInstructions.SetActive(false);
        }
    }
}
