using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);
    void Start()
    {
        
    }

    // Update is called once per frame

    // used LateUpdate instead of Update, because of the jittering issues. 
    // to have the camera follow the car smoothly, the follow method needs update after
    // the car moves. using the Update method can somtimmes triggers the follow before the car moves
    // which causes the jittering.
    void LateUpdate()
    {
        // adding to the player position a new vector to offest the position of the 0,0,0 camera position
        transform.position = player.transform.position + offset;
        
    }
}
