using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Animator anim;

    public PauseMenu pm;

    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemieslayer;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PauseMenu>();

        if (pm == null)
        {
            Debug.LogError("PauseMenu script not found in the scene.");
        }
        //pm = GetComponent<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pm.isPaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                attack();
            }
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
