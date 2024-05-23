using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    float timeSeconds = 0f;
    float timeMinutes = 0f;
    bool timeStarted = false;

    public float distance = 0.1f;
    public GameObject player;
    public TextMeshProUGUI text;
    public string preText;
    public GameObject disabled;
    // Start is called before the first frame update
    void Start()
    {
        timeStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStarted)
        {
            timeSeconds += Time.deltaTime;
            
            if (timeSeconds > 60f)
            {
                timeSeconds = 0f;
                timeMinutes += 1;
            }

            text.text = preText + timeMinutes + ":" + (int)timeSeconds;

            if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < distance)
            {
                timeStarted = false;
                if (disabled != null)
                {
                    disabled.SetActive(true);
                }
            }
        }
        
    }
}
