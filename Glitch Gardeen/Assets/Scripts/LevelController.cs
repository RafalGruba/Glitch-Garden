using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int NumberOfAttackers = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        NumberOfAttackers++;
    }
    public void AttackerKilled()
    {
        NumberOfAttackers--;
        if (NumberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End Level Now!");
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
