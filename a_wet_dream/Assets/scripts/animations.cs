using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    public titles_oncollision toc;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        toc = GameObject.FindObjectOfType<titles_oncollision>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (toc.theshipt == true)
        {
            anim.SetBool("ship", true);

        }
        else if (toc.theshipt == false)
        {
            anim.SetBool("ship", false);

        }
    }
}
