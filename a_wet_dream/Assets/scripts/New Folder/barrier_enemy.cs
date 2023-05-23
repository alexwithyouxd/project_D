using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_enemy : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemy.SetActive(true);
    }
}
