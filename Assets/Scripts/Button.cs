using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool isPressed = false;
    Material material;
    public AudioSource audioSource;
    bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        Tick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tick()
    {
        if (isPressed)
        {
            material.color = Color.blue;
            isPressed = false;
            audioSource.Play();
        }
        else
        {
            material.color = Color.red;
            isPressed = true;
            if (first)
            {
                first = false;
            }
            else
            {
                audioSource.Play();
            }
            
        }
    }

    
}
