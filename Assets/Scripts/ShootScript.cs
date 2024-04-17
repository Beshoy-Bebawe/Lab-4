using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody rb;
    public Transform bulletTransform;

    public GameObject bullet;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;

    
    // Start is called before the first frame update
    void Start()
    {
     mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
     rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;
             if (timer > timeBetweenFiring)
             {
                canFire = true;
                timer = 0;

             }

        }
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            GameObject b = Instantiate(bullet,bulletTransform.position,Quaternion.identity);
             
        }
    }
    

    // Update is called once per frame
    public void Launch(Vector3 direction , float force)
    {
      
    }

   
}
