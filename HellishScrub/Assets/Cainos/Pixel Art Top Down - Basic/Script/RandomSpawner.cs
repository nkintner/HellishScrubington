using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject PFPropsPotB;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11),0,Random.Range(-10,11));
            Instantiate(PFPropsPotB, randomSpawnPosition, Quaternion.identity);
        }
    }
}
