using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Animator anim;
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.enabled)
        {
            transform.Translate(new Vector3(0, 0, 0.25f) * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object the player collided with has the "Center" tag.
        if (other.gameObject.CompareTag("Center"))
        {
            // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            if (anim != null)
            {
                // stop animating
                anim.enabled = false;
            }
        }
    }
}
