using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform[] positions;
    public float speed;
    private int c;
    private float dist;
    private bool end = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "MONKEY")
        {
            transform.Rotate(0f, 1f, 0f, Space.Self);
        }
        if (gameObject.name == "PENGUIN")
        {
            transform.Rotate(1f, 0f, 0f, Space.Self);
        }
        if (gameObject.name == "RABBIT")
        {
            transform.Rotate(0f, 0f, 1f, Space.Self);
        }

        if (c < positions.Length && end == false)
        {
            float x = positions[c].position.x;
            float z = positions[c].position.z;
            positions[c].position = new Vector3(x, transform.position.y, z);
            movePath(positions[c]);
        }
        else if (c < positions.Length && end)
        {
            c +=+ 1;
            end = false;
        }
        else
        {
            end = true;
        }
    }
    private void movePath(Transform po)
    {
        float x = transform.position.x - po.position.x;
        float z = transform.position.z - po.position.z;

        float disEucl = Mathf.Sqrt(x * x + z * z);
        dist = disEucl;
        if (dist > 0.05f)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, po.position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else end = true;
    }
}