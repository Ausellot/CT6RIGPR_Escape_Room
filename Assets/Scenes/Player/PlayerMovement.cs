using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private bool crouch = false;
    public KeyCode crouchKey = KeyCode.C;

    private float originalHeight;
    private float crouchHeight;

    public float speed = 2f;
    public float grav = -20f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        originalHeight = controller.height;
        crouchHeight = originalHeight / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(crouchKey))
        {
            crouch = !crouch;

            CheckCrouch();
        }

        // take x and z
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // movement
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        // gravity
        velocity.y += grav * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    void CheckCrouch()
    {
        if(crouch == true)
        {
            controller.height = crouchHeight;
        }
        else
        {
            controller.height = originalHeight;
        }
    }
}
