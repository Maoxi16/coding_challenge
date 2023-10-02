using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les_move : MonoBehaviour
{
   /* 4.Create four variables in the Leslie game object where:
        a.Variable 1 = I
        b  Variable 2 = want
        c.Variable 3 = 100
        d.Variable 4 = pancakes.*/
    string a = " I ";
    string b = " want ";
    int c = 100;
    string d = " pancakes.";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a+b+c+d); //e Print the sentence" I want 100 pancakes." in a complete sentence to the Unity console once.
    }

    // Update is called once per frame
    void Update()
    {
        //3.Make the Leslie game object move up three units on the push of the E button on the keyboard.
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Translate(0,3,0);
        }
    }
}
