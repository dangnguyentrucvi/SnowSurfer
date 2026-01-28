using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    RigidBody2D myRigidBody2D;
    [SerializeField] float torqueAmount = 1f;

    
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        myRigidBody2D = GetComponent<RigidBody2D>();
    }
    
    void Update()
    {
        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        myRigidBody2D.AddTorque(torqueAmount);
        
        if(moveVector.x < 0)
        {
            myRigidbody2D.AddTorque(torqueAmount);
        }
        
        else if(moveVector.x > 0)
        {
            myRigidbody2D.AddTorque(torqueAmount*-1);
        }
    }
}