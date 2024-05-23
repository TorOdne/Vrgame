using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wheelchair : MonoBehaviour
{
    bool roll = false;
    bool squeakOnce = false;
    float timer = 0;

    public GameObject player;
    public float distance;
    public AudioSource squeak;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < distance)
        {
            roll = true;
        }
        if (roll)
        {
            gameObject.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 0.1f);
            if (squeakOnce != true)
            {
                squeak.Play();
                squeakOnce = true;
            }
            timer += Time.deltaTime;
            if (timer > 6)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
