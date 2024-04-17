using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision other)
{
    if(other.gameObject.CompareTag("Wall"))
    {
        Destroy(bulletPrefab);
    }
    if (other.gameObject.CompareTag("Enemy"))
    {
        
        Destroy(other.gameObject);
        Destroy(bulletPrefab);
    }
}
    void Update()
    {
        
    }
}
