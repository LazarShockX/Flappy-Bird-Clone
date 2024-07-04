using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 1.7f;
    public float yOffsetRange = 6.0f;
    private bool coroutineStarted = false;

    void Update()
    {
        // Start the coroutine when space bar is pressed and it hasn't been started yet
        if (Input.GetKeyDown(KeyCode.Space) && !coroutineStarted)
        {
            StartCoroutine(SpawnPipes());
            coroutineStarted = true; // Set the flag to true to prevent restarting the coroutine
        }
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float yOffset = Random.Range(-yOffsetRange, yOffsetRange);

            Vector3 spawnPosition = new(transform.position.x, transform.position.y + yOffset, transform.position.z);
            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
