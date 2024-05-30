using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private float lifeTime = 6.0f;

    private void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
