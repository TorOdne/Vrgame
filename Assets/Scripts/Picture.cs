using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject player;

    public GameObject kindCap;

    public AudioSource scream;

    public float range = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kindCap.activeSelf)
        {
            if (Vector3.Distance(player.transform.position, gameObject.transform.position) < range)
            {
                kindCap.SetActive(false);
                scream.Play();
            }
        }
    }
}
