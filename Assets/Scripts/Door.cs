using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject pedestal;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y !> -14)
        {
            if (pedestal.GetComponent<Pedestal>().correct)
            {
                OpenDoor();
                
            }
        }
    }

    public void OpenDoor()
    {
        gameObject.transform.Translate(new Vector3(0, 0.1f, 0) * Time.deltaTime);
    }
}
