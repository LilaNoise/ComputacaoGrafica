using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Pick;

    AudioSource somP;
    public AudioSource somL;
    private void Start()
    {
        somP = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = Pick.position;
        this.transform.parent = GameObject.Find("Pick").transform;
        somP.Play();
    }

    //private void OnMouseUp()
    //{
    //    this.transform.parent = null;
    //    GetComponent<Rigidbody>().useGravity = true;
    //}

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;          
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        somL.Play();
    }

}
