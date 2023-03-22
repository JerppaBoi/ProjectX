using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollideScript : MonoBehaviour
{
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gm.AddHealth(-1);
            Destroy(gameObject);
        }
    }
}
