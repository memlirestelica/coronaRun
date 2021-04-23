using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public static bool collected;

    void Start()
    {
        collected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collected = true;
        Destroy(gameObject);
        
    }


   



}
