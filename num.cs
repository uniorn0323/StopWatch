using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityEngine.UI;

public class num : MonoBehaviour
{
    public Sprite[] numberSprites = new Sprite[10];
    public Image[] digitImages; 
    
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        digitImages[0].sprite = numberSprites[timer.minutes / 10];
        digitImages[1].sprite = numberSprites[timer.minutes % 10];
        digitImages[2].sprite = numberSprites[timer.seconds / 10];
        digitImages[3].sprite = numberSprites[timer.seconds % 10];
        digitImages[4].sprite = numberSprites[timer.milliseconds / 10];
        digitImages[5].sprite = numberSprites[timer.milliseconds % 10];
    }
}
