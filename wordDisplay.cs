using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wordDisplay : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countDownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}