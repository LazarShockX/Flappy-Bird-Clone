using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + moveSpeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
