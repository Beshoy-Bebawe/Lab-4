using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Vector3 mousePos;
    Camera mainCam;
    Rigidbody rb;
    public float shootForce;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector3(direction.x, direction.z).normalized * shootForce;
        float rot = Mathf.Atan2(rotation.y ,rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,rot - 90 , 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
