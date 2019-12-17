using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject objectToSpawn;

    private void Awake()
    {
        createNewEgg();
    }
    void Start()
    {

    }

    void Update()
    {

    }

    public void createNewEgg()
    {
        Instantiate(objectToSpawn, getSpawnPosition());
    }

    public Transform getSpawnPosition()
    {
        return this.gameObject.transform.parent;
    }
}
