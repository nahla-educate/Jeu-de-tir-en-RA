using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3.0f, 9.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        // transform.Rotate(Vector2.up * 100f * Time.deltaTime); 
        
    }
}

