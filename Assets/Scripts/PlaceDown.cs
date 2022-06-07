using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDown : MonoBehaviour
{
    public string letter;
    public Animator anim;

    void OnCollisionEnter(Collision collision)
    {
        //if (cube.tag == ("Cube" + letter))
        //{
        //    Debug.Log("a");
        //}

        if (collision.gameObject.name == ("Cube" + letter))
        {
            anim.SetBool(letter, true);
        }
    }
}
