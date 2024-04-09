using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public int score = 0;
    public float horizontalInput;
    public float  verticalInput;
    public GameObject bullet;

    public Transform gunPosition;

    
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

        LookAtMouse();

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet,gunPosition.position ,Quaternion.identity);
        }
        
       
        
        
    }

    void FixedUpdate()
    {
         rb.velocity = new Vector3(horizontalInput * speed,0,verticalInput * speed);
    }   
    private void LookAtMouse()
    {

        Vector2 mousePos = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
         var angle = Mathf.Atan2( dir.x,dir.y)*Mathf.Rad2Deg;
         transform.rotation = Quaternion.AngleAxis(angle,Vector3.up);
        
        
       

    }
}
