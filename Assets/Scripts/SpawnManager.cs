using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartSpawn();
        }
        

    }
    void StartSpawn()
    {
        Instantiate(enemyPrefab,new Vector3(Random.Range(minX,maxX),0.8f,Random.Range(minZ,maxZ)), enemyPrefab.transform.rotation);
    }

}
