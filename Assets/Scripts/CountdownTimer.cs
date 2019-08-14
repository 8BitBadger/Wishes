using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 3.0f;
    float timeLeft;

    public int TimeLeft
    {
        get { return Mathf.RoundToInt(timeLeft); }
        //set { timeLeft = value; }
    }
    void Update()
    {
        startTime -= Time.deltaTime;
    }
}