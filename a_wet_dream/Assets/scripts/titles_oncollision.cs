using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titles_oncollision : MonoBehaviour
{

    public bool theshipt = false;
    public GameObject theship;
    //public Animator anim;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("colliding");
        //anim.SetBool("ship", true);
        theshipt = true;
        //theship.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        theshipt = false;
        //anim.SetBool("ship", false);
        //theship.SetActive(false);
    }
}
