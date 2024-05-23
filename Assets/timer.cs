using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    //  start time value
    [SerializeField] float startTime;

    //  current time
    float currentTime;

    //  wether the timer started?
    bool timerStarted = false;

    // logic current reached 0?

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
