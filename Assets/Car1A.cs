using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UIElements;

public class Car1A : MonoBehaviour
{
  // Start is called before the first frame update
  public Vector3 AnglesRotate = new Vector3(0, 90, 0);
  public float rotationSpeed = 50f;
  [SerializeField] List<GameObject> wayLimitPoints;
  float speed = 2;
  int index = 0;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Vector3 destination = wayLimitPoints[index].transform.position;
    float distance = Vector3.Distance(transform.position, destination);

    Vector3 newpos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
   
    transform.position = newpos;
    Vector3 relativePos= wayLimitPoints[index].transform.position - transform.position; 


    Quaternion targetRotation = Quaternion.LookRotation(relativePos, Vector3.up);
    transform.rotation= Quaternion.Lerp(transform.rotation, targetRotation, 10* Time.deltaTime);
    

    if (distance <= 0.2)
    {
      if (index < wayLimitPoints.Count - 1)
      {
        index++;
// transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
      }
      else
      {
        index = 0;

      }
    }






  }



}

