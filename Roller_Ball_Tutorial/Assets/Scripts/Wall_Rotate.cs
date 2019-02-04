using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Rotate : MonoBehaviour {
    public float speed = 1.0f;
    public float step;
    Vector3 OA = new Vector3(110,0,0);
    Vector3 OB = new Vector3(110,0,9);
    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update ()
    {
        transform.position = Vector3.Lerp(OA,OB,Mathf.PingPong(Time.time,1));
    }
}
