using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float jumpForce;
    private Rigidbody rigidBody;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity += Vector3.up * jumpForce;
            thisAnimation.Play();
        }
        thisAnimation.Play();
        if(this.transform.position.y<=-4.5f)
        {
            GameManager.thisManager.GameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Obstacle")
        {
            GameManager.thisManager.GameOver();
        }
    }
}
