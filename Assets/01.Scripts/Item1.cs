using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item1 : MonoBehaviour
{
    private float lifeTime = 6.0f;
    private float destroyTime = 0.1f;

    private void Update()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, destroyTime);
        }
    }
  
}
