using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private Transform[] bulletSpawnPoints; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Transform SpawnPoint in bulletSpawnPoints)
            {
                Instantiate(bulletPrefab, SpawnPoint.position, transform.rotation);
            }
        }
    }
}
