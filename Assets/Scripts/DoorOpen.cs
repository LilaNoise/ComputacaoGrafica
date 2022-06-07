using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject key;
    public Animator anim;

    AudioSource som;

    private void Start()
    {
        som = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            //gameObject.SetActive(false);
            key.SetActive(false);
            anim.SetBool("isOpen", true);
            som.Play();
        }            
    }


}
