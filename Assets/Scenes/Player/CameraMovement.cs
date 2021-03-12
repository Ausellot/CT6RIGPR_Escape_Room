using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float rotX;
    public float mouseSen = 400f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        mouseSen = Settings.camSen;
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

        // rotate left and right
        player.Rotate(Vector3.up * mouseX);

    }
}
