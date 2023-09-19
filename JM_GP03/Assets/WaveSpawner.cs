using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
   
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, delay);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
        
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(prefab, transform.position+RandomSpawnPosition(), transform.rotation);
    }

    void EndSpawner()
    {
        CancelInvoke();
    }

    private Vector3 RandomSpawnPosition()
    {
        Vector3 random = Vector3.zero;

        random.x = UnityEngine.Random.Range(10, 80);
        random.z = UnityEngine.Random.Range(10, 80);
        return random;
    }
}
