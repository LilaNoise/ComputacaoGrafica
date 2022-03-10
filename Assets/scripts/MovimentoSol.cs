using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 0.5f;

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
}
}