using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody thisrigidbody = null;
    private int force = 250;
    private Animation thisAnimation;

    void Start()
    {
        thisrigidbody = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisrigidbody.AddForce(Vector3.up * force);
            thisAnimation.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Block")
        {
            GameManager.thisManager.GameOver();
        }
    }
}
