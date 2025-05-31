using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balpan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            collision.gameObject.GetComponent<Player>().Dead();
        }
    }
}
