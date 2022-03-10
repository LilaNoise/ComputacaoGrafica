using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    float speed = 10f;

    Color color1 = Color.yellow;
    Color color2 = Color.white;
    Color color3 = new Color(1.0f, 0.64f, 0.0f);

    Light luz;
    void Start()
    {
        luz = GetComponent<Light>();
    }

    void Update()
    {
        if (transform.eulerAngles.x <= 160)
            transform.Rotate(Vector3.right * Time.deltaTime * speed);


        float t = Mathf.PingPong(Time.time, speed) / speed;
        luz.color = Color.Lerp(color1, color2, t);

        if( transform.eulerAngles.x >= 80)
        luz.color = Color.Lerp(color2, color3, t);
    }
}
