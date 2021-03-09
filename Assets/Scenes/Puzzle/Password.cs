using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    public GameObject Computer;
    public GameObject Homescreen;
    public GameObject Enable;
    public GameObject Enable2;
    public GameObject Enable3;
    public GameObject Enable4;
    public GameObject Enable5;
    public GameObject Enable6;
    public GameObject Enable7;
    public GameObject Enable8;
    public GameObject Enable9;
    public GameObject Enable10;
    public GameObject Enable11;
    public GameObject Enable12;
    public GameObject Enable13;
    public GameObject Enable14;
    public GameObject Enable15;
    public GameObject Enable16;


    private bool PasswordScreen;
    private bool Note1Screen;
    private bool Note2Screen;
    private bool Note3Screen;
    private bool Note4Screen;
    private bool Note5Screen;
    private bool Note6Screen;
    private bool Note7Screen;
    private bool Note8Screen;
    private bool Note9Screen;
    private bool Note10Screen;
    private bool Note11Screen;
    private bool Note12Screen;
    private bool Note13Screen;
    private bool Note14Screen;
    private bool Note15Screen; 
    private bool Note16Screen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Enable.SetActive(false);
            PasswordScreen = false;
            Time.timeScale = 1.0f;

            Enable2.SetActive(false);
            Note1Screen = false;
            Time.timeScale = 1.0f;

            Enable3.SetActive(false);
            Note2Screen = false;
            Time.timeScale = 1.0f;

            Enable4.SetActive(false);
            Note3Screen = false;
            Time.timeScale = 1.0f;


            Enable5.SetActive(false);
            Note4Screen = false;
            Time.timeScale = 1.0f;

            Enable6.SetActive(false);
            Note5Screen = false;
            Time.timeScale = 1.0f;

            Enable7.SetActive(false);
            Note6Screen = false;
            Time.timeScale = 1.0f;

            Enable8.SetActive(false);
            Note7Screen = false;
            Time.timeScale = 1.0f;

            Enable9.SetActive(false);
            Note8Screen = false;
            Time.timeScale = 1.0f;

            Enable10.SetActive(false);
            Note9Screen = false;
            Time.timeScale = 1.0f;

            Enable11.SetActive(false);
            Note10Screen = false;
            Time.timeScale = 1.0f;

            Enable12.SetActive(false);
            Note11Screen = false;
            Time.timeScale = 1.0f;

            Enable13.SetActive(false);
            Note12Screen = false;
            Time.timeScale = 1.0f;

            Enable14.SetActive(false);
            Note13Screen = false;
            Time.timeScale = 1.0f;

            Enable15.SetActive(false);
            Note14Screen = false;
            Time.timeScale = 1.0f;

            Enable16.SetActive(false);
            Note15Screen = false;
            Note16Screen = false;
            Time.timeScale = 1.0f;
        }
    }
    void OnGUI()
    {
        if (!Computer.activeInHierarchy && !Homescreen.activeInHierarchy) 
        {


            if (Input.GetMouseButtonDown(0))

            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 2.25f))
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
                    if (selction.CompareTag("Note1"))
                    {
                        Note1Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note1Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note2"))
                    {
                        Note2Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note2Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note3"))
                    {
                        Note3Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note3Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note4"))
                    {
                        Note4Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note4Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note5"))
                    {
                        Note5Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note5Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note6"))
                    {
                        Note6Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note6Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note7"))
                    {
                        Note7Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note7Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note8"))
                    {
                        Note8Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note8Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note9"))
                    {
                        Note9Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note9Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note10"))
                    {
                        Note10Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note10Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note11"))
                    {
                        Note11Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note11Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note12"))
                    {
                        Note12Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note12Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note13"))
                    {
                        Note13Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note13Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note14"))
                    {
                        Note14Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note14Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note15"))
                    {
                        Note15Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note15Screen = true;
                        }
                    }
                    if (selction.CompareTag("Note16"))
                    {
                        Note16Screen = true;

                        var selectionRender = selction.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            Note16Screen = true;
                        }
                    }
                }
            }
        }
        if (PasswordScreen)
        {
            Enable.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note1Screen)
        {
            Enable2.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note2Screen)
        {
            Enable3.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note3Screen)
        {
            Enable4.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note4Screen)
        {
            Enable5.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note5Screen)
        {
            Enable6.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note6Screen)
        {
            Enable7.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note7Screen)
        {
            Enable8.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note8Screen)
        {
            Enable9.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note9Screen)
        {
            Enable10.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note10Screen)
        {
            Enable11.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note11Screen)
        {
            Enable12.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (Note12Screen)
        {
            Enable.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note13Screen)
        {
            Enable13.SetActive(true);
            Time.timeScale = 0.0f;
        }
         if (Note14Screen)
        {
            Enable14.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (Note15Screen)
        {
            Enable15.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (Note16Screen)
        {
            Enable16.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
