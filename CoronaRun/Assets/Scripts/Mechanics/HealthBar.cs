using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    private Image currentTickBoxImage;
    private Image endLevel;
    private Image progression;

    private Image[] alwaysColoredImages = new Image[3];

    private Text endLevelText;
    private Text startLevelText;
    private Text currentTickBoxText;
    [SerializeField]
    private Text healthProgressMessage;

    private RectTransform currentTickBox;

    private Color color;
    private Color lerpedColor;

    public GameObject youLoseScreen;


    void Awake()
    {
        alwaysColoredImages[0] = base.transform.GetChild(0).GetComponent<Image>();
        alwaysColoredImages[1] = base.transform.GetChild(1).GetComponent<Image>();
        alwaysColoredImages[2] = base.transform.GetChild(2).GetComponent<Image>();

        endLevel = base.transform.GetChild(4).GetComponent<Image>();

        endLevelText = endLevel.transform.GetChild(0).GetComponent<Text>();
        startLevelText = base.transform.GetChild(3).GetChild(0).GetComponent<Text>();

        progression = base.transform.GetChild(2).GetChild(0).GetComponent<Image>();
        currentTickBox = base.transform.GetChild(2).GetChild(1).GetComponent<RectTransform>();
        currentTickBoxImage = currentTickBox.GetComponent<Image>();
        currentTickBoxText = currentTickBox.GetChild(0).GetComponent<Text>();

        color = new Color(0.3941795f, 0.8113208f, 0.6467058f, 1f);
        lerpedColor = Color.green;


    }
  
     

    void Update()
    {
        if (GroupOfPeople.enteredGroup || Virus.infected)
        {
            DecreaseHealth();
        }

        if (Mask.collected)
        {
            IncreaseHealth();
        }
        
        if (progression.fillAmount == 0)
        {
            youLoseScreen.gameObject.SetActive(true);
        }
        UpdateColors();

    }

    private void SetProgression(float percentage)
    {
        if (percentage > 1f)
        {
            progression.fillAmount = 1;
        }
        else
        {
            progression.fillAmount = percentage;
        }
        lerpedColor = Color.Lerp(Color.red, Color.green, percentage);
        currentTickBox.anchorMin = new Vector2(percentage, 0);
        currentTickBox.anchorMax = currentTickBox.anchorMin;
        currentTickBoxText.text = Mathf.RoundToInt(percentage * 100) + "%";
    }

    private void UpdateColors()
    {

        if (progression.fillAmount == 0)
        {
            endLevel.color = lerpedColor;
            endLevelText.color = Color.white;

            healthProgressMessage.text = "YOU LOST";
        }
        else
        {
            endLevel.color = Color.white;
            endLevelText.color = lerpedColor;

            healthProgressMessage.text = "HEALTH";
        }

        foreach (Image image in alwaysColoredImages)
        {
            image.color = Color.white;
        }

        progression.color = lerpedColor;
        currentTickBoxImage.color = lerpedColor;
    }

    private void DecreaseHealth()
    {
        if (progression.fillAmount > 0f)
        {
            if(Virus.infected && (progression.fillAmount - 0.2f) > 0f)
            {
                SetProgression(progression.fillAmount - 0.2f);
                Virus.infected = false;
            }
            else
            {
                SetProgression(progression.fillAmount - 0.006f);
            }
        }

        
    }

    private void IncreaseHealth()
    {
        if (progression.fillAmount < 1f && (progression.fillAmount+0.2f)<1f)
        {
            SetProgression(progression.fillAmount + 0.2f);
        }
        else
        {
            SetProgression(1);
        }
        Mask.collected = false;
        
    }
}
