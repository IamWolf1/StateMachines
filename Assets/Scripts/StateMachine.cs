using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }

    public State CurrentState = State.idle;

    void Start()
    {
        
    }

    
    void Update()
    {
        switch (CurrentState)
        {
            case State.idle: Idle(); break;
            case State.walking: Walking(); break;
            case State.swimming: Swimming(); break;
            case State.climbing: Climbimg(); break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "WaterTrigger")
        {
            Swimming();
        }
    }
    void OnTriggerExit(Collider other)
    {
        
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

    void Walking () 
    {
        Debug.Log("I am Walking");
    }

}
