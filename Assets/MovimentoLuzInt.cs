using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLuzInt : MonoBehaviour
{
    void Start()
    {
    }


    public float speed = 0.3f;
    void Update()
    {
        if (transform.position.x >= -1 && transform.position.z >1)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -1 && transform.position.z > 1)
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z <= 1)
            transform.Translate(Vector3.right * speed * Time.deltaTime);



    }
}
