using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("WOOHOO. I FOUND THE PLAYER");
        }

    }
}
