using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    // Private Variables
    private float speed = 20.0f;
    private float direction = 40.0f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Take user input
        horizontalInput = Input.GetAxis("Horizontal"); 
        verticalInput = Input.GetAxis("Vertical");

        // Making the car move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Making the car rotate
        transform.Rotate(Vector3.up, Time.deltaTime * direction * horizontalInput);
    }
}
