using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f; // customized the speed of the plane
    private float rotationSpeed = 75.0f; // customized the rotation speed of the plane
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate (Challenge#1 and #2: changed backward to forward and added Time.deltaTime)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys (Challenge#3: added verticalInput)
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed  * verticalInput);
    }
}
