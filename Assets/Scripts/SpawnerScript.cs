using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerScript : MonoBehaviour
{

    [System.Serializable]
    public struct SpawnObj
    {
        public GameObject obstacle;
        [Range(0f, 1f)] public float spwnChance;
    }

    public SpawnObj[] Obj;

    private float minSpwnRate = 1f;
    private float maxSpwnRate = 2f;

    private float spawnRate;

    private void OnEnable()
    {
        Invoke(nameof(Spawn), Random.Range(minSpwnRate, maxSpwnRate));
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Spawn()
    {
        spawnRate = Random.value;
        foreach(var obj in Obj)
        {
            if(obj.spwnChance > spawnRate)
            {
                GameObject Obs = Instantiate(obj.obstacle);
                Obs.transform.position += transform.position;
                break;
            }
            else
            {
                spawnRate -= obj.spwnChance;
            }
        }
        Invoke(nameof(Spawn), Random.Range(minSpwnRate, maxSpwnRate));
    }

}
