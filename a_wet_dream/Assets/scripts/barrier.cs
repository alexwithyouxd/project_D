using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public float startValue;
    public float endValue;
    public float lerpTime = 1f;
    public bool triggered = false;

    [SerializeField] private float currentValue;
    private float timeElapsed;

    public GameObject barrier1;
    public GameObject barrier2;
    

    void Update()
    {
        if (triggered)
        {
            timeElapsed += Time.deltaTime;
            currentValue = Mathf.Lerp(startValue, endValue, timeElapsed / lerpTime);
            Vector3 currentPos = barrier1.transform.position;
            Vector3 currentpos2 = barrier2.transform.position;
            currentPos.y = currentValue;
            currentpos2.y = currentValue;
            barrier1.transform.position = currentPos;
            barrier2.transform.position = currentpos2;
        }

        Vector3 cp = transform.position;
        

        if (cp.y == -5f)
        {
            triggered = true;

            
        }
        
    }

   
}
