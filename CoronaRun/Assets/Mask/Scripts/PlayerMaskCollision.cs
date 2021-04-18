using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMaskCollision : MonoBehaviour {
    [SerializeField] private Text timerText = null; //reference to the timer on the screen
    private float maskTimer; //timer to count from 10 to 0
    
    // Start is called before the first frame update
    void Start() {
        maskTimer = 0; //default value 0 cause you don't have a mask yet
        timerText.text = ""; //timer not visible, same reason.
    }

    // Update is called once per frame
    void Update() {
        if (maskTimer > 0) { //checking if it's greater than zero, that means you have a mask and we should count down.
            maskTimer -= Time.deltaTime; //decreasing the time(countdown)
            timerText.text = maskTimer.ToString("0.0"); //displaying left time on the screen ("0.0") means just one num after .
        }
    }

    private void OnTriggerEnter2D(Collider2D other) { //checking for collisions
        if (other.tag.Equals("Mask")) { //checking if the object we collided with is a mask
            maskTimer = 10; //setting the timer to 10
            timerText.text = maskTimer.ToString("0.0"); //showing it to the screen
            Destroy(other.gameObject); //destroying the mask.
        }
    }
}
