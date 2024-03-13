using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefab;

    public float minTime = 1f;
    public float maxTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRutine(0));
    }

    IEnumerator SpawnCoRutine(float waitTime)
    {
        yield return new WaitForSeconds(minTime);
        Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)], transform.position, Quaternion.identity);
        StartCoroutine(SpawnCoRutine(Random.Range(minTime, maxTime)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
