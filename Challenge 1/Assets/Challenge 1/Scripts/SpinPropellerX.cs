using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 500.0f; // speed of the spin

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bonus Challenge: make the plane's propeller spin
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
