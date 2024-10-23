using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : MonoBehaviour
{
    public GameObject pikachu;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        pikachu.SetActive(false);
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            transform.Translate(new Vector3(0, -0.5f, 0f) * Time.deltaTime);

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
            this.gameObject.SetActive(false);
        }
    }
}
