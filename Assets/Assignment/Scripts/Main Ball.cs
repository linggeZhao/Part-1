using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMainBaller : MonoBehaviour
{
    Vector2 direction;
    public float moveSpeed = 5f;
    Rigidbody2D rigidbody;
    public float force = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

        
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
