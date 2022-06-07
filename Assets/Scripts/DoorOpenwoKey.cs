using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenwoKey : MonoBehaviour
{
    public Animator anim;
    public AudioSource som;

    private void Start()
    {

    }
    void OnTriggerEnter()
    {
        anim.SetBool("isOpen", true);
        som.Play();
        gameObject.SetActive(false);
    }
}
