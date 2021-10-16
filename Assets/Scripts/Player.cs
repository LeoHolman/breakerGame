using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rig;
    public float jumpForce;

    public int score;

    private bool isGrounded;

    public UI ui;

    public UnityEvent sampleEvent;

    // Update is called once per frame
    void Update()
    {
        // get horizontal and vertical inputs
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        // set velocity based on inputs
        rig.velocity = new Vector3(x, rig.velocity.y, z);

        // create copy of velocity to check for differences
        // normalize y
        Vector3 vel = rig.velocity;
        vel.y = 0;

        // rotate player to face the direction they are moving in
        if(vel.x != 0 || vel.z != 0)
        {
            transform.forward = vel;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Only allow jumping when grounded
            isGrounded = false;
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if(transform.position.y < -10)
        {
            GameOver();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Reset jump ability when landing on a flat surface
        // Surface normal must be straight up, and angled surface will not work
        if(collision.contacts[0].normal == Vector3.up)
        {
            isGrounded = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void AddScore(int amount)
    {
        score += amount;
        ui.SetScoreText(score);
    }
}
