using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilaNoise : MonoBehaviour
{
    public Animator anim;
    public AudioSource som;
    public PlayerMovement player;
    private void Start()
    {

    }
    void OnTriggerEnter()
    {
        anim.SetBool("isOn", true);
        som.Play();
        gameObject.SetActive(false);
        player.enabled = !player.enabled;
    } 
}
