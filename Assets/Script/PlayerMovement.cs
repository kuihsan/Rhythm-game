using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;
    public float movementSpeed = 5; // Default movement speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the object
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * movementSpeed);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }
}