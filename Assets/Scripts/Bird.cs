using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public Retry retry;
    public bool playerIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.isKinematic = true;
        retry = GameObject.FindGameObjectWithTag("Logic").GetComponent<Retry>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive) {
            retry.GameStart();
            myRigidBody.isKinematic = false;
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y < -16) {
            retry.GameOver();
            playerIsAlive = false;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Pipe")) {
            retry.GameOver();
            playerIsAlive = false;
        }
    }


}
