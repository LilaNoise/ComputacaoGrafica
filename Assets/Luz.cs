using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    float speed = 10f;


   void Start()
    {
 
    }

    void Update()
    {
        if (transform.eulerAngles.x <= 160)
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
