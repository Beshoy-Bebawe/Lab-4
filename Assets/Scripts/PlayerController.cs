using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public int score = 0;
    public float horizontalInput;
    public float  verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
         transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

    }
}
