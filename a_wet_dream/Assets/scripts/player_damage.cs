using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_damage : MonoBehaviour
{
    public int maxhealth;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ptakedamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            Debug.Log("player died");
            transform.position = new Vector3(10f, 200f, 1f);
        }
    }
}
