using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefabs;
    [SerializeField] float spawnPipeDelay = 3f;
    [SerializeField] float startGameDelay = 3f;
    [SerializeField] float ySpawnRange;
    [SerializeField] Vector2 newPipePoint;

    void Start() 
    {
        StartCoroutine(SpawnPipe());
    }

    IEnumerator SpawnPipe()
    {
        yield return new WaitForSeconds(startGameDelay);

        while(true)
        {
            newPipePoint.y = Random.Range(-ySpawnRange, ySpawnRange);

            var pipe = Instantiate(pipePrefabs);
            pipe.transform.position = newPipePoint;

            yield return new WaitForSeconds(spawnPipeDelay);
        }
    }

}
