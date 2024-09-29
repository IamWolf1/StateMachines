using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Idle();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "WaterTrigger")
        {
            Swimming();
        }
    }
    void Swimming()
    {
        Debug.Log("I am Swimming");
    }
    void Climbimg()
    {
        Debug.Log("I am Climbing");
    }

    void Idle()
    {
        Debug.Log("I am idle");
    }

}
