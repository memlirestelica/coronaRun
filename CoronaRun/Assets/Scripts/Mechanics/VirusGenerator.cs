using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGenerator : MonoBehaviour
{
    public GameObject virusPrefab;

    private float x, y;

    void Start()
    {
        
        GenerateMasks();

    }


    private void GenerateMasks()
    {
        
        x = Random.Range(11f, 14f);
        y = 0f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = Random.Range(30f, 43f);
        y = 0f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = 30f;
        y = 2f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = Random.Range(51f, 53f);
        y = -3f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = Random.Range(57f, 61f);
        y = -3f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = Random.Range(73f, 82f);
        y = -6f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = 75f;
        y = 3f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = Random.Range(97f, 100f);
        y = -6f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

        x = 110f;
        y = -4.5f;
        Instantiate(virusPrefab, new Vector2(x, y), Quaternion.identity);

    }
}
