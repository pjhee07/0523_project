using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    public float spwanTime = 2.0f;

    private void Start()
    {
        StartCoroutine(SpawnPrefab1());
    }
    IEnumerator SpawnPrefab1()
    {
        yield return new WaitForSecondsRealtime(spwanTime);

        Instantiate(prefab1, transform.position, Quaternion.identity);
    }
}
