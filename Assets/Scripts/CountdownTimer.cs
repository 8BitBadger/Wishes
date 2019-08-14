using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 60.0f;
    public Transform target;
    private float distanceFromTarget;
    float timeLeft;
    float distanceToTravelPerSecond;

    public int TimeLeft
    {
        get { return Mathf.RoundToInt(timeLeft); }
        //set { timeLeft = value; }
    }

    private void Start()
    {
        distanceToTravelPerSecond = startTime / Vector2.Distance(transform.position, target.position);
        //time / distanceFromTarget = distanceFromTarget to travel to reach destination in the time requered
    }
    void Update()
    {
        startTime -= Time.deltaTime;
        transform.position = transform.position + new Vector3(0, transform.position.y + distanceToTravelPerSecond * Time.deltaTime, 0);
        //transform.Translate(Vector2.up * distanceToTravelPerSecond * Time.deltaTime);
    }

    void move()
    {

    }
}