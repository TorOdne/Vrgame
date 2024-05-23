using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Cube : MonoBehaviour
{
    public GameObject[] buttons;

    public string combination;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Checkbuttons();
    }

    void Checkbuttons()
    {
        combination = "";
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Button>().isPressed)
            {
                combination += "1";
            }
            else
            {
                combination += "0";
            }
        }
    }
}
