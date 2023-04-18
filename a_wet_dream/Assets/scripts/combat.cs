using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Animator anim;

    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemieslayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack();
        }
    }

    void attack()
    {
        anim.SetTrigger("attack");
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemieslayer);

        foreach (Collider2D enemy in hitenemies)
        {
            //Debug.Log("enemy dealt damage");
            enemy.GetComponent<enemy>().takedamage(20);
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);

    }
}
