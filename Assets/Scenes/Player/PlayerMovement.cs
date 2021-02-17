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

        //updated movement calculator (Fixing diagonal Bug)
        Vector3 MovementAngle = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        //Debug.Log(MovementAngle.ToString());
        if (MovementAngle.magnitude > 1.0)
        {
            MovementAngle.Normalize();
        }
       
        // movement
        Vector3 move = transform.right * MovementAngle.x + transform.forward * MovementAngle.z;

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
