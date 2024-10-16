using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billiboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        transform.Rotate(new Vector3(0,0,90)); 
    }
}
