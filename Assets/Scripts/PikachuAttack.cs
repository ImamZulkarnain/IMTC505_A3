using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuAttack : MonoBehaviour
{
    public GameObject forest, graveyard;

    bool hit;
    float delay;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        hit = false;
        delay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hit) 
        {
            if (delay > 2) // after 2 seconds
            {
                transform.Translate(new Vector3(0, 1f, 0) * Time.deltaTime);
            }
        }
        else
        {
            if (delay > 2)
            {
                forest.SetActive(true);
                graveyard.SetActive(false);
            }

            if (delay < 0)
            {

            }
        }
        
        delay += (this.gameObject.activeSelf)? Time.deltaTime : 0;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object the player collided with has the "Center" tag.
        if (other.gameObject.CompareTag("Haunter"))
        {
            // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            hit = true;
            delay = 0;
        }
    }
}
