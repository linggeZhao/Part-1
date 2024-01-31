using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 3f; 
    public float leftBound = -5f; 
    public float rightBound = 5f;
    Vector2 direction = new Vector2(1, 0);

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }

    void MoveObstacle()
    {
        rigidbody.MovePosition(rigidbody.position + direction * moveSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction.x *= -1;
    }
}
