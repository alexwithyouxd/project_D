using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int maxhealth;
    [SerializeField]public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            Debug.Log("enemykilled");
            Destroy(this.gameObject);
        }
    }
}
