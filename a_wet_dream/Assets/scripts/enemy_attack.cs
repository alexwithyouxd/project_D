using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    public enemy enemysct;
    public Transform attackpoint;
    public float attackradius = 1f;
    public LayerMask playerlayer;

    private float cooldowntimer = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        enemysct = GetComponent<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;
        attack();
    }

    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackpoint.position, attackradius);
    }

    void attack()
    {
        
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackradius, playerlayer);

        foreach (Collider2D enemy in hitenemies)
        {
            
            //Debug.Log("player dealt damage");
            //enemy.GetComponent<enemy>().takedamage(20);
            InvokeRepeating("debu", 5f, 2f);
        }
    }

    void debu()
    {
        Debug.Log("player dealt damage");
    }
}
