using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical"); 
        transform.Rotate(0, 0, keyboardInput * speed * Time.deltaTime);
    }
}
