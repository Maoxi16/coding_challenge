using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Franc_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //5.Make the Francis game object spin once per frame on its Y axis.
        transform.Rotate(0,360*Time.deltaTime,0);
    }
}
