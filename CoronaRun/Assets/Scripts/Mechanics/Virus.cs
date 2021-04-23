using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public static bool infected;

    void Start()
    {
        infected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        infected = true;
        Destroy(gameObject);

    }


}
