using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
     private Vector3 PositionOld;
    private Vector3 PositionNew;
    // Start is called before the first frame update
    void Start()
    {      PositionOld = new Vector3(0, 0, 0);
        PositionNew = new Vector3(0, 0, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) {
            PositionNew = Input.mousePosition;

            //In ra khoảng cách
float distance = Vector3.Distance(PositionOld, PositionNew);
Debug.Log("Khoang cach " + distance);

PositionOld = PositionNew;
         }
    }
}
