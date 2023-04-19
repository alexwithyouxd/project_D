using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{

    public float attackcooldown;
    public float range;
    public int damage;
    public float cooldowntimer = Mathf.Infinity;


    public LayerMask playerlayer;


    public float colliderDistance;
    public BoxCollider2D bc;
    // Start is called before the first frame update

    private player_damage ph;


    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        ph = GetComponent<player_damage>();
    }





    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;
        if (playerinsight())
        {

            Debug.Log("player dealt damage");
            if (cooldowntimer >= attackcooldown)
            {
                cooldowntimer = 0;
                Debug.Log("player dealt damage");
                DamagePlayer();
               // anim.SetTrigger("meleeAttack");
            }
        }
    }

    private bool playerinsight()
    {
        RaycastHit2D hit =
           Physics2D.BoxCast(bc.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
           new Vector3(bc.bounds.size.x * range, bc.bounds.size.y, bc.bounds.size.z),
           0, Vector2.left, 0, playerlayer);

        if (hit.collider != null)
            ph = hit.transform.GetComponent<player_damage>();

        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(bc.bounds.center + transform.right * range * transform.localScale.x, bc.bounds.size);
    }

    private void DamagePlayer()
    {
        if (playerinsight())
            ph.ptakedamage(damage);
    }
}
