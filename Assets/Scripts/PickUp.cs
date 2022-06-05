using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Pick;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = Pick.position;
        this.transform.parent = GameObject.Find("Pick").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
