using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCameraManager : MonoBehaviour {

    public float downSpeed;
    void Start () {
  
    }
 
    //預設每秒執行50次
    void FixedUpdate () {
        transform.Translate(0, -downSpeed * Time.deltaTime, 0);
    }
}