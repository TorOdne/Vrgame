using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    bool squeakOnce = false;

    public GameObject player;
    public float distance;
    public AudioSource squeak;
    public GameObject winnerThing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < distance)
        {
            if (squeakOnce != true)
            {
                squeak.Play();
                winnerThing.SetActive(true);

                squeakOnce = true;
            }
        }
    }
}
