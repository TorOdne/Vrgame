using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    private string combination;
    public bool correct = false;
    public AudioSource doorsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            
            combination = collision.gameObject.GetComponent<Cube>().combination;
            if (combination == "101010101")
            {
                correct = true;
                doorsound.Play(3);
            }
            
        }
    }
}
