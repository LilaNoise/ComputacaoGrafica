using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject key;
    void OnCollisionEnter()
    {
        if (key.tag == "Key")
        {
            gameObject.SetActive(false);
            key.SetActive(false);
        }            
    }


}
