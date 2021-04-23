using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupOfPeople : MonoBehaviour
{
    
    public static bool enteredGroup;

    void Start()
    {
        enteredGroup = false;
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enteredGroup = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enteredGroup = false;
    }

}
