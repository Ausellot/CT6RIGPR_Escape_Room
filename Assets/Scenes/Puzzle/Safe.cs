using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Safe : MonoBehaviour
{
    public GameObject Enable;
    public GameObject SafeDoor1;
    

    public string CorrectPassword1 = "12";
    public string CorrectPassword2 = "34";
    public string CorrectPassword3 = "56";

    public int Number1;
    public int Number2;
    public int Number3;
    

    public string input1;
    public string input2;
    public string input3;

    public Text DisplayText1;
    public Text DisplayText2;
    public Text DisplayText3;

    public AudioClip CorrectSound;
    public AudioClip WrongSound;    

    private bool KeypadScreen;
    private float btnClicked = 0;
    private float NumOfGuesses;

    void Start()
    {
        
        btnClicked = 0;
        //NumOfGuesses = CorrectPassword.Length;
    }

    void Update()
    {
        input1 = Number1.ToString();
        input2 = Number2.ToString();
        input3 = Number3.ToString();

        

        if (btnClicked == NumOfGuesses)
        {
            if (input1 == CorrectPassword1 && input2 == CorrectPassword2 && input3 == CorrectPassword3)
            {
                SafeDoor1.GetComponent<Animator>().Play("SafeOpen");
                //CorrectSound.Play();
                gameObject.GetComponent<AudioSource>().clip = CorrectSound;
                gameObject.GetComponent<AudioSource>().Play();
                GameObject.Find("Thief Tools").GetComponent<PickableItem>().CanBePickedUp = true;
                GameObject.Find("Thief Tools").GetComponent<BoxCollider>().enabled = true;
                GameObject.Find("Thief Tools").GetComponent<Rigidbody>().useGravity = true;
                Debug.Log("Safe Opening");
                
                input1 = Number1.ToString();
                input2 = Number2.ToString();
                input3 = Number3.ToString();
                btnClicked = 0;
                
            }
            else
            {
                
                //input1 = "00";
                //input2 = "00";
                //input3 = "00";
                DisplayText1.text = input1.ToString();
                DisplayText2.text = input2.ToString();
                DisplayText3.text = input3.ToString();
                btnClicked = 0;
            }
        }
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

                if (selction.CompareTag("Safe"))
                {
                    KeypadScreen = true;

                    var selectionRender = selction.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        KeypadScreen = true;
                    }
                }
            }
        }

        if (KeypadScreen)
        {
            Enable.SetActive(true);
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    #region Up/Down
    public void Up1()
    {
        Number1++;
        if (Number1 == 100)
        {
            Number1 = 0;
        }
        input1 += Number1.ToString();
        DisplayText1.text = Number1.ToString();
    }
    public void Up2()
    {
        Number2++;
        if (Number2 == 100)
        {
            Number2 = 0;
        }
        input2 += Number2.ToString();
        DisplayText2.text = Number2.ToString();
    }
    public void Up3()
    {
        Number3++;
        if (Number3 == 100)
        {
            Number3 = 0;
        }
        input3 += Number3.ToString();
        DisplayText3.text = Number3.ToString();

    }
    public void Down1()
    {
        Number1--;
        if (Number1 == -1)
        {
            Number1 = 99;
        }
        input1 += Number1.ToString();
        DisplayText1.text = Number1.ToString();
    }
    public void Down2()
    {
        Number2--;
        if (Number2 == -1)
        {
            Number2 = 99;
        }
        input2 += Number2.ToString();
        DisplayText2.text = Number2.ToString();
    }
    public void Down3()
    {
        Number3--;
        if (Number3 == -1)
        {
            Number3 = 99;
        }
        input3 += Number3.ToString();
        DisplayText3.text = Number3.ToString();
    }
    #endregion
    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q":
                Enable.SetActive(false);
                btnClicked = 0;
                input1 = "00";
                input2 = "00";
                input3 = "00";
                KeypadScreen = false;
                DisplayText1.text = input1.ToString();
                DisplayText2.text = input2.ToString();
                DisplayText3.text = input3.ToString();
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;

            default:
                //btnClicked++;
                input1 += Number1.ToString();
                input1 += Number2.ToString();
                input1 += Number3.ToString();
                DisplayText1.text = Number1.ToString();
                DisplayText2.text = Number2.ToString();
                DisplayText3.text = Number3.ToString();
                break;
        }
    }
}


