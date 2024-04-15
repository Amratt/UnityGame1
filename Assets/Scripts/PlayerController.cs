using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10.0f;
    public float direction = 5.0f;
    public float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Making the car move forward
        horizontalInput = Input.GetAxis("Horizontal"); // This is the player input to move horizontally

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * direction * horizontalInput);
    }
}
