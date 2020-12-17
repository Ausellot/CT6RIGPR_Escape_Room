using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    public GameObject Enable;
    private bool PasswordScreen;
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

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selction = hit.transform;

                if (selction.CompareTag("Password"))
                {
                    PasswordScreen = true;

                    var selectionRender = selction.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        PasswordScreen = true;
                    }
                }
            }
        }

        if (PasswordScreen)
        {
            Enable.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Enable.SetActive(false);
            PasswordScreen = false;
            Time.timeScale = 1.0f;
        }
    }
}
