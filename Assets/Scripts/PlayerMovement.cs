using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float movespeed = 312.5f;

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
       //if( Keyboard.current.wKey.wasPressedThisFrame)
        //{
            //rigidBody.AddForce(transform.forward * movespeed, ForceMode.Force);
            //Debug.Log("Called input pressed this frame!");

        //}
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       // context.control
        Debug.Log("Called input!");
        rigidBody.AddForce(transform.forward * movespeed, ForceMode.Force);
        var value = context.ReadValueAsButton();
        Debug.Log(value);

    }
}
