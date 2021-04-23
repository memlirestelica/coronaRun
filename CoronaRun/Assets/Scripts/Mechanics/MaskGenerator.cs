using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGenerator : MonoBehaviour
{
    public GameObject maskPrefab;
    
    private float x, y;

    void Start()
    {
      
        GenerateMasks();

    }

   

    private void GenerateMasks()
    {
        
            x = Random.Range(11f, 14f);
            y = 0f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(19f, 22f);
            y = 2f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(30f, 43f);
            y = 0f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(57f, 61f);
            y = -3f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(64f, 74f);
            y = 4f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(73f, 82f);
            y = -6f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = 98f;
            y = -4f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = 108f;
            y = -2f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(107f, 114f);
            y = -7f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);

            x = Random.Range(120f, 130f);
            y = -1f;
            Instantiate(maskPrefab, new Vector2(x, y), Quaternion.identity);
      
        
    }
}
