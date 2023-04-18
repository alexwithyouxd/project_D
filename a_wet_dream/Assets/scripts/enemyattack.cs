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

    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;
    }

    private bool playerinsight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(bc.bounds.center + transform.right*range * transform.localScale.x, bc.bounds.size, 0, Vector2.left, 0, playerlayer);
        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(bc.bounds.center + transform.right * range * transform.localScale.x, bc.bounds.size);
    }
}
