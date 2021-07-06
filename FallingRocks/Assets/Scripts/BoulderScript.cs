using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour
{
    public AudioSource explosion;

    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            explosion.Play();
            
        }
    }
}
