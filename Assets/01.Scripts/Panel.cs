using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool active;

    public void Open()
    {
        if (active == false)
        {
            panel.gameObject.SetActive(true);
            active = true;
        }
        
    }
    public void Close()
    {
        if(active == true)
        {
            panel.gameObject.SetActive(false);
            active = false;
        }
    }
}
