using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform mouseTestObject = null;
    Transform model;

    public Camera characterCamera;
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float maxJumps = 4;

    private Vector3 moveDirection = Vector3.zero;
    private float currentSpeed = 0.0F;
    private int currentJumps = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        model = transform.Find("Model");
    }

    void Update()
    {
        //Use this code to rotate towards the mouse.
        //Vector3 mousePosition2D = new Vector3();
        //mousePosition2D.x = Input.mousePosition.x;
        //mousePosition2D.y = Input.mousePosition.y;
        //mousePosition2D.z = characterCamera.transform.position.y - transform.position.y;

        //Vector3 mousePosition3D = characterCamera.ScreenToWorldPoint(mousePosition2D);
        //transform.rotation = Quaternion.LookRotation(mousePosition3D - transform.position);
        //mouseTestObject.position = mousePosition3D;

        moveDirection.x = Input.GetAxis("Horizontal") * speed;


        if (Input.GetAxis ("Horizontal") < 0)

        {
            Vector3 velocity = Vector3.zero;

            Vector3 desiredAngles = new Vector3(model.localEulerAngles.x, 90, model.localEulerAngles.z);
            model.localEulerAngles = (Vector3.SmoothDamp(model.localEulerAngles, desiredAngles, ref velocity, 1 * Time.deltaTime));

        }

        else if (Input.GetAxis("Horizontal") > 0)

        {
            Vector3 velocity = Vector3.zero;


            Vector3 desiredAngles = new Vector3(model.localEulerAngles.x, 270, model.localEulerAngles.z);
            model.localEulerAngles = (Vector3.SmoothDamp(model.localEulerAngles, desiredAngles, ref velocity, 1 * Time.deltaTime));

        }

        //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        //moveDirection *= speed;

        //This controls the direction the player is facing - left or right, dependant on the direction they're going

        if (characterController.isGrounded)
        {
            currentJumps = 0;
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump") && currentJumps < maxJumps)
//        if (Input.GetButton("Jump") && currentJumps < maxJumps)
        {
            moveDirection.y = jumpSpeed;
            currentJumps++;
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)

        if (characterController.isGrounded == false)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
