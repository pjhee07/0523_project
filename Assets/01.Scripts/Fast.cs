using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : MonoBehaviour
{
    [SerializeField] private int gamespeed;

    private void Start()
    {
        Time.timeScale = gamespeed;
    }
}
