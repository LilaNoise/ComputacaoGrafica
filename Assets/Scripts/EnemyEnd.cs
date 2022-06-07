using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnd : MonoBehaviour
{
    public GameObject end;
    public GameObject cross;
    public PlayerMovement player;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.enabled = !player.enabled;
            cross.SetActive(false);
            end.SetActive(true);
        }
    }
}
