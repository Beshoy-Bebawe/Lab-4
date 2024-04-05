using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public int score = 0;
    public float horizontalInput;
    public float  verticalInput;

float mousePos;
     private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(verticalInput.mousePos);

       
        
        
    }

    void FixedUpdate()
    {
         rb.velocity = new Vector3(horizontalInput * speed,0,verticalInput * speed);
    }
}
