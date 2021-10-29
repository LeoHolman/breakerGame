using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float movespeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        if (rigidBody == null)
        {
            rigidBody = gameObject.GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
       if( Keyboard.current.wKey.wasPressedThisFrame)
        {
            rigidBody.AddForce(transform.forward * movespeed, ForceMode.Force);
            Debug.Log("Called input pressed this frame!");

        }
    }

    public void MoveForward(InputAction.CallbackContext context)
    {
       // context.control
        Debug.Log("Called input!");
        rigidBody.AddForce(transform.forward * movespeed, ForceMode.Force);

    }
}
