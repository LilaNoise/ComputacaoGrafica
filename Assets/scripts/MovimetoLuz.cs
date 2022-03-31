using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentp : MonoBehaviour
{
    float speed;
    Vector3 target1;


    void Start()
    {
        
    }


    void Update()
    {
       if (transform.position.x >= 0)
      transform.position = new Vector3(-1, 3, 5);
    }

}
