using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    public float spwanTime = 2.0f;
    public Vector3 spawnRotation;

    private void Start()
    {
        StartCoroutine(SpawnPrefab1());

    }
    private void Update()
    {
    }
    IEnumerator SpawnPrefab1()
    {
        while (true)
        {
            Instantiate(prefab1, transform.position, Quaternion.Euler(spawnRotation));
            yield return new WaitForSeconds(spwanTime);
        }
       
    }
}
