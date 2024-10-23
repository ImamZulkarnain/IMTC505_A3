using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaunterAppear : MonoBehaviour
{

    private Vector3 sizeChange, visibleSize;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        sizeChange = new Vector3(0.5f, 0.5f, 0.5f);
        visibleSize = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf && transform.localScale.z < 1)
        {
            transform.localScale += sizeChange * Time.deltaTime;
        }
        
    }
}
