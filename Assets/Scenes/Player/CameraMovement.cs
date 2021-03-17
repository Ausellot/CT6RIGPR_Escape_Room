using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float rotX;
    public float mouseSen = 400f;
    public Camera cam;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if(mouseSen == 0)
        {
            mouseSen = Settings.camSen;
        }
        if(cam.fieldOfView == 0)
        {
            cam.fieldOfView = Settings.fov;
        }
        

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse input
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSen;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSen;
  
        // rotate cam up and down
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotX, 0f, 0f);

        Debug.Log(mouseSen);
        Debug.Log(cam.fieldOfView);

        // rotate left and right
        player.Rotate(Vector3.up * mouseX);
    }
}
