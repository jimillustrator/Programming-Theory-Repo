using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMaker : MonoBehaviour
{
    public GameObject atom;

    private float spawnX;
    private float spawnY;
    private float spawnZ;

    private float atomSpawnTime;
    private float startDelay = 1.0f;


    void Start()
    {
        InvokeRepeating("SpawnAtoms", startDelay, atomSpawnTime);
    }

    void SpawnAtoms()
    {
        Vector3 spawnPos = new Vector3(spawnX, spawnY, spawnZ);

        Instantiate(atom, spawnPos, atom.transform.rotation);
    }
}
