using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hospital : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameStatus.goalReached = true;
        Victory.PauseGame();
        winScreen.gameObject.SetActive(true);
    }

}
