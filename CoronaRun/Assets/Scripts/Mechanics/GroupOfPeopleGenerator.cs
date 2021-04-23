using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupOfPeopleGenerator : MonoBehaviour
{
   
    public GameObject groupOfPeoplePrefab;

    void Start()
    {
        GenerateInstances();
    }


    private void GenerateInstances()
    {
        Instantiate(groupOfPeoplePrefab, new Vector2(8f, -0.35f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(8.9f, -0.35f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(27f, -1.55f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(28.2f, -1.55f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(40f, -1.6f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(45f, -5.2f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(46.2f, -5.2f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(55f, -4.4f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(69f, -6.8f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(75f, -6.8f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(76.2f, -6.8f), Quaternion.identity);


        Instantiate(groupOfPeoplePrefab, new Vector2(111f, -7.2f), Quaternion.identity);

        Instantiate(groupOfPeoplePrefab, new Vector2(132f, -8f), Quaternion.identity);
        Instantiate(groupOfPeoplePrefab, new Vector2(133.5f, -8f), Quaternion.identity);

    }

    
}
