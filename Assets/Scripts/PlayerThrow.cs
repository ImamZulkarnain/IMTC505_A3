using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    public GameObject pokeBall, pikachu;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    void Update()
    {
        if (pokeBall.activeSelf && anim.enabled)
        {
           // pokeBall.transform.Translate(new Vector3(0, -0.2f, 0f) * Time.deltaTime);  

        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object the player collided with has the "Center" tag.
        if (other.gameObject.CompareTag("Center"))
        {
            // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);
            pikachu.SetActive(true);

            if (anim != null)
            {
                // stop animating
                anim.enabled = false;
            }
        }
    }
}
