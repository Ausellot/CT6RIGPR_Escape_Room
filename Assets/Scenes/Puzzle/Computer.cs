using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour
{
    public GameObject Enable;
    public GameObject Enable2;

    public GameObject Recycle;
    public GameObject Email;

    public GameObject Doc1;
    public GameObject Doc2;
    public GameObject Doc3;
    public GameObject Doc4;
    public GameObject Doc5;
    public GameObject Doc6;

    public GameObject Email1;
    public GameObject Email2;
    public GameObject Email3;
    public GameObject Email4;
    public GameObject Email5;
    public GameObject Email6;

    public InputField PasswordField;

    private bool ComputerScreen;
    private bool Homescreen;

    public string Password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (PasswordField.text.ToString() == Password)
            {
                Debug.Log("correct");
                Enable.SetActive(false);
                Enable2.SetActive(true);
                Homescreen = true;
            }
        }
    }

    void OnGUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1.0f))
            {
                var selction = hit.transform;

                if (selction.CompareTag("Computer"))
                {
                    ComputerScreen = true;

                    var selectionRender = selction.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        ComputerScreen = true;
                    }
                }
            }
        }

        if (ComputerScreen && PasswordField.text.ToString() != Password)
        {
            Enable.SetActive(true);
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (ComputerScreen && Homescreen)
        {
            Enable2.SetActive(true);
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

    public void CloseComputer()
    {
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Enable.SetActive(false);
        Enable2.SetActive(false);
        ComputerScreen = false;
        CloseEmails();
        CloseRecycling();
    }

    #region Emails
    public void OpenEmails()
    {
        Email.SetActive(true);
    }
    public void CloseEmails()
    {
        Email.SetActive(false);
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail1()
    {
        Email1.SetActive(true);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail2()
    {
        Email2.SetActive(true);
        Email1.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail3()
    {
        Email3.SetActive(true);
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail4()
    {
        Email4.SetActive(true);
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail5()
    {
        Email5.SetActive(true);
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email6.SetActive(false);
    }

    public void OpenEmail6()
    {
        Email6.SetActive(true);
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
    }
    #endregion

    #region Recycling Bin
    public void OpenRecycling() 
    {
        Recycle.SetActive(true);
    }
    public void CloseRecycling()
    {
        Recycle.SetActive(false);
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
    }

    public void OpenDoc1()
    {
        Doc1.SetActive(true);
    }
    public void CloseDoc1()
    {
        Doc1.SetActive(false);
    }

    public void OpenDoc2()
    {
        Doc2.SetActive(true);
    }
    public void CloseDoc2()
    {
        Doc2.SetActive(false);
    }

    public void OpenDoc3()
    {
        Doc3.SetActive(true);
    }
    public void CloseDoc3()
    {
        Doc3.SetActive(false);
    }

    public void OpenDoc4()
    {
        Doc4.SetActive(true);
    }
    public void CloseDoc4()
    {
        Doc4.SetActive(false);
    }

    public void OpenDoc5()
    {
        Doc5.SetActive(true);
    }
    public void CloseDoc5()
    {
        Doc5.SetActive(false);
    }

    public void OpenDoc6()
    {
        Doc6.SetActive(true);
    }
    public void CloseDoc6()
    {
        Doc6.SetActive(false);
    }
    #endregion
}
