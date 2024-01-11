using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speed = 5f;
    public GameObject prefab;
    public Transform barrel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Horizontal");
        transform.Translate(keyboardInput * speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, barrel.position, barrel.rotation);
        }
    }
}
