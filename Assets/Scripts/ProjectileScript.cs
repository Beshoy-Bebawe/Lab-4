using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    Rigidbody rigidbody2d;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Launch(Vector3 direction , float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

   
}
