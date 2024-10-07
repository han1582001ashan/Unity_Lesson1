using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Car1A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h= Input.GetAxisRaw("Horizontal");
        
      gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z +0.02f );

        }
       
    }
