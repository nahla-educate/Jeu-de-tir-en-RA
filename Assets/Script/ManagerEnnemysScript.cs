using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ManagerEnnemysScript : MonoBehaviour
{
    public GameObject Virus;
    float rayon = 10f, delay = 0.5f, rangeY = 20f;


    void Start()
{
  
    InvokeRepeating("Generation", 0f, delay);

    } 
void Generation()
{
        int angle = Random.Range(1, 360);
        Vector3 pos = Vector3.zero;
        pos.x = transform.position.x + rayon * Mathf.Cos(angle);
        pos.z = transform.position.z + rayon * Mathf.Sin(angle);
        pos.y = Random.Range(-rangeY, rangeY);
        GameObject go = Instantiate(Virus, pos, Quaternion.identity);
    }
}
 
