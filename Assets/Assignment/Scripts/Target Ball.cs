using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer mainBallRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainBallRenderer = GameObject.FindWithTag("MainBall").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChangeMainBallColor(Color color)
    {
        mainBallRenderer.color = color;
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("MainBall"))
        {
            Debug.Log("Main ball collided with target ball!");

            Vector2 impactDirection = collision.relativeVelocity.normalized;
            float impactForce = collision.relativeVelocity.magnitude;

            MoveWithImpact(impactDirection, impactForce);
            ChangeMainBallColor(Color.red);


        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        ChangeMainBallColor(Color.white);
    }

    private void MoveWithImpact(Vector2 direction, float force)
    {

        rb.AddForce(direction * force);
    }
}
