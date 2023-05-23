using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ba : MonoBehaviour
{

    public GameObject txt;
    public bool inside = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inside)
        {
            txt.SetActive(true);

        }
        else
        {
            txt.SetActive(false);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inside = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
    }
}
