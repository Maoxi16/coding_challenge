using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand_movement : MonoBehaviour
{
    float horizontalmovement;
    float verticalmovement;
    float speed = 5.0f; //7.Add a speed variable of 5 units to the movement of Sandy.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 6.Make the Sandy move on the X axis using the A and D keys, and move on the Z axis using the W and S keys.
        //8.Have the game object, Sandy's, movement synced with all computers using Time.deltaTime.
        horizontalmovement = Input.GetAxis("Horizontal");
        transform.Translate(horizontalmovement * speed * Time.deltaTime, 0, 0);
        
        verticalmovement = Input.GetAxis("Vertical");
        transform.Translate(0,0,verticalmovement*speed*Time.deltaTime);
    }
}
