using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] targets;
    List<Vector3> pathPoints= new List<Vector3>();
    void OnDrawGizmos(){
        if(pathPoints == null || pathPoints.Count<2){
            return;
        }
        for (int i=0; i<pathPoints.Count -1 ; i++){
            Gizmos.DrawLine(pathPoints[1], pathPoints[i+1]);
        }
    }

     public void ClearPathPoints()
    {
        pathPoints.Clear();
    }
    public void AddPathPoints(Vector3 pos)
    {
        pathPoints.Add(pos);
    }
}
