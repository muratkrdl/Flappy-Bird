using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float spawnDelay = 3f;
    [SerializeField] float spawnYRange = 8;

    [SerializeField] Transform pipeSpawnPoint;

    [SerializeField] GameObject pipePrefab;

    float selectedYPos;
    Vector2 selectedPos;

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnDelay);
            selectedYPos = Random.Range(-spawnYRange, spawnYRange + .01f);
            selectedPos = new Vector2(pipeSpawnPoint.position.x, selectedYPos);
            GameObject pipe = Instantiate(pipePrefab, transform);
            pipe.transform.position = selectedPos;
        }
    }

}
