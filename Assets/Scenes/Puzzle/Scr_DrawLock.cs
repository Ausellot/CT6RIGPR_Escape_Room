using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_DrawLock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enable;
    public GameObject DrawersToOpen;
    bool Opening;

    public AudioSource NormalClick;
    public AudioSource CorrectClick;

    public string CorrectPassword1 = "18";
   
    public string CorrectPassword3 = "70";

    public int Number1;
   
    public int Number3;


    public string input1;
    
    public string input3;

    public Text DisplayText1;
    
    public Text DisplayText3;

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
        
        input3 = Number3.ToString();
        if (Opening)
        {
            if (transform.parent.position.x > -0.80f)
            {
                transform.parent.position -= new Vector3(Time.deltaTime,0f,0f);
            } else
            {
                Opening = false;
            }

        }



        if (btnClicked == NumOfGuesses)
        {
            if (input1 == CorrectPassword1 && input3 == CorrectPassword3)
            {
                
                //CorrectSound.Play();
                //gameObject.GetComponent<AudioSource>().clip = CorrectSound;
                //gameObject.GetComponent<AudioSource>().Play();               
                //Debug.Log("Drawers Opening");
                Opening = true;
                input1 = Number1.ToString();               
                input3 = Number3.ToString();
                DisplayText1.text = Number1.ToString();
                DisplayText3.text = Number3.ToString();
                btnClicked = 0;

            }
            else
            {

                //input1 = "00";
                //input2 = "00";
                //input3 = "00";
                DisplayText1.text = input1.ToString();
                
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

            if (Physics.Raycast(ray, out hit, 1.0f))
            {
                var selction = hit.transform;

                if (selction.CompareTag("DrawersLock"))
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
        if (Number1.ToString() == CorrectPassword1)
        {
            CorrectClick.Play();
        }
        else
        {
            if (Number1 == 100)
            {
                Number1 = 0;
            }
            NormalClick.Play();
        }
        input1 += Number1.ToString();
        DisplayText1.text = Number1.ToString();
    }
   
    public void Up3()
    {
        Number3++;
        if (Number3.ToString() == CorrectPassword3)
        {
            CorrectClick.Play();
        }
        else
        {
            if (Number3 == 100)
            {
                Number3 = 0;
            }
            NormalClick.Play();
        }
        input3 += Number3.ToString();
        DisplayText3.text = Number3.ToString();

    }
    public void Down1()
    {
        Number1--;
        if (Number1.ToString() == CorrectPassword1)
        {
            CorrectClick.Play();
        }
        else
        {
            if (Number1 == -1)
            {
                Number1 = 99;
            }
            NormalClick.Play();
        }
        input1 += Number1.ToString();
        DisplayText1.text = Number1.ToString();
    }

    public void Down3()
    {
        Number3--;
        if (Number3.ToString() == CorrectPassword3)
        {
            CorrectClick.Play();
        }
        else
        {
            if (Number3 == -1)
            {
                Number3 = 99;
            }
            NormalClick.Play();
        }
        input3 += Number3.ToString();
        DisplayText3.text = Number3.ToString();
        Debug.Log("Down, now " + Number3.ToString());
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
                
                input3 = "00";
                KeypadScreen = false;
                DisplayText1.text = input1.ToString();
                
                DisplayText3.text = input3.ToString();
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;

            default:
                //btnClicked++;
                input1 += Number1.ToString();
             
                input3 += Number3.ToString();
                DisplayText1.text = Number1.ToString();
                
                DisplayText3.text = Number3.ToString();
                break;
        }
    }
}
