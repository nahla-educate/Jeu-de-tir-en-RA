using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.up * 10, Color.red);
        if (Physics.Raycast(transform.position,transform.up*10, out hit, 10))
        {
            Debug.Log("le raycast touche un objet");
        }

    }
}
 