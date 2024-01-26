using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float forwardInput;
    float steeringInput;
    public float forwardSpeed = 500;
    public float steeringSpeed = 200;
    Rigidbody2D rigidbody;
    public float maxSpeed = 200;
    public float pushForce = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidbody .AddTorque (steeringInput * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * forwardInput * forwardSpeed * Time.deltaTime;
        if(rigidbody .velocity.magnitude < maxSpeed )
        {
            rigidbody.AddForce(force);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MapBoundary"))
        {
        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tire"))
        {
            Vector2 collisionDirection = (collision.transform.position - transform.position).normalized;

            Vector2 pushDirection = -collisionDirection;

            rigidbody.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
        }
    }

}
