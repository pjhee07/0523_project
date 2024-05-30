using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    public float spwanTime;
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
            int randomIndex = Random.Range(0, prefabs.Length);
            GameObject randomPrefab = prefabs[randomIndex];

            Instantiate(randomPrefab, transform.position, Quaternion.Euler(spawnRotation));
            yield return new WaitForSeconds(spwanTime);
        }
       
    }
}
