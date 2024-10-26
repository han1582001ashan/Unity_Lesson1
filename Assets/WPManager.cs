using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] targets;


    [SerializeField]
    private Slider HealthBar;
    [SerializeField]
    private Car1A car1A;
    List<Vector3> pathPoints= new List<Vector3>();
    void OnDrawGizmos(){
        if(pathPoints == null || pathPoints.Count<2){
            return;
        }
        for (int i=0; i<pathPoints.Count -1 ; i++){
            Gizmos.DrawLine(pathPoints[i], pathPoints[i+1]);
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
    public void UpdateHP(float hp){
        HealthBar.value=hp;
    }
}
